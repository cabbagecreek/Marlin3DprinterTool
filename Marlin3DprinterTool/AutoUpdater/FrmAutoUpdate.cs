using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace AutoUpdater
{
    public partial class FrmAutoUpdate : Form
    {
        private Version _currentVersion;
        private Version _newVersion;

        public FrmAutoUpdate()
        {
            InitializeComponent();
        }

        public Version CurrentVersion
        {
            get { return _currentVersion; }
            set
            {
                _currentVersion = value;
                txtBxCurrentVersion.Text = _currentVersion.ToString();
                
            }
        }

        public string DownloadMsiTo { get; set; }

        public Version NewVersion
        {
            get { return _newVersion; }
            set
            {
                _newVersion = value;
                txtBxNewVersion.Text = _newVersion.ToString();
            }
        }

        public string XmlUrl { get; set; }

        private void btnYes_Click(object sender, EventArgs e)
        {

            
            try
            {

                
                XmlDocument xml = new XmlDocument();
                
                xml.Load(XmlUrl);
               
                XmlNode downlaodUrl = xml.SelectSingleNode("/Marlin3DprinterTool/DownloadUrl");
                
                if (downlaodUrl != null)
                {
                    
                    var currentDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    
                    if (currentDirectory != null)
                    {
                        
                        DownloadMsiTo = Path.Combine(currentDirectory, @"Marlin3DprinterTool.msi");
                        
                        if (File.Exists(DownloadMsiTo))
                        {
                            
                            File.Delete(DownloadMsiTo);
                        }

                        
                        using (WebClient wc = new WebClient())
                        {
                            
                            progressBarDownload.Visible = true;
                            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                            //wc.DownloadFile(new Uri(downlaodUrl.InnerText), downloadMsiTo);
                            wc.DownloadFileAsync(new Uri(downlaodUrl.InnerText), DownloadMsiTo);
                            
                        }


                    }
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
                DialogResult = DialogResult.Cancel;
                Close();
            }
            
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
            if (File.Exists(DownloadMsiTo))
            {
                
                
                Process runWinInstallProcess = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = DownloadMsiTo;
                startInfo.Arguments = "";
                startInfo.WorkingDirectory = Path.GetDirectoryName(DownloadMsiTo);
                runWinInstallProcess.StartInfo = startInfo;

                
                runWinInstallProcess.Start();

               
                
                

                // Close and assign yes to the closing window
                DialogResult = DialogResult.Yes;
                Close();
            }
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
