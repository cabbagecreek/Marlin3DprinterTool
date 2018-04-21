using System.IO;
using System.Windows.Forms;
using Marlin3DprinterToolConfiguration;

namespace Marlin3DprinterStlViewer
{
    /// <summary>
    /// STL viewer based on HelixToolkit
    /// </summary>
    public partial class FrmStlViewer : Form
    {
       
        

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmStlViewer()
        {
            InitializeComponent();
            
            
        }

        /// <summary>
        /// Show window with filename of STL
        /// </summary>
        /// <param name="filename"></param>
        public FrmStlViewer(string filename)
        {
            Filename = filename;
            InitializeComponent();
            
        }


        /// <summary>
        /// Filename of file that is visible
        /// </summary>
        public string Filename { get; internal set; }

        private void FrmStlViewer_DragDrop(object sender, DragEventArgs e)
        {
            //stLviewerWPF1.ModelColor = configuration.STLcolor;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                stLviewerWPF1.ModelColor = Configuration.GetInstance.StlColor;
                stLviewerWPF1.ViewNewStl(file);
                break; // Only the first file. Skip the other
            }

        }

        private void FrmStlViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void FrmStlViewer_Load(object sender, System.EventArgs e)
        {
            if (File.Exists(Filename))
            {
                stLviewerWPF1.ModelColor = Configuration.GetInstance.StlColor;
                stLviewerWPF1.ViewNewStl(Filename);
            }
        }

       
    }
}
