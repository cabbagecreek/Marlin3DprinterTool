using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
                    var downloadDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    //var downloadDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (downloadDirectory != null)
                    {
                        DownloadMsiTo = Path.Combine(downloadDirectory, @"Marlin3DprinterTool.msi");

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
                Close();
                DialogResult = DialogResult.Cancel;
            }
            
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (File.Exists(DownloadMsiTo))
            {

                

                Process scheduler = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = @"msiexec",
                    Arguments = @"/a " + DownloadMsiTo,
                    UseShellExecute = false,
                    CreateNoWindow = false,
                    WorkingDirectory = Path.GetDirectoryName(DownloadMsiTo),
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                };
                scheduler.StartInfo = startInfo;
                scheduler.Start();

               

                
                

                // Close and assign yes to the closing window
                Close();
                DialogResult = DialogResult.Yes;
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
