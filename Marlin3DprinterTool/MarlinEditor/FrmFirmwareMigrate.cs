using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MarlinEditor
{
    public partial class FrmFirmware : Form
    {
        private static FrmFirmware _instanceOfFrmFirmware;


       
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

        public string ArduinoIdeDirectory { get; set; }
        public string NewFirmwareDirectory { get; set; }
        public string CurrentFirmwareDirectory { get; set; }



        private List<string> FindFirmwareFeatures()
        {
            List<string> allFeatures = new List<string>();
            List<int> rows = fastColoredTextBoxCurrentFirmware.FindLines(@"\#define", RegexOptions.Singleline);
            foreach (int row in rows)
            {
                string text = fastColoredTextBoxCurrentFirmware.GetLineText(row);
                //Get word after #define featurename
                string feature = Regex.Match(text, @"(?<=\s*\#define\s*)(\w+)", RegexOptions.Singleline).Value;

                allFeatures.Add(feature);
            }

            return allFeatures;

        }



        private void FrmFirmware_Load(object sender, EventArgs e)
        {
            //TODO: Show current and new Firmware filenames in grpbox
            grpBxOldFirmware.Text = Path.Combine(CurrentFirmwareDirectory, @"configuration.h");
            grpBxNewFirmware.Text = Path.Combine(NewFirmwareDirectory, @"configuration.h");

            fastColoredTextBoxCurrentFirmware.DescriptionFile = "ArduinoSyntax.xml";
            fastColoredTextBoxCurrentFirmware.Language = Language.Custom;
            fastColoredTextBoxCurrentFirmware.Font = new Font("Consolas", 9.75f);
            
            
            
            if (File.Exists(Path.Combine(CurrentFirmwareDirectory, @"configuration.h"))) fastColoredTextBoxCurrentFirmware.OpenFile(Path.Combine(CurrentFirmwareDirectory, @"configuration.h"));
            fastColoredTextBoxCurrentFirmware.Tag = Path.Combine(CurrentFirmwareDirectory, @"configuration.h");

            if (File.Exists(Path.Combine(NewFirmwareDirectory, @"configuration.h"))) fastColoredTextBoxNewFirmware.OpenFile(Path.Combine(NewFirmwareDirectory, @"configuration.h"));
            fastColoredTextBoxNewFirmware.Tag = Path.Combine(NewFirmwareDirectory, @"configuration.h");

            cmbBxFirmwareFeatures.Items.Clear();
            cmbBxFirmwareFeatures.Items.AddRange(FindFirmwareFeatures().ToArray());
            cmbBxFirmwareFeatures.Text = cmbBxFirmwareFeatures.Items[1].ToString();

        }

        


        private void UpdateFirmwareFeatures()
        {
            

            // Old firmware
            List<int> rows = new List<int>();
            rows = fastColoredTextBoxCurrentFirmware.FindLines(@"\#define\s*" + cmbBxFirmwareFeatures.Text,RegexOptions.Singleline);
            foreach (int row in rows)
            {
                fastColoredTextBoxCurrentFirmware.Navigate(row);
                if (fastColoredTextBoxCurrentFirmware.GetLineText(row).Trim().StartsWith("#define")) break;
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
            if (string.IsNullOrEmpty(feauture)) return "";

            string featurevalue = "No value!";
            List<int> rows = new List<int>();
            rows = fastColoredTextBoxCurrentFirmware.FindLines(@"\s*\#define\s*" + feauture, RegexOptions.Singleline);

            if (rows.Count >= 1)
            {
                string row = fastColoredTextBoxCurrentFirmware.GetLineText(rows[0]).Trim();

               
                
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
            if (File.Exists(Path.Combine(NewFirmwareDirectory, "configuration.h")))
            {
                fastColoredTextBoxNewFirmware.SaveToFile(Path.Combine(NewFirmwareDirectory, "configuration.h"),Encoding.UTF8);
            }

        }

        

        private void btnOpenArduinoIde_Click(object sender, EventArgs e)
        {
            var arduino = new ArduinoIDE
            {
                FirmwareDirectory = NewFirmwareDirectory,
                ArduinoDirectory =  ArduinoIdeDirectory
            };
            arduino.OpenArduinoWithMarlin();
        }

      

        private void cmbBxFirmwareFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFirmwareFeatures();
        }

        

        

        private void FrmFirmware_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instanceOfFrmFirmware = null;
        }

       




       
    }
}