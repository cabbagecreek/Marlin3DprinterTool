namespace MarlinConfigurator
{
    partial class FrmConfigurator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigurator));
            this.tabControlConfiguration = new System.Windows.Forms.TabControl();
            this.tabPageDownload = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.btnDownloadMarlinStable = new System.Windows.Forms.Button();
            this.btnBrowseNewFirmware = new System.Windows.Forms.Button();
            this.txtBxNewFirmware = new System.Windows.Forms.TextBox();
            this.grpcurrentFirmware = new System.Windows.Forms.GroupBox();
            this.btnBrowsecurrentFirmware = new System.Windows.Forms.Button();
            this.txtBxcurrentFirmware = new System.Windows.Forms.TextBox();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.grpBxConfigurationVersion = new System.Windows.Forms.GroupBox();
            this.marlinValueCONFIGURATION_H_VERSION = new Marlin3DprinterToolUserControls.MarlinValue();
            this.webBrowserMarlinHelp = new System.Windows.Forms.WebBrowser();
            this.grpBxHardware = new System.Windows.Forms.GroupBox();
            this.marlinComboBoxMOTHERBOARD = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinEnableValueMACHINE_UUID = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinEnableValueCUSTOM_MACHINE_NAME = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxBLUETOOTH = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinValueBAUDRATE = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinUpDnSERIAL_PORT = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBxFirmwareInfo = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinValueSTRING_SPLASH_LINE2 = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueSTRING_SPLASH_LINE1 = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxSHOW_BOOTSCREEN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinValueStringConfigHAuthor = new Marlin3DprinterToolUserControls.MarlinValue();
            this.tabPageExtruder = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxSINGLENOZZLE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnEXTRUDERS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBxExtruderOffset = new System.Windows.Forms.GroupBox();
            this.marlinEnableValueHOTEND_OFFSET_Y = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinEnableValueHOTEND_OFFSET_X = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.grpBxMixingExtruders = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxDIRECT_MIXING_IN_G1 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnMIXING_VIRTUAL_TOOLS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnMIXING_STEPPERS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxMIXING_EXTRUDER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.grpBxSWITCHING_EXTRUDER = new System.Windows.Forms.GroupBox();
            this.marlinEnableValueHOTEND_OFFSET_Z = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxSWITCHING_EXTRUDER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPagePowerSupply = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxPS_DEFAULT_OFF = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnPOWER_SUPPLY = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.tabPageTemperatureSensor = new System.Windows.Forms.TabPage();
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinComboBoxTEMP_SENSOR_BED = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxTEMP_SENSOR_0 = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxTEMP_SENSOR_1 = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxTEMP_SENSOR_2 = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxTEMP_SENSOR_3 = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxTEMP_SENSOR_4 = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.tabPageTemperatureStability = new System.Windows.Forms.TabPage();
            this.grpBxTemperatureStabilityBed = new System.Windows.Forms.GroupBox();
            this.marlinUpDnTEMP_BED_WINDOW = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnTEMP_BED_HYSTERESIS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBxTemperatureStabilityExtruder = new System.Windows.Forms.GroupBox();
            this.marlinUpDnTEMP_WINDOW = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnTEMP_HYSTERESIS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnTEMP_RESIDENCY_TIME = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.tabPageTemperatures = new System.Windows.Forms.TabPage();
            this.grpBxMinTemperatureBed = new System.Windows.Forms.GroupBox();
            this.marlinUpDnBED_MAXTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnBED_MINTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBxMinTemperatureExtruders = new System.Windows.Forms.GroupBox();
            this.marlinUpDnHEATER_4_MAXTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_3_MAXTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_2_MAXTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_1_MAXTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_0_MAXTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_4_MINTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_3_MINTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_2_MINTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_1_MINTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnHEATER_0_MINTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.tabPagePidExtruder = new System.Windows.Forms.TabPage();
            this.marlinValueDEFAULT_Kd = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_Ki = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_Kp = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueK1 = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinUpDnPID_FUNCTIONAL_RANGE = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxSLOW_PWM_HEATERS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinEnableValuePID_OPENLOOP = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxPID_DEBUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxPID_AUTOTUNE_MENU = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinValuePID_MAX = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinUpDnBANG_MAX = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxPIDTEMP = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPagePidBed = new System.Windows.Forms.TabPage();
            this.marlinValueDEFAULT_bedKd = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_bedKi = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_bedKp = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxPID_BED_DEBUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnMAX_BED_POWER = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxBED_LIMIT_SWITCHING = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxPIDTEMPBED = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageExtrusion = new System.Windows.Forms.TabPage();
            this.marlinValueEXTRUDE_MAXLENGTH = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnEXTRUDE_MINTEMP = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageThermalProtection = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxTHERMAL_PROTECTION_BED = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageKinematics = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxCOREZY = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxCOREZX = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxCOREYX = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxCOREYZ = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxCOREXZ = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxCOREXY = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageEndstop = new System.Windows.Forms.TabPage();
            this.groupBoxEndstopPlug = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxUSE_ZMIN_PLUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxUSE_XMIN_PLUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxUSE_YMIN_PLUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxUSE_ZMAX_PLUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxUSE_XMAX_PLUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxUSE_YMAX_PLUG = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.groupBoxInvertingEndstops = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.grpBxPullupResistors = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxENDSTOPPULLUPS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxENDSTOPPULLUP_XMAX = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxENDSTOPPULLUP_YMAX = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxENDSTOPPULLUP_YMIN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxENDSTOPPULLUP_XMIN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageMovement = new System.Windows.Forms.TabPage();
            this.marlinValueDEFAULT_EJERK = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_ZJERK = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_YJERK = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_XJERK = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_RETRACT_ACCELERATION = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_ACCELERATION = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_MAX_ACCELERATION = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_MAX_FEEDRATE = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxDISTINCT_E_FACTORS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageProbe = new System.Windows.Forms.TabPage();
            this.groupBoxZ_CLEARANCE = new System.Windows.Forms.GroupBox();
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.groupBoxZ_PROBE_SPEED = new System.Windows.Forms.GroupBox();
            this.marlinValueZ_PROBE_SPEED_FAST = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueZ_PROBE_SPEED_SLOW = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueXY_PROBE_SPEED = new Marlin3DprinterToolUserControls.MarlinValue();
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER = new System.Windows.Forms.GroupBox();
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER = new Marlin3DprinterToolUserControls.MarlinValue();
            this.grpBxZ_PROBE_SLED = new System.Windows.Forms.GroupBox();
            this.marlinEnableValueSLED_DOCKING_OFFSET = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxZ_PROBE_SLED = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxSOLENOID_PROBE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.grpBxBLTouch = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxBLTOUCH = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinEnableValueBLTOUCH_DELAY = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinEnableValueZ_SERVO_ANGLES = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxFIX_MOUNTED_PROBE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxPROBE_MANUALLY = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinEnableValueZ_MIN_PROBE_PIN = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageStepper = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.grpBxInvertDirection = new System.Windows.Forms.GroupBox();
            this.marlinComboBoxINVERT_E4_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxINVERT_E3_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxINVERT_E2_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxINVERT_E1_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxINVERT_E0_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxINVERT_Z_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxINVERT_Y_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxINVERT_X_DIR = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.grpBxDisableSteppers = new System.Windows.Forms.GroupBox();
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxDISABLE_E = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxDISABLE_Z = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxDISABLE_Y = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxDISABLE_X = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.grpBxStepperEnablePin = new System.Windows.Forms.GroupBox();
            this.marlinValueE_ENABLE_ON = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueZ_ENABLE_ON = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueY_ENABLE_ON = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueX_ENABLE_ON = new Marlin3DprinterToolUserControls.MarlinValue();
            this.tabPageHoming = new System.Windows.Forms.TabPage();
            this.grpBxTravelLimits = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnZ_MAX_POS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnY_MAX_POS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnX_MAX_POS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnZ_MIN_POS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnY_MIN_POS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnX_MIN_POS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.groupBoxEndStopDirection = new System.Windows.Forms.GroupBox();
            this.marlinUpDnZ_HOME_DIR = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnY_HOME_DIR = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnX_HOME_DIR = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.tabPageFilamentRunoutSensor = new System.Windows.Forms.TabPage();
            this.marlinValueFILAMENT_RUNOUT_SCRIPT = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinComboBox1 = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageBedLeveling = new System.Windows.Forms.TabPage();
            this.marlinEnableValueZ_PROBE_END_SCRIPT = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.grpBxMeshBedLevel = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxMESH_G28_REST_ORIGIN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnMESH_INSET = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBxAutoBedLevelingUbl = new System.Windows.Forms.GroupBox();
            this.marlinUpDnUBL_PROBE_PT_3_Y = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnUBL_MESH_INSET = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnUBL_PROBE_PT_3_X = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnUBL_PROBE_PT_1_Y = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnUBL_PROBE_PT_2_Y = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnUBL_PROBE_PT_1_X = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnUBL_PROBE_PT_2_X = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBxGridPoints = new System.Windows.Forms.GroupBox();
            this.marlinValueGRID_MAX_POINTS_X = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueGRID_MAX_POINTS_Y = new Marlin3DprinterToolUserControls.MarlinValue();
            this.grpBx3Points = new System.Windows.Forms.GroupBox();
            this.marlinUpDnABL_PROBE_PT_3_Y = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnABL_PROBE_PT_3_X = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnABL_PROBE_PT_2_Y = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnABL_PROBE_PT_2_X = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnABL_PROBE_PT_1_Y = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnABL_PROBE_PT_1_X = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBiLinear = new System.Windows.Forms.GroupBox();
            this.marlinUpDnBILINEAR_SUBDIVISIONS = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.grpAutoBedLevetType = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxMESH_BED_LEVELING = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.grpBxProbeGrid = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxPROBE_Y_FIRST = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnMIN_PROBE_EDGE = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnBACK_PROBE_BED_POSITION = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnFRONT_PROBE_BED_POSITION = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnRIGHT_PROBE_BED_POSITION = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnLEFT_PROBE_BED_POSITION = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.grpBxEnableFadeHeight = new System.Windows.Forms.GroupBox();
            this.lblFadeHeight = new System.Windows.Forms.Label();
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageLcdBedLeveling = new System.Windows.Forms.TabPage();
            this.marlinUpDnLCD_PROBE_Z_RANGE = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinValueMBL_Z_STEP = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxLCD_BED_LEVELING = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageEEPROM = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxEEPROM_CHITCHAT = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxEEPROM_SETTINGS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPagePreHeat = new System.Windows.Forms.TabPage();
            this.groupBoxPreHeat2 = new System.Windows.Forms.GroupBox();
            this.marlinUpDnPREHEAT_2_FAN_SPEED = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnPREHEAT_2_TEMP_BED = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.groupBoxPreHeat1 = new System.Windows.Forms.GroupBox();
            this.marlinUpDnPREHEAT_1_FAN_SPEED = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnPREHEAT_1_TEMP_BED = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.tabPageNozzlePark = new System.Windows.Forms.TabPage();
            this.groupBoxNozzleCleanFeature = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinUpDn2 = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDn1 = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinValueNOZZLE_CLEAN_END_POINT = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueNOZZLE_CLEAN_START_POINT = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnNOZZLE_CLEAN_STROKES = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinValue1 = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinCheckBoxNOZZLE_PARK_FEATURE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageJob = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxPRINTCOUNTER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageLCD = new System.Windows.Forms.TabPage();
            this.groupBoxMenuOptions = new System.Windows.Forms.GroupBox();
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxSPEAKER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.groupBoxEncoder = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxREVERSE_MENU_DIRECTION = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinEnableValueENCODER_PULSES_PER_STEP = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.groupBoxLcdType = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxOLED_PANEL_TINYBOY2 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxSAV_3DLCD = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxU8GLIB_SH1106 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxSAV_3DGLCD = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxU8GLIB_SSD1306 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxLCD_I2C_VIKI = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxLCD_I2C_PANELOLU2 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxLCM1602 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxRA_CONTROL_PANEL = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxRIGIDBOT_PANEL = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxREPRAPWORLD_KEYPAD = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxMINIPANEL = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxG3D_PANEL = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxminiVIKI = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxVIKI2 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxMAKRPANEL = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxPANEL_ONE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxCARTESIO_UI = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxULTIPANEL = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxULTIMAKERCONTROLLER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxDOGLCD = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxULTRA_LCD = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinComboBoxDISPLAY_CHARSET_HD44780 = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.marlinComboBoxLCD_LANGUAGE = new Marlin3DprinterToolUserControls.MarlinComboBox();
            this.tabPageSD = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxSD_CHECK_AND_RETRY = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxSDSUPPORT = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageExtra = new System.Windows.Forms.TabPage();
            this.groupBoxRGB_Led = new System.Windows.Forms.GroupBox();
            this.marlinCheckBoxPRINTER_EVENT_LEDS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnRGB_LED_W_PIN = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnRGB_LED_B_PIN = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnRGB_LED_G_PIN = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnRGB_LED_R_PIN = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxRGB_LED = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxRGBW_LED = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxBLINKM = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxBARICUDA = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxSF_ARC_FIX = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinEnableValuePHOTOGRAPH_PIN = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxTEMP_STAT_LEDS = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinCheckBoxSOFT_PWM_DITHER = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnSOFT_PWM_SCALE = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBoxFAST_PWM_FAN = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.tabPageServo = new System.Windows.Forms.TabPage();
            this.marlinEnableValueNUM_SERVOS = new Marlin3DprinterToolUserControls.MarlinEnableValue();
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinUpDnSERVO_DELAY = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.tabPageFilamentWidthSensor = new System.Windows.Forms.TabPage();
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinUpDn4 = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinValueMEASURED_LOWER_LIMIT = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinValueMEASURED_UPPER_LIMIT = new Marlin3DprinterToolUserControls.MarlinValue();
            this.marlinUpDn3 = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM = new Marlin3DprinterToolUserControls.MarlinUpDn();
            this.marlinCheckBox1 = new Marlin3DprinterToolUserControls.MarlinCheckBox();
            this.toolStripConfiguration = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonArduinoIDE = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSetup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPayPal = new System.Windows.Forms.ToolStripButton();
            this.toolTipConfiguration = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlConfiguration.SuspendLayout();
            this.tabPageDownload.SuspendLayout();
            this.grpBxNewFirmware.SuspendLayout();
            this.grpcurrentFirmware.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.grpBxConfigurationVersion.SuspendLayout();
            this.grpBxHardware.SuspendLayout();
            this.grpBxFirmwareInfo.SuspendLayout();
            this.tabPageExtruder.SuspendLayout();
            this.grpBxExtruderOffset.SuspendLayout();
            this.grpBxMixingExtruders.SuspendLayout();
            this.grpBxSWITCHING_EXTRUDER.SuspendLayout();
            this.tabPagePowerSupply.SuspendLayout();
            this.tabPageTemperatureSensor.SuspendLayout();
            this.tabPageTemperatureStability.SuspendLayout();
            this.grpBxTemperatureStabilityBed.SuspendLayout();
            this.grpBxTemperatureStabilityExtruder.SuspendLayout();
            this.tabPageTemperatures.SuspendLayout();
            this.grpBxMinTemperatureBed.SuspendLayout();
            this.grpBxMinTemperatureExtruders.SuspendLayout();
            this.tabPagePidExtruder.SuspendLayout();
            this.tabPagePidBed.SuspendLayout();
            this.tabPageExtrusion.SuspendLayout();
            this.tabPageThermalProtection.SuspendLayout();
            this.tabPageKinematics.SuspendLayout();
            this.tabPageEndstop.SuspendLayout();
            this.groupBoxEndstopPlug.SuspendLayout();
            this.groupBoxInvertingEndstops.SuspendLayout();
            this.grpBxPullupResistors.SuspendLayout();
            this.tabPageMovement.SuspendLayout();
            this.tabPageProbe.SuspendLayout();
            this.groupBoxZ_CLEARANCE.SuspendLayout();
            this.groupBoxZ_PROBE_SPEED.SuspendLayout();
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.SuspendLayout();
            this.grpBxZ_PROBE_SLED.SuspendLayout();
            this.grpBxBLTouch.SuspendLayout();
            this.tabPageStepper.SuspendLayout();
            this.grpBxInvertDirection.SuspendLayout();
            this.grpBxDisableSteppers.SuspendLayout();
            this.grpBxStepperEnablePin.SuspendLayout();
            this.tabPageHoming.SuspendLayout();
            this.grpBxTravelLimits.SuspendLayout();
            this.groupBoxEndStopDirection.SuspendLayout();
            this.tabPageFilamentRunoutSensor.SuspendLayout();
            this.tabPageBedLeveling.SuspendLayout();
            this.grpBxMeshBedLevel.SuspendLayout();
            this.grpBxAutoBedLevelingUbl.SuspendLayout();
            this.grpBxGridPoints.SuspendLayout();
            this.grpBx3Points.SuspendLayout();
            this.grpBiLinear.SuspendLayout();
            this.grpAutoBedLevetType.SuspendLayout();
            this.grpBxProbeGrid.SuspendLayout();
            this.grpBxEnableFadeHeight.SuspendLayout();
            this.tabPageLcdBedLeveling.SuspendLayout();
            this.tabPageEEPROM.SuspendLayout();
            this.tabPagePreHeat.SuspendLayout();
            this.groupBoxPreHeat2.SuspendLayout();
            this.groupBoxPreHeat1.SuspendLayout();
            this.tabPageNozzlePark.SuspendLayout();
            this.groupBoxNozzleCleanFeature.SuspendLayout();
            this.tabPageJob.SuspendLayout();
            this.tabPageLCD.SuspendLayout();
            this.groupBoxMenuOptions.SuspendLayout();
            this.groupBoxEncoder.SuspendLayout();
            this.groupBoxLcdType.SuspendLayout();
            this.tabPageSD.SuspendLayout();
            this.tabPageExtra.SuspendLayout();
            this.groupBoxRGB_Led.SuspendLayout();
            this.tabPageServo.SuspendLayout();
            this.tabPageFilamentWidthSensor.SuspendLayout();
            this.toolStripConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConfiguration
            // 
            this.tabControlConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlConfiguration.Controls.Add(this.tabPageDownload);
            this.tabControlConfiguration.Controls.Add(this.tabPageConfiguration);
            this.tabControlConfiguration.Controls.Add(this.tabPageExtruder);
            this.tabControlConfiguration.Controls.Add(this.tabPagePowerSupply);
            this.tabControlConfiguration.Controls.Add(this.tabPageTemperatureSensor);
            this.tabControlConfiguration.Controls.Add(this.tabPageTemperatureStability);
            this.tabControlConfiguration.Controls.Add(this.tabPageTemperatures);
            this.tabControlConfiguration.Controls.Add(this.tabPagePidExtruder);
            this.tabControlConfiguration.Controls.Add(this.tabPagePidBed);
            this.tabControlConfiguration.Controls.Add(this.tabPageExtrusion);
            this.tabControlConfiguration.Controls.Add(this.tabPageThermalProtection);
            this.tabControlConfiguration.Controls.Add(this.tabPageKinematics);
            this.tabControlConfiguration.Controls.Add(this.tabPageEndstop);
            this.tabControlConfiguration.Controls.Add(this.tabPageMovement);
            this.tabControlConfiguration.Controls.Add(this.tabPageProbe);
            this.tabControlConfiguration.Controls.Add(this.tabPageStepper);
            this.tabControlConfiguration.Controls.Add(this.tabPageHoming);
            this.tabControlConfiguration.Controls.Add(this.tabPageFilamentRunoutSensor);
            this.tabControlConfiguration.Controls.Add(this.tabPageBedLeveling);
            this.tabControlConfiguration.Controls.Add(this.tabPageLcdBedLeveling);
            this.tabControlConfiguration.Controls.Add(this.tabPageEEPROM);
            this.tabControlConfiguration.Controls.Add(this.tabPagePreHeat);
            this.tabControlConfiguration.Controls.Add(this.tabPageNozzlePark);
            this.tabControlConfiguration.Controls.Add(this.tabPageJob);
            this.tabControlConfiguration.Controls.Add(this.tabPageLCD);
            this.tabControlConfiguration.Controls.Add(this.tabPageSD);
            this.tabControlConfiguration.Controls.Add(this.tabPageExtra);
            this.tabControlConfiguration.Controls.Add(this.tabPageServo);
            this.tabControlConfiguration.Controls.Add(this.tabPageFilamentWidthSensor);
            this.tabControlConfiguration.Location = new System.Drawing.Point(0, 42);
            this.tabControlConfiguration.Multiline = true;
            this.tabControlConfiguration.Name = "tabControlConfiguration";
            this.tabControlConfiguration.SelectedIndex = 0;
            this.tabControlConfiguration.Size = new System.Drawing.Size(630, 665);
            this.tabControlConfiguration.TabIndex = 0;
            // 
            // tabPageDownload
            // 
            this.tabPageDownload.Controls.Add(this.button1);
            this.tabPageDownload.Controls.Add(this.grpBxNewFirmware);
            this.tabPageDownload.Controls.Add(this.grpcurrentFirmware);
            this.tabPageDownload.Location = new System.Drawing.Point(4, 76);
            this.tabPageDownload.Name = "tabPageDownload";
            this.tabPageDownload.Size = new System.Drawing.Size(622, 585);
            this.tabPageDownload.TabIndex = 6;
            this.tabPageDownload.Text = "DownLoad";
            this.tabPageDownload.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxNewFirmware.Controls.Add(this.btnDownloadMarlinStable);
            this.grpBxNewFirmware.Controls.Add(this.btnBrowseNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.txtBxNewFirmware);
            this.grpBxNewFirmware.Location = new System.Drawing.Point(3, 69);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(616, 80);
            this.grpBxNewFirmware.TabIndex = 2;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "New Firmware Directory";
            // 
            // btnDownloadMarlinStable
            // 
            this.btnDownloadMarlinStable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadMarlinStable.Location = new System.Drawing.Point(7, 46);
            this.btnDownloadMarlinStable.Name = "btnDownloadMarlinStable";
            this.btnDownloadMarlinStable.Size = new System.Drawing.Size(600, 25);
            this.btnDownloadMarlinStable.TabIndex = 3;
            this.btnDownloadMarlinStable.Text = "Download Latest Marlin Firmware (v 1.1.1)";
            this.toolTipConfiguration.SetToolTip(this.btnDownloadMarlinStable, "Download the latest version of Marlin Firmware (version 1.1.1)\'");
            this.btnDownloadMarlinStable.UseVisualStyleBackColor = true;
            this.btnDownloadMarlinStable.Click += new System.EventHandler(this.BtnDownloadMarlinStable_Click);
            // 
            // btnBrowseNewFirmware
            // 
            this.btnBrowseNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseNewFirmware.Location = new System.Drawing.Point(581, 19);
            this.btnBrowseNewFirmware.Name = "btnBrowseNewFirmware";
            this.btnBrowseNewFirmware.Size = new System.Drawing.Size(26, 21);
            this.btnBrowseNewFirmware.TabIndex = 1;
            this.btnBrowseNewFirmware.Text = "...";
            this.btnBrowseNewFirmware.UseVisualStyleBackColor = true;
            this.btnBrowseNewFirmware.Click += new System.EventHandler(this.BtnBrowseNewFirmware_Click);
            // 
            // txtBxNewFirmware
            // 
            this.txtBxNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxNewFirmware.Location = new System.Drawing.Point(7, 20);
            this.txtBxNewFirmware.Name = "txtBxNewFirmware";
            this.txtBxNewFirmware.Size = new System.Drawing.Size(573, 20);
            this.txtBxNewFirmware.TabIndex = 0;
            this.txtBxNewFirmware.Text = "C:\\NewFirmware\\Marlin";
            this.toolTipConfiguration.SetToolTip(this.txtBxNewFirmware, "Directory to New Marlin Firmware");
            this.txtBxNewFirmware.TextChanged += new System.EventHandler(this.TxtBxNewFirmware_TextChanged);
            // 
            // grpcurrentFirmware
            // 
            this.grpcurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpcurrentFirmware.Controls.Add(this.btnBrowsecurrentFirmware);
            this.grpcurrentFirmware.Controls.Add(this.txtBxcurrentFirmware);
            this.grpcurrentFirmware.Location = new System.Drawing.Point(3, 16);
            this.grpcurrentFirmware.Name = "grpcurrentFirmware";
            this.grpcurrentFirmware.Size = new System.Drawing.Size(616, 47);
            this.grpcurrentFirmware.TabIndex = 0;
            this.grpcurrentFirmware.TabStop = false;
            this.grpcurrentFirmware.Text = "Current Firmware Directory";
            // 
            // btnBrowsecurrentFirmware
            // 
            this.btnBrowsecurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsecurrentFirmware.Location = new System.Drawing.Point(581, 19);
            this.btnBrowsecurrentFirmware.Name = "btnBrowsecurrentFirmware";
            this.btnBrowsecurrentFirmware.Size = new System.Drawing.Size(26, 21);
            this.btnBrowsecurrentFirmware.TabIndex = 1;
            this.btnBrowsecurrentFirmware.Text = "...";
            this.btnBrowsecurrentFirmware.UseVisualStyleBackColor = true;
            this.btnBrowsecurrentFirmware.Click += new System.EventHandler(this.BtnBrowsecurrentFirmware_Click);
            // 
            // txtBxcurrentFirmware
            // 
            this.txtBxcurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxcurrentFirmware.Location = new System.Drawing.Point(7, 20);
            this.txtBxcurrentFirmware.Name = "txtBxcurrentFirmware";
            this.txtBxcurrentFirmware.Size = new System.Drawing.Size(573, 20);
            this.txtBxcurrentFirmware.TabIndex = 0;
            this.txtBxcurrentFirmware.Text = "C:\\CurrentFirmware\\Marlin";
            this.toolTipConfiguration.SetToolTip(this.txtBxcurrentFirmware, "Directory to Old Marlin Firmware");
            this.txtBxcurrentFirmware.TextChanged += new System.EventHandler(this.TxtBxcurrentFirmware_TextChanged);
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.grpBxConfigurationVersion);
            this.tabPageConfiguration.Controls.Add(this.grpBxHardware);
            this.tabPageConfiguration.Controls.Add(this.grpBxFirmwareInfo);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 76);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(622, 585);
            this.tabPageConfiguration.TabIndex = 0;
            this.tabPageConfiguration.Text = "Configuration.h";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // grpBxConfigurationVersion
            // 
            this.grpBxConfigurationVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxConfigurationVersion.Controls.Add(this.marlinValueCONFIGURATION_H_VERSION);
            this.grpBxConfigurationVersion.Location = new System.Drawing.Point(8, 6);
            this.grpBxConfigurationVersion.Name = "grpBxConfigurationVersion";
            this.grpBxConfigurationVersion.Size = new System.Drawing.Size(608, 53);
            this.grpBxConfigurationVersion.TabIndex = 10;
            this.grpBxConfigurationVersion.TabStop = false;
            this.grpBxConfigurationVersion.Text = "Configuration Version";
            // 
            // marlinValueCONFIGURATION_H_VERSION
            // 
            this.marlinValueCONFIGURATION_H_VERSION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueCONFIGURATION_H_VERSION.ControlText = "Configuration Version:";
            this.marlinValueCONFIGURATION_H_VERSION.currentFirmwareHelper = null;
            this.marlinValueCONFIGURATION_H_VERSION.Feature = "CONFIGURATION_H_VERSION";
            this.marlinValueCONFIGURATION_H_VERSION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#configuration-versionin" +
    "g";
            this.marlinValueCONFIGURATION_H_VERSION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueCONFIGURATION_H_VERSION.Location = new System.Drawing.Point(151, 19);
            this.marlinValueCONFIGURATION_H_VERSION.Name = "marlinValueCONFIGURATION_H_VERSION";
            this.marlinValueCONFIGURATION_H_VERSION.NewFirmwareHelper = null;
            this.marlinValueCONFIGURATION_H_VERSION.Size = new System.Drawing.Size(451, 26);
            this.marlinValueCONFIGURATION_H_VERSION.SpliterDistance = 110;
            this.marlinValueCONFIGURATION_H_VERSION.TabIndex = 0;
            // 
            // webBrowserMarlinHelp
            // 
            this.webBrowserMarlinHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMarlinHelp.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMarlinHelp.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMarlinHelp.Name = "webBrowserMarlinHelp";
            this.webBrowserMarlinHelp.ScriptErrorsSuppressed = true;
            this.webBrowserMarlinHelp.Size = new System.Drawing.Size(544, 661);
            this.webBrowserMarlinHelp.TabIndex = 1;
            // 
            // grpBxHardware
            // 
            this.grpBxHardware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxHardware.Controls.Add(this.marlinComboBoxMOTHERBOARD);
            this.grpBxHardware.Controls.Add(this.marlinEnableValueMACHINE_UUID);
            this.grpBxHardware.Controls.Add(this.marlinEnableValueCUSTOM_MACHINE_NAME);
            this.grpBxHardware.Controls.Add(this.marlinCheckBoxBLUETOOTH);
            this.grpBxHardware.Controls.Add(this.marlinValueBAUDRATE);
            this.grpBxHardware.Controls.Add(this.marlinUpDnSERIAL_PORT);
            this.grpBxHardware.Location = new System.Drawing.Point(8, 239);
            this.grpBxHardware.Name = "grpBxHardware";
            this.grpBxHardware.Size = new System.Drawing.Size(608, 259);
            this.grpBxHardware.TabIndex = 10;
            this.grpBxHardware.TabStop = false;
            this.grpBxHardware.Text = "Hardware";
            // 
            // marlinComboBoxMOTHERBOARD
            // 
            this.marlinComboBoxMOTHERBOARD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxMOTHERBOARD.ControlText = "MotherBoard:";
            this.marlinComboBoxMOTHERBOARD.currentFirmwareHelper = null;
            this.marlinComboBoxMOTHERBOARD.Feature = "MOTHERBOARD";
            this.marlinComboBoxMOTHERBOARD.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motherboard";
            this.marlinComboBoxMOTHERBOARD.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxMOTHERBOARD.IsTrueFalse = false;
            this.marlinComboBoxMOTHERBOARD.Location = new System.Drawing.Point(151, 111);
            this.marlinComboBoxMOTHERBOARD.Name = "marlinComboBoxMOTHERBOARD";
            this.marlinComboBoxMOTHERBOARD.NewFirmwareHelper = null;
            this.marlinComboBoxMOTHERBOARD.Size = new System.Drawing.Size(451, 26);
            this.marlinComboBoxMOTHERBOARD.SpliterDistance = 80;
            this.marlinComboBoxMOTHERBOARD.TabIndex = 6;
            // 
            // marlinEnableValueMACHINE_UUID
            // 
            this.marlinEnableValueMACHINE_UUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueMACHINE_UUID.ControlText = "Unique Machine Identification (UUID)";
            this.marlinEnableValueMACHINE_UUID.currentFirmwareHelper = null;
            this.marlinEnableValueMACHINE_UUID.Feature = "MACHINE_UUID";
            this.marlinEnableValueMACHINE_UUID.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#machine-uuid";
            this.marlinEnableValueMACHINE_UUID.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueMACHINE_UUID.Location = new System.Drawing.Point(151, 175);
            this.marlinEnableValueMACHINE_UUID.Name = "marlinEnableValueMACHINE_UUID";
            this.marlinEnableValueMACHINE_UUID.NewFirmwareHelper = null;
            this.marlinEnableValueMACHINE_UUID.Size = new System.Drawing.Size(451, 26);
            this.marlinEnableValueMACHINE_UUID.SpliterDistance = 160;
            this.marlinEnableValueMACHINE_UUID.TabIndex = 5;
            // 
            // marlinEnableValueCUSTOM_MACHINE_NAME
            // 
            this.marlinEnableValueCUSTOM_MACHINE_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueCUSTOM_MACHINE_NAME.ControlText = "Custom Machine Name:";
            this.marlinEnableValueCUSTOM_MACHINE_NAME.currentFirmwareHelper = null;
            this.marlinEnableValueCUSTOM_MACHINE_NAME.Feature = "CUSTOM_MACHINE_NAME";
            this.marlinEnableValueCUSTOM_MACHINE_NAME.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#custom-machine-name";
            this.marlinEnableValueCUSTOM_MACHINE_NAME.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueCUSTOM_MACHINE_NAME.Location = new System.Drawing.Point(151, 143);
            this.marlinEnableValueCUSTOM_MACHINE_NAME.Name = "marlinEnableValueCUSTOM_MACHINE_NAME";
            this.marlinEnableValueCUSTOM_MACHINE_NAME.NewFirmwareHelper = null;
            this.marlinEnableValueCUSTOM_MACHINE_NAME.Size = new System.Drawing.Size(451, 26);
            this.marlinEnableValueCUSTOM_MACHINE_NAME.SpliterDistance = 133;
            this.marlinEnableValueCUSTOM_MACHINE_NAME.TabIndex = 4;
            // 
            // marlinCheckBoxBLUETOOTH
            // 
            this.marlinCheckBoxBLUETOOTH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxBLUETOOTH.ControlText = "BlueTooth";
            this.marlinCheckBoxBLUETOOTH.currentFirmwareHelper = null;
            this.marlinCheckBoxBLUETOOTH.Feature = "BLUETOOTH";
            this.marlinCheckBoxBLUETOOTH.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bluetooth";
            this.marlinCheckBoxBLUETOOTH.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxBLUETOOTH.Location = new System.Drawing.Point(471, 83);
            this.marlinCheckBoxBLUETOOTH.Name = "marlinCheckBoxBLUETOOTH";
            this.marlinCheckBoxBLUETOOTH.NewFirmwareHelper = null;
            this.marlinCheckBoxBLUETOOTH.Size = new System.Drawing.Size(131, 21);
            this.marlinCheckBoxBLUETOOTH.TabIndex = 2;
            // 
            // marlinValueBAUDRATE
            // 
            this.marlinValueBAUDRATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueBAUDRATE.ControlText = "Baud rate:";
            this.marlinValueBAUDRATE.currentFirmwareHelper = null;
            this.marlinValueBAUDRATE.Feature = "BAUDRATE";
            this.marlinValueBAUDRATE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#baud-rate";
            this.marlinValueBAUDRATE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueBAUDRATE.Location = new System.Drawing.Point(408, 51);
            this.marlinValueBAUDRATE.Name = "marlinValueBAUDRATE";
            this.marlinValueBAUDRATE.NewFirmwareHelper = null;
            this.marlinValueBAUDRATE.Size = new System.Drawing.Size(194, 26);
            this.marlinValueBAUDRATE.SpliterDistance = 56;
            this.marlinValueBAUDRATE.TabIndex = 1;
            // 
            // marlinUpDnSERIAL_PORT
            // 
            this.marlinUpDnSERIAL_PORT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnSERIAL_PORT.ControlText = "Serial Port:";
            this.marlinUpDnSERIAL_PORT.currentFirmwareHelper = null;
            this.marlinUpDnSERIAL_PORT.Feature = "SERIAL_PORT";
            this.marlinUpDnSERIAL_PORT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#serial-port";
            this.marlinUpDnSERIAL_PORT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnSERIAL_PORT.Location = new System.Drawing.Point(431, 19);
            this.marlinUpDnSERIAL_PORT.Max = 7;
            this.marlinUpDnSERIAL_PORT.Min = 0;
            this.marlinUpDnSERIAL_PORT.Name = "marlinUpDnSERIAL_PORT";
            this.marlinUpDnSERIAL_PORT.NewFirmwareHelper = null;
            this.marlinUpDnSERIAL_PORT.Size = new System.Drawing.Size(171, 26);
            this.marlinUpDnSERIAL_PORT.SpliterDistance = 57;
            this.marlinUpDnSERIAL_PORT.TabIndex = 0;
            // 
            // grpBxFirmwareInfo
            // 
            this.grpBxFirmwareInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxFirmwareInfo.Controls.Add(this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN);
            this.grpBxFirmwareInfo.Controls.Add(this.marlinValueSTRING_SPLASH_LINE2);
            this.grpBxFirmwareInfo.Controls.Add(this.marlinValueSTRING_SPLASH_LINE1);
            this.grpBxFirmwareInfo.Controls.Add(this.marlinCheckBoxSHOW_BOOTSCREEN);
            this.grpBxFirmwareInfo.Controls.Add(this.marlinValueStringConfigHAuthor);
            this.grpBxFirmwareInfo.Location = new System.Drawing.Point(8, 65);
            this.grpBxFirmwareInfo.Name = "grpBxFirmwareInfo";
            this.grpBxFirmwareInfo.Size = new System.Drawing.Size(608, 168);
            this.grpBxFirmwareInfo.TabIndex = 9;
            this.grpBxFirmwareInfo.TabStop = false;
            this.grpBxFirmwareInfo.Text = "Firmware Info";
            // 
            // marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN
            // 
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.ControlText = "Show Custom BootScreen";
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.currentFirmwareHelper = null;
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.Feature = "SHOW_CUSTOM_BOOTSCREEN";
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#firmware-info";
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.Location = new System.Drawing.Point(318, 141);
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.Name = "marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN";
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.NewFirmwareHelper = null;
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.Size = new System.Drawing.Size(284, 21);
            this.marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN.TabIndex = 4;
            // 
            // marlinValueSTRING_SPLASH_LINE2
            // 
            this.marlinValueSTRING_SPLASH_LINE2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueSTRING_SPLASH_LINE2.ControlText = "Shown at line 2 at boot time:";
            this.marlinValueSTRING_SPLASH_LINE2.currentFirmwareHelper = null;
            this.marlinValueSTRING_SPLASH_LINE2.Feature = "STRING_SPLASH_LINE2";
            this.marlinValueSTRING_SPLASH_LINE2.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#firmware-info";
            this.marlinValueSTRING_SPLASH_LINE2.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueSTRING_SPLASH_LINE2.Location = new System.Drawing.Point(151, 110);
            this.marlinValueSTRING_SPLASH_LINE2.Name = "marlinValueSTRING_SPLASH_LINE2";
            this.marlinValueSTRING_SPLASH_LINE2.NewFirmwareHelper = null;
            this.marlinValueSTRING_SPLASH_LINE2.Size = new System.Drawing.Size(451, 26);
            this.marlinValueSTRING_SPLASH_LINE2.SpliterDistance = 140;
            this.marlinValueSTRING_SPLASH_LINE2.TabIndex = 3;
            // 
            // marlinValueSTRING_SPLASH_LINE1
            // 
            this.marlinValueSTRING_SPLASH_LINE1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueSTRING_SPLASH_LINE1.ControlText = "Shown at line 1 at boot time:";
            this.marlinValueSTRING_SPLASH_LINE1.currentFirmwareHelper = null;
            this.marlinValueSTRING_SPLASH_LINE1.Feature = "STRING_SPLASH_LINE1";
            this.marlinValueSTRING_SPLASH_LINE1.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#firmware-info";
            this.marlinValueSTRING_SPLASH_LINE1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueSTRING_SPLASH_LINE1.Location = new System.Drawing.Point(151, 78);
            this.marlinValueSTRING_SPLASH_LINE1.Name = "marlinValueSTRING_SPLASH_LINE1";
            this.marlinValueSTRING_SPLASH_LINE1.NewFirmwareHelper = null;
            this.marlinValueSTRING_SPLASH_LINE1.Size = new System.Drawing.Size(451, 26);
            this.marlinValueSTRING_SPLASH_LINE1.SpliterDistance = 140;
            this.marlinValueSTRING_SPLASH_LINE1.TabIndex = 2;
            // 
            // marlinCheckBoxSHOW_BOOTSCREEN
            // 
            this.marlinCheckBoxSHOW_BOOTSCREEN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSHOW_BOOTSCREEN.ControlText = "Shoow Bootscreen";
            this.marlinCheckBoxSHOW_BOOTSCREEN.currentFirmwareHelper = null;
            this.marlinCheckBoxSHOW_BOOTSCREEN.Feature = "SHOW_BOOTSCREEN";
            this.marlinCheckBoxSHOW_BOOTSCREEN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#firmware-info";
            this.marlinCheckBoxSHOW_BOOTSCREEN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSHOW_BOOTSCREEN.Location = new System.Drawing.Point(318, 51);
            this.marlinCheckBoxSHOW_BOOTSCREEN.Name = "marlinCheckBoxSHOW_BOOTSCREEN";
            this.marlinCheckBoxSHOW_BOOTSCREEN.NewFirmwareHelper = null;
            this.marlinCheckBoxSHOW_BOOTSCREEN.Size = new System.Drawing.Size(284, 21);
            this.marlinCheckBoxSHOW_BOOTSCREEN.TabIndex = 1;
            // 
            // marlinValueStringConfigHAuthor
            // 
            this.marlinValueStringConfigHAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueStringConfigHAuthor.ControlText = "Configuration and Author:";
            this.marlinValueStringConfigHAuthor.currentFirmwareHelper = null;
            this.marlinValueStringConfigHAuthor.Feature = "STRING_CONFIG_H_AUTHOR";
            this.marlinValueStringConfigHAuthor.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#firmware-info";
            this.marlinValueStringConfigHAuthor.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueStringConfigHAuthor.Location = new System.Drawing.Point(151, 19);
            this.marlinValueStringConfigHAuthor.Name = "marlinValueStringConfigHAuthor";
            this.marlinValueStringConfigHAuthor.NewFirmwareHelper = null;
            this.marlinValueStringConfigHAuthor.Size = new System.Drawing.Size(451, 26);
            this.marlinValueStringConfigHAuthor.SpliterDistance = 130;
            this.marlinValueStringConfigHAuthor.TabIndex = 0;
            // 
            // tabPageExtruder
            // 
            this.tabPageExtruder.Controls.Add(this.marlinCheckBoxSINGLENOZZLE);
            this.tabPageExtruder.Controls.Add(this.marlinUpDnEXTRUDERS);
            this.tabPageExtruder.Controls.Add(this.grpBxExtruderOffset);
            this.tabPageExtruder.Controls.Add(this.grpBxMixingExtruders);
            this.tabPageExtruder.Controls.Add(this.grpBxSWITCHING_EXTRUDER);
            this.tabPageExtruder.Location = new System.Drawing.Point(4, 76);
            this.tabPageExtruder.Name = "tabPageExtruder";
            this.tabPageExtruder.Size = new System.Drawing.Size(622, 585);
            this.tabPageExtruder.TabIndex = 7;
            this.tabPageExtruder.Text = "Extruder";
            this.tabPageExtruder.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxSINGLENOZZLE
            // 
            this.marlinCheckBoxSINGLENOZZLE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSINGLENOZZLE.ControlText = "Single Nozzle";
            this.marlinCheckBoxSINGLENOZZLE.currentFirmwareHelper = null;
            this.marlinCheckBoxSINGLENOZZLE.Feature = "SINGLENOZZLE";
            this.marlinCheckBoxSINGLENOZZLE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#single-nozzle";
            this.marlinCheckBoxSINGLENOZZLE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSINGLENOZZLE.Location = new System.Drawing.Point(389, 45);
            this.marlinCheckBoxSINGLENOZZLE.Name = "marlinCheckBoxSINGLENOZZLE";
            this.marlinCheckBoxSINGLENOZZLE.NewFirmwareHelper = null;
            this.marlinCheckBoxSINGLENOZZLE.Size = new System.Drawing.Size(206, 21);
            this.marlinCheckBoxSINGLENOZZLE.TabIndex = 7;
            // 
            // marlinUpDnEXTRUDERS
            // 
            this.marlinUpDnEXTRUDERS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnEXTRUDERS.ControlText = "Number of Extruders:";
            this.marlinUpDnEXTRUDERS.currentFirmwareHelper = null;
            this.marlinUpDnEXTRUDERS.Feature = "EXTRUDERS";
            this.marlinUpDnEXTRUDERS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#extruders";
            this.marlinUpDnEXTRUDERS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnEXTRUDERS.Location = new System.Drawing.Point(389, 13);
            this.marlinUpDnEXTRUDERS.Max = 5;
            this.marlinUpDnEXTRUDERS.Min = 1;
            this.marlinUpDnEXTRUDERS.Name = "marlinUpDnEXTRUDERS";
            this.marlinUpDnEXTRUDERS.NewFirmwareHelper = null;
            this.marlinUpDnEXTRUDERS.Size = new System.Drawing.Size(206, 26);
            this.marlinUpDnEXTRUDERS.SpliterDistance = 121;
            this.marlinUpDnEXTRUDERS.TabIndex = 6;
            // 
            // grpBxExtruderOffset
            // 
            this.grpBxExtruderOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxExtruderOffset.Controls.Add(this.marlinEnableValueHOTEND_OFFSET_Y);
            this.grpBxExtruderOffset.Controls.Add(this.marlinEnableValueHOTEND_OFFSET_X);
            this.grpBxExtruderOffset.Location = new System.Drawing.Point(3, 378);
            this.grpBxExtruderOffset.Name = "grpBxExtruderOffset";
            this.grpBxExtruderOffset.Size = new System.Drawing.Size(598, 86);
            this.grpBxExtruderOffset.TabIndex = 5;
            this.grpBxExtruderOffset.TabStop = false;
            this.grpBxExtruderOffset.Text = "Extruder Offset";
            // 
            // marlinEnableValueHOTEND_OFFSET_Y
            // 
            this.marlinEnableValueHOTEND_OFFSET_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueHOTEND_OFFSET_Y.ControlText = "Hotend Offset Y";
            this.marlinEnableValueHOTEND_OFFSET_Y.currentFirmwareHelper = null;
            this.marlinEnableValueHOTEND_OFFSET_Y.Feature = "HOTEND_OFFSET_Y";
            this.marlinEnableValueHOTEND_OFFSET_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#hotend-offsets";
            this.marlinEnableValueHOTEND_OFFSET_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueHOTEND_OFFSET_Y.Location = new System.Drawing.Point(277, 51);
            this.marlinEnableValueHOTEND_OFFSET_Y.Name = "marlinEnableValueHOTEND_OFFSET_Y";
            this.marlinEnableValueHOTEND_OFFSET_Y.NewFirmwareHelper = null;
            this.marlinEnableValueHOTEND_OFFSET_Y.Size = new System.Drawing.Size(315, 26);
            this.marlinEnableValueHOTEND_OFFSET_Y.SpliterDistance = 100;
            this.marlinEnableValueHOTEND_OFFSET_Y.TabIndex = 1;
            // 
            // marlinEnableValueHOTEND_OFFSET_X
            // 
            this.marlinEnableValueHOTEND_OFFSET_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueHOTEND_OFFSET_X.ControlText = "Hotend Offset X";
            this.marlinEnableValueHOTEND_OFFSET_X.currentFirmwareHelper = null;
            this.marlinEnableValueHOTEND_OFFSET_X.Feature = "HOTEND_OFFSET_X";
            this.marlinEnableValueHOTEND_OFFSET_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#hotend-offsets";
            this.marlinEnableValueHOTEND_OFFSET_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueHOTEND_OFFSET_X.Location = new System.Drawing.Point(277, 19);
            this.marlinEnableValueHOTEND_OFFSET_X.Name = "marlinEnableValueHOTEND_OFFSET_X";
            this.marlinEnableValueHOTEND_OFFSET_X.NewFirmwareHelper = null;
            this.marlinEnableValueHOTEND_OFFSET_X.Size = new System.Drawing.Size(315, 26);
            this.marlinEnableValueHOTEND_OFFSET_X.SpliterDistance = 100;
            this.marlinEnableValueHOTEND_OFFSET_X.TabIndex = 0;
            // 
            // grpBxMixingExtruders
            // 
            this.grpBxMixingExtruders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxMixingExtruders.Controls.Add(this.marlinCheckBoxDIRECT_MIXING_IN_G1);
            this.grpBxMixingExtruders.Controls.Add(this.marlinUpDnMIXING_VIRTUAL_TOOLS);
            this.grpBxMixingExtruders.Controls.Add(this.marlinUpDnMIXING_STEPPERS);
            this.grpBxMixingExtruders.Controls.Add(this.marlinCheckBoxMIXING_EXTRUDER);
            this.grpBxMixingExtruders.Location = new System.Drawing.Point(3, 231);
            this.grpBxMixingExtruders.Name = "grpBxMixingExtruders";
            this.grpBxMixingExtruders.Size = new System.Drawing.Size(598, 141);
            this.grpBxMixingExtruders.TabIndex = 4;
            this.grpBxMixingExtruders.TabStop = false;
            this.grpBxMixingExtruders.Text = "Mixing Extruders";
            // 
            // marlinCheckBoxDIRECT_MIXING_IN_G1
            // 
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.ControlText = "Allow ABCDHI mix factors in G1 movement commands";
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.currentFirmwareHelper = null;
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.Feature = "DIRECT_MIXING_IN_G1";
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#mixing-extruder";
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.Location = new System.Drawing.Point(258, 111);
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.Name = "marlinCheckBoxDIRECT_MIXING_IN_G1";
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.NewFirmwareHelper = null;
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.Size = new System.Drawing.Size(334, 21);
            this.marlinCheckBoxDIRECT_MIXING_IN_G1.TabIndex = 3;
            // 
            // marlinUpDnMIXING_VIRTUAL_TOOLS
            // 
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.ControlText = "Use the Virtual Tool method with M163 and M164:";
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.currentFirmwareHelper = null;
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.Feature = "MIXING_VIRTUAL_TOOLS";
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#mixing-extruder";
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.Location = new System.Drawing.Point(258, 79);
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.Max = 64;
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.Min = 0;
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.Name = "marlinUpDnMIXING_VIRTUAL_TOOLS";
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.NewFirmwareHelper = null;
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.Size = new System.Drawing.Size(334, 26);
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.SpliterDistance = 249;
            this.marlinUpDnMIXING_VIRTUAL_TOOLS.TabIndex = 2;
            // 
            // marlinUpDnMIXING_STEPPERS
            // 
            this.marlinUpDnMIXING_STEPPERS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnMIXING_STEPPERS.ControlText = "Number of steppers in your mixing extruder:";
            this.marlinUpDnMIXING_STEPPERS.currentFirmwareHelper = null;
            this.marlinUpDnMIXING_STEPPERS.Feature = "MIXING_STEPPERS";
            this.marlinUpDnMIXING_STEPPERS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#switching-extruder";
            this.marlinUpDnMIXING_STEPPERS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnMIXING_STEPPERS.Location = new System.Drawing.Point(312, 46);
            this.marlinUpDnMIXING_STEPPERS.Max = 5;
            this.marlinUpDnMIXING_STEPPERS.Min = 2;
            this.marlinUpDnMIXING_STEPPERS.Name = "marlinUpDnMIXING_STEPPERS";
            this.marlinUpDnMIXING_STEPPERS.NewFirmwareHelper = null;
            this.marlinUpDnMIXING_STEPPERS.Size = new System.Drawing.Size(280, 26);
            this.marlinUpDnMIXING_STEPPERS.SpliterDistance = 210;
            this.marlinUpDnMIXING_STEPPERS.TabIndex = 1;
            // 
            // marlinCheckBoxMIXING_EXTRUDER
            // 
            this.marlinCheckBoxMIXING_EXTRUDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxMIXING_EXTRUDER.ControlText = "Mixing Extruder";
            this.marlinCheckBoxMIXING_EXTRUDER.currentFirmwareHelper = null;
            this.marlinCheckBoxMIXING_EXTRUDER.Feature = "MIXING_EXTRUDER";
            this.marlinCheckBoxMIXING_EXTRUDER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#mixing-extruder";
            this.marlinCheckBoxMIXING_EXTRUDER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxMIXING_EXTRUDER.Location = new System.Drawing.Point(386, 19);
            this.marlinCheckBoxMIXING_EXTRUDER.Name = "marlinCheckBoxMIXING_EXTRUDER";
            this.marlinCheckBoxMIXING_EXTRUDER.NewFirmwareHelper = null;
            this.marlinCheckBoxMIXING_EXTRUDER.Size = new System.Drawing.Size(206, 21);
            this.marlinCheckBoxMIXING_EXTRUDER.TabIndex = 0;
            // 
            // grpBxSWITCHING_EXTRUDER
            // 
            this.grpBxSWITCHING_EXTRUDER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxSWITCHING_EXTRUDER.Controls.Add(this.marlinEnableValueHOTEND_OFFSET_Z);
            this.grpBxSWITCHING_EXTRUDER.Controls.Add(this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES);
            this.grpBxSWITCHING_EXTRUDER.Controls.Add(this.marlinUpDnSWITCHING_EXTRUDER_SERVO);
            this.grpBxSWITCHING_EXTRUDER.Controls.Add(this.marlinCheckBoxSWITCHING_EXTRUDER);
            this.grpBxSWITCHING_EXTRUDER.Location = new System.Drawing.Point(3, 72);
            this.grpBxSWITCHING_EXTRUDER.Name = "grpBxSWITCHING_EXTRUDER";
            this.grpBxSWITCHING_EXTRUDER.Size = new System.Drawing.Size(598, 153);
            this.grpBxSWITCHING_EXTRUDER.TabIndex = 3;
            this.grpBxSWITCHING_EXTRUDER.TabStop = false;
            this.grpBxSWITCHING_EXTRUDER.Text = "Switching extruder";
            // 
            // marlinEnableValueHOTEND_OFFSET_Z
            // 
            this.marlinEnableValueHOTEND_OFFSET_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueHOTEND_OFFSET_Z.ControlText = "Hotend offset Z:";
            this.marlinEnableValueHOTEND_OFFSET_Z.currentFirmwareHelper = null;
            this.marlinEnableValueHOTEND_OFFSET_Z.Feature = "HOTEND_OFFSET_Z";
            this.marlinEnableValueHOTEND_OFFSET_Z.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#switching-extruder";
            this.marlinEnableValueHOTEND_OFFSET_Z.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueHOTEND_OFFSET_Z.Location = new System.Drawing.Point(301, 110);
            this.marlinEnableValueHOTEND_OFFSET_Z.Name = "marlinEnableValueHOTEND_OFFSET_Z";
            this.marlinEnableValueHOTEND_OFFSET_Z.NewFirmwareHelper = null;
            this.marlinEnableValueHOTEND_OFFSET_Z.Size = new System.Drawing.Size(291, 26);
            this.marlinEnableValueHOTEND_OFFSET_Z.SpliterDistance = 100;
            this.marlinEnableValueHOTEND_OFFSET_Z.TabIndex = 3;
            // 
            // marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES
            // 
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.ControlText = "Switching extruder Servo angles:";
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.currentFirmwareHelper = null;
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.Feature = "SWITCHING_EXTRUDER_SERVO_ANGLES";
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#switching-extruder";
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.Location = new System.Drawing.Point(293, 78);
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.Name = "marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES";
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.NewFirmwareHelper = null;
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.Size = new System.Drawing.Size(299, 26);
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.SpliterDistance = 160;
            this.marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES.TabIndex = 2;
            // 
            // marlinUpDnSWITCHING_EXTRUDER_SERVO
            // 
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.ControlText = "Switching Servo number:";
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.currentFirmwareHelper = null;
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.Feature = "SWITCHING_EXTRUDER_SERVO";
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#switching-extruder";
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.Location = new System.Drawing.Point(386, 46);
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.Max = 4;
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.Min = 0;
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.Name = "marlinUpDnSWITCHING_EXTRUDER_SERVO";
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.NewFirmwareHelper = null;
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.Size = new System.Drawing.Size(206, 26);
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.SpliterDistance = 125;
            this.marlinUpDnSWITCHING_EXTRUDER_SERVO.TabIndex = 1;
            // 
            // marlinCheckBoxSWITCHING_EXTRUDER
            // 
            this.marlinCheckBoxSWITCHING_EXTRUDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSWITCHING_EXTRUDER.ControlText = "Switching Extruder:";
            this.marlinCheckBoxSWITCHING_EXTRUDER.currentFirmwareHelper = null;
            this.marlinCheckBoxSWITCHING_EXTRUDER.Feature = "SWITCHING_EXTRUDER";
            this.marlinCheckBoxSWITCHING_EXTRUDER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#switching-extruder";
            this.marlinCheckBoxSWITCHING_EXTRUDER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSWITCHING_EXTRUDER.Location = new System.Drawing.Point(386, 19);
            this.marlinCheckBoxSWITCHING_EXTRUDER.Name = "marlinCheckBoxSWITCHING_EXTRUDER";
            this.marlinCheckBoxSWITCHING_EXTRUDER.NewFirmwareHelper = null;
            this.marlinCheckBoxSWITCHING_EXTRUDER.Size = new System.Drawing.Size(206, 21);
            this.marlinCheckBoxSWITCHING_EXTRUDER.TabIndex = 0;
            // 
            // tabPagePowerSupply
            // 
            this.tabPagePowerSupply.Controls.Add(this.marlinCheckBoxPS_DEFAULT_OFF);
            this.tabPagePowerSupply.Controls.Add(this.marlinUpDnPOWER_SUPPLY);
            this.tabPagePowerSupply.Location = new System.Drawing.Point(4, 76);
            this.tabPagePowerSupply.Name = "tabPagePowerSupply";
            this.tabPagePowerSupply.Size = new System.Drawing.Size(622, 585);
            this.tabPagePowerSupply.TabIndex = 8;
            this.tabPagePowerSupply.Text = "Power Supply";
            this.tabPagePowerSupply.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxPS_DEFAULT_OFF
            // 
            this.marlinCheckBoxPS_DEFAULT_OFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPS_DEFAULT_OFF.ControlText = "Power Supply Default Off";
            this.marlinCheckBoxPS_DEFAULT_OFF.currentFirmwareHelper = null;
            this.marlinCheckBoxPS_DEFAULT_OFF.Feature = "PS_DEFAULT_OFF";
            this.marlinCheckBoxPS_DEFAULT_OFF.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#power-supply";
            this.marlinCheckBoxPS_DEFAULT_OFF.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPS_DEFAULT_OFF.Location = new System.Drawing.Point(405, 52);
            this.marlinCheckBoxPS_DEFAULT_OFF.Name = "marlinCheckBoxPS_DEFAULT_OFF";
            this.marlinCheckBoxPS_DEFAULT_OFF.NewFirmwareHelper = null;
            this.marlinCheckBoxPS_DEFAULT_OFF.Size = new System.Drawing.Size(173, 21);
            this.marlinCheckBoxPS_DEFAULT_OFF.TabIndex = 1;
            // 
            // marlinUpDnPOWER_SUPPLY
            // 
            this.marlinUpDnPOWER_SUPPLY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPOWER_SUPPLY.ControlText = "Power Supply:";
            this.marlinUpDnPOWER_SUPPLY.currentFirmwareHelper = null;
            this.marlinUpDnPOWER_SUPPLY.Feature = "POWER_SUPPLY";
            this.marlinUpDnPOWER_SUPPLY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#power-supply";
            this.marlinUpDnPOWER_SUPPLY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPOWER_SUPPLY.Location = new System.Drawing.Point(420, 20);
            this.marlinUpDnPOWER_SUPPLY.Max = 2;
            this.marlinUpDnPOWER_SUPPLY.Min = 0;
            this.marlinUpDnPOWER_SUPPLY.Name = "marlinUpDnPOWER_SUPPLY";
            this.marlinUpDnPOWER_SUPPLY.NewFirmwareHelper = null;
            this.marlinUpDnPOWER_SUPPLY.Size = new System.Drawing.Size(158, 26);
            this.marlinUpDnPOWER_SUPPLY.SpliterDistance = 80;
            this.marlinUpDnPOWER_SUPPLY.TabIndex = 0;
            // 
            // tabPageTemperatureSensor
            // 
            this.tabPageTemperatureSensor.Controls.Add(this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinUpDnDUMMY_THERMISTOR_999_VALUE);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinUpDnDUMMY_THERMISTOR_998_VALUE);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinComboBoxTEMP_SENSOR_BED);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinComboBoxTEMP_SENSOR_0);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinComboBoxTEMP_SENSOR_1);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinComboBoxTEMP_SENSOR_2);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinComboBoxTEMP_SENSOR_3);
            this.tabPageTemperatureSensor.Controls.Add(this.marlinComboBoxTEMP_SENSOR_4);
            this.tabPageTemperatureSensor.Location = new System.Drawing.Point(4, 76);
            this.tabPageTemperatureSensor.Name = "tabPageTemperatureSensor";
            this.tabPageTemperatureSensor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemperatureSensor.Size = new System.Drawing.Size(622, 585);
            this.tabPageTemperatureSensor.TabIndex = 1;
            this.tabPageTemperatureSensor.Text = "Temperature Sensor";
            this.tabPageTemperatureSensor.UseVisualStyleBackColor = true;
            // 
            // marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF
            // 
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.ControlText = "Max redundant temperature diff";
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.currentFirmwareHelper = null;
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.Feature = "MAX_REDUNDANT_TEMP_SENSOR_DIFF";
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.Location = new System.Drawing.Point(290, 108);
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.Max = 20;
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.Min = 0;
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.Name = "marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF";
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.NewFirmwareHelper = null;
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.Size = new System.Drawing.Size(326, 26);
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.SpliterDistance = 180;
            this.marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF.TabIndex = 6;
            // 
            // marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT
            // 
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.ControlText = "Use temp sensor 1 as a redundant sensor with sensor 0";
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.currentFirmwareHelper = null;
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.Feature = "TEMP_SENSOR_1_AS_REDUNDANT";
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.Location = new System.Drawing.Point(296, 81);
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.Name = "marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT";
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.NewFirmwareHelper = null;
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.Size = new System.Drawing.Size(320, 21);
            this.marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT.TabIndex = 5;
            // 
            // marlinUpDnDUMMY_THERMISTOR_999_VALUE
            // 
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.ControlText = "Dummy thermistor constant temperature readings 999";
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.currentFirmwareHelper = null;
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.Feature = "DUMMY_THERMISTOR_999_VALUE";
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.Location = new System.Drawing.Point(169, 377);
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.Max = 275;
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.Min = 0;
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.Name = "marlinUpDnDUMMY_THERMISTOR_999_VALUE";
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.NewFirmwareHelper = null;
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.Size = new System.Drawing.Size(447, 26);
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.SpliterDistance = 270;
            this.marlinUpDnDUMMY_THERMISTOR_999_VALUE.TabIndex = 4;
            // 
            // marlinUpDnDUMMY_THERMISTOR_998_VALUE
            // 
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.ControlText = "Dummy thermistor constant temperature readings 998";
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.currentFirmwareHelper = null;
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.Feature = "DUMMY_THERMISTOR_998_VALUE";
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.Location = new System.Drawing.Point(169, 345);
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.Max = 275;
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.Min = 0;
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.Name = "marlinUpDnDUMMY_THERMISTOR_998_VALUE";
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.NewFirmwareHelper = null;
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.Size = new System.Drawing.Size(447, 26);
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.SpliterDistance = 270;
            this.marlinUpDnDUMMY_THERMISTOR_998_VALUE.TabIndex = 3;
            // 
            // marlinComboBoxTEMP_SENSOR_BED
            // 
            this.marlinComboBoxTEMP_SENSOR_BED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxTEMP_SENSOR_BED.ControlText = "Bed Sensor:";
            this.marlinComboBoxTEMP_SENSOR_BED.currentFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_BED.Feature = "TEMP_SENSOR_BED ";
            this.marlinComboBoxTEMP_SENSOR_BED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinComboBoxTEMP_SENSOR_BED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxTEMP_SENSOR_BED.IsTrueFalse = false;
            this.marlinComboBoxTEMP_SENSOR_BED.Location = new System.Drawing.Point(147, 304);
            this.marlinComboBoxTEMP_SENSOR_BED.Name = "marlinComboBoxTEMP_SENSOR_BED";
            this.marlinComboBoxTEMP_SENSOR_BED.NewFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_BED.Size = new System.Drawing.Size(469, 26);
            this.marlinComboBoxTEMP_SENSOR_BED.SpliterDistance = 60;
            this.marlinComboBoxTEMP_SENSOR_BED.TabIndex = 2;
            // 
            // marlinComboBoxTEMP_SENSOR_0
            // 
            this.marlinComboBoxTEMP_SENSOR_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxTEMP_SENSOR_0.ControlText = "Sensor 0:";
            this.marlinComboBoxTEMP_SENSOR_0.currentFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_0.Feature = "TEMP_SENSOR_0";
            this.marlinComboBoxTEMP_SENSOR_0.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinComboBoxTEMP_SENSOR_0.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxTEMP_SENSOR_0.IsTrueFalse = false;
            this.marlinComboBoxTEMP_SENSOR_0.Location = new System.Drawing.Point(147, 17);
            this.marlinComboBoxTEMP_SENSOR_0.Name = "marlinComboBoxTEMP_SENSOR_0";
            this.marlinComboBoxTEMP_SENSOR_0.NewFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_0.Size = new System.Drawing.Size(469, 26);
            this.marlinComboBoxTEMP_SENSOR_0.SpliterDistance = 50;
            this.marlinComboBoxTEMP_SENSOR_0.TabIndex = 0;
            // 
            // marlinComboBoxTEMP_SENSOR_1
            // 
            this.marlinComboBoxTEMP_SENSOR_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxTEMP_SENSOR_1.ControlText = "Sensor 1:";
            this.marlinComboBoxTEMP_SENSOR_1.currentFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_1.Feature = "TEMP_SENSOR_1";
            this.marlinComboBoxTEMP_SENSOR_1.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinComboBoxTEMP_SENSOR_1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxTEMP_SENSOR_1.IsTrueFalse = false;
            this.marlinComboBoxTEMP_SENSOR_1.Location = new System.Drawing.Point(147, 49);
            this.marlinComboBoxTEMP_SENSOR_1.Name = "marlinComboBoxTEMP_SENSOR_1";
            this.marlinComboBoxTEMP_SENSOR_1.NewFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_1.Size = new System.Drawing.Size(469, 26);
            this.marlinComboBoxTEMP_SENSOR_1.SpliterDistance = 50;
            this.marlinComboBoxTEMP_SENSOR_1.TabIndex = 1;
            // 
            // marlinComboBoxTEMP_SENSOR_2
            // 
            this.marlinComboBoxTEMP_SENSOR_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxTEMP_SENSOR_2.ControlText = "Sensor 2:";
            this.marlinComboBoxTEMP_SENSOR_2.currentFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_2.Feature = "TEMP_SENSOR_2";
            this.marlinComboBoxTEMP_SENSOR_2.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinComboBoxTEMP_SENSOR_2.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxTEMP_SENSOR_2.IsTrueFalse = false;
            this.marlinComboBoxTEMP_SENSOR_2.Location = new System.Drawing.Point(147, 180);
            this.marlinComboBoxTEMP_SENSOR_2.Name = "marlinComboBoxTEMP_SENSOR_2";
            this.marlinComboBoxTEMP_SENSOR_2.NewFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_2.Size = new System.Drawing.Size(469, 26);
            this.marlinComboBoxTEMP_SENSOR_2.SpliterDistance = 50;
            this.marlinComboBoxTEMP_SENSOR_2.TabIndex = 1;
            // 
            // marlinComboBoxTEMP_SENSOR_3
            // 
            this.marlinComboBoxTEMP_SENSOR_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxTEMP_SENSOR_3.ControlText = "Sensor 3:";
            this.marlinComboBoxTEMP_SENSOR_3.currentFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_3.Feature = "TEMP_SENSOR_3";
            this.marlinComboBoxTEMP_SENSOR_3.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinComboBoxTEMP_SENSOR_3.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxTEMP_SENSOR_3.IsTrueFalse = false;
            this.marlinComboBoxTEMP_SENSOR_3.Location = new System.Drawing.Point(147, 212);
            this.marlinComboBoxTEMP_SENSOR_3.Name = "marlinComboBoxTEMP_SENSOR_3";
            this.marlinComboBoxTEMP_SENSOR_3.NewFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_3.Size = new System.Drawing.Size(469, 26);
            this.marlinComboBoxTEMP_SENSOR_3.SpliterDistance = 50;
            this.marlinComboBoxTEMP_SENSOR_3.TabIndex = 1;
            // 
            // marlinComboBoxTEMP_SENSOR_4
            // 
            this.marlinComboBoxTEMP_SENSOR_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxTEMP_SENSOR_4.ControlText = "Sensor 4:";
            this.marlinComboBoxTEMP_SENSOR_4.currentFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_4.Feature = "TEMP_SENSOR_4";
            this.marlinComboBoxTEMP_SENSOR_4.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-sensors";
            this.marlinComboBoxTEMP_SENSOR_4.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxTEMP_SENSOR_4.IsTrueFalse = false;
            this.marlinComboBoxTEMP_SENSOR_4.Location = new System.Drawing.Point(147, 244);
            this.marlinComboBoxTEMP_SENSOR_4.Name = "marlinComboBoxTEMP_SENSOR_4";
            this.marlinComboBoxTEMP_SENSOR_4.NewFirmwareHelper = null;
            this.marlinComboBoxTEMP_SENSOR_4.Size = new System.Drawing.Size(469, 26);
            this.marlinComboBoxTEMP_SENSOR_4.SpliterDistance = 50;
            this.marlinComboBoxTEMP_SENSOR_4.TabIndex = 1;
            // 
            // tabPageTemperatureStability
            // 
            this.tabPageTemperatureStability.Controls.Add(this.grpBxTemperatureStabilityBed);
            this.tabPageTemperatureStability.Controls.Add(this.grpBxTemperatureStabilityExtruder);
            this.tabPageTemperatureStability.Location = new System.Drawing.Point(4, 76);
            this.tabPageTemperatureStability.Name = "tabPageTemperatureStability";
            this.tabPageTemperatureStability.Size = new System.Drawing.Size(622, 585);
            this.tabPageTemperatureStability.TabIndex = 9;
            this.tabPageTemperatureStability.Text = "Temperature Stability";
            this.tabPageTemperatureStability.UseVisualStyleBackColor = true;
            // 
            // grpBxTemperatureStabilityBed
            // 
            this.grpBxTemperatureStabilityBed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxTemperatureStabilityBed.Controls.Add(this.marlinUpDnTEMP_BED_WINDOW);
            this.grpBxTemperatureStabilityBed.Controls.Add(this.marlinUpDnTEMP_BED_RESIDENCY_TIME);
            this.grpBxTemperatureStabilityBed.Controls.Add(this.marlinUpDnTEMP_BED_HYSTERESIS);
            this.grpBxTemperatureStabilityBed.Location = new System.Drawing.Point(5, 126);
            this.grpBxTemperatureStabilityBed.Name = "grpBxTemperatureStabilityBed";
            this.grpBxTemperatureStabilityBed.Size = new System.Drawing.Size(614, 117);
            this.grpBxTemperatureStabilityBed.TabIndex = 4;
            this.grpBxTemperatureStabilityBed.TabStop = false;
            this.grpBxTemperatureStabilityBed.Text = "Temperature Stability Bed";
            // 
            // marlinUpDnTEMP_BED_WINDOW
            // 
            this.marlinUpDnTEMP_BED_WINDOW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnTEMP_BED_WINDOW.ControlText = "Bed Temperature Window:";
            this.marlinUpDnTEMP_BED_WINDOW.currentFirmwareHelper = null;
            this.marlinUpDnTEMP_BED_WINDOW.Feature = "TEMP_BED_WINDOW";
            this.marlinUpDnTEMP_BED_WINDOW.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-stability";
            this.marlinUpDnTEMP_BED_WINDOW.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnTEMP_BED_WINDOW.Location = new System.Drawing.Point(317, 77);
            this.marlinUpDnTEMP_BED_WINDOW.Max = 20;
            this.marlinUpDnTEMP_BED_WINDOW.Min = 0;
            this.marlinUpDnTEMP_BED_WINDOW.Name = "marlinUpDnTEMP_BED_WINDOW";
            this.marlinUpDnTEMP_BED_WINDOW.NewFirmwareHelper = null;
            this.marlinUpDnTEMP_BED_WINDOW.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnTEMP_BED_WINDOW.SpliterDistance = 180;
            this.marlinUpDnTEMP_BED_WINDOW.TabIndex = 5;
            // 
            // marlinUpDnTEMP_BED_RESIDENCY_TIME
            // 
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.ControlText = "Bed Temperature Residency Time:";
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.currentFirmwareHelper = null;
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.Feature = "TEMP_BED_RESIDENCY_TIME";
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-stability";
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.Location = new System.Drawing.Point(317, 13);
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.Max = 20;
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.Min = 0;
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.Name = "marlinUpDnTEMP_BED_RESIDENCY_TIME";
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.NewFirmwareHelper = null;
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.SpliterDistance = 180;
            this.marlinUpDnTEMP_BED_RESIDENCY_TIME.TabIndex = 3;
            // 
            // marlinUpDnTEMP_BED_HYSTERESIS
            // 
            this.marlinUpDnTEMP_BED_HYSTERESIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnTEMP_BED_HYSTERESIS.ControlText = "Bed Temperature Hysteresis:";
            this.marlinUpDnTEMP_BED_HYSTERESIS.currentFirmwareHelper = null;
            this.marlinUpDnTEMP_BED_HYSTERESIS.Feature = "TEMP_BED_HYSTERESIS";
            this.marlinUpDnTEMP_BED_HYSTERESIS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-stability";
            this.marlinUpDnTEMP_BED_HYSTERESIS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnTEMP_BED_HYSTERESIS.Location = new System.Drawing.Point(317, 45);
            this.marlinUpDnTEMP_BED_HYSTERESIS.Max = 20;
            this.marlinUpDnTEMP_BED_HYSTERESIS.Min = 0;
            this.marlinUpDnTEMP_BED_HYSTERESIS.Name = "marlinUpDnTEMP_BED_HYSTERESIS";
            this.marlinUpDnTEMP_BED_HYSTERESIS.NewFirmwareHelper = null;
            this.marlinUpDnTEMP_BED_HYSTERESIS.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnTEMP_BED_HYSTERESIS.SpliterDistance = 180;
            this.marlinUpDnTEMP_BED_HYSTERESIS.TabIndex = 4;
            // 
            // grpBxTemperatureStabilityExtruder
            // 
            this.grpBxTemperatureStabilityExtruder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxTemperatureStabilityExtruder.Controls.Add(this.marlinUpDnTEMP_WINDOW);
            this.grpBxTemperatureStabilityExtruder.Controls.Add(this.marlinUpDnTEMP_HYSTERESIS);
            this.grpBxTemperatureStabilityExtruder.Controls.Add(this.marlinUpDnTEMP_RESIDENCY_TIME);
            this.grpBxTemperatureStabilityExtruder.Location = new System.Drawing.Point(5, 3);
            this.grpBxTemperatureStabilityExtruder.Name = "grpBxTemperatureStabilityExtruder";
            this.grpBxTemperatureStabilityExtruder.Size = new System.Drawing.Size(614, 117);
            this.grpBxTemperatureStabilityExtruder.TabIndex = 3;
            this.grpBxTemperatureStabilityExtruder.TabStop = false;
            this.grpBxTemperatureStabilityExtruder.Text = "Temperature Stability Extruder";
            // 
            // marlinUpDnTEMP_WINDOW
            // 
            this.marlinUpDnTEMP_WINDOW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnTEMP_WINDOW.ControlText = "Temperature Window:";
            this.marlinUpDnTEMP_WINDOW.currentFirmwareHelper = null;
            this.marlinUpDnTEMP_WINDOW.Feature = "TEMP_WINDOW";
            this.marlinUpDnTEMP_WINDOW.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-stability";
            this.marlinUpDnTEMP_WINDOW.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnTEMP_WINDOW.Location = new System.Drawing.Point(317, 74);
            this.marlinUpDnTEMP_WINDOW.Max = 20;
            this.marlinUpDnTEMP_WINDOW.Min = 0;
            this.marlinUpDnTEMP_WINDOW.Name = "marlinUpDnTEMP_WINDOW";
            this.marlinUpDnTEMP_WINDOW.NewFirmwareHelper = null;
            this.marlinUpDnTEMP_WINDOW.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnTEMP_WINDOW.SpliterDistance = 180;
            this.marlinUpDnTEMP_WINDOW.TabIndex = 2;
            // 
            // marlinUpDnTEMP_HYSTERESIS
            // 
            this.marlinUpDnTEMP_HYSTERESIS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnTEMP_HYSTERESIS.ControlText = "Temperature Hysteresis:";
            this.marlinUpDnTEMP_HYSTERESIS.currentFirmwareHelper = null;
            this.marlinUpDnTEMP_HYSTERESIS.Feature = "TEMP_HYSTERESIS";
            this.marlinUpDnTEMP_HYSTERESIS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-stability";
            this.marlinUpDnTEMP_HYSTERESIS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnTEMP_HYSTERESIS.Location = new System.Drawing.Point(317, 42);
            this.marlinUpDnTEMP_HYSTERESIS.Max = 20;
            this.marlinUpDnTEMP_HYSTERESIS.Min = 0;
            this.marlinUpDnTEMP_HYSTERESIS.Name = "marlinUpDnTEMP_HYSTERESIS";
            this.marlinUpDnTEMP_HYSTERESIS.NewFirmwareHelper = null;
            this.marlinUpDnTEMP_HYSTERESIS.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnTEMP_HYSTERESIS.SpliterDistance = 180;
            this.marlinUpDnTEMP_HYSTERESIS.TabIndex = 1;
            // 
            // marlinUpDnTEMP_RESIDENCY_TIME
            // 
            this.marlinUpDnTEMP_RESIDENCY_TIME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnTEMP_RESIDENCY_TIME.ControlText = "Temperature Residency Time:";
            this.marlinUpDnTEMP_RESIDENCY_TIME.currentFirmwareHelper = null;
            this.marlinUpDnTEMP_RESIDENCY_TIME.Feature = "TEMP_RESIDENCY_TIME";
            this.marlinUpDnTEMP_RESIDENCY_TIME.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-stability";
            this.marlinUpDnTEMP_RESIDENCY_TIME.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnTEMP_RESIDENCY_TIME.Location = new System.Drawing.Point(317, 10);
            this.marlinUpDnTEMP_RESIDENCY_TIME.Max = 20;
            this.marlinUpDnTEMP_RESIDENCY_TIME.Min = 0;
            this.marlinUpDnTEMP_RESIDENCY_TIME.Name = "marlinUpDnTEMP_RESIDENCY_TIME";
            this.marlinUpDnTEMP_RESIDENCY_TIME.NewFirmwareHelper = null;
            this.marlinUpDnTEMP_RESIDENCY_TIME.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnTEMP_RESIDENCY_TIME.SpliterDistance = 180;
            this.marlinUpDnTEMP_RESIDENCY_TIME.TabIndex = 0;
            // 
            // tabPageTemperatures
            // 
            this.tabPageTemperatures.Controls.Add(this.grpBxMinTemperatureBed);
            this.tabPageTemperatures.Controls.Add(this.grpBxMinTemperatureExtruders);
            this.tabPageTemperatures.Location = new System.Drawing.Point(4, 76);
            this.tabPageTemperatures.Name = "tabPageTemperatures";
            this.tabPageTemperatures.Size = new System.Drawing.Size(622, 585);
            this.tabPageTemperatures.TabIndex = 10;
            this.tabPageTemperatures.Text = "Temperatures";
            this.tabPageTemperatures.UseVisualStyleBackColor = true;
            // 
            // grpBxMinTemperatureBed
            // 
            this.grpBxMinTemperatureBed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxMinTemperatureBed.Controls.Add(this.marlinUpDnBED_MAXTEMP);
            this.grpBxMinTemperatureBed.Controls.Add(this.marlinUpDnBED_MINTEMP);
            this.grpBxMinTemperatureBed.Location = new System.Drawing.Point(8, 380);
            this.grpBxMinTemperatureBed.Name = "grpBxMinTemperatureBed";
            this.grpBxMinTemperatureBed.Size = new System.Drawing.Size(597, 83);
            this.grpBxMinTemperatureBed.TabIndex = 5;
            this.grpBxMinTemperatureBed.TabStop = false;
            this.grpBxMinTemperatureBed.Text = "Bed";
            // 
            // marlinUpDnBED_MAXTEMP
            // 
            this.marlinUpDnBED_MAXTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnBED_MAXTEMP.ControlText = "Maximum Temperature Bed:";
            this.marlinUpDnBED_MAXTEMP.currentFirmwareHelper = null;
            this.marlinUpDnBED_MAXTEMP.Feature = "BED_MAXTEMP";
            this.marlinUpDnBED_MAXTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnBED_MAXTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnBED_MAXTEMP.Location = new System.Drawing.Point(300, 42);
            this.marlinUpDnBED_MAXTEMP.Max = 150;
            this.marlinUpDnBED_MAXTEMP.Min = 20;
            this.marlinUpDnBED_MAXTEMP.Name = "marlinUpDnBED_MAXTEMP";
            this.marlinUpDnBED_MAXTEMP.NewFirmwareHelper = null;
            this.marlinUpDnBED_MAXTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnBED_MAXTEMP.SpliterDistance = 180;
            this.marlinUpDnBED_MAXTEMP.TabIndex = 11;
            // 
            // marlinUpDnBED_MINTEMP
            // 
            this.marlinUpDnBED_MINTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnBED_MINTEMP.ControlText = "Minimum Temperature Bed:";
            this.marlinUpDnBED_MINTEMP.currentFirmwareHelper = null;
            this.marlinUpDnBED_MINTEMP.Feature = "BED_MINTEMP";
            this.marlinUpDnBED_MINTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnBED_MINTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnBED_MINTEMP.Location = new System.Drawing.Point(300, 19);
            this.marlinUpDnBED_MINTEMP.Max = 50;
            this.marlinUpDnBED_MINTEMP.Min = 0;
            this.marlinUpDnBED_MINTEMP.Name = "marlinUpDnBED_MINTEMP";
            this.marlinUpDnBED_MINTEMP.NewFirmwareHelper = null;
            this.marlinUpDnBED_MINTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnBED_MINTEMP.SpliterDistance = 180;
            this.marlinUpDnBED_MINTEMP.TabIndex = 10;
            // 
            // grpBxMinTemperatureExtruders
            // 
            this.grpBxMinTemperatureExtruders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_4_MAXTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_3_MAXTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_2_MAXTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_1_MAXTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_0_MAXTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_4_MINTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_3_MINTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_2_MINTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_1_MINTEMP);
            this.grpBxMinTemperatureExtruders.Controls.Add(this.marlinUpDnHEATER_0_MINTEMP);
            this.grpBxMinTemperatureExtruders.Location = new System.Drawing.Point(8, 13);
            this.grpBxMinTemperatureExtruders.Name = "grpBxMinTemperatureExtruders";
            this.grpBxMinTemperatureExtruders.Size = new System.Drawing.Size(597, 334);
            this.grpBxMinTemperatureExtruders.TabIndex = 1;
            this.grpBxMinTemperatureExtruders.TabStop = false;
            this.grpBxMinTemperatureExtruders.Text = "Extruder(s)";
            // 
            // marlinUpDnHEATER_4_MAXTEMP
            // 
            this.marlinUpDnHEATER_4_MAXTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_4_MAXTEMP.ControlText = "Maximum Temperature Extruder 4:";
            this.marlinUpDnHEATER_4_MAXTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_4_MAXTEMP.Feature = "HEATER_4_MAXTEMP";
            this.marlinUpDnHEATER_4_MAXTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_4_MAXTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_4_MAXTEMP.Location = new System.Drawing.Point(300, 300);
            this.marlinUpDnHEATER_4_MAXTEMP.Max = 375;
            this.marlinUpDnHEATER_4_MAXTEMP.Min = 100;
            this.marlinUpDnHEATER_4_MAXTEMP.Name = "marlinUpDnHEATER_4_MAXTEMP";
            this.marlinUpDnHEATER_4_MAXTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_4_MAXTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_4_MAXTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_4_MAXTEMP.TabIndex = 9;
            // 
            // marlinUpDnHEATER_3_MAXTEMP
            // 
            this.marlinUpDnHEATER_3_MAXTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_3_MAXTEMP.ControlText = "Maximum Temperature Extruder 3:";
            this.marlinUpDnHEATER_3_MAXTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_3_MAXTEMP.Feature = "HEATER_3_MAXTEMP";
            this.marlinUpDnHEATER_3_MAXTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_3_MAXTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_3_MAXTEMP.Location = new System.Drawing.Point(300, 236);
            this.marlinUpDnHEATER_3_MAXTEMP.Max = 375;
            this.marlinUpDnHEATER_3_MAXTEMP.Min = 100;
            this.marlinUpDnHEATER_3_MAXTEMP.Name = "marlinUpDnHEATER_3_MAXTEMP";
            this.marlinUpDnHEATER_3_MAXTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_3_MAXTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_3_MAXTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_3_MAXTEMP.TabIndex = 8;
            // 
            // marlinUpDnHEATER_2_MAXTEMP
            // 
            this.marlinUpDnHEATER_2_MAXTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_2_MAXTEMP.ControlText = "Maximum Temperature Extruder 2:";
            this.marlinUpDnHEATER_2_MAXTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_2_MAXTEMP.Feature = "HEATER_2_MAXTEMP";
            this.marlinUpDnHEATER_2_MAXTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_2_MAXTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_2_MAXTEMP.Location = new System.Drawing.Point(300, 171);
            this.marlinUpDnHEATER_2_MAXTEMP.Max = 375;
            this.marlinUpDnHEATER_2_MAXTEMP.Min = 100;
            this.marlinUpDnHEATER_2_MAXTEMP.Name = "marlinUpDnHEATER_2_MAXTEMP";
            this.marlinUpDnHEATER_2_MAXTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_2_MAXTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_2_MAXTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_2_MAXTEMP.TabIndex = 7;
            // 
            // marlinUpDnHEATER_1_MAXTEMP
            // 
            this.marlinUpDnHEATER_1_MAXTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_1_MAXTEMP.ControlText = "Maximum Temperature Extruder 1:";
            this.marlinUpDnHEATER_1_MAXTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_1_MAXTEMP.Feature = "HEATER_1_MAXTEMP";
            this.marlinUpDnHEATER_1_MAXTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_1_MAXTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_1_MAXTEMP.Location = new System.Drawing.Point(300, 109);
            this.marlinUpDnHEATER_1_MAXTEMP.Max = 375;
            this.marlinUpDnHEATER_1_MAXTEMP.Min = 100;
            this.marlinUpDnHEATER_1_MAXTEMP.Name = "marlinUpDnHEATER_1_MAXTEMP";
            this.marlinUpDnHEATER_1_MAXTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_1_MAXTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_1_MAXTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_1_MAXTEMP.TabIndex = 6;
            // 
            // marlinUpDnHEATER_0_MAXTEMP
            // 
            this.marlinUpDnHEATER_0_MAXTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_0_MAXTEMP.ControlText = "Maximum Temperature Extruder 0:";
            this.marlinUpDnHEATER_0_MAXTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_0_MAXTEMP.Feature = "HEATER_0_MAXTEMP";
            this.marlinUpDnHEATER_0_MAXTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_0_MAXTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_0_MAXTEMP.Location = new System.Drawing.Point(300, 39);
            this.marlinUpDnHEATER_0_MAXTEMP.Max = 375;
            this.marlinUpDnHEATER_0_MAXTEMP.Min = 100;
            this.marlinUpDnHEATER_0_MAXTEMP.Name = "marlinUpDnHEATER_0_MAXTEMP";
            this.marlinUpDnHEATER_0_MAXTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_0_MAXTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_0_MAXTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_0_MAXTEMP.TabIndex = 5;
            // 
            // marlinUpDnHEATER_4_MINTEMP
            // 
            this.marlinUpDnHEATER_4_MINTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_4_MINTEMP.ControlText = "Minimum Temperature Extruder 4:";
            this.marlinUpDnHEATER_4_MINTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_4_MINTEMP.Feature = "HEATER_4_MINTEMP";
            this.marlinUpDnHEATER_4_MINTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_4_MINTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_4_MINTEMP.Location = new System.Drawing.Point(300, 277);
            this.marlinUpDnHEATER_4_MINTEMP.Max = 50;
            this.marlinUpDnHEATER_4_MINTEMP.Min = 0;
            this.marlinUpDnHEATER_4_MINTEMP.Name = "marlinUpDnHEATER_4_MINTEMP";
            this.marlinUpDnHEATER_4_MINTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_4_MINTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_4_MINTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_4_MINTEMP.TabIndex = 4;
            // 
            // marlinUpDnHEATER_3_MINTEMP
            // 
            this.marlinUpDnHEATER_3_MINTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_3_MINTEMP.ControlText = "Minimum Temperature Extruder 3:";
            this.marlinUpDnHEATER_3_MINTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_3_MINTEMP.Feature = "HEATER_3_MINTEMP";
            this.marlinUpDnHEATER_3_MINTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_3_MINTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_3_MINTEMP.Location = new System.Drawing.Point(300, 212);
            this.marlinUpDnHEATER_3_MINTEMP.Max = 50;
            this.marlinUpDnHEATER_3_MINTEMP.Min = 0;
            this.marlinUpDnHEATER_3_MINTEMP.Name = "marlinUpDnHEATER_3_MINTEMP";
            this.marlinUpDnHEATER_3_MINTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_3_MINTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_3_MINTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_3_MINTEMP.TabIndex = 3;
            // 
            // marlinUpDnHEATER_2_MINTEMP
            // 
            this.marlinUpDnHEATER_2_MINTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_2_MINTEMP.ControlText = "Minimum Temperature Extruder 2:";
            this.marlinUpDnHEATER_2_MINTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_2_MINTEMP.Feature = "HEATER_2_MINTEMP";
            this.marlinUpDnHEATER_2_MINTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_2_MINTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_2_MINTEMP.Location = new System.Drawing.Point(300, 147);
            this.marlinUpDnHEATER_2_MINTEMP.Max = 50;
            this.marlinUpDnHEATER_2_MINTEMP.Min = 0;
            this.marlinUpDnHEATER_2_MINTEMP.Name = "marlinUpDnHEATER_2_MINTEMP";
            this.marlinUpDnHEATER_2_MINTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_2_MINTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_2_MINTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_2_MINTEMP.TabIndex = 2;
            // 
            // marlinUpDnHEATER_1_MINTEMP
            // 
            this.marlinUpDnHEATER_1_MINTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_1_MINTEMP.ControlText = "Minimum Temperature Extruder 1:";
            this.marlinUpDnHEATER_1_MINTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_1_MINTEMP.Feature = "HEATER_1_MINTEMP";
            this.marlinUpDnHEATER_1_MINTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_1_MINTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_1_MINTEMP.Location = new System.Drawing.Point(300, 85);
            this.marlinUpDnHEATER_1_MINTEMP.Max = 50;
            this.marlinUpDnHEATER_1_MINTEMP.Min = 0;
            this.marlinUpDnHEATER_1_MINTEMP.Name = "marlinUpDnHEATER_1_MINTEMP";
            this.marlinUpDnHEATER_1_MINTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_1_MINTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_1_MINTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_1_MINTEMP.TabIndex = 1;
            // 
            // marlinUpDnHEATER_0_MINTEMP
            // 
            this.marlinUpDnHEATER_0_MINTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnHEATER_0_MINTEMP.ControlText = "Minimum Temperature Extruder 0:";
            this.marlinUpDnHEATER_0_MINTEMP.currentFirmwareHelper = null;
            this.marlinUpDnHEATER_0_MINTEMP.Feature = "HEATER_0_MINTEMP";
            this.marlinUpDnHEATER_0_MINTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-ranges";
            this.marlinUpDnHEATER_0_MINTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnHEATER_0_MINTEMP.Location = new System.Drawing.Point(300, 15);
            this.marlinUpDnHEATER_0_MINTEMP.Max = 50;
            this.marlinUpDnHEATER_0_MINTEMP.Min = 0;
            this.marlinUpDnHEATER_0_MINTEMP.Name = "marlinUpDnHEATER_0_MINTEMP";
            this.marlinUpDnHEATER_0_MINTEMP.NewFirmwareHelper = null;
            this.marlinUpDnHEATER_0_MINTEMP.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnHEATER_0_MINTEMP.SpliterDistance = 180;
            this.marlinUpDnHEATER_0_MINTEMP.TabIndex = 0;
            // 
            // tabPagePidExtruder
            // 
            this.tabPagePidExtruder.Controls.Add(this.marlinValueDEFAULT_Kd);
            this.tabPagePidExtruder.Controls.Add(this.marlinValueDEFAULT_Ki);
            this.tabPagePidExtruder.Controls.Add(this.marlinValueDEFAULT_Kp);
            this.tabPagePidExtruder.Controls.Add(this.marlinValueK1);
            this.tabPagePidExtruder.Controls.Add(this.marlinUpDnPID_FUNCTIONAL_RANGE);
            this.tabPagePidExtruder.Controls.Add(this.marlinCheckBoxPID_PARAMS_PER_HOTEND);
            this.tabPagePidExtruder.Controls.Add(this.marlinCheckBoxSLOW_PWM_HEATERS);
            this.tabPagePidExtruder.Controls.Add(this.marlinEnableValuePID_OPENLOOP);
            this.tabPagePidExtruder.Controls.Add(this.marlinCheckBoxPID_DEBUG);
            this.tabPagePidExtruder.Controls.Add(this.marlinCheckBoxPID_AUTOTUNE_MENU);
            this.tabPagePidExtruder.Controls.Add(this.marlinValuePID_MAX);
            this.tabPagePidExtruder.Controls.Add(this.marlinUpDnBANG_MAX);
            this.tabPagePidExtruder.Controls.Add(this.marlinCheckBoxPIDTEMP);
            this.tabPagePidExtruder.Location = new System.Drawing.Point(4, 76);
            this.tabPagePidExtruder.Name = "tabPagePidExtruder";
            this.tabPagePidExtruder.Size = new System.Drawing.Size(622, 585);
            this.tabPagePidExtruder.TabIndex = 2;
            this.tabPagePidExtruder.Text = "PID  Extruder";
            this.tabPagePidExtruder.UseVisualStyleBackColor = true;
            // 
            // marlinValueDEFAULT_Kd
            // 
            this.marlinValueDEFAULT_Kd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_Kd.ControlText = "Default Kd";
            this.marlinValueDEFAULT_Kd.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_Kd.Feature = "DEFAULT_Kd";
            this.marlinValueDEFAULT_Kd.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValueDEFAULT_Kd.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_Kd.Location = new System.Drawing.Point(334, 446);
            this.marlinValueDEFAULT_Kd.Name = "marlinValueDEFAULT_Kd";
            this.marlinValueDEFAULT_Kd.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_Kd.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_Kd.SpliterDistance = 80;
            this.marlinValueDEFAULT_Kd.TabIndex = 12;
            // 
            // marlinValueDEFAULT_Ki
            // 
            this.marlinValueDEFAULT_Ki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_Ki.ControlText = "Default Ki";
            this.marlinValueDEFAULT_Ki.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_Ki.Feature = "DEFAULT_Ki";
            this.marlinValueDEFAULT_Ki.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValueDEFAULT_Ki.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_Ki.Location = new System.Drawing.Point(334, 408);
            this.marlinValueDEFAULT_Ki.Name = "marlinValueDEFAULT_Ki";
            this.marlinValueDEFAULT_Ki.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_Ki.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_Ki.SpliterDistance = 80;
            this.marlinValueDEFAULT_Ki.TabIndex = 11;
            // 
            // marlinValueDEFAULT_Kp
            // 
            this.marlinValueDEFAULT_Kp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_Kp.ControlText = "Default Kp";
            this.marlinValueDEFAULT_Kp.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_Kp.Feature = "DEFAULT_Kp";
            this.marlinValueDEFAULT_Kp.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValueDEFAULT_Kp.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_Kp.Location = new System.Drawing.Point(334, 370);
            this.marlinValueDEFAULT_Kp.Name = "marlinValueDEFAULT_Kp";
            this.marlinValueDEFAULT_Kp.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_Kp.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_Kp.SpliterDistance = 80;
            this.marlinValueDEFAULT_Kp.TabIndex = 10;
            // 
            // marlinValueK1
            // 
            this.marlinValueK1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueK1.ControlText = "Smoothing factor within the PID";
            this.marlinValueK1.currentFirmwareHelper = null;
            this.marlinValueK1.Feature = "K1";
            this.marlinValueK1.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValueK1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueK1.Location = new System.Drawing.Point(334, 332);
            this.marlinValueK1.Name = "marlinValueK1";
            this.marlinValueK1.NewFirmwareHelper = null;
            this.marlinValueK1.Size = new System.Drawing.Size(276, 26);
            this.marlinValueK1.SpliterDistance = 160;
            this.marlinValueK1.TabIndex = 9;
            // 
            // marlinUpDnPID_FUNCTIONAL_RANGE
            // 
            this.marlinUpDnPID_FUNCTIONAL_RANGE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPID_FUNCTIONAL_RANGE.ControlText = "PID function Range:";
            this.marlinUpDnPID_FUNCTIONAL_RANGE.currentFirmwareHelper = null;
            this.marlinUpDnPID_FUNCTIONAL_RANGE.Feature = "PID_FUNCTIONAL_RANGE";
            this.marlinUpDnPID_FUNCTIONAL_RANGE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinUpDnPID_FUNCTIONAL_RANGE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPID_FUNCTIONAL_RANGE.Location = new System.Drawing.Point(334, 294);
            this.marlinUpDnPID_FUNCTIONAL_RANGE.Max = 15;
            this.marlinUpDnPID_FUNCTIONAL_RANGE.Min = 0;
            this.marlinUpDnPID_FUNCTIONAL_RANGE.Name = "marlinUpDnPID_FUNCTIONAL_RANGE";
            this.marlinUpDnPID_FUNCTIONAL_RANGE.NewFirmwareHelper = null;
            this.marlinUpDnPID_FUNCTIONAL_RANGE.Size = new System.Drawing.Size(276, 26);
            this.marlinUpDnPID_FUNCTIONAL_RANGE.SpliterDistance = 104;
            this.marlinUpDnPID_FUNCTIONAL_RANGE.TabIndex = 8;
            // 
            // marlinCheckBoxPID_PARAMS_PER_HOTEND
            // 
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.ControlText = "Use separate PID parameters";
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.currentFirmwareHelper = null;
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.Feature = "PID_PARAMS_PER_HOTEND";
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.Location = new System.Drawing.Point(334, 261);
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.Name = "marlinCheckBoxPID_PARAMS_PER_HOTEND";
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.NewFirmwareHelper = null;
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxPID_PARAMS_PER_HOTEND.TabIndex = 7;
            // 
            // marlinCheckBoxSLOW_PWM_HEATERS
            // 
            this.marlinCheckBoxSLOW_PWM_HEATERS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSLOW_PWM_HEATERS.ControlText = "PWM with very low frequency";
            this.marlinCheckBoxSLOW_PWM_HEATERS.currentFirmwareHelper = null;
            this.marlinCheckBoxSLOW_PWM_HEATERS.Feature = "SLOW_PWM_HEATERS";
            this.marlinCheckBoxSLOW_PWM_HEATERS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxSLOW_PWM_HEATERS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSLOW_PWM_HEATERS.Location = new System.Drawing.Point(334, 228);
            this.marlinCheckBoxSLOW_PWM_HEATERS.Name = "marlinCheckBoxSLOW_PWM_HEATERS";
            this.marlinCheckBoxSLOW_PWM_HEATERS.NewFirmwareHelper = null;
            this.marlinCheckBoxSLOW_PWM_HEATERS.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxSLOW_PWM_HEATERS.TabIndex = 6;
            // 
            // marlinEnableValuePID_OPENLOOP
            // 
            this.marlinEnableValuePID_OPENLOOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValuePID_OPENLOOP.ControlText = "Puts PID in open loop:";
            this.marlinEnableValuePID_OPENLOOP.currentFirmwareHelper = null;
            this.marlinEnableValuePID_OPENLOOP.Feature = "PID_OPENLOOP";
            this.marlinEnableValuePID_OPENLOOP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinEnableValuePID_OPENLOOP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValuePID_OPENLOOP.Location = new System.Drawing.Point(334, 190);
            this.marlinEnableValuePID_OPENLOOP.Name = "marlinEnableValuePID_OPENLOOP";
            this.marlinEnableValuePID_OPENLOOP.NewFirmwareHelper = null;
            this.marlinEnableValuePID_OPENLOOP.Size = new System.Drawing.Size(276, 26);
            this.marlinEnableValuePID_OPENLOOP.SpliterDistance = 124;
            this.marlinEnableValuePID_OPENLOOP.TabIndex = 5;
            // 
            // marlinCheckBoxPID_DEBUG
            // 
            this.marlinCheckBoxPID_DEBUG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPID_DEBUG.ControlText = "Sends debug data to the serial port";
            this.marlinCheckBoxPID_DEBUG.currentFirmwareHelper = null;
            this.marlinCheckBoxPID_DEBUG.Feature = "PID_DEBUG";
            this.marlinCheckBoxPID_DEBUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxPID_DEBUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPID_DEBUG.Location = new System.Drawing.Point(334, 157);
            this.marlinCheckBoxPID_DEBUG.Name = "marlinCheckBoxPID_DEBUG";
            this.marlinCheckBoxPID_DEBUG.NewFirmwareHelper = null;
            this.marlinCheckBoxPID_DEBUG.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxPID_DEBUG.TabIndex = 4;
            // 
            // marlinCheckBoxPID_AUTOTUNE_MENU
            // 
            this.marlinCheckBoxPID_AUTOTUNE_MENU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPID_AUTOTUNE_MENU.ControlText = "Add PID Autotunein LCD \"Temperature\" menu";
            this.marlinCheckBoxPID_AUTOTUNE_MENU.currentFirmwareHelper = null;
            this.marlinCheckBoxPID_AUTOTUNE_MENU.Feature = "PID_AUTOTUNE_MENU";
            this.marlinCheckBoxPID_AUTOTUNE_MENU.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxPID_AUTOTUNE_MENU.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPID_AUTOTUNE_MENU.Location = new System.Drawing.Point(334, 124);
            this.marlinCheckBoxPID_AUTOTUNE_MENU.Name = "marlinCheckBoxPID_AUTOTUNE_MENU";
            this.marlinCheckBoxPID_AUTOTUNE_MENU.NewFirmwareHelper = null;
            this.marlinCheckBoxPID_AUTOTUNE_MENU.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxPID_AUTOTUNE_MENU.TabIndex = 3;
            // 
            // marlinValuePID_MAX
            // 
            this.marlinValuePID_MAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValuePID_MAX.ControlText = "PID max:";
            this.marlinValuePID_MAX.currentFirmwareHelper = null;
            this.marlinValuePID_MAX.Feature = "PID_MAX";
            this.marlinValuePID_MAX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValuePID_MAX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValuePID_MAX.Location = new System.Drawing.Point(334, 86);
            this.marlinValuePID_MAX.Name = "marlinValuePID_MAX";
            this.marlinValuePID_MAX.NewFirmwareHelper = null;
            this.marlinValuePID_MAX.Size = new System.Drawing.Size(276, 26);
            this.marlinValuePID_MAX.SpliterDistance = 100;
            this.marlinValuePID_MAX.TabIndex = 2;
            // 
            // marlinUpDnBANG_MAX
            // 
            this.marlinUpDnBANG_MAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnBANG_MAX.ControlText = "Bang Max:";
            this.marlinUpDnBANG_MAX.currentFirmwareHelper = null;
            this.marlinUpDnBANG_MAX.Feature = "BANG_MAX";
            this.marlinUpDnBANG_MAX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinUpDnBANG_MAX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnBANG_MAX.Location = new System.Drawing.Point(334, 48);
            this.marlinUpDnBANG_MAX.Max = 255;
            this.marlinUpDnBANG_MAX.Min = 0;
            this.marlinUpDnBANG_MAX.Name = "marlinUpDnBANG_MAX";
            this.marlinUpDnBANG_MAX.NewFirmwareHelper = null;
            this.marlinUpDnBANG_MAX.Size = new System.Drawing.Size(276, 26);
            this.marlinUpDnBANG_MAX.SpliterDistance = 100;
            this.marlinUpDnBANG_MAX.TabIndex = 1;
            // 
            // marlinCheckBoxPIDTEMP
            // 
            this.marlinCheckBoxPIDTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPIDTEMP.ControlText = "PID extruders:";
            this.marlinCheckBoxPIDTEMP.currentFirmwareHelper = null;
            this.marlinCheckBoxPIDTEMP.Feature = "PIDTEMP";
            this.marlinCheckBoxPIDTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxPIDTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPIDTEMP.Location = new System.Drawing.Point(334, 15);
            this.marlinCheckBoxPIDTEMP.Name = "marlinCheckBoxPIDTEMP";
            this.marlinCheckBoxPIDTEMP.NewFirmwareHelper = null;
            this.marlinCheckBoxPIDTEMP.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxPIDTEMP.TabIndex = 0;
            // 
            // tabPagePidBed
            // 
            this.tabPagePidBed.Controls.Add(this.marlinValueDEFAULT_bedKd);
            this.tabPagePidBed.Controls.Add(this.marlinValueDEFAULT_bedKi);
            this.tabPagePidBed.Controls.Add(this.marlinValueDEFAULT_bedKp);
            this.tabPagePidBed.Controls.Add(this.marlinCheckBoxPID_BED_DEBUG);
            this.tabPagePidBed.Controls.Add(this.marlinUpDnMAX_BED_POWER);
            this.tabPagePidBed.Controls.Add(this.marlinCheckBoxBED_LIMIT_SWITCHING);
            this.tabPagePidBed.Controls.Add(this.marlinCheckBoxPIDTEMPBED);
            this.tabPagePidBed.Location = new System.Drawing.Point(4, 76);
            this.tabPagePidBed.Name = "tabPagePidBed";
            this.tabPagePidBed.Size = new System.Drawing.Size(622, 585);
            this.tabPagePidBed.TabIndex = 11;
            this.tabPagePidBed.Text = "PID Bed";
            this.tabPagePidBed.UseVisualStyleBackColor = true;
            // 
            // marlinValueDEFAULT_bedKd
            // 
            this.marlinValueDEFAULT_bedKd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_bedKd.ControlText = "Default Bed Kd";
            this.marlinValueDEFAULT_bedKd.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_bedKd.Feature = "DEFAULT_bedKd";
            this.marlinValueDEFAULT_bedKd.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValueDEFAULT_bedKd.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_bedKd.Location = new System.Drawing.Point(334, 243);
            this.marlinValueDEFAULT_bedKd.Name = "marlinValueDEFAULT_bedKd";
            this.marlinValueDEFAULT_bedKd.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_bedKd.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_bedKd.SpliterDistance = 80;
            this.marlinValueDEFAULT_bedKd.TabIndex = 6;
            // 
            // marlinValueDEFAULT_bedKi
            // 
            this.marlinValueDEFAULT_bedKi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_bedKi.ControlText = "Default Bed Ki:";
            this.marlinValueDEFAULT_bedKi.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_bedKi.Feature = "DEFAULT_bedKi";
            this.marlinValueDEFAULT_bedKi.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValueDEFAULT_bedKi.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_bedKi.Location = new System.Drawing.Point(334, 202);
            this.marlinValueDEFAULT_bedKi.Name = "marlinValueDEFAULT_bedKi";
            this.marlinValueDEFAULT_bedKi.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_bedKi.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_bedKi.SpliterDistance = 80;
            this.marlinValueDEFAULT_bedKi.TabIndex = 5;
            // 
            // marlinValueDEFAULT_bedKp
            // 
            this.marlinValueDEFAULT_bedKp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_bedKp.ControlText = "Default Bed Kp:";
            this.marlinValueDEFAULT_bedKp.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_bedKp.Feature = "DEFAULT_bedKp";
            this.marlinValueDEFAULT_bedKp.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinValueDEFAULT_bedKp.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_bedKp.Location = new System.Drawing.Point(334, 161);
            this.marlinValueDEFAULT_bedKp.Name = "marlinValueDEFAULT_bedKp";
            this.marlinValueDEFAULT_bedKp.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_bedKp.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_bedKp.SpliterDistance = 80;
            this.marlinValueDEFAULT_bedKp.TabIndex = 4;
            // 
            // marlinCheckBoxPID_BED_DEBUG
            // 
            this.marlinCheckBoxPID_BED_DEBUG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPID_BED_DEBUG.ControlText = "Sends PID Bed debug data to the serial port";
            this.marlinCheckBoxPID_BED_DEBUG.currentFirmwareHelper = null;
            this.marlinCheckBoxPID_BED_DEBUG.Feature = "PID_BED_DEBUG";
            this.marlinCheckBoxPID_BED_DEBUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxPID_BED_DEBUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPID_BED_DEBUG.Location = new System.Drawing.Point(334, 125);
            this.marlinCheckBoxPID_BED_DEBUG.Name = "marlinCheckBoxPID_BED_DEBUG";
            this.marlinCheckBoxPID_BED_DEBUG.NewFirmwareHelper = null;
            this.marlinCheckBoxPID_BED_DEBUG.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxPID_BED_DEBUG.TabIndex = 3;
            // 
            // marlinUpDnMAX_BED_POWER
            // 
            this.marlinUpDnMAX_BED_POWER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnMAX_BED_POWER.ControlText = "Max Bed power:";
            this.marlinUpDnMAX_BED_POWER.currentFirmwareHelper = null;
            this.marlinUpDnMAX_BED_POWER.Feature = "MAX_BED_POWER";
            this.marlinUpDnMAX_BED_POWER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinUpDnMAX_BED_POWER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnMAX_BED_POWER.Location = new System.Drawing.Point(334, 84);
            this.marlinUpDnMAX_BED_POWER.Max = 255;
            this.marlinUpDnMAX_BED_POWER.Min = 0;
            this.marlinUpDnMAX_BED_POWER.Name = "marlinUpDnMAX_BED_POWER";
            this.marlinUpDnMAX_BED_POWER.NewFirmwareHelper = null;
            this.marlinUpDnMAX_BED_POWER.Size = new System.Drawing.Size(276, 26);
            this.marlinUpDnMAX_BED_POWER.SpliterDistance = 92;
            this.marlinUpDnMAX_BED_POWER.TabIndex = 2;
            // 
            // marlinCheckBoxBED_LIMIT_SWITCHING
            // 
            this.marlinCheckBoxBED_LIMIT_SWITCHING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxBED_LIMIT_SWITCHING.ControlText = "Bed limit switching";
            this.marlinCheckBoxBED_LIMIT_SWITCHING.currentFirmwareHelper = null;
            this.marlinCheckBoxBED_LIMIT_SWITCHING.Feature = "BED_LIMIT_SWITCHING";
            this.marlinCheckBoxBED_LIMIT_SWITCHING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxBED_LIMIT_SWITCHING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxBED_LIMIT_SWITCHING.Location = new System.Drawing.Point(334, 48);
            this.marlinCheckBoxBED_LIMIT_SWITCHING.Name = "marlinCheckBoxBED_LIMIT_SWITCHING";
            this.marlinCheckBoxBED_LIMIT_SWITCHING.NewFirmwareHelper = null;
            this.marlinCheckBoxBED_LIMIT_SWITCHING.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxBED_LIMIT_SWITCHING.TabIndex = 1;
            // 
            // marlinCheckBoxPIDTEMPBED
            // 
            this.marlinCheckBoxPIDTEMPBED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPIDTEMPBED.ControlText = "PID Bed";
            this.marlinCheckBoxPIDTEMPBED.currentFirmwareHelper = null;
            this.marlinCheckBoxPIDTEMPBED.Feature = "PIDTEMPBED";
            this.marlinCheckBoxPIDTEMPBED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#pid";
            this.marlinCheckBoxPIDTEMPBED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPIDTEMPBED.Location = new System.Drawing.Point(334, 12);
            this.marlinCheckBoxPIDTEMPBED.Name = "marlinCheckBoxPIDTEMPBED";
            this.marlinCheckBoxPIDTEMPBED.NewFirmwareHelper = null;
            this.marlinCheckBoxPIDTEMPBED.Size = new System.Drawing.Size(276, 21);
            this.marlinCheckBoxPIDTEMPBED.TabIndex = 0;
            // 
            // tabPageExtrusion
            // 
            this.tabPageExtrusion.Controls.Add(this.marlinValueEXTRUDE_MAXLENGTH);
            this.tabPageExtrusion.Controls.Add(this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE);
            this.tabPageExtrusion.Controls.Add(this.marlinUpDnEXTRUDE_MINTEMP);
            this.tabPageExtrusion.Controls.Add(this.marlinCheckBoxPREVENT_COLD_EXTRUSION);
            this.tabPageExtrusion.Location = new System.Drawing.Point(4, 76);
            this.tabPageExtrusion.Name = "tabPageExtrusion";
            this.tabPageExtrusion.Size = new System.Drawing.Size(622, 585);
            this.tabPageExtrusion.TabIndex = 12;
            this.tabPageExtrusion.Text = "Extrusion";
            this.tabPageExtrusion.UseVisualStyleBackColor = true;
            // 
            // marlinValueEXTRUDE_MAXLENGTH
            // 
            this.marlinValueEXTRUDE_MAXLENGTH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueEXTRUDE_MAXLENGTH.ControlText = "Privent extrusion loger than:";
            this.marlinValueEXTRUDE_MAXLENGTH.currentFirmwareHelper = null;
            this.marlinValueEXTRUDE_MAXLENGTH.Feature = "EXTRUDE_MAXLENGTH";
            this.marlinValueEXTRUDE_MAXLENGTH.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#safety";
            this.marlinValueEXTRUDE_MAXLENGTH.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueEXTRUDE_MAXLENGTH.Location = new System.Drawing.Point(281, 94);
            this.marlinValueEXTRUDE_MAXLENGTH.Name = "marlinValueEXTRUDE_MAXLENGTH";
            this.marlinValueEXTRUDE_MAXLENGTH.NewFirmwareHelper = null;
            this.marlinValueEXTRUDE_MAXLENGTH.Size = new System.Drawing.Size(327, 26);
            this.marlinValueEXTRUDE_MAXLENGTH.SpliterDistance = 140;
            this.marlinValueEXTRUDE_MAXLENGTH.TabIndex = 3;
            // 
            // marlinCheckBoxPREVENT_LENGTHY_EXTRUDE
            // 
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.ControlText = "Prevent Lengthy Extrude";
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.currentFirmwareHelper = null;
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.Feature = "PREVENT_LENGTHY_EXTRUDE";
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#safety";
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.Location = new System.Drawing.Point(281, 67);
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.Name = "marlinCheckBoxPREVENT_LENGTHY_EXTRUDE";
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.NewFirmwareHelper = null;
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.Size = new System.Drawing.Size(327, 21);
            this.marlinCheckBoxPREVENT_LENGTHY_EXTRUDE.TabIndex = 2;
            // 
            // marlinUpDnEXTRUDE_MINTEMP
            // 
            this.marlinUpDnEXTRUDE_MINTEMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnEXTRUDE_MINTEMP.ControlText = "Prevent extrusion below temperature;";
            this.marlinUpDnEXTRUDE_MINTEMP.currentFirmwareHelper = null;
            this.marlinUpDnEXTRUDE_MINTEMP.Feature = "EXTRUDE_MINTEMP";
            this.marlinUpDnEXTRUDE_MINTEMP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#safety";
            this.marlinUpDnEXTRUDE_MINTEMP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnEXTRUDE_MINTEMP.Location = new System.Drawing.Point(281, 35);
            this.marlinUpDnEXTRUDE_MINTEMP.Max = 250;
            this.marlinUpDnEXTRUDE_MINTEMP.Min = 100;
            this.marlinUpDnEXTRUDE_MINTEMP.Name = "marlinUpDnEXTRUDE_MINTEMP";
            this.marlinUpDnEXTRUDE_MINTEMP.NewFirmwareHelper = null;
            this.marlinUpDnEXTRUDE_MINTEMP.Size = new System.Drawing.Size(327, 26);
            this.marlinUpDnEXTRUDE_MINTEMP.SpliterDistance = 200;
            this.marlinUpDnEXTRUDE_MINTEMP.TabIndex = 1;
            // 
            // marlinCheckBoxPREVENT_COLD_EXTRUSION
            // 
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.ControlText = "Prevent Cold Extrusion";
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.currentFirmwareHelper = null;
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.Feature = "PREVENT_COLD_EXTRUSION";
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#safety";
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.Location = new System.Drawing.Point(281, 8);
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.Name = "marlinCheckBoxPREVENT_COLD_EXTRUSION";
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.NewFirmwareHelper = null;
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.Size = new System.Drawing.Size(327, 21);
            this.marlinCheckBoxPREVENT_COLD_EXTRUSION.TabIndex = 0;
            // 
            // tabPageThermalProtection
            // 
            this.tabPageThermalProtection.Controls.Add(this.marlinCheckBoxTHERMAL_PROTECTION_BED);
            this.tabPageThermalProtection.Controls.Add(this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS);
            this.tabPageThermalProtection.Location = new System.Drawing.Point(4, 76);
            this.tabPageThermalProtection.Name = "tabPageThermalProtection";
            this.tabPageThermalProtection.Size = new System.Drawing.Size(622, 585);
            this.tabPageThermalProtection.TabIndex = 13;
            this.tabPageThermalProtection.Text = "Thermal Protection";
            this.tabPageThermalProtection.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxTHERMAL_PROTECTION_BED
            // 
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.ControlText = "Thermal protection Bed";
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.currentFirmwareHelper = null;
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.Feature = "THERMAL_PROTECTION_BED";
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#safety";
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.Location = new System.Drawing.Point(421, 38);
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.Name = "marlinCheckBoxTHERMAL_PROTECTION_BED";
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.NewFirmwareHelper = null;
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.Size = new System.Drawing.Size(187, 21);
            this.marlinCheckBoxTHERMAL_PROTECTION_BED.TabIndex = 1;
            // 
            // marlinCheckBoxTHERMAL_PROTECTION_HOTENDS
            // 
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.ControlText = "Thermal protection Hotends";
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.currentFirmwareHelper = null;
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.Feature = "THERMAL_PROTECTION_HOTENDS";
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#safety";
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.Location = new System.Drawing.Point(421, 11);
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.Name = "marlinCheckBoxTHERMAL_PROTECTION_HOTENDS";
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.NewFirmwareHelper = null;
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.Size = new System.Drawing.Size(187, 21);
            this.marlinCheckBoxTHERMAL_PROTECTION_HOTENDS.TabIndex = 0;
            // 
            // tabPageKinematics
            // 
            this.tabPageKinematics.Controls.Add(this.marlinCheckBoxCOREZY);
            this.tabPageKinematics.Controls.Add(this.marlinCheckBoxCOREZX);
            this.tabPageKinematics.Controls.Add(this.marlinCheckBoxCOREYX);
            this.tabPageKinematics.Controls.Add(this.marlinCheckBoxCOREYZ);
            this.tabPageKinematics.Controls.Add(this.marlinCheckBoxCOREXZ);
            this.tabPageKinematics.Controls.Add(this.marlinCheckBoxCOREXY);
            this.tabPageKinematics.Location = new System.Drawing.Point(4, 76);
            this.tabPageKinematics.Name = "tabPageKinematics";
            this.tabPageKinematics.Size = new System.Drawing.Size(622, 585);
            this.tabPageKinematics.TabIndex = 14;
            this.tabPageKinematics.Text = "Kinematics";
            this.tabPageKinematics.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxCOREZY
            // 
            this.marlinCheckBoxCOREZY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCOREZY.ControlText = "COREZY";
            this.marlinCheckBoxCOREZY.currentFirmwareHelper = null;
            this.marlinCheckBoxCOREZY.Feature = "COREZY";
            this.marlinCheckBoxCOREZY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#kinematics";
            this.marlinCheckBoxCOREZY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCOREZY.Location = new System.Drawing.Point(502, 147);
            this.marlinCheckBoxCOREZY.Name = "marlinCheckBoxCOREZY";
            this.marlinCheckBoxCOREZY.NewFirmwareHelper = null;
            this.marlinCheckBoxCOREZY.Size = new System.Drawing.Size(105, 21);
            this.marlinCheckBoxCOREZY.TabIndex = 5;
            // 
            // marlinCheckBoxCOREZX
            // 
            this.marlinCheckBoxCOREZX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCOREZX.ControlText = "COREZX";
            this.marlinCheckBoxCOREZX.currentFirmwareHelper = null;
            this.marlinCheckBoxCOREZX.Feature = "COREZX";
            this.marlinCheckBoxCOREZX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#kinematics";
            this.marlinCheckBoxCOREZX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCOREZX.Location = new System.Drawing.Point(502, 120);
            this.marlinCheckBoxCOREZX.Name = "marlinCheckBoxCOREZX";
            this.marlinCheckBoxCOREZX.NewFirmwareHelper = null;
            this.marlinCheckBoxCOREZX.Size = new System.Drawing.Size(105, 21);
            this.marlinCheckBoxCOREZX.TabIndex = 4;
            // 
            // marlinCheckBoxCOREYX
            // 
            this.marlinCheckBoxCOREYX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCOREYX.ControlText = "COREYX";
            this.marlinCheckBoxCOREYX.currentFirmwareHelper = null;
            this.marlinCheckBoxCOREYX.Feature = "COREYX";
            this.marlinCheckBoxCOREYX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#kinematics";
            this.marlinCheckBoxCOREYX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCOREYX.Location = new System.Drawing.Point(502, 93);
            this.marlinCheckBoxCOREYX.Name = "marlinCheckBoxCOREYX";
            this.marlinCheckBoxCOREYX.NewFirmwareHelper = null;
            this.marlinCheckBoxCOREYX.Size = new System.Drawing.Size(105, 21);
            this.marlinCheckBoxCOREYX.TabIndex = 3;
            // 
            // marlinCheckBoxCOREYZ
            // 
            this.marlinCheckBoxCOREYZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCOREYZ.ControlText = "COREYZ";
            this.marlinCheckBoxCOREYZ.currentFirmwareHelper = null;
            this.marlinCheckBoxCOREYZ.Feature = "COREYZ";
            this.marlinCheckBoxCOREYZ.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#kinematics";
            this.marlinCheckBoxCOREYZ.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCOREYZ.Location = new System.Drawing.Point(502, 66);
            this.marlinCheckBoxCOREYZ.Name = "marlinCheckBoxCOREYZ";
            this.marlinCheckBoxCOREYZ.NewFirmwareHelper = null;
            this.marlinCheckBoxCOREYZ.Size = new System.Drawing.Size(105, 21);
            this.marlinCheckBoxCOREYZ.TabIndex = 2;
            // 
            // marlinCheckBoxCOREXZ
            // 
            this.marlinCheckBoxCOREXZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCOREXZ.ControlText = "COREXZ";
            this.marlinCheckBoxCOREXZ.currentFirmwareHelper = null;
            this.marlinCheckBoxCOREXZ.Feature = "COREXZ";
            this.marlinCheckBoxCOREXZ.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#kinematics";
            this.marlinCheckBoxCOREXZ.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCOREXZ.Location = new System.Drawing.Point(502, 39);
            this.marlinCheckBoxCOREXZ.Name = "marlinCheckBoxCOREXZ";
            this.marlinCheckBoxCOREXZ.NewFirmwareHelper = null;
            this.marlinCheckBoxCOREXZ.Size = new System.Drawing.Size(105, 21);
            this.marlinCheckBoxCOREXZ.TabIndex = 1;
            // 
            // marlinCheckBoxCOREXY
            // 
            this.marlinCheckBoxCOREXY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCOREXY.ControlText = "COREXY";
            this.marlinCheckBoxCOREXY.currentFirmwareHelper = null;
            this.marlinCheckBoxCOREXY.Feature = "COREXY";
            this.marlinCheckBoxCOREXY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#kinematics";
            this.marlinCheckBoxCOREXY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCOREXY.Location = new System.Drawing.Point(502, 12);
            this.marlinCheckBoxCOREXY.Name = "marlinCheckBoxCOREXY";
            this.marlinCheckBoxCOREXY.NewFirmwareHelper = null;
            this.marlinCheckBoxCOREXY.Size = new System.Drawing.Size(105, 21);
            this.marlinCheckBoxCOREXY.TabIndex = 0;
            // 
            // tabPageEndstop
            // 
            this.tabPageEndstop.Controls.Add(this.groupBoxEndstopPlug);
            this.tabPageEndstop.Controls.Add(this.groupBoxInvertingEndstops);
            this.tabPageEndstop.Controls.Add(this.grpBxPullupResistors);
            this.tabPageEndstop.Location = new System.Drawing.Point(4, 76);
            this.tabPageEndstop.Name = "tabPageEndstop";
            this.tabPageEndstop.Size = new System.Drawing.Size(622, 585);
            this.tabPageEndstop.TabIndex = 3;
            this.tabPageEndstop.Text = "EndStop";
            this.tabPageEndstop.UseVisualStyleBackColor = true;
            // 
            // groupBoxEndstopPlug
            // 
            this.groupBoxEndstopPlug.Controls.Add(this.marlinCheckBoxUSE_ZMIN_PLUG);
            this.groupBoxEndstopPlug.Controls.Add(this.marlinCheckBoxUSE_XMIN_PLUG);
            this.groupBoxEndstopPlug.Controls.Add(this.marlinCheckBoxUSE_YMIN_PLUG);
            this.groupBoxEndstopPlug.Controls.Add(this.marlinCheckBoxUSE_ZMAX_PLUG);
            this.groupBoxEndstopPlug.Controls.Add(this.marlinCheckBoxUSE_XMAX_PLUG);
            this.groupBoxEndstopPlug.Controls.Add(this.marlinCheckBoxUSE_YMAX_PLUG);
            this.groupBoxEndstopPlug.Location = new System.Drawing.Point(8, 15);
            this.groupBoxEndstopPlug.Name = "groupBoxEndstopPlug";
            this.groupBoxEndstopPlug.Size = new System.Drawing.Size(191, 205);
            this.groupBoxEndstopPlug.TabIndex = 16;
            this.groupBoxEndstopPlug.TabStop = false;
            this.groupBoxEndstopPlug.Text = "EndstopPlug";
            // 
            // marlinCheckBoxUSE_ZMIN_PLUG
            // 
            this.marlinCheckBoxUSE_ZMIN_PLUG.ControlText = "Use Zmin Plug";
            this.marlinCheckBoxUSE_ZMIN_PLUG.currentFirmwareHelper = null;
            this.marlinCheckBoxUSE_ZMIN_PLUG.Feature = "USE_ZMIN_PLUG";
            this.marlinCheckBoxUSE_ZMIN_PLUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-plugs";
            this.marlinCheckBoxUSE_ZMIN_PLUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxUSE_ZMIN_PLUG.Location = new System.Drawing.Point(6, 71);
            this.marlinCheckBoxUSE_ZMIN_PLUG.Name = "marlinCheckBoxUSE_ZMIN_PLUG";
            this.marlinCheckBoxUSE_ZMIN_PLUG.NewFirmwareHelper = null;
            this.marlinCheckBoxUSE_ZMIN_PLUG.Size = new System.Drawing.Size(179, 21);
            this.marlinCheckBoxUSE_ZMIN_PLUG.TabIndex = 2;
            // 
            // marlinCheckBoxUSE_XMIN_PLUG
            // 
            this.marlinCheckBoxUSE_XMIN_PLUG.ControlText = "Use Xmin Plug";
            this.marlinCheckBoxUSE_XMIN_PLUG.currentFirmwareHelper = null;
            this.marlinCheckBoxUSE_XMIN_PLUG.Feature = "USE_XMIN_PLUG";
            this.marlinCheckBoxUSE_XMIN_PLUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-plugs";
            this.marlinCheckBoxUSE_XMIN_PLUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxUSE_XMIN_PLUG.Location = new System.Drawing.Point(6, 17);
            this.marlinCheckBoxUSE_XMIN_PLUG.Name = "marlinCheckBoxUSE_XMIN_PLUG";
            this.marlinCheckBoxUSE_XMIN_PLUG.NewFirmwareHelper = null;
            this.marlinCheckBoxUSE_XMIN_PLUG.Size = new System.Drawing.Size(179, 21);
            this.marlinCheckBoxUSE_XMIN_PLUG.TabIndex = 0;
            // 
            // marlinCheckBoxUSE_YMIN_PLUG
            // 
            this.marlinCheckBoxUSE_YMIN_PLUG.ControlText = "Use Ymin Plug";
            this.marlinCheckBoxUSE_YMIN_PLUG.currentFirmwareHelper = null;
            this.marlinCheckBoxUSE_YMIN_PLUG.Feature = "USE_YMIN_PLUG";
            this.marlinCheckBoxUSE_YMIN_PLUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-plugs";
            this.marlinCheckBoxUSE_YMIN_PLUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxUSE_YMIN_PLUG.Location = new System.Drawing.Point(6, 44);
            this.marlinCheckBoxUSE_YMIN_PLUG.Name = "marlinCheckBoxUSE_YMIN_PLUG";
            this.marlinCheckBoxUSE_YMIN_PLUG.NewFirmwareHelper = null;
            this.marlinCheckBoxUSE_YMIN_PLUG.Size = new System.Drawing.Size(179, 21);
            this.marlinCheckBoxUSE_YMIN_PLUG.TabIndex = 1;
            // 
            // marlinCheckBoxUSE_ZMAX_PLUG
            // 
            this.marlinCheckBoxUSE_ZMAX_PLUG.ControlText = "Use Zmax Plug";
            this.marlinCheckBoxUSE_ZMAX_PLUG.currentFirmwareHelper = null;
            this.marlinCheckBoxUSE_ZMAX_PLUG.Feature = "USE_ZMAX_PLUG";
            this.marlinCheckBoxUSE_ZMAX_PLUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-plugs";
            this.marlinCheckBoxUSE_ZMAX_PLUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxUSE_ZMAX_PLUG.Location = new System.Drawing.Point(6, 173);
            this.marlinCheckBoxUSE_ZMAX_PLUG.Name = "marlinCheckBoxUSE_ZMAX_PLUG";
            this.marlinCheckBoxUSE_ZMAX_PLUG.NewFirmwareHelper = null;
            this.marlinCheckBoxUSE_ZMAX_PLUG.Size = new System.Drawing.Size(179, 21);
            this.marlinCheckBoxUSE_ZMAX_PLUG.TabIndex = 5;
            // 
            // marlinCheckBoxUSE_XMAX_PLUG
            // 
            this.marlinCheckBoxUSE_XMAX_PLUG.ControlText = "Use Xmax Plug";
            this.marlinCheckBoxUSE_XMAX_PLUG.currentFirmwareHelper = null;
            this.marlinCheckBoxUSE_XMAX_PLUG.Feature = "USE_XMAX_PLUG";
            this.marlinCheckBoxUSE_XMAX_PLUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-plugs";
            this.marlinCheckBoxUSE_XMAX_PLUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxUSE_XMAX_PLUG.Location = new System.Drawing.Point(6, 119);
            this.marlinCheckBoxUSE_XMAX_PLUG.Name = "marlinCheckBoxUSE_XMAX_PLUG";
            this.marlinCheckBoxUSE_XMAX_PLUG.NewFirmwareHelper = null;
            this.marlinCheckBoxUSE_XMAX_PLUG.Size = new System.Drawing.Size(179, 21);
            this.marlinCheckBoxUSE_XMAX_PLUG.TabIndex = 3;
            // 
            // marlinCheckBoxUSE_YMAX_PLUG
            // 
            this.marlinCheckBoxUSE_YMAX_PLUG.ControlText = "Use Ymax Plug";
            this.marlinCheckBoxUSE_YMAX_PLUG.currentFirmwareHelper = null;
            this.marlinCheckBoxUSE_YMAX_PLUG.Feature = "USE_YMAX_PLUG";
            this.marlinCheckBoxUSE_YMAX_PLUG.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-plugs";
            this.marlinCheckBoxUSE_YMAX_PLUG.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxUSE_YMAX_PLUG.Location = new System.Drawing.Point(6, 146);
            this.marlinCheckBoxUSE_YMAX_PLUG.Name = "marlinCheckBoxUSE_YMAX_PLUG";
            this.marlinCheckBoxUSE_YMAX_PLUG.NewFirmwareHelper = null;
            this.marlinCheckBoxUSE_YMAX_PLUG.Size = new System.Drawing.Size(179, 21);
            this.marlinCheckBoxUSE_YMAX_PLUG.TabIndex = 4;
            // 
            // groupBoxInvertingEndstops
            // 
            this.groupBoxInvertingEndstops.Controls.Add(this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE);
            this.groupBoxInvertingEndstops.Controls.Add(this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING);
            this.groupBoxInvertingEndstops.Controls.Add(this.marlinComboBoxY_MAX_ENDSTOP_INVERTING);
            this.groupBoxInvertingEndstops.Controls.Add(this.marlinComboBoxX_MAX_ENDSTOP_INVERTING);
            this.groupBoxInvertingEndstops.Controls.Add(this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING);
            this.groupBoxInvertingEndstops.Controls.Add(this.marlinComboBoxY_MIN_ENDSTOP_INVERTING);
            this.groupBoxInvertingEndstops.Controls.Add(this.marlinComboBoxX_MIN_ENDSTOP_INVERTING);
            this.groupBoxInvertingEndstops.Location = new System.Drawing.Point(205, 15);
            this.groupBoxInvertingEndstops.Name = "groupBoxInvertingEndstops";
            this.groupBoxInvertingEndstops.Size = new System.Drawing.Size(260, 283);
            this.groupBoxInvertingEndstops.TabIndex = 15;
            this.groupBoxInvertingEndstops.TabStop = false;
            this.groupBoxInvertingEndstops.Text = "Inverting Endstops";
            // 
            // marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE
            // 
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.ControlText = "Use Endstop Interupt feature";
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.Feature = "ENDSTOP_INTERRUPTS_FEATURE";
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-interrupts";
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.Location = new System.Drawing.Point(26, 256);
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.Name = "marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE";
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.Size = new System.Drawing.Size(224, 21);
            this.marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE.TabIndex = 6;
            // 
            // marlinComboBoxZ_MAX_ENDSTOP_INVERTING
            // 
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.ControlText = "Invert Endstop Zmax";
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.currentFirmwareHelper = null;
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.Feature = "Z_MAX_ENDSTOP_INVERTING";
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-inverting";
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.IsTrueFalse = true;
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.Location = new System.Drawing.Point(26, 179);
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.Name = "marlinComboBoxZ_MAX_ENDSTOP_INVERTING";
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.NewFirmwareHelper = null;
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.Size = new System.Drawing.Size(224, 26);
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.SpliterDistance = 110;
            this.marlinComboBoxZ_MAX_ENDSTOP_INVERTING.TabIndex = 5;
            // 
            // marlinComboBoxY_MAX_ENDSTOP_INVERTING
            // 
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.ControlText = "Invert Endstop Ymax";
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.currentFirmwareHelper = null;
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.Feature = "Y_MAX_ENDSTOP_INVERTING";
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-inverting";
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.IsTrueFalse = true;
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.Location = new System.Drawing.Point(26, 147);
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.Name = "marlinComboBoxY_MAX_ENDSTOP_INVERTING";
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.NewFirmwareHelper = null;
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.Size = new System.Drawing.Size(224, 26);
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.SpliterDistance = 110;
            this.marlinComboBoxY_MAX_ENDSTOP_INVERTING.TabIndex = 4;
            // 
            // marlinComboBoxX_MAX_ENDSTOP_INVERTING
            // 
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.ControlText = "Invert Endstop Xmax";
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.currentFirmwareHelper = null;
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.Feature = "X_MAX_ENDSTOP_INVERTING";
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-inverting";
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.IsTrueFalse = true;
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.Location = new System.Drawing.Point(26, 115);
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.Name = "marlinComboBoxX_MAX_ENDSTOP_INVERTING";
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.NewFirmwareHelper = null;
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.Size = new System.Drawing.Size(224, 26);
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.SpliterDistance = 110;
            this.marlinComboBoxX_MAX_ENDSTOP_INVERTING.TabIndex = 3;
            // 
            // marlinComboBoxZ_MIN_ENDSTOP_INVERTING
            // 
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.ControlText = "Invert Endstop Zmin";
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.currentFirmwareHelper = null;
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.Feature = "Z_MIN_ENDSTOP_INVERTING";
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-inverting";
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.IsTrueFalse = true;
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.Location = new System.Drawing.Point(26, 83);
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.Name = "marlinComboBoxZ_MIN_ENDSTOP_INVERTING";
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.NewFirmwareHelper = null;
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.Size = new System.Drawing.Size(224, 26);
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.SpliterDistance = 110;
            this.marlinComboBoxZ_MIN_ENDSTOP_INVERTING.TabIndex = 2;
            // 
            // marlinComboBoxY_MIN_ENDSTOP_INVERTING
            // 
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.ControlText = "Invert Endstop Ymin";
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.currentFirmwareHelper = null;
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.Feature = "Y_MIN_ENDSTOP_INVERTING";
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-inverting";
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.IsTrueFalse = true;
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.Location = new System.Drawing.Point(26, 51);
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.Name = "marlinComboBoxY_MIN_ENDSTOP_INVERTING";
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.NewFirmwareHelper = null;
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.Size = new System.Drawing.Size(224, 26);
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.SpliterDistance = 110;
            this.marlinComboBoxY_MIN_ENDSTOP_INVERTING.TabIndex = 1;
            // 
            // marlinComboBoxX_MIN_ENDSTOP_INVERTING
            // 
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.ControlText = "Invert Endstop Xmin";
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.currentFirmwareHelper = null;
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.Feature = "X_MIN_ENDSTOP_INVERTING";
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-inverting";
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.IsTrueFalse = true;
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.Location = new System.Drawing.Point(26, 19);
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.Name = "marlinComboBoxX_MIN_ENDSTOP_INVERTING";
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.NewFirmwareHelper = null;
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.Size = new System.Drawing.Size(224, 26);
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.SpliterDistance = 110;
            this.marlinComboBoxX_MIN_ENDSTOP_INVERTING.TabIndex = 0;
            // 
            // grpBxPullupResistors
            // 
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUPS);
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE);
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_XMAX);
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_ZMIN);
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_YMAX);
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_YMIN);
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_ZMAX);
            this.grpBxPullupResistors.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_XMIN);
            this.grpBxPullupResistors.Location = new System.Drawing.Point(8, 226);
            this.grpBxPullupResistors.Name = "grpBxPullupResistors";
            this.grpBxPullupResistors.Size = new System.Drawing.Size(191, 283);
            this.grpBxPullupResistors.TabIndex = 14;
            this.grpBxPullupResistors.TabStop = false;
            this.grpBxPullupResistors.Text = "Pullup Resistors";
            // 
            // marlinCheckBoxENDSTOPPULLUPS
            // 
            this.marlinCheckBoxENDSTOPPULLUPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUPS.ControlText = "endstop pullup resistors";
            this.marlinCheckBoxENDSTOPPULLUPS.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUPS.Feature = "ENDSTOPPULLUPS";
            this.marlinCheckBoxENDSTOPPULLUPS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUPS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUPS.Location = new System.Drawing.Point(8, 19);
            this.marlinCheckBoxENDSTOPPULLUPS.Name = "marlinCheckBoxENDSTOPPULLUPS";
            this.marlinCheckBoxENDSTOPPULLUPS.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUPS.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUPS.TabIndex = 6;
            // 
            // marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE
            // 
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.ControlText = "Endstop Pullup Zmin Probe";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.Feature = "ENDSTOPPULLUP_ZMIN_PROBE";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.Location = new System.Drawing.Point(8, 257);
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.Name = "marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE.TabIndex = 13;
            // 
            // marlinCheckBoxENDSTOPPULLUP_XMAX
            // 
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.ControlText = "Endstop Pullup Xmax";
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.Feature = "ENDSTOPPULLUP_XMAX";
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.Location = new System.Drawing.Point(8, 65);
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.Name = "marlinCheckBoxENDSTOPPULLUP_XMAX";
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUP_XMAX.TabIndex = 7;
            // 
            // marlinCheckBoxENDSTOPPULLUP_ZMIN
            // 
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.ControlText = "Endstop Pullup Zmin";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.Feature = "ENDSTOPPULLUP_ZMIN";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.Location = new System.Drawing.Point(8, 210);
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.Name = "marlinCheckBoxENDSTOPPULLUP_ZMIN";
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUP_ZMIN.TabIndex = 12;
            // 
            // marlinCheckBoxENDSTOPPULLUP_YMAX
            // 
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.ControlText = "Endstop Pullup Ymax";
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.Feature = "ENDSTOPPULLUP_YMAX";
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.Location = new System.Drawing.Point(8, 94);
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.Name = "marlinCheckBoxENDSTOPPULLUP_YMAX";
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUP_YMAX.TabIndex = 8;
            // 
            // marlinCheckBoxENDSTOPPULLUP_YMIN
            // 
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.ControlText = "Endstop Pullup Ymin";
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.Feature = "ENDSTOPPULLUP_YMIN";
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.Location = new System.Drawing.Point(8, 181);
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.Name = "marlinCheckBoxENDSTOPPULLUP_YMIN";
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUP_YMIN.TabIndex = 11;
            // 
            // marlinCheckBoxENDSTOPPULLUP_ZMAX
            // 
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.ControlText = "Endstop Pullup Zmax";
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.Feature = "ENDSTOPPULLUP_ZMAX";
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.Location = new System.Drawing.Point(8, 123);
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.Name = "marlinCheckBoxENDSTOPPULLUP_ZMAX";
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUP_ZMAX.TabIndex = 9;
            // 
            // marlinCheckBoxENDSTOPPULLUP_XMIN
            // 
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.ControlText = "Endstop Pullup Xmin";
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.Feature = "ENDSTOPPULLUP_XMIN";
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#endstop-pullups";
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.Location = new System.Drawing.Point(8, 152);
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.Name = "marlinCheckBoxENDSTOPPULLUP_XMIN";
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.Size = new System.Drawing.Size(178, 21);
            this.marlinCheckBoxENDSTOPPULLUP_XMIN.TabIndex = 10;
            // 
            // tabPageMovement
            // 
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_EJERK);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_ZJERK);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_YJERK);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_XJERK);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_TRAVEL_ACCELERATION);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_RETRACT_ACCELERATION);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_ACCELERATION);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_MAX_ACCELERATION);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_MAX_FEEDRATE);
            this.tabPageMovement.Controls.Add(this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT);
            this.tabPageMovement.Controls.Add(this.marlinCheckBoxDISTINCT_E_FACTORS);
            this.tabPageMovement.Location = new System.Drawing.Point(4, 76);
            this.tabPageMovement.Name = "tabPageMovement";
            this.tabPageMovement.Size = new System.Drawing.Size(622, 585);
            this.tabPageMovement.TabIndex = 4;
            this.tabPageMovement.Text = "Movement";
            this.tabPageMovement.UseVisualStyleBackColor = true;
            // 
            // marlinValueDEFAULT_EJERK
            // 
            this.marlinValueDEFAULT_EJERK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_EJERK.ControlText = "Default E-Jerk";
            this.marlinValueDEFAULT_EJERK.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_EJERK.Feature = "DEFAULT_EJERK";
            this.marlinValueDEFAULT_EJERK.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_EJERK.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_EJERK.Location = new System.Drawing.Point(332, 354);
            this.marlinValueDEFAULT_EJERK.Name = "marlinValueDEFAULT_EJERK";
            this.marlinValueDEFAULT_EJERK.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_EJERK.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_EJERK.SpliterDistance = 140;
            this.marlinValueDEFAULT_EJERK.TabIndex = 9;
            // 
            // marlinValueDEFAULT_ZJERK
            // 
            this.marlinValueDEFAULT_ZJERK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_ZJERK.ControlText = "Default Z-Jerk";
            this.marlinValueDEFAULT_ZJERK.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_ZJERK.Feature = "DEFAULT_ZJERK";
            this.marlinValueDEFAULT_ZJERK.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_ZJERK.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_ZJERK.Location = new System.Drawing.Point(332, 322);
            this.marlinValueDEFAULT_ZJERK.Name = "marlinValueDEFAULT_ZJERK";
            this.marlinValueDEFAULT_ZJERK.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_ZJERK.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_ZJERK.SpliterDistance = 140;
            this.marlinValueDEFAULT_ZJERK.TabIndex = 8;
            // 
            // marlinValueDEFAULT_YJERK
            // 
            this.marlinValueDEFAULT_YJERK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_YJERK.ControlText = "Default Y-Jerk";
            this.marlinValueDEFAULT_YJERK.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_YJERK.Feature = "DEFAULT_YJERK";
            this.marlinValueDEFAULT_YJERK.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_YJERK.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_YJERK.Location = new System.Drawing.Point(332, 290);
            this.marlinValueDEFAULT_YJERK.Name = "marlinValueDEFAULT_YJERK";
            this.marlinValueDEFAULT_YJERK.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_YJERK.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_YJERK.SpliterDistance = 140;
            this.marlinValueDEFAULT_YJERK.TabIndex = 7;
            // 
            // marlinValueDEFAULT_XJERK
            // 
            this.marlinValueDEFAULT_XJERK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_XJERK.ControlText = "Default X-Jerk";
            this.marlinValueDEFAULT_XJERK.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_XJERK.Feature = "DEFAULT_XJERK";
            this.marlinValueDEFAULT_XJERK.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_XJERK.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_XJERK.Location = new System.Drawing.Point(332, 258);
            this.marlinValueDEFAULT_XJERK.Name = "marlinValueDEFAULT_XJERK";
            this.marlinValueDEFAULT_XJERK.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_XJERK.Size = new System.Drawing.Size(276, 26);
            this.marlinValueDEFAULT_XJERK.SpliterDistance = 140;
            this.marlinValueDEFAULT_XJERK.TabIndex = 6;
            // 
            // marlinValueDEFAULT_TRAVEL_ACCELERATION
            // 
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.ControlText = "Default Travel Acceleration:";
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.Feature = "DEFAULT_TRAVEL_ACCELERATION";
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.Location = new System.Drawing.Point(364, 209);
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.Name = "marlinValueDEFAULT_TRAVEL_ACCELERATION";
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.Size = new System.Drawing.Size(244, 26);
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.SpliterDistance = 146;
            this.marlinValueDEFAULT_TRAVEL_ACCELERATION.TabIndex = 5;
            // 
            // marlinValueDEFAULT_RETRACT_ACCELERATION
            // 
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.ControlText = "Default Retract Acceleration:";
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.Feature = "DEFAULT_RETRACT_ACCELERATION";
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.Location = new System.Drawing.Point(364, 177);
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.Name = "marlinValueDEFAULT_RETRACT_ACCELERATION";
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.Size = new System.Drawing.Size(244, 26);
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.SpliterDistance = 146;
            this.marlinValueDEFAULT_RETRACT_ACCELERATION.TabIndex = 4;
            // 
            // marlinValueDEFAULT_ACCELERATION
            // 
            this.marlinValueDEFAULT_ACCELERATION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_ACCELERATION.ControlText = "Default Acceleration";
            this.marlinValueDEFAULT_ACCELERATION.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_ACCELERATION.Feature = "DEFAULT_ACCELERATION";
            this.marlinValueDEFAULT_ACCELERATION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_ACCELERATION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_ACCELERATION.Location = new System.Drawing.Point(364, 145);
            this.marlinValueDEFAULT_ACCELERATION.Name = "marlinValueDEFAULT_ACCELERATION";
            this.marlinValueDEFAULT_ACCELERATION.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_ACCELERATION.Size = new System.Drawing.Size(244, 26);
            this.marlinValueDEFAULT_ACCELERATION.SpliterDistance = 146;
            this.marlinValueDEFAULT_ACCELERATION.TabIndex = 3;
            // 
            // marlinValueDEFAULT_MAX_ACCELERATION
            // 
            this.marlinValueDEFAULT_MAX_ACCELERATION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_MAX_ACCELERATION.ControlText = "Default Max Acceleration:";
            this.marlinValueDEFAULT_MAX_ACCELERATION.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_MAX_ACCELERATION.Feature = "DEFAULT_MAX_ACCELERATION";
            this.marlinValueDEFAULT_MAX_ACCELERATION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#acceleration";
            this.marlinValueDEFAULT_MAX_ACCELERATION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_MAX_ACCELERATION.Location = new System.Drawing.Point(138, 105);
            this.marlinValueDEFAULT_MAX_ACCELERATION.Name = "marlinValueDEFAULT_MAX_ACCELERATION";
            this.marlinValueDEFAULT_MAX_ACCELERATION.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_MAX_ACCELERATION.Size = new System.Drawing.Size(470, 26);
            this.marlinValueDEFAULT_MAX_ACCELERATION.SpliterDistance = 135;
            this.marlinValueDEFAULT_MAX_ACCELERATION.TabIndex = 2;
            // 
            // marlinValueDEFAULT_MAX_FEEDRATE
            // 
            this.marlinValueDEFAULT_MAX_FEEDRATE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_MAX_FEEDRATE.ControlText = "Default Max FeedRate:";
            this.marlinValueDEFAULT_MAX_FEEDRATE.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_MAX_FEEDRATE.Feature = "DEFAULT_MAX_FEEDRATE";
            this.marlinValueDEFAULT_MAX_FEEDRATE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#default-steps-per-mm-";
            this.marlinValueDEFAULT_MAX_FEEDRATE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_MAX_FEEDRATE.Location = new System.Drawing.Point(138, 73);
            this.marlinValueDEFAULT_MAX_FEEDRATE.Name = "marlinValueDEFAULT_MAX_FEEDRATE";
            this.marlinValueDEFAULT_MAX_FEEDRATE.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_MAX_FEEDRATE.Size = new System.Drawing.Size(470, 26);
            this.marlinValueDEFAULT_MAX_FEEDRATE.SpliterDistance = 135;
            this.marlinValueDEFAULT_MAX_FEEDRATE.TabIndex = 1;
            // 
            // marlinValueDEFAULT_AXIS_STEPS_PER_UNIT
            // 
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.ControlText = "Default Axis Steps per Unit:";
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.Feature = "DEFAULT_AXIS_STEPS_PER_UNIT";
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#default-steps-per-mm-";
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.Location = new System.Drawing.Point(138, 41);
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.Name = "marlinValueDEFAULT_AXIS_STEPS_PER_UNIT";
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.Size = new System.Drawing.Size(470, 26);
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.SpliterDistance = 135;
            this.marlinValueDEFAULT_AXIS_STEPS_PER_UNIT.TabIndex = 0;
            // 
            // marlinCheckBoxDISTINCT_E_FACTORS
            // 
            this.marlinCheckBoxDISTINCT_E_FACTORS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxDISTINCT_E_FACTORS.ControlText = "Distinct E-Factors";
            this.marlinCheckBoxDISTINCT_E_FACTORS.currentFirmwareHelper = null;
            this.marlinCheckBoxDISTINCT_E_FACTORS.Feature = "DISTINCT_E_FACTORS";
            this.marlinCheckBoxDISTINCT_E_FACTORS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#distinct-e-factors";
            this.marlinCheckBoxDISTINCT_E_FACTORS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxDISTINCT_E_FACTORS.Location = new System.Drawing.Point(364, 14);
            this.marlinCheckBoxDISTINCT_E_FACTORS.Name = "marlinCheckBoxDISTINCT_E_FACTORS";
            this.marlinCheckBoxDISTINCT_E_FACTORS.NewFirmwareHelper = null;
            this.marlinCheckBoxDISTINCT_E_FACTORS.Size = new System.Drawing.Size(244, 21);
            this.marlinCheckBoxDISTINCT_E_FACTORS.TabIndex = 0;
            // 
            // tabPageProbe
            // 
            this.tabPageProbe.Controls.Add(this.groupBoxZ_CLEARANCE);
            this.tabPageProbe.Controls.Add(this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST);
            this.tabPageProbe.Controls.Add(this.marlinCheckBoxPROBE_DOUBLE_TOUCH);
            this.tabPageProbe.Controls.Add(this.groupBoxZ_PROBE_SPEED);
            this.tabPageProbe.Controls.Add(this.groupBoxPROBE_OFFSET_FROM_EXTRUDER);
            this.tabPageProbe.Controls.Add(this.grpBxZ_PROBE_SLED);
            this.tabPageProbe.Controls.Add(this.marlinCheckBoxSOLENOID_PROBE);
            this.tabPageProbe.Controls.Add(this.grpBxBLTouch);
            this.tabPageProbe.Controls.Add(this.marlinEnableValueZ_SERVO_ANGLES);
            this.tabPageProbe.Controls.Add(this.marlinEnableValueZ_ENDSTOP_SERVO_NR);
            this.tabPageProbe.Controls.Add(this.marlinCheckBoxFIX_MOUNTED_PROBE);
            this.tabPageProbe.Controls.Add(this.marlinCheckBoxPROBE_MANUALLY);
            this.tabPageProbe.Controls.Add(this.marlinEnableValueZ_MIN_PROBE_PIN);
            this.tabPageProbe.Controls.Add(this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP);
            this.tabPageProbe.Controls.Add(this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN);
            this.tabPageProbe.Location = new System.Drawing.Point(4, 76);
            this.tabPageProbe.Name = "tabPageProbe";
            this.tabPageProbe.Size = new System.Drawing.Size(622, 585);
            this.tabPageProbe.TabIndex = 5;
            this.tabPageProbe.Text = "Z Probe";
            this.tabPageProbe.UseVisualStyleBackColor = true;
            // 
            // groupBoxZ_CLEARANCE
            // 
            this.groupBoxZ_CLEARANCE.Controls.Add(this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES);
            this.groupBoxZ_CLEARANCE.Controls.Add(this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE);
            this.groupBoxZ_CLEARANCE.Location = new System.Drawing.Point(4, 462);
            this.groupBoxZ_CLEARANCE.Name = "groupBoxZ_CLEARANCE";
            this.groupBoxZ_CLEARANCE.Size = new System.Drawing.Size(231, 79);
            this.groupBoxZ_CLEARANCE.TabIndex = 27;
            this.groupBoxZ_CLEARANCE.TabStop = false;
            this.groupBoxZ_CLEARANCE.Text = "Clearance";
            // 
            // marlinUpDnZ_CLEARANCE_BETWEEN_PROBES
            // 
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.ControlText = "Z Clerance between Probes";
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.currentFirmwareHelper = null;
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.Feature = "Z_CLEARANCE_BETWEEN_PROBES";
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-clearance";
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.Location = new System.Drawing.Point(6, 45);
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.Max = 20;
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.Min = 0;
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.Name = "marlinUpDnZ_CLEARANCE_BETWEEN_PROBES";
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.NewFirmwareHelper = null;
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.Size = new System.Drawing.Size(218, 26);
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.SpliterDistance = 140;
            this.marlinUpDnZ_CLEARANCE_BETWEEN_PROBES.TabIndex = 25;
            // 
            // marlinUpDnZ_CLEARANCE_DEPLOY_PROBE
            // 
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.ControlText = "Z Clerance while Deploy";
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.currentFirmwareHelper = null;
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.Feature = "Z_CLEARANCE_DEPLOY_PROBE";
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-clearance";
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.Location = new System.Drawing.Point(6, 13);
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.Max = 20;
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.Min = 0;
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.Name = "marlinUpDnZ_CLEARANCE_DEPLOY_PROBE";
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.NewFirmwareHelper = null;
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.Size = new System.Drawing.Size(219, 26);
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.SpliterDistance = 140;
            this.marlinUpDnZ_CLEARANCE_DEPLOY_PROBE.TabIndex = 24;
            // 
            // marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST
            // 
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.ControlText = "Z-min Probe Repeatablityty Test";
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.currentFirmwareHelper = null;
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.Feature = "Z_MIN_PROBE_REPEATABILITY_TEST";
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-testing";
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.Location = new System.Drawing.Point(383, 271);
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.Name = "marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST";
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.NewFirmwareHelper = null;
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.Size = new System.Drawing.Size(221, 21);
            this.marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST.TabIndex = 26;
            // 
            // marlinCheckBoxPROBE_DOUBLE_TOUCH
            // 
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.ControlText = "Probe Doubletouch";
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.currentFirmwareHelper = null;
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.Feature = "PROBE_DOUBLE_TOUCH";
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-double-touch";
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.Location = new System.Drawing.Point(383, 244);
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.Name = "marlinCheckBoxPROBE_DOUBLE_TOUCH";
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.NewFirmwareHelper = null;
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.Size = new System.Drawing.Size(221, 21);
            this.marlinCheckBoxPROBE_DOUBLE_TOUCH.TabIndex = 23;
            // 
            // groupBoxZ_PROBE_SPEED
            // 
            this.groupBoxZ_PROBE_SPEED.Controls.Add(this.marlinValueZ_PROBE_SPEED_FAST);
            this.groupBoxZ_PROBE_SPEED.Controls.Add(this.marlinValueZ_PROBE_SPEED_SLOW);
            this.groupBoxZ_PROBE_SPEED.Controls.Add(this.marlinValueXY_PROBE_SPEED);
            this.groupBoxZ_PROBE_SPEED.Location = new System.Drawing.Point(3, 339);
            this.groupBoxZ_PROBE_SPEED.Name = "groupBoxZ_PROBE_SPEED";
            this.groupBoxZ_PROBE_SPEED.Size = new System.Drawing.Size(232, 117);
            this.groupBoxZ_PROBE_SPEED.TabIndex = 22;
            this.groupBoxZ_PROBE_SPEED.TabStop = false;
            this.groupBoxZ_PROBE_SPEED.Text = "Z-probe Speed";
            // 
            // marlinValueZ_PROBE_SPEED_FAST
            // 
            this.marlinValueZ_PROBE_SPEED_FAST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueZ_PROBE_SPEED_FAST.ControlText = "Fast Probe Speed";
            this.marlinValueZ_PROBE_SPEED_FAST.currentFirmwareHelper = null;
            this.marlinValueZ_PROBE_SPEED_FAST.Feature = "Z_PROBE_SPEED_FAST";
            this.marlinValueZ_PROBE_SPEED_FAST.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probing-speed";
            this.marlinValueZ_PROBE_SPEED_FAST.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueZ_PROBE_SPEED_FAST.Location = new System.Drawing.Point(25, 52);
            this.marlinValueZ_PROBE_SPEED_FAST.Name = "marlinValueZ_PROBE_SPEED_FAST";
            this.marlinValueZ_PROBE_SPEED_FAST.NewFirmwareHelper = null;
            this.marlinValueZ_PROBE_SPEED_FAST.Size = new System.Drawing.Size(201, 26);
            this.marlinValueZ_PROBE_SPEED_FAST.SpliterDistance = 110;
            this.marlinValueZ_PROBE_SPEED_FAST.TabIndex = 20;
            // 
            // marlinValueZ_PROBE_SPEED_SLOW
            // 
            this.marlinValueZ_PROBE_SPEED_SLOW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueZ_PROBE_SPEED_SLOW.ControlText = "Slow Probe Speed";
            this.marlinValueZ_PROBE_SPEED_SLOW.currentFirmwareHelper = null;
            this.marlinValueZ_PROBE_SPEED_SLOW.Feature = "Z_PROBE_SPEED_SLOW";
            this.marlinValueZ_PROBE_SPEED_SLOW.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probing-speed";
            this.marlinValueZ_PROBE_SPEED_SLOW.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueZ_PROBE_SPEED_SLOW.Location = new System.Drawing.Point(25, 84);
            this.marlinValueZ_PROBE_SPEED_SLOW.Name = "marlinValueZ_PROBE_SPEED_SLOW";
            this.marlinValueZ_PROBE_SPEED_SLOW.NewFirmwareHelper = null;
            this.marlinValueZ_PROBE_SPEED_SLOW.Size = new System.Drawing.Size(201, 26);
            this.marlinValueZ_PROBE_SPEED_SLOW.SpliterDistance = 110;
            this.marlinValueZ_PROBE_SPEED_SLOW.TabIndex = 21;
            // 
            // marlinValueXY_PROBE_SPEED
            // 
            this.marlinValueXY_PROBE_SPEED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueXY_PROBE_SPEED.ControlText = "X and Y Probe Speed";
            this.marlinValueXY_PROBE_SPEED.currentFirmwareHelper = null;
            this.marlinValueXY_PROBE_SPEED.Feature = "XY_PROBE_SPEED";
            this.marlinValueXY_PROBE_SPEED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probing-speed";
            this.marlinValueXY_PROBE_SPEED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueXY_PROBE_SPEED.Location = new System.Drawing.Point(25, 20);
            this.marlinValueXY_PROBE_SPEED.Name = "marlinValueXY_PROBE_SPEED";
            this.marlinValueXY_PROBE_SPEED.NewFirmwareHelper = null;
            this.marlinValueXY_PROBE_SPEED.Size = new System.Drawing.Size(201, 26);
            this.marlinValueXY_PROBE_SPEED.SpliterDistance = 110;
            this.marlinValueXY_PROBE_SPEED.TabIndex = 19;
            // 
            // groupBoxPROBE_OFFSET_FROM_EXTRUDER
            // 
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.Controls.Add(this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER);
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.Controls.Add(this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER);
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.Controls.Add(this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER);
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.Location = new System.Drawing.Point(3, 212);
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.Name = "groupBoxPROBE_OFFSET_FROM_EXTRUDER";
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.Size = new System.Drawing.Size(231, 121);
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.TabIndex = 18;
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.TabStop = false;
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.Text = "Probe Offset from Extruder";
            // 
            // marlinValueY_PROBE_OFFSET_FROM_EXTRUDER
            // 
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.ControlText = "Y-probe Offset from Extruder";
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.currentFirmwareHelper = null;
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.Feature = "Y_PROBE_OFFSET_FROM_EXTRUDER";
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-offsets-";
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.Location = new System.Drawing.Point(5, 53);
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.Name = "marlinValueY_PROBE_OFFSET_FROM_EXTRUDER";
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.NewFirmwareHelper = null;
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.Size = new System.Drawing.Size(220, 26);
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.SpliterDistance = 140;
            this.marlinValueY_PROBE_OFFSET_FROM_EXTRUDER.TabIndex = 16;
            // 
            // marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER
            // 
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.ControlText = "Z-probe Offset from Extruder";
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.currentFirmwareHelper = null;
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.Feature = "Z_PROBE_OFFSET_FROM_EXTRUDER";
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-offsets-";
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.Location = new System.Drawing.Point(5, 85);
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.Name = "marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER";
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.NewFirmwareHelper = null;
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.Size = new System.Drawing.Size(220, 26);
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.SpliterDistance = 140;
            this.marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER.TabIndex = 17;
            // 
            // marlinValueX_PROBE_OFFSET_FROM_EXTRUDER
            // 
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.ControlText = "X-probe Offset from Extruder";
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.currentFirmwareHelper = null;
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.Feature = "X_PROBE_OFFSET_FROM_EXTRUDER";
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-offsets-";
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.Location = new System.Drawing.Point(5, 21);
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.Name = "marlinValueX_PROBE_OFFSET_FROM_EXTRUDER";
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.NewFirmwareHelper = null;
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.Size = new System.Drawing.Size(220, 26);
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.SpliterDistance = 140;
            this.marlinValueX_PROBE_OFFSET_FROM_EXTRUDER.TabIndex = 15;
            // 
            // grpBxZ_PROBE_SLED
            // 
            this.grpBxZ_PROBE_SLED.Controls.Add(this.marlinEnableValueSLED_DOCKING_OFFSET);
            this.grpBxZ_PROBE_SLED.Controls.Add(this.marlinCheckBoxZ_PROBE_SLED);
            this.grpBxZ_PROBE_SLED.Location = new System.Drawing.Point(4, 126);
            this.grpBxZ_PROBE_SLED.Name = "grpBxZ_PROBE_SLED";
            this.grpBxZ_PROBE_SLED.Size = new System.Drawing.Size(231, 80);
            this.grpBxZ_PROBE_SLED.TabIndex = 14;
            this.grpBxZ_PROBE_SLED.TabStop = false;
            this.grpBxZ_PROBE_SLED.Text = "Z-probe Sled";
            // 
            // marlinEnableValueSLED_DOCKING_OFFSET
            // 
            this.marlinEnableValueSLED_DOCKING_OFFSET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueSLED_DOCKING_OFFSET.ControlText = "Z-Sled Docking offset";
            this.marlinEnableValueSLED_DOCKING_OFFSET.currentFirmwareHelper = null;
            this.marlinEnableValueSLED_DOCKING_OFFSET.Feature = "SLED_DOCKING_OFFSET";
            this.marlinEnableValueSLED_DOCKING_OFFSET.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinEnableValueSLED_DOCKING_OFFSET.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueSLED_DOCKING_OFFSET.Location = new System.Drawing.Point(31, 47);
            this.marlinEnableValueSLED_DOCKING_OFFSET.Name = "marlinEnableValueSLED_DOCKING_OFFSET";
            this.marlinEnableValueSLED_DOCKING_OFFSET.NewFirmwareHelper = null;
            this.marlinEnableValueSLED_DOCKING_OFFSET.Size = new System.Drawing.Size(194, 26);
            this.marlinEnableValueSLED_DOCKING_OFFSET.SpliterDistance = 125;
            this.marlinEnableValueSLED_DOCKING_OFFSET.TabIndex = 13;
            // 
            // marlinCheckBoxZ_PROBE_SLED
            // 
            this.marlinCheckBoxZ_PROBE_SLED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxZ_PROBE_SLED.ControlText = "Z-probe Sled";
            this.marlinCheckBoxZ_PROBE_SLED.currentFirmwareHelper = null;
            this.marlinCheckBoxZ_PROBE_SLED.Feature = "Z_PROBE_SLED";
            this.marlinCheckBoxZ_PROBE_SLED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinCheckBoxZ_PROBE_SLED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxZ_PROBE_SLED.Location = new System.Drawing.Point(27, 20);
            this.marlinCheckBoxZ_PROBE_SLED.Name = "marlinCheckBoxZ_PROBE_SLED";
            this.marlinCheckBoxZ_PROBE_SLED.NewFirmwareHelper = null;
            this.marlinCheckBoxZ_PROBE_SLED.Size = new System.Drawing.Size(198, 21);
            this.marlinCheckBoxZ_PROBE_SLED.TabIndex = 12;
            // 
            // marlinCheckBoxSOLENOID_PROBE
            // 
            this.marlinCheckBoxSOLENOID_PROBE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSOLENOID_PROBE.ControlText = "Solenoid Probe";
            this.marlinCheckBoxSOLENOID_PROBE.currentFirmwareHelper = null;
            this.marlinCheckBoxSOLENOID_PROBE.Feature = "SOLENOID_PROBE";
            this.marlinCheckBoxSOLENOID_PROBE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinCheckBoxSOLENOID_PROBE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSOLENOID_PROBE.Location = new System.Drawing.Point(383, 217);
            this.marlinCheckBoxSOLENOID_PROBE.Name = "marlinCheckBoxSOLENOID_PROBE";
            this.marlinCheckBoxSOLENOID_PROBE.NewFirmwareHelper = null;
            this.marlinCheckBoxSOLENOID_PROBE.Size = new System.Drawing.Size(221, 21);
            this.marlinCheckBoxSOLENOID_PROBE.TabIndex = 11;
            // 
            // grpBxBLTouch
            // 
            this.grpBxBLTouch.Controls.Add(this.marlinCheckBoxBLTOUCH);
            this.grpBxBLTouch.Controls.Add(this.marlinCheckBoxBLTOUCH_HEATERS_OFF);
            this.grpBxBLTouch.Controls.Add(this.marlinEnableValueBLTOUCH_DELAY);
            this.grpBxBLTouch.Location = new System.Drawing.Point(4, 13);
            this.grpBxBLTouch.Name = "grpBxBLTouch";
            this.grpBxBLTouch.Size = new System.Drawing.Size(230, 107);
            this.grpBxBLTouch.TabIndex = 10;
            this.grpBxBLTouch.TabStop = false;
            this.grpBxBLTouch.Text = "BLTouch";
            // 
            // marlinCheckBoxBLTOUCH
            // 
            this.marlinCheckBoxBLTOUCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxBLTOUCH.ControlText = "BLTouch";
            this.marlinCheckBoxBLTOUCH.currentFirmwareHelper = null;
            this.marlinCheckBoxBLTOUCH.Feature = "BLTOUCH";
            this.marlinCheckBoxBLTOUCH.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinCheckBoxBLTOUCH.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxBLTOUCH.Location = new System.Drawing.Point(36, 19);
            this.marlinCheckBoxBLTOUCH.Name = "marlinCheckBoxBLTOUCH";
            this.marlinCheckBoxBLTOUCH.NewFirmwareHelper = null;
            this.marlinCheckBoxBLTOUCH.Size = new System.Drawing.Size(188, 21);
            this.marlinCheckBoxBLTOUCH.TabIndex = 7;
            // 
            // marlinCheckBoxBLTOUCH_HEATERS_OFF
            // 
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.ControlText = "BLTouch Heaters Off";
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.currentFirmwareHelper = null;
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.Feature = "BLTOUCH_HEATERS_OFF";
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.Location = new System.Drawing.Point(36, 78);
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.Name = "marlinCheckBoxBLTOUCH_HEATERS_OFF";
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.NewFirmwareHelper = null;
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.Size = new System.Drawing.Size(188, 21);
            this.marlinCheckBoxBLTOUCH_HEATERS_OFF.TabIndex = 9;
            // 
            // marlinEnableValueBLTOUCH_DELAY
            // 
            this.marlinEnableValueBLTOUCH_DELAY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueBLTOUCH_DELAY.ControlText = "BLTouch Delay:";
            this.marlinEnableValueBLTOUCH_DELAY.currentFirmwareHelper = null;
            this.marlinEnableValueBLTOUCH_DELAY.Feature = "BLTOUCH_DELAY";
            this.marlinEnableValueBLTOUCH_DELAY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinEnableValueBLTOUCH_DELAY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueBLTOUCH_DELAY.Location = new System.Drawing.Point(40, 46);
            this.marlinEnableValueBLTOUCH_DELAY.Name = "marlinEnableValueBLTOUCH_DELAY";
            this.marlinEnableValueBLTOUCH_DELAY.NewFirmwareHelper = null;
            this.marlinEnableValueBLTOUCH_DELAY.Size = new System.Drawing.Size(184, 26);
            this.marlinEnableValueBLTOUCH_DELAY.SpliterDistance = 97;
            this.marlinEnableValueBLTOUCH_DELAY.TabIndex = 8;
            // 
            // marlinEnableValueZ_SERVO_ANGLES
            // 
            this.marlinEnableValueZ_SERVO_ANGLES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueZ_SERVO_ANGLES.ControlText = "Z Servo Angles:";
            this.marlinEnableValueZ_SERVO_ANGLES.currentFirmwareHelper = null;
            this.marlinEnableValueZ_SERVO_ANGLES.Feature = "Z_SERVO_ANGLES";
            this.marlinEnableValueZ_SERVO_ANGLES.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinEnableValueZ_SERVO_ANGLES.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueZ_SERVO_ANGLES.Location = new System.Drawing.Point(387, 185);
            this.marlinEnableValueZ_SERVO_ANGLES.Name = "marlinEnableValueZ_SERVO_ANGLES";
            this.marlinEnableValueZ_SERVO_ANGLES.NewFirmwareHelper = null;
            this.marlinEnableValueZ_SERVO_ANGLES.Size = new System.Drawing.Size(217, 26);
            this.marlinEnableValueZ_SERVO_ANGLES.SpliterDistance = 86;
            this.marlinEnableValueZ_SERVO_ANGLES.TabIndex = 6;
            // 
            // marlinEnableValueZ_ENDSTOP_SERVO_NR
            // 
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.ControlText = "Z Endstop Servo Number:";
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.currentFirmwareHelper = null;
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.Feature = "Z_ENDSTOP_SERVO_NR";
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.Location = new System.Drawing.Point(387, 153);
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.Name = "marlinEnableValueZ_ENDSTOP_SERVO_NR";
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.NewFirmwareHelper = null;
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.Size = new System.Drawing.Size(217, 26);
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.SpliterDistance = 132;
            this.marlinEnableValueZ_ENDSTOP_SERVO_NR.TabIndex = 5;
            // 
            // marlinCheckBoxFIX_MOUNTED_PROBE
            // 
            this.marlinCheckBoxFIX_MOUNTED_PROBE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxFIX_MOUNTED_PROBE.ControlText = "Fix mounted Probe";
            this.marlinCheckBoxFIX_MOUNTED_PROBE.currentFirmwareHelper = null;
            this.marlinCheckBoxFIX_MOUNTED_PROBE.Feature = "FIX_MOUNTED_PROBE";
            this.marlinCheckBoxFIX_MOUNTED_PROBE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinCheckBoxFIX_MOUNTED_PROBE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxFIX_MOUNTED_PROBE.Location = new System.Drawing.Point(382, 126);
            this.marlinCheckBoxFIX_MOUNTED_PROBE.Name = "marlinCheckBoxFIX_MOUNTED_PROBE";
            this.marlinCheckBoxFIX_MOUNTED_PROBE.NewFirmwareHelper = null;
            this.marlinCheckBoxFIX_MOUNTED_PROBE.Size = new System.Drawing.Size(222, 21);
            this.marlinCheckBoxFIX_MOUNTED_PROBE.TabIndex = 4;
            // 
            // marlinCheckBoxPROBE_MANUALLY
            // 
            this.marlinCheckBoxPROBE_MANUALLY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPROBE_MANUALLY.ControlText = "Probe Manually";
            this.marlinCheckBoxPROBE_MANUALLY.currentFirmwareHelper = null;
            this.marlinCheckBoxPROBE_MANUALLY.Feature = "PROBE_MANUALLY";
            this.marlinCheckBoxPROBE_MANUALLY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-type";
            this.marlinCheckBoxPROBE_MANUALLY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPROBE_MANUALLY.Location = new System.Drawing.Point(383, 99);
            this.marlinCheckBoxPROBE_MANUALLY.Name = "marlinCheckBoxPROBE_MANUALLY";
            this.marlinCheckBoxPROBE_MANUALLY.NewFirmwareHelper = null;
            this.marlinCheckBoxPROBE_MANUALLY.Size = new System.Drawing.Size(221, 21);
            this.marlinCheckBoxPROBE_MANUALLY.TabIndex = 3;
            // 
            // marlinEnableValueZ_MIN_PROBE_PIN
            // 
            this.marlinEnableValueZ_MIN_PROBE_PIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueZ_MIN_PROBE_PIN.ControlText = "Z-min Probe Pin:";
            this.marlinEnableValueZ_MIN_PROBE_PIN.currentFirmwareHelper = null;
            this.marlinEnableValueZ_MIN_PROBE_PIN.Feature = "Z_MIN_PROBE_PIN";
            this.marlinEnableValueZ_MIN_PROBE_PIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-pins";
            this.marlinEnableValueZ_MIN_PROBE_PIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueZ_MIN_PROBE_PIN.Location = new System.Drawing.Point(388, 67);
            this.marlinEnableValueZ_MIN_PROBE_PIN.Name = "marlinEnableValueZ_MIN_PROBE_PIN";
            this.marlinEnableValueZ_MIN_PROBE_PIN.NewFirmwareHelper = null;
            this.marlinEnableValueZ_MIN_PROBE_PIN.Size = new System.Drawing.Size(216, 26);
            this.marlinEnableValueZ_MIN_PROBE_PIN.SpliterDistance = 91;
            this.marlinEnableValueZ_MIN_PROBE_PIN.TabIndex = 2;
            // 
            // marlinCheckBoxZ_MIN_PROBE_ENDSTOP
            // 
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.ControlText = "Z-min Probe Endstop";
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.currentFirmwareHelper = null;
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.Feature = "Z_MIN_PROBE_ENDSTOP";
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-pins";
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.Location = new System.Drawing.Point(383, 40);
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.Name = "marlinCheckBoxZ_MIN_PROBE_ENDSTOP";
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.NewFirmwareHelper = null;
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.Size = new System.Drawing.Size(221, 21);
            this.marlinCheckBoxZ_MIN_PROBE_ENDSTOP.TabIndex = 1;
            // 
            // marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN
            // 
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.ControlText = "Z-min Probe Uses Z-min Endstop Pin";
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.currentFirmwareHelper = null;
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.Feature = "Z_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN";
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#probe-pins";
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.Location = new System.Drawing.Point(383, 13);
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.Name = "marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN";
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.NewFirmwareHelper = null;
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.Size = new System.Drawing.Size(221, 21);
            this.marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN.TabIndex = 0;
            // 
            // tabPageStepper
            // 
            this.tabPageStepper.Controls.Add(this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA);
            this.tabPageStepper.Controls.Add(this.grpBxInvertDirection);
            this.tabPageStepper.Controls.Add(this.grpBxDisableSteppers);
            this.tabPageStepper.Controls.Add(this.grpBxStepperEnablePin);
            this.tabPageStepper.Location = new System.Drawing.Point(4, 76);
            this.tabPageStepper.Name = "tabPageStepper";
            this.tabPageStepper.Size = new System.Drawing.Size(622, 585);
            this.tabPageStepper.TabIndex = 15;
            this.tabPageStepper.Text = "Stepper";
            this.tabPageStepper.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxCONFIG_STEPPERS_TOSHIBA
            // 
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.ControlText = "Toshiba stepper Driver";
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.currentFirmwareHelper = null;
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.Feature = "CONFIG_STEPPERS_TOSHIBA";
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#toshiba-drivers";
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.Location = new System.Drawing.Point(407, 22);
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.Name = "marlinCheckBoxCONFIG_STEPPERS_TOSHIBA";
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.NewFirmwareHelper = null;
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.Size = new System.Drawing.Size(204, 21);
            this.marlinCheckBoxCONFIG_STEPPERS_TOSHIBA.TabIndex = 3;
            // 
            // grpBxInvertDirection
            // 
            this.grpBxInvertDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_E4_DIR);
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_E3_DIR);
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_E2_DIR);
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_E1_DIR);
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_E0_DIR);
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_Z_DIR);
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_Y_DIR);
            this.grpBxInvertDirection.Controls.Add(this.marlinComboBoxINVERT_X_DIR);
            this.grpBxInvertDirection.Location = new System.Drawing.Point(405, 49);
            this.grpBxInvertDirection.Name = "grpBxInvertDirection";
            this.grpBxInvertDirection.Size = new System.Drawing.Size(214, 274);
            this.grpBxInvertDirection.TabIndex = 2;
            this.grpBxInvertDirection.TabStop = false;
            this.grpBxInvertDirection.Text = "Invert  Stepper Direction";
            // 
            // marlinComboBoxINVERT_E4_DIR
            // 
            this.marlinComboBoxINVERT_E4_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_E4_DIR.ControlText = "Invert Extruder 4 direction:";
            this.marlinComboBoxINVERT_E4_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_E4_DIR.Feature = "INVERT_E4_DIR";
            this.marlinComboBoxINVERT_E4_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_E4_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_E4_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_E4_DIR.Location = new System.Drawing.Point(3, 243);
            this.marlinComboBoxINVERT_E4_DIR.Name = "marlinComboBoxINVERT_E4_DIR";
            this.marlinComboBoxINVERT_E4_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_E4_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_E4_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_E4_DIR.TabIndex = 12;
            // 
            // marlinComboBoxINVERT_E3_DIR
            // 
            this.marlinComboBoxINVERT_E3_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_E3_DIR.ControlText = "Invert Extruder 3 direction:";
            this.marlinComboBoxINVERT_E3_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_E3_DIR.Feature = "INVERT_E3_DIR";
            this.marlinComboBoxINVERT_E3_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_E3_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_E3_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_E3_DIR.Location = new System.Drawing.Point(3, 211);
            this.marlinComboBoxINVERT_E3_DIR.Name = "marlinComboBoxINVERT_E3_DIR";
            this.marlinComboBoxINVERT_E3_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_E3_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_E3_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_E3_DIR.TabIndex = 11;
            // 
            // marlinComboBoxINVERT_E2_DIR
            // 
            this.marlinComboBoxINVERT_E2_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_E2_DIR.ControlText = "Invert Extruder 2 direction:";
            this.marlinComboBoxINVERT_E2_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_E2_DIR.Feature = "INVERT_E2_DIR";
            this.marlinComboBoxINVERT_E2_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_E2_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_E2_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_E2_DIR.Location = new System.Drawing.Point(3, 179);
            this.marlinComboBoxINVERT_E2_DIR.Name = "marlinComboBoxINVERT_E2_DIR";
            this.marlinComboBoxINVERT_E2_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_E2_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_E2_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_E2_DIR.TabIndex = 10;
            // 
            // marlinComboBoxINVERT_E1_DIR
            // 
            this.marlinComboBoxINVERT_E1_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_E1_DIR.ControlText = "Invert Extruder 1 direction:";
            this.marlinComboBoxINVERT_E1_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_E1_DIR.Feature = "INVERT_E1_DIR";
            this.marlinComboBoxINVERT_E1_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_E1_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_E1_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_E1_DIR.Location = new System.Drawing.Point(1, 147);
            this.marlinComboBoxINVERT_E1_DIR.Name = "marlinComboBoxINVERT_E1_DIR";
            this.marlinComboBoxINVERT_E1_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_E1_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_E1_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_E1_DIR.TabIndex = 9;
            // 
            // marlinComboBoxINVERT_E0_DIR
            // 
            this.marlinComboBoxINVERT_E0_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_E0_DIR.ControlText = "Invert Extruder 0 direction:";
            this.marlinComboBoxINVERT_E0_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_E0_DIR.Feature = "INVERT_E0_DIR";
            this.marlinComboBoxINVERT_E0_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_E0_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_E0_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_E0_DIR.Location = new System.Drawing.Point(3, 115);
            this.marlinComboBoxINVERT_E0_DIR.Name = "marlinComboBoxINVERT_E0_DIR";
            this.marlinComboBoxINVERT_E0_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_E0_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_E0_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_E0_DIR.TabIndex = 8;
            // 
            // marlinComboBoxINVERT_Z_DIR
            // 
            this.marlinComboBoxINVERT_Z_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_Z_DIR.ControlText = "Invert Z direction:";
            this.marlinComboBoxINVERT_Z_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_Z_DIR.Feature = "INVERT_Z_DIR";
            this.marlinComboBoxINVERT_Z_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_Z_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_Z_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_Z_DIR.Location = new System.Drawing.Point(3, 83);
            this.marlinComboBoxINVERT_Z_DIR.Name = "marlinComboBoxINVERT_Z_DIR";
            this.marlinComboBoxINVERT_Z_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_Z_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_Z_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_Z_DIR.TabIndex = 7;
            // 
            // marlinComboBoxINVERT_Y_DIR
            // 
            this.marlinComboBoxINVERT_Y_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_Y_DIR.ControlText = "Invert Y direction:";
            this.marlinComboBoxINVERT_Y_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_Y_DIR.Feature = "INVERT_Y_DIR";
            this.marlinComboBoxINVERT_Y_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_Y_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_Y_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_Y_DIR.Location = new System.Drawing.Point(3, 51);
            this.marlinComboBoxINVERT_Y_DIR.Name = "marlinComboBoxINVERT_Y_DIR";
            this.marlinComboBoxINVERT_Y_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_Y_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_Y_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_Y_DIR.TabIndex = 6;
            // 
            // marlinComboBoxINVERT_X_DIR
            // 
            this.marlinComboBoxINVERT_X_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxINVERT_X_DIR.ControlText = "Invert X direction:";
            this.marlinComboBoxINVERT_X_DIR.currentFirmwareHelper = null;
            this.marlinComboBoxINVERT_X_DIR.Feature = "INVERT_X_DIR";
            this.marlinComboBoxINVERT_X_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-direction";
            this.marlinComboBoxINVERT_X_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxINVERT_X_DIR.IsTrueFalse = true;
            this.marlinComboBoxINVERT_X_DIR.Location = new System.Drawing.Point(3, 19);
            this.marlinComboBoxINVERT_X_DIR.Name = "marlinComboBoxINVERT_X_DIR";
            this.marlinComboBoxINVERT_X_DIR.NewFirmwareHelper = null;
            this.marlinComboBoxINVERT_X_DIR.Size = new System.Drawing.Size(205, 26);
            this.marlinComboBoxINVERT_X_DIR.SpliterDistance = 113;
            this.marlinComboBoxINVERT_X_DIR.TabIndex = 5;
            // 
            // grpBxDisableSteppers
            // 
            this.grpBxDisableSteppers.Controls.Add(this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER);
            this.grpBxDisableSteppers.Controls.Add(this.marlinComboBoxDISABLE_E);
            this.grpBxDisableSteppers.Controls.Add(this.marlinComboBoxDISABLE_Z);
            this.grpBxDisableSteppers.Controls.Add(this.marlinComboBoxDISABLE_Y);
            this.grpBxDisableSteppers.Controls.Add(this.marlinComboBoxDISABLE_X);
            this.grpBxDisableSteppers.Location = new System.Drawing.Point(8, 171);
            this.grpBxDisableSteppers.Name = "grpBxDisableSteppers";
            this.grpBxDisableSteppers.Size = new System.Drawing.Size(226, 178);
            this.grpBxDisableSteppers.TabIndex = 1;
            this.grpBxDisableSteppers.TabStop = false;
            this.grpBxDisableSteppers.Text = "Disable steppers when not used";
            // 
            // marlinComboBoxDISABLE_INACTIVE_EXTRUDER
            // 
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.ControlText = "Disable Inactive Extruder:";
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.currentFirmwareHelper = null;
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.Feature = "DISABLE_INACTIVE_EXTRUDER";
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-disable";
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.IsTrueFalse = true;
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.Location = new System.Drawing.Point(0, 147);
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.Name = "marlinComboBoxDISABLE_INACTIVE_EXTRUDER";
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.NewFirmwareHelper = null;
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.Size = new System.Drawing.Size(220, 26);
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.SpliterDistance = 128;
            this.marlinComboBoxDISABLE_INACTIVE_EXTRUDER.TabIndex = 4;
            // 
            // marlinComboBoxDISABLE_E
            // 
            this.marlinComboBoxDISABLE_E.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxDISABLE_E.ControlText = "Disable E:";
            this.marlinComboBoxDISABLE_E.currentFirmwareHelper = null;
            this.marlinComboBoxDISABLE_E.Feature = "DISABLE_E";
            this.marlinComboBoxDISABLE_E.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-disable";
            this.marlinComboBoxDISABLE_E.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxDISABLE_E.IsTrueFalse = true;
            this.marlinComboBoxDISABLE_E.Location = new System.Drawing.Point(0, 115);
            this.marlinComboBoxDISABLE_E.Name = "marlinComboBoxDISABLE_E";
            this.marlinComboBoxDISABLE_E.NewFirmwareHelper = null;
            this.marlinComboBoxDISABLE_E.Size = new System.Drawing.Size(220, 26);
            this.marlinComboBoxDISABLE_E.SpliterDistance = 128;
            this.marlinComboBoxDISABLE_E.TabIndex = 3;
            // 
            // marlinComboBoxDISABLE_Z
            // 
            this.marlinComboBoxDISABLE_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxDISABLE_Z.ControlText = "Disable Z:";
            this.marlinComboBoxDISABLE_Z.currentFirmwareHelper = null;
            this.marlinComboBoxDISABLE_Z.Feature = "DISABLE_Z";
            this.marlinComboBoxDISABLE_Z.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-disable";
            this.marlinComboBoxDISABLE_Z.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxDISABLE_Z.IsTrueFalse = true;
            this.marlinComboBoxDISABLE_Z.Location = new System.Drawing.Point(0, 83);
            this.marlinComboBoxDISABLE_Z.Name = "marlinComboBoxDISABLE_Z";
            this.marlinComboBoxDISABLE_Z.NewFirmwareHelper = null;
            this.marlinComboBoxDISABLE_Z.Size = new System.Drawing.Size(220, 26);
            this.marlinComboBoxDISABLE_Z.SpliterDistance = 128;
            this.marlinComboBoxDISABLE_Z.TabIndex = 2;
            // 
            // marlinComboBoxDISABLE_Y
            // 
            this.marlinComboBoxDISABLE_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxDISABLE_Y.ControlText = "Disable Y:";
            this.marlinComboBoxDISABLE_Y.currentFirmwareHelper = null;
            this.marlinComboBoxDISABLE_Y.Feature = "DISABLE_Y";
            this.marlinComboBoxDISABLE_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-disable";
            this.marlinComboBoxDISABLE_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxDISABLE_Y.IsTrueFalse = true;
            this.marlinComboBoxDISABLE_Y.Location = new System.Drawing.Point(0, 51);
            this.marlinComboBoxDISABLE_Y.Name = "marlinComboBoxDISABLE_Y";
            this.marlinComboBoxDISABLE_Y.NewFirmwareHelper = null;
            this.marlinComboBoxDISABLE_Y.Size = new System.Drawing.Size(220, 26);
            this.marlinComboBoxDISABLE_Y.SpliterDistance = 128;
            this.marlinComboBoxDISABLE_Y.TabIndex = 1;
            // 
            // marlinComboBoxDISABLE_X
            // 
            this.marlinComboBoxDISABLE_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBoxDISABLE_X.ControlText = "Disable X:";
            this.marlinComboBoxDISABLE_X.currentFirmwareHelper = null;
            this.marlinComboBoxDISABLE_X.Feature = "DISABLE_X";
            this.marlinComboBoxDISABLE_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-disable";
            this.marlinComboBoxDISABLE_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxDISABLE_X.IsTrueFalse = true;
            this.marlinComboBoxDISABLE_X.Location = new System.Drawing.Point(0, 19);
            this.marlinComboBoxDISABLE_X.Name = "marlinComboBoxDISABLE_X";
            this.marlinComboBoxDISABLE_X.NewFirmwareHelper = null;
            this.marlinComboBoxDISABLE_X.Size = new System.Drawing.Size(220, 26);
            this.marlinComboBoxDISABLE_X.SpliterDistance = 128;
            this.marlinComboBoxDISABLE_X.TabIndex = 0;
            // 
            // grpBxStepperEnablePin
            // 
            this.grpBxStepperEnablePin.Controls.Add(this.marlinValueE_ENABLE_ON);
            this.grpBxStepperEnablePin.Controls.Add(this.marlinValueZ_ENABLE_ON);
            this.grpBxStepperEnablePin.Controls.Add(this.marlinValueY_ENABLE_ON);
            this.grpBxStepperEnablePin.Controls.Add(this.marlinValueX_ENABLE_ON);
            this.grpBxStepperEnablePin.Location = new System.Drawing.Point(8, 22);
            this.grpBxStepperEnablePin.Name = "grpBxStepperEnablePin";
            this.grpBxStepperEnablePin.Size = new System.Drawing.Size(226, 143);
            this.grpBxStepperEnablePin.TabIndex = 0;
            this.grpBxStepperEnablePin.TabStop = false;
            this.grpBxStepperEnablePin.Text = "Stepper Enable Pins (0=Low 1=High)";
            // 
            // marlinValueE_ENABLE_ON
            // 
            this.marlinValueE_ENABLE_ON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueE_ENABLE_ON.ControlText = "E enable pin:";
            this.marlinValueE_ENABLE_ON.currentFirmwareHelper = null;
            this.marlinValueE_ENABLE_ON.Feature = "E_ENABLE_ON";
            this.marlinValueE_ENABLE_ON.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-enable";
            this.marlinValueE_ENABLE_ON.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueE_ENABLE_ON.Location = new System.Drawing.Point(43, 113);
            this.marlinValueE_ENABLE_ON.Name = "marlinValueE_ENABLE_ON";
            this.marlinValueE_ENABLE_ON.NewFirmwareHelper = null;
            this.marlinValueE_ENABLE_ON.Size = new System.Drawing.Size(177, 26);
            this.marlinValueE_ENABLE_ON.SpliterDistance = 70;
            this.marlinValueE_ENABLE_ON.TabIndex = 3;
            // 
            // marlinValueZ_ENABLE_ON
            // 
            this.marlinValueZ_ENABLE_ON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueZ_ENABLE_ON.ControlText = "Z enable pin:";
            this.marlinValueZ_ENABLE_ON.currentFirmwareHelper = null;
            this.marlinValueZ_ENABLE_ON.Feature = "Z_ENABLE_ON";
            this.marlinValueZ_ENABLE_ON.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-enable";
            this.marlinValueZ_ENABLE_ON.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueZ_ENABLE_ON.Location = new System.Drawing.Point(43, 81);
            this.marlinValueZ_ENABLE_ON.Name = "marlinValueZ_ENABLE_ON";
            this.marlinValueZ_ENABLE_ON.NewFirmwareHelper = null;
            this.marlinValueZ_ENABLE_ON.Size = new System.Drawing.Size(177, 26);
            this.marlinValueZ_ENABLE_ON.SpliterDistance = 70;
            this.marlinValueZ_ENABLE_ON.TabIndex = 2;
            // 
            // marlinValueY_ENABLE_ON
            // 
            this.marlinValueY_ENABLE_ON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueY_ENABLE_ON.ControlText = "Y enable pin:";
            this.marlinValueY_ENABLE_ON.currentFirmwareHelper = null;
            this.marlinValueY_ENABLE_ON.Feature = "Y_ENABLE_ON";
            this.marlinValueY_ENABLE_ON.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-enable";
            this.marlinValueY_ENABLE_ON.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueY_ENABLE_ON.Location = new System.Drawing.Point(43, 49);
            this.marlinValueY_ENABLE_ON.Name = "marlinValueY_ENABLE_ON";
            this.marlinValueY_ENABLE_ON.NewFirmwareHelper = null;
            this.marlinValueY_ENABLE_ON.Size = new System.Drawing.Size(177, 26);
            this.marlinValueY_ENABLE_ON.SpliterDistance = 70;
            this.marlinValueY_ENABLE_ON.TabIndex = 1;
            // 
            // marlinValueX_ENABLE_ON
            // 
            this.marlinValueX_ENABLE_ON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueX_ENABLE_ON.ControlText = "X enable pin:";
            this.marlinValueX_ENABLE_ON.currentFirmwareHelper = null;
            this.marlinValueX_ENABLE_ON.Feature = "X_ENABLE_ON";
            this.marlinValueX_ENABLE_ON.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#motor-enable";
            this.marlinValueX_ENABLE_ON.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueX_ENABLE_ON.Location = new System.Drawing.Point(43, 17);
            this.marlinValueX_ENABLE_ON.Name = "marlinValueX_ENABLE_ON";
            this.marlinValueX_ENABLE_ON.NewFirmwareHelper = null;
            this.marlinValueX_ENABLE_ON.Size = new System.Drawing.Size(177, 26);
            this.marlinValueX_ENABLE_ON.SpliterDistance = 70;
            this.marlinValueX_ENABLE_ON.TabIndex = 0;
            // 
            // tabPageHoming
            // 
            this.tabPageHoming.Controls.Add(this.grpBxTravelLimits);
            this.tabPageHoming.Controls.Add(this.groupBoxEndStopDirection);
            this.tabPageHoming.Location = new System.Drawing.Point(4, 76);
            this.tabPageHoming.Name = "tabPageHoming";
            this.tabPageHoming.Size = new System.Drawing.Size(622, 585);
            this.tabPageHoming.TabIndex = 16;
            this.tabPageHoming.Text = "Homing";
            this.tabPageHoming.UseVisualStyleBackColor = true;
            // 
            // grpBxTravelLimits
            // 
            this.grpBxTravelLimits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxTravelLimits.Controls.Add(this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS);
            this.grpBxTravelLimits.Controls.Add(this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS);
            this.grpBxTravelLimits.Controls.Add(this.marlinUpDnZ_MAX_POS);
            this.grpBxTravelLimits.Controls.Add(this.marlinUpDnY_MAX_POS);
            this.grpBxTravelLimits.Controls.Add(this.marlinUpDnX_MAX_POS);
            this.grpBxTravelLimits.Controls.Add(this.marlinUpDnZ_MIN_POS);
            this.grpBxTravelLimits.Controls.Add(this.marlinUpDnY_MIN_POS);
            this.grpBxTravelLimits.Controls.Add(this.marlinUpDnX_MIN_POS);
            this.grpBxTravelLimits.Location = new System.Drawing.Point(393, 147);
            this.grpBxTravelLimits.Name = "grpBxTravelLimits";
            this.grpBxTravelLimits.Size = new System.Drawing.Size(217, 287);
            this.grpBxTravelLimits.TabIndex = 1;
            this.grpBxTravelLimits.TabStop = false;
            this.grpBxTravelLimits.Text = "Travel limits after homing (units are in mm)";
            // 
            // marlinCheckBoxMAX_SOFTWARE_ENDSTOPS
            // 
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.ControlText = "Max Software Endstop";
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.currentFirmwareHelper = null;
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.Feature = "MAX_SOFTWARE_ENDSTOPS";
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#software-endstops";
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.Location = new System.Drawing.Point(17, 259);
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.Name = "marlinCheckBoxMAX_SOFTWARE_ENDSTOPS";
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.NewFirmwareHelper = null;
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.Size = new System.Drawing.Size(194, 21);
            this.marlinCheckBoxMAX_SOFTWARE_ENDSTOPS.TabIndex = 7;
            // 
            // marlinCheckBoxMIN_SOFTWARE_ENDSTOPS
            // 
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.ControlText = "Min Software Endstop";
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.currentFirmwareHelper = null;
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.Feature = "MIN_SOFTWARE_ENDSTOPS";
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#software-endstops";
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.Location = new System.Drawing.Point(17, 232);
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.Name = "marlinCheckBoxMIN_SOFTWARE_ENDSTOPS";
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.NewFirmwareHelper = null;
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.Size = new System.Drawing.Size(194, 21);
            this.marlinCheckBoxMIN_SOFTWARE_ENDSTOPS.TabIndex = 6;
            // 
            // marlinUpDnZ_MAX_POS
            // 
            this.marlinUpDnZ_MAX_POS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnZ_MAX_POS.ControlText = "Z-Max Position:";
            this.marlinUpDnZ_MAX_POS.currentFirmwareHelper = null;
            this.marlinUpDnZ_MAX_POS.Feature = "Z_MAX_POS";
            this.marlinUpDnZ_MAX_POS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#movement-bounds";
            this.marlinUpDnZ_MAX_POS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnZ_MAX_POS.Location = new System.Drawing.Point(37, 191);
            this.marlinUpDnZ_MAX_POS.Max = 400;
            this.marlinUpDnZ_MAX_POS.Min = -400;
            this.marlinUpDnZ_MAX_POS.Name = "marlinUpDnZ_MAX_POS";
            this.marlinUpDnZ_MAX_POS.NewFirmwareHelper = null;
            this.marlinUpDnZ_MAX_POS.Size = new System.Drawing.Size(174, 26);
            this.marlinUpDnZ_MAX_POS.SpliterDistance = 80;
            this.marlinUpDnZ_MAX_POS.TabIndex = 5;
            // 
            // marlinUpDnY_MAX_POS
            // 
            this.marlinUpDnY_MAX_POS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnY_MAX_POS.ControlText = "Y-Max Position:";
            this.marlinUpDnY_MAX_POS.currentFirmwareHelper = null;
            this.marlinUpDnY_MAX_POS.Feature = "Y_MAX_POS";
            this.marlinUpDnY_MAX_POS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#movement-bounds";
            this.marlinUpDnY_MAX_POS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnY_MAX_POS.Location = new System.Drawing.Point(37, 159);
            this.marlinUpDnY_MAX_POS.Max = 400;
            this.marlinUpDnY_MAX_POS.Min = -400;
            this.marlinUpDnY_MAX_POS.Name = "marlinUpDnY_MAX_POS";
            this.marlinUpDnY_MAX_POS.NewFirmwareHelper = null;
            this.marlinUpDnY_MAX_POS.Size = new System.Drawing.Size(174, 26);
            this.marlinUpDnY_MAX_POS.SpliterDistance = 80;
            this.marlinUpDnY_MAX_POS.TabIndex = 4;
            // 
            // marlinUpDnX_MAX_POS
            // 
            this.marlinUpDnX_MAX_POS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnX_MAX_POS.ControlText = "X-Max Position:";
            this.marlinUpDnX_MAX_POS.currentFirmwareHelper = null;
            this.marlinUpDnX_MAX_POS.Feature = "X_MAX_POS";
            this.marlinUpDnX_MAX_POS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#movement-bounds";
            this.marlinUpDnX_MAX_POS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnX_MAX_POS.Location = new System.Drawing.Point(37, 127);
            this.marlinUpDnX_MAX_POS.Max = 400;
            this.marlinUpDnX_MAX_POS.Min = -400;
            this.marlinUpDnX_MAX_POS.Name = "marlinUpDnX_MAX_POS";
            this.marlinUpDnX_MAX_POS.NewFirmwareHelper = null;
            this.marlinUpDnX_MAX_POS.Size = new System.Drawing.Size(174, 26);
            this.marlinUpDnX_MAX_POS.SpliterDistance = 80;
            this.marlinUpDnX_MAX_POS.TabIndex = 3;
            // 
            // marlinUpDnZ_MIN_POS
            // 
            this.marlinUpDnZ_MIN_POS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnZ_MIN_POS.ControlText = "Z-Min Position:";
            this.marlinUpDnZ_MIN_POS.currentFirmwareHelper = null;
            this.marlinUpDnZ_MIN_POS.Feature = "Z_MIN_POS";
            this.marlinUpDnZ_MIN_POS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#movement-bounds";
            this.marlinUpDnZ_MIN_POS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnZ_MIN_POS.Location = new System.Drawing.Point(37, 95);
            this.marlinUpDnZ_MIN_POS.Max = 400;
            this.marlinUpDnZ_MIN_POS.Min = -400;
            this.marlinUpDnZ_MIN_POS.Name = "marlinUpDnZ_MIN_POS";
            this.marlinUpDnZ_MIN_POS.NewFirmwareHelper = null;
            this.marlinUpDnZ_MIN_POS.Size = new System.Drawing.Size(174, 26);
            this.marlinUpDnZ_MIN_POS.SpliterDistance = 80;
            this.marlinUpDnZ_MIN_POS.TabIndex = 2;
            // 
            // marlinUpDnY_MIN_POS
            // 
            this.marlinUpDnY_MIN_POS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnY_MIN_POS.ControlText = "Y-Min Position:";
            this.marlinUpDnY_MIN_POS.currentFirmwareHelper = null;
            this.marlinUpDnY_MIN_POS.Feature = "Y_MIN_POS";
            this.marlinUpDnY_MIN_POS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#movement-bounds";
            this.marlinUpDnY_MIN_POS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnY_MIN_POS.Location = new System.Drawing.Point(37, 63);
            this.marlinUpDnY_MIN_POS.Max = 400;
            this.marlinUpDnY_MIN_POS.Min = -400;
            this.marlinUpDnY_MIN_POS.Name = "marlinUpDnY_MIN_POS";
            this.marlinUpDnY_MIN_POS.NewFirmwareHelper = null;
            this.marlinUpDnY_MIN_POS.Size = new System.Drawing.Size(174, 26);
            this.marlinUpDnY_MIN_POS.SpliterDistance = 80;
            this.marlinUpDnY_MIN_POS.TabIndex = 1;
            // 
            // marlinUpDnX_MIN_POS
            // 
            this.marlinUpDnX_MIN_POS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnX_MIN_POS.ControlText = "X-Min Position:";
            this.marlinUpDnX_MIN_POS.currentFirmwareHelper = null;
            this.marlinUpDnX_MIN_POS.Feature = "X_MIN_POS";
            this.marlinUpDnX_MIN_POS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#movement-bounds";
            this.marlinUpDnX_MIN_POS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnX_MIN_POS.Location = new System.Drawing.Point(37, 31);
            this.marlinUpDnX_MIN_POS.Max = 400;
            this.marlinUpDnX_MIN_POS.Min = -400;
            this.marlinUpDnX_MIN_POS.Name = "marlinUpDnX_MIN_POS";
            this.marlinUpDnX_MIN_POS.NewFirmwareHelper = null;
            this.marlinUpDnX_MIN_POS.Size = new System.Drawing.Size(174, 26);
            this.marlinUpDnX_MIN_POS.SpliterDistance = 80;
            this.marlinUpDnX_MIN_POS.TabIndex = 0;
            // 
            // groupBoxEndStopDirection
            // 
            this.groupBoxEndStopDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEndStopDirection.Controls.Add(this.marlinUpDnZ_HOME_DIR);
            this.groupBoxEndStopDirection.Controls.Add(this.marlinUpDnY_HOME_DIR);
            this.groupBoxEndStopDirection.Controls.Add(this.marlinUpDnX_HOME_DIR);
            this.groupBoxEndStopDirection.Location = new System.Drawing.Point(393, 14);
            this.groupBoxEndStopDirection.Name = "groupBoxEndStopDirection";
            this.groupBoxEndStopDirection.Size = new System.Drawing.Size(217, 127);
            this.groupBoxEndStopDirection.TabIndex = 0;
            this.groupBoxEndStopDirection.TabStop = false;
            this.groupBoxEndStopDirection.Text = "Direction of endstops when homing ( 1=MAX, -1=MIN)";
            // 
            // marlinUpDnZ_HOME_DIR
            // 
            this.marlinUpDnZ_HOME_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnZ_HOME_DIR.ControlText = "Z-home direction:";
            this.marlinUpDnZ_HOME_DIR.currentFirmwareHelper = null;
            this.marlinUpDnZ_HOME_DIR.Feature = "Z_HOME_DIR";
            this.marlinUpDnZ_HOME_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#homing-direction";
            this.marlinUpDnZ_HOME_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnZ_HOME_DIR.Location = new System.Drawing.Point(50, 95);
            this.marlinUpDnZ_HOME_DIR.Max = 1;
            this.marlinUpDnZ_HOME_DIR.Min = -1;
            this.marlinUpDnZ_HOME_DIR.Name = "marlinUpDnZ_HOME_DIR";
            this.marlinUpDnZ_HOME_DIR.NewFirmwareHelper = null;
            this.marlinUpDnZ_HOME_DIR.Size = new System.Drawing.Size(161, 26);
            this.marlinUpDnZ_HOME_DIR.SpliterDistance = 88;
            this.marlinUpDnZ_HOME_DIR.TabIndex = 2;
            // 
            // marlinUpDnY_HOME_DIR
            // 
            this.marlinUpDnY_HOME_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnY_HOME_DIR.ControlText = "Y-home direction:";
            this.marlinUpDnY_HOME_DIR.currentFirmwareHelper = null;
            this.marlinUpDnY_HOME_DIR.Feature = "Y_HOME_DIR";
            this.marlinUpDnY_HOME_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#homing-direction";
            this.marlinUpDnY_HOME_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnY_HOME_DIR.Location = new System.Drawing.Point(50, 63);
            this.marlinUpDnY_HOME_DIR.Max = 1;
            this.marlinUpDnY_HOME_DIR.Min = -1;
            this.marlinUpDnY_HOME_DIR.Name = "marlinUpDnY_HOME_DIR";
            this.marlinUpDnY_HOME_DIR.NewFirmwareHelper = null;
            this.marlinUpDnY_HOME_DIR.Size = new System.Drawing.Size(161, 26);
            this.marlinUpDnY_HOME_DIR.SpliterDistance = 88;
            this.marlinUpDnY_HOME_DIR.TabIndex = 1;
            // 
            // marlinUpDnX_HOME_DIR
            // 
            this.marlinUpDnX_HOME_DIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnX_HOME_DIR.ControlText = "X-home direction:";
            this.marlinUpDnX_HOME_DIR.currentFirmwareHelper = null;
            this.marlinUpDnX_HOME_DIR.Feature = "X_HOME_DIR";
            this.marlinUpDnX_HOME_DIR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#homing-direction";
            this.marlinUpDnX_HOME_DIR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnX_HOME_DIR.Location = new System.Drawing.Point(50, 31);
            this.marlinUpDnX_HOME_DIR.Max = 1;
            this.marlinUpDnX_HOME_DIR.Min = -1;
            this.marlinUpDnX_HOME_DIR.Name = "marlinUpDnX_HOME_DIR";
            this.marlinUpDnX_HOME_DIR.NewFirmwareHelper = null;
            this.marlinUpDnX_HOME_DIR.Size = new System.Drawing.Size(161, 26);
            this.marlinUpDnX_HOME_DIR.SpliterDistance = 88;
            this.marlinUpDnX_HOME_DIR.TabIndex = 0;
            // 
            // tabPageFilamentRunoutSensor
            // 
            this.tabPageFilamentRunoutSensor.Controls.Add(this.marlinValueFILAMENT_RUNOUT_SCRIPT);
            this.tabPageFilamentRunoutSensor.Controls.Add(this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT);
            this.tabPageFilamentRunoutSensor.Controls.Add(this.marlinComboBox1);
            this.tabPageFilamentRunoutSensor.Controls.Add(this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR);
            this.tabPageFilamentRunoutSensor.Location = new System.Drawing.Point(4, 76);
            this.tabPageFilamentRunoutSensor.Name = "tabPageFilamentRunoutSensor";
            this.tabPageFilamentRunoutSensor.Size = new System.Drawing.Size(622, 585);
            this.tabPageFilamentRunoutSensor.TabIndex = 17;
            this.tabPageFilamentRunoutSensor.Text = "Filement Runout Sensor";
            this.tabPageFilamentRunoutSensor.UseVisualStyleBackColor = true;
            // 
            // marlinValueFILAMENT_RUNOUT_SCRIPT
            // 
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.ControlText = "Filament RunOut Script";
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.currentFirmwareHelper = null;
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.Feature = "FILAMENT_RUNOUT_SCRIPT";
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.HelpUrl = null;
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.Location = new System.Drawing.Point(263, 98);
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.Name = "marlinValueFILAMENT_RUNOUT_SCRIPT";
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.NewFirmwareHelper = null;
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.Size = new System.Drawing.Size(347, 26);
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.SpliterDistance = 200;
            this.marlinValueFILAMENT_RUNOUT_SCRIPT.TabIndex = 3;
            // 
            // marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT
            // 
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.ControlText = "Use Filament sensor internal Pullup";
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.currentFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.Feature = "ENDSTOPPULLUP_FIL_RUNOUT";
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.HelpUrl = null;
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.Location = new System.Drawing.Point(263, 71);
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.Name = "marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT";
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.NewFirmwareHelper = null;
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT.TabIndex = 2;
            // 
            // marlinComboBox1
            // 
            this.marlinComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinComboBox1.ControlText = "Filament RunOut Sensor Inverting";
            this.marlinComboBox1.currentFirmwareHelper = null;
            this.marlinComboBox1.Feature = "FIL_RUNOUT_INVERTING";
            this.marlinComboBox1.HelpUrl = null;
            this.marlinComboBox1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBox1.IsTrueFalse = true;
            this.marlinComboBox1.Location = new System.Drawing.Point(263, 39);
            this.marlinComboBox1.Name = "marlinComboBox1";
            this.marlinComboBox1.NewFirmwareHelper = null;
            this.marlinComboBox1.Size = new System.Drawing.Size(347, 26);
            this.marlinComboBox1.SpliterDistance = 200;
            this.marlinComboBox1.TabIndex = 1;
            // 
            // marlinCheckBoxFILAMENT_RUNOUT_SENSOR
            // 
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.ControlText = "Filament Runout Sensor";
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.currentFirmwareHelper = null;
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.Feature = "FILAMENT_RUNOUT_SENSOR";
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.HelpUrl = null;
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.Location = new System.Drawing.Point(263, 12);
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.Name = "marlinCheckBoxFILAMENT_RUNOUT_SENSOR";
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.NewFirmwareHelper = null;
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxFILAMENT_RUNOUT_SENSOR.TabIndex = 0;
            // 
            // tabPageBedLeveling
            // 
            this.tabPageBedLeveling.Controls.Add(this.marlinEnableValueZ_PROBE_END_SCRIPT);
            this.tabPageBedLeveling.Controls.Add(this.grpBxMeshBedLevel);
            this.tabPageBedLeveling.Controls.Add(this.grpBxAutoBedLevelingUbl);
            this.tabPageBedLeveling.Controls.Add(this.grpBxGridPoints);
            this.tabPageBedLeveling.Controls.Add(this.grpBx3Points);
            this.tabPageBedLeveling.Controls.Add(this.grpBiLinear);
            this.tabPageBedLeveling.Controls.Add(this.grpAutoBedLevetType);
            this.tabPageBedLeveling.Controls.Add(this.grpBxProbeGrid);
            this.tabPageBedLeveling.Controls.Add(this.grpBxEnableFadeHeight);
            this.tabPageBedLeveling.Controls.Add(this.marlinCheckBoxDEBUG_LEVELING_FEATURE);
            this.tabPageBedLeveling.Location = new System.Drawing.Point(4, 76);
            this.tabPageBedLeveling.Name = "tabPageBedLeveling";
            this.tabPageBedLeveling.Size = new System.Drawing.Size(622, 585);
            this.tabPageBedLeveling.TabIndex = 18;
            this.tabPageBedLeveling.Text = "Bed Leveling";
            this.tabPageBedLeveling.UseVisualStyleBackColor = true;
            // 
            // marlinEnableValueZ_PROBE_END_SCRIPT
            // 
            this.marlinEnableValueZ_PROBE_END_SCRIPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueZ_PROBE_END_SCRIPT.ControlText = "G29 Endscript";
            this.marlinEnableValueZ_PROBE_END_SCRIPT.currentFirmwareHelper = null;
            this.marlinEnableValueZ_PROBE_END_SCRIPT.Feature = "Z_PROBE_END_SCRIPT";
            this.marlinEnableValueZ_PROBE_END_SCRIPT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#z-probe-end-script";
            this.marlinEnableValueZ_PROBE_END_SCRIPT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueZ_PROBE_END_SCRIPT.Location = new System.Drawing.Point(8, 519);
            this.marlinEnableValueZ_PROBE_END_SCRIPT.Name = "marlinEnableValueZ_PROBE_END_SCRIPT";
            this.marlinEnableValueZ_PROBE_END_SCRIPT.NewFirmwareHelper = null;
            this.marlinEnableValueZ_PROBE_END_SCRIPT.Size = new System.Drawing.Size(611, 26);
            this.marlinEnableValueZ_PROBE_END_SCRIPT.SpliterDistance = 91;
            this.marlinEnableValueZ_PROBE_END_SCRIPT.TabIndex = 16;
            // 
            // grpBxMeshBedLevel
            // 
            this.grpBxMeshBedLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxMeshBedLevel.Controls.Add(this.marlinCheckBoxMESH_G28_REST_ORIGIN);
            this.grpBxMeshBedLevel.Controls.Add(this.marlinUpDnMESH_INSET);
            this.grpBxMeshBedLevel.Location = new System.Drawing.Point(321, 381);
            this.grpBxMeshBedLevel.Name = "grpBxMeshBedLevel";
            this.grpBxMeshBedLevel.Size = new System.Drawing.Size(298, 72);
            this.grpBxMeshBedLevel.TabIndex = 14;
            this.grpBxMeshBedLevel.TabStop = false;
            this.grpBxMeshBedLevel.Text = "Mesh Bed Level";
            // 
            // marlinCheckBoxMESH_G28_REST_ORIGIN
            // 
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.ControlText = "G28 rest at Orgin";
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.currentFirmwareHelper = null;
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.Feature = "MESH_G28_REST_ORIGIN";
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#mesh-bed-leveling-optio" +
    "ns";
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.Location = new System.Drawing.Point(114, 45);
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.Name = "marlinCheckBoxMESH_G28_REST_ORIGIN";
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.NewFirmwareHelper = null;
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.Size = new System.Drawing.Size(177, 21);
            this.marlinCheckBoxMESH_G28_REST_ORIGIN.TabIndex = 1;
            // 
            // marlinUpDnMESH_INSET
            // 
            this.marlinUpDnMESH_INSET.ControlText = "Mesh Inset";
            this.marlinUpDnMESH_INSET.currentFirmwareHelper = null;
            this.marlinUpDnMESH_INSET.Feature = "MESH_INSET";
            this.marlinUpDnMESH_INSET.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#mesh-bed-leveling-optio" +
    "ns";
            this.marlinUpDnMESH_INSET.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnMESH_INSET.Location = new System.Drawing.Point(106, 13);
            this.marlinUpDnMESH_INSET.Max = 50;
            this.marlinUpDnMESH_INSET.Min = 0;
            this.marlinUpDnMESH_INSET.Name = "marlinUpDnMESH_INSET";
            this.marlinUpDnMESH_INSET.NewFirmwareHelper = null;
            this.marlinUpDnMESH_INSET.Size = new System.Drawing.Size(185, 26);
            this.marlinUpDnMESH_INSET.SpliterDistance = 85;
            this.marlinUpDnMESH_INSET.TabIndex = 0;
            // 
            // grpBxAutoBedLevelingUbl
            // 
            this.grpBxAutoBedLevelingUbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxAutoBedLevelingUbl.Controls.Add(this.marlinUpDnUBL_PROBE_PT_3_Y);
            this.grpBxAutoBedLevelingUbl.Controls.Add(this.marlinUpDnUBL_MESH_INSET);
            this.grpBxAutoBedLevelingUbl.Controls.Add(this.marlinUpDnUBL_PROBE_PT_3_X);
            this.grpBxAutoBedLevelingUbl.Controls.Add(this.marlinUpDnUBL_PROBE_PT_1_Y);
            this.grpBxAutoBedLevelingUbl.Controls.Add(this.marlinUpDnUBL_PROBE_PT_2_Y);
            this.grpBxAutoBedLevelingUbl.Controls.Add(this.marlinUpDnUBL_PROBE_PT_1_X);
            this.grpBxAutoBedLevelingUbl.Controls.Add(this.marlinUpDnUBL_PROBE_PT_2_X);
            this.grpBxAutoBedLevelingUbl.Location = new System.Drawing.Point(321, 218);
            this.grpBxAutoBedLevelingUbl.Name = "grpBxAutoBedLevelingUbl";
            this.grpBxAutoBedLevelingUbl.Size = new System.Drawing.Size(298, 157);
            this.grpBxAutoBedLevelingUbl.TabIndex = 13;
            this.grpBxAutoBedLevelingUbl.TabStop = false;
            this.grpBxAutoBedLevelingUbl.Text = "Auto Bed Leveling UBL";
            // 
            // marlinUpDnUBL_PROBE_PT_3_Y
            // 
            this.marlinUpDnUBL_PROBE_PT_3_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnUBL_PROBE_PT_3_Y.ControlText = "Point3 Y";
            this.marlinUpDnUBL_PROBE_PT_3_Y.currentFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_3_Y.Feature = "UBL_PROBE_PT_3_Y";
            this.marlinUpDnUBL_PROBE_PT_3_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#unified-bed-leveling-op" +
    "tions";
            this.marlinUpDnUBL_PROBE_PT_3_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnUBL_PROBE_PT_3_Y.Location = new System.Drawing.Point(152, 125);
            this.marlinUpDnUBL_PROBE_PT_3_Y.Max = 400;
            this.marlinUpDnUBL_PROBE_PT_3_Y.Min = 0;
            this.marlinUpDnUBL_PROBE_PT_3_Y.Name = "marlinUpDnUBL_PROBE_PT_3_Y";
            this.marlinUpDnUBL_PROBE_PT_3_Y.NewFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_3_Y.Size = new System.Drawing.Size(139, 26);
            this.marlinUpDnUBL_PROBE_PT_3_Y.SpliterDistance = 49;
            this.marlinUpDnUBL_PROBE_PT_3_Y.TabIndex = 11;
            // 
            // marlinUpDnUBL_MESH_INSET
            // 
            this.marlinUpDnUBL_MESH_INSET.ControlText = "UBL mesh Inset";
            this.marlinUpDnUBL_MESH_INSET.currentFirmwareHelper = null;
            this.marlinUpDnUBL_MESH_INSET.Feature = "UBL_MESH_INSET";
            this.marlinUpDnUBL_MESH_INSET.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#unified-bed-leveling-op" +
    "tions";
            this.marlinUpDnUBL_MESH_INSET.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnUBL_MESH_INSET.Location = new System.Drawing.Point(107, 19);
            this.marlinUpDnUBL_MESH_INSET.Max = 15;
            this.marlinUpDnUBL_MESH_INSET.Min = 1;
            this.marlinUpDnUBL_MESH_INSET.Name = "marlinUpDnUBL_MESH_INSET";
            this.marlinUpDnUBL_MESH_INSET.NewFirmwareHelper = null;
            this.marlinUpDnUBL_MESH_INSET.Size = new System.Drawing.Size(185, 26);
            this.marlinUpDnUBL_MESH_INSET.SpliterDistance = 85;
            this.marlinUpDnUBL_MESH_INSET.TabIndex = 0;
            // 
            // marlinUpDnUBL_PROBE_PT_3_X
            // 
            this.marlinUpDnUBL_PROBE_PT_3_X.ControlText = "Point3 X";
            this.marlinUpDnUBL_PROBE_PT_3_X.currentFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_3_X.Feature = "UBL_PROBE_PT_3_X";
            this.marlinUpDnUBL_PROBE_PT_3_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#unified-bed-leveling-op" +
    "tions";
            this.marlinUpDnUBL_PROBE_PT_3_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnUBL_PROBE_PT_3_X.Location = new System.Drawing.Point(6, 125);
            this.marlinUpDnUBL_PROBE_PT_3_X.Max = 400;
            this.marlinUpDnUBL_PROBE_PT_3_X.Min = 0;
            this.marlinUpDnUBL_PROBE_PT_3_X.Name = "marlinUpDnUBL_PROBE_PT_3_X";
            this.marlinUpDnUBL_PROBE_PT_3_X.NewFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_3_X.Size = new System.Drawing.Size(139, 26);
            this.marlinUpDnUBL_PROBE_PT_3_X.SpliterDistance = 49;
            this.marlinUpDnUBL_PROBE_PT_3_X.TabIndex = 10;
            // 
            // marlinUpDnUBL_PROBE_PT_1_Y
            // 
            this.marlinUpDnUBL_PROBE_PT_1_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnUBL_PROBE_PT_1_Y.ControlText = "Point1 Y";
            this.marlinUpDnUBL_PROBE_PT_1_Y.currentFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_1_Y.Feature = "UBL_PROBE_PT_1_Y";
            this.marlinUpDnUBL_PROBE_PT_1_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#unified-bed-leveling-op" +
    "tions";
            this.marlinUpDnUBL_PROBE_PT_1_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnUBL_PROBE_PT_1_Y.Location = new System.Drawing.Point(152, 61);
            this.marlinUpDnUBL_PROBE_PT_1_Y.Max = 400;
            this.marlinUpDnUBL_PROBE_PT_1_Y.Min = 0;
            this.marlinUpDnUBL_PROBE_PT_1_Y.Name = "marlinUpDnUBL_PROBE_PT_1_Y";
            this.marlinUpDnUBL_PROBE_PT_1_Y.NewFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_1_Y.Size = new System.Drawing.Size(139, 26);
            this.marlinUpDnUBL_PROBE_PT_1_Y.SpliterDistance = 49;
            this.marlinUpDnUBL_PROBE_PT_1_Y.TabIndex = 7;
            // 
            // marlinUpDnUBL_PROBE_PT_2_Y
            // 
            this.marlinUpDnUBL_PROBE_PT_2_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnUBL_PROBE_PT_2_Y.ControlText = "Point2 Y";
            this.marlinUpDnUBL_PROBE_PT_2_Y.currentFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_2_Y.Feature = "UBL_PROBE_PT_2_Y";
            this.marlinUpDnUBL_PROBE_PT_2_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#unified-bed-leveling-op" +
    "tions";
            this.marlinUpDnUBL_PROBE_PT_2_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnUBL_PROBE_PT_2_Y.Location = new System.Drawing.Point(152, 93);
            this.marlinUpDnUBL_PROBE_PT_2_Y.Max = 400;
            this.marlinUpDnUBL_PROBE_PT_2_Y.Min = 0;
            this.marlinUpDnUBL_PROBE_PT_2_Y.Name = "marlinUpDnUBL_PROBE_PT_2_Y";
            this.marlinUpDnUBL_PROBE_PT_2_Y.NewFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_2_Y.Size = new System.Drawing.Size(139, 26);
            this.marlinUpDnUBL_PROBE_PT_2_Y.SpliterDistance = 49;
            this.marlinUpDnUBL_PROBE_PT_2_Y.TabIndex = 9;
            // 
            // marlinUpDnUBL_PROBE_PT_1_X
            // 
            this.marlinUpDnUBL_PROBE_PT_1_X.ControlText = "Point1 X";
            this.marlinUpDnUBL_PROBE_PT_1_X.currentFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_1_X.Feature = "UBL_PROBE_PT_1_X";
            this.marlinUpDnUBL_PROBE_PT_1_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#unified-bed-leveling-op" +
    "tions";
            this.marlinUpDnUBL_PROBE_PT_1_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnUBL_PROBE_PT_1_X.Location = new System.Drawing.Point(6, 61);
            this.marlinUpDnUBL_PROBE_PT_1_X.Max = 400;
            this.marlinUpDnUBL_PROBE_PT_1_X.Min = 0;
            this.marlinUpDnUBL_PROBE_PT_1_X.Name = "marlinUpDnUBL_PROBE_PT_1_X";
            this.marlinUpDnUBL_PROBE_PT_1_X.NewFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_1_X.Size = new System.Drawing.Size(139, 26);
            this.marlinUpDnUBL_PROBE_PT_1_X.SpliterDistance = 49;
            this.marlinUpDnUBL_PROBE_PT_1_X.TabIndex = 6;
            // 
            // marlinUpDnUBL_PROBE_PT_2_X
            // 
            this.marlinUpDnUBL_PROBE_PT_2_X.ControlText = "Point2 X";
            this.marlinUpDnUBL_PROBE_PT_2_X.currentFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_2_X.Feature = "UBL_PROBE_PT_2_X";
            this.marlinUpDnUBL_PROBE_PT_2_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#unified-bed-leveling-op" +
    "tions";
            this.marlinUpDnUBL_PROBE_PT_2_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnUBL_PROBE_PT_2_X.Location = new System.Drawing.Point(6, 93);
            this.marlinUpDnUBL_PROBE_PT_2_X.Max = 400;
            this.marlinUpDnUBL_PROBE_PT_2_X.Min = 0;
            this.marlinUpDnUBL_PROBE_PT_2_X.Name = "marlinUpDnUBL_PROBE_PT_2_X";
            this.marlinUpDnUBL_PROBE_PT_2_X.NewFirmwareHelper = null;
            this.marlinUpDnUBL_PROBE_PT_2_X.Size = new System.Drawing.Size(139, 26);
            this.marlinUpDnUBL_PROBE_PT_2_X.SpliterDistance = 49;
            this.marlinUpDnUBL_PROBE_PT_2_X.TabIndex = 8;
            // 
            // grpBxGridPoints
            // 
            this.grpBxGridPoints.Controls.Add(this.marlinValueGRID_MAX_POINTS_X);
            this.grpBxGridPoints.Controls.Add(this.marlinValueGRID_MAX_POINTS_Y);
            this.grpBxGridPoints.Location = new System.Drawing.Point(8, 437);
            this.grpBxGridPoints.Name = "grpBxGridPoints";
            this.grpBxGridPoints.Size = new System.Drawing.Size(300, 81);
            this.grpBxGridPoints.TabIndex = 12;
            this.grpBxGridPoints.TabStop = false;
            this.grpBxGridPoints.Text = "Number of gridpoints";
            // 
            // marlinValueGRID_MAX_POINTS_X
            // 
            this.marlinValueGRID_MAX_POINTS_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueGRID_MAX_POINTS_X.ControlText = "Grid points X";
            this.marlinValueGRID_MAX_POINTS_X.currentFirmwareHelper = null;
            this.marlinValueGRID_MAX_POINTS_X.Feature = "GRID_MAX_POINTS_X";
            this.marlinValueGRID_MAX_POINTS_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinValueGRID_MAX_POINTS_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueGRID_MAX_POINTS_X.Location = new System.Drawing.Point(7, 19);
            this.marlinValueGRID_MAX_POINTS_X.Name = "marlinValueGRID_MAX_POINTS_X";
            this.marlinValueGRID_MAX_POINTS_X.NewFirmwareHelper = null;
            this.marlinValueGRID_MAX_POINTS_X.Size = new System.Drawing.Size(273, 21);
            this.marlinValueGRID_MAX_POINTS_X.SpliterDistance = 148;
            this.marlinValueGRID_MAX_POINTS_X.TabIndex = 9;
            // 
            // marlinValueGRID_MAX_POINTS_Y
            // 
            this.marlinValueGRID_MAX_POINTS_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueGRID_MAX_POINTS_Y.ControlText = "Grid points Y";
            this.marlinValueGRID_MAX_POINTS_Y.currentFirmwareHelper = null;
            this.marlinValueGRID_MAX_POINTS_Y.Feature = "GRID_MAX_POINTS_Y";
            this.marlinValueGRID_MAX_POINTS_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinValueGRID_MAX_POINTS_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueGRID_MAX_POINTS_Y.Location = new System.Drawing.Point(6, 46);
            this.marlinValueGRID_MAX_POINTS_Y.Name = "marlinValueGRID_MAX_POINTS_Y";
            this.marlinValueGRID_MAX_POINTS_Y.NewFirmwareHelper = null;
            this.marlinValueGRID_MAX_POINTS_Y.Size = new System.Drawing.Size(273, 21);
            this.marlinValueGRID_MAX_POINTS_Y.SpliterDistance = 148;
            this.marlinValueGRID_MAX_POINTS_Y.TabIndex = 10;
            // 
            // grpBx3Points
            // 
            this.grpBx3Points.Controls.Add(this.marlinUpDnABL_PROBE_PT_3_Y);
            this.grpBx3Points.Controls.Add(this.marlinUpDnABL_PROBE_PT_3_X);
            this.grpBx3Points.Controls.Add(this.marlinUpDnABL_PROBE_PT_2_Y);
            this.grpBx3Points.Controls.Add(this.marlinUpDnABL_PROBE_PT_2_X);
            this.grpBx3Points.Controls.Add(this.marlinUpDnABL_PROBE_PT_1_Y);
            this.grpBx3Points.Controls.Add(this.marlinUpDnABL_PROBE_PT_1_X);
            this.grpBx3Points.Location = new System.Drawing.Point(8, 250);
            this.grpBx3Points.Name = "grpBx3Points";
            this.grpBx3Points.Size = new System.Drawing.Size(300, 113);
            this.grpBx3Points.TabIndex = 11;
            this.grpBx3Points.TabStop = false;
            this.grpBx3Points.Text = "Auto Bed Level 3-point";
            // 
            // marlinUpDnABL_PROBE_PT_3_Y
            // 
            this.marlinUpDnABL_PROBE_PT_3_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnABL_PROBE_PT_3_Y.ControlText = "Point3 Y";
            this.marlinUpDnABL_PROBE_PT_3_Y.currentFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_3_Y.Feature = "ABL_PROBE_PT_3_Y";
            this.marlinUpDnABL_PROBE_PT_3_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#3-point-options";
            this.marlinUpDnABL_PROBE_PT_3_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnABL_PROBE_PT_3_Y.Location = new System.Drawing.Point(164, 81);
            this.marlinUpDnABL_PROBE_PT_3_Y.Max = 400;
            this.marlinUpDnABL_PROBE_PT_3_Y.Min = 0;
            this.marlinUpDnABL_PROBE_PT_3_Y.Name = "marlinUpDnABL_PROBE_PT_3_Y";
            this.marlinUpDnABL_PROBE_PT_3_Y.NewFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_3_Y.Size = new System.Drawing.Size(130, 26);
            this.marlinUpDnABL_PROBE_PT_3_Y.SpliterDistance = 46;
            this.marlinUpDnABL_PROBE_PT_3_Y.TabIndex = 5;
            // 
            // marlinUpDnABL_PROBE_PT_3_X
            // 
            this.marlinUpDnABL_PROBE_PT_3_X.ControlText = "Point3 X";
            this.marlinUpDnABL_PROBE_PT_3_X.currentFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_3_X.Feature = "ABL_PROBE_PT_3_X";
            this.marlinUpDnABL_PROBE_PT_3_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#3-point-options";
            this.marlinUpDnABL_PROBE_PT_3_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnABL_PROBE_PT_3_X.Location = new System.Drawing.Point(18, 84);
            this.marlinUpDnABL_PROBE_PT_3_X.Max = 400;
            this.marlinUpDnABL_PROBE_PT_3_X.Min = 0;
            this.marlinUpDnABL_PROBE_PT_3_X.Name = "marlinUpDnABL_PROBE_PT_3_X";
            this.marlinUpDnABL_PROBE_PT_3_X.NewFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_3_X.Size = new System.Drawing.Size(130, 26);
            this.marlinUpDnABL_PROBE_PT_3_X.SpliterDistance = 46;
            this.marlinUpDnABL_PROBE_PT_3_X.TabIndex = 4;
            // 
            // marlinUpDnABL_PROBE_PT_2_Y
            // 
            this.marlinUpDnABL_PROBE_PT_2_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnABL_PROBE_PT_2_Y.ControlText = "Point2 Y";
            this.marlinUpDnABL_PROBE_PT_2_Y.currentFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_2_Y.Feature = "ABL_PROBE_PT_2_Y";
            this.marlinUpDnABL_PROBE_PT_2_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#3-point-options";
            this.marlinUpDnABL_PROBE_PT_2_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnABL_PROBE_PT_2_Y.Location = new System.Drawing.Point(164, 49);
            this.marlinUpDnABL_PROBE_PT_2_Y.Max = 400;
            this.marlinUpDnABL_PROBE_PT_2_Y.Min = 0;
            this.marlinUpDnABL_PROBE_PT_2_Y.Name = "marlinUpDnABL_PROBE_PT_2_Y";
            this.marlinUpDnABL_PROBE_PT_2_Y.NewFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_2_Y.Size = new System.Drawing.Size(130, 26);
            this.marlinUpDnABL_PROBE_PT_2_Y.SpliterDistance = 46;
            this.marlinUpDnABL_PROBE_PT_2_Y.TabIndex = 3;
            // 
            // marlinUpDnABL_PROBE_PT_2_X
            // 
            this.marlinUpDnABL_PROBE_PT_2_X.ControlText = "Point2 X";
            this.marlinUpDnABL_PROBE_PT_2_X.currentFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_2_X.Feature = "ABL_PROBE_PT_2_X";
            this.marlinUpDnABL_PROBE_PT_2_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#3-point-options";
            this.marlinUpDnABL_PROBE_PT_2_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnABL_PROBE_PT_2_X.Location = new System.Drawing.Point(18, 52);
            this.marlinUpDnABL_PROBE_PT_2_X.Max = 400;
            this.marlinUpDnABL_PROBE_PT_2_X.Min = 0;
            this.marlinUpDnABL_PROBE_PT_2_X.Name = "marlinUpDnABL_PROBE_PT_2_X";
            this.marlinUpDnABL_PROBE_PT_2_X.NewFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_2_X.Size = new System.Drawing.Size(130, 26);
            this.marlinUpDnABL_PROBE_PT_2_X.SpliterDistance = 46;
            this.marlinUpDnABL_PROBE_PT_2_X.TabIndex = 2;
            // 
            // marlinUpDnABL_PROBE_PT_1_Y
            // 
            this.marlinUpDnABL_PROBE_PT_1_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnABL_PROBE_PT_1_Y.ControlText = "Point1 Y";
            this.marlinUpDnABL_PROBE_PT_1_Y.currentFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_1_Y.Feature = "ABL_PROBE_PT_1_Y";
            this.marlinUpDnABL_PROBE_PT_1_Y.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#3-point-options";
            this.marlinUpDnABL_PROBE_PT_1_Y.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnABL_PROBE_PT_1_Y.Location = new System.Drawing.Point(164, 17);
            this.marlinUpDnABL_PROBE_PT_1_Y.Max = 400;
            this.marlinUpDnABL_PROBE_PT_1_Y.Min = 0;
            this.marlinUpDnABL_PROBE_PT_1_Y.Name = "marlinUpDnABL_PROBE_PT_1_Y";
            this.marlinUpDnABL_PROBE_PT_1_Y.NewFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_1_Y.Size = new System.Drawing.Size(130, 26);
            this.marlinUpDnABL_PROBE_PT_1_Y.SpliterDistance = 46;
            this.marlinUpDnABL_PROBE_PT_1_Y.TabIndex = 1;
            // 
            // marlinUpDnABL_PROBE_PT_1_X
            // 
            this.marlinUpDnABL_PROBE_PT_1_X.ControlText = "Point1 X";
            this.marlinUpDnABL_PROBE_PT_1_X.currentFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_1_X.Feature = "ABL_PROBE_PT_1_X";
            this.marlinUpDnABL_PROBE_PT_1_X.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#3-point-options";
            this.marlinUpDnABL_PROBE_PT_1_X.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnABL_PROBE_PT_1_X.Location = new System.Drawing.Point(18, 20);
            this.marlinUpDnABL_PROBE_PT_1_X.Max = 400;
            this.marlinUpDnABL_PROBE_PT_1_X.Min = 0;
            this.marlinUpDnABL_PROBE_PT_1_X.Name = "marlinUpDnABL_PROBE_PT_1_X";
            this.marlinUpDnABL_PROBE_PT_1_X.NewFirmwareHelper = null;
            this.marlinUpDnABL_PROBE_PT_1_X.Size = new System.Drawing.Size(130, 26);
            this.marlinUpDnABL_PROBE_PT_1_X.SpliterDistance = 46;
            this.marlinUpDnABL_PROBE_PT_1_X.TabIndex = 0;
            // 
            // grpBiLinear
            // 
            this.grpBiLinear.Controls.Add(this.marlinUpDnBILINEAR_SUBDIVISIONS);
            this.grpBiLinear.Controls.Add(this.marlinCheckBoxABL_BILINEAR_SUBDIVISION);
            this.grpBiLinear.Location = new System.Drawing.Point(8, 172);
            this.grpBiLinear.Name = "grpBiLinear";
            this.grpBiLinear.Size = new System.Drawing.Size(301, 73);
            this.grpBiLinear.TabIndex = 10;
            this.grpBiLinear.TabStop = false;
            this.grpBiLinear.Text = "Bi-Linear SubDivision";
            // 
            // marlinUpDnBILINEAR_SUBDIVISIONS
            // 
            this.marlinUpDnBILINEAR_SUBDIVISIONS.ControlText = "Number of subdivisions between probe points";
            this.marlinUpDnBILINEAR_SUBDIVISIONS.currentFirmwareHelper = null;
            this.marlinUpDnBILINEAR_SUBDIVISIONS.Feature = "BILINEAR_SUBDIVISIONS";
            this.marlinUpDnBILINEAR_SUBDIVISIONS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bilinear-options";
            this.marlinUpDnBILINEAR_SUBDIVISIONS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnBILINEAR_SUBDIVISIONS.Location = new System.Drawing.Point(6, 46);
            this.marlinUpDnBILINEAR_SUBDIVISIONS.Max = 10;
            this.marlinUpDnBILINEAR_SUBDIVISIONS.Min = 1;
            this.marlinUpDnBILINEAR_SUBDIVISIONS.Name = "marlinUpDnBILINEAR_SUBDIVISIONS";
            this.marlinUpDnBILINEAR_SUBDIVISIONS.NewFirmwareHelper = null;
            this.marlinUpDnBILINEAR_SUBDIVISIONS.Size = new System.Drawing.Size(289, 26);
            this.marlinUpDnBILINEAR_SUBDIVISIONS.SpliterDistance = 220;
            this.marlinUpDnBILINEAR_SUBDIVISIONS.TabIndex = 1;
            // 
            // marlinCheckBoxABL_BILINEAR_SUBDIVISION
            // 
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.ControlText = "Auto Bed Level SubDivision";
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.currentFirmwareHelper = null;
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.Feature = "ABL_BILINEAR_SUBDIVISION";
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bilinear-options";
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.Location = new System.Drawing.Point(10, 19);
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.Name = "marlinCheckBoxABL_BILINEAR_SUBDIVISION";
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.NewFirmwareHelper = null;
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.Size = new System.Drawing.Size(285, 21);
            this.marlinCheckBoxABL_BILINEAR_SUBDIVISION.TabIndex = 0;
            // 
            // grpAutoBedLevetType
            // 
            this.grpAutoBedLevetType.Controls.Add(this.marlinCheckBoxAUTO_BED_LEVELING_3POINT);
            this.grpAutoBedLevetType.Controls.Add(this.marlinCheckBoxMESH_BED_LEVELING);
            this.grpAutoBedLevetType.Controls.Add(this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR);
            this.grpAutoBedLevetType.Controls.Add(this.marlinCheckBoxAUTO_BED_LEVELING_UBL);
            this.grpAutoBedLevetType.Controls.Add(this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR);
            this.grpAutoBedLevetType.Location = new System.Drawing.Point(8, 16);
            this.grpAutoBedLevetType.Name = "grpAutoBedLevetType";
            this.grpAutoBedLevetType.Size = new System.Drawing.Size(301, 150);
            this.grpAutoBedLevetType.TabIndex = 9;
            this.grpAutoBedLevetType.TabStop = false;
            this.grpAutoBedLevetType.Text = "Auto Bed Leveling Method";
            // 
            // marlinCheckBoxAUTO_BED_LEVELING_3POINT
            // 
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.ControlText = "Auto Bed Level 3-point";
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.currentFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.Feature = "AUTO_BED_LEVELING_3POINT";
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling-style";
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.Location = new System.Drawing.Point(101, 12);
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.Name = "marlinCheckBoxAUTO_BED_LEVELING_3POINT";
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.NewFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.Size = new System.Drawing.Size(194, 21);
            this.marlinCheckBoxAUTO_BED_LEVELING_3POINT.TabIndex = 0;
            // 
            // marlinCheckBoxMESH_BED_LEVELING
            // 
            this.marlinCheckBoxMESH_BED_LEVELING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxMESH_BED_LEVELING.ControlText = "Mesh Bed Leveling (Manually)";
            this.marlinCheckBoxMESH_BED_LEVELING.currentFirmwareHelper = null;
            this.marlinCheckBoxMESH_BED_LEVELING.Feature = "MESH_BED_LEVELING";
            this.marlinCheckBoxMESH_BED_LEVELING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling-style";
            this.marlinCheckBoxMESH_BED_LEVELING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxMESH_BED_LEVELING.Location = new System.Drawing.Point(101, 120);
            this.marlinCheckBoxMESH_BED_LEVELING.Name = "marlinCheckBoxMESH_BED_LEVELING";
            this.marlinCheckBoxMESH_BED_LEVELING.NewFirmwareHelper = null;
            this.marlinCheckBoxMESH_BED_LEVELING.Size = new System.Drawing.Size(194, 21);
            this.marlinCheckBoxMESH_BED_LEVELING.TabIndex = 4;
            // 
            // marlinCheckBoxAUTO_BED_LEVELING_LINEAR
            // 
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.ControlText = "Auto Bed Leveling Linear";
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.currentFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.Feature = "AUTO_BED_LEVELING_LINEAR";
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling-style";
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.Location = new System.Drawing.Point(101, 39);
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.Name = "marlinCheckBoxAUTO_BED_LEVELING_LINEAR";
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.NewFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.Size = new System.Drawing.Size(194, 21);
            this.marlinCheckBoxAUTO_BED_LEVELING_LINEAR.TabIndex = 1;
            // 
            // marlinCheckBoxAUTO_BED_LEVELING_UBL
            // 
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.ControlText = "Auto Bed Leveling UBL";
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.currentFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.Feature = "AUTO_BED_LEVELING_UBL";
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling-style";
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.Location = new System.Drawing.Point(101, 93);
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.Name = "marlinCheckBoxAUTO_BED_LEVELING_UBL";
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.NewFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.Size = new System.Drawing.Size(194, 21);
            this.marlinCheckBoxAUTO_BED_LEVELING_UBL.TabIndex = 3;
            // 
            // marlinCheckBoxAUTO_BED_LEVELING_BILINEAR
            // 
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.ControlText = "Auto Bed Leveling Bi-Linear";
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.currentFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.Feature = "AUTO_BED_LEVELING_BILINEAR";
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling-style";
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.Location = new System.Drawing.Point(101, 66);
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.Name = "marlinCheckBoxAUTO_BED_LEVELING_BILINEAR";
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.NewFirmwareHelper = null;
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.Size = new System.Drawing.Size(194, 21);
            this.marlinCheckBoxAUTO_BED_LEVELING_BILINEAR.TabIndex = 2;
            // 
            // grpBxProbeGrid
            // 
            this.grpBxProbeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxProbeGrid.Controls.Add(this.marlinCheckBoxPROBE_Y_FIRST);
            this.grpBxProbeGrid.Controls.Add(this.marlinUpDnMIN_PROBE_EDGE);
            this.grpBxProbeGrid.Controls.Add(this.marlinUpDnBACK_PROBE_BED_POSITION);
            this.grpBxProbeGrid.Controls.Add(this.marlinUpDnFRONT_PROBE_BED_POSITION);
            this.grpBxProbeGrid.Controls.Add(this.marlinUpDnRIGHT_PROBE_BED_POSITION);
            this.grpBxProbeGrid.Controls.Add(this.marlinUpDnLEFT_PROBE_BED_POSITION);
            this.grpBxProbeGrid.Location = new System.Drawing.Point(321, 16);
            this.grpBxProbeGrid.Name = "grpBxProbeGrid";
            this.grpBxProbeGrid.Size = new System.Drawing.Size(298, 185);
            this.grpBxProbeGrid.TabIndex = 8;
            this.grpBxProbeGrid.TabStop = false;
            this.grpBxProbeGrid.Text = "ProbePoints for Linear and Bi-Linear";
            // 
            // marlinCheckBoxPROBE_Y_FIRST
            // 
            this.marlinCheckBoxPROBE_Y_FIRST.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPROBE_Y_FIRST.ControlText = "Probe Y First";
            this.marlinCheckBoxPROBE_Y_FIRST.currentFirmwareHelper = null;
            this.marlinCheckBoxPROBE_Y_FIRST.Feature = "PROBE_Y_FIRST";
            this.marlinCheckBoxPROBE_Y_FIRST.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinCheckBoxPROBE_Y_FIRST.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPROBE_Y_FIRST.Location = new System.Drawing.Point(13, 156);
            this.marlinCheckBoxPROBE_Y_FIRST.Name = "marlinCheckBoxPROBE_Y_FIRST";
            this.marlinCheckBoxPROBE_Y_FIRST.NewFirmwareHelper = null;
            this.marlinCheckBoxPROBE_Y_FIRST.Size = new System.Drawing.Size(273, 21);
            this.marlinCheckBoxPROBE_Y_FIRST.TabIndex = 16;
            // 
            // marlinUpDnMIN_PROBE_EDGE
            // 
            this.marlinUpDnMIN_PROBE_EDGE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnMIN_PROBE_EDGE.ControlText = "Min probe Edge";
            this.marlinUpDnMIN_PROBE_EDGE.currentFirmwareHelper = null;
            this.marlinUpDnMIN_PROBE_EDGE.Feature = "MIN_PROBE_EDGE";
            this.marlinUpDnMIN_PROBE_EDGE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinUpDnMIN_PROBE_EDGE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnMIN_PROBE_EDGE.Location = new System.Drawing.Point(13, 129);
            this.marlinUpDnMIN_PROBE_EDGE.Max = 50;
            this.marlinUpDnMIN_PROBE_EDGE.Min = 0;
            this.marlinUpDnMIN_PROBE_EDGE.Name = "marlinUpDnMIN_PROBE_EDGE";
            this.marlinUpDnMIN_PROBE_EDGE.NewFirmwareHelper = null;
            this.marlinUpDnMIN_PROBE_EDGE.Size = new System.Drawing.Size(273, 21);
            this.marlinUpDnMIN_PROBE_EDGE.SpliterDistance = 91;
            this.marlinUpDnMIN_PROBE_EDGE.TabIndex = 15;
            // 
            // marlinUpDnBACK_PROBE_BED_POSITION
            // 
            this.marlinUpDnBACK_PROBE_BED_POSITION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnBACK_PROBE_BED_POSITION.ControlText = "Back Probe Bed Position";
            this.marlinUpDnBACK_PROBE_BED_POSITION.currentFirmwareHelper = null;
            this.marlinUpDnBACK_PROBE_BED_POSITION.Feature = "BACK_PROBE_BED_POSITION";
            this.marlinUpDnBACK_PROBE_BED_POSITION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinUpDnBACK_PROBE_BED_POSITION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnBACK_PROBE_BED_POSITION.Location = new System.Drawing.Point(13, 100);
            this.marlinUpDnBACK_PROBE_BED_POSITION.Max = 400;
            this.marlinUpDnBACK_PROBE_BED_POSITION.Min = 0;
            this.marlinUpDnBACK_PROBE_BED_POSITION.Name = "marlinUpDnBACK_PROBE_BED_POSITION";
            this.marlinUpDnBACK_PROBE_BED_POSITION.NewFirmwareHelper = null;
            this.marlinUpDnBACK_PROBE_BED_POSITION.Size = new System.Drawing.Size(273, 21);
            this.marlinUpDnBACK_PROBE_BED_POSITION.SpliterDistance = 153;
            this.marlinUpDnBACK_PROBE_BED_POSITION.TabIndex = 14;
            // 
            // marlinUpDnFRONT_PROBE_BED_POSITION
            // 
            this.marlinUpDnFRONT_PROBE_BED_POSITION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnFRONT_PROBE_BED_POSITION.ControlText = "Front Probe Bed Position";
            this.marlinUpDnFRONT_PROBE_BED_POSITION.currentFirmwareHelper = null;
            this.marlinUpDnFRONT_PROBE_BED_POSITION.Feature = "FRONT_PROBE_BED_POSITION";
            this.marlinUpDnFRONT_PROBE_BED_POSITION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinUpDnFRONT_PROBE_BED_POSITION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnFRONT_PROBE_BED_POSITION.Location = new System.Drawing.Point(13, 73);
            this.marlinUpDnFRONT_PROBE_BED_POSITION.Max = 400;
            this.marlinUpDnFRONT_PROBE_BED_POSITION.Min = 0;
            this.marlinUpDnFRONT_PROBE_BED_POSITION.Name = "marlinUpDnFRONT_PROBE_BED_POSITION";
            this.marlinUpDnFRONT_PROBE_BED_POSITION.NewFirmwareHelper = null;
            this.marlinUpDnFRONT_PROBE_BED_POSITION.Size = new System.Drawing.Size(273, 21);
            this.marlinUpDnFRONT_PROBE_BED_POSITION.SpliterDistance = 153;
            this.marlinUpDnFRONT_PROBE_BED_POSITION.TabIndex = 13;
            // 
            // marlinUpDnRIGHT_PROBE_BED_POSITION
            // 
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.ControlText = "Right Probe Bed Position";
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.currentFirmwareHelper = null;
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.Feature = "RIGHT_PROBE_BED_POSITION";
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.Location = new System.Drawing.Point(13, 46);
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.Max = 400;
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.Min = 0;
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.Name = "marlinUpDnRIGHT_PROBE_BED_POSITION";
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.NewFirmwareHelper = null;
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.Size = new System.Drawing.Size(273, 21);
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.SpliterDistance = 153;
            this.marlinUpDnRIGHT_PROBE_BED_POSITION.TabIndex = 12;
            // 
            // marlinUpDnLEFT_PROBE_BED_POSITION
            // 
            this.marlinUpDnLEFT_PROBE_BED_POSITION.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnLEFT_PROBE_BED_POSITION.ControlText = "Left Probe Bed Position";
            this.marlinUpDnLEFT_PROBE_BED_POSITION.currentFirmwareHelper = null;
            this.marlinUpDnLEFT_PROBE_BED_POSITION.Feature = "LEFT_PROBE_BED_POSITION";
            this.marlinUpDnLEFT_PROBE_BED_POSITION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#bed-leveling";
            this.marlinUpDnLEFT_PROBE_BED_POSITION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnLEFT_PROBE_BED_POSITION.Location = new System.Drawing.Point(13, 19);
            this.marlinUpDnLEFT_PROBE_BED_POSITION.Max = 400;
            this.marlinUpDnLEFT_PROBE_BED_POSITION.Min = 0;
            this.marlinUpDnLEFT_PROBE_BED_POSITION.Name = "marlinUpDnLEFT_PROBE_BED_POSITION";
            this.marlinUpDnLEFT_PROBE_BED_POSITION.NewFirmwareHelper = null;
            this.marlinUpDnLEFT_PROBE_BED_POSITION.Size = new System.Drawing.Size(273, 21);
            this.marlinUpDnLEFT_PROBE_BED_POSITION.SpliterDistance = 153;
            this.marlinUpDnLEFT_PROBE_BED_POSITION.TabIndex = 11;
            // 
            // grpBxEnableFadeHeight
            // 
            this.grpBxEnableFadeHeight.Controls.Add(this.lblFadeHeight);
            this.grpBxEnableFadeHeight.Controls.Add(this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT);
            this.grpBxEnableFadeHeight.Location = new System.Drawing.Point(8, 366);
            this.grpBxEnableFadeHeight.Name = "grpBxEnableFadeHeight";
            this.grpBxEnableFadeHeight.Size = new System.Drawing.Size(301, 65);
            this.grpBxEnableFadeHeight.TabIndex = 7;
            this.grpBxEnableFadeHeight.TabStop = false;
            this.grpBxEnableFadeHeight.Text = "AutoBedLevel with Level Fade Height";
            // 
            // lblFadeHeight
            // 
            this.lblFadeHeight.AutoSize = true;
            this.lblFadeHeight.Location = new System.Drawing.Point(8, 20);
            this.lblFadeHeight.Name = "lblFadeHeight";
            this.lblFadeHeight.Size = new System.Drawing.Size(178, 13);
            this.lblFadeHeight.TabIndex = 7;
            this.lblFadeHeight.Text = "( Only for MBL, UBL and Bi-Linear  ) ";
            // 
            // marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT
            // 
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.ControlText = "Fade Leveling height";
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.currentFirmwareHelper = null;
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.Feature = "ENABLE_LEVELING_FADE_HEIGHT";
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#leveling-fade-height";
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.Location = new System.Drawing.Point(8, 36);
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.Name = "marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT";
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.NewFirmwareHelper = null;
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.Size = new System.Drawing.Size(287, 21);
            this.marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT.TabIndex = 6;
            // 
            // marlinCheckBoxDEBUG_LEVELING_FEATURE
            // 
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.ControlText = "Debug Bed Leveling Feature";
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.currentFirmwareHelper = null;
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.Feature = "DEBUG_LEVELING_FEATURE";
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#debug-leveling";
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.Location = new System.Drawing.Point(347, 459);
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.Name = "marlinCheckBoxDEBUG_LEVELING_FEATURE";
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.NewFirmwareHelper = null;
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.Size = new System.Drawing.Size(260, 21);
            this.marlinCheckBoxDEBUG_LEVELING_FEATURE.TabIndex = 5;
            // 
            // tabPageLcdBedLeveling
            // 
            this.tabPageLcdBedLeveling.Controls.Add(this.marlinUpDnLCD_PROBE_Z_RANGE);
            this.tabPageLcdBedLeveling.Controls.Add(this.marlinValueMBL_Z_STEP);
            this.tabPageLcdBedLeveling.Controls.Add(this.marlinCheckBoxLCD_BED_LEVELING);
            this.tabPageLcdBedLeveling.Location = new System.Drawing.Point(4, 76);
            this.tabPageLcdBedLeveling.Name = "tabPageLcdBedLeveling";
            this.tabPageLcdBedLeveling.Size = new System.Drawing.Size(622, 585);
            this.tabPageLcdBedLeveling.TabIndex = 19;
            this.tabPageLcdBedLeveling.Text = "LCD Bed Leveling";
            this.tabPageLcdBedLeveling.UseVisualStyleBackColor = true;
            // 
            // marlinUpDnLCD_PROBE_Z_RANGE
            // 
            this.marlinUpDnLCD_PROBE_Z_RANGE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnLCD_PROBE_Z_RANGE.ControlText = "LCD Z adjustment";
            this.marlinUpDnLCD_PROBE_Z_RANGE.currentFirmwareHelper = null;
            this.marlinUpDnLCD_PROBE_Z_RANGE.Feature = "LCD_PROBE_Z_RANGE";
            this.marlinUpDnLCD_PROBE_Z_RANGE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-bed-leveling";
            this.marlinUpDnLCD_PROBE_Z_RANGE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnLCD_PROBE_Z_RANGE.Location = new System.Drawing.Point(378, 71);
            this.marlinUpDnLCD_PROBE_Z_RANGE.Max = 20;
            this.marlinUpDnLCD_PROBE_Z_RANGE.Min = 0;
            this.marlinUpDnLCD_PROBE_Z_RANGE.Name = "marlinUpDnLCD_PROBE_Z_RANGE";
            this.marlinUpDnLCD_PROBE_Z_RANGE.NewFirmwareHelper = null;
            this.marlinUpDnLCD_PROBE_Z_RANGE.Size = new System.Drawing.Size(230, 26);
            this.marlinUpDnLCD_PROBE_Z_RANGE.SpliterDistance = 130;
            this.marlinUpDnLCD_PROBE_Z_RANGE.TabIndex = 18;
            // 
            // marlinValueMBL_Z_STEP
            // 
            this.marlinValueMBL_Z_STEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueMBL_Z_STEP.ControlText = "LCD MBL Z step";
            this.marlinValueMBL_Z_STEP.currentFirmwareHelper = null;
            this.marlinValueMBL_Z_STEP.Feature = "MBL_Z_STEP";
            this.marlinValueMBL_Z_STEP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-bed-leveling";
            this.marlinValueMBL_Z_STEP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueMBL_Z_STEP.Location = new System.Drawing.Point(378, 39);
            this.marlinValueMBL_Z_STEP.Name = "marlinValueMBL_Z_STEP";
            this.marlinValueMBL_Z_STEP.NewFirmwareHelper = null;
            this.marlinValueMBL_Z_STEP.Size = new System.Drawing.Size(230, 26);
            this.marlinValueMBL_Z_STEP.SpliterDistance = 130;
            this.marlinValueMBL_Z_STEP.TabIndex = 17;
            // 
            // marlinCheckBoxLCD_BED_LEVELING
            // 
            this.marlinCheckBoxLCD_BED_LEVELING.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxLCD_BED_LEVELING.ControlText = "LCD menu Bed Leveling";
            this.marlinCheckBoxLCD_BED_LEVELING.currentFirmwareHelper = null;
            this.marlinCheckBoxLCD_BED_LEVELING.Feature = "LCD_BED_LEVELING";
            this.marlinCheckBoxLCD_BED_LEVELING.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-bed-leveling";
            this.marlinCheckBoxLCD_BED_LEVELING.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxLCD_BED_LEVELING.Location = new System.Drawing.Point(378, 12);
            this.marlinCheckBoxLCD_BED_LEVELING.Name = "marlinCheckBoxLCD_BED_LEVELING";
            this.marlinCheckBoxLCD_BED_LEVELING.NewFirmwareHelper = null;
            this.marlinCheckBoxLCD_BED_LEVELING.Size = new System.Drawing.Size(230, 21);
            this.marlinCheckBoxLCD_BED_LEVELING.TabIndex = 16;
            // 
            // tabPageEEPROM
            // 
            this.tabPageEEPROM.Controls.Add(this.marlinCheckBoxM100_FREE_MEMORY_WATCHER);
            this.tabPageEEPROM.Controls.Add(this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL);
            this.tabPageEEPROM.Controls.Add(this.marlinCheckBoxHOST_KEEPALIVE_FEATURE);
            this.tabPageEEPROM.Controls.Add(this.marlinCheckBoxEEPROM_CHITCHAT);
            this.tabPageEEPROM.Controls.Add(this.marlinCheckBoxEEPROM_SETTINGS);
            this.tabPageEEPROM.Location = new System.Drawing.Point(4, 76);
            this.tabPageEEPROM.Name = "tabPageEEPROM";
            this.tabPageEEPROM.Size = new System.Drawing.Size(622, 585);
            this.tabPageEEPROM.TabIndex = 20;
            this.tabPageEEPROM.Text = "EEPROM";
            this.tabPageEEPROM.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxM100_FREE_MEMORY_WATCHER
            // 
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.ControlText = "M100 Free Memory Watcher";
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.currentFirmwareHelper = null;
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.Feature = "M100_FREE_MEMORY_WATCHER";
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#free-memory-watcher";
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.Location = new System.Drawing.Point(401, 128);
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.Name = "marlinCheckBoxM100_FREE_MEMORY_WATCHER";
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.NewFirmwareHelper = null;
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.Size = new System.Drawing.Size(209, 21);
            this.marlinCheckBoxM100_FREE_MEMORY_WATCHER.TabIndex = 4;
            // 
            // marlinUpDnDEFAULT_KEEPALIVE_INTERVAL
            // 
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.ControlText = "Default KeepAlive Interval";
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.currentFirmwareHelper = null;
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.Feature = "DEFAULT_KEEPALIVE_INTERVAL";
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#host-keepalive";
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.Location = new System.Drawing.Point(401, 96);
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.Max = 10;
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.Min = 1;
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.Name = "marlinUpDnDEFAULT_KEEPALIVE_INTERVAL";
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.NewFirmwareHelper = null;
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.Size = new System.Drawing.Size(209, 26);
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.SpliterDistance = 130;
            this.marlinUpDnDEFAULT_KEEPALIVE_INTERVAL.TabIndex = 3;
            // 
            // marlinCheckBoxHOST_KEEPALIVE_FEATURE
            // 
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.ControlText = "Host Keep Alive";
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.currentFirmwareHelper = null;
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.Feature = "HOST_KEEPALIVE_FEATURE";
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#host-keepalive";
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.Location = new System.Drawing.Point(401, 69);
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.Name = "marlinCheckBoxHOST_KEEPALIVE_FEATURE";
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.NewFirmwareHelper = null;
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.Size = new System.Drawing.Size(209, 21);
            this.marlinCheckBoxHOST_KEEPALIVE_FEATURE.TabIndex = 2;
            // 
            // marlinCheckBoxEEPROM_CHITCHAT
            // 
            this.marlinCheckBoxEEPROM_CHITCHAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxEEPROM_CHITCHAT.ControlText = "EEprom chitchat";
            this.marlinCheckBoxEEPROM_CHITCHAT.currentFirmwareHelper = null;
            this.marlinCheckBoxEEPROM_CHITCHAT.Feature = "EEPROM_CHITCHAT";
            this.marlinCheckBoxEEPROM_CHITCHAT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#eeprom";
            this.marlinCheckBoxEEPROM_CHITCHAT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxEEPROM_CHITCHAT.Location = new System.Drawing.Point(401, 42);
            this.marlinCheckBoxEEPROM_CHITCHAT.Name = "marlinCheckBoxEEPROM_CHITCHAT";
            this.marlinCheckBoxEEPROM_CHITCHAT.NewFirmwareHelper = null;
            this.marlinCheckBoxEEPROM_CHITCHAT.Size = new System.Drawing.Size(209, 21);
            this.marlinCheckBoxEEPROM_CHITCHAT.TabIndex = 1;
            // 
            // marlinCheckBoxEEPROM_SETTINGS
            // 
            this.marlinCheckBoxEEPROM_SETTINGS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxEEPROM_SETTINGS.ControlText = "Enable EEPROM";
            this.marlinCheckBoxEEPROM_SETTINGS.currentFirmwareHelper = null;
            this.marlinCheckBoxEEPROM_SETTINGS.Feature = "EEPROM_SETTINGS";
            this.marlinCheckBoxEEPROM_SETTINGS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#eeprom";
            this.marlinCheckBoxEEPROM_SETTINGS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxEEPROM_SETTINGS.Location = new System.Drawing.Point(401, 15);
            this.marlinCheckBoxEEPROM_SETTINGS.Name = "marlinCheckBoxEEPROM_SETTINGS";
            this.marlinCheckBoxEEPROM_SETTINGS.NewFirmwareHelper = null;
            this.marlinCheckBoxEEPROM_SETTINGS.Size = new System.Drawing.Size(209, 21);
            this.marlinCheckBoxEEPROM_SETTINGS.TabIndex = 0;
            // 
            // tabPagePreHeat
            // 
            this.tabPagePreHeat.Controls.Add(this.groupBoxPreHeat2);
            this.tabPagePreHeat.Controls.Add(this.groupBoxPreHeat1);
            this.tabPagePreHeat.Location = new System.Drawing.Point(4, 76);
            this.tabPagePreHeat.Name = "tabPagePreHeat";
            this.tabPagePreHeat.Size = new System.Drawing.Size(622, 585);
            this.tabPagePreHeat.TabIndex = 22;
            this.tabPagePreHeat.Text = "Pre-Heat";
            this.tabPagePreHeat.UseVisualStyleBackColor = true;
            // 
            // groupBoxPreHeat2
            // 
            this.groupBoxPreHeat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPreHeat2.Controls.Add(this.marlinUpDnPREHEAT_2_FAN_SPEED);
            this.groupBoxPreHeat2.Controls.Add(this.marlinUpDnPREHEAT_2_TEMP_HOTEND);
            this.groupBoxPreHeat2.Controls.Add(this.marlinUpDnPREHEAT_2_TEMP_BED);
            this.groupBoxPreHeat2.Location = new System.Drawing.Point(329, 134);
            this.groupBoxPreHeat2.Name = "groupBoxPreHeat2";
            this.groupBoxPreHeat2.Size = new System.Drawing.Size(280, 114);
            this.groupBoxPreHeat2.TabIndex = 4;
            this.groupBoxPreHeat2.TabStop = false;
            this.groupBoxPreHeat2.Text = "Preheat 2";
            // 
            // marlinUpDnPREHEAT_2_FAN_SPEED
            // 
            this.marlinUpDnPREHEAT_2_FAN_SPEED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPREHEAT_2_FAN_SPEED.ControlText = "Preheat 2 Fan Speed";
            this.marlinUpDnPREHEAT_2_FAN_SPEED.currentFirmwareHelper = null;
            this.marlinUpDnPREHEAT_2_FAN_SPEED.Feature = "PREHEAT_2_FAN_SPEED";
            this.marlinUpDnPREHEAT_2_FAN_SPEED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-material-presets-";
            this.marlinUpDnPREHEAT_2_FAN_SPEED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPREHEAT_2_FAN_SPEED.Location = new System.Drawing.Point(15, 83);
            this.marlinUpDnPREHEAT_2_FAN_SPEED.Max = 255;
            this.marlinUpDnPREHEAT_2_FAN_SPEED.Min = 0;
            this.marlinUpDnPREHEAT_2_FAN_SPEED.Name = "marlinUpDnPREHEAT_2_FAN_SPEED";
            this.marlinUpDnPREHEAT_2_FAN_SPEED.NewFirmwareHelper = null;
            this.marlinUpDnPREHEAT_2_FAN_SPEED.Size = new System.Drawing.Size(259, 26);
            this.marlinUpDnPREHEAT_2_FAN_SPEED.SpliterDistance = 170;
            this.marlinUpDnPREHEAT_2_FAN_SPEED.TabIndex = 2;
            // 
            // marlinUpDnPREHEAT_2_TEMP_HOTEND
            // 
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.ControlText = "Preheat 2 Temperature Hotend";
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.currentFirmwareHelper = null;
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.Feature = "PREHEAT_2_TEMP_HOTEND";
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-material-presets-";
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.Location = new System.Drawing.Point(15, 17);
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.Max = 300;
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.Min = 100;
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.Name = "marlinUpDnPREHEAT_2_TEMP_HOTEND";
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.NewFirmwareHelper = null;
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.Size = new System.Drawing.Size(259, 26);
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.SpliterDistance = 170;
            this.marlinUpDnPREHEAT_2_TEMP_HOTEND.TabIndex = 0;
            // 
            // marlinUpDnPREHEAT_2_TEMP_BED
            // 
            this.marlinUpDnPREHEAT_2_TEMP_BED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPREHEAT_2_TEMP_BED.ControlText = "Preheat 2 Temperature Bed";
            this.marlinUpDnPREHEAT_2_TEMP_BED.currentFirmwareHelper = null;
            this.marlinUpDnPREHEAT_2_TEMP_BED.Feature = "PREHEAT_2_TEMP_BED";
            this.marlinUpDnPREHEAT_2_TEMP_BED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-material-presets-";
            this.marlinUpDnPREHEAT_2_TEMP_BED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPREHEAT_2_TEMP_BED.Location = new System.Drawing.Point(15, 50);
            this.marlinUpDnPREHEAT_2_TEMP_BED.Max = 150;
            this.marlinUpDnPREHEAT_2_TEMP_BED.Min = 0;
            this.marlinUpDnPREHEAT_2_TEMP_BED.Name = "marlinUpDnPREHEAT_2_TEMP_BED";
            this.marlinUpDnPREHEAT_2_TEMP_BED.NewFirmwareHelper = null;
            this.marlinUpDnPREHEAT_2_TEMP_BED.Size = new System.Drawing.Size(259, 26);
            this.marlinUpDnPREHEAT_2_TEMP_BED.SpliterDistance = 170;
            this.marlinUpDnPREHEAT_2_TEMP_BED.TabIndex = 1;
            // 
            // groupBoxPreHeat1
            // 
            this.groupBoxPreHeat1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPreHeat1.Controls.Add(this.marlinUpDnPREHEAT_1_FAN_SPEED);
            this.groupBoxPreHeat1.Controls.Add(this.marlinUpDnPREHEAT_1_TEMP_HOTEND);
            this.groupBoxPreHeat1.Controls.Add(this.marlinUpDnPREHEAT_1_TEMP_BED);
            this.groupBoxPreHeat1.Location = new System.Drawing.Point(329, 14);
            this.groupBoxPreHeat1.Name = "groupBoxPreHeat1";
            this.groupBoxPreHeat1.Size = new System.Drawing.Size(280, 114);
            this.groupBoxPreHeat1.TabIndex = 3;
            this.groupBoxPreHeat1.TabStop = false;
            this.groupBoxPreHeat1.Text = "Preheat 1";
            // 
            // marlinUpDnPREHEAT_1_FAN_SPEED
            // 
            this.marlinUpDnPREHEAT_1_FAN_SPEED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPREHEAT_1_FAN_SPEED.ControlText = "Preheat 1 Fan Speed";
            this.marlinUpDnPREHEAT_1_FAN_SPEED.currentFirmwareHelper = null;
            this.marlinUpDnPREHEAT_1_FAN_SPEED.Feature = "PREHEAT_1_FAN_SPEED";
            this.marlinUpDnPREHEAT_1_FAN_SPEED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-material-presets-";
            this.marlinUpDnPREHEAT_1_FAN_SPEED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPREHEAT_1_FAN_SPEED.Location = new System.Drawing.Point(15, 83);
            this.marlinUpDnPREHEAT_1_FAN_SPEED.Max = 255;
            this.marlinUpDnPREHEAT_1_FAN_SPEED.Min = 0;
            this.marlinUpDnPREHEAT_1_FAN_SPEED.Name = "marlinUpDnPREHEAT_1_FAN_SPEED";
            this.marlinUpDnPREHEAT_1_FAN_SPEED.NewFirmwareHelper = null;
            this.marlinUpDnPREHEAT_1_FAN_SPEED.Size = new System.Drawing.Size(259, 26);
            this.marlinUpDnPREHEAT_1_FAN_SPEED.SpliterDistance = 170;
            this.marlinUpDnPREHEAT_1_FAN_SPEED.TabIndex = 2;
            // 
            // marlinUpDnPREHEAT_1_TEMP_HOTEND
            // 
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.ControlText = "Preheat 1 Temperature Hotend";
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.currentFirmwareHelper = null;
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.Feature = "PREHEAT_1_TEMP_HOTEND";
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-material-presets-";
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.Location = new System.Drawing.Point(15, 17);
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.Max = 300;
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.Min = 100;
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.Name = "marlinUpDnPREHEAT_1_TEMP_HOTEND";
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.NewFirmwareHelper = null;
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.Size = new System.Drawing.Size(259, 26);
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.SpliterDistance = 170;
            this.marlinUpDnPREHEAT_1_TEMP_HOTEND.TabIndex = 0;
            // 
            // marlinUpDnPREHEAT_1_TEMP_BED
            // 
            this.marlinUpDnPREHEAT_1_TEMP_BED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnPREHEAT_1_TEMP_BED.ControlText = "Preheat 1 Temperature Bed";
            this.marlinUpDnPREHEAT_1_TEMP_BED.currentFirmwareHelper = null;
            this.marlinUpDnPREHEAT_1_TEMP_BED.Feature = "PREHEAT_1_TEMP_BED";
            this.marlinUpDnPREHEAT_1_TEMP_BED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-material-presets-";
            this.marlinUpDnPREHEAT_1_TEMP_BED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnPREHEAT_1_TEMP_BED.Location = new System.Drawing.Point(15, 50);
            this.marlinUpDnPREHEAT_1_TEMP_BED.Max = 150;
            this.marlinUpDnPREHEAT_1_TEMP_BED.Min = 0;
            this.marlinUpDnPREHEAT_1_TEMP_BED.Name = "marlinUpDnPREHEAT_1_TEMP_BED";
            this.marlinUpDnPREHEAT_1_TEMP_BED.NewFirmwareHelper = null;
            this.marlinUpDnPREHEAT_1_TEMP_BED.Size = new System.Drawing.Size(259, 26);
            this.marlinUpDnPREHEAT_1_TEMP_BED.SpliterDistance = 170;
            this.marlinUpDnPREHEAT_1_TEMP_BED.TabIndex = 1;
            // 
            // tabPageNozzlePark
            // 
            this.tabPageNozzlePark.Controls.Add(this.groupBoxNozzleCleanFeature);
            this.tabPageNozzlePark.Controls.Add(this.marlinValue1);
            this.tabPageNozzlePark.Controls.Add(this.marlinCheckBoxNOZZLE_PARK_FEATURE);
            this.tabPageNozzlePark.Location = new System.Drawing.Point(4, 76);
            this.tabPageNozzlePark.Name = "tabPageNozzlePark";
            this.tabPageNozzlePark.Size = new System.Drawing.Size(622, 585);
            this.tabPageNozzlePark.TabIndex = 23;
            this.tabPageNozzlePark.Text = "Nozzle Park";
            this.tabPageNozzlePark.UseVisualStyleBackColor = true;
            // 
            // groupBoxNozzleCleanFeature
            // 
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinCheckBoxNOZZLE_CLEAN_GOBACK);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinUpDn2);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinUpDn1);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinValueNOZZLE_CLEAN_END_POINT);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinValueNOZZLE_CLEAN_START_POINT);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinCheckBoxNOZZLE_CLEAN_FEATURE);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinUpDnNOZZLE_CLEAN_TRIANGLES);
            this.groupBoxNozzleCleanFeature.Controls.Add(this.marlinUpDnNOZZLE_CLEAN_STROKES);
            this.groupBoxNozzleCleanFeature.Location = new System.Drawing.Point(237, 71);
            this.groupBoxNozzleCleanFeature.Name = "groupBoxNozzleCleanFeature";
            this.groupBoxNozzleCleanFeature.Size = new System.Drawing.Size(449, 327);
            this.groupBoxNozzleCleanFeature.TabIndex = 5;
            this.groupBoxNozzleCleanFeature.TabStop = false;
            this.groupBoxNozzleCleanFeature.Text = "Nozzle Clean Feature";
            // 
            // marlinCheckBoxNOZZLE_CLEAN_GOBACK
            // 
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.ControlText = "Nozzle Clean GoBack";
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.currentFirmwareHelper = null;
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.Feature = "NOZZLE_CLEAN_GOBACK";
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.Location = new System.Drawing.Point(195, 282);
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.Name = "marlinCheckBoxNOZZLE_CLEAN_GOBACK";
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.NewFirmwareHelper = null;
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.Size = new System.Drawing.Size(248, 21);
            this.marlinCheckBoxNOZZLE_CLEAN_GOBACK.TabIndex = 10;
            // 
            // marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE
            // 
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.ControlText = "Nozzle Clean Cirkle Middle";
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.currentFirmwareHelper = null;
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.Feature = "NOZZLE_CLEAN_CIRCLE_MIDDLE";
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.Location = new System.Drawing.Point(6, 250);
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.Name = "marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE";
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.NewFirmwareHelper = null;
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.Size = new System.Drawing.Size(437, 26);
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.SpliterDistance = 140;
            this.marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE.TabIndex = 9;
            // 
            // marlinUpDn2
            // 
            this.marlinUpDn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDn2.ControlText = "Nozzle Clean Cirkle Fragments";
            this.marlinUpDn2.currentFirmwareHelper = null;
            this.marlinUpDn2.Feature = "NOZZLE_CLEAN_CIRCLE_FN";
            this.marlinUpDn2.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinUpDn2.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDn2.Location = new System.Drawing.Point(195, 218);
            this.marlinUpDn2.Max = 20;
            this.marlinUpDn2.Min = 5;
            this.marlinUpDn2.Name = "marlinUpDn2";
            this.marlinUpDn2.NewFirmwareHelper = null;
            this.marlinUpDn2.Size = new System.Drawing.Size(248, 26);
            this.marlinUpDn2.SpliterDistance = 150;
            this.marlinUpDn2.TabIndex = 8;
            // 
            // marlinUpDn1
            // 
            this.marlinUpDn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDn1.ControlText = "Nozzle Clean Cirkle Radius";
            this.marlinUpDn1.currentFirmwareHelper = null;
            this.marlinUpDn1.Feature = "NOZZLE_CLEAN_CIRCLE_RADIUS";
            this.marlinUpDn1.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinUpDn1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDn1.Location = new System.Drawing.Point(195, 186);
            this.marlinUpDn1.Max = 20;
            this.marlinUpDn1.Min = 4;
            this.marlinUpDn1.Name = "marlinUpDn1";
            this.marlinUpDn1.NewFirmwareHelper = null;
            this.marlinUpDn1.Size = new System.Drawing.Size(248, 26);
            this.marlinUpDn1.SpliterDistance = 150;
            this.marlinUpDn1.TabIndex = 7;
            // 
            // marlinValueNOZZLE_CLEAN_END_POINT
            // 
            this.marlinValueNOZZLE_CLEAN_END_POINT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueNOZZLE_CLEAN_END_POINT.ControlText = "Nozzle Clean Endpoint";
            this.marlinValueNOZZLE_CLEAN_END_POINT.currentFirmwareHelper = null;
            this.marlinValueNOZZLE_CLEAN_END_POINT.Feature = "NOZZLE_CLEAN_END_POINT";
            this.marlinValueNOZZLE_CLEAN_END_POINT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinValueNOZZLE_CLEAN_END_POINT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueNOZZLE_CLEAN_END_POINT.Location = new System.Drawing.Point(6, 153);
            this.marlinValueNOZZLE_CLEAN_END_POINT.Name = "marlinValueNOZZLE_CLEAN_END_POINT";
            this.marlinValueNOZZLE_CLEAN_END_POINT.NewFirmwareHelper = null;
            this.marlinValueNOZZLE_CLEAN_END_POINT.Size = new System.Drawing.Size(437, 26);
            this.marlinValueNOZZLE_CLEAN_END_POINT.SpliterDistance = 120;
            this.marlinValueNOZZLE_CLEAN_END_POINT.TabIndex = 6;
            // 
            // marlinValueNOZZLE_CLEAN_START_POINT
            // 
            this.marlinValueNOZZLE_CLEAN_START_POINT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueNOZZLE_CLEAN_START_POINT.ControlText = "Nozzle Clean Startpoint";
            this.marlinValueNOZZLE_CLEAN_START_POINT.currentFirmwareHelper = null;
            this.marlinValueNOZZLE_CLEAN_START_POINT.Feature = "NOZZLE_CLEAN_START_POINT";
            this.marlinValueNOZZLE_CLEAN_START_POINT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinValueNOZZLE_CLEAN_START_POINT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueNOZZLE_CLEAN_START_POINT.Location = new System.Drawing.Point(6, 121);
            this.marlinValueNOZZLE_CLEAN_START_POINT.Name = "marlinValueNOZZLE_CLEAN_START_POINT";
            this.marlinValueNOZZLE_CLEAN_START_POINT.NewFirmwareHelper = null;
            this.marlinValueNOZZLE_CLEAN_START_POINT.Size = new System.Drawing.Size(437, 26);
            this.marlinValueNOZZLE_CLEAN_START_POINT.SpliterDistance = 120;
            this.marlinValueNOZZLE_CLEAN_START_POINT.TabIndex = 5;
            // 
            // marlinCheckBoxNOZZLE_CLEAN_FEATURE
            // 
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.ControlText = "Nozzle Clean Feature";
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.currentFirmwareHelper = null;
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.Feature = "NOZZLE_CLEAN_FEATURE";
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.Location = new System.Drawing.Point(111, 19);
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.Name = "marlinCheckBoxNOZZLE_CLEAN_FEATURE";
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.NewFirmwareHelper = null;
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.Size = new System.Drawing.Size(332, 21);
            this.marlinCheckBoxNOZZLE_CLEAN_FEATURE.TabIndex = 2;
            // 
            // marlinUpDnNOZZLE_CLEAN_TRIANGLES
            // 
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.ControlText = "Nozzle Clean Triangles";
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.currentFirmwareHelper = null;
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.Feature = "NOZZLE_CLEAN_TRIANGLES";
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.Location = new System.Drawing.Point(195, 78);
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.Max = 5;
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.Min = 1;
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.Name = "marlinUpDnNOZZLE_CLEAN_TRIANGLES";
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.NewFirmwareHelper = null;
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.Size = new System.Drawing.Size(248, 26);
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.SpliterDistance = 150;
            this.marlinUpDnNOZZLE_CLEAN_TRIANGLES.TabIndex = 4;
            // 
            // marlinUpDnNOZZLE_CLEAN_STROKES
            // 
            this.marlinUpDnNOZZLE_CLEAN_STROKES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnNOZZLE_CLEAN_STROKES.ControlText = "Nozzle Clean Strokes";
            this.marlinUpDnNOZZLE_CLEAN_STROKES.currentFirmwareHelper = null;
            this.marlinUpDnNOZZLE_CLEAN_STROKES.Feature = "NOZZLE_CLEAN_STROKES";
            this.marlinUpDnNOZZLE_CLEAN_STROKES.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinUpDnNOZZLE_CLEAN_STROKES.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnNOZZLE_CLEAN_STROKES.Location = new System.Drawing.Point(195, 46);
            this.marlinUpDnNOZZLE_CLEAN_STROKES.Max = 20;
            this.marlinUpDnNOZZLE_CLEAN_STROKES.Min = 0;
            this.marlinUpDnNOZZLE_CLEAN_STROKES.Name = "marlinUpDnNOZZLE_CLEAN_STROKES";
            this.marlinUpDnNOZZLE_CLEAN_STROKES.NewFirmwareHelper = null;
            this.marlinUpDnNOZZLE_CLEAN_STROKES.Size = new System.Drawing.Size(248, 26);
            this.marlinUpDnNOZZLE_CLEAN_STROKES.SpliterDistance = 150;
            this.marlinUpDnNOZZLE_CLEAN_STROKES.TabIndex = 3;
            // 
            // marlinValue1
            // 
            this.marlinValue1.ControlText = "Nozzle park point";
            this.marlinValue1.currentFirmwareHelper = null;
            this.marlinValue1.Feature = "NOZZLE_PARK_POINT";
            this.marlinValue1.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinValue1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValue1.Location = new System.Drawing.Point(247, 39);
            this.marlinValue1.Name = "marlinValue1";
            this.marlinValue1.NewFirmwareHelper = null;
            this.marlinValue1.Size = new System.Drawing.Size(433, 26);
            this.marlinValue1.SpliterDistance = 96;
            this.marlinValue1.TabIndex = 1;
            // 
            // marlinCheckBoxNOZZLE_PARK_FEATURE
            // 
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.ControlText = "Enable Noxxle Park";
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.currentFirmwareHelper = null;
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.Feature = "NOZZLE_PARK_FEATURE";
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#nozzle-clean";
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.Location = new System.Drawing.Point(348, 12);
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.Name = "marlinCheckBoxNOZZLE_PARK_FEATURE";
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.NewFirmwareHelper = null;
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.Size = new System.Drawing.Size(332, 21);
            this.marlinCheckBoxNOZZLE_PARK_FEATURE.TabIndex = 0;
            // 
            // tabPageJob
            // 
            this.tabPageJob.Controls.Add(this.marlinCheckBoxPRINTCOUNTER);
            this.tabPageJob.Controls.Add(this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART);
            this.tabPageJob.Location = new System.Drawing.Point(4, 76);
            this.tabPageJob.Name = "tabPageJob";
            this.tabPageJob.Size = new System.Drawing.Size(622, 585);
            this.tabPageJob.TabIndex = 24;
            this.tabPageJob.Text = "Job";
            this.tabPageJob.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxPRINTCOUNTER
            // 
            this.marlinCheckBoxPRINTCOUNTER.ControlText = "Printer Counter";
            this.marlinCheckBoxPRINTCOUNTER.currentFirmwareHelper = null;
            this.marlinCheckBoxPRINTCOUNTER.Feature = "PRINTCOUNTER";
            this.marlinCheckBoxPRINTCOUNTER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#print-counter";
            this.marlinCheckBoxPRINTCOUNTER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPRINTCOUNTER.Location = new System.Drawing.Point(409, 47);
            this.marlinCheckBoxPRINTCOUNTER.Name = "marlinCheckBoxPRINTCOUNTER";
            this.marlinCheckBoxPRINTCOUNTER.NewFirmwareHelper = null;
            this.marlinCheckBoxPRINTCOUNTER.Size = new System.Drawing.Size(186, 21);
            this.marlinCheckBoxPRINTCOUNTER.TabIndex = 1;
            // 
            // marlinCheckBoxPRINTJOB_TIMER_AUTOSTART
            // 
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.ControlText = "Printer Job Timer Autostart";
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.currentFirmwareHelper = null;
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.Feature = "PRINTJOB_TIMER_AUTOSTART";
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#print-job-timer";
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.Location = new System.Drawing.Point(409, 20);
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.Name = "marlinCheckBoxPRINTJOB_TIMER_AUTOSTART";
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.NewFirmwareHelper = null;
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.Size = new System.Drawing.Size(186, 21);
            this.marlinCheckBoxPRINTJOB_TIMER_AUTOSTART.TabIndex = 0;
            // 
            // tabPageLCD
            // 
            this.tabPageLCD.Controls.Add(this.groupBoxMenuOptions);
            this.tabPageLCD.Controls.Add(this.groupBoxEncoder);
            this.tabPageLCD.Controls.Add(this.groupBoxLcdType);
            this.tabPageLCD.Controls.Add(this.marlinComboBoxDISPLAY_CHARSET_HD44780);
            this.tabPageLCD.Controls.Add(this.marlinComboBoxLCD_LANGUAGE);
            this.tabPageLCD.Location = new System.Drawing.Point(4, 76);
            this.tabPageLCD.Name = "tabPageLCD";
            this.tabPageLCD.Size = new System.Drawing.Size(622, 585);
            this.tabPageLCD.TabIndex = 25;
            this.tabPageLCD.Text = "LCD";
            this.tabPageLCD.UseVisualStyleBackColor = true;
            // 
            // groupBoxMenuOptions
            // 
            this.groupBoxMenuOptions.Controls.Add(this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ);
            this.groupBoxMenuOptions.Controls.Add(this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS);
            this.groupBoxMenuOptions.Controls.Add(this.marlinCheckBoxSPEAKER);
            this.groupBoxMenuOptions.Controls.Add(this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU);
            this.groupBoxMenuOptions.Location = new System.Drawing.Point(373, 236);
            this.groupBoxMenuOptions.Name = "groupBoxMenuOptions";
            this.groupBoxMenuOptions.Size = new System.Drawing.Size(318, 203);
            this.groupBoxMenuOptions.TabIndex = 4;
            this.groupBoxMenuOptions.TabStop = false;
            this.groupBoxMenuOptions.Text = "Menu Options";
            // 
            // marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ
            // 
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.ControlText = "LCD Feedback Frequency (Hz) ";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.currentFirmwareHelper = null;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.Feature = "LCD_FEEDBACK_FREQUENCY_HZ";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#speaker";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.Location = new System.Drawing.Point(4, 112);
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.Name = "marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.NewFirmwareHelper = null;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.Size = new System.Drawing.Size(299, 26);
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.SpliterDistance = 220;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ.TabIndex = 3;
            // 
            // marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS
            // 
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.ControlText = "LCD Feedback Frequency Duaration (ms) ";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.currentFirmwareHelper = null;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.Feature = "LCD_FEEDBACK_FREQUENCY_DURATION_MS";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#speaker";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.Location = new System.Drawing.Point(4, 81);
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.Name = "marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS";
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.NewFirmwareHelper = null;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.Size = new System.Drawing.Size(299, 26);
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.SpliterDistance = 220;
            this.marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS.TabIndex = 2;
            // 
            // marlinCheckBoxSPEAKER
            // 
            this.marlinCheckBoxSPEAKER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSPEAKER.ControlText = "Speaker";
            this.marlinCheckBoxSPEAKER.currentFirmwareHelper = null;
            this.marlinCheckBoxSPEAKER.Feature = "SPEAKER";
            this.marlinCheckBoxSPEAKER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#speaker";
            this.marlinCheckBoxSPEAKER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSPEAKER.Location = new System.Drawing.Point(0, 54);
            this.marlinCheckBoxSPEAKER.Name = "marlinCheckBoxSPEAKER";
            this.marlinCheckBoxSPEAKER.NewFirmwareHelper = null;
            this.marlinCheckBoxSPEAKER.Size = new System.Drawing.Size(303, 21);
            this.marlinCheckBoxSPEAKER.TabIndex = 1;
            // 
            // marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU
            // 
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.ControlText = "Individual Axis Homing Menu";
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.currentFirmwareHelper = null;
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.Feature = "INDIVIDUAL_AXIS_HOMING_MENU";
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#encoder-direction";
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.Location = new System.Drawing.Point(0, 27);
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.Name = "marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU";
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.NewFirmwareHelper = null;
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.Size = new System.Drawing.Size(303, 21);
            this.marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU.TabIndex = 0;
            // 
            // groupBoxEncoder
            // 
            this.groupBoxEncoder.Controls.Add(this.marlinCheckBoxREVERSE_MENU_DIRECTION);
            this.groupBoxEncoder.Controls.Add(this.marlinCheckBoxREVERSE_ENCODER_DIRECTION);
            this.groupBoxEncoder.Controls.Add(this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM);
            this.groupBoxEncoder.Controls.Add(this.marlinEnableValueENCODER_PULSES_PER_STEP);
            this.groupBoxEncoder.Location = new System.Drawing.Point(373, 92);
            this.groupBoxEncoder.Name = "groupBoxEncoder";
            this.groupBoxEncoder.Size = new System.Drawing.Size(325, 138);
            this.groupBoxEncoder.TabIndex = 3;
            this.groupBoxEncoder.TabStop = false;
            this.groupBoxEncoder.Text = "Encoder Settings";
            // 
            // marlinCheckBoxREVERSE_MENU_DIRECTION
            // 
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.ControlText = "Reverse Menu Direction";
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.currentFirmwareHelper = null;
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.Feature = "REVERSE_MENU_DIRECTION";
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#encoder-direction";
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.Location = new System.Drawing.Point(4, 110);
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.Name = "marlinCheckBoxREVERSE_MENU_DIRECTION";
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.NewFirmwareHelper = null;
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.Size = new System.Drawing.Size(299, 21);
            this.marlinCheckBoxREVERSE_MENU_DIRECTION.TabIndex = 3;
            // 
            // marlinCheckBoxREVERSE_ENCODER_DIRECTION
            // 
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.ControlText = "Reverse Encoder Direction";
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.currentFirmwareHelper = null;
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.Feature = "REVERSE_ENCODER_DIRECTION";
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#encoder-direction";
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.Location = new System.Drawing.Point(4, 83);
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.Name = "marlinCheckBoxREVERSE_ENCODER_DIRECTION";
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.NewFirmwareHelper = null;
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.Size = new System.Drawing.Size(299, 21);
            this.marlinCheckBoxREVERSE_ENCODER_DIRECTION.TabIndex = 2;
            // 
            // marlinEnableValueENCODER_STEPS_PER_MENU_ITEM
            // 
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.ControlText = "Encoder Pulses per MenuItem";
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.currentFirmwareHelper = null;
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.Feature = "ENCODER_STEPS_PER_MENU_ITEM";
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#encoder-resolution";
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.Location = new System.Drawing.Point(6, 51);
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.Name = "marlinEnableValueENCODER_STEPS_PER_MENU_ITEM";
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.NewFirmwareHelper = null;
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.Size = new System.Drawing.Size(297, 26);
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.SpliterDistance = 150;
            this.marlinEnableValueENCODER_STEPS_PER_MENU_ITEM.TabIndex = 1;
            // 
            // marlinEnableValueENCODER_PULSES_PER_STEP
            // 
            this.marlinEnableValueENCODER_PULSES_PER_STEP.ControlText = "Encoder Pulses per Step";
            this.marlinEnableValueENCODER_PULSES_PER_STEP.currentFirmwareHelper = null;
            this.marlinEnableValueENCODER_PULSES_PER_STEP.Feature = "ENCODER_PULSES_PER_STEP";
            this.marlinEnableValueENCODER_PULSES_PER_STEP.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#encoder-resolution";
            this.marlinEnableValueENCODER_PULSES_PER_STEP.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueENCODER_PULSES_PER_STEP.Location = new System.Drawing.Point(6, 19);
            this.marlinEnableValueENCODER_PULSES_PER_STEP.Name = "marlinEnableValueENCODER_PULSES_PER_STEP";
            this.marlinEnableValueENCODER_PULSES_PER_STEP.NewFirmwareHelper = null;
            this.marlinEnableValueENCODER_PULSES_PER_STEP.Size = new System.Drawing.Size(297, 26);
            this.marlinEnableValueENCODER_PULSES_PER_STEP.SpliterDistance = 150;
            this.marlinEnableValueENCODER_PULSES_PER_STEP.TabIndex = 0;
            // 
            // groupBoxLcdType
            // 
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxOLED_PANEL_TINYBOY2);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxSAV_3DLCD);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxU8GLIB_SH1106);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxSAV_3DGLCD);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxU8GLIB_SSD1306);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxLCD_I2C_VIKI);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxLCD_I2C_PANELOLU2);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxLCM1602);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxRA_CONTROL_PANEL);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxRIGIDBOT_PANEL);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxREPRAPWORLD_KEYPAD);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxMINIPANEL);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxG3D_PANEL);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxminiVIKI);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxVIKI2);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxMAKRPANEL);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxPANEL_ONE);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxCARTESIO_UI);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxULTIPANEL);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxULTIMAKERCONTROLLER);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxDOGLCD);
            this.groupBoxLcdType.Controls.Add(this.marlinCheckBoxULTRA_LCD);
            this.groupBoxLcdType.Location = new System.Drawing.Point(8, 3);
            this.groupBoxLcdType.Name = "groupBoxLcdType";
            this.groupBoxLcdType.Size = new System.Drawing.Size(359, 546);
            this.groupBoxLcdType.TabIndex = 2;
            this.groupBoxLcdType.TabStop = false;
            this.groupBoxLcdType.Text = "LCD Type";
            // 
            // marlinCheckBoxOLED_PANEL_TINYBOY2
            // 
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.ControlText = "OLED_PANEL_TINYBOY2";
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.currentFirmwareHelper = null;
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.Feature = "OLED_PANEL_TINYBOY2";
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-controller";
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.Location = new System.Drawing.Point(5, 524);
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.Name = "marlinCheckBoxOLED_PANEL_TINYBOY2";
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.NewFirmwareHelper = null;
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxOLED_PANEL_TINYBOY2.TabIndex = 27;
            // 
            // marlinCheckBoxSAV_3DLCD
            // 
            this.marlinCheckBoxSAV_3DLCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSAV_3DLCD.ControlText = "SAV_3DLCD";
            this.marlinCheckBoxSAV_3DLCD.currentFirmwareHelper = null;
            this.marlinCheckBoxSAV_3DLCD.Feature = "SAV_3DLCD";
            this.marlinCheckBoxSAV_3DLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxSAV_3DLCD.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-character-lcds";
            this.marlinCheckBoxSAV_3DLCD.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSAV_3DLCD.Location = new System.Drawing.Point(5, 505);
            this.marlinCheckBoxSAV_3DLCD.Name = "marlinCheckBoxSAV_3DLCD";
            this.marlinCheckBoxSAV_3DLCD.NewFirmwareHelper = null;
            this.marlinCheckBoxSAV_3DLCD.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxSAV_3DLCD.TabIndex = 26;
            // 
            // marlinCheckBoxU8GLIB_SH1106
            // 
            this.marlinCheckBoxU8GLIB_SH1106.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxU8GLIB_SH1106.ControlText = "U8GLIB_SH1106";
            this.marlinCheckBoxU8GLIB_SH1106.currentFirmwareHelper = null;
            this.marlinCheckBoxU8GLIB_SH1106.Feature = "U8GLIB_SH1106";
            this.marlinCheckBoxU8GLIB_SH1106.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxU8GLIB_SH1106.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-type";
            this.marlinCheckBoxU8GLIB_SH1106.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxU8GLIB_SH1106.Location = new System.Drawing.Point(5, 486);
            this.marlinCheckBoxU8GLIB_SH1106.Name = "marlinCheckBoxU8GLIB_SH1106";
            this.marlinCheckBoxU8GLIB_SH1106.NewFirmwareHelper = null;
            this.marlinCheckBoxU8GLIB_SH1106.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxU8GLIB_SH1106.TabIndex = 25;
            // 
            // marlinCheckBoxSAV_3DGLCD
            // 
            this.marlinCheckBoxSAV_3DGLCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSAV_3DGLCD.ControlText = "SAV_3DGLCD";
            this.marlinCheckBoxSAV_3DGLCD.currentFirmwareHelper = null;
            this.marlinCheckBoxSAV_3DGLCD.Feature = "SAV_3DGLCD";
            this.marlinCheckBoxSAV_3DGLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxSAV_3DGLCD.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-graphical-lcds";
            this.marlinCheckBoxSAV_3DGLCD.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSAV_3DGLCD.Location = new System.Drawing.Point(5, 467);
            this.marlinCheckBoxSAV_3DGLCD.Name = "marlinCheckBoxSAV_3DGLCD";
            this.marlinCheckBoxSAV_3DGLCD.NewFirmwareHelper = null;
            this.marlinCheckBoxSAV_3DGLCD.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxSAV_3DGLCD.TabIndex = 24;
            // 
            // marlinCheckBoxU8GLIB_SSD1306
            // 
            this.marlinCheckBoxU8GLIB_SSD1306.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxU8GLIB_SSD1306.ControlText = "U8GLIB_SSD1306";
            this.marlinCheckBoxU8GLIB_SSD1306.currentFirmwareHelper = null;
            this.marlinCheckBoxU8GLIB_SSD1306.Feature = "U8GLIB_SSD1306";
            this.marlinCheckBoxU8GLIB_SSD1306.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxU8GLIB_SSD1306.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-graphical-lcds";
            this.marlinCheckBoxU8GLIB_SSD1306.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxU8GLIB_SSD1306.Location = new System.Drawing.Point(5, 448);
            this.marlinCheckBoxU8GLIB_SSD1306.Name = "marlinCheckBoxU8GLIB_SSD1306";
            this.marlinCheckBoxU8GLIB_SSD1306.NewFirmwareHelper = null;
            this.marlinCheckBoxU8GLIB_SSD1306.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxU8GLIB_SSD1306.TabIndex = 23;
            // 
            // marlinCheckBoxLCD_I2C_VIKI
            // 
            this.marlinCheckBoxLCD_I2C_VIKI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxLCD_I2C_VIKI.ControlText = "LCD_I2C_VIKI";
            this.marlinCheckBoxLCD_I2C_VIKI.currentFirmwareHelper = null;
            this.marlinCheckBoxLCD_I2C_VIKI.Feature = "LCD_I2C_VIKI";
            this.marlinCheckBoxLCD_I2C_VIKI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxLCD_I2C_VIKI.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-character-lcds";
            this.marlinCheckBoxLCD_I2C_VIKI.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxLCD_I2C_VIKI.Location = new System.Drawing.Point(5, 429);
            this.marlinCheckBoxLCD_I2C_VIKI.Name = "marlinCheckBoxLCD_I2C_VIKI";
            this.marlinCheckBoxLCD_I2C_VIKI.NewFirmwareHelper = null;
            this.marlinCheckBoxLCD_I2C_VIKI.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxLCD_I2C_VIKI.TabIndex = 22;
            // 
            // marlinCheckBoxLCD_I2C_PANELOLU2
            // 
            this.marlinCheckBoxLCD_I2C_PANELOLU2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxLCD_I2C_PANELOLU2.ControlText = "LCD_I2C_PANELOLU2";
            this.marlinCheckBoxLCD_I2C_PANELOLU2.currentFirmwareHelper = null;
            this.marlinCheckBoxLCD_I2C_PANELOLU2.Feature = "LCD_I2C_PANELOLU2";
            this.marlinCheckBoxLCD_I2C_PANELOLU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxLCD_I2C_PANELOLU2.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-character-lcds";
            this.marlinCheckBoxLCD_I2C_PANELOLU2.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxLCD_I2C_PANELOLU2.Location = new System.Drawing.Point(5, 410);
            this.marlinCheckBoxLCD_I2C_PANELOLU2.Name = "marlinCheckBoxLCD_I2C_PANELOLU2";
            this.marlinCheckBoxLCD_I2C_PANELOLU2.NewFirmwareHelper = null;
            this.marlinCheckBoxLCD_I2C_PANELOLU2.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxLCD_I2C_PANELOLU2.TabIndex = 21;
            // 
            // marlinCheckBoxLCM1602
            // 
            this.marlinCheckBoxLCM1602.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxLCM1602.ControlText = "LCM1602";
            this.marlinCheckBoxLCM1602.currentFirmwareHelper = null;
            this.marlinCheckBoxLCM1602.Feature = "LCM1602";
            this.marlinCheckBoxLCM1602.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxLCM1602.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-character-lcds";
            this.marlinCheckBoxLCM1602.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxLCM1602.Location = new System.Drawing.Point(5, 391);
            this.marlinCheckBoxLCM1602.Name = "marlinCheckBoxLCM1602";
            this.marlinCheckBoxLCM1602.NewFirmwareHelper = null;
            this.marlinCheckBoxLCM1602.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxLCM1602.TabIndex = 20;
            // 
            // marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT
            // 
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.ControlText = "LCD_I2C_SAINSMART_YWROBOT";
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.currentFirmwareHelper = null;
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.Feature = "LCD_I2C_SAINSMART_YWROBOT";
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-character-lcds";
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.Location = new System.Drawing.Point(5, 372);
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.Name = "marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT";
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.NewFirmwareHelper = null;
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT.TabIndex = 19;
            // 
            // marlinCheckBoxRA_CONTROL_PANEL
            // 
            this.marlinCheckBoxRA_CONTROL_PANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxRA_CONTROL_PANEL.ControlText = "RA_CONTROL_PANEL";
            this.marlinCheckBoxRA_CONTROL_PANEL.currentFirmwareHelper = null;
            this.marlinCheckBoxRA_CONTROL_PANEL.Feature = "RA_CONTROL_PANEL";
            this.marlinCheckBoxRA_CONTROL_PANEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxRA_CONTROL_PANEL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#i2c-character-lcds";
            this.marlinCheckBoxRA_CONTROL_PANEL.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxRA_CONTROL_PANEL.Location = new System.Drawing.Point(5, 353);
            this.marlinCheckBoxRA_CONTROL_PANEL.Name = "marlinCheckBoxRA_CONTROL_PANEL";
            this.marlinCheckBoxRA_CONTROL_PANEL.NewFirmwareHelper = null;
            this.marlinCheckBoxRA_CONTROL_PANEL.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxRA_CONTROL_PANEL.TabIndex = 18;
            // 
            // marlinCheckBoxBQ_LCD_SMART_CONTROLLER
            // 
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.ControlText = "BQ_LCD_SMART_CONTROLLER";
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.currentFirmwareHelper = null;
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.Feature = "BQ_LCD_SMART_CONTROLLER";
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.Location = new System.Drawing.Point(5, 334);
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.Name = "marlinCheckBoxBQ_LCD_SMART_CONTROLLER";
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.NewFirmwareHelper = null;
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxBQ_LCD_SMART_CONTROLLER.TabIndex = 17;
            // 
            // marlinCheckBoxRIGIDBOT_PANEL
            // 
            this.marlinCheckBoxRIGIDBOT_PANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxRIGIDBOT_PANEL.ControlText = "RIGIDBOT_PANEL";
            this.marlinCheckBoxRIGIDBOT_PANEL.currentFirmwareHelper = null;
            this.marlinCheckBoxRIGIDBOT_PANEL.Feature = "RIGIDBOT_PANEL";
            this.marlinCheckBoxRIGIDBOT_PANEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxRIGIDBOT_PANEL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#character-lcds";
            this.marlinCheckBoxRIGIDBOT_PANEL.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxRIGIDBOT_PANEL.Location = new System.Drawing.Point(5, 315);
            this.marlinCheckBoxRIGIDBOT_PANEL.Name = "marlinCheckBoxRIGIDBOT_PANEL";
            this.marlinCheckBoxRIGIDBOT_PANEL.NewFirmwareHelper = null;
            this.marlinCheckBoxRIGIDBOT_PANEL.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxRIGIDBOT_PANEL.TabIndex = 16;
            // 
            // marlinCheckBoxREPRAPWORLD_KEYPAD
            // 
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.ControlText = "REPRAPWORLD_KEYPAD";
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.currentFirmwareHelper = null;
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.Feature = "REPRAPWORLD_KEYPAD";
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#keypads";
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.Location = new System.Drawing.Point(5, 296);
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.Name = "marlinCheckBoxREPRAPWORLD_KEYPAD";
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.NewFirmwareHelper = null;
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxREPRAPWORLD_KEYPAD.TabIndex = 15;
            // 
            // marlinCheckBoxMINIPANEL
            // 
            this.marlinCheckBoxMINIPANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxMINIPANEL.ControlText = "MINIPANEL";
            this.marlinCheckBoxMINIPANEL.currentFirmwareHelper = null;
            this.marlinCheckBoxMINIPANEL.Feature = "MINIPANEL";
            this.marlinCheckBoxMINIPANEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxMINIPANEL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxMINIPANEL.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxMINIPANEL.Location = new System.Drawing.Point(5, 277);
            this.marlinCheckBoxMINIPANEL.Name = "marlinCheckBoxMINIPANEL";
            this.marlinCheckBoxMINIPANEL.NewFirmwareHelper = null;
            this.marlinCheckBoxMINIPANEL.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxMINIPANEL.TabIndex = 14;
            // 
            // marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER
            // 
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.ControlText = "REPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER";
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.currentFirmwareHelper = null;
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.Feature = "REPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER";
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.Location = new System.Drawing.Point(5, 258);
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.Name = "marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER";
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.NewFirmwareHelper = null;
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER.TabIndex = 13;
            // 
            // marlinCheckBoxG3D_PANEL
            // 
            this.marlinCheckBoxG3D_PANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxG3D_PANEL.ControlText = "G3D_PANEL";
            this.marlinCheckBoxG3D_PANEL.currentFirmwareHelper = null;
            this.marlinCheckBoxG3D_PANEL.Feature = "G3D_PANEL";
            this.marlinCheckBoxG3D_PANEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxG3D_PANEL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#character-lcds";
            this.marlinCheckBoxG3D_PANEL.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxG3D_PANEL.Location = new System.Drawing.Point(5, 239);
            this.marlinCheckBoxG3D_PANEL.Name = "marlinCheckBoxG3D_PANEL";
            this.marlinCheckBoxG3D_PANEL.NewFirmwareHelper = null;
            this.marlinCheckBoxG3D_PANEL.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxG3D_PANEL.TabIndex = 12;
            // 
            // marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER
            // 
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.ControlText = "REPRAP_DISCOUNT_SMART_CONTROLLER";
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.currentFirmwareHelper = null;
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.Feature = "REPRAP_DISCOUNT_SMART_CONTROLLER";
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#character-lcds";
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.Location = new System.Drawing.Point(5, 220);
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.Name = "marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER";
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.NewFirmwareHelper = null;
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER.TabIndex = 11;
            // 
            // marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER
            // 
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.ControlText = "ELB_FULL_GRAPHIC_CONTROLLER";
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.currentFirmwareHelper = null;
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.Feature = "ELB_FULL_GRAPHIC_CONTROLLER";
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.Location = new System.Drawing.Point(5, 201);
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.Name = "marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER";
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.NewFirmwareHelper = null;
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER.TabIndex = 10;
            // 
            // marlinCheckBoxminiVIKI
            // 
            this.marlinCheckBoxminiVIKI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxminiVIKI.ControlText = "miniVIKI";
            this.marlinCheckBoxminiVIKI.currentFirmwareHelper = null;
            this.marlinCheckBoxminiVIKI.Feature = "miniVIKI";
            this.marlinCheckBoxminiVIKI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxminiVIKI.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxminiVIKI.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxminiVIKI.Location = new System.Drawing.Point(5, 182);
            this.marlinCheckBoxminiVIKI.Name = "marlinCheckBoxminiVIKI";
            this.marlinCheckBoxminiVIKI.NewFirmwareHelper = null;
            this.marlinCheckBoxminiVIKI.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxminiVIKI.TabIndex = 9;
            // 
            // marlinCheckBoxVIKI2
            // 
            this.marlinCheckBoxVIKI2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxVIKI2.ControlText = "VIKI2";
            this.marlinCheckBoxVIKI2.currentFirmwareHelper = null;
            this.marlinCheckBoxVIKI2.Feature = "VIKI2";
            this.marlinCheckBoxVIKI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxVIKI2.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxVIKI2.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxVIKI2.Location = new System.Drawing.Point(5, 163);
            this.marlinCheckBoxVIKI2.Name = "marlinCheckBoxVIKI2";
            this.marlinCheckBoxVIKI2.NewFirmwareHelper = null;
            this.marlinCheckBoxVIKI2.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxVIKI2.TabIndex = 8;
            // 
            // marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD
            // 
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.ControlText = "REPRAPWORLD_GRAPHICAL_LCD";
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.currentFirmwareHelper = null;
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.Feature = "REPRAPWORLD_GRAPHICAL_LCD";
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.Location = new System.Drawing.Point(5, 144);
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.Name = "marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD";
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.NewFirmwareHelper = null;
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD.TabIndex = 7;
            // 
            // marlinCheckBoxMAKRPANEL
            // 
            this.marlinCheckBoxMAKRPANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxMAKRPANEL.ControlText = "MAKRPANEL";
            this.marlinCheckBoxMAKRPANEL.currentFirmwareHelper = null;
            this.marlinCheckBoxMAKRPANEL.Feature = "MAKRPANEL";
            this.marlinCheckBoxMAKRPANEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxMAKRPANEL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxMAKRPANEL.HelpWebBrowser = null;
            this.marlinCheckBoxMAKRPANEL.Location = new System.Drawing.Point(5, 125);
            this.marlinCheckBoxMAKRPANEL.Name = "marlinCheckBoxMAKRPANEL";
            this.marlinCheckBoxMAKRPANEL.NewFirmwareHelper = null;
            this.marlinCheckBoxMAKRPANEL.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxMAKRPANEL.TabIndex = 6;
            // 
            // marlinCheckBoxPANEL_ONE
            // 
            this.marlinCheckBoxPANEL_ONE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxPANEL_ONE.ControlText = "PANEL_ONE";
            this.marlinCheckBoxPANEL_ONE.currentFirmwareHelper = null;
            this.marlinCheckBoxPANEL_ONE.Feature = "PANEL_ONE";
            this.marlinCheckBoxPANEL_ONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxPANEL_ONE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#character-lcds";
            this.marlinCheckBoxPANEL_ONE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPANEL_ONE.Location = new System.Drawing.Point(5, 106);
            this.marlinCheckBoxPANEL_ONE.Name = "marlinCheckBoxPANEL_ONE";
            this.marlinCheckBoxPANEL_ONE.NewFirmwareHelper = null;
            this.marlinCheckBoxPANEL_ONE.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxPANEL_ONE.TabIndex = 5;
            // 
            // marlinCheckBoxCARTESIO_UI
            // 
            this.marlinCheckBoxCARTESIO_UI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxCARTESIO_UI.ControlText = "CARTESIO_UI";
            this.marlinCheckBoxCARTESIO_UI.currentFirmwareHelper = null;
            this.marlinCheckBoxCARTESIO_UI.Feature = "CARTESIO_UI";
            this.marlinCheckBoxCARTESIO_UI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxCARTESIO_UI.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#graphical-lcds";
            this.marlinCheckBoxCARTESIO_UI.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxCARTESIO_UI.Location = new System.Drawing.Point(5, 87);
            this.marlinCheckBoxCARTESIO_UI.Name = "marlinCheckBoxCARTESIO_UI";
            this.marlinCheckBoxCARTESIO_UI.NewFirmwareHelper = null;
            this.marlinCheckBoxCARTESIO_UI.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxCARTESIO_UI.TabIndex = 4;
            // 
            // marlinCheckBoxULTIPANEL
            // 
            this.marlinCheckBoxULTIPANEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxULTIPANEL.ControlText = "ULTIPANEL";
            this.marlinCheckBoxULTIPANEL.currentFirmwareHelper = null;
            this.marlinCheckBoxULTIPANEL.Feature = "ULTIPANEL";
            this.marlinCheckBoxULTIPANEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxULTIPANEL.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#character-lcds";
            this.marlinCheckBoxULTIPANEL.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxULTIPANEL.Location = new System.Drawing.Point(5, 68);
            this.marlinCheckBoxULTIPANEL.Name = "marlinCheckBoxULTIPANEL";
            this.marlinCheckBoxULTIPANEL.NewFirmwareHelper = null;
            this.marlinCheckBoxULTIPANEL.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxULTIPANEL.TabIndex = 3;
            // 
            // marlinCheckBoxULTIMAKERCONTROLLER
            // 
            this.marlinCheckBoxULTIMAKERCONTROLLER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxULTIMAKERCONTROLLER.ControlText = "ULTIMAKERCONTROLLER";
            this.marlinCheckBoxULTIMAKERCONTROLLER.currentFirmwareHelper = null;
            this.marlinCheckBoxULTIMAKERCONTROLLER.Feature = "ULTIMAKERCONTROLLER";
            this.marlinCheckBoxULTIMAKERCONTROLLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxULTIMAKERCONTROLLER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#character-lcds";
            this.marlinCheckBoxULTIMAKERCONTROLLER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxULTIMAKERCONTROLLER.Location = new System.Drawing.Point(5, 49);
            this.marlinCheckBoxULTIMAKERCONTROLLER.Name = "marlinCheckBoxULTIMAKERCONTROLLER";
            this.marlinCheckBoxULTIMAKERCONTROLLER.NewFirmwareHelper = null;
            this.marlinCheckBoxULTIMAKERCONTROLLER.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxULTIMAKERCONTROLLER.TabIndex = 2;
            // 
            // marlinCheckBoxDOGLCD
            // 
            this.marlinCheckBoxDOGLCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxDOGLCD.ControlText = "DOGLCD";
            this.marlinCheckBoxDOGLCD.currentFirmwareHelper = null;
            this.marlinCheckBoxDOGLCD.Feature = "DOGLCD";
            this.marlinCheckBoxDOGLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxDOGLCD.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-type";
            this.marlinCheckBoxDOGLCD.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxDOGLCD.Location = new System.Drawing.Point(5, 30);
            this.marlinCheckBoxDOGLCD.Name = "marlinCheckBoxDOGLCD";
            this.marlinCheckBoxDOGLCD.NewFirmwareHelper = null;
            this.marlinCheckBoxDOGLCD.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxDOGLCD.TabIndex = 1;
            // 
            // marlinCheckBoxULTRA_LCD
            // 
            this.marlinCheckBoxULTRA_LCD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxULTRA_LCD.ControlText = "ULTRA LCD";
            this.marlinCheckBoxULTRA_LCD.currentFirmwareHelper = null;
            this.marlinCheckBoxULTRA_LCD.Feature = "ULTRA_LCD";
            this.marlinCheckBoxULTRA_LCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marlinCheckBoxULTRA_LCD.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#lcd-type";
            this.marlinCheckBoxULTRA_LCD.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxULTRA_LCD.Location = new System.Drawing.Point(5, 11);
            this.marlinCheckBoxULTRA_LCD.Name = "marlinCheckBoxULTRA_LCD";
            this.marlinCheckBoxULTRA_LCD.NewFirmwareHelper = null;
            this.marlinCheckBoxULTRA_LCD.Size = new System.Drawing.Size(348, 19);
            this.marlinCheckBoxULTRA_LCD.TabIndex = 0;
            // 
            // marlinComboBoxDISPLAY_CHARSET_HD44780
            // 
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.ControlText = "LCD CharacterSet";
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.currentFirmwareHelper = null;
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.Feature = "DISPLAY_CHARSET_HD44780";
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#hd44780-character-set";
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.IsTrueFalse = false;
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.Location = new System.Drawing.Point(373, 51);
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.Name = "marlinComboBoxDISPLAY_CHARSET_HD44780";
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.NewFirmwareHelper = null;
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.Size = new System.Drawing.Size(303, 26);
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.SpliterDistance = 101;
            this.marlinComboBoxDISPLAY_CHARSET_HD44780.TabIndex = 1;
            // 
            // marlinComboBoxLCD_LANGUAGE
            // 
            this.marlinComboBoxLCD_LANGUAGE.ControlText = "Language";
            this.marlinComboBoxLCD_LANGUAGE.currentFirmwareHelper = null;
            this.marlinComboBoxLCD_LANGUAGE.Feature = "LCD_LANGUAGE";
            this.marlinComboBoxLCD_LANGUAGE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#user-interface-language" +
    "";
            this.marlinComboBoxLCD_LANGUAGE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinComboBoxLCD_LANGUAGE.IsTrueFalse = false;
            this.marlinComboBoxLCD_LANGUAGE.Location = new System.Drawing.Point(379, 19);
            this.marlinComboBoxLCD_LANGUAGE.Name = "marlinComboBoxLCD_LANGUAGE";
            this.marlinComboBoxLCD_LANGUAGE.NewFirmwareHelper = null;
            this.marlinComboBoxLCD_LANGUAGE.Size = new System.Drawing.Size(297, 26);
            this.marlinComboBoxLCD_LANGUAGE.SpliterDistance = 60;
            this.marlinComboBoxLCD_LANGUAGE.TabIndex = 0;
            // 
            // tabPageSD
            // 
            this.tabPageSD.Controls.Add(this.marlinCheckBoxSD_CHECK_AND_RETRY);
            this.tabPageSD.Controls.Add(this.marlinCheckBoxSDSUPPORT);
            this.tabPageSD.Location = new System.Drawing.Point(4, 76);
            this.tabPageSD.Name = "tabPageSD";
            this.tabPageSD.Size = new System.Drawing.Size(622, 585);
            this.tabPageSD.TabIndex = 26;
            this.tabPageSD.Text = "SD";
            this.tabPageSD.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxSD_CHECK_AND_RETRY
            // 
            this.marlinCheckBoxSD_CHECK_AND_RETRY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSD_CHECK_AND_RETRY.ControlText = "SD Check and Rety";
            this.marlinCheckBoxSD_CHECK_AND_RETRY.currentFirmwareHelper = null;
            this.marlinCheckBoxSD_CHECK_AND_RETRY.Feature = "SD_CHECK_AND_RETRY";
            this.marlinCheckBoxSD_CHECK_AND_RETRY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#sd-card";
            this.marlinCheckBoxSD_CHECK_AND_RETRY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSD_CHECK_AND_RETRY.Location = new System.Drawing.Point(438, 46);
            this.marlinCheckBoxSD_CHECK_AND_RETRY.Name = "marlinCheckBoxSD_CHECK_AND_RETRY";
            this.marlinCheckBoxSD_CHECK_AND_RETRY.NewFirmwareHelper = null;
            this.marlinCheckBoxSD_CHECK_AND_RETRY.Size = new System.Drawing.Size(169, 21);
            this.marlinCheckBoxSD_CHECK_AND_RETRY.TabIndex = 1;
            // 
            // marlinCheckBoxSDSUPPORT
            // 
            this.marlinCheckBoxSDSUPPORT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSDSUPPORT.ControlText = "Support for SD";
            this.marlinCheckBoxSDSUPPORT.currentFirmwareHelper = null;
            this.marlinCheckBoxSDSUPPORT.Feature = "SDSUPPORT";
            this.marlinCheckBoxSDSUPPORT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#sd-card";
            this.marlinCheckBoxSDSUPPORT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSDSUPPORT.Location = new System.Drawing.Point(438, 19);
            this.marlinCheckBoxSDSUPPORT.Name = "marlinCheckBoxSDSUPPORT";
            this.marlinCheckBoxSDSUPPORT.NewFirmwareHelper = null;
            this.marlinCheckBoxSDSUPPORT.Size = new System.Drawing.Size(169, 21);
            this.marlinCheckBoxSDSUPPORT.TabIndex = 0;
            // 
            // tabPageExtra
            // 
            this.tabPageExtra.Controls.Add(this.groupBoxRGB_Led);
            this.tabPageExtra.Controls.Add(this.marlinCheckBoxBLINKM);
            this.tabPageExtra.Controls.Add(this.marlinCheckBoxBARICUDA);
            this.tabPageExtra.Controls.Add(this.marlinCheckBoxSF_ARC_FIX);
            this.tabPageExtra.Controls.Add(this.marlinEnableValuePHOTOGRAPH_PIN);
            this.tabPageExtra.Controls.Add(this.marlinCheckBoxTEMP_STAT_LEDS);
            this.tabPageExtra.Controls.Add(this.marlinCheckBoxSOFT_PWM_DITHER);
            this.tabPageExtra.Controls.Add(this.marlinUpDnSOFT_PWM_SCALE);
            this.tabPageExtra.Controls.Add(this.marlinCheckBoxFAST_PWM_FAN);
            this.tabPageExtra.Location = new System.Drawing.Point(4, 76);
            this.tabPageExtra.Name = "tabPageExtra";
            this.tabPageExtra.Size = new System.Drawing.Size(622, 585);
            this.tabPageExtra.TabIndex = 27;
            this.tabPageExtra.Text = "Extra";
            this.tabPageExtra.UseVisualStyleBackColor = true;
            // 
            // groupBoxRGB_Led
            // 
            this.groupBoxRGB_Led.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRGB_Led.Controls.Add(this.marlinCheckBoxPRINTER_EVENT_LEDS);
            this.groupBoxRGB_Led.Controls.Add(this.marlinUpDnRGB_LED_W_PIN);
            this.groupBoxRGB_Led.Controls.Add(this.marlinUpDnRGB_LED_B_PIN);
            this.groupBoxRGB_Led.Controls.Add(this.marlinUpDnRGB_LED_G_PIN);
            this.groupBoxRGB_Led.Controls.Add(this.marlinUpDnRGB_LED_R_PIN);
            this.groupBoxRGB_Led.Controls.Add(this.marlinCheckBoxRGB_LED);
            this.groupBoxRGB_Led.Controls.Add(this.marlinCheckBoxRGBW_LED);
            this.groupBoxRGB_Led.Location = new System.Drawing.Point(416, 289);
            this.groupBoxRGB_Led.Name = "groupBoxRGB_Led";
            this.groupBoxRGB_Led.Size = new System.Drawing.Size(200, 232);
            this.groupBoxRGB_Led.TabIndex = 11;
            this.groupBoxRGB_Led.TabStop = false;
            this.groupBoxRGB_Led.Text = "RGB LED";
            // 
            // marlinCheckBoxPRINTER_EVENT_LEDS
            // 
            this.marlinCheckBoxPRINTER_EVENT_LEDS.ControlText = "Printer Event LEDs";
            this.marlinCheckBoxPRINTER_EVENT_LEDS.currentFirmwareHelper = null;
            this.marlinCheckBoxPRINTER_EVENT_LEDS.Feature = "PRINTER_EVENT_LEDS";
            this.marlinCheckBoxPRINTER_EVENT_LEDS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinCheckBoxPRINTER_EVENT_LEDS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxPRINTER_EVENT_LEDS.Location = new System.Drawing.Point(6, 203);
            this.marlinCheckBoxPRINTER_EVENT_LEDS.Name = "marlinCheckBoxPRINTER_EVENT_LEDS";
            this.marlinCheckBoxPRINTER_EVENT_LEDS.NewFirmwareHelper = null;
            this.marlinCheckBoxPRINTER_EVENT_LEDS.Size = new System.Drawing.Size(188, 21);
            this.marlinCheckBoxPRINTER_EVENT_LEDS.TabIndex = 14;
            // 
            // marlinUpDnRGB_LED_W_PIN
            // 
            this.marlinUpDnRGB_LED_W_PIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnRGB_LED_W_PIN.ControlText = "RGB LED W-Pin";
            this.marlinUpDnRGB_LED_W_PIN.currentFirmwareHelper = null;
            this.marlinUpDnRGB_LED_W_PIN.Feature = "RGB_LED_W_PIN";
            this.marlinUpDnRGB_LED_W_PIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinUpDnRGB_LED_W_PIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnRGB_LED_W_PIN.Location = new System.Drawing.Point(6, 170);
            this.marlinUpDnRGB_LED_W_PIN.Max = 64;
            this.marlinUpDnRGB_LED_W_PIN.Min = -1;
            this.marlinUpDnRGB_LED_W_PIN.Name = "marlinUpDnRGB_LED_W_PIN";
            this.marlinUpDnRGB_LED_W_PIN.NewFirmwareHelper = null;
            this.marlinUpDnRGB_LED_W_PIN.Size = new System.Drawing.Size(188, 26);
            this.marlinUpDnRGB_LED_W_PIN.SpliterDistance = 90;
            this.marlinUpDnRGB_LED_W_PIN.TabIndex = 13;
            // 
            // marlinUpDnRGB_LED_B_PIN
            // 
            this.marlinUpDnRGB_LED_B_PIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnRGB_LED_B_PIN.ControlText = "RGB LED B-Pin";
            this.marlinUpDnRGB_LED_B_PIN.currentFirmwareHelper = null;
            this.marlinUpDnRGB_LED_B_PIN.Feature = "RGB_LED_B_PIN";
            this.marlinUpDnRGB_LED_B_PIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinUpDnRGB_LED_B_PIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnRGB_LED_B_PIN.Location = new System.Drawing.Point(6, 138);
            this.marlinUpDnRGB_LED_B_PIN.Max = 64;
            this.marlinUpDnRGB_LED_B_PIN.Min = -1;
            this.marlinUpDnRGB_LED_B_PIN.Name = "marlinUpDnRGB_LED_B_PIN";
            this.marlinUpDnRGB_LED_B_PIN.NewFirmwareHelper = null;
            this.marlinUpDnRGB_LED_B_PIN.Size = new System.Drawing.Size(188, 26);
            this.marlinUpDnRGB_LED_B_PIN.SpliterDistance = 90;
            this.marlinUpDnRGB_LED_B_PIN.TabIndex = 12;
            // 
            // marlinUpDnRGB_LED_G_PIN
            // 
            this.marlinUpDnRGB_LED_G_PIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnRGB_LED_G_PIN.ControlText = "RGB LED G-Pin";
            this.marlinUpDnRGB_LED_G_PIN.currentFirmwareHelper = null;
            this.marlinUpDnRGB_LED_G_PIN.Feature = "RGB_LED_G_PIN";
            this.marlinUpDnRGB_LED_G_PIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinUpDnRGB_LED_G_PIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnRGB_LED_G_PIN.Location = new System.Drawing.Point(6, 106);
            this.marlinUpDnRGB_LED_G_PIN.Max = 64;
            this.marlinUpDnRGB_LED_G_PIN.Min = -1;
            this.marlinUpDnRGB_LED_G_PIN.Name = "marlinUpDnRGB_LED_G_PIN";
            this.marlinUpDnRGB_LED_G_PIN.NewFirmwareHelper = null;
            this.marlinUpDnRGB_LED_G_PIN.Size = new System.Drawing.Size(188, 26);
            this.marlinUpDnRGB_LED_G_PIN.SpliterDistance = 90;
            this.marlinUpDnRGB_LED_G_PIN.TabIndex = 11;
            // 
            // marlinUpDnRGB_LED_R_PIN
            // 
            this.marlinUpDnRGB_LED_R_PIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnRGB_LED_R_PIN.ControlText = "RGB LED R-Pin";
            this.marlinUpDnRGB_LED_R_PIN.currentFirmwareHelper = null;
            this.marlinUpDnRGB_LED_R_PIN.Feature = "RGB_LED_R_PIN";
            this.marlinUpDnRGB_LED_R_PIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinUpDnRGB_LED_R_PIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnRGB_LED_R_PIN.Location = new System.Drawing.Point(6, 74);
            this.marlinUpDnRGB_LED_R_PIN.Max = 64;
            this.marlinUpDnRGB_LED_R_PIN.Min = -1;
            this.marlinUpDnRGB_LED_R_PIN.Name = "marlinUpDnRGB_LED_R_PIN";
            this.marlinUpDnRGB_LED_R_PIN.NewFirmwareHelper = null;
            this.marlinUpDnRGB_LED_R_PIN.Size = new System.Drawing.Size(188, 26);
            this.marlinUpDnRGB_LED_R_PIN.SpliterDistance = 90;
            this.marlinUpDnRGB_LED_R_PIN.TabIndex = 10;
            // 
            // marlinCheckBoxRGB_LED
            // 
            this.marlinCheckBoxRGB_LED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxRGB_LED.ControlText = "RGB_LED";
            this.marlinCheckBoxRGB_LED.currentFirmwareHelper = null;
            this.marlinCheckBoxRGB_LED.Feature = "RGB_LED";
            this.marlinCheckBoxRGB_LED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinCheckBoxRGB_LED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxRGB_LED.Location = new System.Drawing.Point(6, 20);
            this.marlinCheckBoxRGB_LED.Name = "marlinCheckBoxRGB_LED";
            this.marlinCheckBoxRGB_LED.NewFirmwareHelper = null;
            this.marlinCheckBoxRGB_LED.Size = new System.Drawing.Size(188, 21);
            this.marlinCheckBoxRGB_LED.TabIndex = 8;
            // 
            // marlinCheckBoxRGBW_LED
            // 
            this.marlinCheckBoxRGBW_LED.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxRGBW_LED.ControlText = "RGBW_LED";
            this.marlinCheckBoxRGBW_LED.currentFirmwareHelper = null;
            this.marlinCheckBoxRGBW_LED.Feature = "RGBW_LED";
            this.marlinCheckBoxRGBW_LED.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinCheckBoxRGBW_LED.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxRGBW_LED.Location = new System.Drawing.Point(6, 47);
            this.marlinCheckBoxRGBW_LED.Name = "marlinCheckBoxRGBW_LED";
            this.marlinCheckBoxRGBW_LED.NewFirmwareHelper = null;
            this.marlinCheckBoxRGBW_LED.Size = new System.Drawing.Size(188, 21);
            this.marlinCheckBoxRGBW_LED.TabIndex = 9;
            // 
            // marlinCheckBoxBLINKM
            // 
            this.marlinCheckBoxBLINKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxBLINKM.ControlText = "BlinkM/CyzRgb Support";
            this.marlinCheckBoxBLINKM.currentFirmwareHelper = null;
            this.marlinCheckBoxBLINKM.Feature = "BLINKM";
            this.marlinCheckBoxBLINKM.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#indicator-leds";
            this.marlinCheckBoxBLINKM.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxBLINKM.Location = new System.Drawing.Point(263, 260);
            this.marlinCheckBoxBLINKM.Name = "marlinCheckBoxBLINKM";
            this.marlinCheckBoxBLINKM.NewFirmwareHelper = null;
            this.marlinCheckBoxBLINKM.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxBLINKM.TabIndex = 7;
            // 
            // marlinCheckBoxBARICUDA
            // 
            this.marlinCheckBoxBARICUDA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxBARICUDA.ControlText = " Support for the BariCUDA Paste Extruder";
            this.marlinCheckBoxBARICUDA.currentFirmwareHelper = null;
            this.marlinCheckBoxBARICUDA.Feature = "BARICUDA";
            this.marlinCheckBoxBARICUDA.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#paste-extruder";
            this.marlinCheckBoxBARICUDA.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxBARICUDA.Location = new System.Drawing.Point(263, 226);
            this.marlinCheckBoxBARICUDA.Name = "marlinCheckBoxBARICUDA";
            this.marlinCheckBoxBARICUDA.NewFirmwareHelper = null;
            this.marlinCheckBoxBARICUDA.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxBARICUDA.TabIndex = 6;
            // 
            // marlinCheckBoxSF_ARC_FIX
            // 
            this.marlinCheckBoxSF_ARC_FIX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSF_ARC_FIX.ControlText = "SkeinForge Arc Fix";
            this.marlinCheckBoxSF_ARC_FIX.currentFirmwareHelper = null;
            this.marlinCheckBoxSF_ARC_FIX.Feature = "SF_ARC_FIX";
            this.marlinCheckBoxSF_ARC_FIX.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#skeinforge-arc-fix";
            this.marlinCheckBoxSF_ARC_FIX.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSF_ARC_FIX.Location = new System.Drawing.Point(263, 192);
            this.marlinCheckBoxSF_ARC_FIX.Name = "marlinCheckBoxSF_ARC_FIX";
            this.marlinCheckBoxSF_ARC_FIX.NewFirmwareHelper = null;
            this.marlinCheckBoxSF_ARC_FIX.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxSF_ARC_FIX.TabIndex = 5;
            // 
            // marlinEnableValuePHOTOGRAPH_PIN
            // 
            this.marlinEnableValuePHOTOGRAPH_PIN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValuePHOTOGRAPH_PIN.ControlText = "Photograph Pin";
            this.marlinEnableValuePHOTOGRAPH_PIN.currentFirmwareHelper = null;
            this.marlinEnableValuePHOTOGRAPH_PIN.Feature = "PHOTOGRAPH_PIN";
            this.marlinEnableValuePHOTOGRAPH_PIN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#photo-pin";
            this.marlinEnableValuePHOTOGRAPH_PIN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValuePHOTOGRAPH_PIN.Location = new System.Drawing.Point(263, 153);
            this.marlinEnableValuePHOTOGRAPH_PIN.Name = "marlinEnableValuePHOTOGRAPH_PIN";
            this.marlinEnableValuePHOTOGRAPH_PIN.NewFirmwareHelper = null;
            this.marlinEnableValuePHOTOGRAPH_PIN.Size = new System.Drawing.Size(347, 26);
            this.marlinEnableValuePHOTOGRAPH_PIN.SpliterDistance = 110;
            this.marlinEnableValuePHOTOGRAPH_PIN.TabIndex = 4;
            // 
            // marlinCheckBoxTEMP_STAT_LEDS
            // 
            this.marlinCheckBoxTEMP_STAT_LEDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxTEMP_STAT_LEDS.ControlText = "Temperature Status LEDs";
            this.marlinCheckBoxTEMP_STAT_LEDS.currentFirmwareHelper = null;
            this.marlinCheckBoxTEMP_STAT_LEDS.Feature = "TEMP_STAT_LEDS";
            this.marlinCheckBoxTEMP_STAT_LEDS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#temperature-status-leds" +
    "";
            this.marlinCheckBoxTEMP_STAT_LEDS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxTEMP_STAT_LEDS.Location = new System.Drawing.Point(263, 119);
            this.marlinCheckBoxTEMP_STAT_LEDS.Name = "marlinCheckBoxTEMP_STAT_LEDS";
            this.marlinCheckBoxTEMP_STAT_LEDS.NewFirmwareHelper = null;
            this.marlinCheckBoxTEMP_STAT_LEDS.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxTEMP_STAT_LEDS.TabIndex = 3;
            // 
            // marlinCheckBoxSOFT_PWM_DITHER
            // 
            this.marlinCheckBoxSOFT_PWM_DITHER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxSOFT_PWM_DITHER.ControlText = "Soft PWM Dither";
            this.marlinCheckBoxSOFT_PWM_DITHER.currentFirmwareHelper = null;
            this.marlinCheckBoxSOFT_PWM_DITHER.Feature = "SOFT_PWM_DITHER";
            this.marlinCheckBoxSOFT_PWM_DITHER.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#fan-pwm";
            this.marlinCheckBoxSOFT_PWM_DITHER.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxSOFT_PWM_DITHER.Location = new System.Drawing.Point(263, 85);
            this.marlinCheckBoxSOFT_PWM_DITHER.Name = "marlinCheckBoxSOFT_PWM_DITHER";
            this.marlinCheckBoxSOFT_PWM_DITHER.NewFirmwareHelper = null;
            this.marlinCheckBoxSOFT_PWM_DITHER.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxSOFT_PWM_DITHER.TabIndex = 2;
            // 
            // marlinUpDnSOFT_PWM_SCALE
            // 
            this.marlinUpDnSOFT_PWM_SCALE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnSOFT_PWM_SCALE.ControlText = "Soft PWM Scale";
            this.marlinUpDnSOFT_PWM_SCALE.currentFirmwareHelper = null;
            this.marlinUpDnSOFT_PWM_SCALE.Feature = "SOFT_PWM_SCALE";
            this.marlinUpDnSOFT_PWM_SCALE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#fan-pwm";
            this.marlinUpDnSOFT_PWM_SCALE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnSOFT_PWM_SCALE.Location = new System.Drawing.Point(263, 46);
            this.marlinUpDnSOFT_PWM_SCALE.Max = 128;
            this.marlinUpDnSOFT_PWM_SCALE.Min = 0;
            this.marlinUpDnSOFT_PWM_SCALE.Name = "marlinUpDnSOFT_PWM_SCALE";
            this.marlinUpDnSOFT_PWM_SCALE.NewFirmwareHelper = null;
            this.marlinUpDnSOFT_PWM_SCALE.Size = new System.Drawing.Size(347, 26);
            this.marlinUpDnSOFT_PWM_SCALE.SpliterDistance = 115;
            this.marlinUpDnSOFT_PWM_SCALE.TabIndex = 1;
            // 
            // marlinCheckBoxFAST_PWM_FAN
            // 
            this.marlinCheckBoxFAST_PWM_FAN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxFAST_PWM_FAN.ControlText = "Fast PWM Fan";
            this.marlinCheckBoxFAST_PWM_FAN.currentFirmwareHelper = null;
            this.marlinCheckBoxFAST_PWM_FAN.Feature = "FAST_PWM_FAN";
            this.marlinCheckBoxFAST_PWM_FAN.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#fan-pwm";
            this.marlinCheckBoxFAST_PWM_FAN.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxFAST_PWM_FAN.Location = new System.Drawing.Point(263, 12);
            this.marlinCheckBoxFAST_PWM_FAN.Name = "marlinCheckBoxFAST_PWM_FAN";
            this.marlinCheckBoxFAST_PWM_FAN.NewFirmwareHelper = null;
            this.marlinCheckBoxFAST_PWM_FAN.Size = new System.Drawing.Size(347, 21);
            this.marlinCheckBoxFAST_PWM_FAN.TabIndex = 0;
            // 
            // tabPageServo
            // 
            this.tabPageServo.Controls.Add(this.marlinEnableValueNUM_SERVOS);
            this.tabPageServo.Controls.Add(this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE);
            this.tabPageServo.Controls.Add(this.marlinUpDnSERVO_DELAY);
            this.tabPageServo.Location = new System.Drawing.Point(4, 76);
            this.tabPageServo.Name = "tabPageServo";
            this.tabPageServo.Size = new System.Drawing.Size(622, 585);
            this.tabPageServo.TabIndex = 28;
            this.tabPageServo.Text = "Servo";
            this.tabPageServo.UseVisualStyleBackColor = true;
            // 
            // marlinEnableValueNUM_SERVOS
            // 
            this.marlinEnableValueNUM_SERVOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinEnableValueNUM_SERVOS.ControlText = "Number of Servos";
            this.marlinEnableValueNUM_SERVOS.currentFirmwareHelper = null;
            this.marlinEnableValueNUM_SERVOS.Feature = "NUM_SERVOS";
            this.marlinEnableValueNUM_SERVOS.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#servos";
            this.marlinEnableValueNUM_SERVOS.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinEnableValueNUM_SERVOS.Location = new System.Drawing.Point(319, 12);
            this.marlinEnableValueNUM_SERVOS.Name = "marlinEnableValueNUM_SERVOS";
            this.marlinEnableValueNUM_SERVOS.NewFirmwareHelper = null;
            this.marlinEnableValueNUM_SERVOS.Size = new System.Drawing.Size(291, 26);
            this.marlinEnableValueNUM_SERVOS.SpliterDistance = 150;
            this.marlinEnableValueNUM_SERVOS.TabIndex = 3;
            // 
            // marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE
            // 
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.ControlText = "Deactivate Servo After Move";
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.currentFirmwareHelper = null;
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.Feature = "DEACTIVATE_SERVOS_AFTER_MOVE";
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#servos";
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.Location = new System.Drawing.Point(319, 76);
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.Name = "marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE";
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.NewFirmwareHelper = null;
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.Size = new System.Drawing.Size(291, 21);
            this.marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE.TabIndex = 2;
            // 
            // marlinUpDnSERVO_DELAY
            // 
            this.marlinUpDnSERVO_DELAY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnSERVO_DELAY.ControlText = "Servo Delay (ms)";
            this.marlinUpDnSERVO_DELAY.currentFirmwareHelper = null;
            this.marlinUpDnSERVO_DELAY.Feature = "SERVO_DELAY";
            this.marlinUpDnSERVO_DELAY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#servos";
            this.marlinUpDnSERVO_DELAY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnSERVO_DELAY.Location = new System.Drawing.Point(319, 46);
            this.marlinUpDnSERVO_DELAY.Max = 2000;
            this.marlinUpDnSERVO_DELAY.Min = 0;
            this.marlinUpDnSERVO_DELAY.Name = "marlinUpDnSERVO_DELAY";
            this.marlinUpDnSERVO_DELAY.NewFirmwareHelper = null;
            this.marlinUpDnSERVO_DELAY.Size = new System.Drawing.Size(291, 26);
            this.marlinUpDnSERVO_DELAY.SpliterDistance = 150;
            this.marlinUpDnSERVO_DELAY.TabIndex = 1;
            // 
            // tabPageFilamentWidthSensor
            // 
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinCheckBoxFILAMENT_LCD_DISPLAY);
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA);
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinUpDn4);
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinValueMEASURED_LOWER_LIMIT);
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinValueMEASURED_UPPER_LIMIT);
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinUpDn3);
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM);
            this.tabPageFilamentWidthSensor.Controls.Add(this.marlinCheckBox1);
            this.tabPageFilamentWidthSensor.Location = new System.Drawing.Point(4, 76);
            this.tabPageFilamentWidthSensor.Name = "tabPageFilamentWidthSensor";
            this.tabPageFilamentWidthSensor.Size = new System.Drawing.Size(622, 585);
            this.tabPageFilamentWidthSensor.TabIndex = 29;
            this.tabPageFilamentWidthSensor.Text = "Filament Width Sensor1";
            this.tabPageFilamentWidthSensor.UseVisualStyleBackColor = true;
            // 
            // marlinCheckBoxFILAMENT_LCD_DISPLAY
            // 
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.ControlText = "Display filament width on the LCD status line";
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.currentFirmwareHelper = null;
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.Feature = "FILAMENT_LCD_DISPLAY";
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.Location = new System.Drawing.Point(206, 247);
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.Name = "marlinCheckBoxFILAMENT_LCD_DISPLAY";
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.NewFirmwareHelper = null;
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.Size = new System.Drawing.Size(404, 21);
            this.marlinCheckBoxFILAMENT_LCD_DISPLAY.TabIndex = 7;
            // 
            // marlinValueDEFAULT_MEASURED_FILAMENT_DIA
            // 
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.ControlText = "Default Nominal Filament Diameter";
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.currentFirmwareHelper = null;
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.Feature = "DEFAULT_MEASURED_FILAMENT_DIA";
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.Location = new System.Drawing.Point(206, 213);
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.Name = "marlinValueDEFAULT_MEASURED_FILAMENT_DIA";
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.NewFirmwareHelper = null;
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.Size = new System.Drawing.Size(404, 26);
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.SpliterDistance = 170;
            this.marlinValueDEFAULT_MEASURED_FILAMENT_DIA.TabIndex = 6;
            // 
            // marlinUpDn4
            // 
            this.marlinUpDn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDn4.ControlText = "Buffer size for stored measurements (1 byte per cm)";
            this.marlinUpDn4.currentFirmwareHelper = null;
            this.marlinUpDn4.Feature = "MAX_MEASUREMENT_DELAY";
            this.marlinUpDn4.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinUpDn4.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDn4.Location = new System.Drawing.Point(206, 179);
            this.marlinUpDn4.Max = 60;
            this.marlinUpDn4.Min = 0;
            this.marlinUpDn4.Name = "marlinUpDn4";
            this.marlinUpDn4.NewFirmwareHelper = null;
            this.marlinUpDn4.Size = new System.Drawing.Size(404, 26);
            this.marlinUpDn4.SpliterDistance = 300;
            this.marlinUpDn4.TabIndex = 5;
            // 
            // marlinValueMEASURED_LOWER_LIMIT
            // 
            this.marlinValueMEASURED_LOWER_LIMIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueMEASURED_LOWER_LIMIT.ControlText = "Meassured Lower Limit";
            this.marlinValueMEASURED_LOWER_LIMIT.currentFirmwareHelper = null;
            this.marlinValueMEASURED_LOWER_LIMIT.Feature = "MEASURED_LOWER_LIMIT";
            this.marlinValueMEASURED_LOWER_LIMIT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinValueMEASURED_LOWER_LIMIT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueMEASURED_LOWER_LIMIT.Location = new System.Drawing.Point(206, 145);
            this.marlinValueMEASURED_LOWER_LIMIT.Name = "marlinValueMEASURED_LOWER_LIMIT";
            this.marlinValueMEASURED_LOWER_LIMIT.NewFirmwareHelper = null;
            this.marlinValueMEASURED_LOWER_LIMIT.Size = new System.Drawing.Size(404, 26);
            this.marlinValueMEASURED_LOWER_LIMIT.SpliterDistance = 300;
            this.marlinValueMEASURED_LOWER_LIMIT.TabIndex = 4;
            // 
            // marlinValueMEASURED_UPPER_LIMIT
            // 
            this.marlinValueMEASURED_UPPER_LIMIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinValueMEASURED_UPPER_LIMIT.ControlText = "Meassured Upper Limit";
            this.marlinValueMEASURED_UPPER_LIMIT.currentFirmwareHelper = null;
            this.marlinValueMEASURED_UPPER_LIMIT.Feature = "MEASURED_UPPER_LIMIT";
            this.marlinValueMEASURED_UPPER_LIMIT.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinValueMEASURED_UPPER_LIMIT.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinValueMEASURED_UPPER_LIMIT.Location = new System.Drawing.Point(206, 111);
            this.marlinValueMEASURED_UPPER_LIMIT.Name = "marlinValueMEASURED_UPPER_LIMIT";
            this.marlinValueMEASURED_UPPER_LIMIT.NewFirmwareHelper = null;
            this.marlinValueMEASURED_UPPER_LIMIT.Size = new System.Drawing.Size(404, 26);
            this.marlinValueMEASURED_UPPER_LIMIT.SpliterDistance = 300;
            this.marlinValueMEASURED_UPPER_LIMIT.TabIndex = 3;
            // 
            // marlinUpDn3
            // 
            this.marlinUpDn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDn3.ControlText = "The distance from the filament sensor to the melting chamber (cm)";
            this.marlinUpDn3.currentFirmwareHelper = null;
            this.marlinUpDn3.Feature = "MEASUREMENT_DELAY_CM";
            this.marlinUpDn3.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinUpDn3.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDn3.Location = new System.Drawing.Point(206, 77);
            this.marlinUpDn3.Max = 200;
            this.marlinUpDn3.Min = 1;
            this.marlinUpDn3.Name = "marlinUpDn3";
            this.marlinUpDn3.NewFirmwareHelper = null;
            this.marlinUpDn3.Size = new System.Drawing.Size(404, 26);
            this.marlinUpDn3.SpliterDistance = 316;
            this.marlinUpDn3.TabIndex = 2;
            // 
            // marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM
            // 
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.ControlText = "Extruder that has the filament sensor";
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.currentFirmwareHelper = null;
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.Feature = "FILAMENT_SENSOR_EXTRUDER_NUM";
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.Location = new System.Drawing.Point(206, 43);
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.Max = 3;
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.Min = 0;
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.Name = "marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM";
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.NewFirmwareHelper = null;
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.Size = new System.Drawing.Size(404, 26);
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.SpliterDistance = 315;
            this.marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM.TabIndex = 1;
            // 
            // marlinCheckBox1
            // 
            this.marlinCheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marlinCheckBox1.ControlText = "Filament Width Sensor";
            this.marlinCheckBox1.currentFirmwareHelper = null;
            this.marlinCheckBox1.Feature = "FILAMENT_WIDTH_SENSOR";
            this.marlinCheckBox1.HelpUrl = "http://marlinfw.org/docs/configuration/configuration.html#filament-width-sensor";
            this.marlinCheckBox1.HelpWebBrowser = this.webBrowserMarlinHelp;
            this.marlinCheckBox1.Location = new System.Drawing.Point(206, 14);
            this.marlinCheckBox1.Name = "marlinCheckBox1";
            this.marlinCheckBox1.NewFirmwareHelper = null;
            this.marlinCheckBox1.Size = new System.Drawing.Size(404, 21);
            this.marlinCheckBox1.TabIndex = 0;
            // 
            // toolStripConfiguration
            // 
            this.toolStripConfiguration.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripConfiguration.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDownload,
            this.toolStripButtonPrevious,
            this.toolStripButtonNext,
            this.toolStripButtonArduinoIDE,
            this.toolStripButtonSetup,
            this.toolStripSeparator1,
            this.toolStripButtonPayPal});
            this.toolStripConfiguration.Location = new System.Drawing.Point(0, 0);
            this.toolStripConfiguration.Name = "toolStripConfiguration";
            this.toolStripConfiguration.Size = new System.Drawing.Size(630, 39);
            this.toolStripConfiguration.TabIndex = 4;
            this.toolStripConfiguration.Text = "toolStrip1";
            // 
            // toolStripButtonDownload
            // 
            this.toolStripButtonDownload.Image = global::MarlinConfigurator.Properties.Resources.download;
            this.toolStripButtonDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDownload.Name = "toolStripButtonDownload";
            this.toolStripButtonDownload.Size = new System.Drawing.Size(97, 36);
            this.toolStripButtonDownload.Text = "Download";
            this.toolStripButtonDownload.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButtonPrevious
            // 
            this.toolStripButtonPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrevious.Image = global::MarlinConfigurator.Properties.Resources.go_previous;
            this.toolStripButtonPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrevious.Name = "toolStripButtonPrevious";
            this.toolStripButtonPrevious.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonPrevious.Text = "Previous";
            this.toolStripButtonPrevious.Click += new System.EventHandler(this.ToolStripButtonPrevious_Click);
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNext.Image = global::MarlinConfigurator.Properties.Resources.go_next;
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonNext.Text = "Next";
            this.toolStripButtonNext.Click += new System.EventHandler(this.ToolStripButtonNext_Click);
            // 
            // toolStripButtonArduinoIDE
            // 
            this.toolStripButtonArduinoIDE.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonArduinoIDE.Image")));
            this.toolStripButtonArduinoIDE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonArduinoIDE.Name = "toolStripButtonArduinoIDE";
            this.toolStripButtonArduinoIDE.Size = new System.Drawing.Size(106, 36);
            this.toolStripButtonArduinoIDE.Text = "Arduino IDE";
            // 
            // toolStripButtonSetup
            // 
            this.toolStripButtonSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetup.Image")));
            this.toolStripButtonSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetup.Name = "toolStripButtonSetup";
            this.toolStripButtonSetup.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonSetup.Text = "Setup";
            this.toolStripButtonSetup.Click += new System.EventHandler(this.toolStripButtonSetup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonPayPal
            // 
            this.toolStripButtonPayPal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPayPal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPayPal.Image")));
            this.toolStripButtonPayPal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPayPal.Name = "toolStripButtonPayPal";
            this.toolStripButtonPayPal.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonPayPal.Text = "PayPal";
            this.toolStripButtonPayPal.Click += new System.EventHandler(this.toolStripButtonPayPal_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripConfiguration);
            this.splitContainer1.Panel1.Controls.Add(this.tabControlConfiguration);
            this.splitContainer1.Panel1MinSize = 630;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserMarlinHelp);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 661);
            this.splitContainer1.SplitterDistance = 630;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 2;
            // 
            // FrmConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FrmConfigurator";
            this.Text = "Marlin Firmware Configurator";
            this.Load += new System.EventHandler(this.FrmConfigurator_Load);
            this.tabControlConfiguration.ResumeLayout(false);
            this.tabPageDownload.ResumeLayout(false);
            this.grpBxNewFirmware.ResumeLayout(false);
            this.grpBxNewFirmware.PerformLayout();
            this.grpcurrentFirmware.ResumeLayout(false);
            this.grpcurrentFirmware.PerformLayout();
            this.tabPageConfiguration.ResumeLayout(false);
            this.grpBxConfigurationVersion.ResumeLayout(false);
            this.grpBxHardware.ResumeLayout(false);
            this.grpBxFirmwareInfo.ResumeLayout(false);
            this.tabPageExtruder.ResumeLayout(false);
            this.grpBxExtruderOffset.ResumeLayout(false);
            this.grpBxMixingExtruders.ResumeLayout(false);
            this.grpBxSWITCHING_EXTRUDER.ResumeLayout(false);
            this.tabPagePowerSupply.ResumeLayout(false);
            this.tabPageTemperatureSensor.ResumeLayout(false);
            this.tabPageTemperatureStability.ResumeLayout(false);
            this.grpBxTemperatureStabilityBed.ResumeLayout(false);
            this.grpBxTemperatureStabilityExtruder.ResumeLayout(false);
            this.tabPageTemperatures.ResumeLayout(false);
            this.grpBxMinTemperatureBed.ResumeLayout(false);
            this.grpBxMinTemperatureExtruders.ResumeLayout(false);
            this.tabPagePidExtruder.ResumeLayout(false);
            this.tabPagePidBed.ResumeLayout(false);
            this.tabPageExtrusion.ResumeLayout(false);
            this.tabPageThermalProtection.ResumeLayout(false);
            this.tabPageKinematics.ResumeLayout(false);
            this.tabPageEndstop.ResumeLayout(false);
            this.groupBoxEndstopPlug.ResumeLayout(false);
            this.groupBoxInvertingEndstops.ResumeLayout(false);
            this.grpBxPullupResistors.ResumeLayout(false);
            this.tabPageMovement.ResumeLayout(false);
            this.tabPageProbe.ResumeLayout(false);
            this.groupBoxZ_CLEARANCE.ResumeLayout(false);
            this.groupBoxZ_PROBE_SPEED.ResumeLayout(false);
            this.groupBoxPROBE_OFFSET_FROM_EXTRUDER.ResumeLayout(false);
            this.grpBxZ_PROBE_SLED.ResumeLayout(false);
            this.grpBxBLTouch.ResumeLayout(false);
            this.tabPageStepper.ResumeLayout(false);
            this.grpBxInvertDirection.ResumeLayout(false);
            this.grpBxDisableSteppers.ResumeLayout(false);
            this.grpBxStepperEnablePin.ResumeLayout(false);
            this.tabPageHoming.ResumeLayout(false);
            this.grpBxTravelLimits.ResumeLayout(false);
            this.groupBoxEndStopDirection.ResumeLayout(false);
            this.tabPageFilamentRunoutSensor.ResumeLayout(false);
            this.tabPageBedLeveling.ResumeLayout(false);
            this.grpBxMeshBedLevel.ResumeLayout(false);
            this.grpBxAutoBedLevelingUbl.ResumeLayout(false);
            this.grpBxGridPoints.ResumeLayout(false);
            this.grpBx3Points.ResumeLayout(false);
            this.grpBiLinear.ResumeLayout(false);
            this.grpAutoBedLevetType.ResumeLayout(false);
            this.grpBxProbeGrid.ResumeLayout(false);
            this.grpBxEnableFadeHeight.ResumeLayout(false);
            this.grpBxEnableFadeHeight.PerformLayout();
            this.tabPageLcdBedLeveling.ResumeLayout(false);
            this.tabPageEEPROM.ResumeLayout(false);
            this.tabPagePreHeat.ResumeLayout(false);
            this.groupBoxPreHeat2.ResumeLayout(false);
            this.groupBoxPreHeat1.ResumeLayout(false);
            this.tabPageNozzlePark.ResumeLayout(false);
            this.groupBoxNozzleCleanFeature.ResumeLayout(false);
            this.tabPageJob.ResumeLayout(false);
            this.tabPageLCD.ResumeLayout(false);
            this.groupBoxMenuOptions.ResumeLayout(false);
            this.groupBoxEncoder.ResumeLayout(false);
            this.groupBoxLcdType.ResumeLayout(false);
            this.tabPageSD.ResumeLayout(false);
            this.tabPageExtra.ResumeLayout(false);
            this.groupBoxRGB_Led.ResumeLayout(false);
            this.tabPageServo.ResumeLayout(false);
            this.tabPageFilamentWidthSensor.ResumeLayout(false);
            this.toolStripConfiguration.ResumeLayout(false);
            this.toolStripConfiguration.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConfiguration;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.TabPage tabPageTemperatureSensor;
        private System.Windows.Forms.TabPage tabPagePidExtruder;
        private System.Windows.Forms.TabPage tabPageEndstop;
        private System.Windows.Forms.TabPage tabPageMovement;
        private System.Windows.Forms.TabPage tabPageProbe;
        private System.Windows.Forms.TabPage tabPageDownload;
        private System.Windows.Forms.WebBrowser webBrowserMarlinHelp;
        private System.Windows.Forms.GroupBox grpBxNewFirmware;
        private System.Windows.Forms.Button btnDownloadMarlinStable;
        private System.Windows.Forms.ToolTip toolTipConfiguration;
        private System.Windows.Forms.Button btnBrowseNewFirmware;
        private System.Windows.Forms.TextBox txtBxNewFirmware;
        private System.Windows.Forms.GroupBox grpcurrentFirmware;
        private System.Windows.Forms.Button btnBrowsecurrentFirmware;
        private System.Windows.Forms.TextBox txtBxcurrentFirmware;
        private System.Windows.Forms.GroupBox grpBxFirmwareInfo;
        private System.Windows.Forms.GroupBox grpBxHardware;
        
        private System.Windows.Forms.SplitContainer splitContainer1;
        
        private System.Windows.Forms.TabPage tabPageExtruder;

        private System.Windows.Forms.GroupBox grpBxExtruderOffset;

        private System.Windows.Forms.GroupBox grpBxMixingExtruders;

        private System.Windows.Forms.GroupBox grpBxSWITCHING_EXTRUDER;
        private System.Windows.Forms.TabPage tabPagePowerSupply;
        
        private System.Windows.Forms.TabPage tabPageTemperatureStability;
        private System.Windows.Forms.GroupBox grpBxTemperatureStabilityBed;

        private System.Windows.Forms.GroupBox grpBxTemperatureStabilityExtruder;

        private System.Windows.Forms.TabPage tabPageTemperatures;
        private System.Windows.Forms.GroupBox grpBxMinTemperatureBed;

        private System.Windows.Forms.GroupBox grpBxMinTemperatureExtruders;
        private System.Windows.Forms.GroupBox grpBxConfigurationVersion;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueCONFIGURATION_H_VERSION;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueStringConfigHAuthor;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueMACHINE_UUID;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueCUSTOM_MACHINE_NAME;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxBLUETOOTH;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueBAUDRATE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnSERIAL_PORT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSHOW_CUSTOM_BOOTSCREEN;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueSTRING_SPLASH_LINE2;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueSTRING_SPLASH_LINE1;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSHOW_BOOTSCREEN;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSINGLENOZZLE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnEXTRUDERS;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueHOTEND_OFFSET_Y;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueHOTEND_OFFSET_X;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxDIRECT_MIXING_IN_G1;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnMIXING_VIRTUAL_TOOLS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnMIXING_STEPPERS;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxMIXING_EXTRUDER;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueHOTEND_OFFSET_Z;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueSWITCHING_EXTRUDER_SERVO_ANGLES;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnSWITCHING_EXTRUDER_SERVO;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSWITCHING_EXTRUDER;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPOWER_SUPPLY;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPS_DEFAULT_OFF;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxMOTHERBOARD;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxTEMP_SENSOR_0;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxTEMP_SENSOR_BED;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxTEMP_SENSOR_1;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxTEMP_SENSOR_2;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxTEMP_SENSOR_3;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxTEMP_SENSOR_4;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnMAX_REDUNDANT_TEMP_SENSOR_DIFF;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxTEMP_SENSOR_1_AS_REDUNDANT;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnDUMMY_THERMISTOR_999_VALUE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnDUMMY_THERMISTOR_998_VALUE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnTEMP_BED_WINDOW;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnTEMP_BED_RESIDENCY_TIME;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnTEMP_BED_HYSTERESIS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnTEMP_WINDOW;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnTEMP_HYSTERESIS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnTEMP_RESIDENCY_TIME;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnBED_MAXTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnBED_MINTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_4_MAXTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_3_MAXTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_2_MAXTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_1_MAXTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_0_MAXTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_4_MINTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_3_MINTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_2_MINTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_1_MINTEMP;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnHEATER_0_MINTEMP;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_Kd;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_Ki;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_Kp;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueK1;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPID_FUNCTIONAL_RANGE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPID_PARAMS_PER_HOTEND;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSLOW_PWM_HEATERS;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValuePID_OPENLOOP;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPID_DEBUG;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPID_AUTOTUNE_MENU;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValuePID_MAX;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnBANG_MAX;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPIDTEMP;
        private System.Windows.Forms.TabPage tabPagePidBed;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_bedKd;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_bedKi;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_bedKp;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPID_BED_DEBUG;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnMAX_BED_POWER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxBED_LIMIT_SWITCHING;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPIDTEMPBED;
        private System.Windows.Forms.TabPage tabPageExtrusion;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueEXTRUDE_MAXLENGTH;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPREVENT_LENGTHY_EXTRUDE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnEXTRUDE_MINTEMP;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPREVENT_COLD_EXTRUSION;
        private System.Windows.Forms.TabPage tabPageThermalProtection;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxTHERMAL_PROTECTION_BED;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxTHERMAL_PROTECTION_HOTENDS;
        private System.Windows.Forms.TabPage tabPageKinematics;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCOREZY;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCOREZX;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCOREYX;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCOREYZ;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCOREXZ;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCOREXY;
        private System.Windows.Forms.GroupBox groupBoxEndstopPlug;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxUSE_ZMIN_PLUG;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxUSE_XMIN_PLUG;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxUSE_YMIN_PLUG;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxUSE_ZMAX_PLUG;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxUSE_XMAX_PLUG;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxUSE_YMAX_PLUG;
        private System.Windows.Forms.GroupBox groupBoxInvertingEndstops;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxZ_MAX_ENDSTOP_INVERTING;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxY_MAX_ENDSTOP_INVERTING;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxX_MAX_ENDSTOP_INVERTING;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxZ_MIN_ENDSTOP_INVERTING;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxY_MIN_ENDSTOP_INVERTING;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxX_MIN_ENDSTOP_INVERTING;
        private System.Windows.Forms.GroupBox grpBxPullupResistors;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUPS;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_ZMIN_PROBE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_XMAX;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_ZMIN;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_YMAX;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_YMIN;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_ZMAX;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_XMIN;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOP_INTERRUPTS_FEATURE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxDISTINCT_E_FACTORS;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_EJERK;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_ZJERK;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_YJERK;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_XJERK;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_TRAVEL_ACCELERATION;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_RETRACT_ACCELERATION;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_ACCELERATION;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_MAX_ACCELERATION;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_MAX_FEEDRATE;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_AXIS_STEPS_PER_UNIT;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueZ_MIN_PROBE_PIN;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxZ_MIN_PROBE_ENDSTOP;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxZ_MIN_PROBE_USES_Z_MIN_ENDSTOP_PIN;
        private System.Windows.Forms.GroupBox groupBoxPROBE_OFFSET_FROM_EXTRUDER;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueY_PROBE_OFFSET_FROM_EXTRUDER;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueZ_PROBE_OFFSET_FROM_EXTRUDER;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueX_PROBE_OFFSET_FROM_EXTRUDER;
        private System.Windows.Forms.GroupBox grpBxZ_PROBE_SLED;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueSLED_DOCKING_OFFSET;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxZ_PROBE_SLED;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSOLENOID_PROBE;
        private System.Windows.Forms.GroupBox grpBxBLTouch;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxBLTOUCH;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxBLTOUCH_HEATERS_OFF;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueBLTOUCH_DELAY;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueZ_SERVO_ANGLES;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueZ_ENDSTOP_SERVO_NR;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxFIX_MOUNTED_PROBE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPROBE_MANUALLY;
        private System.Windows.Forms.GroupBox groupBoxZ_CLEARANCE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnZ_CLEARANCE_BETWEEN_PROBES;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnZ_CLEARANCE_DEPLOY_PROBE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxZ_MIN_PROBE_REPEATABILITY_TEST;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPROBE_DOUBLE_TOUCH;
        private System.Windows.Forms.GroupBox groupBoxZ_PROBE_SPEED;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueZ_PROBE_SPEED_FAST;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueZ_PROBE_SPEED_SLOW;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueXY_PROBE_SPEED;
        private System.Windows.Forms.TabPage tabPageStepper;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCONFIG_STEPPERS_TOSHIBA;
        private System.Windows.Forms.GroupBox grpBxInvertDirection;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_E4_DIR;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_E3_DIR;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_E2_DIR;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_E1_DIR;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_E0_DIR;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_Z_DIR;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_Y_DIR;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxINVERT_X_DIR;
        private System.Windows.Forms.GroupBox grpBxDisableSteppers;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxDISABLE_INACTIVE_EXTRUDER;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxDISABLE_E;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxDISABLE_Z;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxDISABLE_Y;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxDISABLE_X;
        private System.Windows.Forms.GroupBox grpBxStepperEnablePin;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueE_ENABLE_ON;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueZ_ENABLE_ON;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueY_ENABLE_ON;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueX_ENABLE_ON;
        private System.Windows.Forms.TabPage tabPageHoming;
        private System.Windows.Forms.GroupBox grpBxTravelLimits;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxMIN_SOFTWARE_ENDSTOPS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnZ_MAX_POS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnY_MAX_POS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnX_MAX_POS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnZ_MIN_POS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnY_MIN_POS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnX_MIN_POS;
        private System.Windows.Forms.GroupBox groupBoxEndStopDirection;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnZ_HOME_DIR;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnY_HOME_DIR;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnX_HOME_DIR;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxMAX_SOFTWARE_ENDSTOPS;
        private System.Windows.Forms.TabPage tabPageFilamentRunoutSensor;
        private System.Windows.Forms.TabPage tabPageBedLeveling;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueZ_PROBE_END_SCRIPT;
        private System.Windows.Forms.GroupBox grpBxMeshBedLevel;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxMESH_G28_REST_ORIGIN;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnMESH_INSET;
        private System.Windows.Forms.GroupBox grpBxAutoBedLevelingUbl;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnUBL_PROBE_PT_3_Y;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnUBL_MESH_INSET;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnUBL_PROBE_PT_3_X;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnUBL_PROBE_PT_1_Y;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnUBL_PROBE_PT_2_Y;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnUBL_PROBE_PT_1_X;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnUBL_PROBE_PT_2_X;
        private System.Windows.Forms.GroupBox grpBxGridPoints;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueGRID_MAX_POINTS_X;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueGRID_MAX_POINTS_Y;
        private System.Windows.Forms.GroupBox grpBx3Points;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnABL_PROBE_PT_3_Y;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnABL_PROBE_PT_3_X;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnABL_PROBE_PT_2_Y;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnABL_PROBE_PT_2_X;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnABL_PROBE_PT_1_Y;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnABL_PROBE_PT_1_X;
        private System.Windows.Forms.GroupBox grpBiLinear;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnBILINEAR_SUBDIVISIONS;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxABL_BILINEAR_SUBDIVISION;
        private System.Windows.Forms.GroupBox grpAutoBedLevetType;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxAUTO_BED_LEVELING_3POINT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxMESH_BED_LEVELING;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxAUTO_BED_LEVELING_LINEAR;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxAUTO_BED_LEVELING_UBL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxAUTO_BED_LEVELING_BILINEAR;
        private System.Windows.Forms.GroupBox grpBxProbeGrid;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPROBE_Y_FIRST;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnMIN_PROBE_EDGE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnBACK_PROBE_BED_POSITION;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnFRONT_PROBE_BED_POSITION;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnRIGHT_PROBE_BED_POSITION;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnLEFT_PROBE_BED_POSITION;
        private System.Windows.Forms.GroupBox grpBxEnableFadeHeight;
        private System.Windows.Forms.Label lblFadeHeight;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENABLE_LEVELING_FADE_HEIGHT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxDEBUG_LEVELING_FEATURE;
        private System.Windows.Forms.TabPage tabPageLcdBedLeveling;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnLCD_PROBE_Z_RANGE;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueMBL_Z_STEP;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxLCD_BED_LEVELING;
        private System.Windows.Forms.TabPage tabPageEEPROM;
        private System.Windows.Forms.TabPage tabPagePreHeat;
        private System.Windows.Forms.TabPage tabPageNozzlePark;
        private System.Windows.Forms.TabPage tabPageJob;
        private System.Windows.Forms.TabPage tabPageLCD;
        private System.Windows.Forms.TabPage tabPageSD;
        private System.Windows.Forms.TabPage tabPageExtra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStripConfiguration;
        private System.Windows.Forms.ToolStripButton toolStripButtonDownload;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrevious;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxM100_FREE_MEMORY_WATCHER;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnDEFAULT_KEEPALIVE_INTERVAL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxHOST_KEEPALIVE_FEATURE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxEEPROM_CHITCHAT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxEEPROM_SETTINGS;
        private System.Windows.Forms.GroupBox groupBoxPreHeat2;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPREHEAT_2_FAN_SPEED;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPREHEAT_2_TEMP_HOTEND;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPREHEAT_2_TEMP_BED;
        private System.Windows.Forms.GroupBox groupBoxPreHeat1;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPREHEAT_1_FAN_SPEED;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPREHEAT_1_TEMP_HOTEND;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnPREHEAT_1_TEMP_BED;
        private System.Windows.Forms.GroupBox groupBoxNozzleCleanFeature;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueNOZZLE_CLEAN_CIRCLE_MIDDLE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDn2;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDn1;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueNOZZLE_CLEAN_END_POINT;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueNOZZLE_CLEAN_START_POINT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxNOZZLE_CLEAN_FEATURE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnNOZZLE_CLEAN_TRIANGLES;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnNOZZLE_CLEAN_STROKES;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValue1;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxNOZZLE_PARK_FEATURE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxNOZZLE_CLEAN_GOBACK;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPRINTCOUNTER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPRINTJOB_TIMER_AUTOSTART;
        private System.Windows.Forms.GroupBox groupBoxMenuOptions;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueLCD_FEEDBACK_FREQUENCY_HZ;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueLCD_FEEDBACK_FREQUENCY_DURATION_MS;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSPEAKER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxINDIVIDUAL_AXIS_HOMING_MENU;
        private System.Windows.Forms.GroupBox groupBoxEncoder;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxREVERSE_MENU_DIRECTION;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxREVERSE_ENCODER_DIRECTION;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueENCODER_STEPS_PER_MENU_ITEM;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueENCODER_PULSES_PER_STEP;
        private System.Windows.Forms.GroupBox groupBoxLcdType;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxMINIPANEL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxREPRAP_DISCOUNT_FULL_GRAPHIC_SMART_CONTROLLER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxG3D_PANEL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxREPRAP_DISCOUNT_SMART_CONTROLLER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxELB_FULL_GRAPHIC_CONTROLLER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxminiVIKI;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxVIKI2;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxREPRAPWORLD_GRAPHICAL_LCD;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxMAKRPANEL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPANEL_ONE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxCARTESIO_UI;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxULTIPANEL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxULTIMAKERCONTROLLER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxDOGLCD;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxULTRA_LCD;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxDISPLAY_CHARSET_HD44780;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBoxLCD_LANGUAGE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSD_CHECK_AND_RETRY;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSDSUPPORT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxU8GLIB_SSD1306;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxLCD_I2C_VIKI;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxLCD_I2C_PANELOLU2;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxLCM1602;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxLCD_I2C_SAINSMART_YWROBOT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxRA_CONTROL_PANEL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxBQ_LCD_SMART_CONTROLLER;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxRIGIDBOT_PANEL;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxREPRAPWORLD_KEYPAD;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxOLED_PANEL_TINYBOY2;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSAV_3DLCD;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxU8GLIB_SH1106;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSAV_3DGLCD;
        private System.Windows.Forms.GroupBox groupBoxRGB_Led;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxPRINTER_EVENT_LEDS;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnRGB_LED_W_PIN;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnRGB_LED_B_PIN;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnRGB_LED_G_PIN;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnRGB_LED_R_PIN;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxRGB_LED;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxRGBW_LED;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxBLINKM;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxBARICUDA;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSF_ARC_FIX;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValuePHOTOGRAPH_PIN;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxTEMP_STAT_LEDS;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxSOFT_PWM_DITHER;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnSOFT_PWM_SCALE;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxFAST_PWM_FAN;
        private System.Windows.Forms.TabPage tabPageServo;
        private Marlin3DprinterToolUserControls.MarlinEnableValue marlinEnableValueNUM_SERVOS;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxDEACTIVATE_SERVOS_AFTER_MOVE;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnSERVO_DELAY;
        private System.Windows.Forms.TabPage tabPageFilamentWidthSensor;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxFILAMENT_LCD_DISPLAY;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueDEFAULT_MEASURED_FILAMENT_DIA;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDn4;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueMEASURED_LOWER_LIMIT;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueMEASURED_UPPER_LIMIT;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDn3;
        private Marlin3DprinterToolUserControls.MarlinUpDn marlinUpDnFILAMENT_SENSOR_EXTRUDER_NUM;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonArduinoIDE;
        private Marlin3DprinterToolUserControls.MarlinValue marlinValueFILAMENT_RUNOUT_SCRIPT;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxENDSTOPPULLUP_FIL_RUNOUT;
        private Marlin3DprinterToolUserControls.MarlinComboBox marlinComboBox1;
        private Marlin3DprinterToolUserControls.MarlinCheckBox marlinCheckBoxFILAMENT_RUNOUT_SENSOR;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPayPal;
    }
}

