using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using LogicNP.EZShellExtensions;
using Marlin3DprinterToolConfiguration;
using Marlin3DprinterToolStlThumbnailProvider;
using Microsoft.Win32;
using PayPal;

namespace Marlin3DprinterToolStlConfiguration
{
    public partial class FrmStlConfiguration : Form
    {

        private readonly Configuration _configuration = new Configuration();

        public FrmStlConfiguration()
        {
            InitializeComponent();
        }

        private void btnInstallStlServer_Click(object sender, EventArgs e)
        {
            try
            {
                ThumbnailProvider.RegisterExtension(typeof (StlThumbnailProvider));
                MessageBox.Show("Registration done with RegisterExtension ");

            }
            catch (Exception ex1)
            {

                MessageBox.Show(@"Got priviledge problems. Tries another solution" + Environment.NewLine + ex1.Message);
                try
                {
                    Register();
                }
                catch (Exception ex2)
                {

                    MessageBox.Show(@"Tried to run as Administrator and even that attempt failed" + Environment.NewLine +
                                    ex2.Message);
                }
            }

            try
            {
                Register();
                MessageBox.Show("Registration done with Shell Register ");
            }
            catch (Exception ex3)
            {

                MessageBox.Show(@"Registration thru CMD failed. Registration must be don manually " +
                                Environment.NewLine + ex3.Message);
            }




        }


        private void Register()
        {
            //RegisterExtensionDotNetXX.exe -i "c:\Program Files\My App\MyContextMenuExtension.dll" 






            string fileName = Assembly.GetExecutingAssembly().Location;
            if (fileName != null)
            {


                string executingDirectory = new FileInfo(fileName).DirectoryName;

                if (string.IsNullOrEmpty(executingDirectory))
                {
                    return;
                }



                string executingRegister = "\"" +Path.Combine(executingDirectory, "RegisterExtensionDotNet40.exe") + "\"";
                string stlThumbnail = "\"" + Path.Combine(executingDirectory, "Marlin3DprinterToolStlThumbnail.dll") + "\"";

                string argument = $" -i {stlThumbnail} ";

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = executingRegister,
                    Arguments = argument,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Verb = "runas"
                };



                process.StartInfo = startInfo;

                process.Start();


                string processResponce = "";
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    processResponce += line + Environment.NewLine;
                }

                MessageBox.Show(processResponce);
                process.WaitForExit(5000);




            }



        }

        private void UnRegister()
        {
            //RegisterExtensionDotNetXX.exe -u "c:\Program Files\My App\MyContextMenuExtension.dll" 



            string fileName = Assembly.GetExecutingAssembly().Location;
            if (fileName != null)
            {


                string executingDirectory = new FileInfo(fileName).DirectoryName;

                if (string.IsNullOrEmpty(executingDirectory))
                {
                    return;
                }



                string executingRegister = "\"" + Path.Combine(executingDirectory, "RegisterExtensionDotNet40.exe") + "\"";
                string stlThumbnail = "\"" + Path.Combine(executingDirectory, "Marlin3DprinterToolStlThumbnail.dll") + "\"";

                string argument = $" -u {stlThumbnail} ";

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = executingRegister,
                    Arguments = argument,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Verb = "runas"
                };



                process.StartInfo = startInfo;

                process.Start();


                string processResponce = "";
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    processResponce += line + Environment.NewLine;
                }

                MessageBox.Show(processResponce);
                process.WaitForExit(5000);



            }



        }




        private static void RunCmd(string command, string argument, bool runAsAdministrator, bool messages)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = command,
                Arguments = argument,
                UseShellExecute = true,
                RedirectStandardOutput = messages,
                CreateNoWindow = true
            };

            if (runAsAdministrator)
            {
                startInfo.Verb = "runas";
            }

            if (messages) startInfo.UseShellExecute = false;

            process.StartInfo = startInfo;

            process.Start();
            if (messages)
            {
                string processResponce = "";
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    processResponce += line + Environment.NewLine;
                }

                MessageBox.Show(processResponce);
            }
            process.WaitForExit(5000);

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


            RunCmd("cmd.exe", "/C ie4uinit.exe -ClearIconCache", false, false);
            RunCmd(@"cmd.exe", @"/C taskkill /f /im explorer.exe", false, true);
            Thread.Sleep(2000);
            RunCmd("cmd.exe",
                $@"/C DEL /F /S /Q /A {Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Microsoft\Windows\Explorer\thumbcache_*.db"
                , false, true);
            Thread.Sleep(2000);
            RunCmd("cmd.exe", "/C ie4uinit.exe -ClearIconCache", false, true);

            string filename = null;
            string directory = Environment.GetEnvironmentVariable(@"windir");
            if (directory != null) filename = Path.Combine(directory, "explorer.exe");

            if (filename != null)
            {
                Process appli = new Process
                {

                    StartInfo =
                    {
                        FileName = filename,
                        UseShellExecute = true,
                        RedirectStandardOutput = false
                    }
                };
                appli.Start();

                SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
            }


            MessageBox.Show(@"Forced Delete of Thumbnail Cache and Restart of Explorer is DONE!", @"Restart of Explorer",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        private void btnUnInstallStlServer_Click(object sender, EventArgs e)
        {
            try
            {
                ThumbnailProvider.UnRegisterExtension(typeof (StlThumbnailProvider));
                MessageBox.Show(@"UnRegistration done with UnRegisterExtension ");

            }
            catch (Exception)
            {

                MessageBox.Show(@"Got priviledge problems. Tries another solution");
                try
                {
                    UnRegister();
                }
                catch (Exception)
                {

                    MessageBox.Show(@"Tried to run as Administrator and even that attempt failed");
                }
            }

            try
            {
                UnRegister();
                MessageBox.Show(@"Registration done with Shell UnRegister ");
            }
            catch (Exception)
            {

                MessageBox.Show(@"UnRegistration thru CMD failed. Registration must be don manually");
            }
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

            string fileName = Assembly.GetExecutingAssembly().Location;
            if (fileName != null)
            {
                string executingDirectory = new FileInfo(fileName).DirectoryName;

                if (String.IsNullOrEmpty(executingDirectory))
                {
                    return;
                }




                string executingRegister = Path.Combine(executingDirectory, "RestartExplorer.exe");




                RunCmd(executingRegister, " ", true, false);



            }
        }

        private void btnResetAndCleanExistingThumbnails_Click_1(object sender, EventArgs e)
        {

            DialogResult result =
                MessageBox.Show(
                    @"Be sure that all important work is SAVED!" + Environment.NewLine + Environment.NewLine +
                    @"This is a more BRUTAL method of reseting the File Explorer Thumbnails"
                    , @"Forced Delete of Thumbnail cache", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Cancel) return;


            RunCmd("cmd.exe", "/C ie4uinit.exe -ClearIconCache", false, false);
            RunCmd(@"cmd.exe", @"/C taskkill /f /im explorer.exe", false, true);
            Thread.Sleep(2000);
            RunCmd("cmd.exe",
                $@"/C DEL /F /S /Q /A {Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Microsoft\Windows\Explorer\thumbcache_*.db"
                , false, true);
            Thread.Sleep(2000);
            RunCmd("cmd.exe", "/C ie4uinit.exe -ClearIconCache", false, true);

            string filename = null;
            string directory = Environment.GetEnvironmentVariable(@"windir");
            if (directory != null) filename = Path.Combine(directory, "explorer.exe");

            if (filename != null)
            {
                Process appli = new Process
                {

                    StartInfo =
                    {
                        FileName = filename,
                        UseShellExecute = true,
                        RedirectStandardOutput = false
                    }
                };
                appli.Start();

                SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
            }
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

        private void btnPayPal_Click(object sender, EventArgs e)
        {
            Donation paypal = new Donation();

            paypal.Donatebutton();
        }
    }
}
