using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using MarlinComunicationHelper;
using Microsoft.Win32;
using SharpShell.Attributes;
using SharpShell.SharpThumbnailHandler;
using Brush = System.Windows.Media.Brush;
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;
using Image = System.Drawing.Image;
using Size = System.Windows.Size;

namespace Marlin3DprinterToolStlThumbnail
{
    // ====================================================================================================================================================================
    // 
    //     N E E D E D     E X T E N S I O N S 
    // 
    // If you have Nuget installed, just do a quick search for SharpShell and install it directly - or get the package details at https://www.nuget.org/packages/SharpShell.
    // 
    // More info can be found at: http://www.codeproject.com/Articles/563114/NET-Shell-Extensions-Shell-Thumbnail-Handlers    
    // ====================================================================================================================================================================

    /// <summary>
    /// Derived StlViewerThumbnailHandlerClass from SharpThumbnailHandler  (Nuget)
    /// 
    /// 
    /// </summary>
    /// ComVisible attribute to class. This because our class is a COM server and must be visible to other code trying to use it. 
    /// Associate our extension with some the types of shell items we want to use it for. This is done with the COMServerAssociation attribute
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.FileExtension, ".stl")]
    public class Marlin3DprinterToolStlThumbnailClass : SharpThumbnailHandler
    {

        //Configuration configuration = new Configuration();

        /// <summary>
        /// Creates a thumbnail for a 3D object (.STL)
        /// 
        /// The Stlfile is available in the SelectedItemStream property. 
        /// 
        /// </summary>
        /// <param name="width">With of the bitmap thats needs to be created. (Height is equal. The thumbnail cannot be higher than it is wide. )</param>
        /// <returns></returns>
        [STAThread]
        protected override Bitmap GetThumbnailImage(uint width) // Implemented abstract function in the base class
        {
            MemoryStream memStream = new MemoryStream();
            


            Thread thread = new Thread(() =>
            {
                try
                {



                    string color = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Marlin3DprinterTool", "Color", "Blue");
                    var stlReader = new StLReader();
                    stlReader.DefaultMaterial = new DiffuseMaterial(
                    new SolidColorBrush((Color) ColorConverter.ConvertFromString(color)));
                    

                    
                    //stlReader.DefaultMaterial = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
                    var model = stlReader.Read(SelectedItemStream);


                    
                    //...create UI controls...

                    Viewport3D viewport = new Viewport3D();
                    

                    // viewport.Measure(new System.Windows.Size(320, 240));
                    viewport.Measure(new Size(width, width));
                    // viewport.Arrange(new Rect(0, 0, 320, 240));
                    viewport.Arrange(new Rect(0, 0, width, width));

                    ModelVisual3D root = new ModelVisual3D();
                    
                    viewport.Children.Add(root);

                    
                    var camera = new PerspectiveCamera();
                    camera.Position = new Point3D(2, 16, 20);
                    camera.LookDirection = new Vector3D(-2, -16, -20);
                    camera.UpDirection = new Vector3D(0, 0, 1);
                    camera.FieldOfView = 45;
                    camera.NearPlaneDistance = 0.1;
                    camera.FarPlaneDistance = double.PositiveInfinity;
                    viewport.Camera = camera;
                        
                        
                    root.Children.Add(new DefaultLights());
                        
                    root.Content = model;

                    

                    camera.ZoomExtents(viewport);

                    Brush background = new SolidColorBrush(Colors.Transparent);
                    BitmapExporter exporter = new BitmapExporter
                    {
                        OversamplingMultiplier = 2,
                        Background = background
                    };


                    exporter.Export(viewport, memStream);

                }
                catch (Exception treadException)
                {

                        
                }
                            
                           
            });

                
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();


            Bitmap thumbnailBitmap = (Bitmap) Image.FromStream(memStream);

            return thumbnailBitmap;
        }
        static object GetRegistryValue(string fullPath, object defaultValue)
        {
            string keyName = Path.GetDirectoryName(fullPath);
            string valueName = Path.GetFileName(fullPath);
            return Registry.GetValue(keyName, valueName, defaultValue);
        }
    }
}
    