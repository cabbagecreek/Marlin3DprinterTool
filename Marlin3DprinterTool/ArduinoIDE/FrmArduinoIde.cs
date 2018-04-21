using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Marlin3DprinterToolConfiguration;
using ZylSoft.Serial;

namespace ArduinoIDE
{
    public partial class FrmArduinoIde : Form
    {
        
        

        public string FirmwareDirectory { set; get; }

        public string ArduinoIdeDirectory { set; get; }
        //public MarlinCommunication Communication { set; get; }
        

        public FrmArduinoIde()
        {
            InitializeComponent();
        }

        private void chkBxUseLastArduinoConfig_CheckedChanged(object sender, EventArgs e)
        {
            ArduinoParameters(chkBxUseLastArduinoConfig.Checked);
        }

        private void ArduinoParameters(bool useLastArduinoConfig)
        {
            lblArduinoComport.Visible = !useLastArduinoConfig;
            cmbBxArduinoComport.Visible = !useLastArduinoConfig;
        }

        private void chkBxShowArduinoResponce_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioBnCompileAndUpload_CheckedChanged(object sender, EventArgs e)
        {

            ButtonCompileText();
        }

        private void ButtonCompileText()
        {
            if (radioBnCompileAndUpload.Checked)
            {
                btnProgram.Text = @"Compile and Upload Marlin Firmware thru Arduino IDE";
            }

            if (radioBnOnlyCompile.Checked)
            {
                btnProgram.Text = @"Only Compile Marlin Firmware thru Arduino IDE";
            }

            if (radioBnOpenArduinoIde.Checked)
            {
                btnProgram.Text = @"Open Arduini IDE with Marlin Firmware";
            }
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            

            if ( !File.Exists( Path.Combine( Configuration.GetInstance.ArduinoIde,"arduino.exe")))
            {
                DialogResult result = MessageBox.Show(@"Path to Arduino.exe is missing!" + Environment.NewLine + "Do you want to configure Arduino IDE path?","Missing path to Arduino IDE",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    Marlin3DprinterSetup setup = new Marlin3DprinterSetup();
                    setup.ShowDialog();

                }
                return;
            }


            string arguments = " ";
            if (chkBxShowArduinoResponce.Checked) { arguments += @"-v ";}
            if (radioBnOnlyCompile.Checked) { arguments += @"--verify ";}
            if (radioBnCompileAndUpload.Checked) {arguments += @"--upload ";}

            ComboboxItemTextParameter board = cmbBxArduinoBoard.SelectedItem as ComboboxItemTextParameter;
            if (board != null) arguments += board.ToParameter();


            ComboboxItemTextParameter port = cmbBxArduinoComport.SelectedItem as ComboboxItemTextParameter;
            if (port != null) arguments += port.ToParameter();
            

            if (chkBxUseLastArduinoConfig.Checked) arguments = "";

            if (radioBnOpenArduinoIde.Checked) arguments = "";
            string firmware = "";
            if (!string.IsNullOrEmpty(FirmwareDirectory))
            {
                firmware = Path.Combine(FirmwareDirectory, "marlin.ino");
                arguments += $" \"{firmware} \"";
            }


           

            string arduinoExe = "";
            arduinoExe = Path.Combine(ArduinoIdeDirectory, "arduino.exe"); // "arduino_debug.exe"
            arduinoExe = $"\"{arduinoExe}\"";


            fctbArduinoIde.Clear();


            fctbArduinoIde.Text = "";
            fctbArduinoIde.AppendText(arduinoExe);
            fctbArduinoIde.AppendText(arguments);
            fctbArduinoIde.AppendText(Environment.NewLine);

            if (radioBnOnlyCompile.Checked) { fctbArduinoIde.AppendText(@"Only compile "); }
            if (radioBnCompileAndUpload.Checked) { fctbArduinoIde.AppendText(@"Started the Compile and Upload of "); }
            if (radioBnOpenArduinoIde.Checked) { fctbArduinoIde.AppendText(@"Open Arduino IDE with "); }
            fctbArduinoIde.AppendText($"{firmware}. {Environment.NewLine} {Environment.NewLine}");


            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo();
            startinfo.FileName = arduinoExe;
            startinfo.Arguments = arguments;


            if (!radioBnOpenArduinoIde.Checked)
            {
                this.Cursor = Cursors.AppStarting;
                

                if (!radioBnOpenArduinoIde.Checked)
                {

                    
                    startinfo.RedirectStandardError = true;
                    startinfo.RedirectStandardOutput = true;
                    startinfo.UseShellExecute = false;


                    process.StartInfo = startinfo;
                    process.OutputDataReceived += Process_OutputDataReceived;
                    process.ErrorDataReceived += Process_ErrorDataReceived;




                    // the following function starts a process and returns immediately,
                    // thus allowing the form to stay responsive.


                    process.Start();
                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();

                    process.WaitForExit(180*1000); // 3 minutes
                    this.Cursor = Cursors.Default;
                    
                } 
            }
            else
            {
                process.StartInfo = startinfo;
                process.Start();
                
            }

        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            DelegateFastColoredTextBoxAppendText(fctbArduinoIde, e.Data);
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            DelegateFastColoredTextBoxAppendText(fctbArduinoIde, e.Data);
        }



        private delegate void DelegateFastColoredTextBoxAppendTextCallback(FastColoredTextBox control, string text);
        public void DelegateFastColoredTextBoxAppendText(FastColoredTextBox control, string text)
        {
            if (control.InvokeRequired)
            {
                DelegateFastColoredTextBoxAppendTextCallback d = DelegateFastColoredTextBoxAppendText;
                this.Invoke(d, control, text);
    }
            else
            {
                
                 control.AppendText(text + Environment.NewLine); 


                if (control.Lines.Count >= 10)
                {
                    control.Navigate(control.Lines.Count - 10);
                }
            }
            
        }

        private delegate void DelegateProgressbarCallback(ProgressBar control, int procent);

        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="procent"></param>
        public void DelegateProgressbar(ProgressBar control, int procent)
        {
            if (control.InvokeRequired)
            {
                DelegateProgressbarCallback d = DelegateProgressbar;
                this.Invoke(d, control, procent);
            }
            else
            {
                control.Value = Math.Min(100, procent);
            }
        }



        private void btnSetup_Click(object sender, EventArgs e)
        {
            Marlin3DprinterSetup setup = new Marlin3DprinterSetup();
            setup.ShowDialog();
        }

        private void FrmArduinoIde_Load(object sender, EventArgs e)
        {
            
            // Load the possible type of boards
            cmbBxArduinoBoard.Items.Add(new ComboboxItemTextParameter { Text = @"Use Arduino IDE", Parameter = " " });
            cmbBxArduinoBoard.Items.Add(new ComboboxItemTextParameter { Text = @"Arduino Mega 2560",Parameter = "--board arduino:avr:mega:cpu=atmega2560 "});

            cmbBxArduinoBoard.Text = @"Use Arduino IDE";

            // Load ComPort
            cmbBxArduinoComport.Items.Add(new ComboboxItemTextParameter { Text = @"Use Arduino IDE", Parameter = " " });
            try
            {
                
                var serialPorts = ZylSoft.Serial.SerialPort.GetExistingCommPortNames();


                if (serialPorts.Length == 1) cmbBxArduinoComport.Text = serialPorts[0];
                cmbBxArduinoComport.Text = Configuration.GetInstance.ComPort;

                cmbBxArduinoComport.Items.Add(new ComboboxItemTextParameter { Text = Configuration.GetInstance.ComPort, Parameter = Configuration.GetInstance.ComPort });
                foreach (var serialPort in serialPorts)
                {
                    cmbBxArduinoComport.Items.Add(new ComboboxItemTextParameter { Text = serialPort, Parameter = serialPort }); 
                }

                

            }
            catch (Exception)
            {
                cmbBxArduinoComport.Text = @"Use Arduino IDE";
            }




            


        }

        private void radioBnOpenArduinoIde_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCompileText();
        }

        private void radioBnOnlyCompile_CheckedChanged(object sender, EventArgs e)
        {
            ButtonCompileText();
        }

        private void cmbBxArduinoComport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBxArduinoBoard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    /// <summary>
    /// Combobox with Text-Value Keypair. 
    /// </summary>
    public class ComboboxItemTextParameter
    {
        /// <summary>
        /// 
        /// </summary>
        public string Text { private get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Parameter { private get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Text;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToParameter()
        {
            return Parameter;
        }
    }
}
