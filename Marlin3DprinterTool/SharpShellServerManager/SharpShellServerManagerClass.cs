using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using ServerManager;
using SharpShell.Attributes;
using SharpShell.Diagnostics;
using SharpShell.ServerRegistration;


namespace SharpShellServerManager
{
    public static class SharpShellServerManagerClass
    {
        public static void InstallServer(string thumbnailFilename, bool osIs32Bit)
        {

            

            if (!string.IsNullOrEmpty(thumbnailFilename))
            {

                if (!File.Exists(thumbnailFilename)) return;

                IEnumerable<ServerEntry> serverEntries = ServerManagerApi.LoadServers(thumbnailFilename);

                foreach (ServerEntry serverEntry in serverEntries)
                {
                    SharpShell.ServerRegistration.ServerRegistrationManager.InstallServer(serverEntry.Server, osIs32Bit ? RegistrationType.OS32Bit : RegistrationType.OS64Bit, true);
                    SharpShell.ServerRegistration.ServerRegistrationManager.RegisterServer(serverEntry.Server, osIs32Bit ? RegistrationType.OS32Bit : RegistrationType.OS64Bit);
                    



                }
            }

            ExplorerManager.RestartExplorer();
            // Tell explorer the file association has been changed
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);

        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);




        public static IEnumerable<ServerEntry> UpdateServerStatus(string stlViewerThumbnail)
        {
            if (!string.IsNullOrEmpty(stlViewerThumbnail))
            {

                if (!File.Exists(stlViewerThumbnail)) return null;

                IEnumerable<ServerEntry> serverEntries = ServerManagerApi.LoadServers(stlViewerThumbnail);

                return serverEntries;
            }
            return null;
        }

        public class ServerInfo
        {
            public string ServerName { get; set; }
            public string ServerType { get; set; }
            public string ClassId { get; set; }
            public string ServerPath { get; set; }
            public string SecurityStatus { get; set; }
            public bool IsInvalid { get; set; }
            public string Association { get; set; }
            public ShellExtensionRegistrationInfo Info32 { get; set; }
            public ShellExtensionRegistrationInfo Info64 { get; set; }

        



        }


       
        

        public static ServerInfo GetServerinfo(ServerEntry serverEntry)
        {
            if (serverEntry == null) return null;


            //  Get the specified associations.
            AssociationType associationType = COMServerAssociationAttribute.GetAssociationType(serverEntry.Server.GetType());
            IEnumerable<string> associations = COMServerAssociationAttribute.GetAssociations(serverEntry.Server.GetType());

            ServerInfo serverInfo = new ServerInfo();

            serverInfo.ServerName = serverEntry.ServerName;
            serverInfo.ServerType = serverEntry.ServerType.ToString();
            serverInfo.ClassId = serverEntry.ClassId.ToString();
            serverInfo.SecurityStatus = serverEntry.GetSecurityStatus();
            serverInfo.ServerPath = serverEntry.ServerPath;
            serverInfo.IsInvalid = serverEntry.IsInvalid;
            serverInfo.Association = associationType + " " + string.Join(", ", associations);
            serverInfo.Info32 = SharpShell.ServerRegistration.ServerRegistrationManager.GetServerRegistrationInfo(serverEntry.Server.ServerClsid,RegistrationType.OS32Bit);
            serverInfo.Info64 = SharpShell.ServerRegistration.ServerRegistrationManager.GetServerRegistrationInfo(serverEntry.Server.ServerClsid,RegistrationType.OS64Bit);

            return serverInfo;
        }

        public static void Unregister(string stlViewerThumbnail, bool osIs32Bit)
        {
            if (!string.IsNullOrEmpty(stlViewerThumbnail))
            {

                if (!File.Exists(stlViewerThumbnail)) return;

                IEnumerable<ServerEntry> serverEntries = ServerManagerApi.LoadServers(stlViewerThumbnail);

                foreach (ServerEntry serverEntry in serverEntries)
                {
                    SharpShell.ServerRegistration.ServerRegistrationManager.UnregisterServer(serverEntry.Server,osIs32Bit ? RegistrationType.OS32Bit : RegistrationType.OS64Bit);
                    SharpShell.ServerRegistration.ServerRegistrationManager.UninstallServer(serverEntry.Server,osIs32Bit ? RegistrationType.OS32Bit : RegistrationType.OS64Bit);
                }
            }


            // Restert File Explorer
            ExplorerManager.RestartExplorer();
            // Tell explorer the file association has been changed
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        public static void RestartExplorer()
        {
            ExplorerManager.RestartExplorer();
        }

        public static void ResetAndCleanExistingThumbnails()
        {
            RunCmd("cmd.exe", "/C ie4uinit.exe -ClearIconCache");
            RunCmd(@"cmd.exe", @"/C taskkill /f /im explorer.exe");
            Thread.Sleep(2000);
            RunCmd("cmd.exe", $@"/C DEL /F /S /Q /A {Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Microsoft\Windows\Explorer\thumbcache_*.db"
                );
            Thread.Sleep(2000);
            RunCmd("cmd.exe", "/C ie4uinit.exe -ClearIconCache");

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


        private static void RunCmd(string command, string argument)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            startInfo.FileName = command;
            startInfo.Arguments = argument;
            process.StartInfo = startInfo;

            process.Start();
            process.WaitForExit(5000);

        }



    }
}
