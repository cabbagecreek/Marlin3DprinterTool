using System.Diagnostics;

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

            Process.Start("IEXPLORE", url);



        }
    }
}
