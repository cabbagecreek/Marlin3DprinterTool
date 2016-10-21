using System.IO;
using System.Windows.Forms;

namespace Marlin3DprinterStlViewer
{
    public partial class FrmStlViewer : Form
    {
        
        public FrmStlViewer()
        {
            InitializeComponent();
            
            
        }

        public FrmStlViewer(string filename)
        {
            Filename = filename;
            InitializeComponent();
            
        }

        public string Filename { get; internal set; }

        private void FrmStlViewer_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
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
                stLviewerWPF1.ViewNewStl(Filename);
            }
        }
    }
}
