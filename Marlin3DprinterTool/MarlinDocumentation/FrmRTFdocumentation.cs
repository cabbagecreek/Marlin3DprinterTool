using System.Windows.Forms;

namespace MarlinDocumentation
{
    
    public partial class FrmRTFdocumentation : Form
    {

        private string _fileName ;
        public FrmRTFdocumentation()
        {
            InitializeComponent();
        }

        public string Filename
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                richTxtBxRTFdocumentation.LoadFile(value);
                
            }
        }
    }
}
