using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marlin3DprinterStlViewer
{
    public partial class FrmStlViewer : Form
    {
        public FrmStlViewer()
        {
            InitializeComponent();
            
            
        }

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
    }
}
