using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace MarlinEditor
{
    class MarlinMigrateHelper
    {
        public static List<string> FindFirmwareFeatures(FastColoredTextBox fastColoredTextBox)
        {
            List<string> allFeatures = new List<string>();
            List<int> rows = fastColoredTextBox.FindLines(@"\#define", RegexOptions.Singleline);
            foreach (int row in rows)
            {
                string text = fastColoredTextBox.GetLineText(row);
                //Get word after #define featurename
                string feature = Regex.Match(text, @"(?<=\s*\#define\s*)(\w+)", RegexOptions.Singleline).Value;


                if (allFeatures.Contains(feature)) continue;



                allFeatures.Add(feature);
            }

            return allFeatures;

        }





        public static void FixCrLfProblems(string filename)
        {

            if (File.Exists(filename))
            {

                try
                {
                    string allText = File.ReadAllText(filename, Encoding.UTF8);

                    allText = allText.Replace("\r\n", "\n");
                    allText = allText.Replace("\n", "\r\n");
                    allText = allText.Replace("\r\n", "\n");

                    File.WriteAllText(filename, allText);

                }
                catch (Exception writException)
                {
                    MessageBox.Show(@"Cant correct CR/LF on file!" + Environment.NewLine + writException.Message,
                        @"Correcting CR/LF");
                    throw;
                }
            }




        }




        public static string GetFirmwareFeatureValue(FastColoredTextBox fctb, string feauture)
        {
            if (string.IsNullOrEmpty(feauture)) return "";

            string featurevalue = "";
            string row = "";

            List<int> rows = new List<int>();
            rows = fctb.FindLines(@"\s*\#define\s*\b" + feauture + @"\b", RegexOptions.Multiline);

            foreach (int index in rows)
            {
                row = fctb.GetLineText(index).Trim();

                featurevalue = row.Substring(row.IndexOf(feauture, StringComparison.Ordinal));
                featurevalue = featurevalue.Replace(feauture, "");
                if (featurevalue.StartsWith("\""))
                {
                    featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("\"", 1, StringComparison.Ordinal) + 1);
                }

                if (row.StartsWith("#define")) break;
            }


            if (featurevalue.Contains("//")) featurevalue = featurevalue.Substring(0, featurevalue.IndexOf("//", StringComparison.Ordinal)).Trim();

            if (string.IsNullOrEmpty(featurevalue))
            {
                if (row.StartsWith(@"//")) featurevalue = "// Deactivated feature";
                else featurevalue = "// Activated feature";
            }


            return featurevalue.Trim();
        }


        public static void BookmarkChangeNeeded(string feature, FastColoredTextBox fctbCurrentFirmware, FastColoredTextBox fctbNewFirmware)
        {
            // Get the last occurance for the feature in current firmware
            int currentrow = GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
            string currentValue = GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
            string currentLine = fctbCurrentFirmware.GetLineText(currentrow).Trim();

            // Get the last occurance for the feature in new firmware
            int newrow = GetFirmwareFeatureRow(fctbNewFirmware, feature);
            string newValue = GetFirmwareFeatureValue(fctbNewFirmware, feature);
            string newLine = fctbNewFirmware.GetLineText(newrow).Trim();


            if ((newrow == 0) | currentValue != newValue)
            {
                fctbCurrentFirmware.BookmarkLine(currentrow);
                return;

            }

            //if (currentLine.StartsWith("//") && !newLine.StartsWith("//"))
            //{
            //    fctbCurrentFirmware.BookmarkLine(currentrow);
            //    return;
            //}
            //if (!currentLine.StartsWith("//") && newLine.StartsWith("//"))
            //{
            //    fctbCurrentFirmware.BookmarkLine(currentrow);
            //    return;
            //}


            fctbCurrentFirmware.UnbookmarkLine(currentrow);


        }

        public static int GetFirmwareFeatureRow(FastColoredTextBox fctb, string feauture)
        {
            if (string.IsNullOrEmpty(feauture)) return 0;

            string row = "";
            
            List<int> rows = new List<int>();
            rows = fctb.FindLines(@"\s*\#define\s*\b" + feauture + @"\b", RegexOptions.Singleline);

            // return last occurance of feature
            foreach (int index in rows)
            {
                row = fctb.GetLineText(index).Trim();
                if (row.StartsWith("#define")) return index;
            }

            if (rows.Count == 0) return 0;

            return rows[rows.Count - 1];



        }


        public static void UpdateFeatureValue(string feature, string newValue, FastColoredTextBox fctbNewFirmware)
        {

            
            // Get the last occurance for the feature in new firmware
            int currentRow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbNewFirmware, feature);
            string currentValue = MarlinMigrateHelper.GetFirmwareFeatureValue(fctbNewFirmware, feature);
            string correntRow = fctbNewFirmware.GetLineText(currentRow);



           

            
            
            fctbNewFirmware.Navigate(currentRow);
            List<int> removeRow = new List<int>();

            removeRow.Add(currentRow);
            fctbNewFirmware.RemoveLines(removeRow);
            fctbNewFirmware.Navigate(currentRow);
            fctbNewFirmware.InsertText(correntRow.ReplaceFirst(currentValue, newValue) + Environment.NewLine);

           

            fctbNewFirmware.DoAutoIndent(currentRow);
            fctbNewFirmware.DoAutoIndent(currentRow + 1);
        }




        public static void UpdateFeatureValue(string feature, FastColoredTextBox fctbCurrentFirmware, FastColoredTextBox fctbNewFirmware)
        {

            // Get the last occurance for the feature in current firmware
            int currentrow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbCurrentFirmware, feature);
            string currentValue = MarlinMigrateHelper.GetFirmwareFeatureValue(fctbCurrentFirmware, feature);
            string currentLine = fctbCurrentFirmware.GetLineText(currentrow).Trim();

            // Get the last occurance for the feature in new firmware
            int newrow = MarlinMigrateHelper.GetFirmwareFeatureRow(fctbNewFirmware, feature);
            string newValue = MarlinMigrateHelper.GetFirmwareFeatureValue(fctbNewFirmware, feature);
            string newLine = fctbNewFirmware.GetLineText(newrow).Trim();



            if (currentLine.StartsWith("//"))
            {
                if (!newLine.StartsWith("//"))
                {
                    fctbNewFirmware.Navigate(newrow);
                    fctbNewFirmware.CommentSelected("//");

                }
            }
            if (!currentLine.StartsWith("//"))
            {
                if (newLine.StartsWith("//"))
                {
                    fctbNewFirmware.Navigate(newrow);
                    fctbNewFirmware.RemoveLinePrefix("//");
                }
            }

            if (!currentValue.StartsWith("//"))
            {
                string originalLine = fctbNewFirmware.GetLineText(newrow);
                fctbNewFirmware.Navigate(newrow);
                List<int> removeRow = new List<int>();

                removeRow.Add(newrow);
                fctbNewFirmware.RemoveLines(removeRow);
                fctbNewFirmware.Navigate(newrow);
                fctbNewFirmware.InsertText(originalLine.ReplaceFirst(newValue, currentValue) + Environment.NewLine);

            }

            fctbNewFirmware.DoAutoIndent(newrow);
            fctbNewFirmware.DoAutoIndent(newrow + 1);
        }


        public static bool IsFilesEqual(FastColoredTextBox fctbCurrentFirmware, FastColoredTextBox fctbNewFirmware)
        {
            FileInfo first = (FileInfo) fctbCurrentFirmware.Tag;
            FileInfo second = (FileInfo)fctbNewFirmware.Tag;

            const int BYTES_TO_READ = sizeof(Int64);


            // Missing file 
            try
            {
                if (!File.Exists(first.FullName)) return false;
                if (!File.Exists(second.FullName)) return false;

            }
            catch (Exception)
            {

                return false;
            }
            
            
            





            if (first.Length != second.Length) return false;

            int iterations = (int)Math.Ceiling((double)first.Length / BYTES_TO_READ);

            using (FileStream fs1 = first.OpenRead())
            using (FileStream fs2 = second.OpenRead())
            {
                byte[] one = new byte[BYTES_TO_READ];
                byte[] two = new byte[BYTES_TO_READ];

                for (int i = 0; i < iterations; i++)
                {
                    fs1.Read(one, 0, BYTES_TO_READ);
                    fs2.Read(two, 0, BYTES_TO_READ);

                    if (BitConverter.ToInt64(one, 0) != BitConverter.ToInt64(two, 0))
                        return false;
                }
            }

            return true;
        }
        
    }
}
