using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Marlin3DprinterToolUserControls
{
    public class FirmwareHelper
    {
        #region Properties
        private string _fileName;
        private readonly FastColoredTextBox _fctbFirmware = new FastColoredTextBox();

        public string FileName
        {
            set
            {
                _fileName = value;

                if (_fileName != null && File.Exists(_fileName))
                {
                    _fctbFirmware.OpenFile(_fileName);
                }
                

            }
            get { return _fileName; }
        }
        #endregion



        public string GetEnabledFeature(string feature)
        {
            // Get the last occurance for the feature in new firmware
            int row = GetFirmwareFeatureRow(feature);
            if (row == -1) return null;
            string currentRow = _fctbFirmware.GetLineText(row);


            
            Regex rgx = new Regex(@"^[ ,\t]*//", RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(currentRow);
            return matches.Count > 0 ? false.ToString() : true.ToString();


               

        }

        

        public string GetFeatureValue(string feature)
        {
            // Get the last occurance for the feature in new firmware
            int row = GetFirmwareFeatureRow(feature);
            if (row == -1) return null;


            Debug.WriteLine("---- GetFeatureValue ---------------------------------------");
            string currentRow = _fctbFirmware.GetLineText(row);

            Debug.WriteLine(currentRow);

            var featurevalue = currentRow.Substring(currentRow.IndexOf(feature, StringComparison.Ordinal));
            featurevalue = featurevalue.Replace(feature, "");

            


            if (featurevalue.Contains(@"//")) featurevalue = featurevalue.Substring(0, featurevalue.IndexOf(@"//", StringComparison.Ordinal)).Trim();
            Debug.WriteLine(featurevalue.Trim());


            return featurevalue.Trim();



           



        }

        

        public void SetFeatureValue(string feature, string newValue, bool enabled)
        {
            // Get the last occurance for the feature in new firmware
            int row = GetFirmwareFeatureRow(feature);
            string currentRow = _fctbFirmware.GetLineText(row);
            string currentValue = GetFeatureValue(feature);
            string comment = GetComment(feature);
            string whitespace = GetWhitespace(feature);

            _fctbFirmware.Navigate(row);
            List<int> removeRow = new List<int> { row };

            Debug.WriteLine("---- SetFeatureValue ---------------------------------------");
            Debug.WriteLine($"    Row: {currentRow} Value: {currentValue}");
            _fctbFirmware.RemoveLines(removeRow);
            _fctbFirmware.Navigate(row);

            String enabledStr = enabled ? "" : "// ";
            string newFeatureValue = $"{whitespace}{enabledStr}#define {feature} {newValue} {comment}";


            _fctbFirmware.InsertText(newFeatureValue + Environment.NewLine);
            Debug.WriteLine($"New row: {newFeatureValue}");
            Debug.WriteLine("");

            Save();



        }

        private string GetWhitespace(string feature)
        {
            // Get the last occurance for the feature in new firmware
            int row = GetFirmwareFeatureRow(feature);
            string currentRow = _fctbFirmware.GetLineText(row);


            string whitespace = "";


            for (int i = 0; i < currentRow.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(currentRow.Substring(i, 1)))
                {
                    whitespace += currentRow.Substring(i, 1);
                }
                else break;
            }

            return whitespace;

        }

        public void SetFeatureValue(string feature, string newValue)
        {
            SetFeatureValue(feature, newValue, true);
        }

        public void SetFeatureValue(string feature, bool enabled)
        {
            SetFeatureValue(feature, "", enabled);        
        }


        public string GetComment(string feature)
        {
            // Get the last occurance for the feature in new firmware
            int row = GetFirmwareFeatureRow(feature);
            string enabled = this.GetEnabledFeature(feature);
            string currentRow = _fctbFirmware.GetLineText(row);
            string currentValue = GetFeatureValue(feature);
            
            string comment = currentRow.Trim();
            comment = comment.TrimStart('/',' ', '\t');
            comment = comment.Replace("#define", "");
            if (!string.IsNullOrEmpty(currentValue))
            {
                comment = comment.Replace(currentValue,"");
            }
            comment = comment.Replace(feature, "");
            comment = comment.Trim();


            return comment;
        }

        

        



        private void Save()
        {
            if (File.Exists(FileName) && FileName != null)
            {
                try
                {
                    _fctbFirmware.SaveToFile(FileName, Encoding.UTF8);
                }
                catch (Exception e)
                {
                    MessageBox.Show(@"Error while updating Marlin Firmware." + Environment.NewLine + Environment.NewLine +
                                    @"Error: " + e.Message, @"Update Marlin Firmware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        

        public int GetFirmwareFeatureRow( string feature)
        {

            if (string.IsNullOrEmpty(feature)) return -1;

            List<int> rows = new List<int>();
            //rows = _fctbFirmware.FindLines( @"\#define\s*\b" + feature + @"\b", RegexOptions.Singleline);
            string pattern = $@"^(\s*//\s*|\s*)\#define\s*\b{feature}\b";
            rows = _fctbFirmware.FindLines(pattern, RegexOptions.Singleline);

            // return last occurance of feature
            Debug.WriteLine("---- GetFirmwareFeatureRow ---------------------------------------------");
            foreach (int index in rows)
            {
                var row = _fctbFirmware.GetLineText(index);
                //if (row.StartsWith("#define")) return index;

                Regex rgx = new Regex(@"\s*\#define", RegexOptions.IgnoreCase);
                MatchCollection matches = rgx.Matches(row);
                if (matches.Count > 0)
                {
                    Debug.WriteLine($"Found row: {index} {row}");
                    return index;
                }

            }

            if (rows.Count == 0)
            {
                Debug.WriteLine("No row found. Return -1");
                return -1;
            }

            var lastrow = _fctbFirmware.GetLineText(rows[rows.Count - 1]);
            Debug.WriteLine($"No enabled {feature} found. Last disabled row choosen: {lastrow}");
            return rows[rows.Count - 1];



        }



        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            IEnumerable<Control> controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }
       

        public void UpdateNewFirmware(Form form, string oldfilename, string newFilename)
        {



            FirmwareHelper newFirmwareHelper = new FirmwareHelper {FileName = newFilename};

            FirmwareHelper currentFirmwareHelper = new FirmwareHelper {FileName = oldfilename};




            IEnumerable<Control> marlinCheckBox = GetAll(form, typeof(MarlinCheckBox));
            foreach (var marlinControl in marlinCheckBox)
            {
                var control = (MarlinCheckBox)marlinControl;
                control.NewFirmwareHelper = newFirmwareHelper;
                control.currentFirmwareHelper = currentFirmwareHelper;
                WebBrowser save = control.HelpWebBrowser;
                control.HelpWebBrowser = null;
                control.UpdateStatus();
                control.HelpWebBrowser = save;
            }

            IEnumerable<Control> marlinComboBox = GetAll(form, typeof(MarlinComboBox));
            foreach (var marlinControl in marlinComboBox)
            {
                var control = (MarlinComboBox)marlinControl;
                control.NewFirmwareHelper = newFirmwareHelper;
                control.currentFirmwareHelper = currentFirmwareHelper;
                WebBrowser save = control.HelpWebBrowser;
                control.HelpWebBrowser = null;
                control.UpdateStatus();
                control.HelpWebBrowser = save;
            }

            IEnumerable<Control> marlinEnableValue = GetAll(form, typeof(MarlinEnableValue));
            foreach (var marlinControl in marlinEnableValue)
            {
                var control = (MarlinEnableValue)marlinControl;
                control.NewFirmwareHelper = newFirmwareHelper;
                control.currentFirmwareHelper = currentFirmwareHelper;
                WebBrowser save = control.HelpWebBrowser;
                control.HelpWebBrowser = null;
                control.UpdateStatus();
                control.HelpWebBrowser = save;
            }

            IEnumerable<Control> marlinUpDn = GetAll(form, typeof(MarlinUpDn));
            foreach (var marlinControl in marlinUpDn)
            {
                var control = (MarlinUpDn)marlinControl;
                control.NewFirmwareHelper = newFirmwareHelper;
                control.currentFirmwareHelper = currentFirmwareHelper;
                WebBrowser save = control.HelpWebBrowser;
                control.HelpWebBrowser = null;
                control.UpdateStatus();
                control.HelpWebBrowser = save;
            }

            IEnumerable<Control> marlinValue = GetAll(form, typeof(MarlinValue));
            foreach (var marlinControl in marlinValue)
            {
                var control = (MarlinValue)marlinControl;
                control.NewFirmwareHelper = newFirmwareHelper;
                control.currentFirmwareHelper = currentFirmwareHelper;
                WebBrowser save = control.HelpWebBrowser;
                control.HelpWebBrowser = null;
                control.UpdateStatus();
                control.HelpWebBrowser = save;
            }


            

            




        }

        public List<ComboboxItem> GetLanguages()
        {
            List<ComboboxItem> returnComboboxItems = new List<ComboboxItem>
            {
                new ComboboxItem {Value = "an", Text = "(an)        Aragonese"},
                new ComboboxItem {Value = "bg", Text = "(bg)        Bulgarian"},
                new ComboboxItem {Value = "ca", Text = "(ca)        Catalan"},
                new ComboboxItem {Value = "cn", Text = "(cn)        Chinese"},
                new ComboboxItem {Value = "cz", Text = "(cz)        Czech"},
                new ComboboxItem {Value = "de", Text = "(de)        German"},
                new ComboboxItem {Value = "el", Text = "(el)        Greek"},
                new ComboboxItem {Value = "el-gr", Text = "(el-gr)     Greek (Greece)"},
                new ComboboxItem {Value = "en", Text = "(en)        English (Default)"},
                new ComboboxItem {Value = "es", Text = "(es)        Spanish"},
                new ComboboxItem {Value = "eu", Text = "(eu)        Basque-Euskera"},
                new ComboboxItem {Value = "fi", Text = "(fi)        Finnish"},
                new ComboboxItem {Value = "fr", Text = "(fr)        French"},
                new ComboboxItem {Value = "gl", Text = "(gl)        Galician"},
                new ComboboxItem {Value = "hr", Text = "(hr)        Croatian"},
                new ComboboxItem {Value = "it", Text = "(it)        Italian"},
                new ComboboxItem {Value = "kana", Text = "(kana)      Japanese"},
                new ComboboxItem {Value = "kana_utf8", Text = "(kana_utf8) Japanese (UTF8)"},
                new ComboboxItem {Value = "nl", Text = "(nl)        Dutch"},
                new ComboboxItem {Value = "pl", Text = "(pl)        Polish"},
                new ComboboxItem {Value = "pt", Text = "(pt)        Portuguese"},
                new ComboboxItem {Value = "pt-br", Text = "(pt-br)     Portuguese (Brazilian)"},
                new ComboboxItem {Value = "pt_utf8", Text = "(pt_utf8)   Portuguese (UTF8)"},
                new ComboboxItem {Value = "ru", Text = "(ru)        Russian"},
                new ComboboxItem {Value = "tr", Text = "(tr)        Turkish"},
                new ComboboxItem {Value = "uk", Text = "(uk)        Ukrainian"}
            };



            return returnComboboxItems;

        }

        public List<ComboboxItem> GetHD44780Charset()
        {
            List<ComboboxItem> returnComboboxItems =
                new List<ComboboxItem>
                {
                    new ComboboxItem {Value = "JAPANESE", Text = "JAPANESE"},
                    new ComboboxItem {Value = "WESTERN", Text = "WESTERN"},
                    new ComboboxItem {Value = "CYRILLIC", Text = "CYRILLIC"}
                };

            return returnComboboxItems;

        }


        public List<ComboboxItem> GetTempSensors()
        {
            List<ComboboxItem> returnComboboxItems = new List<ComboboxItem>
            {
                new ComboboxItem {Value = "-3", Text = "(-3)   Thermocouple with MAX31855(only for sensor 0)"},
                new ComboboxItem {Value = "-2", Text = "(-2)   Thermocouple with MAX6675(only for sensor 0)"},
                new ComboboxItem {Value = "-1", Text = "(-1)   Thermocouple with AD595"},
                new ComboboxItem {Value = "0", Text = "(0)    Not used"},
                new ComboboxItem {Value = "1", Text = "(1)    100k thermistor -best choice for EPCOS 100k(4.7k pullup)"},
                new ComboboxItem {Value = "2", Text = "(2)    200k thermistor - ATC Semitec 204GT - 2(4.7k pullup)"},
                new ComboboxItem {Value = "3", Text = "(3)    Mendel - parts thermistor(4.7k pullup)"},
                new ComboboxItem {Value = "4",Text ="(4)    10k thermistor !! do not use it for a hotend. It gives bad resolution at high temp. !!"},
                new ComboboxItem {Value = "5",Text = "(5)    100K thermistor - ATC Semitec 104GT - 2(Used in ParCan & J - Head)(4.7k pullup)"},
                new ComboboxItem {Value = "6",Text ="(6)    100k EPCOS - Not as accurate as table 1(created using a fluke thermocouple) (4.7k pullup)"},
                new ComboboxItem {Value = "7",Text = "(7)    100k Honeywell thermistor 135 - 104LAG - J01(4.7k pullup)"},
                new ComboboxItem {Value = "71",Text = "(71)   100k Honeywell thermistor 135 - 104LAF - J01(4.7k pullup)"},
                new ComboboxItem {Value = "8", Text = "(8)    100k 0603 SMD Vishay NTCS0603E3104FXT(4.7k pullup)"},
                new ComboboxItem {Value = "9", Text = "(9)    100k GE Sensing AL03006-58.2K - 97 - G1(4.7k pullup)"},
                new ComboboxItem {Value = "10", Text = "(10)   100k RS thermistor 198 - 961(4.7k pullup)"},
                new ComboboxItem {Value = "11", Text = "(11)   100k beta 3950 1 % thermistor(4.7k pullup)"},
                new ComboboxItem {Value = "12",Text = "(12)   100k 0603 SMD Vishay NTCS0603E3104FXT(4.7k pullup)(calibrated for Makibox hot bed)"},
                new ComboboxItem {Value = "13",Text = "(13)   100k Hisens 3950  1 % up to 300°C for hotend Simple ONE  & Hotend All In ONE"},
                new ComboboxItem {Value = "20", Text = "(20)   The PT100 circuit found in the Ultimainboard V2.x"},
                new ComboboxItem {Value = "60",Text = "(60)   100k Maker's Tool Works Kapton Bed Thermistor beta=3950"},
                new ComboboxItem {Value = "66", Text = "(66)   4.7M High Temperature thermistor from Dyze Design"},
                new ComboboxItem {Value = "70", Text = "(70)   The 100K thermistor found in the bq Hephestos 2"},
                new ComboboxItem {Value = "75",Text = "(75)   100k Generic Silicon Heat Pad with NTC 100K MGB18 - 104F39050L32 thermistor"},
                new ComboboxItem {Value = "51", Text = "(51)   100k thermistor -EPCOS(1k pullup)"},
                new ComboboxItem {Value = "52", Text = "(52)   200k thermistor -ATC Semitec 204GT - 2(1k pullup)"},
                new ComboboxItem {Value = "55",Text = "(55)   100k thermistor -ATC Semitec 104GT - 2(Used in ParCan & J - Head)(1k pullup)"},
                new ComboboxItem {Value = "1047", Text = "(1047) Pt1000 with 4k7 pullup"},
                new ComboboxItem {Value = "1010", Text = "(1010) Pt1000 with 1k pullup(non standard)"},
                new ComboboxItem {Value = "147", Text = "(147)  Pt100 with 4k7 pullup"},
                new ComboboxItem {Value = "110", Text = "(110)  Pt100 with 1k pullup(non standard)"},
                new ComboboxItem {Value = "998",Text = "(998)  Dummy Table that ALWAYS reads 25°C or the temperature defined below."},
                new ComboboxItem {Value = "999",Text = "(999)  Dummy Table that ALWAYS reads 100°C or the temperature defined below."
                }
            };







            return returnComboboxItems;
        }



        public List<ComboboxItem> GetAllBoards()
        {
            


            List<ComboboxItem> returnComboboxItems = new List<ComboboxItem>();


            FastColoredTextBox fctbBoards = new FastColoredTextBox();

            // The the board.h

            string boardPath = Path.GetDirectoryName(FileName);
            if (boardPath != null)
            {
                boardPath = Path.Combine(boardPath, "boards.h");
            }
            if (File.Exists(boardPath))
            {
                fctbBoards.OpenFile(boardPath);

                List<int> rows = fctbBoards.FindLines(@"#define\s*BOARD_[A-Z,0-9,_]*\s*[0-9]*\s*//\s*.*", RegexOptions.IgnoreCase);

                foreach (int row in rows)
                {
                    string board = fctbBoards.GetLineText(row);



                    string value = Regex.Match(board, @"(?<=#define\s*)BOARD_[A-Z,0-9,_]*").Value;
                    string text = Regex.Match(board, @"(?<=#define\s*BOARD_[A-Z,0-9,_]*\s*[0-9]*\s*//\s*).*").Value;

                    if (value != "")
                    {
                        ComboboxItem item = new ComboboxItem
                        {
                            Text = text,
                            Value = value
                        };

                        returnComboboxItems.Add(item);
                    }

                }

            }

            return returnComboboxItems;


        }

        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }


        public bool IsFeatureValueNumbers(string value)
        {
            return  Regex.IsMatch(value, @"^[\d,.,\,,\+,\-]+$");


        }

        

    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    

    public static class StringExtension
    {
        public static string ReplaceFirst(this string text, string search, string replace)
        {

            try
            {
                int pos = text.IndexOf(search, StringComparison.Ordinal);
                if (pos < 0)
                {
                    return text;
                }

                string firstPart = text.Substring(0, pos);
                string lastPart = text.Substring(pos + search.Length);

                return firstPart + replace + lastPart;
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Cant replace! Something is wrong. Do the change manually." + Environment.NewLine +
                                e.Message);
                return text;
            }

            
        }
    }

    





}
