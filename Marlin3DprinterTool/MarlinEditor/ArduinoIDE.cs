using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Marlin3DprinterToolConfiguration;

namespace MarlinEditor
{
    public class ArduinoIDE
    {
        public string FirmwareDirectory { private get; set; }

        public string ArduinoDirectory { private get; set; }


        public void OpenArduinoWithMarlin()
        {

            try
            {
                // arduino --board arduino:avr:nano:cpu=atmega168 --port /dev/ttyACM0 --upload /path/to/sketch/sketch.ino
                var compileAndUpload = new Process
                {
                    StartInfo =
                    {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        WorkingDirectory = FirmwareDirectory,
                        FileName = Path.Combine(ArduinoDirectory, "arduino.exe"),
                        Arguments = " \"" + Path.Combine(FirmwareDirectory, "marlin.ino") + "\" "
                    }
                };
                compileAndUpload.Start();
                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                // p.WaitForExit();
                // Read the output stream first and then wait.
                // string output = compileAndUpload.StandardOutput.ReadToEnd();
                compileAndUpload.WaitForExit();
            }
            catch (Exception exception)
            {
                DialogResult configResult = MessageBox.Show(@"Message: " + exception.Message + Environment.NewLine + Environment.NewLine +

                                                            @"It looks some problem with finding the ArduinoIDE at " + Environment.NewLine +

                                                            Path.Combine(ArduinoDirectory, "arduino.exe") + @"." + Environment.NewLine +
                                                            Environment.NewLine +
                                                            @"Do you want to configure where to find Arduino IDE?", @"Error when calling Arduini IDE",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (configResult == DialogResult.Yes)
                {
                    Marlin3DprinterSetup setup = new Marlin3DprinterSetup();
                    setup.ShowDialog();
                }
            }
            

            
        }
    }
}