using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Marlin3DprinterToolConfiguration;

namespace MarlinEditor
{
    public partial class FrmMigrationCompare : Form
    {
        readonly Configuration _configuration = new Configuration();


        public FrmMigrationCompare()
        {
            InitializeComponent();
            StartSearch();
        }

        public List<FileInfo> FileNames { get; set; }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            FileNames = new List<FileInfo>();
            try
            {
                foreach (FileInfo fileInfo in lstBxFileNames.Items)
                {
                    FileNames.Add(fileInfo);
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
            

            Close();
            

        }


        private void StartSearch()
        {
            fctbCurrentFirmware.Visible = false;
            fctbNewFirmware.Visible = false;

            progressBarWorkingOnFile.Visible = true;
            lblCurrentWorkingOnFile.Visible = true;
            btnStopCompare.Visible = true;
            btnCompare.Visible = false;
            backgroundWorkerCompare.RunWorkerAsync();
        }




        private void Compare()
        {

           
            // Load all files in current firmware

            DelegateListBoxItemsClear(lstBxFileNames);
            string[] currentFirmwareFiles = Directory.GetFiles(_configuration.CurrentFirmware, "*.h");


            for (int index = 0; index < currentFirmwareFiles.Length; index++)
            {
                if (backgroundWorkerCompare.CancellationPending) break;


                string firmwareFile = currentFirmwareFiles[index];
                FileInfo fileInfo = new FileInfo(firmwareFile);

                backgroundWorkerCompare.ReportProgress(Math.Min(100, (index * 100) / currentFirmwareFiles.Length));


                DelegateText(lblCurrentWorkingOnFile,$"Working on file: {fileInfo.Name} ({progressBarWorkingOnFile.Value} % )");


                LoadFiles(fileInfo.Name);




                if (MarlinMigrateHelper.IsFilesEqual(fctbCurrentFirmware, fctbNewFirmware)) continue; // No differance = Next file

                foreach (string feature in MarlinMigrateHelper.FindFirmwareFeatures(fctbCurrentFirmware))
                {
                    MarlinMigrateHelper.BookmarkChangeNeeded(feature, fctbCurrentFirmware, fctbNewFirmware);
                    if (fctbCurrentFirmware.Bookmarks.Count != 0) break;
                }

                if (fctbCurrentFirmware.Bookmarks.Count != 0)
                {
                    DelegateListBoxAdd(lstBxFileNames, fileInfo);
                }
            }
        }

        private void LoadFiles(string filename)
        {
            


            fctbCurrentFirmware.DescriptionFile = "ArduinoSyntax.xml";
            fctbCurrentFirmware.Language = Language.Custom;
            fctbCurrentFirmware.Font = new Font("Consolas", 9.75f);

            fctbNewFirmware.DescriptionFile = "ArduinoSyntax.xml";
            fctbNewFirmware.Language = Language.Custom;
            fctbNewFirmware.Font = new Font("Consolas", 9.75f);



            MarlinMigrateHelper.FixCrLfProblems(Path.Combine(_configuration.CurrentFirmware, filename));
            MarlinMigrateHelper.FixCrLfProblems(Path.Combine(_configuration.NewFirmware, filename));



            if (File.Exists(Path.Combine(_configuration.CurrentFirmware, filename)))
            {
                DelegateFctbOpenFile(fctbCurrentFirmware,Path.Combine(_configuration.CurrentFirmware, filename), Encoding.UTF8);
            }
            fctbCurrentFirmware.Tag =  new FileInfo( Path.Combine(_configuration.CurrentFirmware, filename));

            if (File.Exists(Path.Combine(_configuration.NewFirmware, filename)))
            {
                DelegateFctbOpenFile(fctbNewFirmware , Path.Combine(_configuration.NewFirmware, filename), Encoding.UTF8);
            }
            fctbNewFirmware.Tag = new FileInfo( Path.Combine(_configuration.NewFirmware, filename));


            

            

        }

        private void backgroundWorkerCompare_DoWork(object sender, DoWorkEventArgs e)
        {
            Compare();
        }


        private void DelegateListBoxItemsClear(ListBox control)
        {
            if (control.InvokeRequired)
            {
                DelegateListBoxItemsClearCallback d = DelegateListBoxItemsClear;
                Invoke(d, control);
            }
            else
            {
                control.Items.Clear();
            }
        }
        private delegate void DelegateListBoxItemsClearCallback(ListBox control);


        private void DelegateText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                DelegateTextCallback d = DelegateText;
                Invoke(d, control, text);
            }
            else
            {
                control.Text = text;
            }
        }

        private delegate void DelegateTextCallback(Control control, string text);


        private void DelegateFctbOpenFile(FastColoredTextBox fctb, string filename, Encoding encoding)
        {
            if (fctb.InvokeRequired)
            {
                DelegateFctbOpenFileCallback d = DelegateFctbOpenFile;
                Invoke(d, fctb, filename, encoding);
            }
            else
            {
                fctb.OpenFile(filename,encoding);
            }
        }

        private delegate void DelegateFctbOpenFileCallback(FastColoredTextBox fctb, string filename, Encoding encoding);



        private void DelegateListBoxAdd(ListBox control, FileInfo fileInfo)
        {
            if (control.InvokeRequired)
            {
                DelegateListBoxAddCallback d = DelegateListBoxAdd;
                Invoke(d, control, fileInfo);

            }
            else
            {
                control.Items.Add(fileInfo);
            }
        }

        private delegate void DelegateListBoxAddCallback(ListBox control, FileInfo fileInfo);

        private void backgroundWorkerCompare_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarWorkingOnFile.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerCompare_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarWorkingOnFile.Visible = false;
            lblCurrentWorkingOnFile.Visible = false;
            btnStopCompare.Visible = false;
            btnCompare.Visible = true;
            MessageBox.Show("All files scanned for changes");
        }

        private void btnStopCompare_Click(object sender, EventArgs e)
        {
            backgroundWorkerCompare.CancelAsync();
            btnCompare.Visible = true;
        }
    }
}
