using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FastColoredTextBoxNS;
using MarlinComunicationHelper;
using Cursor = System.Windows.Forms.Cursor;

namespace Marlin3DprinterTool
{
    /// <summary>
    ///     All Delegates And Invokes thats needed because the cross-threding created by Asyncon Serial communication
    /// </summary>
    public class DelegateAndInvoke
    {
        /// <summary>
        /// </summary>
        private static FrmMarlin3DprinterTool _frm3DprinterTool;


        /// <summary>
        /// </summary>
        /// <param name="frm3DprinterTool"></param>
        public DelegateAndInvoke(FrmMarlin3DprinterTool frm3DprinterTool)
        {
            _frm3DprinterTool = frm3DprinterTool;
        }

        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="visible"></param>
        public static void DelegateVisible(Control control, bool visible)
        {
            if (control.InvokeRequired)
            {
                DelegateVisibleCallback d = DelegateVisible;
                _frm3DprinterTool.Invoke(d, control, visible);
            }
            else
            {
                control.Visible = visible;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="kompass"></param>
        /// <param name="marlin"></param>
        public static void DelegateKompassControll(KompassControll kompass, MarlinCommunication marlin)
        {
            if (kompass.InvokeRequired)
            {
                DelegateKompassControllCallback d = DelegateKompassControll;
                _frm3DprinterTool.Invoke(d, kompass, marlin);
            }
            else
            {
                kompass.MarlinCommunication = marlin;
            }
        }

        

        /// <summary>
        /// </summary>
        /// <param name="verticalJogControl"></param>
        /// <param name="marlin"></param>
        public static void DelegateVerticalJogControl(VerticalJogControl verticalJogControl, MarlinCommunication marlin)
        {
            if (verticalJogControl.InvokeRequired)
            {
                DelegateVerticalJogControlCallback d = DelegateVerticalJogControl;
                _frm3DprinterTool.Invoke(d, verticalJogControl, marlin);
            }
            else
            {
                verticalJogControl.MarlinCommunication = marlin;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="enabled"></param>
        public static void DelegateEnabled(Control control, bool enabled)
        {
            if (control.InvokeRequired)
            {
                DelegateEnabledCallback d = DelegateEnabled;
                _frm3DprinterTool.Invoke(d, control, enabled);
            }
            else
            {
                control.Enabled = enabled;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="image"></param>
        public static void DelegateBackgroundImage(Control control, Image image)
        {
            if (control.InvokeRequired)
            {
                DelegateBackgroundImageCallback d = DelegateBackgroundImage;
                _frm3DprinterTool.Invoke(d, control, image);
            }
            else
            {
                control.BackgroundImage = image;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="tabControl"></param>
        /// <param name="enable"></param>
        public void DisableTabs(TabControl tabControl, bool enable)
        {
            if (tabControl.InvokeRequired)
            {
                DisableTabsCallback d = DisableTabs;
                _frm3DprinterTool.Invoke(d, tabControl, enable);
            }
            else
            {
                foreach (TabPage tabPage in tabControl.TabPages)
                {
                    tabPage.Enabled = enable;




                }
            }
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public static string TabControl3DprinterToolSelected(TabControl tabControl)
        {
            if (tabControl.InvokeRequired)
            {
                TabControl3DprinterToolSelectedCallback d = TabControl3DprinterToolSelected;

                return (string) tabControl.Invoke(d, tabControl);
            }

            return tabControl.SelectedTab.Name;
        }

        /// <summary>
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="text"></param>
        public void TextBoxAdd(TextBox textbox, string text)
        {
            if (textbox.InvokeRequired)
            {
                TextBoxAddCallback d = TextBoxAdd;
                _frm3DprinterTool.Invoke(d, textbox, text);
            }
            else
            {
                textbox.Text += text;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="text"></param>
        public static void DelegateText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                DelegateTextCallback d = DelegateText;
                _frm3DprinterTool.Invoke(d, control, text);
            }
            else
            {
                control.Text = text;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="responce"></param>
        public static void MultiTextLines(TextBox textBox, List<string> responce)
        {
            if (textBox.InvokeRequired)
            {
                MultiTextLinesCallback d = MultiTextLines;
                _frm3DprinterTool.Invoke(d, textBox, responce);
            }
            else
            {
                textBox.Lines = responce.ToArray();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="fastColoredTextBox"></param>
        /// <param name="responces"></param>
        public static void FastColoredTextBox(FastColoredTextBox fastColoredTextBox, List<string> responces)
        {
            if (fastColoredTextBox.InvokeRequired)
            {
                FastColoredTextBoxCallback d = FastColoredTextBox;
                _frm3DprinterTool.Invoke(d, fastColoredTextBox, responces);
            }
            else
            {
                fastColoredTextBox.Clear();
                string textLines = "";

                foreach (string responce in responces)
                {
                    textLines += responce + Environment.NewLine;
                }
                fastColoredTextBox.Text = textLines;


            }
        }

        /// <summary>
        /// </summary>
        /// <param name="fastColoredTextBox"></param>
        /// <param name="text"></param>
        public static void FastColoredTextBox(FastColoredTextBox fastColoredTextBox, string text)
        {
            if (fastColoredTextBox.InvokeRequired)
            {
                FastColoredTextBoxCallbackText d = FastColoredTextBox;
                _frm3DprinterTool.Invoke(d, fastColoredTextBox, text);
            }
            else
            {
                fastColoredTextBox.Clear();
                fastColoredTextBox.Text = text;


            }
        }




        /// <summary>
        /// Scroll to row in FCTB
        /// </summary>
        /// <param name="fastColoredTextBox"></param>
        /// <param name="row"></param>
        public static void ScrollTo(FastColoredTextBox fastColoredTextBox, int row)
        {
            if (fastColoredTextBox.InvokeRequired)
            {
                ScrollToCallback d = ScrollTo;
                _frm3DprinterTool.Invoke(d, fastColoredTextBox, row);
            }
            else
            {
                fastColoredTextBox.Navigate(Math.Min(fastColoredTextBox.LinesCount, row));
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="time"></param>
        /// <param name="extruderTemp"></param>
        /// <param name="setExtruderTemp"></param>
        public static void SetExtruderTemp(Chart chart, int time, int extruderTemp, int setExtruderTemp)
        {
            if (chart.InvokeRequired)
            {
                SetExtruderTempCallback d = SetExtruderTemp;
                _frm3DprinterTool.Invoke(d, chart, time, extruderTemp, setExtruderTemp);
            }
            else
            {

                if (chart.Series.IndexOf("Extruder") != -1)
                {
                    if (chart.Series["Extruder"].Points.Count >= 21)
                    {
                        chart.Series["Extruder"].Points.RemoveAt(0);
                    }

                }


                if (chart.Series.IndexOf("SetExtruder") != -1)
                {
                    if (chart.Series["SetExtruder"].Points.Count >= 21)
                    {
                        chart.Series["SetExtruder"].Points.RemoveAt(0);
                    }
                }


                
                if (chart.Series.IndexOf("Bed") != -1)
                {
                    if (chart.Series["Bed"].Points.Count >= 21)
                    {
                        chart.Series["Bed"].Points.RemoveAt(0);
                    }
                }

                if (chart.Series.IndexOf("SetBed") != -1)
                {
                    if (chart.Series["SetBed"].Points.Count >= 21)
                    {
                        chart.Series["SetBed"].Points.RemoveAt(0);
                    }
                }

                int minAxisX = 200;
                int maxAxisX = 0;

                if (chart.Series.IndexOf("Bed") != -1)
                {
                    foreach (DataPoint dataPoint in chart.Series["Bed"].Points)
                    {
                        minAxisX = (int) Math.Min(minAxisX, dataPoint.XValue - 10);
                        maxAxisX = (int) Math.Max(maxAxisX, dataPoint.XValue + 10);
                    }
                }
                if (chart.Series.IndexOf("SetBed") != -1)
                {
                    foreach (DataPoint dataPoint in chart.Series["SetBed"].Points)
                    {
                        minAxisX = (int) Math.Min(minAxisX, dataPoint.XValue - 10);
                        maxAxisX = (int) Math.Max(maxAxisX, dataPoint.XValue + 10);
                    }
                }
                if (chart.Series.IndexOf("Extruder") != -1)
                {
                    foreach (DataPoint dataPoint in chart.Series["Extruder"].Points)
                    {
                        minAxisX = (int) Math.Min(minAxisX, dataPoint.XValue - 10);
                        maxAxisX = (int) Math.Max(maxAxisX, dataPoint.XValue + 10);
                    }
                }
                if (chart.Series.IndexOf("SetExtruder") != -1)
                {
                    foreach (DataPoint dataPoint in chart.Series["SetExtruder"].Points)
                    {
                        minAxisX = (int) Math.Min(minAxisX, dataPoint.XValue - 10);
                        maxAxisX = (int) Math.Max(maxAxisX, dataPoint.XValue + 10);
                    }
                }

                





                var area = chart.ChartAreas[0];
                area.AxisX.Maximum = time;
                area.AxisX.Minimum = Math.Max(0, time - 20);
                if (chart.Series.IndexOf("Extruder") != -1)
                {
                    if (extruderTemp > 0)
                        chart.Series["Extruder"].Points.AddXY(time, extruderTemp);
                }

                if (chart.Series.IndexOf("SetExtruder") != -1)
                {
                    if (setExtruderTemp > 0)
                        chart.Series["SetExtruder"].Points.AddXY(time, setExtruderTemp);
                }






                //TODO: 
                // area.AxisX.IntervalType = DateTimeIntervalType.Seconds;

                chart.ResetAutoValues();
                chart.ChartAreas[0].AxisX.Maximum = maxAxisX;
                chart.ChartAreas[0].AxisX.Minimum = minAxisX;

            }
        }

        /// <summary>
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="time"></param>
        /// <param name="bedTemp"></param>
        /// <param name="setBedTemp"></param>
        public static void SetBedTemp(Chart chart, int time, int bedTemp, int setBedTemp)
        {
            if (chart.InvokeRequired)
            {
                SetBedTempCallback d = SetBedTemp;
                _frm3DprinterTool.Invoke(d, chart, time, bedTemp, setBedTemp);
            }
            else
            {
                if (chart.Series.IndexOf("Extruder") != -1)
                {
                    if (chart.Series["Extruder"].Points.Count >= 21)
                    {
                        chart.Series["Extruder"].Points.RemoveAt(0);
                    }
                }
                if (chart.Series.IndexOf("SetExtruder") != -1)
                {
                    if (chart.Series["SetExtruder"].Points.Count >= 21)
                    {
                        chart.Series["SetExtruder"].Points.RemoveAt(0);
                    }
                }
                if (chart.Series.IndexOf("Bed") != -1)
                {
                    if (chart.Series["Bed"].Points.Count >= 21)
                    {
                        chart.Series["Bed"].Points.RemoveAt(0);
                    }
                }
                if (chart.Series.IndexOf("SetBed") != -1)
                {
                    if (chart.Series["SetBed"].Points.Count >= 21)
                    {
                        chart.Series["SetBed"].Points.RemoveAt(0);
                    }
                }

                var area = chart.ChartAreas[0];
                area.AxisX.Maximum = time;
                area.AxisX.Minimum = Math.Max(0, time - 20);
                if (chart.Series.IndexOf("Bed") != -1)
                {
                    if (bedTemp > 0)
                        chart.Series["Bed"].Points.AddXY(time, bedTemp);
                }
                if (chart.Series.IndexOf("SetBed") != -1)
                {
                    if (setBedTemp > 0)
                        chart.Series["SetBed"].Points.AddXY(time, setBedTemp);
                    area.AxisX.IntervalType = DateTimeIntervalType.Seconds;
                }
                chart.ResetAutoValues();
            }
        }

        

        /// <summary>
        /// Select a tab
        /// </summary>
        /// <param name="tabControl3DprinterTool"></param>
        /// <param name="tabPage"></param>
        public static void SelectTabcontrol(TabControl tabControl3DprinterTool, TabPage tabPage)
        {
            if (tabControl3DprinterTool.InvokeRequired)
            {
                SelectTabcontrolCallback d = SelectTabcontrol;
                _frm3DprinterTool.Invoke(d, tabControl3DprinterTool, tabPage);
            }
            else
            {
                tabControl3DprinterTool.SelectedTab = tabPage;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tabControl3DprinterTool"></param>
        /// <returns></returns>
        public static TabPage GetSelectedTab(TabControl tabControl3DprinterTool)
        {
            if (tabControl3DprinterTool.InvokeRequired)
            {
                GetSelectedTabCallback d = GetSelectedTab;
                _frm3DprinterTool.Invoke(d, tabControl3DprinterTool);
            }
            else
            {
                return tabControl3DprinterTool.SelectedTab;

            }
            return null;
        }



        /// <summary>
        /// Change the cursor
        /// </summary>
        /// <param name="cursorType"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static void Cursor(Cursor cursorType)
        {
            if (_frm3DprinterTool.InvokeRequired)
            {
                CursorCallback d = Cursor;
                try{_frm3DprinterTool.Invoke(d, cursorType);} catch (Exception){}
            }
            else
            {
                try{_frm3DprinterTool.Cursor = cursorType; } catch (Exception) { }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="verticalJogControl"></param>
        /// <param name="communication"></param>
        public static void VerticalJogControl(VerticalJogControl verticalJogControl, MarlinCommunication communication)
        {
            if (verticalJogControl.InvokeRequired)
            {
                VerticalJogControlCallback d = VerticalJogControl;
                _frm3DprinterTool.Invoke(d, verticalJogControl, communication);
            }
            else
            {
                verticalJogControl.MarlinCommunication = communication;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="kompassControl"></param>
        /// <param name="communication"></param>
        public static void KompassControl(KompassControll kompassControl, MarlinCommunication communication)
        {
            if (kompassControl.InvokeRequired)
            {
                KompassControlCallback d = KompassControl;
                _frm3DprinterTool.Invoke(d, kompassControl, communication);
            }
            else
            {
                kompassControl.MarlinCommunication = communication;
            }
        }




        // Delegate
        private delegate void DelegateVerticalJogControlCallback(
            VerticalJogControl verticalJogControl, MarlinCommunication marlin);

        private delegate void DelegateKompassControllCallback(KompassControll kompass, MarlinCommunication marlin);

        private delegate void DelegateEnabledCallback(Control control, bool enabled);

        private delegate void DelegateVisibleCallback(Control control, bool visible);

        private delegate void DelegateBackgroundImageCallback(Control control, Image image);

        private delegate void DisableTabsCallback(TabControl tabControl, bool enable);

        private delegate void DelegateTextCallback(Control control, string text);

        private delegate void TextBoxAddCallback(TextBox textbox, string text);

        private delegate void MultiTextLinesCallback(TextBox textBox, List<string> responce);

        private delegate void FastColoredTextBoxCallback(FastColoredTextBox marlinSyntaxTextBox, List<string> responces);

        private delegate void FastColoredTextBoxCallbackText(FastColoredTextBox marlinSyntaxTextBox, string text);

        private delegate void SetBedTempCallback(Chart chart, int time, int bedTemp, int setBedTemp);

        private delegate void SetExtruderTempCallback(Chart chart, int time, int extruderTemp, int setExtruderTemp);

        private delegate string TabControl3DprinterToolSelectedCallback(TabControl tabControl);

        //TODO: TABORT private delegate void TabPageEnableCallback(TabPage tabPage, bool enable);

        private delegate void ScrollToCallback(FastColoredTextBox marlinSyntaxTextBox, int row);

        private delegate void SelectTabcontrolCallback(TabControl tabControl3DprinterTool, TabPage tabPage);

        private delegate TabPage GetSelectedTabCallback(TabControl tabControl);

        private delegate void CursorCallback(Cursor cursorType);

        private delegate void VerticalJogControlCallback(VerticalJogControl verticalJogControl, MarlinCommunication communication);

        private delegate void KompassControlCallback(KompassControll kompassControl, MarlinCommunication communication);

        //!Delegate


    }
}