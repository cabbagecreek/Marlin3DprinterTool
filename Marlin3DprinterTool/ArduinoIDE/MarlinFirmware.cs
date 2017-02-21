using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using MarlinEditor;

namespace ArduinoIDE
{
    public partial class MarlinFirmware : UserControl
    {

        
       
        public string FirmwareDirectory { set; get; }
        public string Firmware { get; set; }


        public MarlinFirmware()
        {
            InitializeComponent();

            

        }

        public void CompareWithFile(string filename)
        {
            FileInfo compare = new FileInfo(filename);

            string firmware = "";

            if (!string.IsNullOrEmpty(FirmwareDirectory))
            {
                firmware = Path.Combine(FirmwareDirectory, "marlin.ino");
                Firmware = firmware;
            }

            FileInfo firmwareFileInfo = new FileInfo(firmware);

            newCreationTime.NewDate = firmwareFileInfo.CreationTime;
            newCreationTime.Olddate = compare.CreationTime;

            newLastAceess.NewDate = firmwareFileInfo.LastAccessTime;
            newLastAceess.Olddate = compare.LastAccessTime;

            newLastWrite.NewDate = firmwareFileInfo.LastWriteTime;
            newLastWrite.Olddate = compare.LastWriteTime;


        }

        public void UpdateFirmwareInfo()
        {
            string firmware = "";

            if (!string.IsNullOrEmpty(FirmwareDirectory))
            {
                firmware = Path.Combine(FirmwareDirectory, "marlin.ino");
                Firmware = firmware;
            }
                
            
            

            if (File.Exists(firmware))
            {
                FileInfo fileInfo = new FileInfo(firmware);


                
                checkBox1.Checked = fileInfo.IsReadOnly;
                txtBxLength.Text = $"{fileInfo.Length} bytes";
                txtBxCreationTime.Text = $"{fileInfo.CreationTime.ToShortDateString()} -- {fileInfo.CreationTime.ToShortTimeString()}";
                txtBxLastAceess.Text = $"{fileInfo.LastAccessTime.ToShortDateString()} -- {fileInfo.LastAccessTime.ToShortTimeString()}";
                txtBxLastWrite.Text = $"{fileInfo.LastWriteTime.ToShortDateString()} -- {fileInfo.LastWriteTime.ToShortTimeString()}";


            }
            else
            {
                MessageBox.Show(
                    $"Marlin firmware (marlin.ino) does not exist in directory \"{FirmwareDirectory}\".",
                    @"Marlin Firmware not found!");
                
            }

            ShowFirmwareFeatures("CUSTOM_MACHINE_NAME");
            ShowFirmwareFeatures("MOTHERBOARD");

            fastColoredTextBox1.AppendText("----------------------------------" + Environment.NewLine);
            ShowFirmwareActivation(@"MESH_BED_LEVEL");
            ShowFirmwareActivation(@"AUTO_BED_LEVELING_3POINT");
            ShowFirmwareActivation(@"AUTO_BED_LEVELING_LINEAR");
            ShowFirmwareActivation(@"AUTO_BED_LEVELING_BILINEAR");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowFirmwareFeatures(string feature)
        {

            string firmware = "";

            if (!string.IsNullOrEmpty(FirmwareDirectory))
            {
                firmware = Path.Combine(FirmwareDirectory, "configuration.h");
                Firmware = firmware;
            }

            FastColoredTextBox fctb = new FastColoredTextBox();

            fctb.OpenFile(firmware);



            fastColoredTextBox1.AppendText( MarlinMigrateHelper.GetFirmwareFeatureValue(fctb, feature)  + Environment.NewLine);
        }

        private void ShowFirmwareActivation(string feature)
        {

            string firmware = "";

            if (!string.IsNullOrEmpty(FirmwareDirectory))
            {
                firmware = Path.Combine(FirmwareDirectory, "configuration.h");
                Firmware = firmware;
            }

            FastColoredTextBox fctb = new FastColoredTextBox();

            fctb.OpenFile(firmware);

            

            if (MarlinMigrateHelper.GetFirmwareFeatureValue(fctb, feature).Contains(@"Activated feature"))
            {
                fastColoredTextBox1.AppendText(feature.Replace("_"," ") + " Activated" + Environment.NewLine);
            }

            
        }
    }
}
