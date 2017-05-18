
using System.Windows.Forms;

namespace MarlinConfigurator
{
    public partial class MarlinControl : UserControl,IMarlinControl
    {
        public static FirmwareHelper OldFirmwareHelper;

        public static FirmwareHelper NewFirmwareHelper;
        //private string _checkBoxText;
        private string _feature;
        private static string _oldFilename;
        private static string _newFilename;

        public string OldFilename
        {
            set
            {
                _oldFilename = value;
                OldFirmwareHelper = new FirmwareHelper { FileName = OldFilename };
            }
            get { return _oldFilename; }
        }

        public string NewFilename
        {
            set
            {
                _newFilename = value;
                NewFirmwareHelper = new FirmwareHelper { FileName = NewFilename };
            }
            get { return _newFilename; }
        }

        //public override string Text
        //{
        //    set
        //    {
        //        _checkBoxText = value;
        //        chkBxProperty.Text = _checkBoxText;
        //    }
        //    get { return _checkBoxText; }
        //}

        public WebBrowser HelpWebBrowser { set; get; }

        public string HelpUrl { set; get; }

       


        public string Feature
        {
            set
            {
                _feature = value;

            }
            get { return _feature; }
        }



        public MarlinControl()
        {
            InitializeComponent();
        }

        private void MarlinControl_Load(object sender, System.EventArgs e)
        {
            ControlLoad();
        }

        public void ControlLoad()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateStatus()
        {
            throw new System.NotImplementedException();
        }

        public void TransferOldFirmwareToNewFirmware()
        {
            throw new System.NotImplementedException();
        }

        public void DataChanged()
        {
            throw new System.NotImplementedException();
        }
    }
}
