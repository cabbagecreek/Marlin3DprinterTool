using System.Diagnostics;
using System.IO;
using System.Net.Mime;
using Microsoft.Win32;

namespace PayPal
{
    public class Donation
    {
        public void Donatebutton()
        {
            

            string paypalBrowser = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            paypalBrowser = Path.Combine(paypalBrowser, @"PayPalWebBrowser.exe");

            Process paypal = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = paypalBrowser;
            paypal.StartInfo = startInfo;

            paypal.Start();
            paypal.WaitForExit(1000 * 3 * 60); // 3 minutes wait


        }


    }
}
