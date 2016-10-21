using System;
using System.IO;
using System.Windows.Forms;

namespace Marlin3DprinterStlViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (args.Length == 0)
            {
                Application.Run(new FrmStlViewer());
            }
            else
            {
                if (File.Exists(args[0]))
                {
                    Application.Run(new FrmStlViewer(args[0]));
                }
                else
                {
                    Application.Run(new FrmStlViewer());
                }
            }
            
        }
    }
}
