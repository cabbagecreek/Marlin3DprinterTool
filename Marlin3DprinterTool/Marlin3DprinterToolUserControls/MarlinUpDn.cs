using System;
using System.Drawing;
using System.Windows.Forms;

namespace Marlin3DprinterToolUserControls
{
    public partial class MarlinUpDn : UserControl
    {
        #region Properties
        
        private string _controlText;
        private int _min;
        private int _max;
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


        public int Min
        {
            set
            {
                _min = value;
                numUpDnControl.Minimum = _min;
            }

            get { return _min; }
        }

        public int Max
        {
            set
            {
                _max = value;
                numUpDnControl.Maximum = _max;
            }
            get { return _max; }
        }

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



        public MarlinUpDn()
        {
            InitializeComponent();
        }


        public void UpdateText(string text)
        {
            //Control to get Text/Label 
            lblControlText.Text = text;

        }
        
        public  void UpdateStatus()
        {
            ledBulbEqualcurrentFirmware.On = true;
            if (currentFirmwareHelper != null && NewFirmwareHelper != null)
            {
                if (currentFirmwareHelper.GetFeatureValue(Feature) == null &&
                    NewFirmwareHelper.GetFeatureValue(Feature) != null)
                {
                    ledBulbEqualcurrentFirmware.Color = Color.Yellow;

                }

                else
                {


                    ledBulbEqualcurrentFirmware.Color = currentFirmwareHelper.GetFeatureValue(Feature) ==
                                                    NewFirmwareHelper.GetFeatureValue(Feature)
                        ? Color.Green
                        : Color.Red;
                }
            }
            if (NewFirmwareHelper != null)
            {
                int resultValue;
                if (int.TryParse(NewFirmwareHelper.GetFeatureValue(Feature), out resultValue))
                {
                    numUpDnControl.Value = resultValue;
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

            var result = MessageBox.Show(@"Do you want to transfer value from Current Firmware to the New Firmware?",
                @"Transfer value", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                NewFirmwareHelper.SetFeatureValue(Feature, currentFirmwareHelper.GetFeatureValue(Feature));

                
                int resultValue;
                if (int.TryParse(NewFirmwareHelper.GetFeatureValue(Feature), out resultValue))
                {
                    numUpDnControl.Value = resultValue;
                }
                UpdateStatus();
            }
        }

        public  void DataChanged()
        {
            if (NewFirmwareHelper != null)
            {
                NewFirmwareHelper.SetFeatureValue(Feature,numUpDnControl.Value.ToString()); //TODO: Kan det bli decimaltalcomma??
            }
            UpdateStatus();
            ToolTip();
        }

        private void ToolTip()
        {
            toolTipControl.SetToolTip(numUpDnControl, "Coose number for Marlin FW feature " + Feature);
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
        

        private void MarlinUpDn_Enter(object sender, System.EventArgs e)
        {
            if (HelpWebBrowser != null && !string.IsNullOrEmpty(HelpUrl) && HelpWebBrowser.Visible)
            {
                HelpWebBrowser.Url = new Uri(HelpUrl);
            }
            UpdateStatus();
        }

        private void ledBulbEqualcurrentFirmware_Click(object sender, EventArgs e)
        {
            ledBulbEqualcurrentFirmware.On = true;
            TransfercurrentFirmwareToNewFirmware();
        }

        private void MarlinUpDn_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }

        

        private void ledBulbEqualcurrentFirmware_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }

        private void numUpDnControl_ValueChanged(object sender, EventArgs e)
        {
            DataChanged();
        }
    }
}
