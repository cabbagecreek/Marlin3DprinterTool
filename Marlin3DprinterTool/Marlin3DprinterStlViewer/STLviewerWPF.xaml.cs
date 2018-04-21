using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using Marlin3DprinterToolConfiguration;


namespace Marlin3DprinterStlViewer
{
    /// <summary>
    /// Interaction logic for STLviewerWPF.xaml
    /// </summary>
    public partial class StlViewerWPF : UserControl
    {
        
        private string modellColor = "Blue";
        /// <summary>
        /// Get and Set current visible 3D models filename
        /// </summary>
        public string Filename { get; set; }


        /// <summary>
        /// Set and Get the color of the 3D model
        /// </summary>
        public string ModelColor
        {
            get { return modellColor;}
            set
            {

                modellColor = value;
                Configuration.GetInstance.StlColor = modellColor;
            }
        }

        



        /// <summary>
        /// STL Viewer
        /// </summary>
        public StlViewerWPF()
        {
            InitializeComponent();
            myViewPort3D.DragEnter += MyViewPort3D_DragEnter;
            myViewPort3D.Drop += MyViewPort3D_Drop;
        }

        private void MyViewPort3D_Drop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            if (files != null)
            {
                foreach (string file in files)
                {
                    ViewNewStl(file);
                    break; // Only the first file. Skip the other
                }
            }
        }

        private void MyViewPort3D_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = (DragDropEffects) System.Windows.Forms.DragDropEffects.Copy;
        }

        /// <summary>
        /// Create a visible model of the STL file
        /// </summary>
        /// <param name="filename">The STL file with full extension</param>
        public void ViewNewStl(string filename)
        {
            
            // WTF!! No file
            if (!File.Exists(filename)) return;

            // Check the file extension to be STL
            FileInfo fileInfo = new FileInfo(filename);
            if (fileInfo.Extension.ToLower() != ".stl") return;

            ModelColor = Configuration.GetInstance.StlColor;

            Filename = filename;

            // Create a model of the STL file

            try
            {
                ModelImporter modellImporter = new ModelImporter
                {
                    DefaultMaterial = new DiffuseMaterial(new SolidColorBrush((Color) ColorConverter.ConvertFromString(modellColor)))
                };
                Model3DGroup model3DGroup = modellImporter.Load(filename);



                StlModel.Content = model3DGroup;


                myViewPort3D.CameraController.ResetCamera();
                myViewPort3D.CameraController.ZoomExtents(0);

            }
            catch (Exception e)
            {
                Debug.WriteLine($"modelimporter crash {e.Message}");
            }

            


        }

    }
}
    
