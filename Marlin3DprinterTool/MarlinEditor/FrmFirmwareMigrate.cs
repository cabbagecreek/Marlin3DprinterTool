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
        private readonly Style _invisibleCharsStyle = new InvisibleCharsRenderer(Pens.Gray);
        

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

       
        private List<string> FindFirmwareFeatures()
        {
            List<string> allFeatures = new List<string>();
            List<int> rows = fctbCurrentFirmware.FindLines(@"\#define", RegexOptions.Singleline);
            foreach (int row in rows)
            {
                string text = fctbCurrentFirmware.GetLineText(row);
                //Get word after #define featurename
                string feature = Regex.Match(text, @"(?<=\s*\#define\s*)(\w+)", RegexOptions.Singleline).Value;


                if (allFeatures.Contains(feature)) continue;
                


                allFeatures.Add(feature);
            }

            return allFeatures;

        }



        private void FrmFirmware_Load(object sender, EventArgs e)
        {

            Configuration configuration = new Configuration();


            //TODO: Show current and new Firmware filenames in grpbox
            grpBxOldFirmware.Text = Path.Combine(configuration.CurrentFirmware, @"configuration.h");
            grpBxNewFirmware.Text = Path.Combine(configuration.NewFirmware, @"configuration.h");

            fctbCurrentFirmware.DescriptionFile = "ArduinoSyntax.xml";
            fctbCurrentFirmware.Language = Language.Custom;
            fctbCurrentFirmware.Font = new Font("Consolas", 9.75f);




            fixCrLFproblems(Path.Combine(configuration.CurrentFirmware, @"configuration.h"));
            fixCrLFproblems(Path.Combine(configuration.NewFirmware, @"configuration.h"));



            if (File.Exists(Path.Combine(configuration.CurrentFirmware, @"configuration.h"))) fctbCurrentFirmware.OpenFile(Path.Combine(configuration.CurrentFirmware, @"configuration.h"),Encoding.UTF8);
            fctbCurrentFirmware.Tag = Path.Combine(configuration.CurrentFirmware, @"configuration.h");

            if (File.Exists(Path.Combine(configuration.NewFirmware, @"configuration.h"))) fctbNewFirmware.OpenFile(Path.Combine(configuration.NewFirmware, @"configuration.h"), Encoding.UTF8);
            fctbNewFirmware.Tag = Path.Combine(configuration.NewFirmware, @"configuration.h");


            HighlightInvisibleChars(fctbCurrentFirmware.Range);
            HighlightInvisibleChars(fctbNewFirmware.Range);

            cmbBxFirmwareFeatures.Items.Clear();
            cmbBxFirmwareFeatures.Items.AddRange(FindFirmwareFeatures().ToArray());
            cmbBxFirmwareFeatures.Text = cmbBxFirmwareFeatures.Items[1].ToString();

        }

        private void fixCrLFproblems(string filename)
        {
            string allText = File.ReadAllText(filename, Encoding.UTF8);

            allText = allText.Replace("\r\n", "\n");
            allText = allText.Replace("\n", "\r\n");
            allText = allText.Replace("\r\n", "\n");

            File.WriteAllText(filename,allText);



        }

        private void ShowFirmwareFeatures(string feature)
        {
            List<int> rows = new List<int>();

            // Old firmware
            string oldFeatureValue = GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
            string newFeatureValue = GetFirmwareFeatureValue(fctbNewFirmware, feature);

            rows = fctbCurrentFirmware.FindLines(@"^\s*[/]*\#define\s*\b" + feature + @"\b", RegexOptions.Singleline);
            foreach (int row in rows)
            {
                fctbCurrentFirmware.Navigate(row);
                if (fctbCurrentFirmware.GetLineText(row).Trim().StartsWith("#define")) break;
            }

            txtBxCurrentFirmwareValue.Text = oldFeatureValue;
            // !Old firmware




            //New Firmware
            rows = fctbNewFirmware.FindLines(@"^\s*[/]*\#define\s*\b" + feature + @"\b", RegexOptions.Singleline);
            foreach (int row in rows)
            {
                fctbNewFirmware.Navigate(row);
                if (fctbNewFirmware.GetLineText(row).Trim().StartsWith("#define")) break;
            }


            fctbCurrentFirmware.CurrentLineColor = oldFeatureValue == newFeatureValue ? Color.GreenYellow : Color.Magenta;
            fctbNewFirmware.CurrentLineColor = oldFeatureValue == newFeatureValue ? Color.GreenYellow : Color.Magenta;
            //! New Firmware
            



        }

        private string GetFirmwareFeatureValue(FastColoredTextBox fctb, string feauture )
        {
            if (string.IsNullOrEmpty(feauture)) return "";

            string featurevalue = "";
            string row = "";

            List<int> rows = new List<int>();
            rows = fctb.FindLines(@"\s*\#define\s*\b" + feauture + @"\b", RegexOptions.Multiline);

            foreach (int index in rows)
            {
                row = fctb.GetLineText(index).Trim();

                featurevalue = row.Substring(row.IndexOf(feauture, StringComparison.Ordinal));
                featurevalue = featurevalue.Replace(feauture, "");
                if (featurevalue.StartsWith("\""))
                {
                    featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("\"", 1, StringComparison.Ordinal) + 1);
                }

                if (row.StartsWith("#define")) break;
            }

            
            if (featurevalue.Contains("//")) featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("//", StringComparison.Ordinal)).Trim();

            if(string.IsNullOrEmpty(featurevalue))
            {
                if (row.StartsWith(@"//")) featurevalue = "// Deactivated feature";
                else featurevalue = "// Activated feature";
            }
            

            return featurevalue;
        }

        private int GetFirmwareFeatureRow(FastColoredTextBox fctb, string feauture)
        {
            if (string.IsNullOrEmpty(feauture)) return 0;

            
            List<int> rows = new List<int>();
            rows = fctb.FindLines(@"\s*\#define\s*\b" + feauture + @"\b", RegexOptions.Singleline);
            // return last occurance of feature
            return rows[rows.Count - 1];
           


        }

        private void btnPassValue_Click(object sender, EventArgs e)
        {
            UpdateFeatureValue(cmbBxFirmwareFeatures.Text);

            ShowFirmwareFeatures(cmbBxFirmwareFeatures.Text);
            // Move the focus to cmbBxFirmwareFeatures => Next feature
            cmbBxFirmwareFeatures.Focus();
        }

        private void UpdateFeatureValue(string feature)
        {

            // Get the last occurance for the feature in current firmware
            int currentrow = GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
            string currentValue = GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
            string currentRow = fctbCurrentFirmware.GetLineText(currentrow).Trim();

            // Get the last occurance for the feature in new firmware
            int newrow = GetFirmwareFeatureRow(fctbNewFirmware, feature);
            string newValue = GetFirmwareFeatureValue(fctbNewFirmware, feature);
            string newRow = fctbNewFirmware.GetLineText(currentrow).Trim();


            if (currentValue.StartsWith("//"))
            {
                if (!newValue.StartsWith("//"))
                {
                    fctbNewFirmware.Navigate(newrow);
                    fctbNewFirmware.CommentSelected("// Activated by Marlin3dPrinterTool -- ");
                    fctbNewFirmware.Navigate(newrow + 1);

                    fctbNewFirmware.InsertText($"#define {cmbBxFirmwareFeatures.Text}  // Activated by Marlin3DprinterTool {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\n");
                    fctbNewFirmware.DoAutoIndent(newrow);
                    fctbNewFirmware.DoAutoIndent(newrow + 1);

                }
                else
                {
                    fctbNewFirmware.Navigate(newrow);
                    fctbNewFirmware.CommentSelected("// Deactivated by Marlin3dPrinterTool -- ");
                    fctbNewFirmware.Navigate(newrow + 1);

                    fctbNewFirmware.InsertText($"//#define {cmbBxFirmwareFeatures.Text}  // Deactivated by Marlin3DprinterTool {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\n");
                    fctbNewFirmware.DoAutoIndent(newrow);
                    fctbNewFirmware.DoAutoIndent(newrow + 1);
                }
                
            }


           
            else
            {
                //Feature with value

                fctbNewFirmware.Navigate(newrow);
                fctbNewFirmware.CommentSelected("//");
                fctbNewFirmware.Navigate(newrow + 1);

                fctbNewFirmware.InsertText($"#define {cmbBxFirmwareFeatures.Text} {txtBxCurrentFirmwareValue.Text} // Created by Marlin3DprinterTool {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}\n");

                fctbNewFirmware.DoAutoIndent(newrow);
                fctbNewFirmware.DoAutoIndent(newrow + 1);
            }






        }

        

        private void ActivateFeature(string feature)
        {

        }

        private void btnExtruderFirmwareCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fctbNewFirmware.Text);
        }

        private void btnUpdateExtruderInFirmware_Click(object sender, EventArgs e)
        {

            Configuration configuration = new Configuration();
            if (File.Exists(Path.Combine(configuration.NewFirmware, "configuration.h")))
            {
                fctbNewFirmware.SaveToFile(Path.Combine(configuration.NewFirmware, "configuration.h"),Encoding.UTF8);
            }

        }

        

        private void btnOpenArduinoIde_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            var arduino = new ArduinoIDE
            {
                FirmwareDirectory = configuration.NewFirmware,
                ArduinoDirectory =  configuration.ArduinoIde
            };
            arduino.OpenArduinoWithMarlin();
        }

      

        private void cmbBxFirmwareFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFirmwareFeatures(cmbBxFirmwareFeatures.Text);
        }

        

        

        private void FrmFirmware_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instanceOfFrmFirmware = null;
        }

        private void fctbCurrentFirmware_SelectionChanged(object sender, EventArgs e)
        {
            string possibleFeature = fctbCurrentFirmware.SelectedText;
            if (string.IsNullOrEmpty(possibleFeature)) return;

            foreach (string item in cmbBxFirmwareFeatures.Items)
            {
                if (item == possibleFeature) cmbBxFirmwareFeatures.Text = possibleFeature;
            }

        }

        

        private void fctbBoxNewFirmware_SelectionChanged(object sender, EventArgs e)
        {
            string possibleFeature = fctbNewFirmware.SelectedText;
            if (string.IsNullOrEmpty(possibleFeature)) return;

            foreach (string item in cmbBxFirmwareFeatures.Items)
            {
                if (item == possibleFeature) cmbBxFirmwareFeatures.Text = possibleFeature;
            }
        }

        private void HighlightInvisibleChars(Range range)
        {
            range.ClearStyle(_invisibleCharsStyle);
            range.SetStyle(_invisibleCharsStyle, @".$|.\r\n|\s");
        }

        private void fctbCurrentFirmware_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            //show invisible chars
            HighlightInvisibleChars(e.ChangedRange);
        }

        private void fctbNewFirmware_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            //show invisible chars
            HighlightInvisibleChars(e.ChangedRange);
        }
    }
}