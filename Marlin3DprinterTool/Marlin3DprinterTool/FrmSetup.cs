using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Marlin3DprinterToolConfiguration;
using MarlinComunicationHelper;
using MarlinDocumentation;
using Microsoft.Win32;
using ServerManager;
using SharpShellServerManager;

namespace Marlin3DprinterTool
{
    /// <summary>
    /// Form for Setup of License and some other initial stuff
    /// </summary>
    public partial class FrmSetup : Form
    {

        private readonly Configuration _configuration = new Configuration();


        /// <summary>
        /// /Form for Setup of License and some other initial stuff
        /// </summary>
        public FrmSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _configuration.LicenseKey = txtBxUnlockKey.Text;
            Close();
        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {
            
            txtBxUnlockKey.Text = _configuration.LicenseKey;
            UpdateServerStatus();
            ShowLicense();
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
            string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                "Marlin3DprinterToolStlThumbnail.dll");
            SharpShellServerManagerClass.InstallServer(stlViewerThumbnail, osIs32Bit);
            UpdateServerStatus();
        }

        private void btnUnInstallStlServer_Click(object sender, EventArgs e)
        {
            string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
               "Marlin3DprinterToolStlThumbnail.dll");
            bool osIs32Bit = chkBx32BitOS.Checked;
            SharpShellServerManagerClass.Unregister(stlViewerThumbnail, osIs32Bit);
            UpdateServerStatus();
        }

        private void btnTroubleShootStl_Click(object sender, EventArgs e)
        {
            FrmRTFdocumentation stlTroubleshoot = new FrmRTFdocumentation { Filename = "STL thumbnail debug.rtf" };
            stlTroubleshoot.ShowDialog();
        }

        private void btnColorStl_Click(object sender, EventArgs e)
        {
            ColorConverter exitingColor = new ColorConverter();
            exitingColor.ConvertFrom(_configuration.STLcolor);
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = (Color)exitingColor.ConvertFrom(_configuration.STLcolor);
            colorDialog.AllowFullOpen = false;
            colorDialog.AnyColor = false;
            colorDialog.ShowHelp = true;
            colorDialog.FullOpen = false;
            colorDialog.ShowDialog();
            _configuration.STLcolor = colorDialog.Color.IsNamedColor
                ? colorDialog.Color.Name
                : $"#{colorDialog.Color.Name}";

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




            string stlViewerThumbnail = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"Marlin3DprinterToolStlThumbnail.dll");
            //TODO: SharpShellServerManagerClass.Serverentries
            IEnumerable<ServerEntry> serverEntries = SharpShellServerManagerClass.UpdateServerStatus(stlViewerThumbnail);

            if (serverEntries != null)
            {
                foreach (ServerEntry serverEntry in serverEntries)
                {
                    SharpShellServerManagerClass.ServerInfo serverinfo = SharpShellServerManagerClass.GetServerinfo(serverEntry);
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

        }

        private void grpBxLicensedTo_Enter(object sender, EventArgs e)
        {

        }
    }
}
