using System;
using System.Drawing;
using System.Windows.Forms;

namespace Marlin3DprinterToolUserControls
{
    public partial class MarlinEnableValue : UserControl
    {
        #region Properties
        
        private string _controlText;
        private int _spliterDistance;
        

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

        public int SpliterDistance
        {
            set
            {
                _spliterDistance = value;
                splitContainer1.SplitterDistance = _spliterDistance;
            }
            get
            {
                _spliterDistance = splitContainer1.SplitterDistance;
                return _spliterDistance;
            }
        }


        public string Feature { set; get; }

        #endregion



        public MarlinEnableValue()
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

            EnabledValue newEnabledValue = new EnabledValue();
            EnabledValue oldEnabledValue = new EnabledValue();

            ledBulbEqualcurrentFirmware.On = true;
            if (currentFirmwareHelper != null && NewFirmwareHelper != null)
            {
                newEnabledValue = NewFirmwareHelper.GetEnableValue(Feature);
                oldEnabledValue = currentFirmwareHelper.GetEnableValue(Feature);

                if (oldEnabledValue.Value == null && newEnabledValue.Value != null)
                {
                    ledBulbEqualcurrentFirmware.Color = Color.Yellow;
                }
                else
                {
                    ledBulbEqualcurrentFirmware.Color = (oldEnabledValue.Enabled == newEnabledValue.Enabled && oldEnabledValue.Value == newEnabledValue.Value)
                        ? Color.Green
                        : Color.Red;
                }
            }
            if (NewFirmwareHelper != null)
            {
                chkBxProperty.Checked = newEnabledValue.Enabled;
                txtBxValue.Text = newEnabledValue.Value;
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
                bool oldChecked;
                try
                {
                    oldChecked = Convert.ToBoolean(currentFirmwareHelper.GetEnabledFeature(Feature));
                }
                catch (Exception e)
                {
                    oldChecked = false;
                }
                NewFirmwareHelper.SetEnableValue(Feature, oldChecked, currentFirmwareHelper.GetFeatureValue(Feature));
                UpdateStatus();
            }
        }

        public  void DataChanged()
        {
            NewFirmwareHelper.SetEnableValue(Feature, chkBxProperty.Checked, txtBxValue.Text);
            UpdateStatus();
            ToolTip();
        }

        private void ToolTip()
        {
            toolTipControl.SetToolTip(chkBxProperty, "Activate and deactivate Marlin FW feature " + Feature);
            toolTipControl.SetToolTip(txtBxValue, "Enter value for Marlin FW feature " + Feature);

            switch (ledBulbEqualcurrentFirmware.Color.ToKnownColor().ToString())
            {
                case @"Red":
                    toolTipControl.SetToolTip(ledBulbEqualcurrentFirmware, $"Old FW feature {Feature} is different!" + Environment.NewLine +
                          @"Value in current Firmware is " + currentFirmwareHelper.GetFeatureValue(Feature));
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
            
        }

        private void MarlinEnableValue_Enter(object sender, System.EventArgs e)
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

        private void MarlinEnableValue_MouseHover(object sender, EventArgs e)
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

        private void txtBxValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxValue_Leave(object sender, EventArgs e)
        {
            DataChanged();
        }

        private void chkBxProperty_Leave(object sender, EventArgs e)
        {
            DataChanged();
        }
    }
}
