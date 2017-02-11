using System.Diagnostics;
using Microsoft.Win32;

namespace PayPal
{
    public class Donation
    {
        public void Donatebutton()
        {
            var url = "https://www.paypal.com/cgi-bin/webscr" +
                     @"?cmd=" + "_donations" +
                     @"&business=" + "cabbagecreek@gmail.com" +
                     @"&lc=" + "US" +
                     @"&item_name=" + "Marlin 3D printer Tool Donation" +
                     @"&amount=5" +
                     @"&currency_code=" + "USD" +
                     @"&bn=" + "PP%2dDonationsBF";

            launchBrowser(url);


        }


        private void launchBrowser(string url)
        {
            string browserName = null;
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey == null)
                {
                    browserName = "iexplore.exe";
                }
                else
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().ToLower().Contains("chrome"))
                            browserName = "chrome.exe";
                        else if (progIdValue.ToString().ToLower().Contains("firefox"))
                            browserName = "firefox.exe";
                        else if (progIdValue.ToString().ToLower().Contains("safari"))
                            browserName = "safari.exe";
                        else if (progIdValue.ToString().ToLower().Contains("opera"))
                            browserName = "opera.exe";
                    }
                }
            }

            Process.Start(new ProcessStartInfo(browserName, url));
        }
    }
}
