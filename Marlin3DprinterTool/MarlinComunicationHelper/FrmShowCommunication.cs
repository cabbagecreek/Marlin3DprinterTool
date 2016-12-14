using System;
using System.Drawing;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MarlinComunicationHelper
{
    /// <summary>
    /// Frame that shows the communication To and From the Marlin FW
    /// Possible to Send commands and se the responce
    /// </summary>
    public partial class FrmShowCommunication : Form
    {
        private static FrmShowCommunication _instanceOfFrmShowForm;


        /// <summary>
        /// The communication that is setup in the calling program
        /// This is the communication that is monitored
        /// </summary>
        public MarlinCommunication Communication { get; set; }

        private FrmShowCommunication()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Create Singleton for this window
        /// </summary>
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



        /// <summary>
        /// Add a row with Received data from Marlin FW
        /// </summary>
        public string AddReceived
        {
            get { return fctbMarlinCommunication.Text; }
            set
            {
                string text = value;
                if (chkBxRemoveProcessing.Checked)
                {
                    text = text.Replace("busy: processing", "");
                    text = text.Replace("echo:", "");
                    text = text.Replace("  ", "");
                    
                }
                if ((string.IsNullOrEmpty(text)) || (string.IsNullOrEmpty(text.Replace("\n","")))) return;

                MarlinSyntaxTextBox(fctbMarlinCommunication, "Receive " + text + Environment.NewLine);
                
            }
        }

        /// <summary>
        /// Add command thats been sent
        /// </summary>
        public string AddSend
        {
            get { return fctbMarlinCommunication.Text; }
            set
            {
                MarlinSyntaxTextBox(fctbMarlinCommunication, "Send " + value + Environment.NewLine);


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

                if (marlinSyntaxTextBox.Lines.Count >= 10)
                {
                    marlinSyntaxTextBox.Navigate(marlinSyntaxTextBox.Lines.Count - 10);
                }
                
            }



            

        }


        private void btnClearResponces_Click(object sender, EventArgs e)
        {
            fctbMarlinCommunication.Clear();
            fctbMarlinCommunication.Text = @"Cleared";
        }

        private void chkBxNeverClear_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.NeverClear = chkBxNeverClear.Checked;
        }


        private void btnCopyToClipBoard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fctbMarlinCommunication.Text))
            {
                MessageBox.Show(@"There is nothing to copy to Clipboard!");
                return;
            }
            Clipboard.SetText(fctbMarlinCommunication.Text);
        }

        private void FrmShowForm_Load(object sender, EventArgs e)
        {
            PopulateGui();
            fctbMarlinCommunication.DescriptionFile = "MarlinCommunication.xml";
            
            
          
            
        }

       

        private delegate void MarlinSyntaxTextBoxCallback(FastColoredTextBox marlinSyntaxTextBox, string text);

        private void btnSend_Click(object sender, EventArgs e)
        {
            Communication.SendCommand(cmbBxCommand.Text);
            
            // Add command to commandlist
            if (cmbBxCommand.Items.Contains(cmbBxCommand.Text)) return;
            cmbBxCommand.Items.Add(cmbBxCommand.Text);
        }
    }
}