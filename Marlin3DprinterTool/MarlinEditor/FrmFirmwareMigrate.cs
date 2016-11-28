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



        private string _configurationFile ;
        /// <summary>
        /// Type of configuration file. If blank = "Configuration.h"
        /// </summary>
        private string ConfigurationFilename
        {
            get {
                return string.IsNullOrEmpty(_configurationFile) ? "Configuration.h" : _configurationFile;
            }
            set { _configurationFile = value; }
            
        }
        
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

            LoadFiles();

           

        }

        private void ResizedFrame()
        {
            Configuration configuration = new Configuration();
            string lastchar = "";
            int numberOfCharacters = grpBxOldFirmware.Width / 7;
            lastchar = Path.Combine(configuration.CurrentFirmware, ConfigurationFilename);
            grpBxOldFirmware.Text = $"Current Firmware (...{lastchar.Substring(Math.Max(0, lastchar.Length - numberOfCharacters))} )";
            lastchar = Path.Combine(configuration.NewFirmware, ConfigurationFilename);
            grpBxNewFirmware.Text = $"New firmware (...{lastchar.Substring(Math.Max(0, lastchar.Length - numberOfCharacters))} )";

            this.Text = $"Marlin Firmware migration ({ ConfigurationFilename })";
        }


        private void LoadFiles()
        {
            Configuration configuration = new Configuration();


            ResizedFrame();



            fctbCurrentFirmware.DescriptionFile = "ArduinoSyntax.xml";
            fctbCurrentFirmware.Language = Language.Custom;
            fctbCurrentFirmware.Font = new Font("Consolas", 9.75f);




            fixCrLFproblems(Path.Combine(configuration.CurrentFirmware, ConfigurationFilename));
            fixCrLFproblems(Path.Combine(configuration.NewFirmware, ConfigurationFilename));



            if (File.Exists(Path.Combine(configuration.CurrentFirmware, ConfigurationFilename))) fctbCurrentFirmware.OpenFile(Path.Combine(configuration.CurrentFirmware, ConfigurationFilename), Encoding.UTF8);
            fctbCurrentFirmware.Tag = Path.Combine(configuration.CurrentFirmware, ConfigurationFilename);

            if (File.Exists(Path.Combine(configuration.NewFirmware, ConfigurationFilename))) fctbNewFirmware.OpenFile(Path.Combine(configuration.NewFirmware, ConfigurationFilename), Encoding.UTF8);
            fctbNewFirmware.Tag = Path.Combine(configuration.NewFirmware, ConfigurationFilename);


            HighlightInvisibleChars(fctbCurrentFirmware.Range);
            HighlightInvisibleChars(fctbNewFirmware.Range);

            cmbBxFirmwareFeatures.Items.Clear();
            foreach (string feature in FindFirmwareFeatures())
            {
                cmbBxFirmwareFeatures.Items.Add(feature);
            }
            cmbBxFirmwareFeatures.Text = cmbBxFirmwareFeatures.Items[1].ToString();



            btnUpdateExtruderInFirmware.Text = $"Update and Save Firmware ({ConfigurationFilename})";

           
        }

        private void fixCrLFproblems(string filename)
        {
            try
            {
                string allText = File.ReadAllText(filename, Encoding.UTF8);

                allText = allText.Replace("\r\n", "\n");
                allText = allText.Replace("\n", "\r\n");
                allText = allText.Replace("\r\n", "\n");

                File.WriteAllText(filename, allText);

            }
            catch (Exception writException)
            {
                MessageBox.Show(@"Cant correct CR/LF on file!" + Environment.NewLine + writException.Message, @"Correcting CR/LF");
                throw;
            }
            



        }

        private void ShowFirmwareFeatures(string feature)
        {
            BookmarkChangeNeeded(feature);

            // Old firmware
            string oldFeatureValue = GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
            string newFeatureValue = GetFirmwareFeatureValue(fctbNewFirmware, feature);



            int oldRow = GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
            int newRow = GetFirmwareFeatureRow(fctbNewFirmware, feature);

            txtBxCurrentFirmwareValue.Text = oldFeatureValue;

            if (newRow == 0)
            {
                MessageBox.Show(
                    "It looks like feature " + feature + " is obsolite in new firmware" + Environment.NewLine,
                    "Obsolite feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fctbCurrentFirmware.Navigate(oldRow);
                fctbCurrentFirmware.CurrentLineColor = Color.Red;
                fctbNewFirmware.CurrentLineColor = Color.Transparent;
            }
            else
            {
                fctbCurrentFirmware.Navigate(oldRow);
                fctbCurrentFirmware.CurrentLineColor = oldFeatureValue == newFeatureValue ? Color.GreenYellow : Color.Magenta;
                fctbNewFirmware.Navigate(newRow);
                fctbNewFirmware.CurrentLineColor = oldFeatureValue == newFeatureValue ? Color.GreenYellow : Color.Magenta;
            }

            

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
            

            return featurevalue.Trim();
        }

        private void BookmarkChangeNeeded(string feature)
        {
            // Get the last occurance for the feature in current firmware
            int currentrow = GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
            string currentValue = GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
            string currentLine = fctbCurrentFirmware.GetLineText(currentrow).Trim();

            // Get the last occurance for the feature in new firmware
            int newrow = GetFirmwareFeatureRow(fctbNewFirmware, feature);
            string newValue = GetFirmwareFeatureValue(fctbNewFirmware, feature);
            string newLine = fctbNewFirmware.GetLineText(newrow).Trim();


            if ((newrow == 0) | currentValue != newValue )
            {
                fctbCurrentFirmware.BookmarkLine(currentrow);
                return;

            }

            //if (currentLine.StartsWith("//") && !newLine.StartsWith("//"))
            //{
            //    fctbCurrentFirmware.BookmarkLine(currentrow);
            //    return;
            //}
            //if (!currentLine.StartsWith("//") && newLine.StartsWith("//"))
            //{
            //    fctbCurrentFirmware.BookmarkLine(currentrow);
            //    return;
            //}


            fctbCurrentFirmware.UnbookmarkLine(currentrow);


        }

        private int GetFirmwareFeatureRow(FastColoredTextBox fctb, string feauture)
        {
            if (string.IsNullOrEmpty(feauture)) return 0;

            string row = "";
            string featurevalue = "";

            List<int> rows = new List<int>();
            rows = fctb.FindLines(@"\s*\#define\s*\b" + feauture + @"\b", RegexOptions.Singleline);
            
            // return last occurance of feature
            foreach (int index in rows)
            {
                row = fctb.GetLineText(index).Trim();
                if (row.StartsWith("#define")) return index;
            }

            if (rows.Count == 0) return 0;
            
            return  rows[rows.Count - 1] ;



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
            string currentLine = fctbCurrentFirmware.GetLineText(currentrow).Trim();

            // Get the last occurance for the feature in new firmware
            int newrow = GetFirmwareFeatureRow(fctbNewFirmware, feature);
            string newValue = GetFirmwareFeatureValue(fctbNewFirmware, feature);
            string newLine = fctbNewFirmware.GetLineText(newrow).Trim();

            

            if (currentLine.StartsWith("//"))
            {
                if (!newLine.StartsWith("//"))
                {
                    fctbNewFirmware.Navigate(newrow);
                    fctbNewFirmware.CommentSelected("//");

                }
            }
            if (!currentLine.StartsWith("//"))
            {
                if (newLine.StartsWith("//"))
                {
                    fctbNewFirmware.Navigate(newrow);
                    fctbNewFirmware.RemoveLinePrefix("//");
                }
            }

            if (!currentValue.StartsWith("//"))
            {
                string originalLine = fctbNewFirmware.GetLineText(newrow);
                fctbNewFirmware.Navigate(newrow);
                List<int> removeRow = new List<int>();

                removeRow.Add(newrow);
                fctbNewFirmware.RemoveLines(removeRow);
                fctbNewFirmware.Navigate(newrow);
                fctbNewFirmware.InsertText(originalLine.ReplaceFirst(newValue, currentValue) + Environment.NewLine);

            }

            fctbNewFirmware.DoAutoIndent(newrow);
            fctbNewFirmware.DoAutoIndent(newrow + 1);
        }

        


        

       

        private void btnExtruderFirmwareCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fctbNewFirmware.Text);
        }

        private void btnUpdateExtruderInFirmware_Click(object sender, EventArgs e)
        {
            SaveTheUpdatedFile();
            

        }

        private void SaveTheUpdatedFile()
        {
            try
            {
                Configuration configuration = new Configuration();
                if (File.Exists(Path.Combine(configuration.NewFirmware, ConfigurationFilename)))
                {
                    string lastchar = "";
                    lastchar = Path.Combine(configuration.CurrentFirmware, ConfigurationFilename);
                    lastchar = $"New firmware (...{lastchar.Substring(Math.Max(0, lastchar.Length - 40))} )";

                    fctbNewFirmware.SaveToFile(Path.Combine(configuration.NewFirmware, ConfigurationFilename), Encoding.UTF8);
                    MessageBox.Show(@"File saved!", lastchar);
                }

            }
            catch (Exception fileException)
            {

                MessageBox.Show(
                    $"Cant save {ConfigurationFilename}! {Environment.NewLine} Reason: {fileException.Message}",
                    @"File write error");
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

        private void aonfigurationadvhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationFilename = @"Configuration_adv.h";
            LoadFiles();

        }

        private void boardhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationFilename = @"Boards.h";
            LoadFiles();
        }

        private void configurationhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIfNewFirmwareIsChanged();
            ConfigurationFilename = @"Configuration.h";
            LoadFiles();
        }

        private void CheckIfNewFirmwareIsChanged()
        {
            if (fctbNewFirmware.IsChanged)
            {
                DialogResult result =
                    MessageBox.Show($"The file {ConfigurationFilename} is changed! " + Environment.NewLine +
                        $"Do you want to save {ConfigurationFilename}?", "File is changed",MessageBoxButtons.YesNoCancel );
                if (result == DialogResult.Cancel || result == DialogResult.No) return;
                SaveTheUpdatedFile();

            }
        }

        private void chooseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "*.h";
            fileDialog.InitialDirectory = configuration.CurrentFirmware;

            fileDialog.ShowDialog();
            FileInfo fileInfo = new FileInfo(fileDialog.FileName);
            ConfigurationFilename = fileInfo.Name;
            LoadFiles();
        }

        private void FrmFirmware_SizeChanged(object sender, EventArgs e)
        {
            ResizedFrame();
        }
    }

    public static class StringExtension
    {
        public static string ReplaceFirst(this string text, string search, string replace)
        {



            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }

            string firstPart = text.Substring(0, pos);
            string lastPart  = text.Substring(pos + search.Length);

            return firstPart + replace + lastPart;
        }
    }
}