using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MarlinComunicationHelper
{
    /// <summary>
    /// User Control that shows a Marlin GCODE kompass for navigation
    /// </summary>
    public partial class KompassControll : UserControl
    {
        /// <summary>
        /// Construktor
        /// </summary>
        public KompassControll()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Get and set the Comminication used for the MarlinCommunicationHelper
        /// </summary>
        public MarlinCommunication MarlinCommunication { get; set; }

        /// <summary>
        /// Bool if current position should be sent after each movement
        /// </summary>
        public bool SendCurrentPosition { get; set; }


        private void MoveAxis(string stepperMotor, double amount)
        {
            var commands = new List<string>();
            var value = amount.ToString().Replace(",", "."); //Allways decimalpoint

            commands.Add("G91");
            commands.Add($"G1 {stepperMotor}{value}");
            commands.Add("G90");
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
    }
}