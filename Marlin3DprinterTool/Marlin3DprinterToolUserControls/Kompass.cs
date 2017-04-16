using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MarlinComunicationHelper;

namespace Marlin3DprinterToolUserControls
{
    public partial class Kompass : UserControl
    {
        private MarlinCommunication _marlinCommunication;

        /// <summary>
        /// Construktor
        /// </summary>
        public Kompass()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Get and set the Comminication used for the MarlinCommunicationHelper
        /// </summary>
        public MarlinCommunication MarlinCommunication
        {
            get { return _marlinCommunication; }
            set
            {
                _marlinCommunication = value;
                if (_marlinCommunication != null)
                {
                    _marlinCommunication.M114GetCurrentPosition += _marlinCommunication_M114GetCurrentPosition;
                }
            }
        }

        private void _marlinCommunication_M114GetCurrentPosition(object sender, CurrentPosition e)
        {
            DelegateText(txtBxX, MarlinCommunication.CurrentPosition.Xstring);
            DelegateText(txtBxY, MarlinCommunication.CurrentPosition.Ystring);
            DelegateText(txtBxZ, MarlinCommunication.CurrentPosition.Zstring);
        }

        /// <summary>
        /// Bool if current position should be sent after each movement
        /// </summary>
        public bool SendCurrentPosition { get; set; }


        private void MoveAxis(string stepperMotor, double amount)
        {
            var commands = new List<string>();
            var value = amount.ToString().Replace(",", "."); //Allways decimalpoint

            commands.Add(@"G91");
            commands.Add($"G1 {stepperMotor}{value}");
            commands.Add(@"G90");
            if (SendCurrentPosition) commands.Add("M114");
            MarlinCommunication.SendCommand(commands);
        }

        private void btnPlusY100_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", 100);
        }

        private void btnPlusY10_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", 10);
        }

        private void btnPlusY1_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", 1);
        }

        private void btnPlusY01_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", 0.1);
        }

        private void btnMinusY01_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", -0.1);
        }

        private void btnMinusY1_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", -1);
        }

        private void btnMinusY10_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", -10);
        }

        private void btnMinusY1100_Click(object sender, EventArgs e)
        {
            MoveAxis("Y", -100);
        }

        private void btnMinusX100_Click(object sender, EventArgs e)
        {
            MoveAxis("X", -100);
        }

        private void btnMinusX10_Click(object sender, EventArgs e)
        {
            MoveAxis("X", -10);
        }

        private void btnMinusX1_Click(object sender, EventArgs e)
        {
            MoveAxis("X", -1);
        }

        private void btnMinusX01_Click(object sender, EventArgs e)
        {
            MoveAxis("X", -0.1);
        }

        private void btnPlusX01_Click(object sender, EventArgs e)
        {
            MoveAxis("X", 0.1);
        }

        private void btnPlusX1_Click(object sender, EventArgs e)
        {
            MoveAxis("X", 1);
        }

        private void btnPlusX10_Click(object sender, EventArgs e)
        {
            MoveAxis("X", 10);
        }

        private void btnPlusX100_Click(object sender, EventArgs e)
        {
            MoveAxis("X", 100);
        }


        private delegate void DelegateTextCallback(Control control, string text);
        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="text"></param>
        public void DelegateText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                DelegateTextCallback d = DelegateText;
                Invoke(d, control, text);
            }
            else
            {
                control.Text = text;
            }
        }
    }
}
