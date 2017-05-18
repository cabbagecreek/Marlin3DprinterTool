using System;
using System.Drawing;
using System.Windows.Forms;

namespace Marlin3DprinterToolUserControls
{
    public partial class MarlinCheckBox : UserControl
    {
        #region Properties
        
        private string _controlText;
        

        public FirmwareHelper currentFirmwareHelper { get; set; }
        public FirmwareHelper NewFirmwareHelper { get; set; }


        public string ControlText
        {
            set
            {
                _controlText = value;
                UpdateText(_controlText);
                
            }
            get { return _controlText; }
        }

        public WebBrowser HelpWebBrowser { set; get; }

        public string HelpUrl { set; get; }




        public string Feature { set; get; }

        #endregion



        public MarlinCheckBox()
        {
            InitializeComponent();
        }




        public void UpdateText(string text)
        {
            //Control to get Text/Label 
            chkBxProperty.Text = text;
        }
        
        public  void UpdateStatus()
        {
            ledBulbEqualcurrentFirmware.On = true;
            if (currentFirmwareHelper != null && NewFirmwareHelper != null)
            {

                if (currentFirmwareHelper.GetFeatureValue(Feature) == null && NewFirmwareHelper.GetFeatureValue(Feature) != null)
                {
                    ledBulbEqualcurrentFirmware.Color = Color.Yellow;

                }
                else
                {
                    ledBulbEqualcurrentFirmware.Color = currentFirmwareHelper.GetEnabledFeature(Feature) == NewFirmwareHelper.GetEnabledFeature(Feature)
                        ? Color.Green
                        : Color.Red;
                }
            }
            if (NewFirmwareHelper != null)
            {
                try
                {
                    chkBxProperty.Checked = Convert.ToBoolean(NewFirmwareHelper.GetEnabledFeature(Feature));
                }
                catch (Exception e)
                {
                    chkBxProperty.Checked = false;
                }
                
            }
        }

        public  void TransfercurrentFirmwareToNewFirmware()
        {
            if (currentFirmwareHelper.GetFeatureValue(Feature) == null && NewFirmwareHelper.GetFeatureValue(Feature) != null)
            {
                MessageBox.Show(@"The feature " + Feature + @" is not available in the old Marlin Firmware." +
                                Environment.NewLine +
                                @"This might be a new feature." + Environment.NewLine +
                                @"Read the documentation and set this value manually.", @"New feature",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(@"Do you want to transfer value from Current Firmware to the New Firmware?",
                @"Transfer value", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                bool oldvalue;
                try
                {
                    oldvalue = Convert.ToBoolean(currentFirmwareHelper.GetEnabledFeature(Feature));
                }
                catch (Exception e)
                {
                    oldvalue = false;
                }
                
                NewFirmwareHelper.SetEnabledFeature(Feature,  oldvalue);
                chkBxProperty.Checked = oldvalue;
                UpdateStatus();
            }
        }

        public  void DataChanged()
        {
            NewFirmwareHelper?.SetEnabledFeature(Feature, chkBxProperty.Checked);

            UpdateStatus();
            ToolTip();
        }

        private void ToolTip()
        {
            toolTipControl.SetToolTip(chkBxProperty, "Activate and deactivate Marlin FW feature " + Feature);
            switch (ledBulbEqualcurrentFirmware.Color.ToKnownColor().ToString())
            {
                case @"Red":
                    toolTipControl.SetToolTip(ledBulbEqualcurrentFirmware, $"Old FW feature {Feature} is different!" +Environment.NewLine +
                        @"Value in current Firmware is " + currentFirmwareHelper.GetEnabledFeature(Feature));
                    break;
                case @"Green":
                    toolTipControl.SetToolTip(ledBulbEqualcurrentFirmware, $"New and Old FW feature {Feature} is equal.");
                    break;
                case @"Yellow":
                    toolTipControl.SetToolTip(ledBulbEqualcurrentFirmware, $"Feature {Feature} is not available in Old Marlin Firmware.");
                    break;


            }


            if (HelpWebBrowser != null && !string.IsNullOrEmpty(HelpUrl) && HelpWebBrowser.Visible)
            {
                HelpWebBrowser.Url = new Uri(HelpUrl);
            }
        }



        //=====================================================================================================
        //
        // Events
        //
        //=====================================================================================================
        private void chkBxProperty_CheckedChanged(object sender, System.EventArgs e)
        {
            DataChanged();
        }

        private void MarlinCheckBox_Enter(object sender, System.EventArgs e)
        {
            if (HelpWebBrowser != null && !string.IsNullOrEmpty(HelpUrl) && HelpWebBrowser.Visible)
            {
                HelpWebBrowser.Url = new Uri(HelpUrl);
            }
            UpdateStatus();
        }

        private void ledBulbEqualcurrentFirmware_Click(object sender, EventArgs e)
        {
            TransfercurrentFirmwareToNewFirmware();
        }

        private void MarlinCheckBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }

        private void chkBxProperty_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }

        private void ledBulbEqualcurrentFirmware_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }

        
    }
}
