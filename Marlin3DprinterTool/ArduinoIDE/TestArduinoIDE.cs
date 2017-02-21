using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoIDE
{
    public partial class TestArduinoIDE : Form
    {
        public TestArduinoIDE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmArduinoIde frmArduinoIde = new FrmArduinoIde();
            frmArduinoIde.FirmwareDirectory = "C:\\Users\\Johnnyboy\\Desktop\\Utveckling\\Marlin\\BIG BOX\\Marlin-- Marlin 1.1.0-RC8\\Marlin";
            frmArduinoIde.ArduinoIdeDirectory = "C:\\Program Files (x86)\\Arduino";


            frmArduinoIde.ShowDialog();
        }
    }
}
