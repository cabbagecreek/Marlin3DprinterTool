using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MarlinComunicationHelper
{
    public partial class FrmFirmware : Form
    {
        private static FrmFirmware _instanceOfFrmFirmware;

        private readonly Configuration _configuration = new Configuration();
        


        public FrmFirmware()
        {
            InitializeComponent();
        }

        public static FrmFirmware InstanceFrmFirmware
        {
            get
            {
                if (_instanceOfFrmFirmware == null)
                {
                    _instanceOfFrmFirmware = new FrmFirmware();
                }
                return _instanceOfFrmFirmware;
            }
        }

        private void btnCurrentFirmwareLocationBrowse_Click(object sender, EventArgs e)
        {
            var oldFirmwareBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = _configuration.FirmwareLocation
            };
            var result = oldFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBxCurrentFirmwareLocation.Text = oldFirmwareBrowserDialog.SelectedPath;
                _configuration.FirmwareLocation = oldFirmwareBrowserDialog.SelectedPath;
            }
        }

        private void btnCurrentFirmwareLocationSave_Click(object sender, EventArgs e)
        {
            _configuration.FirmwareLocation = txtBxCurrentFirmwareLocation.Text;
        }

        private void PopulateFirmware()
        {
           
        }

        private List<string> FindFirmwareFeatures()
        {
            List<string> allFeatures = new List<string>();
            List<int> rows = fastColoredTextBoxOldFirmware.FindLines(@"\#define", RegexOptions.Singleline);
            foreach (int row in rows)
            {
                string text = fastColoredTextBoxOldFirmware.GetLineText(row);
                //Get word after #define featurename
                string feature = Regex.Match(text, @"(?<=\s*\#define\s*)(\w+)", RegexOptions.Singleline).Value;

                allFeatures.Add(feature);
            }

            return allFeatures;

        }



        private void FrmFirmware_Load(object sender, EventArgs e)
        {
            txtBxCurrentFirmwareLocation.Text = _configuration.FirmwareLocation;
            txtBxNewFirmwareLocation.Text = _configuration.NewFirmwareLocation;

            
        }

        private void chlBxUpdateCurrentFirmware_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFirmwareFeatures();
        }

        private void UpdateFirmwareFeatures()
        {
            // Change the visibility depending on the chlBxUpdateCurrentFirmware
            txtBxNewFirmwareLocation.Visible = !chlBxUpdateCurrentFirmware.Checked;
            btnNewFirmwareLocationBrowse.Visible = !chlBxUpdateCurrentFirmware.Checked;
            btnNewFirmwareLocationSave.Visible = !chlBxUpdateCurrentFirmware.Checked;
            lblNewFirmwareLocation.Visible = !chlBxUpdateCurrentFirmware.Checked;
            grpBxNewFirmware.Text = chlBxUpdateCurrentFirmware.Checked ? @"Update Current Firmware" : @"New Firmware";
            btnEditCurrentFirmware.Visible = true;
            btnEditNewFirmware.Visible = !chlBxUpdateCurrentFirmware.Checked;

            if (chlBxUpdateCurrentFirmware.Checked)
            {
                txtBxCurrentFirmwareLocation.Text = _configuration.FirmwareLocation;
                txtBxNewFirmwareLocation.Text = _configuration.FirmwareLocation;
            }
            else
            {
                txtBxCurrentFirmwareLocation.Text = _configuration.FirmwareLocation;
                txtBxNewFirmwareLocation.Text = _configuration.NewFirmwareLocation;
            }




            // Old firmware
            List<int> rows = new List<int>();
            rows = fastColoredTextBoxOldFirmware.FindLines(@"\#define\s*" + cmbBxFirmwareFeatures.Text,RegexOptions.Singleline);
            foreach (int row in rows)
            {
                fastColoredTextBoxOldFirmware.Navigate(row);
                if (fastColoredTextBoxOldFirmware.GetLineText(row).Trim().StartsWith("#define")) break;
            }
            
            txtBxCurrentFirmwareValue.Text = GetFirmwareFeatureValue(cmbBxFirmwareFeatures.Text);

            rows = fastColoredTextBoxNewFirmware.FindLines(@"^\s*[/]*\#define\s*" + cmbBxFirmwareFeatures.Text, RegexOptions.Singleline);
            foreach (int row in rows)
            {
                fastColoredTextBoxNewFirmware.Navigate(row);
                if (fastColoredTextBoxNewFirmware.GetLineText(row).Trim().StartsWith("#define")) break;
            }
           

            if (rows.Count == 0)
            {
                MessageBox.Show(string.Format(@"The Feature {0} is not available in the new Firmware. ", cmbBxFirmwareFeatures.Text) + Environment.NewLine + Environment.NewLine + 
                    @"This feature may have been obsolite in the new Firmware");
            }


        }

        private string GetFirmwareFeatureValue(string feauture )
        {
            string featurevalue = "No value!";
            List<int> rows = new List<int>();
            rows = fastColoredTextBoxOldFirmware.FindLines(@"\s*\#define\s*" + feauture, RegexOptions.Singleline);

            if (rows.Count >= 1)
            {
                string row = fastColoredTextBoxOldFirmware.GetLineText(rows[0]).Trim();

               
                
                featurevalue = row.Substring(row.IndexOf(feauture, StringComparison.Ordinal));

                

                featurevalue = featurevalue.Replace(feauture, "");

                featurevalue = featurevalue.Trim();

                if (featurevalue.StartsWith("\""))
                {
                    featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("\"" ,1, StringComparison.Ordinal) +1);
                }
                if (string.IsNullOrEmpty(featurevalue)) featurevalue = "Activates a feature";
                
                
            }


            if (featurevalue.Contains("//")) featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("//", StringComparison.Ordinal));

            return featurevalue;
        }

        private void btnPassValue_Click(object sender, EventArgs e)
        {
            List<int> rows = new List<int>();


            rows = fastColoredTextBoxNewFirmware.FindLines(@"^\s*\#define\s*" + cmbBxFirmwareFeatures.Text,
                RegexOptions.Singleline);
            if (rows.Count > 0)
            {

                fastColoredTextBoxNewFirmware.Navigate(rows[0]);
                fastColoredTextBoxNewFirmware.CommentSelected("//");
                fastColoredTextBoxNewFirmware.Navigate(rows[0] + 1);
                fastColoredTextBoxNewFirmware.InsertText(
                    string.Format("#define {0} {1} // Created by Marlin3DprinterTool {2} {3}\n",
                        cmbBxFirmwareFeatures.Text,
                        txtBxCurrentFirmwareValue.Text,
                        DateTime.Now.ToShortDateString(),
                        DateTime.Now.ToShortTimeString())


                    );

                fastColoredTextBoxNewFirmware.DoAutoIndent(rows[0]);
                fastColoredTextBoxNewFirmware.DoAutoIndent(rows[0] + 1);




            }
            else
            {
                // DeActivated Feature
                rows = fastColoredTextBoxNewFirmware.FindLines(@"\s*\#define\s*" + cmbBxFirmwareFeatures.Text,
                RegexOptions.Singleline);
                if (rows.Count > 0)
                {

                    fastColoredTextBoxNewFirmware.Navigate(rows[0]);
                    fastColoredTextBoxNewFirmware.CommentSelected("// Activated by Marlin3DprinterTool -- ");
                    fastColoredTextBoxNewFirmware.Navigate(rows[0] + 1);

                    fastColoredTextBoxNewFirmware.InsertText(
                        txtBxCurrentFirmwareValue.Text == @"Activates a feature"
                            ? $"#define {cmbBxFirmwareFeatures.Text} {""} // Created by Marlin3DprinterTool {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\n"
                            : $"#define {cmbBxFirmwareFeatures.Text} {txtBxCurrentFirmwareValue.Text} // Created by Marlin3DprinterTool {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\n"
                        );

                    fastColoredTextBoxNewFirmware.DoAutoIndent(rows[0]);
                    fastColoredTextBoxNewFirmware.DoAutoIndent(rows[0] + 1);




                }

            }
        }

        private void btnExtruderFirmwareCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fastColoredTextBoxNewFirmware.Text);
        }

        private void btnUpdateExtruderInFirmware_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(txtBxNewFirmwareLocation.Text, "configuration.h")))
            {
                fastColoredTextBoxNewFirmware.SaveToFile(Path.Combine(txtBxNewFirmwareLocation.Text, "configuration.h"),Encoding.UTF8);
            }

        }

        private void btnOpenArduinoIde_Click(object sender, EventArgs e)
        {
            var arduino = new ArduinoIDE
            {
                FirmwareDirectory = txtBxNewFirmwareLocation.Text,
                ArduinoDirectory = txtBxArduinoIdeLocation.Text
            };
            arduino.OpenArduinoWithMarlin();
        }

        private void btnBrowseArduinoIde_Click(object sender, EventArgs e)
        {
            var arduinIDEBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = _configuration.ArduinoIde
            };
            var result = arduinIDEBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBxArduinoIdeLocation.Text = arduinIDEBrowserDialog.SelectedPath;
                _configuration.ArduinoIde = arduinIDEBrowserDialog.SelectedPath;
            }
        }

        private void txtBxSavArduinoIdeLocation_Click(object sender, EventArgs e)
        {
            _configuration.ArduinoIde = txtBxArduinoIdeLocation.Text;
        }

        private void cmbBxFirmwareFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFirmwareFeatures();
        }

        private void btnNewFirmwareLocationBrowse_Click(object sender, EventArgs e)
        {
            var newFirmwareBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = _configuration.NewFirmwareLocation
            };

            var result = newFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBxNewFirmwareLocation.Text = newFirmwareBrowserDialog.SelectedPath;
                _configuration.NewFirmwareLocation = newFirmwareBrowserDialog.SelectedPath;
            }
        }

        private void btnNewFirmwareLocationSave_Click(object sender, EventArgs e)
        {
            _configuration.NewFirmwareLocation = txtBxNewFirmwareLocation.Text;
        }

        private void FrmFirmware_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instanceOfFrmFirmware = null;
        }

        public void UpdateZprobeOffset(string zProbeOffset)
        {
            // update the current firmware.
            InstanceFrmFirmware.chlBxUpdateCurrentFirmware.Checked = true;
            InstanceFrmFirmware.cmbBxFirmwareFeatures.Text = @"Z_PROBE_OFFSET_FROM_EXTRUDER";
            InstanceFrmFirmware.txtBxCurrentFirmwareValue.Text = zProbeOffset;
        }

        private void fastColoredTextBoxOldFirmware_Load(object sender, EventArgs e)
        {
        }

        private void btnEditCurrentFirmware_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Not implemented (yet). This will be a full implementation of a Marlin configuration Editor");
        }

        private void btnEditNewFirmware_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Not implemented (yet). This will be a full implementation of a Marlin configuration Editor");
        }

        private void fastColoredTextBoxOldFirmware_AutoIndentNeeded(object sender, AutoIndentEventArgs e)
        {
        }

        private void txtBxCurrentFirmwareLocation_TextChanged(object sender, EventArgs e)
        {
            
            if (File.Exists(Path.Combine(txtBxCurrentFirmwareLocation.Text, "configuration.h")))
            {
                fastColoredTextBoxOldFirmware.OpenFile(Path.Combine(txtBxCurrentFirmwareLocation.Text, "configuration.h"),Encoding.UTF8);
                cmbBxFirmwareFeatures.Items.Clear();
                cmbBxFirmwareFeatures.Items.AddRange(FindFirmwareFeatures().ToArray());
                
            }

           
        }

        private void txtBxNewFirmwareLocation_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(txtBxNewFirmwareLocation.Text, "configuration.h")))
            {
                fastColoredTextBoxNewFirmware.OpenFile(Path.Combine(txtBxNewFirmwareLocation.Text, @"configuration.h"), Encoding.UTF8);
            }
        }

        private void fastColoredTextBoxNewFirmware_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}