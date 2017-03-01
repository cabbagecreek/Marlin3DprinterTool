using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void FrmPayPal_Load(object sender, EventArgs e)
        {

            var url = "https://www.paypal.com/cgi-bin/webscr" +
                     @"?cmd=" + "_donations" +
                     @"&business=" + "cabbagecreek@gmail.com" +
                     @"&lc=" + "US" +
                     @"&item_name=" + "Marlin 3D printer Tool Donation" +
                     @"&amount=5" +
                     @"&currency_code=" + "USD" +
                     @"&bn=" + "PP%2dDonationsBF";


            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            ChromiumWebBrowser chrome = new ChromiumWebBrowser(url);
            this.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;

        }
    }
}
