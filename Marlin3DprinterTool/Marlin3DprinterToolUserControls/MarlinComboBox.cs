using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Marlin3DprinterToolUserControls
{
    public partial class MarlinComboBox : UserControl
    {
        #region Properties
        
        private string _controlText;
        private int _spliterDistance;
        private bool _isTrueFalse;


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


        public bool IsTrueFalse
        {
            set
            {
                _isTrueFalse = value;
                if (_isTrueFalse)
                {
                    cmbBxControl.Items.Clear();
                    cmbBxControl.Items.Add(new ComboboxItem { Value = "true",  Text = "True"});
                    cmbBxControl.Items.Add(new ComboboxItem { Value = "false", Text = "False" });
                }
            }
            get { return _isTrueFalse; }
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



        public MarlinComboBox()
        {
            InitializeComponent();
        }



        public void Clear()
        {
            cmbBxControl.Items.Clear();
        }


       

        public void UpdateText(string text)
        {
            //Control to get Text/Label 
            lblControlText.Text = _controlText;

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
                else if (NewFirmwareHelper.GetFeatureValue(Feature) == null)
                {
                    ledBulbEqualcurrentFirmware.Color = Color.Blue;
                    this.Enabled = false;
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
                string currentvalue = NewFirmwareHelper.GetFeatureValue(Feature);
                foreach (object item in cmbBxControl.Items)
                {
                    ComboboxItem temp = (ComboboxItem) item;
                    if ((string) temp.Value == currentvalue || temp.Text == currentvalue)
                    {
                        cmbBxControl.Text = temp.Text;
                        break;
                    }
                   

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
                Migrate();
                
            }
        }


        public void Migrate()
        {
            if (ledBulbEqualcurrentFirmware.Color == Color.Red || ledBulbEqualcurrentFirmware.Color == Color.Green)
            {
                NewFirmwareHelper.SetFeatureValue(Feature, currentFirmwareHelper.GetFeatureValue(Feature));
                cmbBxControl.Text = NewFirmwareHelper.GetFeatureValue(Feature);
                UpdateStatus();
            }
        }

        public  void DataChanged()
        {

            ComboboxItem selectedItem = (ComboboxItem) cmbBxControl.SelectedItem;
            NewFirmwareHelper.SetFeatureValue(Feature, selectedItem.Value.ToString());
            UpdateStatus();
            ToolTip();
        }

        private void ToolTip()
        {
            toolTipControl.SetToolTip(cmbBxControl, "Choose value for " + Feature);
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
                case @"Blue":
                    toolTipControl.SetToolTip(ledBulbEqualcurrentFirmware, $"Feature {Feature} might be obsolite in new Marlin Firmware.");
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
       

        private void MarlinComboBox_Enter(object sender, System.EventArgs e)
        {
            if (HelpWebBrowser != null && !string.IsNullOrEmpty(HelpUrl) && HelpWebBrowser.Visible)
            {
                HelpWebBrowser.Url = new Uri(HelpUrl);
            }
            ToolTip();
            UpdateStatus();
        }

        private void ledBulbEqualcurrentFirmware_Click(object sender, EventArgs e)
        {
            TransfercurrentFirmwareToNewFirmware();
        }

        private void cmbBxControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataChanged();
        }



        public  void AddComboItems(ComboboxItem item)
        {
            
                    cmbBxControl.Items.Add(item);
                
        }

        public void AddComboItems(List< ComboboxItem> items)
        {

            cmbBxControl.Items.Add(items.ToArray());

        }

        private void MarlinComboBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }

        private void cmbBxControl_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }

        private void ledBulbEqualcurrentFirmware_MouseHover(object sender, EventArgs e)
        {
            ToolTip();
        }


        
    }
    
}
