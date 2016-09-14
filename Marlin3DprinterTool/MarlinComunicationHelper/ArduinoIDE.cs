using System.Diagnostics;
using System.IO;

namespace MarlinComunicationHelper
{
    public class ArduinoIDE
    {
        public string FirmwareDirectory { private get; set; }

        public string ArduinoDirectory { private get; set; }


        public void OpenArduinoWithMarlin()
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
    }
}