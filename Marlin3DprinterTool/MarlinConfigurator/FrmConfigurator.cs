using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using Marlin3DprinterToolConfiguration;
using Marlin3DprinterToolUserControls;


namespace MarlinConfigurator
{
    public partial class FrmConfigurator : Form
    {
        public FrmConfigurator()
        {
            InitializeComponent();
        }


        private void TxtBxcurrentFirmware_TextChanged(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void TxtBxNewFirmware_TextChanged(object sender, EventArgs e)
        {
            UpdateGui();

        }

        private void BtnBrowsecurrentFirmware_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog firmware = new FolderBrowserDialog
                {
                    Description = @"Directory thet contains Old Marlin Firmware",
                    SelectedPath = txtBxcurrentFirmware.Text
            };
            
            if(firmware.ShowDialog() != DialogResult.OK) return;
            
            txtBxcurrentFirmware.Text = firmware.SelectedPath;

        }

        private void BtnBrowseNewFirmware_Click(object sender, EventArgs e)
        {
            string text = BrowseNewFirmwareDirectory(txtBxNewFirmware.Text);
            if (text != null) txtBxNewFirmware.Text = text;
        }

        private string BrowseNewFirmwareDirectory(string startFolder)
        {
            FolderBrowserDialog firmware = new FolderBrowserDialog
            {
                Description = @"Directory thet contains New Marlin Firmware",
                SelectedPath = startFolder
            };
            
            return firmware.ShowDialog() != DialogResult.OK ? null : firmware.SelectedPath;
        }

        private void FrmConfigurator_Load(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            txtBxcurrentFirmware.Text = configuration.CurrentFirmware;
            txtBxNewFirmware.Text = configuration.NewFirmware;
            UpdateGui();
        }



        private void UpdateGui()
        {
            webBrowserMarlinHelp.Visible = false;
            FirmwareHelper firmware = new FirmwareHelper {FileName = Path.Combine(txtBxNewFirmware.Text, "configuration.h")};
            webBrowserMarlinHelp.Visible = true;
            webBrowserMarlinHelp.Url = new Uri("http://marlinfw.org/docs/configuration/configuration.html#configuring-marlin-1.1");
            // Load comboBoxes
            marlinComboBoxMOTHERBOARD.Clear();
            foreach (ComboboxItem comboboxItem in firmware.GetAllBoards())
            {
                marlinComboBoxMOTHERBOARD.AddComboItems(comboboxItem);
            }

            marlinComboBoxTEMP_SENSOR_0.Clear();
            marlinComboBoxTEMP_SENSOR_1.Clear();
            marlinComboBoxTEMP_SENSOR_2.Clear();
            marlinComboBoxTEMP_SENSOR_3.Clear();
            marlinComboBoxTEMP_SENSOR_4.Clear();
            marlinComboBoxTEMP_SENSOR_BED.Clear();
            foreach (ComboboxItem comboboxItem in firmware.GetTempSensors())
            {
                marlinComboBoxTEMP_SENSOR_0.AddComboItems(comboboxItem);
                marlinComboBoxTEMP_SENSOR_1.AddComboItems(comboboxItem);
                marlinComboBoxTEMP_SENSOR_2.AddComboItems(comboboxItem);
                marlinComboBoxTEMP_SENSOR_3.AddComboItems(comboboxItem);
                marlinComboBoxTEMP_SENSOR_4.AddComboItems(comboboxItem);
                marlinComboBoxTEMP_SENSOR_BED.AddComboItems(comboboxItem);
            }

            marlinComboBoxLCD_LANGUAGE.Clear();
            foreach (ComboboxItem comboboxItem in firmware.GetLanguages())
            {
                marlinComboBoxLCD_LANGUAGE.AddComboItems(comboboxItem);
            }

            marlinComboBoxDISPLAY_CHARSET_HD44780.Clear();
            foreach (ComboboxItem comboboxItem in firmware.GetHD44780Charset())
            {
                marlinComboBoxDISPLAY_CHARSET_HD44780.AddComboItems(comboboxItem);
            }



            firmware.UpdateNewFirmware(this, Path.Combine(txtBxcurrentFirmware.Text, "configuration.h"), Path.Combine(txtBxNewFirmware.Text, "configuration.h"));

            webBrowserMarlinHelp.Visible = true;
        }

        

        

        private void BtnDownloadMarlinStable_Click(object sender, EventArgs e)
        {
            string link = @"https://github.com/MarlinFirmware/Marlin/archive/1.1.x.zip";

            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (Directory.Exists(txtBxNewFirmware.Text))
            {
                folder.SelectedPath = txtBxNewFirmware.Text;
            }

            if (folder.ShowDialog() != DialogResult.OK) return;

            string[] files = Directory.GetFiles(folder.SelectedPath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Cant delete files in " + folder.SelectedPath + Environment.NewLine +
                                    @"Error: " + exception.Message);
                    return;
                }

            }

            string[] directories = Directory.GetDirectories(folder.SelectedPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string directory in directories)
            {
                try
                {
                    Directory.Delete(directory, true);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Cant delete Directories in " + folder.SelectedPath + Environment.NewLine +
                                    @"Error: " + exception.Message);
                    return;
                }

            }


            try
            {
                WebClient myWebClient = new WebClient();
                // Download the Web resource and save it into the current filesystem folder.
                myWebClient.DownloadFile(link, Path.Combine(folder.SelectedPath, "1.1.x.zip"));
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Cant download latest version of Marlin" + Environment.NewLine +
                                @"Error : " + exception.Message);
                return;
            }

            
           

            if (File.Exists(Path.Combine(folder.SelectedPath,"1.1.x.zip")))
            {
                
                ZipFile.ExtractToDirectory(Path.Combine(folder.SelectedPath, "1.1.x.zip"),folder.SelectedPath);
                txtBxNewFirmware.Text = BrowseNewFirmwareDirectory(folder.SelectedPath);

            }

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FirmwareHelper firmware = new FirmwareHelper();
            firmware.DirectoryCopy(@"C:\NewFirmware\MarlinBackup", @"C:\NewFirmware\Marlin", true);
            firmware.UpdateNewFirmware(this, Path.Combine(txtBxcurrentFirmware.Text, "configuration.h"), Path.Combine(txtBxNewFirmware.Text, "configuration.h"));


        }

        private void ToolStripButtonPrevious_Click(object sender, EventArgs e)
        {
            tabControlConfiguration.SelectedIndex = Math.Max(0, tabControlConfiguration.SelectedIndex - 1);
        }

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
        {
            tabControlConfiguration.SelectedIndex = tabControlConfiguration.SelectedIndex + 1;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            tabControlConfiguration.SelectedIndex = 0;
        }

        private void toolStripButtonSetup_Click(object sender, EventArgs e)
        {
            Marlin3DprinterSetup setup = new Marlin3DprinterSetup();
            setup.ShowDialog();
        }

        private void toolStripButtonPayPal_Click(object sender, EventArgs e)
        {
            const string url = "https://www.paypal.com/cgi-bin/webscr" +
                               @"?cmd=" + "_donations" +
                               @"&business=" + "cabbagecreek@gmail.com" +
                               @"&lc=" + "US" +
                               @"&item_name=" + "Marlin 3D printer Tool Donation" +
                               @"&notify_url=" + @"http://marlin3dprintertool.se/PayPal/PayPalIPN.php" +
                               @"&amount=5" +
                               @"&currency_code=" + "USD" +
                               @"&bn=" + "PP%2dDonationsBF";
            try
            {
                Process myProcess = new Process
                {
                    StartInfo =
                    {
                        UseShellExecute = true,
                        FileName = url
                    }
                };



                // true is the default, but it is important not to set it to false
                myProcess.Start();
            }
            catch (Exception webbroserException)
            {
                MessageBox.Show(@"Cant open the default webbrowser with connection to PayPal" + Environment.NewLine +
                                Environment.NewLine +
                                @"Reason: " + webbroserException.Message, @"Cant find default browser", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Clipboard.SetText(url);

                MessageBox.Show(@"The webaddress and parameters are copied to ClipBoard" + Environment.NewLine + Environment.NewLine +
                                @"Do the donation manually by paste it (ctrl+V) in your webbrowser address field", @"Manual PayPal donation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
