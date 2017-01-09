using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarlinComunicationHelper
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BedCornerControl : UserControl
    {
        private CornerType _corner;
        private Configuration configuration = new Configuration();
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

        public BedCornerControl()
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
                        maskedTxtBxX.Text = configuration.FrontLeftCorner.Xstring;
                        maskedTxtBxY.Text = configuration.FrontLeftCorner.Ystring;
                        break;
                    case CornerType.FrontRightCorner:
                        maskedTxtBxX.Text = configuration.FrontRightCorner.Xstring;
                        maskedTxtBxY.Text = configuration.FrontRightCorner.Ystring;
                        break;
                    case CornerType.BackLeftCorner:
                        maskedTxtBxX.Text = configuration.BackLeftCorner.Xstring;
                        maskedTxtBxY.Text = configuration.BackLeftCorner.Ystring;
                        break;
                    case CornerType.BackRightCorner:
                        maskedTxtBxX.Text = configuration.BackRightCorner.Xstring;
                        maskedTxtBxY.Text = configuration.BackRightCorner.Ystring;
                        break;
                    case CornerType.SafeHome:
                        maskedTxtBxX.Text = configuration.SafeHome.Xstring;
                        maskedTxtBxY.Text = configuration.SafeHome.Ystring;
                        break;

                }

            }
            catch (Exception)
            {
                
                
            }
            

        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            maskedTxtBxX.Text = Communication.CurrentPosition.Xstring;
            maskedTxtBxY.Text = Communication.CurrentPosition.Ystring;
        }


        private void btnGoto_Click(object sender, EventArgs e)
        {
            List<string> commands = new List<string>();
            // Lift

            commands.Add($"G1 X{maskedTxtBxX.Text} Y{maskedTxtBxY.Text}");
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
                    configuration.FrontLeftCorner = position;
                    break;
                case CornerType.FrontRightCorner:
                    configuration.FrontRightCorner = position;
                    break;
                case CornerType.BackLeftCorner:
                    configuration.BackLeftCorner = position;
                    break;
                case CornerType.BackRightCorner:
                    configuration.BackRightCorner = position;
                    break;
                case CornerType.SafeHome:
                    configuration.SafeHome = position;
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
