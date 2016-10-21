using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Marlin3DprinterTool.Properties;
using MarlinComunicationHelper;
using MarlinEditor;
using Microsoft.Win32;
using Nevron;
using Nevron.Chart;
using Nevron.Chart.Windows;
using Configuration = MarlinComunicationHelper.Configuration;
using Position = MarlinComunicationHelper.Position;

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
        private double _fix;


        ///
        public FrmMarlin3DprinterTool()
        {
            InitializeComponent();
            DeligateAndInvoke = new DeligateAndInvoke(this);
        }

        /// <summary>
        ///     All deligates, Callback and Invoke is in separate class
        /// </summary>
        private DeligateAndInvoke DeligateAndInvoke { get; }


        private void Frm3DprinterTool_Load(object sender, EventArgs e)
        {
            DeligateAndInvoke.DisableTabs(tabControl3DprinterTool, false);
            PopulateComboBoxes();
            PopulateConfig();
            fastColoredTextBoxM48Responce.DescriptionFile = "Marlincommunication.xml";

        }

        //private void EnableTabPages(bool enable)
        //{
        //    DeligateAndInvoke.TabPageEnable(tabPageEndstop, enable);
        //    DeligateAndInvoke.TabPageEnable(tabPageBedLevel,enable);
        //    DeligateAndInvoke.TabPageEnable(tabPageConfigurateZprobe,enable);
        //    DeligateAndInvoke.TabPageEnable(tabPageConfigurationBed,enable);
        //    DeligateAndInvoke.TabPageEnable(tabPageExtruderCalibration,enable);
        //    DeligateAndInvoke.TabPageEnable(tabPagePID,enable);
        //    DeligateAndInvoke.TabPageEnable(tabPageZMaintenance,enable);
        //    DeligateAndInvoke.TabPageEnable(tabPageCalculations, true);
        //    DeligateAndInvoke.TabPageEnable(tabPageStlViewer,true);
        //}


        private void PopulateConfig()
        {
            rdoBn3pointAdjusterLeft.Checked = _configuration.BedType == "3pointLeft";
            rdoBn3pointAdjusterRight.Checked = _configuration.BedType == "3pointRight";
            rdoBn4pointAdjuster.Checked = _configuration.BedType == "4point";
            RedesignBedAdjusters();
            txtBxGcodeAssistZprobeEngage.Lines = _configuration.GcodeAssistZprobeEngage.ToArray();
            txtBxGcodeAssistZprobeRelease.Lines = _configuration.GcodeAssistZprobeRelease.ToArray();
            txtBxArduinoIDE.Text = _configuration.ArduinoIde;
            trkBrZmaxTravel.Value = _configuration.ZmaxTravel;
            numUpDnZmaxTravel.Value = _configuration.ZmaxTravel;


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
            //TODO: Hitta X,Y,Z steps-per-unit

            //lblFirmwareExtrudeCalibration.Text =
            //    string.Format(
            //        "#define DEFAULT_AXIS_STEPS_PER_UNIT   {{ {0},{1},{2},{3}}}  // default steps per unit",
            //        200,
            //        200,
            //        3200,
            //        _com.CalculateExtrusionStepsString((int) numUpDnExtrude.Value,
            //            (double) numUpDnFirmware.Value,
            //            (int) numUpDnMeassure.Value));
        }

        private void btnM92_Click(object sender, EventArgs e)
        {
            _com.ExtrudeCalculationUpdate((int) numUpDnExtrude.Value, (double) numUpDnFirmware.Value,
                (int) numUpDnMeassure.Value, false);
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
            //TODO:
            var selectedTab = DeligateAndInvoke.TabControl3DprinterToolSelectedIndex(tabControl3DprinterTool);

            switch (selectedTab)
            {
                case 0:
                    _com.SendCommand("M119"); // Send new M119 only if selected Tab is Enstop Tab = 0
                    break;

                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 7:
                    UpdateZmaintDescription();
                    break;
            }

        }


        private void _com_M114GetCurrentPosition(object sender, CurrentPosition currentPosition)
        {
            _currectPosition.X = currentPosition.Xdouble;
            _currectPosition.Y = currentPosition.Ydouble;
            _currectPosition.Z = currentPosition.Zdouble;


            DeligateAndInvoke.DelegateText(txtBxCalculatedZProbeOffset, _currectPosition.Z.ToString());
            DeligateAndInvoke.DelegateText(txtBxCurrentPositionXConfigBed, _currectPosition.X.ToString());
            DeligateAndInvoke.DelegateText(txtBxCurrentPositionYConfigBed, _currectPosition.Y.ToString());
        }


        private void _com_EndStopStatus(object sender, EndstopStatusList endstopStatus)
        {
            if (endstopStatus.Data[0] != null)
                ledXmin.On = endstopStatus.Data[0].ToLower().Contains("triggered");
            if (endstopStatus.Data[1] != null)
                ledXmax.On = endstopStatus.Data[1].ToLower().Contains("triggered");
            if (endstopStatus.Data[2] != null)
                ledYmin.On = endstopStatus.Data[2].ToLower().Contains("triggered");
            if (endstopStatus.Data[3] != null)
                ledYmax.On = endstopStatus.Data[3].ToLower().Contains("triggered");
            if (endstopStatus.Data[4] != null)
                ledZmin.On = endstopStatus.Data[4].ToLower().Contains("triggered");
            if (endstopStatus.Data[5] != null)
                ledZmax.On = endstopStatus.Data[5].ToLower().Contains("triggered");
            var selectedTab = DeligateAndInvoke.TabControl3DprinterToolSelectedIndex(tabControl3DprinterTool);
            if (selectedTab == 0) _com.SendCommand("M119"); // Send new M119 only if selected Tab is Enstop Tab = 0
        }

        #region
        // TODO: ta bort
        //private void ValidateConfig()
        //{
            //var config = new Configuration();


            //Position position = config.UpperLeftCorner;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveUpperLeftCorner.BackColor = Color.Red;
            //        btnMoveUpperLeftCorner.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveUpperLeftCorner.BackColor = Color.Green;
            //        btnMoveUpperLeftCorner.Enabled = true;
            //    }
            //}

            //position = config.UpperRightCorner;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveUpperRightCorner.BackColor = Color.Red;
            //        btnMoveUpperRightCorner.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveUpperRightCorner.BackColor = Color.Green;
            //        btnMoveUpperRightCorner.Enabled = true;
            //    }
            //}

            //position = config.LowerRightCorner;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveLowerRightCorner.BackColor = Color.Red;
            //        btnMoveLowerRightCorner.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveLowerRightCorner.BackColor = Color.Green;
            //        btnMoveLowerRightCorner.Enabled = true;
            //    }
            //}

            //position = config.LowerLeftCorner;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveLowerLeftCorner.BackColor = Color.Red;
            //        btnMoveLowerLeftCorner.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveLowerLeftCorner.BackColor = Color.Green;
            //        btnMoveLowerLeftCorner.Enabled = true;
            //    }
            //}

            //position = config.UpperLeftAdjuster;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveUpperLeftAdjuster.BackColor = Color.Red;
            //        btnMoveUpperLeftAdjuster.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveUpperLeftAdjuster.BackColor = Color.Green;
            //        btnMoveUpperLeftAdjuster.Enabled = true;
            //    }
            //}

            //position = config.UpperRightAdjuster;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveUpperRightAdjuster.BackColor = Color.Red;
            //        btnMoveUpperRightAdjuster.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveUpperRightAdjuster.BackColor = Color.Green;
            //        btnMoveUpperRightAdjuster.Enabled = true;
            //    }
            //}
            //position = config.LowerRightAdjuster;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveLowerRightAdjuster.BackColor = Color.Red;
            //        btnMoveLowerRightAdjuster.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveLowerRightAdjuster.BackColor = Color.Green;
            //        btnMoveLowerRightAdjuster.Enabled = true;
            //    }
            //}

            //position = config.LowerLeftAdjuster;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveLowerLeftAdjuster.BackColor = Color.Red;
            //        btnMoveLowerLeftAdjuster.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveLowerLeftAdjuster.BackColor = Color.Green;
            //        btnMoveLowerLeftAdjuster.Enabled = true;
            //    }
            //}

            //position = config.SafeHome;
            //if (position != null)
            //{
            //    if (position.X > 9000 && position.Y > 9000)
            //    {
            //        btnSaveSafeHome.BackColor = Color.Red;
            //        btnMoveSafeHome.Enabled = false;
            //    }
            //    else
            //    {
            //        btnSaveSafeHome.BackColor = Color.Green;
            //        btnMoveSafeHome.Enabled = true;
            //    }
            //}

            //if (chkListBxAdjustment.CheckedItems.Count != 0)
            //{
            //    btnSaveAdjustment.BackColor = Color.Green;
            //    chkListBxAdjustment.BackColor = Color.Green;
            //}
            //else
            //{
            //    btnSaveAdjustment.BackColor = Color.Red;
            //    chkListBxAdjustment.BackColor = Color.Red;
            //}
        //}

        #endregion

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

        private void btnM48Repetition_Click(object sender, EventArgs e)
        {
            var commands = new List<string>
            {
                "G28 Y",
                "G28 X",
                "G28 Z",
                $"M48 P{numUpDnM48Repetitions.Value} X{_configuration.SafeHome.X} Y{_configuration.SafeHome.Y} V4"
            };
            _com.SendCommand(commands);
        }


        private void btnProbeTheBed_Click(object sender, EventArgs e)
        {
            nChartControlSurface.Charts[0].Series.Clear();
            nChartControlSurface.Refresh();

            List<Point> probePointsList = new List<Point>();
            if (_configuration.BedType == "4point")
            {  
                probePointsList.Add(new Point((int)_configuration.LowerLeftAdjuster.X, (int)_configuration.LowerLeftAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.LowerRightAdjuster.X, (int)_configuration.LowerRightAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.UpperRightAdjuster.X, (int)_configuration.UpperRightAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.UpperLeftAdjuster.X, (int)_configuration.UpperLeftAdjuster.Y));
            }
               

            if (_configuration.BedType == "3pointLeft")
            {
                probePointsList.Add(new Point((int)_configuration.LowerLeftAdjuster.X, (int)_configuration.LowerLeftAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.LowerRightAdjuster.X, (int)_configuration.LowerRightAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.UpperRightAdjuster.X, (int)_configuration.UpperRightAdjuster.Y));
                //probePointsList.Add(new Point((int)_configuration.UpperLeftAdjuster.X, (int)_configuration.UpperLeftAdjuster.Y));
            }

            if (_configuration.BedType == "3pointRight")
            {
                probePointsList.Add(new Point((int)_configuration.LowerLeftAdjuster.X, (int)_configuration.LowerLeftAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.LowerRightAdjuster.X, (int)_configuration.LowerRightAdjuster.Y));
                //probePointsList.Add(new Point((int)_configuration.UpperRightAdjuster.X, (int)_configuration.UpperRightAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.UpperLeftAdjuster.X, (int)_configuration.UpperLeftAdjuster.Y));
            }

            if (_configuration.BedType == "3pointFront")
            {
                probePointsList.Add(new Point((int)_configuration.LowerLeftAdjuster.X, (int)_configuration.LowerLeftAdjuster.Y));
                //probePointsList.Add(new Point((int)_configuration.LowerRightAdjuster.X, (int)_configuration.LowerRightAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.UpperRightAdjuster.X, (int)_configuration.UpperRightAdjuster.Y));
                probePointsList.Add(new Point((int)_configuration.UpperLeftAdjuster.X, (int)_configuration.UpperLeftAdjuster.Y));
            }
            
            ScanSurface(probePointsList, 1);
        }

        private void ScanSurface(List<Point> probePointsList,  int numberOfRepetitions)
        {
            var result = MessageBox.Show(@"Do you want to engare the Z-probe?", @"Engage Z-probe",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var conf = new Configuration();
                _com.SendCommand(conf.GcodeAssistZprobeEngage);
            }

            var commands = new List<string> { "M420 S0", "G28 Y", "G28 X", "G28 Z" };

            _probePoints.Clear();

            _com.ProbeResponceList = new List<Position>(); // Create a new probe responce list
            
            foreach (Point probePoint in probePointsList)
            {
                // move to X&Y
                commands.Add($"G1 X{probePoint.X}.0 Y{probePoint.Y}.0 Z40.0 F8000");
                //commands.Add("G1 Z40");
                
                for (var i = 0; i < numberOfRepetitions; i++)
                {
                    // probe the point
                    commands.Add("G30 S-1");
                    commands.Add($"G1 X{probePoint.X}.0 Y{probePoint.Y}.0 Z40.0 F6000");
                }
            }

            commands.Add($"G1 X{_configuration.SafeHome.X}.0 Y{_configuration.SafeHome.Y}.0 Z40.0 F5000");
            _com.SendCommand(commands);
        }


        private void ScanSurface(int numberOfXpoint, int numberOfYpoints, int numberOfRepetitions)
        {

            List<Point> probePointsList = new List<Point>();
            
            var xMin = (int) Convert.ToDecimal(_configuration.LowerLeftAdjuster.X);
            var xMax = (int) Convert.ToDecimal(_configuration.LowerRightAdjuster.X);
            var xStep = (xMax - xMin)/(numberOfXpoint - 1);

            var yMin = (int) Convert.ToDecimal(_configuration.LowerLeftAdjuster.Y);
            var yMax = (int) Convert.ToDecimal(_configuration.UpperLeftAdjuster.Y);
            var yStep = (yMax - yMin)/(numberOfYpoints - 1);

            
            _probePoints.Clear();

            for (var y = yMin; y <= yMax; y += yStep)
            {
                for (var x = xMin; x <= xMax; x += xStep)
                {
                    //TODO: Multiple probe on point = numberOfRepetitions
                    for (int repetition = 0; repetition < numberOfRepetitions; repetition++)
                    {
                        // probePointsList.Add(new Point(x,y));    
                    }
                    probePointsList.Add(new Point(x,y));
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
            var commands = new List<string>();

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
        }


        private void btnZprobeHeightNext_Click(object sender, EventArgs e)
        {

            txtBxJogControlZprobeHeightHelp.Visible = false;
            btnZprobeHeightNext.Visible = false;
            verticalJogControlZprobeHeight.BackColor = SystemColors.Control;
            verticalJogControlZprobeHeight.Visible100Movement = true;
            verticalJogControlZprobeHeight.VisibleZero = true;
            verticalJogControlZprobeHeight.Visible = false;

            kompassControllConfigBed.Visible = true;
            btnHomeX.Visible = true;
            btnHomeY.Visible = true;
            grpBxBed.Visible = true;

            var commands = new List<string> {"G92 Z0", "M114", "G1 Z50"};
            _com.SendCommand(commands);

            var result = MessageBox.Show(@"Remove the paper under the nozzle and continue.",
                @"Removing the paper", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.Cancel) return;


            lblCalculatedZProbeOffset.Visible = true;
            txtBxCalculatedZProbeOffset.Visible = false;
            btnZpromeFirmwareUpdate.Visible = false;
            btnZpromeEepromUpdate.Visible = false;

            _com.ProbeResponceList = new List<Position>(); //Clear the proberesponcelist fron old probing

            _com.SendCommand("G30");
        }

        #region Pupulating Form

        private void PopulateComboBoxes()
        {


            cmbBxLeadScrewMotorStepAngle.Items.Clear();
            cmbBxLeadScrewMotorStepAngle.Items.Add(new ComboboxItemTextValue {Text = @"1.8°", Value = (int) (360.0/1.8)});
            cmbBxLeadScrewMotorStepAngle.Items.Add(new ComboboxItemTextValue { Text = @"0.9°", Value = (int)(360.0 / 0.9) });
            cmbBxLeadScrewMotorStepAngle.Items.Add(new ComboboxItemTextValue { Text = @"7.5°", Value = (int)(360.0 / 7.5) });
            cmbBxLeadScrewMotorStepAngle.Text = @"1.8°";

            cmbBxLeadScrewDriverMicrostepping.Items.Clear();
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1    - Full step",    Value = (float)(1/(1.0 / 1.0))  });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/2  - Half step",    Value = (float)(1/(1.0 / 2.0))  });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/4  - Quarter step", Value = (float)(1/(1.0 / 4.0))  });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/8  - Micro step",   Value = (float)(1/(1.0 / 8.0))  });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/16 - Micro step",   Value = (float)(1/(1.0 / 16.0)) });
            cmbBxLeadScrewDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/32 - Micro step",   Value = (float)(1/(1.0 / 32.0)) });
            cmbBxLeadScrewDriverMicrostepping.Text = @"1/16 - Micro step";

            cmbBxLeadScrewPitch.Items.Clear();
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue { Text = @"M8 - Metric (1.25mm / revolution)", Value = (float)(1.25) });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue { Text = @"M6 - Metric (1.00mm / revolution)", Value = (float)(1.00) });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue { Text = @"M5 - Metric (0.80mm / revolution)", Value = (float)(0.80) });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue { Text = @"5/16-18 imperial coarse (1.41111mm / revolution)", Value = (float)(1.41111) });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue { Text = @"1/4-16 - Acme (1.5875mm / revolution", Value = (float)(1.5875) });
            cmbBxLeadScrewPitch.Items.Add(new ComboboxItemTextValue { Text = @"8mm Trapezoidal Threaded (2.00mm / revolution", Value = (float)(2.00) });
            cmbBxLeadScrewPitch.Text = @"8mm Trapezoidal Threaded (2.00mm / revolution";

            cmbBxBeltMotorStepAngle.Items.Clear();
            cmbBxBeltMotorStepAngle.Items.Add(new ComboboxItemTextValue { Text = @"1.8°", Value = (int)(360.0 / 1.8) });
            cmbBxBeltMotorStepAngle.Items.Add(new ComboboxItemTextValue { Text = @"0.9°", Value = (int)(360.0 / 0.9) });
            cmbBxBeltMotorStepAngle.Items.Add(new ComboboxItemTextValue { Text = @"7.5°", Value = (int)(360.0 / 7.5) });
            cmbBxBeltMotorStepAngle.Text = @"1.8°";

            cmbBxBeltDriverMicrostepping.Items.Clear();
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1    - Full step",    Value = (float)(1/(1.0 / 1.0)) });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/2  - Half step",    Value = (float)(1/(1.0 / 2.0)) });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/4  - Quarter step", Value = (float)(1/(1.0 / 4.0)) });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/8  - Micro step",   Value = (float)(1/(1.0 / 8.0)) });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/16 - Micro step",   Value = (float)(1/(1.0 / 16.0)) });
            cmbBxBeltDriverMicrostepping.Items.Add(new ComboboxItemTextValue { Text = @"1/32 - Micro step",   Value = (float)(1/(1.0 / 32.0)) });
            cmbBxBeltDriverMicrostepping.Text = @"1/16 - Micro step";

            cmbBxBeltPitch.Items.Clear();
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue { Text = @"2mm   - Metric (GT2)", Value = (float)(2.00) });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue { Text = @"2.5mm - Metric (T2.5)", Value = (float)(2.50) });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue { Text = @"3mm   - Metric (GT2, HTD)", Value = (float)(3.00) });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue { Text = @"5mm   - Metric (T5,GT2, HTD)", Value = (float)(5.00) });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue { Text = @"MXL   - Inch   (2.03mm)", Value = (float)(2.03) });
            cmbBxBeltPitch.Items.Add(new ComboboxItemTextValue { Text = @"XL    - Inch   (5.08mm)", Value = (float)(5.08) });
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
            grpBxCalculate.Visible = chkBxColdExtruderCalibration.Checked;
        }


        private void btnExtruderCalibation_Click(object sender, EventArgs e)
        {
            var extrudeCalibration = new List<string> {"M503"};
            if (chkBxColdExtruderCalibration.Checked)
            {
                extrudeCalibration.Add("M302"); // Allow cold extrusion
            }


            extrudeCalibration.Add("G92 E0");
            extrudeCalibration.Add($"G1 E{numUpDnExtrude.Value}F20");
            _com.SendCommand(extrudeCalibration);
        }

        private void Frm3DprinterTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_com.IsPortOpen) _com.DisConnect();
        }

        private void btnHeatExtruderForCalibration_Click(object sender, EventArgs e)
        {
            var commands = new List<string>();


            chartTemperature.Series["Extruder"].Points.Clear();
            chartTemperature.Series["SetExtruder"].Points.Clear();
            chartTemperature.Series["Bed"].Points.Clear();
            chartTemperature.Series["SetBed"].Points.Clear();


            _temperatureStopwatch.Reset();
            _temperatureStopwatch.Start();


            //SENT: M104 S195 T0
            commands.Add($"M109 S{Convert.ToDouble(numUpDnCalibrateExtruderTemp.Value)}");
            _com.SendCommand(commands);
        }

    


        private void Kill()
        {
            _com.Kill = true;
            MessageBox.Show(
                @"You have to use the Disconnect button and then Connect button to reset Emergency Switch. +\n\n" +
                @"Do not disconnect the USB cable.", @"Emergency Switch", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void btnCalculateExtruderPid_Click(object sender, EventArgs e)
        {
            txtBxPIDresponce.Text = "";
            
            chartTemperature.Series["Extruder"].Points.Clear();
            chartTemperature.Series["SetExtruder"].Points.Clear();
            chartTemperature.Series["Bed"].Points.Clear();
            chartTemperature.Series["SetBed"].Points.Clear();


            _com.ClearReceived();
            _com.SendCommand($"M303 E0 S{numUpDownPidExtruderTemp.Value} C{numUpDownPidExtruderCykles.Value}");
        }

        private void btnStartZprobeHeight_Click(object sender, EventArgs e)
        {
            txtBxJogControlZprobeHeightHelp.Visible = false;
            verticalJogControlZprobeHeight.Visible = false;
            btnZprobeHeightNext.Visible = false;
            lblCalculatedZProbeOffset.Visible = false;
            txtBxCalculatedZProbeOffset.Visible = false;
            btnZpromeFirmwareUpdate.Visible = false;
            btnZpromeEepromUpdate.Visible = false;

            kompassControllConfigBed.Visible = false;
            btnHomeX.Visible = false;
            btnHomeY.Visible = false;
            grpBxBed.Visible = false;

            var result = MessageBox.Show(@"Do you want to engare the Z-probe?", @"Engage Z-probe",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var conf = new Configuration();
                _com.SendCommand(conf.GcodeAssistZprobeEngage);
            }

            if (result == DialogResult.Cancel) return;
            result = MessageBox.Show(@"Home the Z-probe?", @"Homing the Z-probe",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.Cancel)
            {
                var commands = new List<string> {"G28 Z", "M114", "G92 Z0", "M114"};
                _com.SendCommand(commands);
            }
            if (result == DialogResult.Cancel) return;


            verticalJogControlZprobeHeight.BackColor = Color.Green;
            verticalJogControlZprobeHeight.Visible100Movement = false;
            verticalJogControlZprobeHeight.VisibleZero = false;
            txtBxJogControlZprobeHeightHelp.Visible = true;
            verticalJogControlZprobeHeight.Visible = true;
            btnZprobeHeightNext.Visible = true;
            lblCalculatedZProbeOffset.Visible = false;
            txtBxCalculatedZProbeOffset.Visible = false;
            btnZpromeFirmwareUpdate.Visible = false;
            btnZpromeEepromUpdate.Visible = false;
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
            txtBxPIDresponce.Text = "";
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
                    _com.M119EndStopStatus += _com_EndStopStatus;
                    _com.M301Responce += _com_M301Responce;
                    _com.M303Responce += _com_M303Responce;
                    _com.M304Responce += _com_M304Responce;
                    _com.M500Responce += _com_M500Responce;
                    _com.M501Responce += _com_M501Responce;
                    _com.ReadyForNextCommand += _com_ReadyForNextCommand;
                    
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

        

        private void _com_Temperatures(object sender, Temperatures temperatures)
        {
            DeligateAndInvoke.SetExtruderTemp(chartTemperature, (int) _temperatureStopwatch.Elapsed.TotalSeconds,
                (int) temperatures.Extruder, (int) temperatures.SetExtruder);

            DeligateAndInvoke.SetBedTemp(chartTemperature, (int) _temperatureStopwatch.Elapsed.TotalSeconds,
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

            var pidResponce = "";

            foreach (var line in linesList)
            {
                pidResponce += line + Environment.NewLine;
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
                        @"It looks like Firmware had BedPID disabled", @"BedPID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                if (matchKp.Success)
                {
                    DeligateAndInvoke.DelegateText(txtBxKpExtruder, matchKp.Value);
                }
                if (matchKi.Success)
                {
                    DeligateAndInvoke.DelegateText(txtBxKiExtruder, matchKi.Value);
                }
                if (matchKd.Success)
                {
                    DeligateAndInvoke.DelegateText(txtBxKdExtruder, matchKd.Value);
                }


            } 

            



            DeligateAndInvoke.DelegateText(txtBxPIDresponce, pidResponce);
        }

        private void _com_M304Responce(object sender, ResponceData responce)
        {
           // TODO: SHOW EEPROM
        }


        private void _com_M500Responce(object sender, ResponceData responce)
        {
            // TODO: Show saved EEPROM
            MessageBox.Show(responce.Data, @"Saved EEPROM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _com_M501Responce(object sender, ResponceData responce)
        {
            MessageBox.Show(responce.Data, @"Data in EEPROM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _com_G30ProbeResponce(object sender, List<Position> probePositions)
        {
            

            // Z-ProbeHeight 
            if (lblCalculatedZProbeOffset.Visible)
            {
                DeligateAndInvoke.DelegateVisible(txtBxCalculatedZProbeOffset, true);
                DeligateAndInvoke.DelegateVisible(btnZpromeFirmwareUpdate,true);
                DeligateAndInvoke.DelegateVisible(btnZpromeEepromUpdate,true);
                foreach (var position in probePositions)
                {
                    DeligateAndInvoke.DelegateText(txtBxCalculatedZProbeOffset, position.Z.ToString());
                }
            }
            //! Z-ProbeHeight
        }

        private void _com_Init(object sender, ResponceData e)
        {
            //Enable TAB
            DeligateAndInvoke.DisableTabs(tabControl3DprinterTool,true);
            
            
            //Enable EmergencyStop
            DeligateAndInvoke.DelegateBackgroundImage(btnEmergency, Resources.emargency_enabled);
            DeligateAndInvoke.DelegateVisible(btnEmergency, true);
            DeligateAndInvoke.DelegateEnabled(btnEmergency, true);

            // Enable/visible ShowCommunication
            DeligateAndInvoke.DelegateVisible(btnShowCommunication, true);
            DeligateAndInvoke.DelegateEnabled(btnShowCommunication, true);

            // Show navigation
            DeligateAndInvoke.DelegateVisible(grpBxNavigation, true);

            //// Assign Marlincommunication
            DeligateAndInvoke.DelegateKompassControll(kompassControllConfigBed, _com);
            DeligateAndInvoke.DelegateVerticalJogControl(verticalJogControlZprobeHeight, _com);


            // Show temperature Chart
            DeligateAndInvoke.DelegateVisible(chartTemperature, true);


            // Start the temperature stopwatch
            _temperatureStopwatch.Reset();
            _temperatureStopwatch.Start();

            MessageBox.Show(e.Data.Replace("\n", Environment.NewLine), @"Marlin Init", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            var selectedTab = DeligateAndInvoke.TabControl3DprinterToolSelectedIndex(tabControl3DprinterTool);
            if (selectedTab == 0) _com.SendCommand("M119"); // Send new M119 only if selected Tab is Enstop Tab = 0
        }

       

        private void _com_ReadyForNextCommand(object sender, EventArgs e)
        {
            var selectedTab = DeligateAndInvoke.TabControl3DprinterToolSelectedIndex(tabControl3DprinterTool);


            switch (selectedTab)
            {
                case 0:
                    _com.SendCommand("M119");
                    break;
                case 3: // Bedlevel

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


                            var thread = 0.5;

                            if (chkListBxAdjustment.CheckedItems.Count != 0)
                            {
                                if ((string) chkListBxAdjustment.CheckedItems[0] == "M3")
                                {
                                    thread = 0.5;
                                }
                                else if ((string) chkListBxAdjustment.CheckedItems[0] == "M4")
                                {
                                    thread = 0.7;
                                }
                                else if ((string) chkListBxAdjustment.CheckedItems[0] == "M5")
                                {
                                    thread = 0.8;
                                }
                            }


                            var adjust = (_fix - probeResponce.Z)/thread;
                            var sign = adjust <= 0 ? "+" : "-";
                            var turn = Math.Truncate(adjust);
                            var decimalpart = adjust - turn;
                            var minutes = (int) (decimalpart*60);

                            //Lower Left Adjuster
                            if ((Math.Abs(_configuration.LowerLeftAdjuster.X - probeResponce.X) < 35) &&
                                (Math.Abs(_configuration.LowerLeftAdjuster.Y - probeResponce.Y) < 35))
                            {
                                DeligateAndInvoke.DelegateText(lblTurn1, @"No adjustments");
                                DeligateAndInvoke.DelegateText(lblAdjustValue1, probeResponce.Z.ToString());
                                _fix = probeResponce.Z;
                            }

                            //Lower Right Adjuster
                            if ((Math.Abs(_configuration.LowerRightAdjuster.X - probeResponce.X) < 35) &&
                                (Math.Abs(_configuration.LowerRightAdjuster.Y - probeResponce.Y) < 35))
                            {
                                DeligateAndInvoke.DelegateBackgroundImage(picBxTurn2,
                                    adjust <= 0 ? Resources.clockwise : Resources.counterclockwise);
                                DeligateAndInvoke.DelegateText(lblTurn2,
                                    $"{sign} {Math.Abs(turn)}:{Math.Abs(minutes)} minutes");
                                DeligateAndInvoke.DelegateText(lblAdjustValue2, probeResponce.Z.ToString());
                            }


                            //Upper Right Adjuster
                            if ((Math.Abs(_configuration.UpperRightAdjuster.X - probeResponce.X) < 35) &&
                                (Math.Abs(_configuration.UpperRightAdjuster.Y - probeResponce.Y) < 35))
                            {
                                DeligateAndInvoke.DelegateBackgroundImage(picBxTurn3,
                                    adjust <= 0 ? Resources.clockwise : Resources.counterclockwise);
                                DeligateAndInvoke.DelegateText(lblTurn3,
                                    $"{sign} {Math.Abs(turn)}:{Math.Abs(minutes)} minutes");
                                DeligateAndInvoke.DelegateText(lblAdjustValue3, probeResponce.Z.ToString());
                            }

                            //Upper Left Adjuster
                            if ((Math.Abs(_configuration.UpperLeftAdjuster.X - probeResponce.X) < 35) &&
                                (Math.Abs(_configuration.UpperLeftAdjuster.Y - probeResponce.Y) < 35))
                            {
                                DeligateAndInvoke.DelegateBackgroundImage(picBxTurn4,
                                    adjust <= 0 ? Resources.clockwise : Resources.counterclockwise);
                                DeligateAndInvoke.DelegateText(lblTurn4,
                                    $"{sign} {Math.Abs(turn)}:{Math.Abs(minutes)} minutes");
                                DeligateAndInvoke.DelegateText(lblAdjustValue4, probeResponce.Z.ToString());
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
                    CreateSurfaceChart();
                    break;
                case 4: // SurfaceScan
                    CreateSurfaceChart();

                    //TODO: tabort
                    //NLicense license = new NLicense("001800d6-4511-4600-6a35-050c5793dd94");
                    //NLicenseManager.Instance.SetLicense(license);
                    //NLicenseManager.Instance.LockLicense = true;

                    //NChart chart = nChartControlSurface.Charts[0];
                    //chart.Enable3D = true;
                    //chart.Width = 60;
                    //chart.Height = 50;
                    //chart.Depth = 60;
                    //nChartControlSurface.Legends.Clear();


                    //NTriangulatedSurfaceSeries surface = new NTriangulatedSurfaceSeries { SmoothPalette = true };

                    //if (_com.ProbeResponceList != null)
                    //{
                    //    foreach (Position position in _com.ProbeResponceList)
                    //    {
                    //        surface.XValues.Add(position.X);
                    //        surface.Values.Add(position.Z);
                    //        surface.ZValues.Add(position.Y);
                    //    }

                    //    chart.Series.Add(surface);

                    //    nChartControlSurface.Controller.Tools.Add(new NPanelSelectorTool());
                    //    nChartControlSurface.Controller.Tools.Add(new NTrackballTool());
                    //}

                    //nChartControlSurface.Refresh();

                    break;
            }
        }

        private void CreateSurfaceChart()
        {
            var license = new NLicense("001800d6-4511-4600-6a35-050c5793dd94");
            NLicenseManager.Instance.SetLicense(license);
            NLicenseManager.Instance.LockLicense = true;

            var chart = nChartControlSurface.Charts[0];
            chart.Enable3D = true;
            chart.Width = 60;
            chart.Height = 50;
            chart.Depth = 60;
            nChartControlSurface.Legends.Clear();


            var surface = new NTriangulatedSurfaceSeries {SmoothPalette = true};

            if (_com.ProbeResponceList != null)
            {
                foreach (var position in _com.ProbeResponceList)
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
            btnConnect.Text = @"Connect";

            //Disable TAB
            DeligateAndInvoke.DisableTabs(tabControl3DprinterTool, false);

            //Disable EmergencyStop
            btnEmergency.BackgroundImage = Resources.emargency_disabled;
            btnEmergency.Visible = false;
            btnEmergency.Enabled = false;

            // DisableEnable/Hide ShowCommunication
            btnShowCommunication.Visible = false;
            btnShowCommunication.Enabled = false;

            // Show navigation
            grpBxNavigation.Visible = false;

            verticalJogControlZprobeHeight.MarlinCommunication = null;
            kompassControllConfigBed.MarlinCommunication = null;

            // Show temperature Chart
            chartTemperature.Visible = true;

            // Stop the temperature stopwatch
            _temperatureStopwatch.Reset();
            _temperatureStopwatch.Stop();
        }

        private void _com_Connected(object sender, EventArgs e)
        {
            btnConnect.Text = @"DisConnect";
            _configuration.ComPort = _com.Port;
            _configuration.Baudrate = _com.BaudRate;
        }

        private void _com_G29Responce(object sender, Responce responce)
        {
            DeligateAndInvoke.MultiTextLines(txtBxAutoBedLevelResponce, responce.ResponsRowList);
        }


        private void _com_M48ProbeStatus(object sender, Responce responce)
        {
            //ok
            //ok
            //ok
            //M48 Z - Probe Repeatability test.   Version 2.00
            //Full support at: http://3dprintboard.com/forum.php
            //Positioning probe for the test.
            //1 of 4   z: 8.705000 mean: 8.705000   sigma: 0.000000
            //2 of 4   z: 8.706875 mean: 8.705938   sigma: 0.000937
            //3 of 4   z: 8.705313 mean: 8.705730   sigma: 0.000820
            //4 of 4   z: 8.707813 mean: 8.706251   sigma: 0.001148
            //Mean: 8.706251
            //Standard Deviation: 0.001148
            //            ok
            //            echo:endstops hit:  Z:8.71
            //            ok


            DeligateAndInvoke.FastColoredTextBox(fastColoredTextBoxM48Responce, responce.ResponsRowList);
        }

        #endregion

        #region MoveToPosition

        private void btnMoveUpperLeftAdjuster_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.UpperLeftAdjuster;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveLowerLeftAdjuster_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.LowerLeftAdjuster;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveLowerLeftCorner_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.LowerLeftCorner;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveLowerRightCorner_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.LowerRightCorner;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveLowerRightAdjuster_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.LowerRightAdjuster;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveUpperRightAdjuster_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.UpperRightAdjuster;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveUpperRightCorner_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.UpperRightCorner;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveUpperLeftCorner_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.UpperLeftCorner;
            MoveToPosition(position.X, position.Y);
        }

        private void btnMoveSafeHome_Click(object sender, EventArgs e)
        {
            var config = new Configuration();
            var position = config.SafeHome;
            MoveToPosition(position.X, position.Y);
        }

        private void MoveToPosition(double x, double y)
        {
            _com.SendCommand($"G1 X{x} Y{y}");
            _com.SendCommand("M114");
        }

        #endregion

        #region SetPosition

        private void btnSaveLowerLeftAdjuster_Click(object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");

            _configuration.LowerLeftAdjuster = _currectPosition;
           
        }

        private void btnSaveUpperLeftAdjuster_Click(object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");

            _configuration.UpperLeftAdjuster = _currectPosition;
            
        }

        private void btnSaveLowerLeftCorner_Click(object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");

            _configuration.LowerLeftCorner = _currectPosition;
            
        }

        private void btnSaveLowerRightCorner_Click(object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");

            _configuration.LowerRightCorner = _currectPosition;
            
        }

        private void btnSaveLowerRightAdjuster_Click(object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");

            _configuration.LowerRightAdjuster = _currectPosition;
            
        }

        private void btnSaveUpperRightAdjuster_Click(object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");

            _configuration.UpperRightAdjuster = _currectPosition;
            
        }

        private void btnSaveUpperRightCorner_Click(object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");


            _configuration.UpperRightCorner = _currectPosition;
            
        }


        private void btnSaveUpperLeftCorner_Click
            (object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");


            _configuration.UpperLeftCorner = _currectPosition;
            
        }

        private void btnSaveSafeHome_Click
            (object sender, EventArgs e)
        {
            // Get current position
            _com.SendCommand("M114");

            _configuration.SafeHome = _currectPosition;
            
        }

        #endregion

        private void btnMeshLevel_Click(object sender, EventArgs e)
        {
            //TODO: get existing mash level data
            // G29 S0 = show Mesh Level Data

            // G29 S3 Xn Yn Zn Set value to meshpoint

            // G29 Zn Set Z offset

            // Save to EEPROM M50x


        }

        private void btnUpdateExtruderPid_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>
            {
                $"M301 P{txtBxKpExtruder.Text} I{txtBxKiExtruder.Text} D{txtBxKdExtruder.Text}","M500"
            };
            // M301 P19.56 I0.71 D134.26
            _com.SendCommand(commands);

        }

        private void btnUpdateBedPid_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>
            {
                $"M304 P{txtBxKpBed.Text} I{txtBxKiBed.Text} D{txtBxKdBed.Text}","M500"
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
            marlinEditor.UpdateAndSavePidExtruder(txtBxKpExtruder.Text, txtBxKiExtruder.Text,txtBxKdExtruder.Text);
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
            _com.SendCommand(new List<string>(new[] { "M500" }));
        }

        private void btnM501ReadEeprom_Click(object sender, EventArgs e)
        {
            _com.Gcode = "";
            _com.ClearCommunication();
            _com.SendCommand(new List<string>(new[] { "M501" }));

        }

        private void btnZpromeEepromUpdate_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>
            {
                $"M851 Z-{txtBxCalculatedZProbeOffset.Text.Replace(',', '.')}","M500"
            };
            _com.SendCommand(commands);
            
        }

       

        private void RedesignBedAdjusters()
        {
            if (rdoBn4pointAdjuster.Checked)
            {
                _configuration.BedType = "4point";
                btnSaveLowerLeftAdjuster.Visible = true;
                btnSaveLowerLeftAdjuster.Location = new Point(5,200);
                btnMoveLowerLeftAdjuster.Visible = true;
                btnMoveLowerLeftAdjuster.Location = new Point(50, 200);

                btnSaveLowerRightAdjuster.Visible = true;
                btnSaveLowerRightAdjuster.Location = new Point(430, 200);
                btnMoveLowerRightAdjuster.Visible = true;
                btnMoveLowerRightAdjuster.Location = new Point(390, 200);
            
                btnSaveUpperLeftAdjuster.Visible = true;
                btnSaveUpperLeftAdjuster.Location = new Point(5, 100);
                btnMoveUpperLeftAdjuster.Visible = true;
                btnMoveUpperLeftAdjuster.Location = new Point(50, 100);

                btnSaveUpperRightAdjuster.Visible = true;
                btnSaveUpperRightAdjuster.Location = new Point(430, 100);
                btnMoveUpperRightAdjuster.Visible = true;
                btnMoveUpperRightAdjuster.Location = new Point(390, 100);


                panel1.Visible = true;
                panelAdjust1.Location = new Point(20,234);

                picBxLowerLeftAdjuster.Visible = true;
                picBxLowerLeftAdjuster.Location = new Point(126,238);

                panelAdjust2.Visible = true;
                panelAdjust2.Location = new Point(663, 234);

                picBxLowerRightAdjuster.Visible = true;
                picBxLowerRightAdjuster.Location = new Point(624, 238);

                panelAdjust3.Visible = true;
                panelAdjust3.Location = new Point(668, 38);

                picBxUpperLeftAdjuster.Visible = true;
                picBxUpperLeftAdjuster.Location = new Point(624, 42);

                panelAdjust4.Visible = true;
                panelAdjust4.Location = new Point(20, 38);

                picBxUpperRightAdjuster.Visible = true;
                picBxUpperRightAdjuster.Location = new Point(126, 42);

            }
            else
            if (rdoBn3pointAdjusterRight.Checked)
            {
                _configuration.BedType = "3pointRight";
                btnSaveLowerLeftAdjuster.Visible = true;
                btnSaveLowerLeftAdjuster.Location = new Point(5, 200);
                btnMoveLowerLeftAdjuster.Visible = true;
                btnMoveLowerLeftAdjuster.Location = new Point(50, 200);

                btnSaveLowerRightAdjuster.Visible = true;
                btnSaveLowerRightAdjuster.Location = new Point(430, 150);
                btnMoveLowerRightAdjuster.Visible = true;
                btnMoveLowerRightAdjuster.Location = new Point(390, 150);

                btnSaveUpperLeftAdjuster.Visible = true;
                btnSaveUpperLeftAdjuster.Location = new Point(5, 100);
                btnMoveUpperLeftAdjuster.Visible = true;
                btnMoveUpperLeftAdjuster.Location = new Point(50, 100);

                btnSaveUpperRightAdjuster.Visible = false;
                btnSaveUpperRightAdjuster.Location = new Point(430, 100);
                btnMoveUpperRightAdjuster.Visible = false;
                btnMoveUpperRightAdjuster.Location = new Point(390, 98);


                panel1.Visible = true;
                panelAdjust1.Location = new Point(20, 234);

                picBxLowerLeftAdjuster.Visible = true;
                picBxLowerLeftAdjuster.Location = new Point(126, 238);

                panelAdjust2.Visible = true;
                panelAdjust2.Location = new Point(663, 134);

                picBxLowerRightAdjuster.Visible = true;
                picBxLowerRightAdjuster.Location = new Point(624, 140);

                panelAdjust3.Visible = false;
                panelAdjust3.Location = new Point(668, 38);

                picBxUpperLeftAdjuster.Visible = false;
                picBxUpperLeftAdjuster.Location = new Point(624, 42);

                panelAdjust4.Visible = true;
                panelAdjust4.Location = new Point(20, 38);

                picBxUpperRightAdjuster.Visible = true;
                picBxUpperRightAdjuster.Location = new Point(126, 42);
            }
            else
            if (rdoBn3pointAdjusterLeft.Checked)
            {
                _configuration.BedType = "3pointLeft";
                btnSaveLowerLeftAdjuster.Visible = true;
                btnSaveLowerLeftAdjuster.Location = new Point(5, 150);
                btnMoveLowerLeftAdjuster.Visible = true;
                btnMoveLowerLeftAdjuster.Location = new Point(50, 150);

                btnSaveLowerRightAdjuster.Visible = true;
                btnSaveLowerRightAdjuster.Location = new Point(430, 200);
                btnMoveLowerRightAdjuster.Visible = true;
                btnMoveLowerRightAdjuster.Location = new Point(390, 200);

                btnSaveUpperLeftAdjuster.Visible = false;
                btnSaveUpperLeftAdjuster.Location = new Point(5, 100);
                btnMoveUpperLeftAdjuster.Visible = false;
                btnMoveUpperLeftAdjuster.Location = new Point(50, 100);

                btnSaveUpperRightAdjuster.Visible = true;
                btnSaveUpperRightAdjuster.Location = new Point(430, 100);
                btnMoveUpperRightAdjuster.Visible = true;
                btnMoveUpperRightAdjuster.Location = new Point(390, 100);


                panel1.Visible = true;
                panelAdjust1.Location = new Point(20, 130);

                picBxLowerLeftAdjuster.Visible = true;
                picBxLowerLeftAdjuster.Location = new Point(126, 134);

                panelAdjust2.Visible = true;
                panelAdjust2.Location = new Point(663, 234);

                picBxLowerRightAdjuster.Visible = true;
                picBxLowerRightAdjuster.Location = new Point(624, 238);

                panelAdjust3.Visible = true;
                panelAdjust3.Location = new Point(668, 38);

                picBxUpperLeftAdjuster.Visible = true;
                picBxUpperLeftAdjuster.Location = new Point(624, 42);

                panelAdjust4.Visible = false;
                panelAdjust4.Location = new Point(20, 38);

                picBxUpperRightAdjuster.Visible = false;
                picBxUpperRightAdjuster.Location = new Point(126, 42);


            }
            else
            if (rdoBn3pointAdjusterFront.Checked)
            {
                _configuration.BedType = "3pointFront";
                btnSaveLowerLeftAdjuster.Visible = true;
                btnSaveLowerLeftAdjuster.Location = new Point(171, 334);
                btnMoveLowerLeftAdjuster.Visible = true;
                btnMoveLowerLeftAdjuster.Location = new Point(218, 334);

                btnSaveLowerRightAdjuster.Visible = false;
                btnSaveLowerRightAdjuster.Location = new Point(430, 200);
                btnMoveLowerRightAdjuster.Visible = false;
                btnMoveLowerRightAdjuster.Location = new Point(390, 200);

                btnSaveUpperLeftAdjuster.Visible = true;
                btnSaveUpperLeftAdjuster.Location = new Point(5, 100);
                btnMoveUpperLeftAdjuster.Visible = true;
                btnMoveUpperLeftAdjuster.Location = new Point(50, 100);

                btnSaveUpperRightAdjuster.Visible = true;
                btnSaveUpperRightAdjuster.Location = new Point(430, 100);
                btnMoveUpperRightAdjuster.Visible = true;
                btnMoveUpperRightAdjuster.Location = new Point(390, 100);


                panel1.Visible = true;
                panelAdjust1.Location = new Point(390, 320);

                picBxLowerLeftAdjuster.Visible = true;
                picBxLowerLeftAdjuster.Location = new Point(330, 320);

                panelAdjust2.Visible = false;
                panelAdjust2.Location = new Point(663, 234);

                picBxLowerRightAdjuster.Visible = false;
                picBxLowerRightAdjuster.Location = new Point(624, 238);

                panelAdjust3.Visible = true;
                panelAdjust3.Location = new Point(668, 38);

                picBxUpperLeftAdjuster.Visible = true;
                picBxUpperLeftAdjuster.Location = new Point(624, 42);

                panelAdjust4.Visible = true;
                panelAdjust4.Location = new Point(20, 38);

                picBxUpperRightAdjuster.Visible = true;
                picBxUpperRightAdjuster.Location = new Point(126, 42);


            }


        }
        private void rdoBn4pointAdjuster_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }
        private void rdoBn3pointAdjusterRight_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }

        private void rdoBn3pointAdjusterLeft_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }

        private void rdoBn3pointAdjusterFront_CheckedChanged(object sender, EventArgs e)
        {
            RedesignBedAdjusters();
        }

        private void chkListBxAdjustment_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in chkListBxAdjustment.CheckedItems)
            {
                _configuration.Adjuster = (string)item;
                break;
            }
        }

        
        private void CalculateLeadScrew()
        {
            float microStep = 1;
            int stepsPerRevolution = (int)(360.0 / 1.8);
            float pitch = (float)1.25;
            float gear;

            var comboboxItemTextValue = cmbBxLeadScrewMotorStepAngle.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null) { stepsPerRevolution = (int)comboboxItemTextValue.ToValue(); }

            comboboxItemTextValue = cmbBxLeadScrewDriverMicrostepping.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null){microStep = (float) comboboxItemTextValue.ToValue();}

            comboboxItemTextValue = cmbBxLeadScrewPitch.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null) { pitch = (float)comboboxItemTextValue.ToValue(); }



            if (chkBxLeadScrewDirectDriven.Checked) gear = (float) 1.0;
            else
            {
                gear = (float)(numUpDnLeadScrewMotorTeethCount.Value / numUpDnLeadScrewTeethCount.Value);
            }
            
            
            var stepsPerMM = (int)(stepsPerRevolution  * ( microStep / pitch)  * gear );

            fastColoredTextBoxLeadScrewStepsPerMM.Text = $"{stepsPerMM} steps/mm";
            
        }

        private void cmbBxLeadScrewMotorStepAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateLeadScrew();
        }
        private void chkBxLeadScrewDirectDriven_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnLeadScrewTeethCount.Visible      = !chkBxLeadScrewDirectDriven.Checked;
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
            int stepsPerRevolution = (int)(360.0 / 1.8);
            float pitch = (float)1.25;
            float gear;

            var comboboxItemTextValue = cmbBxBeltMotorStepAngle.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null) { stepsPerRevolution = (int)comboboxItemTextValue.ToValue(); }

            comboboxItemTextValue = cmbBxBeltDriverMicrostepping.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null) { microStep = (float)comboboxItemTextValue.ToValue(); }

            comboboxItemTextValue = cmbBxBeltPitch.SelectedItem as ComboboxItemTextValue;
            if (comboboxItemTextValue != null) { pitch = (float)comboboxItemTextValue.ToValue(); }



            if (chkBxBeltDirectDriven.Checked) gear = (float)1.0;
            else
            {
                gear = (float)(numUpDnBeltMotorTeethCount.Value / numUpDnBeltTeethCount.Value);
            }


            var stepsPerMM =
                (int) (stepsPerRevolution*(microStep/(pitch*(double) numUpDnBeltPulleyTeethCount.Value)) ) * gear;

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

            var stepsPerMM = extrudedLength * oldStepsPerMM / meassuredExtrudedLength;


            fastColoredTextBoxExtruderStepsPerMM.Text = $"{stepsPerMM} steps/mm";
            fastColoredTextBoxExtruderStepsPerMM.Tag = stepsPerMM.ToString();
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
            _com.SendCommand($"M92 E{fastColoredTextBoxExtruderStepsPerMM.Tag}");
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

        private void btnAssociateStlViewer_Click(object sender, EventArgs e)
        {
            string stlViewerExe = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "STLviewer.exe");
            SetAssociation(".stl", "Marlin3DprinterTool_STLviewer", stlViewerExe, "STL 3D model file");
        }


        private static void SetAssociation(string Extension, string KeyName, string OpenWith, string FileDescription)
        {
            RegistryKey BaseKey;
            RegistryKey OpenMethod;
            RegistryKey Shell;
            RegistryKey CurrentUser;

            BaseKey = Registry.ClassesRoot.CreateSubKey(Extension);
            BaseKey.SetValue("", KeyName);

            OpenMethod = Registry.ClassesRoot.CreateSubKey(KeyName);
            OpenMethod.SetValue("", FileDescription);
            OpenMethod.CreateSubKey("DefaultIcon").SetValue("", "\"" + OpenWith + "\",0");
            Shell = OpenMethod.CreateSubKey("Shell");
            Shell.CreateSubKey("edit").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            Shell.CreateSubKey("open").CreateSubKey("command").SetValue("", "\"" + OpenWith + "\"" + " \"%1\"");
            BaseKey.Close();
            OpenMethod.Close();
            Shell.Close();

            CurrentUser = Registry.CurrentUser.CreateSubKey(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.ucs");
            CurrentUser = CurrentUser.OpenSubKey("UserChoice", RegistryKeyPermissionCheck.ReadWriteSubTree, System.Security.AccessControl.RegistryRights.FullControl);
            CurrentUser.SetValue("Progid", KeyName, RegistryValueKind.String);
            CurrentUser.Close();

            // Tell explorer the file association has been changed
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);

        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        private void btnInstallStlServer_Click(object sender, EventArgs e)
        {
            //string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Marlin3DprinterToolStlThumbnail.dll");
            //if (!File.Exists(stlViewerThumbnail)) return;

            //IEnumerable<ServerEntry> serverEntries = ServerManagerApi.LoadServers(stlViewerThumbnail);

            //foreach (ServerEntry serverEntry in serverEntries)
            //{
            //    ServerRegistrationManager.InstallServer(serverEntry.Server, chkBx32BitOS.Checked ? RegistrationType.OS32Bit : RegistrationType.OS64Bit, true);
            //}
        }

        

        private void btnUnRegisterStlServer_Click(object sender, EventArgs e)
        {
            //string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Marlin3DprinterToolStlThumbnail.dll");
            //if (!File.Exists(stlViewerThumbnail)) return;

            //IEnumerable<ServerEntry> serverEntries = ServerManagerApi.LoadServers(stlViewerThumbnail);

            //foreach (ServerEntry serverEntry in serverEntries)
            //{
            //    ServerRegistrationManager.UnregisterServer(serverEntry.Server, chkBx32BitOS.Checked ? RegistrationType.OS32Bit : RegistrationType.OS64Bit);
                
            //}           
        }


        private void btnRegisterStlServer_Click(object sender, EventArgs e)
        {
            //string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Marlin3DprinterToolStlThumbnail.dll");
            //if (!File.Exists(stlViewerThumbnail)) return;

            //IEnumerable<ServerEntry> serverEntries = ServerManagerApi.LoadServers(stlViewerThumbnail);

            //foreach (ServerEntry serverEntry in serverEntries)
            //{
            //    ServerRegistrationManager.RegisterServer(serverEntry.Server, RegistrationType.OS64Bit);
            //}
            
        }

        private void btnUnInstallStlServer_Click(object sender, EventArgs e)
        {
            //string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Marlin3DprinterToolStlThumbnail.dll");
            //if (!File.Exists(stlViewerThumbnail)) return;

            //IEnumerable<ServerEntry> serverEntries = ServerManagerApi.LoadServers(stlViewerThumbnail);

            //foreach (ServerEntry serverEntry in serverEntries)
            //{
            //    ServerRegistrationManager.UninstallServer(serverEntry.Server, chkBx32BitOS.Checked ? RegistrationType.OS32Bit : RegistrationType.OS64Bit);
            //}
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
}