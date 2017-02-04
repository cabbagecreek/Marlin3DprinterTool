// Copyright (C) 2007 A.J.Bauer
//
//  This software is provided as-is, without any express or implied
//  warranty.  In no event will the authors be held liable for any damages
//  arising from the use of this software.

//  Permission is granted to anyone to use this software for any purpose,
//  including commercial applications, and to alter it and redistribute it
//  freely, subject to the following restrictions:
//  1. The origin of this software must not be misrepresented; you must not
//     claim that you wrote the original software. if you use this software
//     in a product, an acknowledgment in the product documentation would be
//     appreciated but is not required.
//  2. Altered source versions must be plainly marked as such, and must not be
//     misrepresented as being the original software.
//  3. This notice may not be removed or altered from any source distribution.
//
// -----------------------------------------------------------------------------------
// Copyright (C) 2012 Code Artist
// 
// Added several improvement to original code created by A.J.Bauer.
// Visit: http://codearteng.blogspot.com for more information on change history.
//
// -----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Collections;

namespace System.Windows.Forms
{
    /// <summary>
    /// <para>AGauge - Copyright (C) 2007 A.J.Bauer</para>
    /// <link>http://www.codeproject.com/Articles/17559/A-fast-and-performing-gauge</link>
    /// </summary>
    [ToolboxBitmapAttribute(typeof(AGauge), "AGauge.AGauge.bmp"),
    DefaultEvent("ValueInRangeChanged"),
    Description("Displays a value on an analog gauge. Raises an event if the value enters one of the definable ranges.")]
    public partial class AGauge : Control
    {
        #region Private Fields

        private Single fontBoundY1;
        private Single fontBoundY2;
        private Bitmap gaugeBitmap;
        private Boolean drawGaugeBackground = true;

        private Single m_value;
        private Point m_Center = new Point(100, 100);
        private Single m_MinValue = -100;
        private Single m_MaxValue = 400;

        private Color m_BaseArcColor = Color.Gray;
        private Int32 m_BaseArcRadius = 80;
        private Int32 m_BaseArcStart = 135;
        private Int32 m_BaseArcSweep = 270;
        private Int32 m_BaseArcWidth = 2;

        private Color m_ScaleLinesInterColor = Color.Black;
        private Int32 m_ScaleLinesInterInnerRadius = 73;
        private Int32 m_ScaleLinesInterOuterRadius = 80;
        private Int32 m_ScaleLinesInterWidth = 1;

        private Int32 m_ScaleLinesMinorTicks = 9;
        private Color m_ScaleLinesMinorColor = Color.Gray;
        private Int32 m_ScaleLinesMinorInnerRadius = 75;
        private Int32 m_ScaleLinesMinorOuterRadius = 80;
        private Int32 m_ScaleLinesMinorWidth = 1;

        private Single m_ScaleLinesMajorStepValue = 50.0f;
        private Color m_ScaleLinesMajorColor = Color.Black;
        private Int32 m_ScaleLinesMajorInnerRadius = 70;
        private Int32 m_ScaleLinesMajorOuterRadius = 80;
        private Int32 m_ScaleLinesMajorWidth = 2;

        private Int32 m_ScaleNumbersRadius = 95;
        private Color m_ScaleNumbersColor = Color.Black;
        private String m_ScaleNumbersFormat;
        private Int32 m_ScaleNumbersStartScaleLine;
        private Int32 m_ScaleNumbersStepScaleLines = 1;
        private Int32 m_ScaleNumbersRotation;

        private NeedleType m_NeedleType;
        private Int32 m_NeedleRadius = 80;
        private AGaugeNeedleColor m_NeedleColor1 = AGaugeNeedleColor.Gray;
        private Color m_NeedleColor2 = Color.DimGray;
        private Int32 m_NeedleWidth = 2;

        #endregion

        #region EventHandler

        [Description("This event is raised when gauge value changed.")]
        public event EventHandler ValueChanged;
        private void OnValueChanged()
        {
            EventHandler e = ValueChanged;
            if (e != null) e(this, null);
        }

        [Description("This event is raised if the value is entering or leaving defined range.")]
        public event EventHandler<ValueInRangeChangedEventArgs> ValueInRangeChanged;
        private void OnValueInRangeChanged(AGaugeRange range, Single value)
        {
            EventHandler<ValueInRangeChangedEventArgs> e = ValueInRangeChanged;
            if (e != null) e(this, new ValueInRangeChangedEventArgs(range, value, range.InRange));
        }

        #endregion

        #region Hidden and overridden inherited properties

        public new Boolean AllowDrop { get { return false; } set { /*Do Nothing */ } }
        public new Boolean AutoSize { get { return false; } set { /*Do Nothing */ } }
        public new Boolean ForeColor { get { return false; } set { /*Do Nothing */ } }
        public new Boolean ImeMode { get { return false; } set { /*Do Nothing */ } }
        public override System.Drawing.Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                drawGaugeBackground = true;
                Refresh();
            }
        }
        public override System.Drawing.Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                drawGaugeBackground = true;
                Refresh();
            }
        }
        public override System.Windows.Forms.ImageLayout BackgroundImageLayout
        {
            get { return base.BackgroundImageLayout; }
            set
            {
                base.BackgroundImageLayout = value;
                drawGaugeBackground = true;
                Refresh();
            }
        }

        #endregion

        public AGauge()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            _GaugeRanges = new AGaugeRangeCollection(this);
            _GaugeLabels = new AGaugeLabelCollection(this);

            //Default Values
            Size = new Size(205, 180);
        }

        #region Properties

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("Gauge value.")]
        public Single Value
        {
            get { return m_value; }
            set
            {
                value = Math.Min(Math.Max(value, m_MinValue), m_MaxValue);
                if (m_value != value)
                {
                    m_value = value;
                    OnValueChanged();

                    if (this.DesignMode) drawGaugeBackground = true;

                    foreach (AGaugeRange ptrRange in _GaugeRanges)
                    {
                        if ((m_value >= ptrRange.StartValue)
                            && (m_value <= ptrRange.EndValue))
                        {
                            //Entering Range
                            if (!ptrRange.InRange)
                            {
                                ptrRange.InRange = true;
                                OnValueInRangeChanged(ptrRange, m_value);
                            }
                        }
                        else
                        {
                            //Leaving Range
                            if (ptrRange.InRange)
                            {
                                ptrRange.InRange = false;
                                OnValueInRangeChanged(ptrRange, m_value);
                            }
                        }
                    }
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("Gauge Ranges.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AGaugeRangeCollection GaugeRanges { get { return _GaugeRanges; } }
        private AGaugeRangeCollection _GaugeRanges;

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("Gauge Labels.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AGaugeLabelCollection GaugeLabels { get { return _GaugeLabels; } }
        private AGaugeLabelCollection _GaugeLabels;

        #region << Gauge Base >>

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The center of the gauge (in the control's client area).")]
        public Point Center
        {
            get { return m_Center; }
            set
            {
                if (m_Center != value)
                {
                    m_Center = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The color of the base arc.")]
        public Color BaseArcColor
        {
            get { return m_BaseArcColor; }
            set
            {
                if (m_BaseArcColor != value)
                {
                    m_BaseArcColor = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The radius of the base arc.")]
        public Int32 BaseArcRadius
        {
            get { return m_BaseArcRadius; }
            set
            {
                if (m_BaseArcRadius != value)
                {
                    m_BaseArcRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The start angle of the base arc.")]
        public Int32 BaseArcStart
        {
            get { return m_BaseArcStart; }
            set
            {
                if (m_BaseArcStart != value)
                {
                    m_BaseArcStart = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The sweep angle of the base arc.")]
        public Int32 BaseArcSweep
        {
            get { return m_BaseArcSweep; }
            set
            {
                if (m_BaseArcSweep != value)
                {
                    m_BaseArcSweep = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The width of the base arc.")]
        public Int32 BaseArcWidth
        {
            get { return m_BaseArcWidth; }
            set
            {
                if (m_BaseArcWidth != value)
                {
                    m_BaseArcWidth = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        #endregion

        #region << Gauge Scale >>

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The minimum value to show on the scale.")]
        public Single MinValue
        {
            get { return m_MinValue; }
            set
            {
                if ((m_MinValue != value) && (value < m_MaxValue))
                {
                    m_MinValue = value;
                    m_value = Math.Min(Math.Max(m_value, m_MinValue), m_MaxValue);
                    m_ScaleLinesMajorStepValue = Math.Min(m_ScaleLinesMajorStepValue, m_MaxValue - m_MinValue);
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The maximum value to show on the scale.")]
        public Single MaxValue
        {
            get { return m_MaxValue; }
            set
            {
                if ((m_MaxValue != value) && (value > m_MinValue))
                {
                    m_MaxValue = value;
                    m_value= Math.Min(Math.Max(m_value, m_MinValue), m_MaxValue);
                    m_ScaleLinesMajorStepValue = Math.Min(m_ScaleLinesMajorStepValue, m_MaxValue - m_MinValue);
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The color of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
        public Color ScaleLinesInterColor
        {
            get { return m_ScaleLinesInterColor; }
            set
            {
                if (m_ScaleLinesInterColor != value)
                {
                    m_ScaleLinesInterColor = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The inner radius of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
        public Int32 ScaleLinesInterInnerRadius
        {
            get { return m_ScaleLinesInterInnerRadius; }
            set
            {
                if (m_ScaleLinesInterInnerRadius != value)
                {
                    m_ScaleLinesInterInnerRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The outer radius of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
        public Int32 ScaleLinesInterOuterRadius
        {
            get { return m_ScaleLinesInterOuterRadius; }
            set
            {
                if (m_ScaleLinesInterOuterRadius != value)
                {
                    m_ScaleLinesInterOuterRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The width of the inter scale lines which are the middle scale lines for an uneven number of minor scale lines.")]
        public Int32 ScaleLinesInterWidth
        {
            get { return m_ScaleLinesInterWidth; }
            set
            {
                if (m_ScaleLinesInterWidth != value)
                {
                    m_ScaleLinesInterWidth = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The number of minor scale lines.")]
        public Int32 ScaleLinesMinorTicks
        {
            get { return m_ScaleLinesMinorTicks; }
            set
            {
                if (m_ScaleLinesMinorTicks != value)
                {
                    m_ScaleLinesMinorTicks = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The color of the minor scale lines.")]
        public Color ScaleLinesMinorColor
        {
            get { return m_ScaleLinesMinorColor; }
            set
            {
                if (m_ScaleLinesMinorColor != value)
                {
                    m_ScaleLinesMinorColor = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The inner radius of the minor scale lines.")]
        public Int32 ScaleLinesMinorInnerRadius
        {
            get { return m_ScaleLinesMinorInnerRadius; }
            set
            {
                if (m_ScaleLinesMinorInnerRadius != value)
                {
                    m_ScaleLinesMinorInnerRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The outer radius of the minor scale lines.")]
        public Int32 ScaleLinesMinorOuterRadius
        {
            get { return m_ScaleLinesMinorOuterRadius; }
            set
            {
                if (m_ScaleLinesMinorOuterRadius != value)
                {
                    m_ScaleLinesMinorOuterRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The width of the minor scale lines.")]
        public Int32 ScaleLinesMinorWidth
        {
            get { return m_ScaleLinesMinorWidth; }
            set
            {
                if (m_ScaleLinesMinorWidth != value)
                {
                    m_ScaleLinesMinorWidth = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The step value of the major scale lines.")]
        public Single ScaleLinesMajorStepValue
        {
            get { return m_ScaleLinesMajorStepValue; }
            set
            {
                if ((m_ScaleLinesMajorStepValue != value) && (value > 0))
                {
                    m_ScaleLinesMajorStepValue = Math.Min(value, m_MaxValue - m_MinValue);
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The color of the major scale lines.")]
        public Color ScaleLinesMajorColor
        {
            get { return m_ScaleLinesMajorColor; }
            set
            {
                if (m_ScaleLinesMajorColor != value)
                {
                    m_ScaleLinesMajorColor = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The inner radius of the major scale lines.")]
        public Int32 ScaleLinesMajorInnerRadius
        {
            get { return m_ScaleLinesMajorInnerRadius; }
            set
            {
                if (m_ScaleLinesMajorInnerRadius != value)
                {
                    m_ScaleLinesMajorInnerRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The outer radius of the major scale lines.")]
        public Int32 ScaleLinesMajorOuterRadius
        {
            get { return m_ScaleLinesMajorOuterRadius; }
            set
            {
                if (m_ScaleLinesMajorOuterRadius != value)
                {
                    m_ScaleLinesMajorOuterRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The width of the major scale lines.")]
        public Int32 ScaleLinesMajorWidth
        {
            get { return m_ScaleLinesMajorWidth; }
            set
            {
                if (m_ScaleLinesMajorWidth != value)
                {
                    m_ScaleLinesMajorWidth = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        #endregion

        #region << Gauge Scale Numbers >>

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The radius of the scale numbers.")]
        public Int32 ScaleNumbersRadius
        {
            get { return m_ScaleNumbersRadius; }
            set
            {
                if (m_ScaleNumbersRadius != value)
                {
                    m_ScaleNumbersRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The color of the scale numbers.")]
        public Color ScaleNumbersColor
        {
            get { return m_ScaleNumbersColor; }
            set
            {
                if (m_ScaleNumbersColor != value)
                {
                    m_ScaleNumbersColor = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The format of the scale numbers.")]
        public String ScaleNumbersFormat
        {
            get { return m_ScaleNumbersFormat; }
            set
            {
                if (m_ScaleNumbersFormat != value)
                {
                    m_ScaleNumbersFormat = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The number of the scale line to start writing numbers next to.")]
        public Int32 ScaleNumbersStartScaleLine
        {
            get { return m_ScaleNumbersStartScaleLine; }
            set
            {
                if (m_ScaleNumbersStartScaleLine != value)
                {
                    m_ScaleNumbersStartScaleLine = Math.Max(value, 1);
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The number of scale line steps for writing numbers.")]
        public Int32 ScaleNumbersStepScaleLines
        {
            get { return m_ScaleNumbersStepScaleLines; }
            set
            {
                if (m_ScaleNumbersStepScaleLines != value)
                {
                    m_ScaleNumbersStepScaleLines = Math.Max(value, 1);
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The angle relative to the tangent of the base arc at a scale line that is used to rotate numbers. set to 0 for no rotation or e.g. set to 90.")]
        public Int32 ScaleNumbersRotation
        {
            get { return m_ScaleNumbersRotation; }
            set
            {
                if (m_ScaleNumbersRotation != value)
                {
                    m_ScaleNumbersRotation = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        #endregion

        #region << Gauge Needle >>

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The type of the needle, currently only type 0 and 1 are supported. Type 0 looks nicers but if you experience performance problems you might consider using type 1.")]
        public NeedleType NeedleType
        {
            get { return m_NeedleType; }
            set
            {
                if (m_NeedleType != value)
                {
                    m_NeedleType = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The radius of the needle.")]
        public Int32 NeedleRadius
        {
            get { return m_NeedleRadius; }
            set
            {
                if (m_NeedleRadius != value)
                {
                    m_NeedleRadius = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The first color of the needle.")]
        public AGaugeNeedleColor NeedleColor1
        {
            get { return m_NeedleColor1; }
            set
            {
                if (m_NeedleColor1 != value)
                {
                    m_NeedleColor1 = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The second color of the needle.")]
        public Color NeedleColor2
        {
            get { return m_NeedleColor2; }
            set
            {
                if (m_NeedleColor2 != value)
                {
                    m_NeedleColor2 = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("AGauge"),
        System.ComponentModel.Description("The width of the needle.")]
        public Int32 NeedleWidth
        {
            get { return m_NeedleWidth; }
            set
            {
                if (m_NeedleWidth != value)
                {
                    m_NeedleWidth = value;
                    drawGaugeBackground = true;
                    Refresh();
                }
            }
        }

        #endregion

        #endregion

        #region Helper

        private void FindFontBounds()
        {
            //find upper and lower bounds for numeric characters
            Int32 c1;
            Int32 c2;
            Boolean boundfound;
            Bitmap b;
            Graphics g;
            SolidBrush backBrush = new SolidBrush(Color.White);
            SolidBrush foreBrush = new SolidBrush(Color.Black);
            SizeF boundingBox;

            b = new Bitmap(5, 5);
            g = Graphics.FromImage(b);
            boundingBox = g.MeasureString("0123456789", Font, -1, StringFormat.GenericTypographic);
            b = new Bitmap((Int32)(boundingBox.Width), (Int32)(boundingBox.Height));
            g = Graphics.FromImage(b);
            g.FillRectangle(backBrush, 0.0F, 0.0F, boundingBox.Width, boundingBox.Height);
            g.DrawString("0123456789", Font, foreBrush, 0.0F, 0.0F, StringFormat.GenericTypographic);

            fontBoundY1 = 0;
            fontBoundY2 = 0;
            c1 = 0;
            boundfound = false;
            while ((c1 < b.Height) && (!boundfound))
            {
                c2 = 0;
                while ((c2 < b.Width) && (!boundfound))
                {
                    if (b.GetPixel(c2, c1) != backBrush.Color)
                    {
                        fontBoundY1 = c1;
                        boundfound = true;
                    }
                    c2++;
                }
                c1++;
            }

            c1 = b.Height - 1;
            boundfound = false;
            while ((0 < c1) && (!boundfound))
            {
                c2 = 0;
                while ((c2 < b.Width) && (!boundfound))
                {
                    if (b.GetPixel(c2, c1) != backBrush.Color)
                    {
                        fontBoundY2 = c1;
                        boundfound = true;
                    }
                    c2++;
                }
                c1--;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public void RepaintControl()
        {
            drawGaugeBackground = true;
            Refresh();
        }

        #endregion

        #region Base member overrides

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if ((Width < 10) || (Height < 10))
            {
                return;
            }

            if (drawGaugeBackground)
            {
                drawGaugeBackground = false;

                FindFontBounds();

                gaugeBitmap = new Bitmap(Width, Height, e.Graphics);
                Graphics ggr = Graphics.FromImage(gaugeBitmap);
                ggr.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

                if (BackgroundImage != null)
                {
                    switch (BackgroundImageLayout)
                    {
                        case ImageLayout.Center:
                            ggr.DrawImageUnscaled(BackgroundImage, Width / 2 - BackgroundImage.Width / 2, Height / 2 - BackgroundImage.Height / 2);
                            break;
                        case ImageLayout.None:
                            ggr.DrawImageUnscaled(BackgroundImage, 0, 0);
                            break;
                        case ImageLayout.Stretch:
                            ggr.DrawImage(BackgroundImage, 0, 0, Width, Height);
                            break;
                        case ImageLayout.Tile:
                            Int32 pixelOffsetX = 0;
                            Int32 pixelOffsetY = 0;
                            while (pixelOffsetX < Width)
                            {
                                pixelOffsetY = 0;
                                while (pixelOffsetY < Height)
                                {
                                    ggr.DrawImageUnscaled(BackgroundImage, pixelOffsetX, pixelOffsetY);
                                    pixelOffsetY += BackgroundImage.Height;
                                }
                                pixelOffsetX += BackgroundImage.Width;
                            }
                            break;
                        case ImageLayout.Zoom:
                            if ((Single)(BackgroundImage.Width / Width) < (Single)(BackgroundImage.Height / Height))
                            {
                                ggr.DrawImage(BackgroundImage, 0, 0, Height, Height);
                            }
                            else
                            {
                                ggr.DrawImage(BackgroundImage, 0, 0, Width, Width);
                            }
                            break;
                    }
                }

                ggr.SmoothingMode = SmoothingMode.HighQuality;
                ggr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                GraphicsPath gp = new GraphicsPath();
                Single rangeStartAngle;
                Single rangeSweepAngle;

                foreach (AGaugeRange ptrRange in _GaugeRanges)
                {
                    if (ptrRange.EndValue > ptrRange.StartValue)
                    {
                        rangeStartAngle = m_BaseArcStart + (ptrRange.StartValue - m_MinValue) * m_BaseArcSweep / (m_MaxValue - m_MinValue);
                        rangeSweepAngle = (ptrRange.EndValue - ptrRange.StartValue) * m_BaseArcSweep / (m_MaxValue - m_MinValue);
                        gp.Reset();
                        gp.AddPie(new Rectangle(m_Center.X - ptrRange.OuterRadius, m_Center.Y - ptrRange.OuterRadius,
                            2 * ptrRange.OuterRadius, 2 * ptrRange.OuterRadius), rangeStartAngle, rangeSweepAngle);
                        gp.Reverse();
                        gp.AddPie(new Rectangle(m_Center.X - ptrRange.InnerRadius, m_Center.Y - ptrRange.InnerRadius,
                            2 * ptrRange.InnerRadius, 2 * ptrRange.InnerRadius), rangeStartAngle, rangeSweepAngle);
                        gp.Reverse();
                        ggr.SetClip(gp);
                        ggr.FillPie(new SolidBrush(ptrRange.Color), new Rectangle(m_Center.X - ptrRange.OuterRadius, m_Center.Y - ptrRange.OuterRadius, 2 * ptrRange.OuterRadius, 2 * ptrRange.OuterRadius), rangeStartAngle, rangeSweepAngle);
                    }
                }

                ggr.SetClip(ClientRectangle);
                if (m_BaseArcRadius > 0)
                {
                    ggr.DrawArc(new Pen(m_BaseArcColor, m_BaseArcWidth), new Rectangle(m_Center.X - m_BaseArcRadius, m_Center.Y - m_BaseArcRadius, 2 * m_BaseArcRadius, 2 * m_BaseArcRadius), m_BaseArcStart, m_BaseArcSweep);
                }

                String valueText = "";
                SizeF boundingBox;
                Single countValue = 0;
                Int32 counter1 = 0;
                while (countValue <= (m_MaxValue - m_MinValue))
                {
                    valueText = (m_MinValue + countValue).ToString(m_ScaleNumbersFormat);
                    ggr.ResetTransform();
                    boundingBox = ggr.MeasureString(valueText, Font, -1, StringFormat.GenericTypographic);

                    gp.Reset();
                    gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesMajorOuterRadius, m_Center.Y - m_ScaleLinesMajorOuterRadius, 2 * m_ScaleLinesMajorOuterRadius, 2 * m_ScaleLinesMajorOuterRadius));
                    gp.Reverse();
                    gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesMajorInnerRadius, m_Center.Y - m_ScaleLinesMajorInnerRadius, 2 * m_ScaleLinesMajorInnerRadius, 2 * m_ScaleLinesMajorInnerRadius));
                    gp.Reverse();
                    ggr.SetClip(gp);

                    ggr.DrawLine(new Pen(m_ScaleLinesMajorColor, m_ScaleLinesMajorWidth),
                    (Single)(Center.X),
                    (Single)(Center.Y),
                    (Single)(Center.X + 2 * m_ScaleLinesMajorOuterRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0)),
                    (Single)(Center.Y + 2 * m_ScaleLinesMajorOuterRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0)));

                    gp.Reset();
                    gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesMinorOuterRadius, m_Center.Y - m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius));
                    gp.Reverse();
                    gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesMinorInnerRadius, m_Center.Y - m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius));
                    gp.Reverse();
                    ggr.SetClip(gp);

                    if (countValue < (m_MaxValue - m_MinValue))
                    {
                        for (Int32 counter2 = 1; counter2 <= m_ScaleLinesMinorTicks; counter2++)
                        {
                            if (((m_ScaleLinesMinorTicks % 2) == 1) && ((Int32)(m_ScaleLinesMinorTicks / 2) + 1 == counter2))
                            {
                                gp.Reset();
                                gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesInterOuterRadius, m_Center.Y - m_ScaleLinesInterOuterRadius, 2 * m_ScaleLinesInterOuterRadius, 2 * m_ScaleLinesInterOuterRadius));
                                gp.Reverse();
                                gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesInterInnerRadius, m_Center.Y - m_ScaleLinesInterInnerRadius, 2 * m_ScaleLinesInterInnerRadius, 2 * m_ScaleLinesInterInnerRadius));
                                gp.Reverse();
                                ggr.SetClip(gp);

                                ggr.DrawLine(new Pen(m_ScaleLinesInterColor, m_ScaleLinesInterWidth),
                                (Single)(Center.X),
                                (Single)(Center.Y),
                                (Single)(Center.X + 2 * m_ScaleLinesInterOuterRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (((Single)((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue)) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0)),
                                (Single)(Center.Y + 2 * m_ScaleLinesInterOuterRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (((Single)((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue)) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0)));

                                gp.Reset();
                                gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesMinorOuterRadius, m_Center.Y - m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius, 2 * m_ScaleLinesMinorOuterRadius));
                                gp.Reverse();
                                gp.AddEllipse(new Rectangle(m_Center.X - m_ScaleLinesMinorInnerRadius, m_Center.Y - m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius, 2 * m_ScaleLinesMinorInnerRadius));
                                gp.Reverse();
                                ggr.SetClip(gp);
                            }
                            else
                            {
                                ggr.DrawLine(new Pen(m_ScaleLinesMinorColor, m_ScaleLinesMinorWidth),
                                (Single)(Center.X),
                                (Single)(Center.Y),
                                (Single)(Center.X + 2 * m_ScaleLinesMinorOuterRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (((Single)((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue)) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0)),
                                (Single)(Center.Y + 2 * m_ScaleLinesMinorOuterRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue) + counter2 * m_BaseArcSweep / (((Single)((m_MaxValue - m_MinValue) / m_ScaleLinesMajorStepValue)) * (m_ScaleLinesMinorTicks + 1))) * Math.PI / 180.0)));
                            }
                        }
                    }

                    ggr.SetClip(ClientRectangle);

                    if (m_ScaleNumbersRotation != 0)
                    {
                        ggr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        ggr.RotateTransform(90.0F + m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue));
                    }

                    ggr.TranslateTransform((Single)(Center.X + m_ScaleNumbersRadius * Math.Cos((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0f)),
                                           (Single)(Center.Y + m_ScaleNumbersRadius * Math.Sin((m_BaseArcStart + countValue * m_BaseArcSweep / (m_MaxValue - m_MinValue)) * Math.PI / 180.0f)),
                                           System.Drawing.Drawing2D.MatrixOrder.Append);


                    if (counter1 >= ScaleNumbersStartScaleLine - 1)
                    {
                        ggr.DrawString(valueText, Font, new SolidBrush(m_ScaleNumbersColor), -boundingBox.Width / 2, -fontBoundY1 - (fontBoundY2 - fontBoundY1 + 1) / 2, StringFormat.GenericTypographic);
                    }

                    countValue += m_ScaleLinesMajorStepValue;
                    counter1++;
                }

                ggr.ResetTransform();
                ggr.SetClip(ClientRectangle);

                if (m_ScaleNumbersRotation != 0)
                {
                    ggr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
                }

                foreach (AGaugeLabel ptrGaugeLabel in _GaugeLabels)
                {
                    if (!String.IsNullOrEmpty(ptrGaugeLabel.Text))
                        ggr.DrawString(ptrGaugeLabel.Text, ptrGaugeLabel.Font, new SolidBrush(ptrGaugeLabel.Color),
                            ptrGaugeLabel.Position.X, ptrGaugeLabel.Position.Y, StringFormat.GenericTypographic);
                }
            }

            e.Graphics.DrawImageUnscaled(gaugeBitmap, 0, 0);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Single brushAngle = (Int32)(m_BaseArcStart + (m_value - m_MinValue) * m_BaseArcSweep / (m_MaxValue - m_MinValue)) % 360;
            Double needleAngle = brushAngle * Math.PI / 180;

            switch (m_NeedleType)
            {
                case NeedleType.Advance:
                    PointF[] points = new PointF[3];
                    Brush brush1 = Brushes.White;
                    Brush brush2 = Brushes.White;
                    Brush brush3 = Brushes.White;
                    Brush brush4 = Brushes.White;

                    Brush brushBucket = Brushes.White;
                    Int32 subcol = (Int32)(((brushAngle + 225) % 180) * 100 / 180);
                    Int32 subcol2 = (Int32)(((brushAngle + 135) % 180) * 100 / 180);

                    e.Graphics.FillEllipse(new SolidBrush(m_NeedleColor2), Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                    switch (m_NeedleColor1)
                    {
                        case AGaugeNeedleColor.Gray:
                            brush1 = new SolidBrush(Color.FromArgb(80 + subcol, 80 + subcol, 80 + subcol));
                            brush2 = new SolidBrush(Color.FromArgb(180 - subcol, 180 - subcol, 180 - subcol));
                            brush3 = new SolidBrush(Color.FromArgb(80 + subcol2, 80 + subcol2, 80 + subcol2));
                            brush4 = new SolidBrush(Color.FromArgb(180 - subcol2, 180 - subcol2, 180 - subcol2));
                            e.Graphics.DrawEllipse(Pens.Gray, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                            break;
                        case AGaugeNeedleColor.Red:
                            brush1 = new SolidBrush(Color.FromArgb(145 + subcol, subcol, subcol));
                            brush2 = new SolidBrush(Color.FromArgb(245 - subcol, 100 - subcol, 100 - subcol));
                            brush3 = new SolidBrush(Color.FromArgb(145 + subcol2, subcol2, subcol2));
                            brush4 = new SolidBrush(Color.FromArgb(245 - subcol2, 100 - subcol2, 100 - subcol2));
                            e.Graphics.DrawEllipse(Pens.Red, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                            break;
                        case AGaugeNeedleColor.Green:
                            brush1 = new SolidBrush(Color.FromArgb(subcol, 145 + subcol, subcol));
                            brush2 = new SolidBrush(Color.FromArgb(100 - subcol, 245 - subcol, 100 - subcol));
                            brush3 = new SolidBrush(Color.FromArgb(subcol2, 145 + subcol2, subcol2));
                            brush4 = new SolidBrush(Color.FromArgb(100 - subcol2, 245 - subcol2, 100 - subcol2));
                            e.Graphics.DrawEllipse(Pens.Green, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                            break;
                        case AGaugeNeedleColor.Blue:
                            brush1 = new SolidBrush(Color.FromArgb(subcol, subcol, 145 + subcol));
                            brush2 = new SolidBrush(Color.FromArgb(100 - subcol, 100 - subcol, 245 - subcol));
                            brush3 = new SolidBrush(Color.FromArgb(subcol2, subcol2, 145 + subcol2));
                            brush4 = new SolidBrush(Color.FromArgb(100 - subcol2, 100 - subcol2, 245 - subcol2));
                            e.Graphics.DrawEllipse(Pens.Blue, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                            break;
                        case AGaugeNeedleColor.Magenta:
                            brush1 = new SolidBrush(Color.FromArgb(subcol, 145 + subcol, 145 + subcol));
                            brush2 = new SolidBrush(Color.FromArgb(100 - subcol, 245 - subcol, 245 - subcol));
                            brush3 = new SolidBrush(Color.FromArgb(subcol2, 145 + subcol2, 145 + subcol2));
                            brush4 = new SolidBrush(Color.FromArgb(100 - subcol2, 245 - subcol2, 245 - subcol2));
                            e.Graphics.DrawEllipse(Pens.Magenta, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                            break;
                        case AGaugeNeedleColor.Violet:
                            brush1 = new SolidBrush(Color.FromArgb(145 + subcol, subcol, 145 + subcol));
                            brush2 = new SolidBrush(Color.FromArgb(245 - subcol, 100 - subcol, 245 - subcol));
                            brush3 = new SolidBrush(Color.FromArgb(145 + subcol2, subcol2, 145 + subcol2));
                            brush4 = new SolidBrush(Color.FromArgb(245 - subcol2, 100 - subcol2, 245 - subcol2));
                            e.Graphics.DrawEllipse(Pens.Violet, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                            break;
                        case AGaugeNeedleColor.Yellow:
                            brush1 = new SolidBrush(Color.FromArgb(145 + subcol, 145 + subcol, subcol));
                            brush2 = new SolidBrush(Color.FromArgb(245 - subcol, 245 - subcol, 100 - subcol));
                            brush3 = new SolidBrush(Color.FromArgb(145 + subcol2, 145 + subcol2, subcol2));
                            brush4 = new SolidBrush(Color.FromArgb(245 - subcol2, 245 - subcol2, 100 - subcol2));
                            e.Graphics.DrawEllipse(Pens.Violet, Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);
                            break;
                    }

                    if (Math.Floor((Single)(((brushAngle + 225) % 360) / 180.0)) == 0)
                    {
                        brushBucket = brush1;
                        brush1 = brush2;
                        brush2 = brushBucket;
                    }

                    if (Math.Floor((Single)(((brushAngle + 135) % 360) / 180.0)) == 0)
                    {
                        brush4 = brush3;
                    }

                    points[0].X = (Single)(Center.X + m_NeedleRadius * Math.Cos(needleAngle));
                    points[0].Y = (Single)(Center.Y + m_NeedleRadius * Math.Sin(needleAngle));
                    points[1].X = (Single)(Center.X - m_NeedleRadius / 20 * Math.Cos(needleAngle));
                    points[1].Y = (Single)(Center.Y - m_NeedleRadius / 20 * Math.Sin(needleAngle));
                    points[2].X = (Single)(Center.X - m_NeedleRadius / 5 * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle + Math.PI / 2));
                    points[2].Y = (Single)(Center.Y - m_NeedleRadius / 5 * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle + Math.PI / 2));
                    e.Graphics.FillPolygon(brush1, points);

                    points[2].X = (Single)(Center.X - m_NeedleRadius / 5 * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle - Math.PI / 2));
                    points[2].Y = (Single)(Center.Y - m_NeedleRadius / 5 * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle - Math.PI / 2));
                    e.Graphics.FillPolygon(brush2, points);

                    points[0].X = (Single)(Center.X - (m_NeedleRadius / 20 - 1) * Math.Cos(needleAngle));
                    points[0].Y = (Single)(Center.Y - (m_NeedleRadius / 20 - 1) * Math.Sin(needleAngle));
                    points[1].X = (Single)(Center.X - m_NeedleRadius / 5 * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle + Math.PI / 2));
                    points[1].Y = (Single)(Center.Y - m_NeedleRadius / 5 * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle + Math.PI / 2));
                    points[2].X = (Single)(Center.X - m_NeedleRadius / 5 * Math.Cos(needleAngle) + m_NeedleWidth * 2 * Math.Cos(needleAngle - Math.PI / 2));
                    points[2].Y = (Single)(Center.Y - m_NeedleRadius / 5 * Math.Sin(needleAngle) + m_NeedleWidth * 2 * Math.Sin(needleAngle - Math.PI / 2));
                    e.Graphics.FillPolygon(brush4, points);

                    points[0].X = (Single)(Center.X - m_NeedleRadius / 20 * Math.Cos(needleAngle));
                    points[0].Y = (Single)(Center.Y - m_NeedleRadius / 20 * Math.Sin(needleAngle));
                    points[1].X = (Single)(Center.X + m_NeedleRadius * Math.Cos(needleAngle));
                    points[1].Y = (Single)(Center.Y + m_NeedleRadius * Math.Sin(needleAngle));

                    e.Graphics.DrawLine(new Pen(m_NeedleColor2), Center.X, Center.Y, points[0].X, points[0].Y);
                    e.Graphics.DrawLine(new Pen(m_NeedleColor2), Center.X, Center.Y, points[1].X, points[1].Y);
                    break;
                case NeedleType.Simple: Point startPoint = new Point((Int32)(Center.X - m_NeedleRadius / 8 * Math.Cos(needleAngle)),
                                                (Int32)(Center.Y - m_NeedleRadius / 8 * Math.Sin(needleAngle)));
                    Point endPoint = new Point((Int32)(Center.X + m_NeedleRadius * Math.Cos(needleAngle)),
                                             (Int32)(Center.Y + m_NeedleRadius * Math.Sin(needleAngle)));

                    e.Graphics.FillEllipse(new SolidBrush(m_NeedleColor2), Center.X - m_NeedleWidth * 3, Center.Y - m_NeedleWidth * 3, m_NeedleWidth * 6, m_NeedleWidth * 6);

                    switch (m_NeedleColor1)
                    {
                        case AGaugeNeedleColor.Gray:
                            e.Graphics.DrawLine(new Pen(Color.DarkGray, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y);
                            e.Graphics.DrawLine(new Pen(Color.DarkGray, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y);
                            break;
                        case AGaugeNeedleColor.Red:
                            e.Graphics.DrawLine(new Pen(Color.Red, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y);
                            e.Graphics.DrawLine(new Pen(Color.Red, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y);
                            break;
                        case AGaugeNeedleColor.Green:
                            e.Graphics.DrawLine(new Pen(Color.Green, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y);
                            e.Graphics.DrawLine(new Pen(Color.Green, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y);
                            break;
                        case AGaugeNeedleColor.Blue:
                            e.Graphics.DrawLine(new Pen(Color.Blue, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y);
                            e.Graphics.DrawLine(new Pen(Color.Blue, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y);
                            break;
                        case AGaugeNeedleColor.Magenta:
                            e.Graphics.DrawLine(new Pen(Color.Magenta, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y);
                            e.Graphics.DrawLine(new Pen(Color.Magenta, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y);
                            break;
                        case AGaugeNeedleColor.Violet:
                            e.Graphics.DrawLine(new Pen(Color.Violet, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y);
                            e.Graphics.DrawLine(new Pen(Color.Violet, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y);
                            break;
                        case AGaugeNeedleColor.Yellow:
                            e.Graphics.DrawLine(new Pen(Color.Yellow, m_NeedleWidth), Center.X, Center.Y, endPoint.X, endPoint.Y);
                            e.Graphics.DrawLine(new Pen(Color.Yellow, m_NeedleWidth), Center.X, Center.Y, startPoint.X, startPoint.Y);
                            break;
                    }
                    break;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            drawGaugeBackground = true;
            Refresh();
        }

        #endregion

    }

    #region[ Gauge Range ]
    public class AGaugeRangeCollection : CollectionBase
    {
        private AGauge Owner;
        public AGaugeRangeCollection(AGauge sender) { Owner = sender; }

        public AGaugeRange this[int index] { get { return (AGaugeRange)List[index]; } }
        public bool Contains(AGaugeRange itemType) { return List.Contains(itemType); }
        public int Add(AGaugeRange itemType)
        {
            itemType.SetOwner(Owner);
            if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
            return List.Add(itemType);
        }
        public void Remove(AGaugeRange itemType) { List.Remove(itemType); }
        public void Insert(int index, AGaugeRange itemType)
        {
            itemType.SetOwner(Owner);
            if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
            List.Insert(index, itemType);
        }
        public int IndexOf(AGaugeRange itemType) { return List.IndexOf(itemType); }
        public AGaugeRange FindByName(string name)
        {
            foreach (AGaugeRange ptrRange in List)
            {
                if (ptrRange.Name == name) return ptrRange;
            }
            return null;
        }

        protected override void OnInsert(int index, object value)
        {
            if (string.IsNullOrEmpty(((AGaugeRange)value).Name)) ((AGaugeRange)value).Name = GetUniqueName();
            base.OnInsert(index, value);
            ((AGaugeRange)value).SetOwner(Owner);
        }
        protected override void OnRemove(int index, object value)
        {
            if (Owner != null) Owner.RepaintControl();
        }
        protected override void OnClear()
        {
            if (Owner != null) Owner.RepaintControl();
        }

        private string GetUniqueName()
        {
            const string Prefix = "GaugeRange";
            int index = 1;
            bool valid;
            while (this.Count != 0)
            {
                valid = true;
                for (int x = 0; x < this.Count; x++)
                {
                    if (this[x].Name == (Prefix + index.ToString()))
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid) break;
                index++;
            };
            return Prefix + index.ToString();
        }
    }
    public class AGaugeRange
    {
        public AGaugeRange() { }
        public AGaugeRange(Color color, Single startValue, Single endValue, Int32 innerRadius, Int32 outerRadius)
        {
            Color = color;
            _StartValue = startValue;
            _EndValue = endValue;
            InnerRadius = innerRadius;
            OuterRadius = outerRadius;
        }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Design"),
        System.ComponentModel.DisplayName("(Name)"),
        System.ComponentModel.Description("Instance Name.")]
        public string Name { get; set; }

        [System.ComponentModel.Browsable(false)]
        public Boolean InRange { get; set; }

        private AGauge Owner;
        [System.ComponentModel.Browsable(false)]
        public void SetOwner(AGauge value) { Owner = value; }
        private void NotifyOwner() { if (Owner != null) Owner.RepaintControl(); }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Appearance"),
        System.ComponentModel.Description("The color of the range.")]
        public Color Color { get { return _Color; } set { _Color = value; NotifyOwner(); } }
        private Color _Color;

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Limits"),
        System.ComponentModel.Description("The start value of the range, must be less than RangeEndValue.")]
        public Single StartValue
        {
            get { return _StartValue; }
            set
            {
                if (Owner != null)
                {
                    if (value < Owner.MinValue) value = Owner.MinValue;
                    if (value > Owner.MaxValue) value = Owner.MaxValue;
                }
                _StartValue = value; NotifyOwner();
            }

        }
        private Single _StartValue;

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Limits"),
        System.ComponentModel.Description("The end value of the range. Must be greater than RangeStartValue.")]
        public Single EndValue
        {
            get { return _EndValue; }
            set
            {
                if (Owner != null)
                {
                    if (value < Owner.MinValue) value = Owner.MinValue;
                    if (value > Owner.MaxValue) value = Owner.MaxValue;
                }
                _EndValue = value; NotifyOwner();
            }

        }
        private Single _EndValue;

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Appearance"),
        System.ComponentModel.Description("The inner radius of the range.")]
        public Int32 InnerRadius
        {
            get { return _InnerRadius; }
            set { if (value > 0) { _InnerRadius = value; NotifyOwner(); } }
        }
        private Int32 _InnerRadius = 1;

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Appearance"),
        System.ComponentModel.Description("The outer radius of the range.")]
        public Int32 OuterRadius
        {
            get { return _OuterRadius; }
            set { if (value > 0) { _OuterRadius = value; NotifyOwner(); } }
        }
        private Int32 _OuterRadius = 2;
    }
    #endregion

    #region [ Gauge Label ]
    public class AGaugeLabelCollection : CollectionBase
    {
        private AGauge Owner;
        public AGaugeLabelCollection(AGauge sender) { Owner = sender; }

        public AGaugeLabel this[int index] { get { return (AGaugeLabel)List[index]; } }
        public bool Contains(AGaugeLabel itemType) { return List.Contains(itemType); }
        public int Add(AGaugeLabel itemType)
        {
            itemType.SetOwner(Owner);
            if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
            return List.Add(itemType);
        }
        public void Remove(AGaugeLabel itemType) { List.Remove(itemType); }
        public void Insert(int index, AGaugeLabel itemType)
        {
            itemType.SetOwner(Owner);
            if (string.IsNullOrEmpty(itemType.Name)) itemType.Name = GetUniqueName();
            List.Insert(index, itemType);
        }
        public int IndexOf(AGaugeLabel itemType) { return List.IndexOf(itemType); }
        public AGaugeLabel FindByName(string name)
        {
            foreach (AGaugeLabel ptrRange in List)
            {
                if (ptrRange.Name == name) return ptrRange;
            }
            return null;
        }

        protected override void OnInsert(int index, object value)
        {
            if (string.IsNullOrEmpty(((AGaugeLabel)value).Name)) ((AGaugeLabel)value).Name = GetUniqueName();
            base.OnInsert(index, value);
            ((AGaugeLabel)value).SetOwner(Owner);
        }
        protected override void OnRemove(int index, object value)
        {
            if (Owner != null) Owner.RepaintControl();
        }
        protected override void OnClear()
        {
            if (Owner != null) Owner.RepaintControl();
        }

        private string GetUniqueName()
        {
            const string Prefix = "GaugeLabel";
            int index = 1;
            while (this.Count != 0)
            {
                for (int x = 0; x < this.Count; x++)
                {
                    if (this[x].Name == (Prefix + index.ToString()))
                        continue;
                    else
                        return Prefix + index.ToString();
                }
                index++;
            };
            return Prefix + index.ToString();
        }
    }
    public class AGaugeLabel
    {
        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Design"),
        System.ComponentModel.DisplayName("(Name)"),
        System.ComponentModel.Description("Instance Name.")]
        public string Name { get; set; }

        private AGauge Owner;
        [System.ComponentModel.Browsable(false)]
        public void SetOwner(AGauge value) { Owner = value; }
        private void NotifyOwner() { if (Owner != null) Owner.RepaintControl(); }

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Appearance"),
        System.ComponentModel.Description("The color of the caption text.")]
        public Color Color { get { return _Color; } set { _Color = value; NotifyOwner(); } }
        private Color _Color = Color.FromKnownColor(KnownColor.WindowText);

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Appearance"),
        System.ComponentModel.Description("The text of the caption.")]
        public String Text { get { return _Text; } set { _Text = value; NotifyOwner(); } }
        private String _Text;

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Appearance"),
        System.ComponentModel.Description("The position of the caption.")]
        public Point Position { get { return _Position; } set { _Position = value; NotifyOwner(); } }
        private Point _Position;

        [System.ComponentModel.Browsable(true),
        System.ComponentModel.Category("Appearance"),
        System.ComponentModel.Description("Font of Text.")]
        public Font Font { get { return _Font; } set { _Font = value; NotifyOwner(); } }
        private Font _Font = DefaultFont;

        public void ResetFont() { _Font = DefaultFont; }
        private Boolean ShouldSerializeFont() { return (_Font != DefaultFont); }
        private static Font DefaultFont = System.Windows.Forms.Control.DefaultFont;
    }
    #endregion

    #region [ Gauge Enum ]

    /// <summary>
    /// First needle color
    /// </summary>
    public enum AGaugeNeedleColor
    {
        Gray = 0,
        Red = 1,
        Green = 2,
        Blue = 3,
        Yellow = 4,
        Violet = 5,
        Magenta = 6
    };

    public enum NeedleType
    {
        Advance,
        Simple
    }

    #endregion

    /// <summary>
    /// Event argument for <see cref="ValueInRangeChanged"/> event.
    /// </summary>
    public class ValueInRangeChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Affected GaugeRange
        /// </summary>
        public AGaugeRange Range { get; private set; }
        /// <summary>
        /// Gauge Value
        /// </summary>
        public Single Value { get; private set; }
        /// <summary>
        /// True if value is within current range.
        /// </summary>
        public bool InRange { get; private set; }
        public ValueInRangeChangedEventArgs(AGaugeRange range, Single value, bool inRange)
        {
            this.Range = range;
            this.Value = value;
            this.InRange = inRange;
        }
    }

    [System.Runtime.CompilerServices.CompilerGenerated]
    class NamespaceDoc { } //Namespace Documentation
}
