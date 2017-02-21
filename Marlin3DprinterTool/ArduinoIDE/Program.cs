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
            frmCurrentOrNewFirmware.CurrentFirmwareDirectory =@"C:\Users\Johnnyboy\Desktop\Utveckling\Marlin\BIG BOX\MarlinPipsHag\Marlin";
            frmCurrentOrNewFirmware.NewFirmwareDirectory = @"C:\Users\Johnnyboy\Desktop\Utveckling\Marlin\BIG BOX\Marlin-- Marlin 1.1.0-RC8\Marlin";
            frmCurrentOrNewFirmware.ArduinoIdeDirectory = @"C:\Program Files (x86)\Arduino";
            Application.Run(frmCurrentOrNewFirmware);
        }
    }
}
