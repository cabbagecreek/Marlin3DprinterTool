using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Marlin3DprinterToolConfiguration;

namespace ArduinoIDE
{
    public partial class FrmCurrentOrNewFirmware : Form
    {
        public string CurrentFirmwareDirectory { get; set; }

    
        public string NewFirmwareDirectory { get; set; }


        public string ArduinoIdeDirectory { get; set; }
        public FrmCurrentOrNewFirmware()
        {
            InitializeComponent();
        }

        private void btnCurrentFirmware_Click(object sender, EventArgs e)
        {
            

            FrmArduinoIde frmArduinoIde = new FrmArduinoIde();
            frmArduinoIde.FirmwareDirectory = CurrentFirmwareDirectory;
            frmArduinoIde.ArduinoIdeDirectory = ArduinoIdeDirectory;

            frmArduinoIde.ShowDialog();

        }


        private void FrmCurrentOrNewFirmware_Load(object sender, EventArgs e)
        {
            grpBxCurrentFirmware.Text = Path.Combine(CurrentFirmwareDirectory, "marlin.ino");
            grpBxNewFirmware.Text = Path.Combine(NewFirmwareDirectory, "malin.ino");

            marlinFirmwareCurrent.FirmwareDirectory = CurrentFirmwareDirectory;
            marlinFirmwareCurrent.UpdateFirmwareInfo();
            marlinFirmwareNew.FirmwareDirectory = NewFirmwareDirectory;
            marlinFirmwareNew.UpdateFirmwareInfo();

            marlinFirmwareCurrent.CompareWithFile(marlinFirmwareNew.Firmware);
            marlinFirmwareNew.CompareWithFile(marlinFirmwareCurrent.Firmware);


        }

        private void btnNewFirmware_Click(object sender, EventArgs e)
        {
            FrmArduinoIde frmArduinoIde = new FrmArduinoIde();
            frmArduinoIde.FirmwareDirectory = NewFirmwareDirectory;
            frmArduinoIde.ArduinoIdeDirectory = ArduinoIdeDirectory;

            frmArduinoIde.ShowDialog();
        }
    }
}
