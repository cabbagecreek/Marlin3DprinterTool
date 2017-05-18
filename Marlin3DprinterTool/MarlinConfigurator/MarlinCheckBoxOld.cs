using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarlinConfigurator
{


    public partial class MarlinCheckBoxOld : UserControl
    {

        private static FirmwareHelper _oldFirmwareHelper;
        private static FirmwareHelper _newFirmwareHelper; 
        private string _checkBoxText;
        private string _feature;
        private static string _oldFilename;
        private static string _newFilename;

        public string OldFilename
        {
            set
            {
                _oldFilename = value;
                _oldFirmwareHelper = new FirmwareHelper { FileName = OldFilename };
            }
            get { return _oldFilename; }
        }

        public string NewFilename
        {
            set
            {
                _newFilename = value;
                _newFirmwareHelper = new FirmwareHelper { FileName = NewFilename };
            }
            get { return _newFilename; }
        }

        public  override string Text
        {
            set
            {
                _checkBoxText = value;
                chkBxProperty.Text = _checkBoxText;
            }
            get { return _checkBoxText; }
        }

        public  WebBrowser HelpWebBrowser { set; get; }

        public string HelpUrl { set; get; }

        public MarlinCheckBoxOld()
        {
            InitializeComponent();
        }


        public string Feature
        {
            set
            {
                _feature = value;
                
            }
            get { return _feature; }
        }

        private void MarlinCheckBox_Enter(object sender, System.EventArgs e)
        {
            toolTipCheckBox.SetToolTip(chkBxProperty, "Activate and deactivate Marlin FW feature " + _feature);
            if (ledBulbEqualOldFirmware.Color == Color.Red)
            {
                toolTipCheckBox.SetToolTip(ledBulbEqualOldFirmware, $"Old FW feature {_feature} is different!");
            }
            else
            {
                toolTipCheckBox.SetToolTip(ledBulbEqualOldFirmware, $"New and Old FW feature {_feature} is equal.");
            }


            if (HelpWebBrowser != null && !string.IsNullOrEmpty(HelpUrl))
            {
                HelpWebBrowser.Url = new Uri(HelpUrl);
            }
        }

        public void UpdateStatus()
        {
            

            ledBulbEqualOldFirmware.Color = _oldFirmwareHelper.GetDefineTrueFalse(Feature) == _newFirmwareHelper.GetDefineTrueFalse(Feature) ? Color.Green : Color.Red;
        }

        private void chkBxProperty_CheckedChanged(object sender, EventArgs e)
        {
            
            _newFirmwareHelper.EnableFeatureValue(Feature, chkBxProperty.Checked);
            UpdateStatus();
        }

        private void MarlinCheckBox_Load(object sender, EventArgs e)
        {
            chkBxProperty.Checked = _newFirmwareHelper.GetDefineTrueFalse(Feature);
        }

        private void ledBulbEqualOldFirmware_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Do you want to transfer value from Old Firmware to the New Firmware?",
                @"Transfer value", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                _newFirmwareHelper.EnableFeatureValue(Feature, _oldFirmwareHelper.GetDefineTrueFalse(Feature));
                chkBxProperty.Checked = _newFirmwareHelper.GetDefineTrueFalse(Feature);
                UpdateStatus();
            }
        }
    }
}
