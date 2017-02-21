using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoIDE
{
    public partial class New : UserControl
    {
        private DateTime _olddate;
        private DateTime _newDate;

        public DateTime Olddate
        {
            set
            {
                _olddate = value;
                ShowImage();
            }
            get { return _olddate; }
        }

        public DateTime NewDate
        {
            set
            {
                _newDate = value;
                ShowImage();
            }
            get { return _newDate; }
        }

        public New()
        {
            InitializeComponent();
        }

        private void ShowImage()
        {
            picBxNew.Visible = (Olddate < NewDate);
        }
    }
}
