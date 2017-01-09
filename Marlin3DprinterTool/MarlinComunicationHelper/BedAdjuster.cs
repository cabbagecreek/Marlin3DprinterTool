using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarlinComunicationHelper.Properties;

namespace MarlinComunicationHelper
{
    public partial class BedAdjuster : UserControl
    {
       
        private Configuration configuration = new Configuration();
        private AdjusterType _adjuster;
        private Position _position;
        private double _z;
        private double _x;
        private double _y;
        private AdjusterThreadType _adjusterThreads;
        private double _threadsPitch ;


        public AdjusterThreadType AdjusterThread
        {
            set
            {
                _adjusterThreads = value;

                switch (_adjusterThreads)
                {
                    case AdjusterThreadType.M3:
                        _threadsPitch = 0.5;
                        break;
                    case AdjusterThreadType.M4:
                        _threadsPitch = 0.7;
                        break;
                    case AdjusterThreadType.M5:
                        _threadsPitch = 0.8;
                        break;



                }
                


            }
            get { return _adjusterThreads; }
        }

        public double X
        {
            set
            {
                _x = value;
                
                if (Position != null) Position.X = _x;
            }
            get { return _x; }
        }

        public double Y
        {
            set
            {
                _y = value;
                if (Position != null) Position.Y = _y;

            }
            get { return _y; }
        }

        public double Z
        {
            set
            {
                _z = value;
                if (Position != null) Position.Z = _z;
                DelegateText(txtBxZ,_z.ToString().Replace(",", "."));
            }
            get { return _z; }
        }


        public Position Position
        {
            get { return _position; }
            set
            {
                _position = value;
                X = _position.X;
                Y = _position.Y;
            }
        }


        public AdjusterType Adjuster
        {
            get { return _adjuster; }
            set
            {
                _adjuster = value;
                switch (Adjuster)
                {
                        case AdjusterType.BackLeftAdjuster:
                            AdjusterPictureToTheLeft();
                            break;
                        case AdjusterType.BackRightAdjuster:
                            AdjusterPictureToTheRight();
                            break;
                        case AdjusterType.FrontLeftAdjuster:
                            AdjusterPictureToTheLeft();
                            break;
                        case AdjusterType.FrontRightAdjuster:
                            AdjusterPictureToTheRight();
                            break;
                        case AdjusterType.LeftSingleAdjuster:
                            AdjusterPictureToTheLeft();
                            break;
                        case AdjusterType.FrontSingleAdjuster:
                            AdjusterPictureToTheLeft();
                        break;
                        case AdjusterType.RightSingleAdjuster:
                            AdjusterPictureToTheRight();
                        break;
                }
            }
        }

        public void Clear()
        {
            switch (Adjuster)
            {
                case AdjusterType.BackLeftAdjuster:
                    ClearPictureToTheRight();
                    break;
                case AdjusterType.BackRightAdjuster:
                    ClearPictureToTheLeft();
                    break;
                case AdjusterType.FrontLeftAdjuster:
                    ClearPictureToTheRight();
                    break;
                case AdjusterType.FrontRightAdjuster:
                    ClearPictureToTheLeft();
                    break;
                case AdjusterType.LeftSingleAdjuster:
                    ClearPictureToTheRight();
                    break;
                case AdjusterType.FrontSingleAdjuster:
                    ClearPictureToTheRight();
                    break;
                case AdjusterType.RightSingleAdjuster:
                    ClearPictureToTheLeft();
                    break;
            }

        }


        private void AdjusterPictureToTheLeft()
        {
            picBxLeft.BackgroundImage = Properties.Resources.adjuster;
        }

        private void AdjusterPictureToTheRight()
        {
            picBxRight.BackgroundImage = Properties.Resources.adjuster;
        }


        private void ClearPictureToTheLeft()
        {
            picBxLeft.Visible = false;
        }

        private void ClearPictureToTheRight()
        {
            picBxRight.Visible = false;
        }


        public double Fix { get; set; }

        


        public void Calculate()
        {


            DelegateText(txtBxZ, Z.ToString().Replace(",", "."));
            double adjust;
            var diff = (Fix - Z);
            if (Math.Abs(diff) < 0.001)
            {
                adjust = 0;
            }
            else
            {
                adjust = (Fix - Z) / _threadsPitch;
            }
            
            var sign = adjust <= 0 ? "+" : "-";
            var turn = Math.Truncate(adjust);
            var decimalpart = adjust - turn;
            var minutes = (int)(decimalpart * 60);



            DelegateVisible(picBxRight, true);
            DelegateVisible(picBxLeft,true);

            Image turnIndicator = adjust <= 0 ? Resources.clockwise : Resources.counterclockwise;
            if (Math.Abs( adjust) <= 0.05) turnIndicator = Resources.OK;


            switch (Adjuster)
            {
                case AdjusterType.BackLeftAdjuster:

                    DelegateBackgroundImage(picBxRight, turnIndicator);
                    break;
                case AdjusterType.BackRightAdjuster:
                    DelegateBackgroundImage(picBxLeft, turnIndicator);
                    break;
                case AdjusterType.FrontLeftAdjuster:
                    DelegateBackgroundImage(picBxRight, turnIndicator);
                    break;
                case AdjusterType.FrontRightAdjuster:
                    DelegateBackgroundImage(picBxLeft, turnIndicator);
                    break;
                case AdjusterType.LeftSingleAdjuster:
                    DelegateBackgroundImage(picBxRight, turnIndicator);
                    break;
                case AdjusterType.FrontSingleAdjuster:
                    DelegateBackgroundImage(picBxRight, turnIndicator);
                    break;
                case AdjusterType.RightSingleAdjuster:
                    DelegateBackgroundImage(picBxLeft, turnIndicator);
                    break;

            }

            DelegateText(lblTurn, $"{sign} {Math.Abs(turn)}:{Math.Abs(minutes)} minutes");


        }

        public BedAdjuster()
        {
            InitializeComponent();
            Position = new Position();
            
        }



        private delegate void DelegateBackgroundImageCallback(Control control, Image image);
        private delegate void DelegateTextCallback(Control control, string text);
        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="image"></param>
        public void DelegateBackgroundImage(Control control, Image image)
        {
            if (control.InvokeRequired)
            {
                DelegateBackgroundImageCallback d = DelegateBackgroundImage;
                this.Invoke(d, control, image);
            }
            else
            {
                control.BackgroundImage = image;
            }
        }


        private delegate void DelegateVisibleCallback(Control control, bool visible);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        /// <param name="visible"></param>
        public void DelegateVisible(Control control, bool visible)
        {
            if (control.InvokeRequired)
            {
                DelegateVisibleCallback d = DelegateVisible;
                this.Invoke(d, control, visible);
            }
            else
            {
                control.Visible = visible;
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="text"></param>
        public void DelegateText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                DelegateTextCallback d = DelegateText;
                this.Invoke(d, control, text);
            }
            else
            {
                control.Text = text;
            }
        }


    }

    public enum AdjusterThreadType
    {
        M3 = 1,
        M4 = 2,
        M5 = 3

    }

    public enum AdjusterType
    {
        None = 0,
        FrontLeftAdjuster = 1,
        FrontRightAdjuster = 2,
        BackLeftAdjuster = 3,
        BackRightAdjuster = 4,
        LeftSingleAdjuster =5,
        FrontSingleAdjuster =6,
        RightSingleAdjuster = 7
    }
}
