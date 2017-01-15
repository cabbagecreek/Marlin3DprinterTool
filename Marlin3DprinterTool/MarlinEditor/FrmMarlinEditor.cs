using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using FarsiLibrary.Win;
using FastColoredTextBoxNS;
using MarlinEditor.Properties;

namespace MarlinEditor
{
    public partial class FrmMarlinEditor : Form
    {

        



        private readonly Configuration _configuration = new Configuration();

        private readonly string[] _keywords = { "#define","abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "Deligate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "descending", "dynamic", "from", "get", "global", "group", "into", "join", "let", "orderby", "partial", "remove", "select", "set", "value", "var", "where", "yield" };
        private readonly string[] _methods = { "Equals()", "GetHashCode()", "GetType()", "ToString()" };
        private readonly string[] _snippets = { "if(^)\n{\n;\n}", "if(^)\n{\n;\n}\nelse\n{\n;\n}", "for(^;;)\n{\n;\n}", "while(^)\n{\n;\n}", "do\n{\n^;\n}while();", "switch(^)\n{\ncase : break;\n}" };
        private readonly string[] _declarationSnippets = {
               "public class ^\n{\n}", "private class ^\n{\n}", "internal class ^\n{\n}",
               "public struct ^\n{\n;\n}", "private struct ^\n{\n;\n}", "internal struct ^\n{\n;\n}",
               "public void ^()\n{\n;\n}", "private void ^()\n{\n;\n}", "internal void ^()\n{\n;\n}", "protected void ^()\n{\n;\n}",
               "public ^{ get; set; }", "private ^{ get; set; }", "internal ^{ get; set; }", "protected ^{ get; set; }"
               };
        private readonly Style _invisibleCharsStyle = new InvisibleCharsRenderer(Pens.Gray);
        private readonly Color _currentLineColor = Color.FromArgb(100, 210, 210, 255);
        private readonly Color _changedLineColor = Color.FromArgb(255, 230, 230, 255);

        
        FastColoredTextBox CurrentFastColoredTextBox
        {
            get
            {
                return tsFiles.SelectedItem?.Controls[0] as FastColoredTextBox;
            }

            set
            {
                tsFiles.SelectedItem = (value.Parent as FATabStripItem);
                value.Focus();
            }
        }

        public string FirmwareDirectory
        {
            get { return ofdMain.InitialDirectory; }
            set
            {
                ofdMain.InitialDirectory = value; 
                
            }
        }

        public string Filename {
            set
            {
                ofdMain.FileName = value;
                CreateTab(ofdMain.FileName);
            }
        }


        public FrmMarlinEditor()
        {
            InitializeComponent();
            //init menu images
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmMarlinEditor));
            copyToolStripMenuItem.Image = ((Image)(resources.GetObject("copyToolStripButton.Image")));
            cutToolStripMenuItem.Image = ((Image)(resources.GetObject("cutToolStripButton.Image")));
            pasteToolStripMenuItem.Image = ((Image)(resources.GetObject("pasteToolStripButton.Image")));
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            FastColoredTextBox tb = CreateTab(null);
        }

        public void UpdateAndSavePidExtruder(string kp, string ki, string kd)
        {
            if (string.IsNullOrEmpty(FirmwareDirectory))
            {
                FirmwareDirectory = _configuration.CurrentFirmware;
            }


            if (File.Exists(Path.Combine(FirmwareDirectory, @"configuration.h")))
            {
                FastColoredTextBox fb = CreateTab(Path.Combine(FirmwareDirectory, @"configuration.h"));


                UpdateFeature(fb, @"DEFAULT_Kp",kp);
                UpdateFeature(fb, @"DEFAULT_Ki", ki);
                UpdateFeature(fb, @"DEFAULT_Kd", kd);
                fb.SaveToFile(Path.Combine(FirmwareDirectory, @"configuration.h"),Encoding.UTF8);

            }
        }

        public void UpdateAndSavePidBed(string kp, string ki, string kd)
        {
            if (string.IsNullOrEmpty(FirmwareDirectory))
            {
                FirmwareDirectory = _configuration.CurrentFirmware;
            }

            if (File.Exists(Path.Combine(FirmwareDirectory, @"configuration.h")))
            {
                FastColoredTextBox fb = CreateTab(Path.Combine(FirmwareDirectory, @"configuration.h"));


                UpdateFeature(fb, @"DEFAULT_bedKp", kp);
                UpdateFeature(fb, @"DEFAULT_bedKi", ki);
                UpdateFeature(fb, @"DEFAULT_bedKd", kd);
                fb.SaveToFile(Path.Combine(FirmwareDirectory, @"configuration.h"), Encoding.UTF8);

            }
        }




        private void UpdateFeature(FastColoredTextBox fastColoredTextBoxNewFirmware, string feature, string value )
        {
            List<int> rows = new List<int>();


            rows = fastColoredTextBoxNewFirmware.FindLines(@"^\s*\#define\s*" + feature,RegexOptions.Singleline);
            if (rows.Count > 0)
            {

                fastColoredTextBoxNewFirmware.Navigate(rows[0]);


                // #Update Feature in Firmware BugFix
                // Find value in rows[0]
                // replace value with the new value
                MarlinMigrateHelper.UpdateFeatureValue(feature, value, fastColoredTextBoxNewFirmware);
                

                fastColoredTextBoxNewFirmware.DoAutoIndent(rows[0]);
                fastColoredTextBoxNewFirmware.DoAutoIndent(rows[0] + 1);




            }
        }


        private Style sameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(50, Color.Gray)));



        private FastColoredTextBox CreateTab(string fileName)
        {
            try
            {
                var tb = new FastColoredTextBox();
                tb.DescriptionFile = "ArduinoSyntax.xml";
                tb.Language = Language.Custom;
                tb.Font = new Font("Consolas", 9.75f);
                tb.ContextMenuStrip = cmMain;
                tb.Dock = DockStyle.Fill;
                tb.BorderStyle = BorderStyle.Fixed3D;
                //tb.VirtualSpace = true;
                tb.LeftPadding = 17;
                //tb.Language = Language.CSharp;
                tb.AddStyle(sameWordsStyle);//same words style
                var tab = new FATabStripItem(fileName != null ? Path.GetFileName(fileName) : "[new]", tb);
                tab.Tag = fileName;
                if (fileName != null)
                    tb.OpenFile(fileName);
                tb.Tag = new TbInfo();
                tsFiles.AddTab(tab);
                tsFiles.SelectedItem = tab;
                tb.Focus();
                tb.CurrentLineColor = Color.Turquoise;
                tb.DelayedTextChangedInterval = 1000;
                tb.DelayedEventsInterval = 500;
                tb.TextChangedDelayed += tb_TextChangedDelayed;
                tb.SelectionChangedDelayed += tb_SelectionChangedDelayed;
                tb.KeyDown += tb_KeyDown;
                tb.MouseMove += tb_MouseMove;
                tb.ChangedLineColor = _changedLineColor;
                if (btHighlightCurrentLine.Checked)
                    tb.CurrentLineColor = _currentLineColor;
                tb.ShowFoldingLines = btShowFoldingLines.Checked;
                tb.HighlightingRangeType = HighlightingRangeType.VisibleRange;
                //create autocomplete popup menu
                AutocompleteMenu popupMenu = new AutocompleteMenu(tb);
                popupMenu.Items.ImageList = ilAutocomplete;
                popupMenu.Opening += popupMenu_Opening;
                BuildAutocompleteMenu(popupMenu);
                (tb.Tag as TbInfo).popupMenu = popupMenu;
                return tb;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    return CreateTab(fileName);
            }
            return null;
        }

        void tb_MouseMove(object sender, MouseEventArgs e)
        {
            var tb = sender as FastColoredTextBox;
            var place = tb.PointToPlace(e.Location);
            var r = new Range(tb, place, place);

            string text = r.GetFragment("[a-zA-Z]").Text;
            lbWordUnderMouse.Text = text;
        }


        void popupMenu_Opening(object sender, CancelEventArgs e)
        {
            //---block autocomplete menu for comments
            //get index of green style (used for comments)
            var iGreenStyle = CurrentFastColoredTextBox.GetStyleIndex(CurrentFastColoredTextBox.SyntaxHighlighter.GreenStyle);
            if (iGreenStyle >= 0)
                if (CurrentFastColoredTextBox.Selection.Start.iChar > 0)
                {
                    //current char (before caret)
                    var c = CurrentFastColoredTextBox[CurrentFastColoredTextBox.Selection.Start.iLine][CurrentFastColoredTextBox.Selection.Start.iChar - 1];
                    //green Style
                    var greenStyleIndex = Range.ToStyleIndex(iGreenStyle);
                    //if char contains green style then block popup menu
                    if ((c.style & greenStyleIndex) != 0)
                        e.Cancel = true;
                }
        }

        private void BuildAutocompleteMenu(AutocompleteMenu popupMenu)
        {
            List<AutocompleteItem> items = new List<AutocompleteItem>();

            foreach (var item in _snippets)
                items.Add(new SnippetAutocompleteItem(item) { ImageIndex = 1 });
            foreach (var item in _declarationSnippets)
                items.Add(new DeclarationSnippet(item) { ImageIndex = 0 });
            foreach (var item in _methods)
                items.Add(new MethodAutocompleteItem(item) { ImageIndex = 2 });
            foreach (var item in _keywords)
                items.Add(new AutocompleteItem(item));

            items.Add(new InsertSpaceSnippet());
            items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
            items.Add(new InsertEnterSnippet());

            //set as autocomplete source
            popupMenu.Items.SetAutocompleteItems(items);
            popupMenu.SearchPattern = @"[\w\.:=!<>]";
        }



        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.OemMinus)
            {
                NavigateBackward();
                e.Handled = true;
            }

            if (e.Modifiers == (Keys.Control | Keys.Shift) && e.KeyCode == Keys.OemMinus)
            {
                NavigateForward();
                e.Handled = true;
            }

            if (e.KeyData == (Keys.K | Keys.Control))
            {
                //forced show (MinFragmentLength will be ignored)
                (CurrentFastColoredTextBox.Tag as TbInfo).popupMenu.Show(true);
                e.Handled = true;
            }
        }

        private bool NavigateForward()
        {
            DateTime min = DateTime.Now;
            int iLine = -1;
            FastColoredTextBox tb = null;
            for (int iTab = 0; iTab < tsFiles.Items.Count; iTab++)
            {
                var t = (tsFiles.Items[iTab].Controls[0] as FastColoredTextBox);
                for (int i = 0; i < t.LinesCount; i++)
                    if (t[i].LastVisit > lastNavigatedDateTime && t[i].LastVisit < min)
                    {
                        min = t[i].LastVisit;
                        iLine = i;
                        tb = t;
                    }
            }
            if (iLine >= 0)
            {
                tsFiles.SelectedItem = (tb.Parent as FATabStripItem);
                tb.Navigate(iLine);
                lastNavigatedDateTime = tb[iLine].LastVisit;
                tb.Focus();
                tb.Invalidate();
                return true;
            }
            return false;
        }


        

        private bool NavigateBackward()
        {
            DateTime max = new DateTime();
            int iLine = -1;
            FastColoredTextBox tb = null;
            for (int iTab = 0; iTab < tsFiles.Items.Count; iTab++)
            {
                var t = (tsFiles.Items[iTab].Controls[0] as FastColoredTextBox);
                for (int i = 0; i < t.LinesCount; i++)
                    if (t[i].LastVisit < lastNavigatedDateTime && t[i].LastVisit > max)
                    {
                        max = t[i].LastVisit;
                        iLine = i;
                        tb = t;
                    }
            }
            if (iLine >= 0)
            {
                tsFiles.SelectedItem = (tb.Parent as FATabStripItem);
                tb.Navigate(iLine);
                lastNavigatedDateTime = tb[iLine].LastVisit;
                tb.Focus();
                tb.Invalidate();
                return true;
            }
            return false;
        }


        void tb_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            FastColoredTextBox tb = (sender as FastColoredTextBox);
            //rebuild object explorer
            string text = (sender as FastColoredTextBox).Text;
            ThreadPool.QueueUserWorkItem(
                o => ReBuildObjectExplorer(text)
            );

            //show invisible chars
            HighlightInvisibleChars(e.ChangedRange);
        }

        DateTime lastNavigatedDateTime = DateTime.Now;

        void tb_SelectionChangedDelayed(object sender, EventArgs e)
        {
            var tb = sender as FastColoredTextBox;
            //remember last visit time
            if (tb.Selection.IsEmpty && tb.Selection.Start.iLine < tb.LinesCount)
            {
                if (lastNavigatedDateTime != tb[tb.Selection.Start.iLine].LastVisit)
                {
                    tb[tb.Selection.Start.iLine].LastVisit = DateTime.Now;
                    lastNavigatedDateTime = tb[tb.Selection.Start.iLine].LastVisit;
                }
            }

            //highlight same words
            tb.VisibleRange.ClearStyle(sameWordsStyle);
            if (!tb.Selection.IsEmpty)
                return;//user selected diapason
            //get fragment around caret
            var fragment = tb.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            Range[] ranges = tb.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();

            if (ranges.Length > 1)
                foreach (var r in ranges)
                    r.SetStyle(sameWordsStyle);
        }

        private void HighlightInvisibleChars(Range range)
        {
            range.ClearStyle(_invisibleCharsStyle);
            if (btInvisibleChars.Checked)
                range.SetStyle(_invisibleCharsStyle, @".$|.\r\n|\s");
        }

        List<ExplorerItem> explorerList = new List<ExplorerItem>();

       

        private void ReBuildObjectExplorer(string text)
        {
            try
            {
                List<ExplorerItem> list = new List<ExplorerItem>();
                int lastClassIndex = -1;
                //find classes, methods and properties
                Regex regex = new Regex(@"^(?<range>[\w\s]+\b(class|struct|enum|interface)\s+[\w<>,\s]+)|^\s*(#define|//\s*#define|public|private|internal|protected)[^\n]+(\n?\s*{|;)?", RegexOptions.Multiline);
                foreach (Match r in regex.Matches(text))
                {
                    try
                    {
                        var item = new ExplorerItem {title = r.Value.Trim(), position = r.Index};

                        if (item.title.Contains("#define"))
                        {


                            if (item.title.StartsWith(@"#define"))
                            {
                                item.title = item.title.Replace(@"#define", "").Trim();

                                if (item.title.Contains(@"//"))
                                {
                                    item.title = item.title.Substring(0,
                                        item.title.IndexOf(@"//", StringComparison.Ordinal));
                                }
                                item.type = ExplorerItemType.Property;
                            }
                            if (item.title.StartsWith(@"//"))
                            {
                                item.title = item.title.TrimStart('/').Trim();

                                item.title = item.title.Replace(@"#define", "").Trim();

                                item.type = ExplorerItemType.DisabledProperty;
                            }






                        }



                        list.Add(item);
                    }
                    catch
                    {
                        ;

                    }

                }

                
                explorerList.Clear();

                BeginInvoke(
                    new Action(() =>
                    {
                        explorerList = list;
                        dgvObjectExplorer.RowCount = explorerList.Count;
                        dgvObjectExplorer.Invalidate();
                    })
                );
            }
            catch {; }
        }

        private void btShowFoldingLines_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in tsFiles.Items)
                (tab.Controls[0] as FastColoredTextBox).ShowFoldingLines = btShowFoldingLines.Checked;
            if (CurrentFastColoredTextBox != null)
            {
                CurrentFastColoredTextBox.Invalidate();
            }
        }

       
       

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (tsFiles.SelectedItem != null)
                Save(tsFiles.SelectedItem);

        }
        private bool Save(FATabStripItem tab)
        {
            var tb = (tab.Controls[0] as FastColoredTextBox);
            if (tab.Tag == null)
            {
                if (sfdMain.ShowDialog() != DialogResult.OK)
                    return false;
                tab.Title = Path.GetFileName(sfdMain.FileName);
                tab.Tag = sfdMain.FileName;
            }

            try
            {
                File.WriteAllText(tab.Tag as string, tb.Text);
                tb.IsChanged = false;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    return Save(tab);
                return false;
            }

            tb.Invalidate();

            return true;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (ofdMain.ShowDialog() == DialogResult.OK)
                CreateTab(ofdMain.FileName);

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (CurrentFastColoredTextBox != null)
            {
                var settings = new PrintDialogSettings();
                settings.Title = tsFiles.SelectedItem.Title;
                settings.Header = "&b&w&b";
                settings.Footer = "&b&p";
                CurrentFastColoredTextBox.Print(settings);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            CurrentFastColoredTextBox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            CurrentFastColoredTextBox.Copy();
        }

        private void btInvisibleChars_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in tsFiles.Items)
                HighlightInvisibleChars((tab.Controls[0] as FastColoredTextBox).Range);
            if (CurrentFastColoredTextBox != null)
            {
                CurrentFastColoredTextBox.Invalidate();
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            CurrentFastColoredTextBox.Paste();
        }

        private void undoStripButton_Click(object sender, EventArgs e)
        {
            if (CurrentFastColoredTextBox.UndoEnabled)
            {
                CurrentFastColoredTextBox.Undo();
            }
        }

        private void redoStripButton_Click(object sender, EventArgs e)
        {
            if (CurrentFastColoredTextBox.RedoEnabled)
            {
                CurrentFastColoredTextBox.Redo();
                
            }

        }

        private void backStripButton_Click(object sender, EventArgs e)
        {
            NavigateBackward();
        }

        private void forwardStripButton_Click_1(object sender, EventArgs e)
        {
            NavigateForward();
        }

        private void bookmarkPlusButton_Click(object sender, EventArgs e)
        {
            if (CurrentFastColoredTextBox == null) return;
            CurrentFastColoredTextBox.BookmarkLine(CurrentFastColoredTextBox.Selection.Start.iLine);
        }

        private void bookmarkMinusButton_Click(object sender, EventArgs e)
        {
            if (CurrentFastColoredTextBox == null) return;
            CurrentFastColoredTextBox.UnbookmarkLine(CurrentFastColoredTextBox.Selection.Start.iLine);
        }

        private void gotoButton_Click(object sender, EventArgs e)
        {

        }

        private void gotoButton_DropDownOpening(object sender, EventArgs e)
        {
            gotoButton.DropDownItems.Clear();
            foreach (Control tab in tsFiles.Items)
            {
                FastColoredTextBox tb = tab.Controls[0] as FastColoredTextBox;
                foreach (var bookmark in tb.Bookmarks)
                {
                    var item = gotoButton.DropDownItems.Add(bookmark.Name + " [" + Path.GetFileNameWithoutExtension(tab.Tag as String) + "]");
                    item.Tag = bookmark;
                    item.Click += (o, a) => {
                        var b = (Bookmark)(o as ToolStripItem).Tag;
                        try
                        {
                            CurrentFastColoredTextBox = b.TB;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                        b.DoVisible();
                    };
                }
            }
        }

        private void ofdMain_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void dgvObjectExplorer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CurrentFastColoredTextBox != null)
            {
                var item = explorerList[e.RowIndex];
                CurrentFastColoredTextBox.GoEnd();
                CurrentFastColoredTextBox.SelectionStart = item.position;
                CurrentFastColoredTextBox.DoSelectionVisible();
                CurrentFastColoredTextBox.Focus();
            }
        }

        private void dgvObjectExplorer_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

            try
            {
                ExplorerItem item = explorerList[e.RowIndex];
                if (e.ColumnIndex == 1)
                    e.Value = item.title;
                else
                    switch (item.type)
                    {
                        case ExplorerItemType.DisabledProperty:
                            e.Value = Resources.disabled_property;
                            return;
                        case ExplorerItemType.Class:
                            e.Value = Resources.class_libraries;
                            return;
                        case ExplorerItemType.Method:
                            e.Value = Resources.box;
                            return;
                        case ExplorerItemType.Event:
                            e.Value = Resources.lightning;
                            return;
                        case ExplorerItemType.Property:
                            e.Value = Resources.property;
                            return;
                    }
            }
            catch {; }
        }

        private void btHighlightCurrentLine_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in tsFiles.Items)
            {
                if (btHighlightCurrentLine.Checked)
                    (tab.Controls[0] as FastColoredTextBox).CurrentLineColor = _currentLineColor;
                else
                    (tab.Controls[0] as FastColoredTextBox).CurrentLineColor = Color.Transparent;
            }
            if (CurrentFastColoredTextBox != null)
                CurrentFastColoredTextBox.Invalidate();
        }

        private void tsFiles_TabStripItemSelectionChanged(TabStripItemChangedEventArgs e)
        {
            this.Text = string.Format("Marlin Editor - {0}", e.Item.Tag);
            
            FastColoredTextBox tb = (e.Item.Controls[0] as FastColoredTextBox);
            //rebuild object explorer
            if (tb != null)
            {
                string text = tb.Text;
                ThreadPool.QueueUserWorkItem(
                    o => ReBuildObjectExplorer(text)
                    );
            }
        }

        private void FrmMarlinEditor_Load(object sender, EventArgs e)
        {
            //string documentation =  MarlinDocumentationHarvestClass.GetMarlinConfigurationDocumentation(@"http://www.marlinfw.org/docs/development/configuration.html");

            //TODO: Dialog containing setup for Current and New Firmware

            if (string.IsNullOrEmpty(FirmwareDirectory))
            {
                FirmwareDirectory = _configuration.CurrentFirmware;
            }

            if (File.Exists(Path.Combine(FirmwareDirectory, @"configuration.h")))
            {
                CreateTab(Path.Combine(FirmwareDirectory, @"configuration.h"));
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (CurrentFastColoredTextBox != null)
                CurrentFastColoredTextBox.Zoom = int.Parse((sender as ToolStripItem).Tag.ToString());
        }

        private void toolStripArduinoIDE_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();

            string workingDirectory = Path.GetDirectoryName(tsFiles.SelectedItem.Tag.ToString());

            DialogResult result =
            MessageBox.Show(@"Starting Arduino IDE with Marlin.ino" + Environment.NewLine + Environment.NewLine +
                            @"* Working directory: " + workingDirectory + Environment.NewLine +
                            @"* Arduino directory: " + configuration.ArduinoIde + Environment.NewLine +
                            Environment.NewLine +
                            @"Is CallConvThiscall what you want?", @"Starting Arduino IDE with Marlin.ino",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Cancel) return;



            
            var compileAndUpload = new Process();
            compileAndUpload.StartInfo.UseShellExecute = false;
            compileAndUpload.StartInfo.RedirectStandardOutput = true;
            compileAndUpload.StartInfo.WorkingDirectory = configuration.CurrentFirmware;
            compileAndUpload.StartInfo.FileName = Path.Combine(configuration.ArduinoIde, "arduino.exe");
            compileAndUpload.StartInfo.Arguments = " \"" + Path.Combine(configuration.CurrentFirmware, "marlin.ino") + "\" --upload ";
            compileAndUpload.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            // string output = compileAndUpload.StandardOutput.ReadToEnd();
            compileAndUpload.WaitForExit();
        }

        private void toolStripMigration_Click(object sender, EventArgs e)
        {
            FrmFirmware migrate = new FrmFirmware();
            migrate.ShowDialog();

        }

        private void toolStripSetup_Click(object sender, EventArgs e)
        {
            FrmMarlinEditorSetup setup = new FrmMarlinEditorSetup();
            setup.ShowDialog();
            string fileName = Path.Combine(_configuration.CurrentFirmware, "configuration.h");
            if (File.Exists(fileName))
            {
                CreateTab(fileName);
            }

        }
    }


    /// <summary>
    /// Inerts line break after '}'
    /// </summary>
    class InsertEnterSnippet : AutocompleteItem
    {
        Place enterPlace = Place.Empty;

        public InsertEnterSnippet()
            : base("[Line break]")
        {
        }

        public override CompareResult Compare(string fragmentText)
        {
            var r = Parent.Fragment.Clone();
            while (r.Start.iChar > 0)
            {
                if (r.CharBeforeStart == '}')
                {
                    enterPlace = r.Start;
                    return CompareResult.Visible;
                }

                r.GoLeftThroughFolded();
            }

            return CompareResult.Hidden;
        }

        public override string GetTextForReplace()
        {
            //extend range
            Range r = Parent.Fragment;
            Place end = r.End;
            r.Start = enterPlace;
            r.End = r.End;
            //insert line break
            return Environment.NewLine + r.Text;
        }

        public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
        {
            base.OnSelected(popupMenu, e);
            if (Parent.Fragment.tb.AutoIndent)
                Parent.Fragment.tb.DoAutoIndent();
        }

        public override string ToolTipTitle
        {
            get
            {
                return "Insert line break after '}'";
            }
        }
    }

    /// <summary>
    /// This item appears when any part of snippet text is typed
    /// </summary>
    class DeclarationSnippet : SnippetAutocompleteItem
    {
        public DeclarationSnippet(string snippet)
            : base(snippet)
        {
        }

        public override CompareResult Compare(string fragmentText)
        {
            var pattern = Regex.Escape(fragmentText);
            if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                return CompareResult.Visible;
            return CompareResult.Hidden;
        }
    }

    /// <summary>
    /// Divides numbers and words: "123AND456" -> "123 AND 456"
    /// Or "i=2" -> "i = 2"
    /// </summary>
    class InsertSpaceSnippet : AutocompleteItem
    {
        string pattern;

        public InsertSpaceSnippet(string pattern)
            : base("")
        {
            this.pattern = pattern;
        }

        public InsertSpaceSnippet()
            : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
        {
        }

        public override CompareResult Compare(string fragmentText)
        {
            if (Regex.IsMatch(fragmentText, pattern))
            {
                Text = InsertSpaces(fragmentText);
                if (Text != fragmentText)
                    return CompareResult.Visible;
            }
            return CompareResult.Hidden;
        }

        public string InsertSpaces(string fragment)
        {
            var m = Regex.Match(fragment, pattern);
            if (m == null)
                return fragment;
            if (m.Groups[1].Value == "" && m.Groups[3].Value == "")
                return fragment;
            return (m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value).Trim();
        }

        public override string ToolTipTitle
        {
            get
            {
                return Text;
            }
        }
    }

    enum ExplorerItemType
    {
        Define, Class, Method, Property, Event,DisabledProperty
    }


    class ExplorerItem
    {
        public ExplorerItemType type;
        public string title;
        public int position;
    }

    class ExplorerItemComparer : IComparer<ExplorerItem>
    {
        public int Compare(ExplorerItem x, ExplorerItem y)
        {
            return x.title.CompareTo(y.title);
        }
    }


    public class TbInfo
    {
        public AutocompleteMenu popupMenu;
    }

    public class InvisibleCharsRenderer : Style
    {
        Pen pen;

        public InvisibleCharsRenderer(Pen pen)
        {
            this.pen = pen;
        }

        public override void Draw(Graphics gr, Point position, Range range)
        {
            var tb = range.tb;
            using (Brush brush = new SolidBrush(pen.Color))
                foreach (var place in range)
                {
                    switch (tb[place].c)
                    {
                        case ' ':
                            var point = tb.PlaceToPoint(place);
                            point.Offset(tb.CharWidth / 2, tb.CharHeight / 2);
                            gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
                            break;
                    }

                    if (tb[place.iLine].Count - 1 == place.iChar)
                    {
                        var point = tb.PlaceToPoint(place);
                        point.Offset(tb.CharWidth, 0);
                        gr.DrawString("¶", tb.Font, brush, point);
                    }
                }
        }
    }
}
