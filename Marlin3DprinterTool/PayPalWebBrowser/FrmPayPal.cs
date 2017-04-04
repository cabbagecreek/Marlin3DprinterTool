using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PayPalWebBrowser
{
    public partial class FrmPayPal : Form
    {
        public FrmPayPal()
        {
            InitializeComponent();
            const string url = "https://www.paypal.com/cgi-bin/webscr" +
                               @"?cmd=" + "_donations" +
                               @"&business=" + "cabbagecreek@gmail.com" +
                               @"&lc=" + "US" +
                               @"&item_name=" + "Marlin 3D printer Tool Donation" +
                               @"&notify_url=" + @"http://marlin3dprintertool.se/PayPal/PayPalIPN.php" +
                               @" & amount=5" +
                               @"&currency_code=" + "USD" +
                               @"&bn=" + "PP%2dDonationsBF";

            
            CefSettings settings = new CefSettings();
            if (!Cef.IsInitialized) Cef.Initialize(settings);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser(url);
            Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }
    }
}
