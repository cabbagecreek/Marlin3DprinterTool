using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MarlinDocumentation;
using Microsoft.Win32;
using ServerManager;


namespace Marlin3DprinterToolConfiguration
{
    public partial class Marlin3DprinterSetup : Form
    {
        private readonly Configuration _configuration = new Configuration();

        public Marlin3DprinterSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _configuration.LicenseKey = txtBxUnlockKey.Text;
            Close();
        }


        private void ShowLicense()
        {
            if (string.IsNullOrEmpty(txtBxUnlockKey.Text)) return;

            txtBxShowLicence.Text = Configuration.Decrypt(txtBxUnlockKey.Text).Replace(";", Environment.NewLine);
        }

        private void txtBxUnlockKey_TextChanged(object sender, EventArgs e)
        {
            ShowLicense();
        }

        private void btnPayPal_Click(object sender, EventArgs e)
        {
            var url = "https://www.paypal.com/cgi-bin/webscr" +
                      @"?cmd=" + "_donations" +
                      @"&business=" + "cabbagecreek@gmail.com" +
                      @"&lc=" + "US" +
                      @"&item_name=" + "Marlin 3D printer Tool Donation" +
                      @"&amount=5" +
                      @"&currency_code=" + "USD" +
                      @"&bn=" + "PP%2dDonationsBF";

            Process.Start("IEXPLORE", url);
        }

        private void btnInstallStlServer_Click(object sender, EventArgs e)
        {
            bool osIs32Bit = chkBx32BitOS.Checked;
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!string.IsNullOrEmpty(executablePath))
            {
                string stlViewerThumbnail = Path.Combine(executablePath,"Marlin3DprinterToolStlThumbnail.dll");
                SharpShellServerManagerClass.InstallServer(stlViewerThumbnail, osIs32Bit);

            }

           
            UpdateServerStatus();
        }

        private void btnUnInstallStlServer_Click(object sender, EventArgs e)
        {
            bool osIs32Bit = chkBx32BitOS.Checked;
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!string.IsNullOrEmpty(executablePath))
            {
                string stlViewerThumbnail = Path.Combine(executablePath,"Marlin3DprinterToolStlThumbnail.dll");
                SharpShellServerManagerClass.Unregister(stlViewerThumbnail, osIs32Bit);
            }
            
            
            UpdateServerStatus();
        }

        private void btnTroubleShootStl_Click(object sender, EventArgs e)
        {
            FrmRTFdocumentation stlTroubleshoot = new FrmRTFdocumentation {Filename = "STL thumbnail debug.rtf"};
            stlTroubleshoot.ShowDialog();
        }

        private void btnColorStl_Click(object sender, EventArgs e)
        {
            ColorConverter exitingColor = new ColorConverter();
            var convertFromColor = exitingColor.ConvertFrom(_configuration.STLcolor);
            if (convertFromColor != null)
            {
                Color color = (Color) convertFromColor;
                ColorDialog colorDialog = new ColorDialog
                {
                    Color = color,
                    AllowFullOpen = false,
                    AnyColor = false,
                    ShowHelp = true,
                    FullOpen = false
                };
                colorDialog.ShowDialog();
                _configuration.STLcolor = colorDialog.Color.IsNamedColor
                    ? colorDialog.Color.Name
                    : $"#{colorDialog.Color.Name}";
            }

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Marlin3DprinterTool", "Color", _configuration.STLcolor);
            //string color = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Software\Marlin3DprinterTool","Color","Brown");
            //MessageBox.Show(color);
        }

        private void btnRestartWindowsFileExplorer_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    @"Be sure that all important work is SAVED!" + Environment.NewLine + Environment.NewLine +
                    @"Explorer will be forced to restart"
                    , @"Restarting Explorer", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel) return;

            SharpShellServerManagerClass.RestartExplorer();

            MessageBox.Show(@"Restart of Explorer DONE!", @"Restart of Explorer", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnResetAndCleanExistingThumbnails_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    @"Be sure that all important work is SAVED!" + Environment.NewLine + Environment.NewLine +
                    @"This is a more BRUTAL method of reseting the File Explorer Thumbnails"
                    , @"Forced Delete of Thumbnail cache", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel) return;


            SharpShellServerManagerClass.ResetAndCleanExistingThumbnails();
            MessageBox.Show(@"Forced Delete of Thumbnail Cache and Restart of Explorer is DONE!", @"Restart of Explorer",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAssociateStlViewer_Click(object sender, EventArgs e)
        {

            string stlViewerExe = Path.GetDirectoryName(Application.ExecutablePath);

            if (stlViewerExe != null)
            {
                stlViewerExe = Path.Combine(stlViewerExe, "Marlin3DprinterStlViewer.exe");

                FileAssociation.Associate(".stl", "Marlin3DprinterToolSTLviewer", "MarlinSTLviewer",
                    "Marlin3DprinterTool.ico", stlViewerExe);
                MessageBox.Show(@"STL viewer is now the prefered stl-application", @"Assign STL Viewer",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void UpdateServerStatus()
        {


            string stlViewerExe = Path.GetDirectoryName(Application.ExecutablePath);

            if (stlViewerExe != null)
            {

                string stlViewerThumbnail = Path.Combine(stlViewerExe,"Marlin3DprinterToolStlThumbnail.dll");
                IEnumerable<ServerEntry> serverEntries = SharpShellServerManagerClass.UpdateServerStatus(stlViewerThumbnail);

                if (serverEntries != null)
                {
                    foreach (ServerEntry serverEntry in serverEntries)
                    {
                        
                        Marlin3DprinterToolConfiguration.SharpShellServerManagerClass.ServerInfo serverinfo = SharpShellServerManagerClass.GetServerinfo(serverEntry);
                        textBoxServerName.Text = serverinfo.ServerName;
                        textBoxServerType.Text = serverinfo.ServerType;
                        textBoxServerCLSID.Text = serverinfo.ClassId;
                        textBoxServerSecurity.Text = serverinfo.SecurityStatus;
                        textBoxAssemblyPath.Text = serverinfo.ServerPath;
                        if (serverinfo.IsInvalid)
                        {
                            //  Clear other data for invalid servers.
                            textBoxAssociations.Text = string.Empty;
                            ledServer32.Color = Color.Gray;
                            ledServer64.Color = Color.Gray;
                            ledRegister32.Color = Color.Gray;
                            ledRegister64.Color = Color.Gray;
                        }
                        else
                        {

                            textBoxAssociations.Text = serverinfo.Association;



                            //  By default, our installation info is going all led gray.
                            ledServer32.Color = Color.Gray;
                            ledServer64.Color = Color.Gray;
                            ledRegister32.Color = Color.Gray;
                            ledRegister64.Color = Color.Gray;

                            //  Do we have 32 bit registration info?
                            if (serverinfo.Info32 != null)
                            {
                                //  Do we have a codebase?
                                if (!string.IsNullOrEmpty(serverinfo.Info32.CodeBase))
                                {
                                    //textBox32BitServer.Text = info32.CodeBase;
                                    ledServer32.Color = Color.Chartreuse;
                                }
                                else if (!string.IsNullOrEmpty(serverinfo.Info32.Assembly))
                                    //textBox32BitServer.Text = info32.Assembly + " (GAC)";
                                    ledServer32.Color = Color.Chartreuse;

                                //  Set the registration info.
                                if (serverinfo.Info32.IsApproved)
                                {
                                    //textBox32BitServerRegistration.Text = "Registered";
                                    ledRegister32.Color = Color.Chartreuse;
                                }

                            }

                            //  Do we have 64 bit registration info?
                            if (serverinfo.Info64 != null)
                            {
                                //  Do we have a codebase?
                                if (!string.IsNullOrEmpty(serverinfo.Info64.CodeBase))
                                {
                                    //textBox64BitServer.Text = info64.CodeBase;
                                    ledServer64.Color = Color.Chartreuse;
                                }
                                else if (!string.IsNullOrEmpty(serverinfo.Info64.Assembly))
                                {
                                    //textBox64BitServer.Text = info64.Assembly + " (GAC)";
                                    ledServer64.Color = Color.Chartreuse;
                                }

                                //  Set the registration info.
                                if (serverinfo.Info64.IsApproved)
                                {
                                    //textBox64BitServerRegistration.Text = "Registered";
                                    ledRegister64.Color = Color.Chartreuse;
                                }
                            }
                        }

                    }
                }
            } // stlViewerExe found

        }

        private void btnDirectoryCurrentFirmware_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog currentFirmwareBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = configuration.CurrentFirmware,
                Description = @"Directory to current Firmware"
            };
            DialogResult result = currentFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) txtBxDirectoryCurrentFirmware.Text = currentFirmwareBrowserDialog.SelectedPath;
        }

        private void btnDirectoryNewFirmware_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog newFirmwareBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = configuration.NewFirmware,
                Description = @"Directory to new Firmware"
            };
            DialogResult result = newFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) txtBxDirectoryNewFirmware.Text = newFirmwareBrowserDialog.SelectedPath;
        }

        private void btnArduinoIDE_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog arduinoIdeBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = configuration.ArduinoIde,
                Description = @"Directory to Arduino IDE"
            };
            DialogResult result = arduinoIdeBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) txtBxArduinoIDE.Text = arduinoIdeBrowserDialog.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            _configuration.CurrentFirmware = txtBxDirectoryCurrentFirmware.Text;
            _configuration.NewFirmware = txtBxDirectoryNewFirmware.Text;
            _configuration.ArduinoIde = txtBxArduinoIDE.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Marlin3DprinterSetup_Load(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            txtBxDirectoryCurrentFirmware.Text = configuration.CurrentFirmware;
            txtBxDirectoryNewFirmware.Text = configuration.NewFirmware;
            txtBxArduinoIDE.Text = configuration.ArduinoIde;

            txtBxUnlockKey.Text = configuration.LicenseKey;
            UpdateServerStatus();
            ShowLicense();

        }

    }

   
    /// <summary>
    /// 
    /// </summary>
    public static class FileAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="progID"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="application"></param>
        // Associate file extension with progID, description, icon and application
        public static void Associate(string extension,
            string progID, string description, string icon, string application)
        {
            RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(extension);
            registryKey?.SetValue("", progID);


            if (string.IsNullOrEmpty(progID)) return;
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progID))
            {
                if (description != null)
                {
                    key?.SetValue("", description);
                }
                if (icon != null)
                {
                    var subKey = key?.CreateSubKey("DefaultIcon");
                    subKey?.SetValue("", ToShortPathName(icon));
                }
                if (application != null)
                {
                    var subKey = key?.CreateSubKey(@"Shell\Open\Command");
                    subKey?.SetValue("", ToShortPathName(application) + " \"%1\"");
                }
            }
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="extension"></param>
        ///// <returns></returns>
        //// Return true if extension already associated in registry
        //public static bool IsAssociated(string extension)
        //{
        //    return (Registry.ClassesRoot.OpenSubKey(extension, false) != null);
        //}

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath,
            [Out] StringBuilder lpszShortPath, uint cchBuffer);

        // Return short path format of a file name
        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            GetShortPathName(longName, s, iSize);
            return s.ToString();
        }

        //    // Tell explorer the file association has been changed
        //    SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
    }
}
