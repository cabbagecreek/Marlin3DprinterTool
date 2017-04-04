using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Marlin3DprinterToolUserControls
{
    public partial class BindingControl : UserControl
    {
        private int _frontLeftCorner;
        private int _frontRightCorner;
        private int _backLeftCorner;
        private int _backRightCorner;


        public BindingControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            _frontLeftCorner = 0;
            _frontRightCorner = 0;
            _backLeftCorner = 0;
            _backRightCorner = 0;
            chartBinding.Series["FrontLeftCorner"].Points.Clear();
            chartBinding.Series["FrontRightCorner"].Points.Clear();
            chartBinding.Series["BackLeftCorner"].Points.Clear();
            chartBinding.Series["BackRightCorner"].Points.Clear();
            Rescale();
        }

        public void FrontLeftCorner(decimal y)
        {
            chartBinding.Series["FrontLeftCorner"].Points.AddXY(_frontLeftCorner, y);
            Rescale();
        }
        public void FrontRightCorner(decimal y)
        {
            chartBinding.Series["FrontRightCorner"].Points.AddXY(_frontRightCorner, y);
            Rescale();
        }
        public void BackLeftCorner(decimal y)
        {
            chartBinding.Series["BackRightCorner"].Points.AddXY(_backRightCorner, y);
            Rescale();

        }
        public void BackRightCorner(decimal y)
        {
            chartBinding.Series["BackLeftCorner"].Points.AddXY(_backLeftCorner, y);
            Rescale();
        }

        private void Rescale()
        {
            double max = 0;
            double min = 1000;


            for (int serieIndex = 0; serieIndex < chartBinding.Series.Count; serieIndex++)
            {


                foreach (DataPoint dp in chartBinding.Series[serieIndex].Points)
                {
                    min = Math.Min(min, dp.YValues[0]);
                    max = Math.Max(max, dp.YValues[0]);

                }
            }

            chartBinding.ChartAreas[0].AxisY.Maximum = max + (0.11 * max);
            chartBinding.ChartAreas[0].AxisY.Minimum = (Math.Max(min - (0.1 * min), 0));
        }
    }
}
