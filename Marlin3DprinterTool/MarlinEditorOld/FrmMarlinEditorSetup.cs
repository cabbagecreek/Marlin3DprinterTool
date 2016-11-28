using System;
using System.IO;
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
            configuration.CurrentFirmware = CheckIfDirectoryContainsMarlin( txtBxDirectoryCurrentFirmware.Text);
            configuration.NewFirmware = CheckIfDirectoryContainsMarlin( txtBxDirectoryNewFirmware.Text );
            configuration.ArduinoIde = CheckIfDirectoryContainsArduino( txtBxArduinoIDE.Text );
            Close();
        }

        private void btnDirectoryCurrentFirmware_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog currentFirmwareBrowserDialog = new FolderBrowserDialog();
            currentFirmwareBrowserDialog.SelectedPath = configuration.CurrentFirmware;
            currentFirmwareBrowserDialog.Description = @"Directory to current Firmware";
            DialogResult result = currentFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                txtBxDirectoryCurrentFirmware.Text = CheckIfDirectoryContainsMarlin(currentFirmwareBrowserDialog.SelectedPath );
            }

        }

        private string CheckIfDirectoryContainsMarlin(string directory)
        {
            bool marlinIsFound = false;
            bool configIsFound = false;

            if (string.IsNullOrEmpty(directory))  return "";
            
            string[] allFilesInDirectory = Directory.GetFiles(directory);
            foreach (string file in allFilesInDirectory)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Name.ToLower() == @"marlin.ino")
                {
                    marlinIsFound = true;
                }
                if (fileInfo.Name.ToLower() == @"configuration.h")
                {
                    configIsFound = true;
                }
            }
            

            if (marlinIsFound && configIsFound) return directory;

            string messagestring = $"The {directory} does not look like a directory containing Marlin Firmware!";
            messagestring += Environment.NewLine;
            if (marlinIsFound) messagestring += "Marlin.ino is found."; else messagestring += "Marlin.ino is NOT found!";
            messagestring += Environment.NewLine;
            if (configIsFound) messagestring += "Configuration.h is found."; else messagestring += "Configuration.h is NOT found!";
            messagestring += Environment.NewLine;
            messagestring += Environment.NewLine;
            messagestring += "Choose a directory that contains Marlin Firmware";

            MessageBox.Show(messagestring, @"Invalid Marlin Firmware directory", MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            return "";
        }

        private string CheckIfDirectoryContainsArduino(string directory)
        {
            bool arduinoExeIsFound = false;

            if (string.IsNullOrEmpty(directory)) return "";
            string[] allFilesInDirectory = Directory.GetFiles(directory);
            foreach (string file in allFilesInDirectory)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Name.ToLower() == "arduino.exe")
                {
                    arduinoExeIsFound = true;
                }
                
            }

            if (arduinoExeIsFound ) return directory;

            string messagestring = $"The {directory} does not look like a directory containing Arduino IDE!";
            messagestring += Environment.NewLine;
            messagestring += "Arduino.exe is NOT found!";
            messagestring += Environment.NewLine;
            messagestring += Environment.NewLine;
            messagestring += "Choose a directory that contains Arduino IDE";

            MessageBox.Show(messagestring, @"Invalid Arduino IDE directory", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return "";
        }

        private void btnDirectoryNewFirmware_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog newFirmwareBrowserDialog = new FolderBrowserDialog();
            newFirmwareBrowserDialog.SelectedPath = configuration.NewFirmware;
            newFirmwareBrowserDialog.Description = @"Directory to new Firmware";
            DialogResult result = newFirmwareBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBxDirectoryNewFirmware.Text = CheckIfDirectoryContainsMarlin( newFirmwareBrowserDialog.SelectedPath);
            }
        }

        private void btnArduinoIDE_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            FolderBrowserDialog arduinoIdeBrowserDialog = new FolderBrowserDialog();
            arduinoIdeBrowserDialog.SelectedPath = configuration.ArduinoIde;
            arduinoIdeBrowserDialog.Description = @"Directory to Arduino IDE";
            DialogResult result = arduinoIdeBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBxArduinoIDE.Text = CheckIfDirectoryContainsArduino( arduinoIdeBrowserDialog.SelectedPath);
            }

        }

        private void FrmMarlinEditorSetup_Load(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration();
            txtBxDirectoryCurrentFirmware.Text = configuration.CurrentFirmware;
            txtBxDirectoryNewFirmware.Text = configuration.NewFirmware;
            txtBxArduinoIDE.Text = configuration.ArduinoIde;
        }

        private void txtBxDirectoryCurrentFirmware_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
