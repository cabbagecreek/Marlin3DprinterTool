using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marlin3DprinterToolUserControls;

namespace Marlin3DprinterToolUserControlsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private FirmwareHelper _firmwareHelper;

        [TestInitialize]
        public void Initialize()
        {
            _firmwareHelper = new FirmwareHelper();
            _firmwareHelper.FileName = @"configuration.h";
        }

        [TestCleanup]
        public void CleanUp()
        {
            
        }
       

        [TestMethod]
        public void GetFeatureValue()
        {
            

            // Simple enabled value
            Assert.AreEqual("250000", _firmwareHelper.GetFeatureValue("BAUDRATE"));

            // There is alot of #defines but the first one is active
            Assert.AreEqual("22.2", _firmwareHelper.GetFeatureValue("DEFAULT_Kp"));

            // Get values from Features that got space and tab(s) at rowstart
            Assert.AreEqual("20.0", _firmwareHelper.GetFeatureValue("DEFAULT_XJERK"));
            Assert.AreEqual("20.1", _firmwareHelper.GetFeatureValue("DEFAULT_YJERK"));
            Assert.AreEqual("0.4", _firmwareHelper.GetFeatureValue("DEFAULT_ZJERK"));
            Assert.AreEqual("5.0", _firmwareHelper.GetFeatureValue("DEFAULT_EJERK"));

            //#define E_MUX0_PIN 40  // Always Required
            //#define E_MUX1_PIN 42  // Needed for 3 to 8 steppers
            //#define E_MUX2_PIN 44  // Needed for 5 to 8 steppers
            Assert.AreEqual("40", _firmwareHelper.GetFeatureValue("E_MUX0_PIN"));
            Assert.AreEqual("42", _firmwareHelper.GetFeatureValue("E_MUX1_PIN"));
            Assert.AreEqual("44", _firmwareHelper.GetFeatureValue("E_MUX2_PIN"));

            //#define CUSTOM_MACHINE_NAME "3D Printer"
            var customMachineName = _firmwareHelper.GetFeatureValue("CUSTOM_MACHINE_NAME");
            Assert.AreEqual("\"3D Printer\"", customMachineName);
            
            // Simple enabled value
            Assert.AreEqual("250000", _firmwareHelper.GetFeatureValue("BAUDRATE"));
            

            // There is alot of #defines but the first one is active
            Assert.AreEqual("22.2", _firmwareHelper.GetFeatureValue("DEFAULT_Kp"));
            

            // Get values from Features that got space and tab(s) at rowstart
            Assert.AreEqual("20.0", _firmwareHelper.GetFeatureValue("DEFAULT_XJERK"));
            Assert.AreEqual("20.1", _firmwareHelper.GetFeatureValue("DEFAULT_YJERK"));
            Assert.AreEqual("0.4", _firmwareHelper.GetFeatureValue("DEFAULT_ZJERK"));
            Assert.AreEqual("5.0", _firmwareHelper.GetFeatureValue("DEFAULT_EJERK"));



            //#define E_MUX0_PIN 40  // Always Required
            //#define E_MUX1_PIN 42  // Needed for 3 to 8 steppers
            //#define E_MUX2_PIN 44  // Needed for 5 to 8 steppers
            Assert.AreEqual("40", _firmwareHelper.GetFeatureValue("E_MUX0_PIN"));
            Assert.AreEqual("42", _firmwareHelper.GetFeatureValue("E_MUX1_PIN"));
            Assert.AreEqual("44", _firmwareHelper.GetFeatureValue("E_MUX2_PIN"));


            // begind with * #define Y_PROBE_OFFSET_FROM_EXTRUDER 10
            Assert.AreEqual("12", _firmwareHelper.GetFeatureValue("X_PROBE_OFFSET_FROM_EXTRUDER"));
            Assert.AreEqual("14", _firmwareHelper.GetFeatureValue("Y_PROBE_OFFSET_FROM_EXTRUDER"));
            Assert.AreEqual("16", _firmwareHelper.GetFeatureValue("Z_PROBE_OFFSET_FROM_EXTRUDER"));


            // Feature that is non-existing
            Assert.IsNull(_firmwareHelper.GetFeatureValue("NOTVALID"));

            // Feature ""
            Assert.IsNull(_firmwareHelper.GetFeatureValue(""));
            
        }

        [TestMethod]
        public void GetEnabledFeature()
        {
            

            // Get enabled INACTIVE Features that got space and tab(s) at rowstart
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("AUTO_BED_LEVELING_3POINT"));
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("AUTO_BED_LEVELING_LINEAR"));
            Assert.AreEqual("True", _firmwareHelper.GetEnabledFeature("AUTO_BED_LEVELING_BILINEAR"));
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("AUTO_BED_LEVELING_UBL"));
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("MESH_BED_LEVELING"));

            // Feature that is non-existing
            Assert.IsNull(_firmwareHelper.GetEnabledFeature("NOTVALID"));

            // Feature ""
            Assert.IsNull(_firmwareHelper.GetFeatureValue(""));
        }

        [TestMethod]
        public void GetEnableValue()
        {
            


            //#define CUSTOM_MACHINE_NAME "3D Printer"
            Assert.AreEqual("\"3D Printer\"", _firmwareHelper.GetFeatureValue("CUSTOM_MACHINE_NAME"));
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("CUSTOM_MACHINE_NAME"));

            // Simple enabled value
            Assert.AreEqual("250000", _firmwareHelper.GetFeatureValue("BAUDRATE"));
            Assert.AreEqual("True", _firmwareHelper.GetEnabledFeature("BAUDRATE"));

            // There is alot of #defines but the first one is active
            Assert.AreEqual("22.2", _firmwareHelper.GetFeatureValue("DEFAULT_Kp"));
            Assert.AreEqual("True", _firmwareHelper.GetEnabledFeature("DEFAULT_Kp"));

            // Get values from Features that got space and tab(s) at rowstart
            Assert.AreEqual("20.0", _firmwareHelper.GetFeatureValue("DEFAULT_XJERK"));
            Assert.AreEqual("20.1", _firmwareHelper.GetFeatureValue("DEFAULT_YJERK"));
            Assert.AreEqual("0.4", _firmwareHelper.GetFeatureValue("DEFAULT_ZJERK"));
            Assert.AreEqual("5.0", _firmwareHelper.GetFeatureValue("DEFAULT_EJERK"));
            Assert.AreEqual("True", _firmwareHelper.GetEnabledFeature("DEFAULT_XJERK"));
            Assert.AreEqual("True", _firmwareHelper.GetEnabledFeature("DEFAULT_YJERK"));
            Assert.AreEqual("True", _firmwareHelper.GetEnabledFeature("DEFAULT_ZJERK"));
            Assert.AreEqual("True", _firmwareHelper.GetEnabledFeature("DEFAULT_EJERK"));


            //#define E_MUX0_PIN 40  // Always Required
            //#define E_MUX1_PIN 42  // Needed for 3 to 8 steppers
            //#define E_MUX2_PIN 44  // Needed for 5 to 8 steppers
            Assert.AreEqual("40", _firmwareHelper.GetFeatureValue("E_MUX0_PIN"));
            Assert.AreEqual("42", _firmwareHelper.GetFeatureValue("E_MUX1_PIN"));
            Assert.AreEqual("44", _firmwareHelper.GetFeatureValue("E_MUX2_PIN"));
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("E_MUX0_PIN"));
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("E_MUX1_PIN"));
            Assert.AreEqual("False", _firmwareHelper.GetEnabledFeature("E_MUX2_PIN"));

            // Feature that is non-existing
            Assert.IsNull(_firmwareHelper.GetFeatureValue("NOTVALID"));
            Assert.IsNull(_firmwareHelper.GetEnabledFeature("NOTVALID"));

            // Feature ""
            Assert.IsNull(_firmwareHelper.GetFeatureValue(""));
            Assert.IsNull(_firmwareHelper.GetEnabledFeature(""));

            
        }

        [TestMethod]
        public void GetFirmwareFeatureRow()
        {
            


            Assert.AreEqual(112, _firmwareHelper.GetFirmwareFeatureRow("BAUDRATE"));
            Assert.AreEqual(338, _firmwareHelper.GetFirmwareFeatureRow("DEFAULT_Kp"));
            Assert.AreEqual(548, _firmwareHelper.GetFirmwareFeatureRow("DEFAULT_XJERK"));
            Assert.AreEqual(549, _firmwareHelper.GetFirmwareFeatureRow("DEFAULT_YJERK"));
            Assert.AreEqual(550, _firmwareHelper.GetFirmwareFeatureRow("DEFAULT_ZJERK"));
            Assert.AreEqual(154, _firmwareHelper.GetFirmwareFeatureRow("E_MUX0_PIN"));
            Assert.AreEqual(155, _firmwareHelper.GetFirmwareFeatureRow("E_MUX1_PIN"));
            Assert.AreEqual(156, _firmwareHelper.GetFirmwareFeatureRow("E_MUX2_PIN"));
            
            Assert.AreEqual(828, _firmwareHelper.GetFirmwareFeatureRow("AUTO_BED_LEVELING_3POINT"));
            Assert.AreEqual(829, _firmwareHelper.GetFirmwareFeatureRow("AUTO_BED_LEVELING_LINEAR"));
            Assert.AreEqual(830, _firmwareHelper.GetFirmwareFeatureRow("AUTO_BED_LEVELING_BILINEAR"));
            Assert.AreEqual(831, _firmwareHelper.GetFirmwareFeatureRow("AUTO_BED_LEVELING_UBL"));
            Assert.AreEqual(832, _firmwareHelper.GetFirmwareFeatureRow("MESH_BED_LEVELING"));

            // Feature that is non-existing
            Assert.AreEqual(-1, _firmwareHelper.GetFirmwareFeatureRow("NOTVALID"));
            // Feature ""
            Assert.AreEqual(-1,_firmwareHelper.GetFirmwareFeatureRow(""));
        }

        [TestMethod]
        public void IsFeatureValueNumbers()
        {
            

            Assert.IsTrue(_firmwareHelper.IsFeatureValueNumbers("123"));
            Assert.IsTrue(_firmwareHelper.IsFeatureValueNumbers("123.0"));
            Assert.IsTrue(_firmwareHelper.IsFeatureValueNumbers("-123"));
            Assert.IsTrue(_firmwareHelper.IsFeatureValueNumbers("-123.0"));

            Assert.IsFalse(_firmwareHelper.IsFeatureValueNumbers("IsNot Number"));



        }

        [TestMethod]
        public void GetComment()
        {

            

            Assert.AreEqual(_firmwareHelper.GetComment("STRING_CONFIG_H_AUTHOR"), "// Who made the changes.");
            Assert.AreEqual(_firmwareHelper.GetComment("SHOW_BOOTSCREEN"), "");
            Assert.AreEqual(_firmwareHelper.GetComment("SLED_DOCKING_OFFSET"), "// The extra distance the X axis must travel to pickup the sled. 0 should be fine but you can push it further if you'd like.");
            // space and Tab before and after beginning //
            Assert.AreEqual(_firmwareHelper.GetComment("MESH_G28_REST_ORIGIN"), "// After homing all axes ('G28' or 'G28 XYZ') rest Z at Z_MIN_POS");
            // Alot of tab&spaces in separations
            Assert.AreEqual(_firmwareHelper.GetComment("Z_SAFE_HOMING_X_POINT"), "// X point for Z homing when homing all axis (G28).");
            Assert.AreEqual(_firmwareHelper.GetComment("Z_SAFE_HOMING_Y_POINT"), "// Y point for Z homing when homing all axis (G28).");



        }


        [TestMethod]
        public void SetAndGetValues()
        {

            

            string originalValue;
            string newValue;
            string feature;

            //#define NOZZLE_CLEAN_TRIANGLES 3 
            feature = "NOZZLE_CLEAN_TRIANGLES";
            originalValue = _firmwareHelper.GetFeatureValue(feature);
            _firmwareHelper.SetFeatureValue(feature, "17",true);
            newValue = _firmwareHelper.GetFeatureValue(feature);
            _firmwareHelper.SetFeatureValue(feature, originalValue, true);
            Assert.AreEqual("17", newValue,$"{feature}");

            //#define STRING_CONFIG_H_AUTHOR "(none, default config)" // Who made the changes.
            feature = "STRING_CONFIG_H_AUTHOR";
            originalValue = _firmwareHelper.GetFeatureValue(feature);
            _firmwareHelper.SetFeatureValue(feature, "17", true);
            newValue = _firmwareHelper.GetFeatureValue(feature);
            _firmwareHelper.SetFeatureValue(feature, originalValue, true);
            Assert.AreEqual("17", newValue, $"{feature}");




        }



    }
}
