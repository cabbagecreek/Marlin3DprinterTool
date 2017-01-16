using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Marlin3DprinterToolConfiguration;

namespace MarlinEditor
{
    public partial class FrmFirmware : Form
    {
        
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



        private void SearchAndCompare()
        {
            
            FrmMigrationCompare frmMigrationCompare = new FrmMigrationCompare();
            if (frmMigrationCompare.ShowDialog() != DialogResult.OK) return;

            foreach (ToolStripMenuItem dropDownItem in filesWithDifferancesToolStripMenuItem.DropDownItems)
            {
                filesWithDifferancesToolStripMenuItem.DropDownItems.RemoveByKey(dropDownItem.Name);
            }

            // create menuitems for each file
            foreach (FileInfo fileInfo in frmMigrationCompare.FileNames)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem
                {
                    Tag = fileInfo,
                    Text = fileInfo.Name
                };
                tsmi.Click += Tsmi_Click;
                filesWithDifferancesToolStripMenuItem.DropDownItems.Add(tsmi);
                    
            }
        }

        private void Tsmi_Click(object sender, EventArgs e)
        {

            ToolStripItem item = (ToolStripItem)sender;

            FileInfo fileInfo = (FileInfo) item.Tag;

            ConfigurationFilename = fileInfo.Name;
            LoadFiles();

        }

        private void FrmFirmware_Load(object sender, EventArgs e)
        {
            
            DialogResult result =
                MessageBox.Show(@"Do you want to search for changes in *.h files?" + Environment.NewLine +
                                @"( This will take 5 minutes or more )", @"Search for changes",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Cancel) Close();
            if (result == DialogResult.Yes)
            {
                SearchAndCompare();

            }


            LoadFiles();

           

        }

        private void ResizedFrame()
        {
            Configuration configuration = new Configuration();
            int numberOfCharacters = grpBxOldFirmware.Width / 7;
            var lastchar = Path.Combine(configuration.CurrentFirmware, ConfigurationFilename);
            grpBxOldFirmware.Text = $"Current Firmware (...{lastchar.Substring(Math.Max(0, lastchar.Length - numberOfCharacters))} )";
            lastchar = Path.Combine(configuration.NewFirmware, ConfigurationFilename);
            grpBxNewFirmware.Text = $"New firmware (...{lastchar.Substring(Math.Max(0, lastchar.Length - numberOfCharacters))} )";

            Text = $"Marlin Firmware migration ({ ConfigurationFilename })";
        }


        private void LoadFiles()
        {
            Configuration configuration = new Configuration();

            CheckIfNewFirmwareIsChanged();

            ResizedFrame();



            fctbCurrentFirmware.DescriptionFile = "ArduinoSyntax.xml";
            fctbCurrentFirmware.Language = Language.Custom;
            fctbCurrentFirmware.Font = new Font("Consolas", 9.75f);

            fctbNewFirmware.DescriptionFile = "ArduinoSyntax.xml";
            fctbNewFirmware.Language = Language.Custom;
            fctbNewFirmware.Font = new Font("Consolas", 9.75f);



            MarlinMigrateHelper.FixCrLfProblems(Path.Combine(configuration.CurrentFirmware, ConfigurationFilename));
            MarlinMigrateHelper.FixCrLfProblems(Path.Combine(configuration.NewFirmware, ConfigurationFilename));



            if (File.Exists(Path.Combine(configuration.CurrentFirmware, ConfigurationFilename))) fctbCurrentFirmware.OpenFile(Path.Combine(configuration.CurrentFirmware, ConfigurationFilename), Encoding.UTF8);
            fctbCurrentFirmware.Tag = Path.Combine(configuration.CurrentFirmware, ConfigurationFilename);

            if (File.Exists(Path.Combine(configuration.NewFirmware, ConfigurationFilename))) fctbNewFirmware.OpenFile(Path.Combine(configuration.NewFirmware, ConfigurationFilename), Encoding.UTF8);
            fctbNewFirmware.Tag = Path.Combine(configuration.NewFirmware, ConfigurationFilename);


            HighlightInvisibleChars(fctbCurrentFirmware.Range);
            HighlightInvisibleChars(fctbNewFirmware.Range);

            cmbBxFirmwareFeatures.Items.Clear();
            foreach (string feature in MarlinMigrateHelper.FindFirmwareFeatures(fctbCurrentFirmware))
            {
                cmbBxFirmwareFeatures.Items.Add(feature);
            }
            cmbBxFirmwareFeatures.Text = cmbBxFirmwareFeatures.Items[1].ToString();



            btnUpdateExtruderInFirmware.Text = $"Update and Save Firmware ({ConfigurationFilename})";

           
        }


        private void ShowFirmwareFeatures(string feature)
        {
            MarlinMigrateHelper.BookmarkChangeNeeded(feature,fctbCurrentFirmware,fctbNewFirmware);

            // Old firmware
            string oldFeatureValue = MarlinMigrateHelper.GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
            string newFeatureValue = MarlinMigrateHelper.GetFirmwareFeatureValue(fctbNewFirmware, feature);



            int oldRow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
            int newRow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbNewFirmware, feature);

            txtBxCurrentFirmwareValue.Text = oldFeatureValue;

            if (newRow == 0)
            {
                MessageBox.Show(
                    @"It looks like feature " + feature + @" is obsolite in new firmware" + Environment.NewLine,
                    @"Obsolite feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //private string GetFirmwareFeatureValue(FastColoredTextBox fctb, string feauture )
        //{
        //    if (string.IsNullOrEmpty(feauture)) return "";

        //    string featurevalue = "";
        //    string row = "";

        //    List<int> rows = new List<int>();
        //    rows = fctb.FindLines(@"\s*\#define\s*\b" + feauture + @"\b", RegexOptions.Multiline);

        //    foreach (int index in rows)
        //    {
        //        row = fctb.GetLineText(index).Trim();

        //        featurevalue = row.Substring(row.IndexOf(feauture, StringComparison.Ordinal));
        //        featurevalue = featurevalue.Replace(feauture, "");
        //        if (featurevalue.StartsWith("\""))
        //        {
        //            featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("\"", 1, StringComparison.Ordinal) + 1);
        //        }

        //        if (row.StartsWith("#define")) break;
        //    }

            
        //    if (featurevalue.Contains("//")) featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("//", StringComparison.Ordinal)).Trim();

        //    if(string.IsNullOrEmpty(featurevalue))
        //    {
        //        if (row.StartsWith(@"//")) featurevalue = "// Deactivated feature";
        //        else featurevalue = "// Activated feature";
        //    }
            

        //    return featurevalue.Trim();
        //}

        //private void BookmarkChangeNeeded(string feature)
        //{
        //    // Get the last occurance for the feature in current firmware
        //    int currentrow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
        //    string currentValue = GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
        //    string currentLine = fctbCurrentFirmware.GetLineText(currentrow).Trim();

        //    // Get the last occurance for the feature in new firmware
        //    int newrow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbNewFirmware, feature);
        //    string newValue = GetFirmwareFeatureValue(fctbNewFirmware, feature);
        //    string newLine = fctbNewFirmware.GetLineText(newrow).Trim();


        //    if ((newrow == 0) | currentValue != newValue )
        //    {
        //        fctbCurrentFirmware.BookmarkLine(currentrow);
        //        return;

        //    }

        //    //if (currentLine.StartsWith("//") && !newLine.StartsWith("//"))
        //    //{
        //    //    fctbCurrentFirmware.BookmarkLine(currentrow);
        //    //    return;
        //    //}
        //    //if (!currentLine.StartsWith("//") && newLine.StartsWith("//"))
        //    //{
        //    //    fctbCurrentFirmware.BookmarkLine(currentrow);
        //    //    return;
        //    //}


        //    fctbCurrentFirmware.UnbookmarkLine(currentrow);


        //}

       

        private void btnPassValue_Click(object sender, EventArgs e)
        {
            MarlinMigrateHelper.UpdateFeatureValue(cmbBxFirmwareFeatures.Text,fctbCurrentFirmware,fctbNewFirmware);

            ShowFirmwareFeatures(cmbBxFirmwareFeatures.Text);
            // Move the focus to cmbBxFirmwareFeatures => Next feature
            cmbBxFirmwareFeatures.Focus();
        }

        //private void UpdateFeatureValue(string feature)
        //{

        //    // Get the last occurance for the feature in current firmware
        //    int currentrow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
        //    string currentValue = MarlinMigrateHelper.GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
        //    string currentLine = fctbCurrentFirmware.GetLineText(currentrow).Trim();

        //    // Get the last occurance for the feature in new firmware
        //    int newrow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbNewFirmware, feature);
        //    string newValue = MarlinMigrateHelper.GetFirmwareFeatureValue(fctbNewFirmware, feature);
        //    string newLine = fctbNewFirmware.GetLineText(newrow).Trim();

            

        //    if (currentLine.StartsWith("//"))
        //    {
        //        if (!newLine.StartsWith("//"))
        //        {
        //            fctbNewFirmware.Navigate(newrow);
        //            fctbNewFirmware.CommentSelected("//");

        //        }
        //    }
        //    if (!currentLine.StartsWith("//"))
        //    {
        //        if (newLine.StartsWith("//"))
        //        {
        //            fctbNewFirmware.Navigate(newrow);
        //            fctbNewFirmware.RemoveLinePrefix("//");
        //        }
        //    }

        //    if (!currentValue.StartsWith("//"))
        //    {
        //        string originalLine = fctbNewFirmware.GetLineText(newrow);
        //        fctbNewFirmware.Navigate(newrow);
        //        List<int> removeRow = new List<int>();

        //        removeRow.Add(newrow);
        //        fctbNewFirmware.RemoveLines(removeRow);
        //        fctbNewFirmware.Navigate(newrow);
        //        fctbNewFirmware.InsertText(originalLine.ReplaceFirst(newValue, currentValue) + Environment.NewLine);

        //    }

        //    fctbNewFirmware.DoAutoIndent(newrow);
        //    fctbNewFirmware.DoAutoIndent(newrow + 1);
        //}

        


        

       

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
                    var lastchar = Path.Combine(configuration.CurrentFirmware, ConfigurationFilename);
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

       

        

        private void CheckIfNewFirmwareIsChanged()
        {
            if (fctbNewFirmware.IsChanged)
            {
                DialogResult result =
                    MessageBox.Show($"The file {ConfigurationFilename} is changed! " + Environment.NewLine +
                        $"Do you want to save {ConfigurationFilename}?", @"File is changed",MessageBoxButtons.YesNoCancel );
                if (result == DialogResult.Cancel || result == DialogResult.No) return;
                SaveTheUpdatedFile();

            }
        }


        private void chooseAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = "*.h";
            fileDialog.InitialDirectory = configuration.CurrentFirmware;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(fileDialog.FileName);
                ConfigurationFilename = fileInfo.Name;
                LoadFiles();
            }
        }

        private void FrmFirmware_SizeChanged(object sender, EventArgs e)
        {
            ResizedFrame();
        }

       
        private void compareFiles_Click(object sender, EventArgs e)
        {
            
            SearchAndCompare();


        }

       
    }

    public static class StringExtension
    {
        public static string ReplaceFirst(this string text, string search, string replace)
        {



            int pos = text.IndexOf(search, StringComparison.Ordinal);
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