using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marlin3DprinterToolUserControls
{
    public partial class MarlinPrecision : UserControl
    {
        private decimal _z;

        public bool Automatic
        {
            set { chkBxAutomatic.Checked = value; }
            get { return chkBxAutomatic.Checked; }
        }

        public decimal Z
        {
            set
            {
                _z = value;
                if (Automatic)
                {
                    if (_z >= 2)
                    {
                        trkBarPrecision.SmallChange = 5;
                        trkBarPrecision.LargeChange = 10;
                        trkBarPrecision.Maximum = 100;
                        trkBarPrecision.Minimum = 5;
                        trkBarPrecision.Value = 100;
                        
                    }
                    else
                    if (_z < 2 && _z >=1)
                    {
                        trkBarPrecision.SmallChange = 5;
                        trkBarPrecision.LargeChange = 10;
                        trkBarPrecision.Maximum = 100;
                        trkBarPrecision.Minimum = 5;
                        trkBarPrecision.Value = 50;

                    }
                    else
                    if (_z < 1)
                    {
                        trkBarPrecision.SmallChange = 5;
                        trkBarPrecision.LargeChange = 10;
                        trkBarPrecision.Maximum = 100;
                        trkBarPrecision.Minimum = 2;
                        trkBarPrecision.Value = 5;

                    }
                }


                txtBxPrecision.Text = (trkBarPrecision.Value / 100).ToString();
            }
            get { return _z; }
        }


        public MarlinPrecision()
        {
            InitializeComponent();
        }

        private void chkBxAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            trkBarPrecision.Enabled = !chkBxAutomatic.Checked;
            Z = _z;
        }
    }
}
