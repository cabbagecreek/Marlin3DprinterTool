using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoIDE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmCurrentOrNewFirmware frmCurrentOrNewFirmware = new FrmCurrentOrNewFirmware();
            frmCurrentOrNewFirmware.CurrentFirmwareDirectory =@"C:\currentFirmware\Marlin";
            frmCurrentOrNewFirmware.NewFirmwareDirectory = @"C:\NewFirmware\Marlin";
            frmCurrentOrNewFirmware.ArduinoIdeDirectory = @"C:\Program Files (x86)\Arduino";
            Application.Run(frmCurrentOrNewFirmware);
        }
    }
}
