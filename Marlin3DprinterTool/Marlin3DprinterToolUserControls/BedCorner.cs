using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Marlin3DprinterToolConfiguration;
using MarlinComunicationHelper;

namespace Marlin3DprinterToolUserControls
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BedCorner : UserControl
    {
        private CornerType _corner;
        private MarlinCommunication _communication;

        public MarlinCommunication Communication
        {
            get { return _communication; }
            set
            {
                _communication = value;
                Populate();
            }
        }

        public CornerType Corner
        {
            get { return _corner; }
            set
            {
                _corner = value;

                switch (Corner)
                {
                    case CornerType.FrontLeftCorner:
                        grpBxBedControl.Text = @"Front Left Corner";
                        break;
                    case CornerType.FrontRightCorner:
                        grpBxBedControl.Text = @"Front Right Corner";
                        break;
                    case CornerType.BackLeftCorner:
                        grpBxBedControl.Text = @"Back Left Corner";
                        break;
                    case CornerType.BackRightCorner:
                        grpBxBedControl.Text = @"Back Right Corner";
                        break;
                    case CornerType.SafeHome:
                        grpBxBedControl.Text = @"Safe Home";
                        break;

                }

            }
        }

        public BedCorner()
        {
            InitializeComponent();

        }

        public void Populate()
        {
            try
            {
                switch (Corner)
                {
                    case CornerType.FrontLeftCorner:
                        maskedTxtBxX.Text = Configuration.GetInstance.FrontLeftCorner.Xstring;
                        maskedTxtBxY.Text = Configuration.GetInstance.FrontLeftCorner.Ystring;
                        break;
                    case CornerType.FrontRightCorner:
                        maskedTxtBxX.Text = Configuration.GetInstance.FrontRightCorner.Xstring;
                        maskedTxtBxY.Text = Configuration.GetInstance.FrontRightCorner.Ystring;
                        break;
                    case CornerType.BackLeftCorner:
                        maskedTxtBxX.Text = Configuration.GetInstance.BackLeftCorner.Xstring;
                        maskedTxtBxY.Text = Configuration.GetInstance.BackLeftCorner.Ystring;
                        break;
                    case CornerType.BackRightCorner:
                        maskedTxtBxX.Text = Configuration.GetInstance.BackRightCorner.Xstring;
                        maskedTxtBxY.Text = Configuration.GetInstance.BackRightCorner.Ystring;
                        break;
                    case CornerType.SafeHome:
                        maskedTxtBxX.Text = Configuration.GetInstance.SafeHome.Xstring;
                        maskedTxtBxY.Text = Configuration.GetInstance.SafeHome.Ystring;
                        break;

                }

            }
            catch (Exception)
            {


            }


        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            maskedTxtBxX.Text = Convert.ToInt16( Communication.CurrentPosition.X).ToString();
            maskedTxtBxY.Text = Convert.ToInt16( Communication.CurrentPosition.Y).ToString();
        }


        private void btnGoto_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            // Lift

            commands.Add($"G1 X{maskedTxtBxX.Text} Y{maskedTxtBxY.Text} F6000" );
            commands.Add("M114");
            Communication.SendCommand(commands);
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.Xstring = maskedTxtBxX.Text;
            position.Ystring = maskedTxtBxY.Text;
            switch (Corner)
            {
                case CornerType.FrontLeftCorner:
                    Configuration.GetInstance.FrontLeftCorner = position;
                    break;
                case CornerType.FrontRightCorner:
                    Configuration.GetInstance.FrontRightCorner = position;
                    break;
                case CornerType.BackLeftCorner:
                    Configuration.GetInstance.BackLeftCorner = position;
                    break;
                case CornerType.BackRightCorner:
                    Configuration.GetInstance.BackRightCorner = position;
                    break;
                case CornerType.SafeHome:
                    Configuration.GetInstance.SafeHome = position;
                    break;


            }
        }

    }

    public enum CornerType
    {
        None = 0,
        FrontLeftCorner = 1,
        FrontRightCorner = 2,
        BackLeftCorner = 3,
        BackRightCorner = 4,
        SafeHome = 5
    }
}
