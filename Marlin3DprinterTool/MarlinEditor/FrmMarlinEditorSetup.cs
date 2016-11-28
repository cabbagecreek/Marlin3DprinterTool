using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarlinEditor
{
    public partial class FrmMarlinEditorSetup : Form
    {
        public FrmMarlinEditorSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            configuration.CurrentFirmware = txtBxDirectoryCurrentFirmware.Text;
            configuration.NewFirmware = txtBxDirectoryNewFirmware.Text;
            configuration.ArduinoIde = txtBxArduinoIDE.Text;
            this.Close();
        }

        private void btnDirectoryCurrentFirmware_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog currentFirmwareBrowserDialog = new FolderBrowserDialog();
            currentFirmwareBrowserDialog.SelectedPath = configuration.CurrentFirmware;
            currentFirmwareBrowserDialog.Description = @"Directory to current Firmware";
            DialogResult result = currentFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) txtBxDirectoryCurrentFirmware.Text = currentFirmwareBrowserDialog.SelectedPath;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog newFirmwareBrowserDialog = new FolderBrowserDialog();
            newFirmwareBrowserDialog.SelectedPath = configuration.NewFirmware;
            newFirmwareBrowserDialog.Description = @"Directory to new Firmware";
            DialogResult result = newFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) txtBxDirectoryNewFirmware.Text = newFirmwareBrowserDialog.SelectedPath;
        }

        private void btnArduinoIDE_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog arduinoIdeBrowserDialog = new FolderBrowserDialog();
            arduinoIdeBrowserDialog.SelectedPath = configuration.ArduinoIde;
            arduinoIdeBrowserDialog.Description = @"Directory to Arduino IDE";
            DialogResult result = arduinoIdeBrowserDialog.ShowDialog();
            if (result == DialogResult.OK) txtBxArduinoIDE.Text = arduinoIdeBrowserDialog.SelectedPath;

        }

        private void FrmMarlinEditorSetup_Load(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            txtBxDirectoryCurrentFirmware.Text = configuration.CurrentFirmware;
            txtBxDirectoryNewFirmware.Text = configuration.NewFirmware;
            txtBxArduinoIDE.Text = configuration.ArduinoIde;
        }
    }
}
