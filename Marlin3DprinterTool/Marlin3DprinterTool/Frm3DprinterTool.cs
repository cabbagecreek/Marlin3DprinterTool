using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Marlin3DprinterTool.Properties;
using Marlin3DprinterToolConfiguration;
using MarlinComunicationHelper;
using MarlinEditor;
using Microsoft.Win32;
using Nevron;
using Nevron.Chart;
using Nevron.Chart.Windows;
using Configuration = Marlin3DprinterToolConfiguration.Configuration;
using Cursor = System.Windows.Forms.Cursor;
using Position = Marlin3DprinterToolConfiguration.Position;


namespace Marlin3DprinterTool
{
    /// <summary>
    /// </summary>
    public partial class FrmMarlin3DprinterTool : Form
    {
        private readonly Configuration _configuration = new Configuration();

        private readonly Position _currectPosition = new Position();

        private readonly List<Position> _probePoints = new List<Position>();
        private readonly Stopwatch _temperatureStopwatch = new Stopwatch();

        private MarlinCommunication _com = new MarlinCommunication();
        

        private double _dockZprobePrecision;
        private bool _dockZprobeUpDown ;

        ///
        public FrmMarlin3DprinterTool()
        {
            InitializeComponent();
            Delegate = new DelegateAndInvoke(this);

        }

        /// <summary>
        ///     All Delegates, Callback and Invoke is in separate class
        /// </summary>
        private DelegateAndInvoke Delegate { set; get; }


        private void Frm3DprinterTool_Load(object sender, EventArgs e)
        {

            UpdateFrameHeader();
            AutoUpdaterDotNET();

            Delegate.DisableTabs(tabControl3DprinterTool, false);




            PopulateComboBoxes();
            PopulateConfig();
            fctbPidResponce.DescriptionFile = "MarlinCommunication.xml";
            fctbInit.DescriptionFile = "MarlinCommunication.xml";

        }

        private void AutoUpdaterDotNET()
        {
            
        }

        private void UpdateFrameHeader()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.ProductVersion;
            Text = $"Marlin3DprinterTool Version: {version}";
        }


        private void PopulateConfig()
        {
            rdoBn4point.Checked = _configuration.BedType == BedTypeEnum.FourPoint;
            rdoBn3pointLeft.Checked = _configuration.BedType == BedTypeEnum.ThreePointLeftSingle;
            rdoBn3pointFront.Checked = _configuration.BedType == BedTypeEnum.ThreePointFrontSingle;
            rdoBn3pointRight.Checked = _configuration.BedType == BedTypeEnum.ThreePointRightSingle;



            RedesignBedAdjusters();
            txtBxGcodeAssistZprobeEngage.Lines = _configuration.GcodeAssistZprobeEngage.ToArray();
            txtBxGcodeAssistZprobeRelease.Lines = _configuration.GcodeAssistZprobeRelease.ToArray();
            txtBxArduinoIDE.Text = _configuration.ArduinoIde;
            trkBrZmaxTravel.Value = _configuration.ZmaxTravel;
            numUpDnZmaxTravel.Value = _configuration.ZmaxTravel;
            txtBxZextraDistance.Text = _configuration.ZextraDistance;
            cmbBxZprobeXoffset.Text = _configuration.ZprobeXoffset;
            txtBxZprobeXoffset.Text = _configuration.ZprobeXoffsetValue;
            cmbBxZprobeYoffset.Text = _configuration.ZprobeYoffset;
            txtBxZprobeYoffset.Text = _configuration.ZprobeYoffsetValue;


            for (var i = 0; i < chkListBxAdjustment.Items.Count; i++)
            {
                if ((string) chkListBxAdjustment.Items[i] == _configuration.Adjuster)
                {
                    chkListBxAdjustment.SetItemChecked(i, true);
                }
            }
        }


        private void btnExtruderCalibrationCalculate_Click(object sender, EventArgs e)
        {
            _com.ExtrudeCalculationUpdate((int)numUpDnExtrude.Value, txtBxCurrentStepsPermm.Text,(int)numUpDnMeassure.Value);
        }


        private void trkBarTemperature_Scroll(object sender, EventArgs e)
        {
            numUpDnCalibrateExtruderTemp.Value = trkBarTemperature.Value;
        }

        private void NumUpDnCalibrateExtruderTemp_ValueChanged(object sender, EventArgs e)
        {
            trkBarTemperature.Value = (int) numUpDnCalibrateExtruderTemp.Value;
        }


        private void tabControl3DprinterTool_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabChanged();
           

        }

        private void TabChanged()
        {
            string selectedTab = DelegateAndInvoke.TabControl3DprinterToolSelected(tabControl3DprinterTool);


            if (selectedTab == tabPageEndstop.Name)
            {
                _com.Status = MarlinCommunication.Feature.EndStop;
                List<string> commands = new List<string> { "M0 P50","M119" };
                _com.SendCommand(commands);
            }
            else
            if (selectedTab == tabPageZoffset.Name)
            {
                _com.Status = MarlinCommunication.Feature.Done;
                
            }
            else
            if (selectedTab == tabPageConfigurationBed.Name)
            {
                _com.Status = MarlinCommunication.Feature.Bedlevel;
            }
            else
            if (selectedTab == tabPageConfigurationZprobe.Name)
            {
                _com.Status = MarlinCommunication.Feature.Done;
            }
            else
            if (selectedTab == tabPageScanSurface.Name)
            {
                _com.Status = MarlinCommunication.Feature.SurfaceScan;
            }
            else
            if (selectedTab == tabPagePID.Name)
            {
                _com.Status = MarlinCommunication.Feature.SurfaceScan;
            }
            else
            if (selectedTab == tabPageExtruderCalibration.Name)
            {
                _com.Status = MarlinCommunication.Feature.ExtruderCalibration;
            }
            else
            if (selectedTab == tabPageCalculations.Name)
            {
                _com.Status = MarlinCommunication.Feature.Done;
            }
            else
            if (selectedTab == tabPageParameters.Name)
            {
                _com.Status = MarlinCommunication.Feature.Done;
            }
            

           
        }


        private void _com_M114GetCurrentPosition(object sender, CurrentPosition currentPosition)
        {
            _currectPosition.X = currentPosition.Xdouble;
            _currectPosition.Y = currentPosition.Ydouble;
            _currectPosition.Z = currentPosition.Zdouble;

            // allways with decimalpoints
            DelegateAndInvoke.DelegateText(txtBxZprobePosition, _currectPosition.Zstring);
        }


       

        

        private void btnHomeZ_Click(object sender, EventArgs e)
        {
            _com.SendCommand(new List<string>(new[] {"G28 Z", "M114"}));
        }

        private void btnHomeY_Click(object sender, EventArgs e)
        {
            _com.SendCommand(new List<string>(new[] {"G28 Y", "M114"}));
        }

        private void btnHomeX_Click(object sender, EventArgs e)
        {
            _com.SendCommand(new List<string>(new[] {"G28 X", "M114"}));
        }

       


        private void btnProbeTheBed_Click(object sender, EventArgs e)
        {
            
            RedesignBedAdjusters();

            _com.Status = MarlinCommunication.Feature.Bedlevel;
            nChartControlSurface.Charts[0].Series.Clear();
            nChartControlSurface.Refresh();



           
            List<Position> probePointsList = new List<Position>();
            if (_configuration.BedType == BedTypeEnum.FourPoint)
            {
                probePointsList.Add( bedAdjusterFrontLeft.Position);
                probePointsList.Add( bedAdjusterFrontRight.Position);
                probePointsList.Add(bedAdjusterBackRight.Position);
                probePointsList.Add(bedAdjusterBackLeft.Position);
            }
            else
            if (_configuration.BedType ==   BedTypeEnum.ThreePointLeftSingle)
            {
                probePointsList.Add(bedAdjusterLeftSingle.Position);
                probePointsList.Add(bedAdjusterFrontRight.Position);
                probePointsList.Add(bedAdjusterBackRight.Position);
            }
            else
            if (_configuration.BedType ==   BedTypeEnum.ThreePointFrontSingle)
            {
                probePointsList.Add(bedAdjusterFrontSingle.Position);
                probePointsList.Add(bedAdjusterBackRight.Position);
                probePointsList.Add(bedAdjusterBackLeft.Position);
            }

            else
            if (_configuration.BedType == BedTypeEnum.ThreePointRightSingle)
            {
                probePointsList.Add(bedAdjusterRightSingle.Position);
                probePointsList.Add(bedAdjusterFrontLeft.Position);
                probePointsList.Add(bedAdjusterBackLeft.Position);

            }




            ScanSurface(probePointsList, 1);
        }

        private void ScanSurface(List<Position> probePointsList, int numberOfRepetitions)
        {
            var result = MessageBox.Show(@"Do you want to engare the Z-probe?", @"Engage Z-probe",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Cancel:
                    return;
                case DialogResult.OK:
                    var conf = new Configuration();
                    _com.SendCommand(conf.GcodeAssistZprobeEngage);
                    break;
            }


            
            var commands = new List<string> {"G28 Y", "G28 X", "G28 Z"};

            _probePoints.Clear();

            _com.ProbeResponceList = new List<Position>(); // Create a new probe responce list

            foreach (Position probePoint in probePointsList)
            {
                
                // move to X&Y
                commands.Add($"G1 X{probePoint.X}.0 Y{probePoint.Y}.0 Z{_configuration.ZextraDistance} F6000");
                //commands.Add("G1 Z40");

                for (var i = 0; i < numberOfRepetitions; i++)
                {
                    // probe the point
                    commands.Add("G30 S-1");
                    commands.Add($"G1 X{probePoint.X}.0 Y{probePoint.Y}.0 Z{_configuration.ZextraDistance} F6000");
                }
            }

            commands.Add($"G1 X{_configuration.SafeHome.X}.0 Y{_configuration.SafeHome.Y}.0 Z{_configuration.ZextraDistance} F6000");
            _com.SendCommand(commands);
        }


        private void ScanSurface(int numberOfXpoint, int numberOfYpoints, int numberOfRepetitions)
        {

            List<Position> probePointsList = new List<Position>();

            var xMin = (int) Convert.ToDecimal(_configuration.FrontLeftCorner.X);
            var xMax = (int) Convert.ToDecimal(_configuration.FrontRightCorner.X);
            var xStep = (xMax - xMin)/(numberOfXpoint - 1);

            var yMin = (int) Convert.ToDecimal(_configuration.FrontLeftCorner.Y);
            var yMax = (int) Convert.ToDecimal(_configuration.BackLeftCorner.Y);
            var yStep = (yMax - yMin)/(numberOfYpoints - 1);


            _probePoints.Clear();

            for (var y = yMin; y <= yMax; y += yStep)
            {
                for (var x = xMin; x <= xMax; x += xStep)
                {
                    
                    for (int repetition = 0; repetition < numberOfRepetitions; repetition++)
                    {
                        
                        probePointsList.Add(new Position{X = x,Y = y});    
                    }
                    
                }
            }

            ScanSurface(probePointsList, 1);
        }


        private void btnPayPal_Click(object sender, EventArgs e)
        {
            var url = "https://www.paypal.com/cgi-bin/webscr" +
                      @"?cmd=" + "_donations" +
                      @"&business=" + "cabbagecreek@gmail.com" +
                      @"&lc=" + "US" +
                      @"&item_name=" + "Marlin 3D printer Tool Donation" +
                      @"&amount=5" +
                      @"&currency_code=" + "USD" +
                      @"&bn=" + "PP%2dDonationsBF";

            Process.Start("IEXPLORE", url);
        }


        private void btnCreateExampleForZprobePosition_Click(object sender, EventArgs e)
        {
            txtBxGcodeAssistZprobeEngage.Lines = new[]
            {
                @"G90",
                @"G1 Z20",
                @"G91",
                @"G28 X",
                @"G1 X300"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBxGcodeAssistZprobeEngage.Lines = new[]
            {
                @"G90",
                @"G1 Z20",
                @"G91",
                @"G31"
            };
        }

        private void btnCreateExampleForZprobeServo_Click(object sender, EventArgs e)
        {
            //TODO:
            txtBxGcodeAssistZprobeEngage.Lines = new[]
            {
                @"G90",
                @"G1 Z20",
                @"G91",
                @"G31"
            };
        }

        private void btnAutoBedLevel_Click(object sender, EventArgs e)
        {
            var commands = new List<string> {"G28 Y", "G28 X", "G28 Z", "G29"};
            _com.Status = MarlinCommunication.Feature.AutoBedLevel;
            _com.SendCommand(commands);
        }


        private void btnTestZprobeEngage_Click(object sender, EventArgs e)
        {
            _com.SendCommand(new List<string>(txtBxGcodeAssistZprobeEngage.Lines));
        }


        private void UpdateZmaintDescription()
        {
            txtBxZmaintenanceDescription.Text = "";
            txtBxZmaintenanceDescription.Text +=
                $"Z max is {trackBarZmaintenanceMax.Value} and Z low is {trackBarZmaintenanceMin.Value}" +
                Environment.NewLine;
        }


        private void btnZmaintenanceRun_Click(object sender, EventArgs e)
        {
            var commands = new List<string> {"G28 Y", "G28 X", "G28 Z"};

            for (var i = 0; i < numUpDnZmaintenanceRepetitions.Value; i++)
            {
                commands.Add($"G1 Z{trackBarZmaintenanceMax.Value}"); // Max value
                commands.Add($"G1 Z{trackBarZmaintenanceMin.Value}"); // MIN VALUE
            }

            _com.SendCommand(commands);
        }

        private void btnZmaintenanceCancel_Click(object sender, EventArgs e)
        {
            Kill();
        }

        private void trkBrZmaxTravel_Scroll(object sender, EventArgs e)
        {
            numUpDnZmaxTravel.Value = trkBrZmaxTravel.Value;
        }

        private void numUpDnZmaxTravel_ValueChanged(object sender, EventArgs e)
        {
            trkBrZmaxTravel.Value = (int) numUpDnZmaxTravel.Value;
        }

        private void btnTestZprobeEngageSave_Click(object sender, EventArgs e)
        {
            _configuration.GcodeAssistZprobeEngage = new List<string>(txtBxGcodeAssistZprobeEngage.Lines);
        }

        private void btnTestZprobeReleaseSave_Click(object sender, EventArgs e)
        {
            _configuration.GcodeAssistZprobeRelease = new List<string>(txtBxGcodeAssistZprobeRelease.Lines);
        }

        private void btnTestZprobeRelease_Click(object sender, EventArgs e)
        {
            _com.SendCommand(new List<string>(txtBxGcodeAssistZprobeRelease.Lines));
        }


        private void btnSaveArduinoIDE_Click(object sender, EventArgs e)
        {
            _configuration.ArduinoIde = txtBxArduinoIDE.Text;
        }


        //TOFO: Tabort
        //private void btnSaveAdjustment_Click(object sender, EventArgs e)
        //{
        //    foreach (var item in chkListBxAdjustment.CheckedItems)
        //    {
        //        _configuration.Adjuster = (string) item;
        //        break;
        //    }


        //}

        private void chkListBxAdjustment_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (var ix = 0; ix < chkListBxAdjustment.Items.Count; ++ix)
                    if (e.Index != ix) chkListBxAdjustment.SetItemChecked(ix, false);
        }

        private void btnZmaxTravel_Click(object sender, EventArgs e)
        {
            _configuration.ZmaxTravel = (int) numUpDnZmaxTravel.Value;
        }


        private void btnShowCommunication_Click_2(object sender, EventArgs e)
        {

            _com.Showform = FrmShowCommunication.InstanceFrmShowForm;
            _com.Showform.Communication = _com;
        }


        

        #region Pupulating Form

        private void PopulateComboBoxes()
        {


            cmbBxLeadScrewMotorStepAngle.Items.Clear();
            cmbBxLeadScrewMotorStepAngle.Items.Add(new ComboboxItemTextValue {Text = @"1.8°", Value = (int) (360.0/1.8)});
            cmbBxLeadScrewMotorStepAngle.Items.Add(new ComboboxItemTextValue {Text = @"0.9°", Value = (int) (360.0/0.9)});
            cmbBxLeadScrewMotorStepAngle.Items.Add(new ComboboxItemTextValue {Text = @"7.5°", Value = (int) (360.0/7.5)});
            cmbBxLeadScrewMotorStepAngle.Text = @"1.8°";

            cmbBxLeadScrewDriverMicrostepping.Items.Clear();
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1    - Full step",
                Value = (float) (1/(1.0/1.0))
            });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/2  - Half step",
                Value = (float) (1/(1.0/2.0))
            });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/4  - Quarter step",
                Value = (float) (1/(1.0/4.0))
            });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/8  - Micro step",
                Value = (float) (1/(1.0/8.0))
            });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/16 - Micro step",
                Value = (float) (1/(1.0/16.0))
            });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/32 - Micro step",
                Value = (float) (1/(1.0/32.0))
            });
            cmbBxLeadScrewDriverMicrostepping.Text = @"1/16 - Micro step";

            cmbBxLeadScrewPitch.Items.Clear();
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"M8 - Metric (1.25mm / revolution)",
                Value = (float) (1.25)
            });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"M6 - Metric (1.00mm / revolution)",
                Value = (float) (1.00)
            });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"M5 - Metric (0.80mm / revolution)",
                Value = (float) (0.80)
            });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"5/16-18 imperial coarse (1.41111mm / revolution)",
                Value = (float) (1.41111)
            });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/4-16 - Acme (1.5875mm / revolution",
                Value = (float) (1.5875)
            });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"8mm Trapezoidal Threaded (2.00mm / revolution",
                Value = (float) (2.00)
            });
            cmbBxLeadScrewPitch.Text = @"8mm Trapezoidal Threaded (2.00mm / revolution";

            cmbBxBeltMotorStepAngle.Items.Clear();
            cmbBxBeltMotorStepAngle.Items.Add(new ComboboxItemTextValue {Text = @"1.8°", Value = (int) (360.0/1.8)});
            cmbBxBeltMotorStepAngle.Items.Add(new ComboboxItemTextValue {Text = @"0.9°", Value = (int) (360.0/0.9)});
            cmbBxBeltMotorStepAngle.Items.Add(new ComboboxItemTextValue {Text = @"7.5°", Value = (int) (360.0/7.5)});
            cmbBxBeltMotorStepAngle.Text = @"1.8°";

            cmbBxBeltDriverMicrostepping.Items.Clear();
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1    - Full step",
                Value = (float) (1/(1.0/1.0))
            });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/2  - Half step",
                Value = (float) (1/(1.0/2.0))
            });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/4  - Quarter step",
                Value = (float) (1/(1.0/4.0))
            });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/8  - Micro step",
                Value = (float) (1/(1.0/8.0))
            });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/16 - Micro step",
                Value = (float) (1/(1.0/16.0))
            });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue
            {
                Text = @"1/32 - Micro step",
                Value = (float) (1/(1.0/32.0))
            });
            cmbBxBeltDriverMicrostepping.Text = @"1/16 - Micro step";

            cmbBxBeltPitch.Items.Clear();
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue {Text = @"2mm   - Metric (GT2)", Value = (float) (2.00)});
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue {Text = @"2.5mm - Metric (T2.5)", Value = (float) (2.50)});
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"3mm   - Metric (GT2, HTD)",
                Value = (float) (3.00)
            });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"5mm   - Metric (T5,GT2, HTD)",
                Value = (float) (5.00)
            });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"MXL   - Inch   (2.03mm)",
                Value = (float) (2.03)
            });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue
            {
                Text = @"XL    - Inch   (5.08mm)",
                Value = (float) (5.08)
            });
            cmbBxBeltPitch.Text = @"2mm   - Metric (GT2)";

            try
            {
                //var serialPorts = _com.GetExistingSerialPorts();
                var serialPorts = _com.GetExistingSerialPorts();
                cmbBxComPort.Items.Clear();
                if (serialPorts.Length == 1) cmbBxComPort.Text = serialPorts[0];
                foreach (var serialPort in serialPorts)
                {
                    cmbBxComPort.Items.Add(serialPort);
                }
                cmbBxComPort.Text = _configuration.ComPort;
                cmbBxBaud.Text = _configuration.Baudrate;
            }
            catch (Exception)
            {
                cmbBxComPort.Text = @"No Comport found!";
            }


            cmbBxPidExtruder.Items.Clear();
            cmbBxPidExtruder.Items.Add(new ComboboxItemTextValue { Text = @"First Extruder  (0)", Value = 0});
            cmbBxPidExtruder.Items.Add(new ComboboxItemTextValue { Text = @"Secund Extruder (1)", Value = 1 });
            cmbBxPidExtruder.Items.Add(new ComboboxItemTextValue { Text = @"Third Extruder  (2)", Value = 2 });
            cmbBxPidExtruder.Items.Add(new ComboboxItemTextValue { Text = @"Fourth Extruder (3)", Value = 3 });
            cmbBxPidExtruder.SelectedIndex = 0;


            cmbBxExtruderCalibration.Items.Clear();
            cmbBxExtruderCalibration.Items.Add(new ComboboxItemTextValue { Text = @"First Extruder  (0)", Value = 0 });
            cmbBxExtruderCalibration.Items.Add(new ComboboxItemTextValue { Text = @"Secund Extruder (1)", Value = 1 });
            cmbBxExtruderCalibration.Items.Add(new ComboboxItemTextValue { Text = @"Third Extruder  (2)", Value = 2 });
            cmbBxExtruderCalibration.Items.Add(new ComboboxItemTextValue { Text = @"Fourth Extruder (3)", Value = 3 });
            cmbBxExtruderCalibration.SelectedIndex = 0;
        }

        #endregion

        private void trackBarZmaintenanceMin_Scroll(object sender, EventArgs e)
        {
            UpdateZmaintDescription();
        }

        private void trackBarZmaintenanceMax_Scroll(object sender, EventArgs e)
        {
            UpdateZmaintDescription();
        }

        private void numUpDnZmaintenanceRepetitions_ValueChanged(object sender, EventArgs e)
        {
            UpdateZmaintDescription();
        }


        private void btnEngageZprobeScanSurface_Click(object sender, EventArgs e)
        {
            var conf = new Configuration();
            _com.SendCommand(conf.GcodeAssistZprobeEngage);
        }

        private void btnScanSurface_Click(object sender, EventArgs e)
        {
            
            nChartControlSurface.Charts[0].Series.Clear();
            nChartControlSurface.Refresh();

            ScanSurface((int) numUpDownXpoints.Value, (int) numUpDownYpoints.Value,
                (int) numUpDownNumberOfRepetitions.Value);
        }

        private void chkBxColdExtruderCalibration_CheckedChanged(object sender, EventArgs e)
        {
            trkBarTemperature.Visible = !chkBxColdExtruderCalibration.Checked;
            numUpDnCalibrateExtruderTemp.Visible = !chkBxColdExtruderCalibration.Checked;
            btnHeatExtruderForCalibration.Visible = !chkBxColdExtruderCalibration.Checked;
            chartTemperature.Visible = !chkBxColdExtruderCalibration.Checked;
            grpBxTestExtrude.Visible = chkBxColdExtruderCalibration.Checked;
            
        }


        private void btnExtruderCalibation_Click(object sender, EventArgs e)
        {
            _com.Status = MarlinCommunication.Feature.ExtruderCalibrationTest;
            var extrudeCalibration = new List<string> {"M503"};


            if (chkBxColdExtruderCalibration.Checked)
            {
                extrudeCalibration.Add("M302"); // Allow cold extrusion
            }

            var comboboxItemTextValue = cmbBxExtruderCalibration.SelectedItem as ComboboxItemTextValue;


            if (comboboxItemTextValue != null)
            {
                extrudeCalibration.Add($"T{comboboxItemTextValue.ToValue()}");
            }

            extrudeCalibration.Add("G91");
            extrudeCalibration.Add($"G1 E{numUpDnExtrude.Value} F100");
            extrudeCalibration.Add("G90");
            _com.SendCommand(extrudeCalibration);
        }

        private void Frm3DprinterTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_com.IsPortOpen) _com.DisConnect();
        }

        private void btnHeatExtruderForCalibration_Click(object sender, EventArgs e)
        {
            _com.Status = MarlinCommunication.Feature.ExtruderCalibration;
            var commands = new List<string>();


            if (chartTemperature.Series.IndexOf("Extruder") == -1)
            {
                chartTemperature.Series.Add("Extruder");
                chartTemperature.Series["Extruder"].ChartType = SeriesChartType.Spline;
                chartTemperature.Series["Extruder"].Color = Color.Red;
                chartTemperature.Series["Extruder"].BorderWidth = 3;
                chartTemperature.Series["Extruder"].BorderDashStyle = ChartDashStyle.Solid;
                chartTemperature.Series["Extruder"].Points.Clear();
            }
            if (chartTemperature.Series.IndexOf("SetExtruder") == -1)
            {
                chartTemperature.Series.Add("SetExtruder");
                chartTemperature.Series["SetExtruder"].ChartType = SeriesChartType.Spline;
                chartTemperature.Series["SetExtruder"].Color = Color.Blue;
                chartTemperature.Series["SetExtruder"].BorderWidth = 3;
                chartTemperature.Series["SetExtruder"].BorderDashStyle = ChartDashStyle.Dash;
                chartTemperature.Series["SetExtruder"].Points.Clear();
            }
            
            

            

            
            

            
            
            
            


            _temperatureStopwatch.Reset();
            _temperatureStopwatch.Start();


            //SENT: M109 S195 T0
            var extruder = cmbBxExtruderCalibration.SelectedItem as ComboboxItemTextValue;

            if (extruder != null)
            {
                commands.Add($"M109 S{Convert.ToDouble(numUpDnCalibrateExtruderTemp.Value)} T{extruder.ToValue()}");

                _com.SendCommand(commands);
            }
        }




        private void Kill()
        {
            _com.Kill = true;
            
        }

        private void btnCalculateExtruderPid_Click(object sender, EventArgs e)
        {
            _com.Status = MarlinCommunication.Feature.AutoPidTuneExtruder;
            fctbPidResponce.Text = "";


            
            if (chartTemperature.Series.IndexOf("Extruder") == -1)
            {
                
                chartTemperature.Series.Add("Extruder");
                chartTemperature.Series["Extruder"].ChartType = SeriesChartType.Spline;
                chartTemperature.Series["Extruder"].Color = Color.Red;
                chartTemperature.Series["Extruder"].BorderWidth = 3;
                chartTemperature.Series["Extruder"].BorderDashStyle = ChartDashStyle.Solid;
                chartTemperature.Series["Extruder"].Points.Clear();
            }
            if (chartTemperature.Series.IndexOf("SetExtruder") == -1)
            {
                chartTemperature.Series.Add("SetExtruder");
                chartTemperature.Series["SetExtruder"].ChartType = SeriesChartType.Spline;
                chartTemperature.Series["SetExtruder"].Color = Color.Blue;
                chartTemperature.Series["SetExtruder"].BorderWidth = 3;
                chartTemperature.Series["SetExtruder"].BorderDashStyle = ChartDashStyle.Dash;
                chartTemperature.Series["SetExtruder"].Points.Clear();
            }
            



            _com.ClearCommunication();
            var comboboxItemTextValue = cmbBxPidExtruder.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null)
            {
                _com.SendCommand($"M303 E{(int) comboboxItemTextValue.ToValue()} S{numUpDownPidExtruderTemp.Value} C{numUpDownPidExtruderCykles.Value}");
            }
        }

       

        private void tabPageEndstop_Click(object sender, EventArgs e)
        {
        }

        private void btnRetractZprobe_Click(object sender, EventArgs e)
        {
            var conf = new Configuration();
            _com.SendCommand(conf.GcodeAssistZprobeRelease);
        }

        private void trkBarPidExtruderTemp_Scroll(object sender, EventArgs e)
        {
            numUpDownPidExtruderTemp.Value = trkBarPidExtruderTemp.Value;
        }

        private void numUpDownPidExtruderTemp_ValueChanged(object sender, EventArgs e)
        {
            trkBarPidExtruderTemp.Value = (int) numUpDownPidExtruderTemp.Value;
        }

        private void numUpDownPidExtruderCykles_ValueChanged(object sender, EventArgs e)
        {
            trkBarPidExtruderCykles.Value = (int) numUpDownPidExtruderCykles.Value;
        }

        private void trkBarPidExtruderCykles_Scroll(object sender, EventArgs e)
        {
            numUpDownPidExtruderCykles.Value = trkBarPidExtruderCykles.Value;
        }

        private void trkBarPidBedTemp_Scroll(object sender, EventArgs e)
        {
            numUpDownPidBedTemp.Value = trkBarPidBedTemp.Value;
        }

        private void btnCalculateBedPid_Click(object sender, EventArgs e)
        {
            _com.Status = MarlinCommunication.Feature.AutoPidTuneBed;
            if (chartTemperature.Series.IndexOf("Bed") == -1)
            {
               chartTemperature.Series.Add("Bed");
                chartTemperature.Series["Bed"].ChartType = SeriesChartType.Spline;
                chartTemperature.Series["Bed"].Color = Color.Red;
                chartTemperature.Series["Bed"].BorderWidth = 3;
                chartTemperature.Series["Bed"].BorderDashStyle = ChartDashStyle.Solid;
                chartTemperature.Series["Bed"].Points.Clear();
            }
            if (chartTemperature.Series.IndexOf("SetBed") != -1)
            {
                chartTemperature.Series.Add("SetBed");
                chartTemperature.Series["SetBed"].ChartType = SeriesChartType.Spline;
                chartTemperature.Series["SetBed"].Color = Color.Blue;
                chartTemperature.Series["SetBed"].BorderWidth = 3;
                chartTemperature.Series["SetBed"].BorderDashStyle = ChartDashStyle.Dash;
                chartTemperature.Series["SetBed"].Points.Clear();
            }
           

            fctbPidResponce.Text = "";
            _com.SendCommand($"M303 E-1 S{numUpDownPidBedTemp.Value} C{numUpDownPidBedCykles.Value}");
        }

        private void numUpDownPidBedCykles_ValueChanged(object sender, EventArgs e)
        {
            trkBarPidBedCykles.Value = (int) numUpDownPidBedCykles.Value;
        }

        private void trkBarPidBedCykles_Scroll(object sender, EventArgs e)
        {
            numUpDownPidBedCykles.Value = trkBarPidBedCykles.Value;
        }

        private void numUpDownPidBedTemp_ValueChanged(object sender, EventArgs e)
        {
            trkBarPidBedTemp.Value = (int) numUpDownPidBedTemp.Value;
        }

        private void btnFirmware_Click(object sender, EventArgs e)
        {

            FrmMarlinEditor marlinEditor = new FrmMarlinEditor();
            marlinEditor.Show();



        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            Kill();
        }

        private void btnZprobeFirmwareUpdate_Click(object sender, EventArgs e)
        {

            //TODO: 
            //_com.Firmware = FrmFirmware.InstanceFrmFirmware;

            //// The found offset has wrong sing. Cahnge positive to negative
            //var calcZProbeOffset = Convert.ToDecimal(txtBxCalculatedZProbeOffset.Text)*-1;

            //// round to to decimals
            //var round = decimal.Round(calcZProbeOffset, 2);

            //// Format the round to a string with 2 decimals and decimalpoint. (Not decimal =, )
            ////TODO: _com.Firmware.UpdateZprobeOffset($"{round:0.00}".Replace(",", "."));
        }

        #region Communication

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!_com.IsPortOpen)
            {
                try
                {
                    _com = new MarlinCommunication
                    {
                        BaudRate = cmbBxBaud.Text,
                        Port = cmbBxComPort.Text,
                        Kill = false
                    };

                    _com.Connected += _com_Connected;
                    _com.Init += _com_Init;
                    _com.G29Responce += _com_G29Responce;
                    _com.G30ProbeResponce += _com_G30ProbeResponce;
                    _com.M48ProbeStatus += _com_M48ProbeStatus;
                    _com.Temperatures += _com_Temperatures;
                    _com.M114GetCurrentPosition += _com_M114GetCurrentPosition;
                    _com.M119EndStopStatus += _com_M119EndStopStatus;
                    _com.M301Responce += _com_M301Responce;
                    _com.M303Responce += _com_M303Responce;
                    _com.M304Responce += _com_M304Responce;
                    _com.M500Responce += _com_M500Responce;
                    _com.M501Responce += _com_M501Responce;
                    _com.M851Responce += _com_M851Responce;
                    _com.Sending += _com_Sending    ;
                    _com.CommandSequenceeDone += _com_CommandSequenceeDone;

                    _com.DisConnected += _com_DisConnected;


                    _com.Connect();

                    
                }
                catch (Exception serialException)
                {
                    MessageBox.Show(serialException.Message);
                }
            }

            else
            {
                try
                {
                    _com.Port = cmbBxComPort.Text;
                    _com.DisConnect();


                    btnConnect.Text = @"Connect";
                }
                catch (Exception serialException)
                {
                    btnConnect.Text = @"Connect";
                    MessageBox.Show(serialException.Message);
                }
            }
        }

        private void _com_Sending(object sender, EventArgs e)
        {
            var cursor  = (TypeOfCursor) e;
            DelegateAndInvoke.Cursor(cursor.CursorType);
        }

        private void _com_M851Responce(object sender, ResponceData m851Data)
        {
            DelegateAndInvoke.DelegateText(txtBxM851, m851Data.Data);
        }

        private void _com_M119EndStopStatus(object sender, EndStop e)
        {
            ledXmin.On = _com.EndStopStatus.Xmin;
            ledXmax.On = _com.EndStopStatus.Xmax;
            ledYmin.On = _com.EndStopStatus.Ymin;
            ledYmax.On = _com.EndStopStatus.Ymax;
            ledZmin.On = _com.EndStopStatus.Zmin;
            ledZmax.On = _com.EndStopStatus.Zmax;

            ledBulbZprobeGauge.On = _com.EndStopStatus.Zmin;
        }
       
        private void _com_CommandSequenceeDone(object sender, EventArgs e)
        {
            switch (_com.Status)
            {
                #region EndStop
                case MarlinCommunication.Feature.EndStop:
                    List<string> commands = new List<string> { "M0 P50","M119" };
                    _com.SendCommand(commands);
                    break;
                #endregion

                #region BedLevel
                case MarlinCommunication.Feature.Bedlevel:
                    // Calculate the turns on each corner
                    if (_com.ProbeResponceList != null)
                    {
                        foreach (var probeResponce in _com.ProbeResponceList)
                        {
                            _probePoints.Add(new Position
                            {
                                X = probeResponce.X,
                                Y = probeResponce.Y,
                                Z = probeResponce.Z
                            });


                            // Find control that match the X and Y
                            // Assign the Z
                            if ((Math.Abs(bedAdjusterBackLeft.X - probeResponce.X) < 50) &&
                                (Math.Abs(bedAdjusterBackLeft.Y - probeResponce.Y) < 50))
                            {
                                bedAdjusterBackLeft.Z = probeResponce.Z;
                            }

                            if ((Math.Abs(bedAdjusterBackRight.X - probeResponce.X) < 50) &&
                                (Math.Abs(bedAdjusterBackRight.Y - probeResponce.Y) < 50))
                            {
                                bedAdjusterBackRight.Z = probeResponce.Z;
                            }

                            if ((Math.Abs(bedAdjusterFrontLeft.X - probeResponce.X) < 50) &&
                                (Math.Abs(bedAdjusterFrontLeft.Y - probeResponce.Y) < 50))
                            {
                                bedAdjusterFrontLeft.Z = probeResponce.Z;
                            }

                            if ((Math.Abs(bedAdjusterFrontRight.X - probeResponce.X) < 50) &&
                                (Math.Abs(bedAdjusterFrontRight.Y - probeResponce.Y) < 50))
                            {
                                bedAdjusterFrontRight.Z = probeResponce.Z;
                            }

                            if ((Math.Abs(bedAdjusterLeftSingle.X - probeResponce.X) < 50) &&
                                (Math.Abs(bedAdjusterLeftSingle.Y - probeResponce.Y) < 50))
                            {
                                bedAdjusterLeftSingle.Z = probeResponce.Z;
                            }

                            if ((Math.Abs(bedAdjusterFrontSingle.X - probeResponce.X) < 50) &&
                                (Math.Abs(bedAdjusterFrontSingle.Y - probeResponce.Y) < 50))
                            {
                                bedAdjusterFrontSingle.Z = probeResponce.Z;
                            }

                            if ((Math.Abs(bedAdjusterRightSingle.X - probeResponce.X) < 50) &&
                                (Math.Abs(bedAdjusterRightSingle.Y - probeResponce.Y) < 50))
                            {
                                bedAdjusterRightSingle.Z = probeResponce.Z;
                            }






                            double fixedPoint;

                            switch (_configuration.BedType)
                            {
                                case BedTypeEnum.FourPoint:
                                    fixedPoint = bedAdjusterBackRight.Z;

                                    bedAdjusterBackRight.Fix = fixedPoint;
                                    bedAdjusterBackRight.Calculate();

                                    bedAdjusterBackLeft.Fix = fixedPoint;
                                    bedAdjusterBackLeft.Calculate();

                                    bedAdjusterFrontLeft.Fix = fixedPoint;
                                    bedAdjusterFrontLeft.Calculate();

                                    bedAdjusterFrontRight.Fix = fixedPoint;
                                    bedAdjusterFrontRight.Calculate();

                                    break;



                                case BedTypeEnum.ThreePointLeftSingle:
                                    fixedPoint = bedAdjusterLeftSingle.Z;

                                    bedAdjusterLeftSingle.Fix = fixedPoint;
                                    bedAdjusterLeftSingle.Calculate();

                                    bedAdjusterBackRight.Fix = fixedPoint;
                                    bedAdjusterBackLeft.Calculate();

                                    bedAdjusterFrontRight.Fix = fixedPoint;
                                    bedAdjusterFrontRight.Calculate();

                                    break;



                                case BedTypeEnum.ThreePointFrontSingle:
                                    fixedPoint = bedAdjusterFrontSingle.Z;

                                    bedAdjusterFrontSingle.Fix = fixedPoint;
                                    bedAdjusterFrontSingle.Calculate();

                                    bedAdjusterBackRight.Fix = fixedPoint;
                                    bedAdjusterBackRight.Calculate();

                                    bedAdjusterBackLeft.Fix = fixedPoint;
                                    bedAdjusterBackLeft.Calculate();
                                    break;



                                case BedTypeEnum.ThreePointRightSingle:
                                    fixedPoint = bedAdjusterRightSingle.Z;
                                    bedAdjusterRightSingle.Fix = fixedPoint;
                                    bedAdjusterRightSingle.Calculate();

                                    bedAdjusterBackLeft.Fix = fixedPoint;
                                    bedAdjusterBackLeft.Calculate();

                                    bedAdjusterFrontLeft.Fix = fixedPoint;
                                    bedAdjusterFrontLeft.Calculate();

                                    break;

                            }
                        }


                        string zMin = null;
                        string zMax = null;

                        foreach (var probePoint in _com.ProbeResponceList)
                        {
                            if (zMin == null) zMin = probePoint.Z.ToString();
                            if (Convert.ToDouble(zMin) <= probePoint.Z) zMin = probePoint.Z.ToString();
                            if (zMax == null) zMax = probePoint.Z.ToString();
                            if (Convert.ToDouble(zMax) >= probePoint.Z) zMax = probePoint.Z.ToString();
                        }
                    }
                    CreateSurfaceChart(_com.ProbeResponceList);
                    _com.Status = MarlinCommunication.Feature.Done;
                    break;

                    #endregion

                #region SurfaceScan

                case MarlinCommunication.Feature.SurfaceScan:
                    CreateSurfaceChart(_com.ProbeResponceList);
                    _com.Status = MarlinCommunication.Feature.Done;
                    break;

                #endregion

                #region DockZprobe
                case MarlinCommunication.Feature.DockZprobe:
                    

                    // Going Down and ZProbe triggered
                    if (_com.EndStopStatus.Zmin == _dockZprobeUpDown )
                    {
                        if (_com.EndStopStatus.Zmin && _dockZprobeUpDown && _dockZprobePrecision <= 0.03)
                        {
                            DelegateAndInvoke.DelegateText(txtBxDockZprobe, _com.CurrentPosition.Zstring);
                            
                            _com.Status = MarlinCommunication.Feature.Done;
                            _com.SendCommand(new List<string> { "M117 Z-Probe is docked", "M114", "M119", });
                            break;
                        }

                        _dockZprobePrecision = Math.Max( _dockZprobePrecision/2.0, 0.025);
                        _dockZprobeUpDown = !_dockZprobeUpDown; // going up
                    }

                    
                    if (_dockZprobeUpDown)
                    {
                        _com.SendCommand(new List<string> { "G91", $"G1 Z-{_dockZprobePrecision.ToString().Replace(',', '.')} F100", "G90", "M0 P50",  "M119", "M114", });
                    }
                    else
                    {
                        _com.SendCommand(new List<string> { "G91", $"G1 Z{_dockZprobePrecision.ToString().Replace(',', '.')} F100", "G90", "M0 P50", "M119", "M114", });
                    }

                    break;
                    #endregion

                #region ExtruderCalibration
                case MarlinCommunication.Feature.ExtruderCalibration:
                        DelegateAndInvoke.DelegateVisible(grpBxTestExtrude,true);
                    MessageBox.Show(
                        @"Heating of the extruder is done!" + Environment.NewLine + Environment.NewLine +
                        @"Continue with test-extrude of filament");
                    break;

                case MarlinCommunication.Feature.ExtruderCalibrationTest:
                    MessageBox.Show(@" Wait until the filament extrusion stops!" +  Environment.NewLine +
                        @"Then meassure the used filament and enter the amount as ""Meassured used"" filament "
                        + Environment.NewLine + Environment.NewLine +
                        @"Button ""Calculate"" will give you the recalculated steps-per-mm.");
                    break;

                 #endregion
            }   
        }

        private void _com_Temperatures(object sender, Temperatures temperatures)
        {
            DelegateAndInvoke.SetExtruderTemp(chartTemperature, (int) _temperatureStopwatch.Elapsed.TotalSeconds,
                (int) temperatures.Extruder, (int) temperatures.SetExtruder);

            DelegateAndInvoke.SetBedTemp(chartTemperature, (int) _temperatureStopwatch.Elapsed.TotalSeconds,
                (int) temperatures.Heatbed, (int) temperatures.SetHeatbed);
        }




        private void _com_M301Responce(object sender, ResponceData responce)
        {
            // TODO: Show EEPROM

        }

        private void _com_M303Responce(object sender, ResponceData responceData)
        {
            if (responceData == null) return;

            var data = responceData.Data;

            //string pattern = @"\sT:.[0-9]*.[0-9]*\s\/.[0-9]*.[0-9]*.\sB:.[0-9]*.[0-9]*.\s\/.[0-9]*.[0-9]*\s\@:.[0-9]*\sB\@:[0-9]*";
            //Remove temperatures from _dataReceived
            //data = Regex.Replace(data, pattern, "");
            data = Regex.Replace(data, "T:", "\nT:");

            data = Regex.Replace(data, "bias:", "\nbias:");
            data = data.Replace("Classic PID", "\nClassic PID");
            data = data.Replace("PID Autotune finished", "\nPID Autotune finished");
            data = data.Replace("#define  DEFAULT", "\n#define  DEFAULT");

            var lines = data.Split('\n');
            var linesList = new List<string>();

            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line)) linesList.Add(line);
            }







            // get the Kp , Ki and Kd from the responce
            foreach (string line in linesList)
            {
                Match matchKp = Regex.Match(line, @"(?<=#define\s*DEFAULT_[0-9]*Kp\s)[0-9|.]*", RegexOptions.IgnoreCase);
                if (!matchKp.Success)
                {
                    matchKp = Regex.Match(line, @"(?<=Kp:\s)[0-9|.]*", RegexOptions.IgnoreCase);
                }

                Match matchKi = Regex.Match(line, @"(?<=#define\s*DEFAULT_[0-9]*Ki\s)[0-9|.]*", RegexOptions.IgnoreCase);
                if (!matchKi.Success)
                {
                    matchKi = Regex.Match(line, @"(?<=Ki:\s)[0-9|.]*", RegexOptions.IgnoreCase);
                }

                Match matchKd = Regex.Match(line, @"(?<=#define\s*DEFAULT_[0-9]*Kd\s)[0-9|.]*", RegexOptions.IgnoreCase);
                if (!matchKd.Success)
                {
                    matchKd = Regex.Match(line, @"(?<=Kd:\s)[0-9|.]*", RegexOptions.IgnoreCase);
                }




                if (line.Contains(@"Bad extruder number"))
                {
                    MessageBox.Show(line + Environment.NewLine + Environment.NewLine +
                                    @"It looks like Firmware had BedPID disabled", @"BedPID", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                if (_com.Status == MarlinCommunication.Feature.AutoPidTuneExtruder)
                {
                    if (matchKp.Success)
                    {
                        DelegateAndInvoke.DelegateText(txtBxKpExtruder, matchKp.Value);
                    }
                    if (matchKi.Success)
                    {
                        DelegateAndInvoke.DelegateText(txtBxKiExtruder, matchKi.Value);
                    }
                    if (matchKd.Success)
                    {
                        DelegateAndInvoke.DelegateText(txtBxKdExtruder, matchKd.Value);
                    }
                }
                else if (_com.Status == MarlinCommunication.Feature.AutoPidTuneBed)
                {
                    if (matchKp.Success)
                    {
                        DelegateAndInvoke.DelegateText(txtBxKpBed, matchKp.Value);
                    }
                    if (matchKi.Success)
                    {
                        DelegateAndInvoke.DelegateText(txtBxKiBed, matchKi.Value);
                    }
                    if (matchKd.Success)
                    {
                        DelegateAndInvoke.DelegateText(txtBxKdBed, matchKd.Value);
                    }

                }



            }




            DelegateAndInvoke.FastColoredTextBox(fctbPidResponce, linesList);
            DelegateAndInvoke.ScrollTo(fctbPidResponce, linesList.Count);
        }

        private void _com_M304Responce(object sender, ResponceData responce)
        {
            // TODO: SHOW EEPROM
        }


        private void _com_M500Responce(object sender, ResponceData responce)
        {
            // TODO: Show saved EEPROM
            //MessageBox.Show(responce.Data, @"Saved EEPROM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _com_M501Responce(object sender, ResponceData responce)
        {
            //MessageBox.Show(responce.Data, @"Data in EEPROM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowInitAndM501(responce.Data);
        }

        private void _com_G30ProbeResponce(object sender, List<Position> probePositions)
        {

            // Calculate the turns on each corner
            if (_com.ProbeResponceList != null)
            {
                foreach (var probeResponce in _com.ProbeResponceList)
                {
                    _probePoints.Add(new Position
                    {
                        X = probeResponce.X,
                        Y = probeResponce.Y,
                        Z = probeResponce.Z
                    });


                    // Find control that match the X and Y
                    // Assign the Z
                    if ((Math.Abs(bedAdjusterBackLeft.X - probeResponce.X) < 50) &&
                        (Math.Abs(bedAdjusterBackLeft.Y - probeResponce.Y) < 50))
                    {
                        bedAdjusterBackLeft.Z = probeResponce.Z;
                    }

                    if ((Math.Abs(bedAdjusterBackRight.X - probeResponce.X) < 50) &&
                        (Math.Abs(bedAdjusterBackRight.Y - probeResponce.Y) < 50))
                    {
                        bedAdjusterBackRight.Z = probeResponce.Z;
                    }

                    if ((Math.Abs(bedAdjusterFrontLeft.X - probeResponce.X) < 50) &&
                        (Math.Abs(bedAdjusterFrontLeft.Y - probeResponce.Y) < 50))
                    {
                        bedAdjusterFrontLeft.Z = probeResponce.Z;
                    }

                    if ((Math.Abs(bedAdjusterFrontRight.X - probeResponce.X) < 50) &&
                        (Math.Abs(bedAdjusterFrontRight.Y - probeResponce.Y) < 50))
                    {
                        bedAdjusterFrontRight.Z = probeResponce.Z;
                    }

                    if ((Math.Abs(bedAdjusterLeftSingle.X - probeResponce.X) < 50) &&
                        (Math.Abs(bedAdjusterLeftSingle.Y - probeResponce.Y) < 50))
                    {
                        bedAdjusterLeftSingle.Z = probeResponce.Z;
                    }

                    if ((Math.Abs(bedAdjusterFrontSingle.X - probeResponce.X) < 50) &&
                        (Math.Abs(bedAdjusterFrontSingle.Y - probeResponce.Y) < 50))
                    {
                        bedAdjusterFrontSingle.Z = probeResponce.Z;
                    }

                    if ((Math.Abs(bedAdjusterRightSingle.X - probeResponce.X) < 50) &&
                        (Math.Abs(bedAdjusterRightSingle.Y - probeResponce.Y) < 50))
                    {
                        bedAdjusterRightSingle.Z = probeResponce.Z;
                    }



                }
            }
        }







        private void _com_Init(object sender, ResponceData e)
        {
            //Enable TAB
            Delegate.DisableTabs(tabControl3DprinterTool, true);


            //Enable EmergencyStop
            DelegateAndInvoke.DelegateBackgroundImage(btnEmergency, Resources.emargency_enabled);
            DelegateAndInvoke.DelegateVisible(btnEmergency, true);
            DelegateAndInvoke.DelegateEnabled(btnEmergency, true);

            // Enable/visible ShowCommunication
            DelegateAndInvoke.DelegateVisible(btnShowCommunication, true);
            DelegateAndInvoke.DelegateEnabled(btnShowCommunication, true);

            // Show navigation
            DelegateAndInvoke.DelegateVisible(grpBxNavigation, true);

            //// Assign Marlincommunication
            DelegateAndInvoke.DelegateKompass(kompass, _com);
            DelegateAndInvoke.DelegateVerticalJog(verticalJogZprobeHeight, _com);






            // Show temperature Chart
            DelegateAndInvoke.DelegateVisible(chartTemperature, true);


            // Start the temperature stopwatch
            _temperatureStopwatch.Reset();
            _temperatureStopwatch.Start();


            ShowInitAndM501(e.Data);

            
            
        }

        private void ShowInitAndM501(string data)
        {
            string initText = "";
            string[] initRows = data.Split('\n');
            foreach (string row in initRows)
            {
                initText += row.Replace("echo:", "").Trim() + Environment.NewLine;
            }

            DelegateAndInvoke.FastColoredTextBox(fctbInit, initText);

            DelegateAndInvoke.SelectTabcontrol(tabControl3DprinterTool, tabPageParameters);

            DelegateAndInvoke.DelegateText(txtBxM851, _com.M851ZprobeOffset.ToString().Replace(",","."));

        }




        private void CreateSurfaceChart(List<Position> positions )
        {

            var license = new NLicense("001800d6-4511-4600-6a35-050c5793dd94");
            NLicenseManager.Instance.SetLicense(license);
            NLicenseManager.Instance.LockLicense = true;

            var chart = nChartControlSurface.Charts[0];
            chart.Enable3D = true;
            chart.Width = 80;
            chart.Height = 80;
            chart.Depth = 80;
            nChartControlSurface.Legends.Clear();


            var surface = new NTriangulatedSurfaceSeries { SmoothPalette = true };

            if (positions != null)
            {
                foreach (var position in positions)
                {
                    surface.XValues.Add(position.X);
                    surface.Values.Add(position.Z);
                    surface.ZValues.Add(position.Y);
                }

                chart.Series.Add(surface);

                nChartControlSurface.Controller.Tools.Add(new NPanelSelectorTool());
                nChartControlSurface.Controller.Tools.Add(new NTrackballTool());
            }

            nChartControlSurface.Refresh();
        }


        private void _com_DisConnected(object sender, EventArgs e)
        {
            DelegateAndInvoke.DelegateText(btnConnect, @"Connect");

            //Disable TAB
            Delegate.DisableTabs(tabControl3DprinterTool, false);

            //Disable EmergencyStop
            DelegateAndInvoke.DelegateBackgroundImage(btnEmergency, Resources.emargency_disabled);
            DelegateAndInvoke.DelegateVisible(btnEmergency,false);
            DelegateAndInvoke.DelegateEnabled(btnEmergency, false);

            // DisableEnable/Hide ShowCommunication
            DelegateAndInvoke.DelegateVisible(btnShowCommunication, false);
            DelegateAndInvoke.DelegateEnabled(btnShowCommunication,false);

            // Show navigation
            DelegateAndInvoke.DelegateVisible(grpBxNavigation,false);

            
            DelegateAndInvoke.VerticalJog(verticalJogZprobeHeight, null);
            DelegateAndInvoke.Kompass(kompass, null);

            // Show temperature Chart
            DelegateAndInvoke.DelegateVisible(chartTemperature, true);

            // Stop the temperature stopwatch
            _temperatureStopwatch.Reset();
            _temperatureStopwatch.Stop();
        }

        private void _com_Connected(object sender, EventArgs e)
        {
            btnConnect.Text = @"DisConnect";
            _configuration.ComPort = _com.Port;
            _configuration.Baudrate = _com.BaudRate;

            bedCornerControlBackLeft.Communication = _com;
            bedCornerControlBackRight.Communication = _com;
            bedCornerControlFrontLeft.Communication = _com;
            bedCornerControlFrontRight.Communication = _com;
            bedCornerControlSafeHome.Communication = _com;

            
        }

        private void _com_G29Responce(object sender, Responce responce)
        {

            if (_com.Status == MarlinCommunication.Feature.AutoBedLevel)
            {
                DelegateAndInvoke.FastColoredTextBox(fctbAutoBedLevelResponce, responce.ResponsRowList);
                return;
            }




            
            // X:0.00 Y:0.00 Z:5.00 E:0.00 Count X: 0 Y:0 Z:16000
            foreach (string row in responce.ResponsRowList)
            {
                string positionPattern = @"X:[0-9]*\.[0-9]*\s*Y:[0-9]*\.[0-9]*\s*Z:[0-9]*\.[0-9]*\s*E:[0-9]*\.[0-9]*\s*Count\s*X:\s*";
                Match positionMatch = Regex.Match(row, positionPattern);
                if (positionMatch.Success)
                {
                    double x = (double)Convert.ToDecimal(Regex.Match(row, @"(?<=X:)[0-9]*\.[0-9]*").Value.Replace('.', ','));
                    double y = (double)Convert.ToDecimal(Regex.Match(row, @"(?<=Y:)[0-9]*\.[0-9]*").Value.Replace('.', ','));
                    double z = (double)Convert.ToDecimal(Regex.Match(row, @"(?<=Z:)[0-9]*\.[0-9]*").Value.Replace('.', ','));
                    _probePoints.Add(new Position { X = x, Y = y, Z = z });
                }

            }

            


        }


        private void _com_M48ProbeStatus(object sender, Responce responce)
        {
            
            
           




        }

        #endregion

       

        

        private void btnMeshLevel_Click(object sender, EventArgs e)
        {
            nChartControlSurface.Charts[0].Series.Clear();
            nChartControlSurface.Refresh();


        }

        private void btnUpdateExtruderPid_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string> {$"M301 P{txtBxKpExtruder.Text} I{txtBxKiExtruder.Text} D{txtBxKdExtruder.Text}","M500","M501"};
            // M301 P19.56 I0.71 D134.26
            _com.SendCommand(commands);

        }

        private void btnUpdateBedPid_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>
            {
                $"M304 P{txtBxKpBed.Text} I{txtBxKiBed.Text} D{txtBxKdBed.Text}",
                "M500",
                "M501"
            };
            // M301 P19.56 I0.71 D134.26
            _com.SendCommand(commands);
        }

        private void btnTransferExtruderPid_Click(object sender, EventArgs e)
        {
            _com.Port = cmbBxComPort.Text;
            _com.DisConnect();


            btnConnect.Text = @"Connect";

            // Update Firmware)

            FrmMarlinEditor marlinEditor = new FrmMarlinEditor();
            marlinEditor.UpdateAndSavePidExtruder(txtBxKpExtruder.Text, txtBxKiExtruder.Text, txtBxKdExtruder.Text);
            marlinEditor.ShowDialog();

        }

        private void btnTransferBedPid_Click(object sender, EventArgs e)
        {
            _com.Port = cmbBxComPort.Text;
            _com.DisConnect();


            btnConnect.Text = @"Connect";

            FrmMarlinEditor marlinEditor = new FrmMarlinEditor();
            marlinEditor.UpdateAndSavePidBed(txtBxKpBed.Text, txtBxKiBed.Text, txtBxKdBed.Text);

            marlinEditor = new FrmMarlinEditor();
            marlinEditor.ShowDialog();
        }




        private void btnM500SaveEeprom_Click(object sender, EventArgs e)
        {
            _com.SendCommand(new List<string>(new[] {"M500"}));
        }

        private void btnM501ReadEeprom_Click(object sender, EventArgs e)
        {
            _com.Gcode = "";
            _com.ClearCommunication();
            _com.SendCommand(new List<string>(new[] {"M501"}));

        }

       


        private void RedesignBedAdjusters()
        {
            int x;
            int y;

            bedAdjusterBackLeft.X = _configuration.BackLeftCorner.X;
            bedAdjusterBackLeft.Y = _configuration.BackLeftCorner.Y;

            bedAdjusterBackRight.X = _configuration.BackRightCorner.X;
            bedAdjusterBackRight.Y = _configuration.BackRightCorner.Y;

            bedAdjusterFrontLeft.X = _configuration.FrontLeftCorner.X;
            bedAdjusterFrontLeft.Y = _configuration.FrontLeftCorner.Y;

            bedAdjusterFrontRight.X = _configuration.FrontRightCorner.X;
            bedAdjusterFrontRight.Y = _configuration.FrontRightCorner.Y;

            x = (int)_configuration.FrontLeftCorner.X;
            y = (int)(_configuration.FrontLeftCorner.Y + ((int)_configuration.BackLeftCorner.Y - (int)_configuration.FrontLeftCorner.Y));
            bedAdjusterLeftSingle.X = x;
            bedAdjusterLeftSingle.Y = y;


            x = (int)(_configuration.FrontLeftCorner.X + ((int)_configuration.FrontRightCorner.X - (int)_configuration.FrontLeftCorner.X));
            y = (int)_configuration.FrontLeftCorner.Y;
            bedAdjusterFrontSingle.X = x;
            bedAdjusterFrontSingle.Y = y;

            x = (int)_configuration.FrontRightCorner.X;
            y = (int)(_configuration.FrontRightCorner.Y + ((int)_configuration.BackRightCorner.Y - (int)_configuration.FrontRightCorner.Y));
            bedAdjusterRightSingle.X = x;
            bedAdjusterRightSingle.Y = y;


            bedAdjusterBackLeft.Clear();
            bedAdjusterBackRight.Clear();
            bedAdjusterFrontLeft.Clear();
            bedAdjusterFrontRight.Clear();
            bedAdjusterLeftSingle.Clear();
            bedAdjusterFrontSingle.Clear();
            bedAdjusterRightSingle.Clear();

            List<Position> probePointsList = new List<Position>();
            if (_configuration.BedType ==  BedTypeEnum.FourPoint)
            {
                probePointsList.Add(bedAdjusterFrontLeft.Position);
                probePointsList.Add(bedAdjusterFrontRight.Position);
                probePointsList.Add(bedAdjusterBackRight.Position);
                probePointsList.Add(bedAdjusterBackLeft.Position);
                bedAdjusterBackLeft.Visible = true;
                bedAdjusterBackRight.Visible = true;
                bedAdjusterFrontLeft.Visible = true;
                bedAdjusterFrontRight.Visible = true;
                bedAdjusterLeftSingle.Visible = false;
                bedAdjusterFrontSingle.Visible = false;
                bedAdjusterRightSingle.Visible = false;
            }
            else
            if (_configuration.BedType == BedTypeEnum.ThreePointLeftSingle)
            {
                probePointsList.Add(bedAdjusterLeftSingle.Position);
                probePointsList.Add(bedAdjusterFrontRight.Position);
                probePointsList.Add(bedAdjusterBackRight.Position);
                bedAdjusterBackLeft.Visible = false;
                bedAdjusterBackRight.Visible = true;
                bedAdjusterFrontLeft.Visible = false;
                bedAdjusterFrontRight.Visible = true;
                bedAdjusterLeftSingle.Visible = true;
                bedAdjusterFrontSingle.Visible = false;
                bedAdjusterRightSingle.Visible = false;

            }
            else
            if (_configuration.BedType ==  BedTypeEnum.ThreePointFrontSingle)
            {
                probePointsList.Add(bedAdjusterFrontSingle.Position);
                probePointsList.Add(bedAdjusterBackRight.Position);
                probePointsList.Add(bedAdjusterBackLeft.Position);
                bedAdjusterBackLeft.Visible = true;
                bedAdjusterBackRight.Visible = true;
                bedAdjusterFrontLeft.Visible = false;
                bedAdjusterFrontRight.Visible = false;
                bedAdjusterLeftSingle.Visible = false;
                bedAdjusterFrontSingle.Visible = true;
                bedAdjusterRightSingle.Visible = false;
            }

            else
            if (_configuration.BedType ==   BedTypeEnum.ThreePointRightSingle)
            {
                probePointsList.Add(bedAdjusterRightSingle.Position);
                probePointsList.Add(bedAdjusterFrontLeft.Position);
                probePointsList.Add(bedAdjusterBackLeft.Position);
                bedAdjusterBackLeft.Visible = true;
                bedAdjusterBackRight.Visible = false;
                bedAdjusterFrontLeft.Visible = true;
                bedAdjusterFrontRight.Visible = false;
                bedAdjusterLeftSingle.Visible = false;
                bedAdjusterFrontSingle.Visible = false;
                bedAdjusterRightSingle.Visible = true;
            }



           



        }

        private void rdoBn4point_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }

       

        private void chkListBxAdjustment_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in chkListBxAdjustment.CheckedItems)
            {
                _configuration.Adjuster = (string) item;
                break;
            }
        }


        private void CalculateLeadScrew()
        {
            float microStep = 1;
            int stepsPerRevolution = (int) (360.0/1.8);
            float pitch = (float) 1.25;
            float gear;

            var comboboxItemTextValue = cmbBxLeadScrewMotorStepAngle.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null)
            {
                stepsPerRevolution = (int) comboboxItemTextValue.ToValue();
            }

            comboboxItemTextValue = cmbBxLeadScrewDriverMicrostepping.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null)
            {
                microStep = (float) comboboxItemTextValue.ToValue();
            }

            comboboxItemTextValue = cmbBxLeadScrewPitch.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null)
            {
                pitch = (float) comboboxItemTextValue.ToValue();
            }



            if (chkBxLeadScrewDirectDriven.Checked) gear = (float) 1.0;
            else
            {
                gear = (float) (numUpDnLeadScrewMotorTeethCount.Value/numUpDnLeadScrewTeethCount.Value);
            }


            var stepsPerMM = (int) (stepsPerRevolution*(microStep/pitch)*gear);

            fastColoredTextBoxLeadScrewStepsPerMM.Text = $"{stepsPerMM} steps/mm";

        }

        private void cmbBxLeadScrewMotorStepAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateLeadScrew();
        }

        private void chkBxLeadScrewDirectDriven_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnLeadScrewTeethCount.Visible = !chkBxLeadScrewDirectDriven.Checked;
            numUpDnLeadScrewMotorTeethCount.Visible = !chkBxLeadScrewDirectDriven.Checked;
            lblLeadScrewMotorTeethCount.Visible = !chkBxLeadScrewDirectDriven.Checked;
            lblLeadscrewTeethCount.Visible = !chkBxLeadScrewDirectDriven.Checked;
            CalculateLeadScrew();

        }

        private void cmbBxLeadScrewDriverMicrostepping_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateLeadScrew();
        }

        private void numUpDnLeadScrewMotorPulleyTeethCount_ValueChanged(object sender, EventArgs e)
        {
            CalculateLeadScrew();
        }

        private void numUpDnLeadScrewPulleyTeethCount_ValueChanged(object sender, EventArgs e)
        {
            CalculateLeadScrew();
        }

        private void cmbBxLeadScrewPitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateLeadScrew();
        }

        private void cmbBxBeltMotorStepAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBelt();
        }

        private void CalculateBelt()
        {
            float microStep = 1;
            int stepsPerRevolution = (int) (360.0/1.8);
            float pitch = (float) 1.25;
            float gear;

            var comboboxItemTextValue = cmbBxBeltMotorStepAngle.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null)
            {
                stepsPerRevolution = (int) comboboxItemTextValue.ToValue();
            }

            comboboxItemTextValue = cmbBxBeltDriverMicrostepping.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null)
            {
                microStep = (float) comboboxItemTextValue.ToValue();
            }

            comboboxItemTextValue = cmbBxBeltPitch.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null)
            {
                pitch = (float) comboboxItemTextValue.ToValue();
            }



            if (chkBxBeltDirectDriven.Checked) gear = (float) 1.0;
            else
            {
                gear = (float) (numUpDnBeltMotorTeethCount.Value/numUpDnBeltTeethCount.Value);
            }


            var stepsPerMM =
                (int) (stepsPerRevolution*(microStep/(pitch*(double) numUpDnBeltPulleyTeethCount.Value)))*gear;

            fastColoredTextBoxBeltStepsPerMM.Text = $"{stepsPerMM} steps/mm";
        }

        private void numUpDnExtruderExpectedValue_ValueChanged(object sender, EventArgs e)
        {
            CalculateExtruder();
        }

        private void CalculateExtruder()
        {

            // Extruder steps/mm = ( extrude button clicks * extruded length per click * old extruder steps/mm ) / marked length on filament

            int extrudedLength = (int) numUpDnExtruderExpectedValue.Value;
            int oldStepsPerMM = (int) numUpDnExtruderOldFirmware.Value;
            int meassuredExtrudedLength = (int) numUpDnExtruderMeassuredExtrusion.Value;

            var stepsPerMM = extrudedLength*oldStepsPerMM/meassuredExtrudedLength;


            fastColoredTextBoxExtruderStepsPerMM.Text = $"{stepsPerMM} steps/mm";
            fastColoredTextBoxExtruderStepsPerMM.Tag = stepsPerMM.ToString(CultureInfo.InvariantCulture).Replace(',','.');
        }

        private void btnExtruderOldFirmware_Click(object sender, EventArgs e)
        {
            // TODO: Get extruder Steps Per MM from EEPROM
            // get the OldFirmware settings from EEPROM
            // M501 without a Responce shown
            // Only Parse responce 

        }

        private void btnExtruderUpdateStepsPerMMinFirmware_Click(object sender, EventArgs e)
        {
            //TODO: Update current Firmware
            MessageBox.Show(@"Not implemented (yet)");
        }

        private void btnExtruderUpdateStepsPerMMinEEPROM_Click(object sender, EventArgs e)
        {
            // TODO: Set Extruder two???? 
            // Send M92 E420.5 

            List<string> commands = new List<string>();
            commands.Add($"M92 E{fastColoredTextBoxExtruderStepsPerMM.Tag}");
            commands.Add("M500");
            commands.Add("M501");
            _com.SendCommand(commands);

        }

        private void numUpDnFeedRateMMperMinute_ValueChanged(object sender, EventArgs e)
        {
            numUpDnFeedRateMMperSecund.Value = numUpDnFeedRateMMperMinute.Value/60;
        }

        private void numUpDnFeedRateMMperSecund_ValueChanged(object sender, EventArgs e)
        {
            numUpDnFeedRateMMperMinute.Value = numUpDnFeedRateMMperSecund.Value*60;
        }

        private void numUpDnBeltMotorPulleyTeethCount_ValueChanged(object sender, EventArgs e)
        {
            CalculateBelt();
        }

        private void numUpDnBeltTeethCount_ValueChanged(object sender, EventArgs e)
        {
            CalculateBelt();
        }

        private void cmbBxBeltDriverMicrostepping_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBelt();
        }

        private void cmbBxBeltPitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBelt();
        }

        private void chkBxBeltDirectDriven_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnBeltTeethCount.Visible = !chkBxBeltDirectDriven.Checked;
            numUpDnBeltMotorTeethCount.Visible = !chkBxBeltDirectDriven.Checked;
            lblBeltMotorTeethCount.Visible = !chkBxBeltDirectDriven.Checked;
            lblBeltTeethCount.Visible = !chkBxBeltDirectDriven.Checked;
            CalculateBelt();
        }

        private void numUpDnBeltPulleyTeethCount_ValueChanged(object sender, EventArgs e)
        {
            CalculateBelt();
        }


        //TODO: Tabort
        //private void btnAssociateStlViewer_Click(object sender, EventArgs e)
        //{


        //    string stlViewerExe = Path.GetDirectoryName(Application.ExecutablePath);

        //    if (stlViewerExe != null)
        //    {
        //        stlViewerExe = Path.Combine(stlViewerExe, "Marlin3DprinterStlViewer.exe");

        //        FileAssociation.Associate(".stl", "Marlin3DprinterToolSTLviewer", "MarlinSTLviewer",
        //            "Marlin3DprinterTool.ico", stlViewerExe);
        //        MessageBox.Show(@"STL viewer is now the prefered stl-application", @"Assign STL Viewer",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}




        //TODO: Tabort
        //private void btnInstallStlServer_Click(object sender, EventArgs e)
        //{
        //    bool osIs32Bit = chkBx32BitOS.Checked;
        //    string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
        //        "Marlin3DprinterToolStlThumbnail.dll");
        //    SharpShellServerManagerClass.InstallServer(stlViewerThumbnail, osIs32Bit);
        //    UpdateServerStatus();
        //}



        //TODO: Tabort
        //private void btnUnRegisterStlServer_Click(object sender, EventArgs e)
        //{
        //    string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
        //        "Marlin3DprinterToolStlThumbnail.dll");
        //    bool osIs32Bit = chkBx32BitOS.Checked;
        //    SharpShellServerManagerClass.Unregister(stlViewerThumbnail, osIs32Bit);
        //    UpdateServerStatus();
        //}

        //private void btnRestartWindowsFileExplorer_Click(object sender, EventArgs e)
        //{
        //    DialogResult result =
        //        MessageBox.Show(
        //            @"Be sure that all important work is SAVED!" + Environment.NewLine + Environment.NewLine +
        //            @"Explorer will be forced to restart"
        //            , @"Restarting Explorer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
        //            MessageBoxDefaultButton.Button2);
        //    if (result == DialogResult.Cancel) return;

        //    SharpShellServerManagerClass.RestartExplorer();

        //    MessageBox.Show(@"Restart of Explorer DONE!", @"Restart of Explorer", MessageBoxButtons.OK,
        //        MessageBoxIcon.Information);

        //}




        //private void btnTroubleShootStl_Click_1(object sender, EventArgs e)
        //{

        //    FrmRTFdocumentation stlTroubleshoot = new FrmRTFdocumentation {Filename = "STL thumbnail debug.rtf"};
        //    stlTroubleshoot.ShowDialog();
        //}

        //private void btnResetAndCleanExistingThumbnails_Click(object sender, EventArgs e)
        //{
        //    DialogResult result =
        //        MessageBox.Show(
        //            @"Be sure that all important work is SAVED!" + Environment.NewLine + Environment.NewLine +
        //            @"This is a more BRUTAL method of reseting the File Explorer Thumbnails"
        //            , @"Forced Delete of Thumbnail cache", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
        //            MessageBoxDefaultButton.Button2);
        //    if (result == DialogResult.Cancel) return;


        //    SharpShellServerManagerClass.ResetAndCleanExistingThumbnails();
        //    MessageBox.Show(@"Forced Delete of Thumbnail Cache and Restart of Explorer is DONE!", @"Restart of Explorer",
        //        MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void btnColorStl_Click(object sender, EventArgs e)
        //{
        //    ColorConverter exitingColor = new ColorConverter();
        //    exitingColor.ConvertFrom(_configuration.STLcolor);
        //    ColorDialog colorDialog = new ColorDialog();
        //    colorDialog.Color = (Color) exitingColor.ConvertFrom(_configuration.STLcolor);
        //    colorDialog.AllowFullOpen = false;
        //    colorDialog.AnyColor = false;
        //    colorDialog.ShowHelp = true;
        //    colorDialog.FullOpen = false;
        //    colorDialog.ShowDialog();
        //    _configuration.STLcolor = colorDialog.Color.IsNamedColor
        //        ? colorDialog.Color.Name
        //        : $"#{colorDialog.Color.Name}";

        //    Registry.SetValue(@"HKEY_CURRENT_USER\Software\Marlin3DprinterTool", "Color", _configuration.STLcolor);
        //    //string color = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Software\Marlin3DprinterTool","Color","Brown");
        //    //MessageBox.Show(color);
        //}

       


        private void ParseInit()
        {
            foreach (string line in fctbInit.Lines)
            {
                string linePattern = "";
                Match rowMatch = null;

                linePattern = @"M92\s*X[0-9]*\.[0-9]*\s*Y[0-9]*\.[0-9]*\s*Z[0-9]*\.[0-9]*\sE[0-9]*\.[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    txtBxStepsPerUnitX.Text =
                        Regex.Match(line, @"(?:X)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxStepsPerUnitY.Text =
                        Regex.Match(line, @"(?:Y)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxStepsPerUnitZ.Text =
                        Regex.Match(line, @"(?:Z)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxStepsPerUnitE.Text =
                        Regex.Match(line, @"(?:E)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;

                    _com.StepsPerUnitX = txtBxStepsPerUnitX.Text;
                    _com.StepsPerUnitY = txtBxStepsPerUnitY.Text;
                    _com.StepsPerUnitZ = txtBxStepsPerUnitZ.Text;
                    _com.StepsPerUnitE = txtBxStepsPerUnitE.Text;

                    txtBxCurrentStepsPermm.Text = _com.StepsPerUnitE;


                }

                

                linePattern = @"M203\s*X[0-9]*\.[0-9]*\s*Y[0-9]*\.[0-9]*\s*Z[0-9]*\.[0-9]*\sE[0-9]*\.[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    txtBxMaxFeedRateX.Text =
                        Regex.Match(line, @"(?:X)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxMaxFeedRateY.Text =
                        Regex.Match(line, @"(?:Y)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxMaxFeedRateZ.Text =
                        Regex.Match(line, @"(?:Z)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxMaxFeedRateE.Text =
                        Regex.Match(line, @"(?:E)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                }

                linePattern = @"M201\s*X[0-9]*\s*Y[0-9]*\s*Z[0-9]*\sE[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    // Only integers
                    txtBxMaxAccelationX.Text =
                        Regex.Match(line, @"(?:X)([-]*[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxMaxAccelationY.Text =
                        Regex.Match(line, @"(?:Y)([-]*[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxMaxAccelationZ.Text =
                        Regex.Match(line, @"(?:Z)([-]*[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxMaxAccelationE.Text =
                        Regex.Match(line, @"(?:E)([-]*[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                }

                linePattern = @"M204\s*P[0-9]*\.[0-9]*\s*R[0-9]*\.[0-9]*\s*T[0-9]*\.[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    // Only integers
                    txtBxAccelerationPrint.Text =
                        Regex.Match(line, @"(?:P)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxAccelerationRetract.Text =
                        Regex.Match(line, @"(?:R)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxAccelerationTravel.Text =
                        Regex.Match(line, @"(?:T)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;

                }

                linePattern = @"M206\s*X[0-9]*\.[0-9]*\s*Y[0-9]*\.[0-9]*\s*Z[0-9]*\.[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    txtBxHomeOffsetX.Text =
                        Regex.Match(line, @"(?:X)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxHomeOffsetY.Text =
                        Regex.Match(line, @"(?:Y)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxHomeOffsetZ.Text =
                        Regex.Match(line, @"(?:Z)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;

                }


                linePattern = @"M301\s*P[0-9]*\.[0-9]*\s*I[0-9]*\.[0-9]*\s*D[0-9]*\.[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    txtBxPidExtruderKp.Text =
                        Regex.Match(line, @"(?:P)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxPidExtruderKi.Text =
                        Regex.Match(line, @"(?:I)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxPidExtruderKd.Text =
                        Regex.Match(line, @"(?:D)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;

                    _com.PidExtruderKp = txtBxPidExtruderKp.Text;
                    _com.PidExtruderKi = txtBxPidExtruderKi.Text;
                    _com.PidExtruderKd = txtBxPidExtruderKd.Text;

                }

                linePattern = @"M304\s*P[0-9]*\.[0-9]*\s*I[0-9]*\.[0-9]*\s*D[0-9]*\.[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    txtBxBedKp.Text =
                        Regex.Match(line, @"(?:P)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxBedKi.Text =
                        Regex.Match(line, @"(?:I)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxBedKd.Text =
                        Regex.Match(line, @"(?:D)([-]*[0-9]*.[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    _com.PidBedKp = txtBxBedKp.Text;
                    _com.PidBedKi = txtBxBedKi.Text;
                    _com.PidBedKd = txtBxBedKd.Text;

                }



                linePattern = @"M420\s*S[0-9]*\s*X[0-9]*\s*Y[0-9]*";
                rowMatch = Regex.Match(line, linePattern);
                if (rowMatch.Success)
                {
                    txtBxMeshBedLevelPointX.Text =
                        Regex.Match(line, @"(?:X)([-]*[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                    txtBxMeshBedLevelPointY.Text =
                        Regex.Match(line, @"(?:Y)([-]*[0-9]*)", RegexOptions.CultureInvariant).Groups[1].Value;
                }

                


            }
        }

        private void btnM92paremeters_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            string command = "M92";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitX.Text)) command += $" X{txtBxStepsPerUnitX.Text}";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitY.Text)) command += $" Y{txtBxStepsPerUnitY.Text}";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitZ.Text)) command += $" Z{txtBxStepsPerUnitZ.Text}";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitE.Text)) command += $" E{txtBxStepsPerUnitE.Text}";
            commands.Add(command);
            commands.Add("M500"); // Save the eprom values
            commands.Add("M501"); // Read parameters from EEPROM (and update fctbInit)
            _com.SendCommand(commands);


        }

        private void fctbInit_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            ParseInit();
        }

        private void btnM203parameters_Click(object sender, EventArgs e)
        {

            List<string> commands = new List<string>();
            string command = "M92";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitX.Text)) command += $" X{txtBxStepsPerUnitX.Text}";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitY.Text)) command += $" Y{txtBxStepsPerUnitY.Text}";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitZ.Text)) command += $" Y{txtBxStepsPerUnitZ.Text}";
            if (!string.IsNullOrEmpty(txtBxStepsPerUnitE.Text)) command += $" Y{txtBxStepsPerUnitE.Text}";
            commands.Add(command);
            commands.Add("M501"); // Read parameters from EEPROM (and update fctbInit)
            _com.SendCommand(commands);
        }

        private void btnM201paremeters_Click(object sender, EventArgs e)
        {

            List<string> commands = new List<string>();
            string command = "M201";
            if (!string.IsNullOrEmpty(txtBxMaxAccelationX.Text)) command += $" X{txtBxMaxAccelationX.Text}";
            if (!string.IsNullOrEmpty(txtBxMaxAccelationY.Text)) command += $" Y{txtBxMaxAccelationY.Text}";
            if (!string.IsNullOrEmpty(txtBxMaxAccelationZ.Text)) command += $" Y{txtBxMaxAccelationZ.Text}";
            if (!string.IsNullOrEmpty(txtBxMaxAccelationE.Text)) command += $" Y{txtBxMaxAccelationE.Text}";
            commands.Add(command);
            commands.Add("M501"); // Read parameters from EEPROM (and update fctbInit)
            _com.SendCommand(commands);


        }

        private void btnM204paremeters_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            string command = "M204";
            if (!string.IsNullOrEmpty(txtBxAccelerationPrint.Text)) command += $" P{txtBxAccelerationPrint.Text}";
            if (!string.IsNullOrEmpty(txtBxAccelerationRetract.Text)) command += $" R{txtBxAccelerationRetract.Text}";
            if (!string.IsNullOrEmpty(txtBxAccelerationTravel.Text)) command += $" Y{txtBxAccelerationTravel.Text}";

            commands.Add(command);
            commands.Add("M501"); // Read parameters from EEPROM (and update fctbInit)
            _com.SendCommand(commands);
        }

        private void btnHomeOffsetParameters_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            string command = "M206";
            if (!string.IsNullOrEmpty(txtBxHomeOffsetX.Text)) command += $" P{txtBxHomeOffsetX.Text}";
            if (!string.IsNullOrEmpty(txtBxHomeOffsetX.Text)) command += $" R{txtBxHomeOffsetY.Text}";
            if (!string.IsNullOrEmpty(txtBxHomeOffsetX.Text)) command += $" Y{txtBxHomeOffsetZ.Text}";

            commands.Add(command);
            commands.Add("M501"); // Read parameters from EEPROM (and update fctbInit)
            _com.SendCommand(commands);

        }

        private void btnPidExtruderParameters_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            string command = "M301";
            if (!string.IsNullOrEmpty(txtBxPidExtruderKp.Text)) command += $" P{txtBxPidExtruderKp.Text}";
            if (!string.IsNullOrEmpty(txtBxPidExtruderKi.Text)) command += $" I{txtBxPidExtruderKi.Text}";
            if (!string.IsNullOrEmpty(txtBxPidExtruderKd.Text)) command += $" D{txtBxPidExtruderKd.Text}";

            commands.Add(command);
            commands.Add("M501"); // Read parameters from EEPROM (and update fctbInit)
            _com.SendCommand(commands);
        }

        private void btnPidBedParameters_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            string command = "M304";
            if (!string.IsNullOrEmpty(txtBxBedKp.Text)) command += $" P{txtBxBedKp.Text}";
            if (!string.IsNullOrEmpty(txtBxBedKi.Text)) command += $" I{txtBxBedKi.Text}";
            if (!string.IsNullOrEmpty(txtBxBedKd.Text)) command += $" D{txtBxBedKd.Text}";

            commands.Add(command);
            commands.Add("M501"); // Read parameters from EEPROM (and update fctbInit)
            _com.SendCommand(commands);

        }

        private void btnShowMeshInSurfaceChart_Click(object sender, EventArgs e)
        {
            

            var xMin = (int)Convert.ToDecimal(_configuration.FrontLeftCorner.X);
            var xMax = (int)Convert.ToDecimal(_configuration.FrontRightCorner.X);
            var xStep = (xMax - xMin) / (Convert.ToUInt16( txtBxMeshBedLevelPointX.Text) - 1);

            var yMin = (int)Convert.ToDecimal(_configuration.FrontLeftCorner.Y);
            var yMax = (int)Convert.ToDecimal(_configuration.BackLeftCorner.Y);
            var yStep = (yMax - yMin) / (Convert.ToUInt16(txtBxMeshBedLevelPointY.Text) - 1);



            List<Position> positions = new List<Position>();


            positions = _configuration.GetMeshpoints();
            
            CreateSurfaceChart(positions);

           DelegateAndInvoke.SelectTabcontrol(tabControl3DprinterTool,tabPageScanSurface);
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            FrmSetup setup = new FrmSetup();
            setup.ShowDialog();
        }

        private void txtBxZextraDistance_TextChanged(object sender, EventArgs e)
        {
            _configuration.ZextraDistance = txtBxZextraDistance.Text;
        }

        

       

        private void UpdateZprobeOffset(string zprobeZoffset)
        {
            _configuration.ZprobeZoffsetValue = zprobeZoffset;

        }




        private void cmbBxZprobeXoffset_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void cmbBxZprobeYoffset_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxZprobeYoffset_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxZprobeXoffset_TextChanged(object sender, EventArgs e)
        {
            
        }


       

       

       


        private void btnDockZprobe_Click(object sender, EventArgs e)
        {
            
            AGaugeRange probeRange = aGaugeProbe.GaugeRanges.FindByName("Probe");
            if (probeRange != null) aGaugeProbe.GaugeRanges.Remove(probeRange);
            _com.Status = MarlinCommunication.Feature.DockZprobe;

            
            List<String> commands = new List<string> {"G28","G91", "G1 Z10","G90","M0 P50", "M119", "M114"};
            _dockZprobePrecision = 0.5;
            _dockZprobeUpDown = true;

            _com.SendCommand(commands);
            

        }

        private void btnProbeUp_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string> {"G91","G1 Z0.05 F500","G90","M114"};
            

            _com.SendCommand(commands);
        }

        private void btnProbeDown_Click_2(object sender, EventArgs e)
        {
            List<string> commands = new List<string> { "G91", "G1 Z-0.05 F500", "G90", "M114" };
            

            _com.SendCommand(commands);
            
        }

        private void txtBxDockZprobe_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBxDockZprobe.Text))
            {
                float dockedProbeHigh = (float) Convert.ToDecimal(txtBxDockZprobe.Text.Replace(".", ","));
                float dockedProbeLow = (float) (dockedProbeHigh - 1);
                AGaugeRange probeRange = new AGaugeRange(Color.Green, dockedProbeLow, dockedProbeHigh, 5, 80);
                probeRange.Name = "Probe";
                aGaugeProbe.GaugeRanges.Add(probeRange);

            }
        }

       

        private void txtBxZprobePosition_TextChanged(object sender, EventArgs e)
        {
            aGaugeProbe.Value = (float) Convert.ToDecimal(txtBxZprobePosition.Text.Replace(".", ","));
            if (_com.EndStopStatus.Zmin)
            {
                AGaugeRange probeRange = aGaugeProbe.GaugeRanges.FindByName("Probe");
                if (probeRange != null)
                {
                    
                    probeRange.StartValue = (float)Convert.ToDouble(txtBxZprobePosition.Text.Replace(".", ","));
                }
                
            }
        }


        private void btnNozzleIsTouchingBed_Click(object sender, EventArgs e)
        {
            double zhome = Convert.ToDouble(txtBxDockZprobe.Text.Replace(".", ","));
            double ztouch = Convert.ToDouble(txtBxZprobePosition.Text.Replace(".", ","));

            double zProbeOffset = zhome - ztouch;

            zProbeOffset = zProbeOffset - (zProbeOffset * 2.0);

            DialogResult result = MessageBox.Show
                ($"The probe is detecting the bed at {txtBxDockZprobe.Text}" + Environment.NewLine +
                 $"and the nozzle is touching the bed at {txtBxZprobePosition.Text}." + Environment.NewLine + Environment.NewLine +
                 $"The Z_PROBE_OFFSET is {zProbeOffset}." + Environment.NewLine + Environment.NewLine +
                 @"Do you want to update EEPROM with this value?", @"Z Probe offset", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1


                );
            if (result == DialogResult.Cancel) return;
            if (result == DialogResult.Yes)
            {
                _com.Status = MarlinCommunication.Feature.Done;
                UpdateZprobeOffset(zProbeOffset.ToString().Replace(",", "."));
                UpdateEpromZprobeOffset(zProbeOffset.ToString().Replace(",", "."));
            }
        }

        private void UpdateEpromZprobeOffset(string zProbeOffset)
        {
            List<string> commands = new List<string>();
            commands.Add($"M851 Z{zProbeOffset}");
            commands.Add("M500");
            commands.Add("M501");
            _com.SendCommand(commands);
        }

        private void btnM851_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            commands.Add($"M851 Z{txtBxM851.Text}");
            commands.Add("M500");
            commands.Add("M501");
            _com.SendCommand(commands);
        }

        private void grpBxNavigation_Enter(object sender, EventArgs e)
        {

        }

        


        private void nChartControlSurface_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rdoBn3pointLeft_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }

        private void rdoBn3pointRight_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }

        private void rdoBn3pointFront_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }


        private void txtBxProbeLift_Load(object sender, EventArgs e)
        {

        }


        private void btnResetFactorySettings_Click(object sender, EventArgs e)
        {
            _com.SendCommand(new List<string>(new[] { "M502" }));
        }
    }


    /// <summary>
    /// Combobox with Text-Value Keypair. 
    /// </summary>
    public class ComboboxItemTextValue
    {
        /// <summary>
        /// 
        /// </summary>
        public string Text { private get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object Value { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Text;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object ToValue()
        {
            return Value;
        }
    }



    //TODO:: Move to Class for STL thumbnails
    /// <summary>
    /// 
    /// </summary>
    public class FileAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="progID"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="application"></param>
        // Associate file extension with progID, description, icon and application
        public static void Associate(string extension,
               string progID, string description, string icon, string application)
        {
            RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(extension);
            registryKey?.SetValue("", progID);


            if (string.IsNullOrEmpty(progID)) return;
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progID))
            {
                if (description != null)
                {
                    key?.SetValue("", description);
                }
                if (icon != null)
                {
                    var subKey = key?.CreateSubKey("DefaultIcon");
                    subKey?.SetValue("", ToShortPathName(icon));
                }
                if (application != null)
                {
                    var subKey = key?.CreateSubKey(@"Shell\Open\Command");
                    subKey?.SetValue("",ToShortPathName(application) + " \"%1\"");
                }
            }
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        // Return true if extension already associated in registry
        public static bool IsAssociated(string extension)
        {
            return (Registry.ClassesRoot.OpenSubKey(extension, false) != null);
        }

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath,
            [Out] StringBuilder lpszShortPath, uint cchBuffer);

        // Return short path format of a file name
        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            GetShortPathName(longName, s, iSize);
            return s.ToString();
        }

        //    // Tell explorer the file association has been changed
        //    SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
    }

        
}