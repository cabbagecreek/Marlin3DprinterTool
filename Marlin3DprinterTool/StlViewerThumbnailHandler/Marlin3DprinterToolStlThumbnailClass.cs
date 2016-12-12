using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
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


            string debug = (string) Registry.GetValue(@"HKEY_CURRENT_USER\Software\Marlin3DprinterTool", "Debug", "false");


            Logger( debug,"Creating Memorystream",EventLogEntryType.Information,100);
            MemoryStream memStream = new MemoryStream();


            Logger( debug,"Creating Thread", EventLogEntryType.Information, 200);
            Thread thread = new Thread(() =>
            {

                Logger( debug,"Try Thread",EventLogEntryType.Information, 210);
                try
                {


                    Logger( debug,"Get Color",EventLogEntryType.Information, 220);
                    string color = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Marlin3DprinterTool", "Color", "Blue");

                    Logger( debug,$"Color: {color}",EventLogEntryType.Information, 222);

                    Logger( debug,"Start reader",EventLogEntryType.Information, 230);
                    var stlReader = new StLReader();
                    stlReader.DefaultMaterial = new DiffuseMaterial(
                    new SolidColorBrush((Color) ColorConverter.ConvertFromString(color)));

                    Logger( debug,"Reader configured",EventLogEntryType.Information, 240);

                    //stlReader.DefaultMaterial = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));

                    Logger( debug,"Start reader the model",EventLogEntryType.Information, 250);
                    var model = stlReader.Read(SelectedItemStream);
                    Logger( debug,"Model ok",EventLogEntryType.Information, 260);


                    Logger( debug,"Create UI control",EventLogEntryType.Information, 300);
                    //...create UI controls...

                    Logger( debug,"Create Viewport",EventLogEntryType.Information, 310);
                    Viewport3D viewport = new Viewport3D();
                    Logger( debug,"Viewport done",EventLogEntryType.Information, 320);


                    Logger( debug,$"viewport.Measure: {width}",EventLogEntryType.Information, 330);
                    // viewport.Measure(new System.Windows.Size(320, 240));
                    viewport.Measure(new Size(width, width));
                    // viewport.Arrange(new Rect(0, 0, 320, 240));
                    Logger( debug,$"viewport.Arrange: {width}",EventLogEntryType.Information, 340);
                    viewport.Arrange(new Rect(0, 0, width, width));


                    Logger( debug,"ModelVisual3D",EventLogEntryType.Information, 350);
                    ModelVisual3D root = new ModelVisual3D();

                    Logger( debug,"viewport.Children.Add",EventLogEntryType.Information, 360);
                    viewport.Children.Add(root);


                    Logger( debug,"Camera",EventLogEntryType.Information, 400);
                    var camera = new PerspectiveCamera();
                    camera.Position = new Point3D(2, 16, 20);
                    camera.LookDirection = new Vector3D(-2, -16, -20);
                    camera.UpDirection = new Vector3D(0, 0, 1);
                    camera.FieldOfView = 45;
                    camera.NearPlaneDistance = 0.1;
                    camera.FarPlaneDistance = double.PositiveInfinity;
                    viewport.Camera = camera;
                    Logger( debug,"Camera Done",EventLogEntryType.Information, 410);




                    Logger( debug,"Add light",EventLogEntryType.Information, 420);
                    root.Children.Add(new DefaultLights());
                    Logger( debug,"Add model",EventLogEntryType.Information, 430);
                    root.Content = model;


                    Logger( debug,"Do camera.ZoomExtents",EventLogEntryType.Information, 440);
                    camera.ZoomExtents(viewport);


                    Logger( debug,"Do background",EventLogEntryType.Information, 450);
                    Brush background = new SolidColorBrush(Colors.Transparent);

                    Logger( debug,"Do a BitmapExporter",EventLogEntryType.Information, 460);
                    BitmapExporter exporter = new BitmapExporter
                    {
                        OversamplingMultiplier = 2,
                        Background = background
                    };

                    Logger( debug,"Fill the exporter",EventLogEntryType.Information, 470);
                    exporter.Export(viewport, memStream);

                }
                catch (Exception errorException)
                {
                    Logger( debug,errorException.Message,EventLogEntryType.Error,errorException.HResult);
                    //TODO: Empty Catch            
                }
                            
                           
            });


            Logger( debug,"Thread STA",EventLogEntryType.Information, 500);
            thread.SetApartmentState(ApartmentState.STA);
            Logger( debug,"Thread Sstart",EventLogEntryType.Information, 510);
            thread.Start();
            Logger( debug,"Thread Join",EventLogEntryType.Information, 520);
            thread.Join();

            Logger( debug,"Create bitmap from memstream",EventLogEntryType.Information, 530);
            Bitmap thumbnailBitmap = (Bitmap) Image.FromStream(memStream);

            Logger( debug,"Return Bitmap!",EventLogEntryType.Information, 500);
            return thumbnailBitmap;
        }

        private void Logger( string writeLog,string logMessage,EventLogEntryType type,int number)
        {
            if (writeLog.ToLower() == "false" ) return;


            var sSource = "STLviewer";
            var sLog = "Application";

            if (!EventLog.SourceExists(sSource))
            {
                EventLog.CreateEventSource(sSource, sLog);
            }

            EventLog.WriteEntry(sSource, logMessage, type, number);
        }
    }
    
}
    