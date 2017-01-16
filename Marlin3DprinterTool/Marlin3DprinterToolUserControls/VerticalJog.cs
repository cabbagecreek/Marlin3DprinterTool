using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarlinComunicationHelper;

namespace Marlin3DprinterToolUserControls
{
    public partial class VerticalJog : UserControl
    {
        private bool _negativeButtonFirst;

        /// <summary>
        /// Constructor
        /// </summary>
        public VerticalJog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public MarlinCommunication MarlinCommunication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool SendCurrentPosition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ZeroPositionAfterEachMove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool VisibleZero
        {
            get { return btnZero.Visible; }
            set
            {
                btnZero.Visible = value;
                btnZero.Visible = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Visible100Movement
        {
            get { return btnMinus100.Visible; }
            set
            {
                btnMinus100.Visible = value;
                btnPlus100.Visible = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Visible10Movement
        {
            get { return btnMinus10.Visible; }
            set
            {
                btnMinus10.Visible = value;
                btnPlus10.Visible = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool NegativeButtonsFirst
        {
            get { return _negativeButtonFirst; }
            set
            {
                _negativeButtonFirst = value;
                if (value)
                {
                    btnMinus100.Location = new Point(3, 17);
                    btnMinus10.Location = new Point(3, 40);
                    btnMinus1.Location = new Point(3, 63);
                    btnMinus01.Location = new Point(3, 86);
                    btnZero.Location = new Point(3, 109);
                    btnPlus01.Location = new Point(3, 132);
                    btnPlus1.Location = new Point(3, 155);
                    btnPlus10.Location = new Point(3, 178);
                    btnPlus100.Location = new Point(3, 201);
                }
                else
                {
                    btnMinus100.Location = new Point(3, 201);
                    btnMinus10.Location = new Point(3, 178);
                    btnMinus1.Location = new Point(3, 155);
                    btnMinus01.Location = new Point(3, 132);
                    btnZero.Location = new Point(3, 109);
                    btnPlus01.Location = new Point(3, 86);
                    btnPlus1.Location = new Point(3, 63);
                    btnPlus10.Location = new Point(3, 40);
                    btnPlus100.Location = new Point(3, 17);
                }
                Invalidate();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string StepperMotor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TextUnder
        {
            get { return lblUnder.Text; }
            set { lblUnder.Text = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TextOver
        {
            get { return lblOver.Text; }
            set { lblOver.Text = value; }
        }


        private void MoveAxis(double amount)
        {
            var commands = new List<string>();
            var value = amount.ToString().Replace(",", "."); // Allways decimal point

            switch (StepperMotor)
            {
                case "Z":
                    commands.Add("G91");
                    commands.Add($"G1 Z{value}");
                    commands.Add("G90");
                    if (ZeroPositionAfterEachMove)
                    {
                        commands.Add("G92 Z0");
                    }
                    if (SendCurrentPosition) commands.Add("M114");
                    MarlinCommunication.SendCommand(commands);
                    break;
                case "E0":
                    //TODO: Fixa hur Extruder communikation ser ut
                    break;
            }
        }

        private void btnMinus100_Click(object sender, EventArgs e)
        {
            MoveAxis(-100);
        }

        private void btnMinus10_Click(object sender, EventArgs e)
        {
            MoveAxis(-10);
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            MoveAxis(-1);
        }

        private void btnMinus01_Click(object sender, EventArgs e)
        {
            MoveAxis(-0.1);
        }

        private void btnPlus01_Click(object sender, EventArgs e)
        {
            MoveAxis(0.1);
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            MoveAxis(1);
        }

        private void btnPlus10_Click(object sender, EventArgs e)
        {
            MoveAxis(10);
        }

        private void btnPlus100_Click(object sender, EventArgs e)
        {
            MoveAxis(100);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //TODO: Haneta Extruder / Z axis

            MarlinCommunication.SendCommand("G92 Z0");
        }
    }
}
