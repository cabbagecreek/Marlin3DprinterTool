using System;
using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MarlinComunicationHelper
{
    public partial class FrmShowCommunication : Form
    {
        private static FrmShowCommunication _instanceOfFrmShowForm;

        private FrmShowCommunication()
        {
            InitializeComponent();
        }

        public static FrmShowCommunication InstanceFrmShowForm
        {
            get
            {
                if (_instanceOfFrmShowForm == null || _instanceOfFrmShowForm.IsDisposed)
                {
                    _instanceOfFrmShowForm = new FrmShowCommunication();
                }
                return _instanceOfFrmShowForm;
            }
        }


        public string AddReceived
        {
            get { return fastColoredTextMarlinCommunication.Text; }
            set
            {
                MarlinSyntaxTextBox(fastColoredTextMarlinCommunication, "Receive " + value + Environment.NewLine);
                
            }
        }


        public string AddSend
        {
            get { return fastColoredTextMarlinCommunication.Text; }
            set
            {
                MarlinSyntaxTextBox(fastColoredTextMarlinCommunication, "Send " + value + Environment.NewLine);
            }
        }

        private void PopulateGui()
        {
            chkBxNeverClear.Checked = Configuration.NeverClear;
        }

        private void MarlinSyntaxTextBox(FastColoredTextBox marlinSyntaxTextBox, string text)
        {
            if (marlinSyntaxTextBox.InvokeRequired)
            {
                MarlinSyntaxTextBoxCallback d = MarlinSyntaxTextBox;
                Invoke(d, marlinSyntaxTextBox, text);
            }
            else
            {
                if (chkBxNeverClear.Checked) marlinSyntaxTextBox.Text += text;
                else marlinSyntaxTextBox.Text = text;
            }
        }


        private void btnClearResponces_Click(object sender, EventArgs e)
        {
            fastColoredTextMarlinCommunication.Clear();
            fastColoredTextMarlinCommunication.Text = @"Cleared";
        }

        private void chkBxNeverClear_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.NeverClear = chkBxNeverClear.Checked;
        }


        private void btnCopyToClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fastColoredTextMarlinCommunication.Text);
        }

        private void FrmShowForm_Load(object sender, EventArgs e)
        {
            PopulateGui();
            fastColoredTextMarlinCommunication.DescriptionFile = "MarlinCommunication.xml";

            
          
            
        }

       

        private delegate void MarlinSyntaxTextBoxCallback(FastColoredTextBox marlinSyntaxTextBox, string text);
    }
}