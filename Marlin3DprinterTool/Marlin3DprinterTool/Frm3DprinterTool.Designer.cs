using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FastColoredTextBoxNS;
using LedBulbUserControl;
using Marlin3DprinterToolUserControls;
using MarlinComunicationHelper;

namespace Marlin3DprinterTool
{
    partial class FrmMarlin3DprinterTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            
            //TODO: Detta är fel i AGauge
            try
            {
                base.Dispose(disposing);
            }
            catch (Exception)
            {
                
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarlin3DprinterTool));
            Marlin3DprinterToolConfiguration.Position position1 = new Marlin3DprinterToolConfiguration.Position();
            Marlin3DprinterToolConfiguration.Position position2 = new Marlin3DprinterToolConfiguration.Position();
            Marlin3DprinterToolConfiguration.Position position3 = new Marlin3DprinterToolConfiguration.Position();
            Marlin3DprinterToolConfiguration.Position position4 = new Marlin3DprinterToolConfiguration.Position();
            Marlin3DprinterToolConfiguration.Position position5 = new Marlin3DprinterToolConfiguration.Position();
            Marlin3DprinterToolConfiguration.Position position6 = new Marlin3DprinterToolConfiguration.Position();
            Marlin3DprinterToolConfiguration.Position position7 = new Marlin3DprinterToolConfiguration.Position();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl3DprinterTool = new System.Windows.Forms.TabControl();
            this.tabPageEndstop = new System.Windows.Forms.TabPage();
            this.grpBxZ = new System.Windows.Forms.GroupBox();
            this.ledZmax = new LedBulbUserControl.LedBulb();
            this.ledZmin = new LedBulbUserControl.LedBulb();
            this.lblZmax = new System.Windows.Forms.Label();
            this.lblZmin = new System.Windows.Forms.Label();
            this.grpBxY = new System.Windows.Forms.GroupBox();
            this.ledYmax = new LedBulbUserControl.LedBulb();
            this.ledYmin = new LedBulbUserControl.LedBulb();
            this.lblYmax = new System.Windows.Forms.Label();
            this.lblYmin = new System.Windows.Forms.Label();
            this.grpBxX = new System.Windows.Forms.GroupBox();
            this.ledXmax = new LedBulbUserControl.LedBulb();
            this.ledXmin = new LedBulbUserControl.LedBulb();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblXmin = new System.Windows.Forms.Label();
            this.tabPageZoffset = new System.Windows.Forms.TabPage();
            this.grpBxM48Test = new System.Windows.Forms.GroupBox();
            this.lblNumberOfM48Test = new System.Windows.Forms.Label();
            this.trackBarNumberOfM48Test = new System.Windows.Forms.TrackBar();
            this.btnM48Test = new System.Windows.Forms.Button();
            this.fctbM48Test = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grpBxZextraDistance = new System.Windows.Forms.GroupBox();
            this.lblZextraDistance = new System.Windows.Forms.Label();
            this.txtBxZextraDistance = new System.Windows.Forms.TextBox();
            this.txtBxZextraDistanceInstruct = new System.Windows.Forms.TextBox();
            this.grpBxMeassureUsingProbe = new System.Windows.Forms.GroupBox();
            this.ledBulbZprobeGauge = new LedBulbUserControl.LedBulb();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnM851 = new System.Windows.Forms.Button();
            this.txtBxM851 = new System.Windows.Forms.TextBox();
            this.lblM851 = new System.Windows.Forms.Label();
            this.btnNozzleIsTouchingBed = new System.Windows.Forms.Button();
            this.txtBxZprobePosition = new System.Windows.Forms.TextBox();
            this.btnProbeDown = new System.Windows.Forms.Button();
            this.txtBxDockZprobe = new System.Windows.Forms.TextBox();
            this.btnProbeUp = new System.Windows.Forms.Button();
            this.btnDockZprobe = new System.Windows.Forms.Button();
            this.aGaugeProbe = new System.Windows.Forms.AGauge();
            this.grpBxZprobeXoffset = new System.Windows.Forms.GroupBox();
            this.pictureWorkInProgressZprobe = new System.Windows.Forms.PictureBox();
            this.txtBxZprobeYoffset = new System.Windows.Forms.TextBox();
            this.txtBxZprobeXoffset = new System.Windows.Forms.TextBox();
            this.cmbBxZprobeYoffset = new System.Windows.Forms.ComboBox();
            this.lblZprobeYoffsetmm = new System.Windows.Forms.Label();
            this.lblZprobeYoffset = new System.Windows.Forms.Label();
            this.cmbBxZprobeXoffset = new System.Windows.Forms.ComboBox();
            this.lblZprobeXoffsetmm = new System.Windows.Forms.Label();
            this.lblZprobeXoffset = new System.Windows.Forms.Label();
            this.tabPageConfigurationBed = new System.Windows.Forms.TabPage();
            this.panelConfigurationBedTab = new System.Windows.Forms.Panel();
            this.btnProbeTheBed = new System.Windows.Forms.Button();
            this.panelBed = new System.Windows.Forms.Panel();
            this.bedCornerControlFrontRight = new Marlin3DprinterToolUserControls.BedCorner();
            this.bedCornerControlFrontLeft = new Marlin3DprinterToolUserControls.BedCorner();
            this.bedAdjusterLeftSingle = new Marlin3DprinterToolUserControls.BedAdjuster();
            this.bedCornerControlBackRight = new Marlin3DprinterToolUserControls.BedCorner();
            this.bedAdjusterFrontSingle = new Marlin3DprinterToolUserControls.BedAdjuster();
            this.bedCornerControlBackLeft = new Marlin3DprinterToolUserControls.BedCorner();
            this.bedAdjusterRightSingle = new Marlin3DprinterToolUserControls.BedAdjuster();
            this.bedAdjusterBackRight = new Marlin3DprinterToolUserControls.BedAdjuster();
            this.bedAdjusterFrontRight = new Marlin3DprinterToolUserControls.BedAdjuster();
            this.bedAdjusterFrontLeft = new Marlin3DprinterToolUserControls.BedAdjuster();
            this.bedCornerControlSafeHome = new Marlin3DprinterToolUserControls.BedCorner();
            this.bedAdjusterBackLeft = new Marlin3DprinterToolUserControls.BedAdjuster();
            this.grpBxAdjusters = new System.Windows.Forms.GroupBox();
            this.rdoBn3pointFront = new System.Windows.Forms.RadioButton();
            this.chkListBxAdjustment = new System.Windows.Forms.CheckedListBox();
            this.rdoBn3pointRight = new System.Windows.Forms.RadioButton();
            this.rdoBn3pointLeft = new System.Windows.Forms.RadioButton();
            this.rdoBn4point = new System.Windows.Forms.RadioButton();
            this.tabPageConfigurationZprobe = new System.Windows.Forms.TabPage();
            this.grpBxBlTouch = new System.Windows.Forms.GroupBox();
            this.picBxApprovedByBLTouch = new System.Windows.Forms.PictureBox();
            this.btnBlTouchSave = new System.Windows.Forms.Button();
            this.btnBlTouchRelease = new System.Windows.Forms.Button();
            this.btnBlTouchEngage = new System.Windows.Forms.Button();
            this.btnBlTouchResetAlarm = new System.Windows.Forms.Button();
            this.btnBlTouchSelftest = new System.Windows.Forms.Button();
            this.chkBxBlTouch = new System.Windows.Forms.CheckBox();
            this.grpAutoBedLevel = new System.Windows.Forms.GroupBox();
            this.fctbAutoBedLevelResponce = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnAutoBedLevel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTestZprobeRelease = new System.Windows.Forms.Button();
            this.btnTestZprobeReleaseSave = new System.Windows.Forms.Button();
            this.txtBxGcodeAssistZprobeRelease = new System.Windows.Forms.TextBox();
            this.grpBxEngageZprobe = new System.Windows.Forms.GroupBox();
            this.btnTestZprobeEngage = new System.Windows.Forms.Button();
            this.btnTestZprobeEngageSave = new System.Windows.Forms.Button();
            this.txtBxGcodeAssistZprobeEngage = new System.Windows.Forms.TextBox();
            this.tabPageScanSurface = new System.Windows.Forms.TabPage();
            this.nChartControlSurface = new Nevron.Chart.WinForm.NChartControl();
            this.btnResetSurfaceChart = new System.Windows.Forms.Button();
            this.numUpDownNumberOfRepetitions = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfRepetitions = new System.Windows.Forms.Label();
            this.lblYpoints = new System.Windows.Forms.Label();
            this.lblXpoints = new System.Windows.Forms.Label();
            this.btnScanSurface = new System.Windows.Forms.Button();
            this.numUpDownYpoints = new System.Windows.Forms.NumericUpDown();
            this.numUpDownXpoints = new System.Windows.Forms.NumericUpDown();
            this.tabPagePID = new System.Windows.Forms.TabPage();
            this.fctbPidResponce = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grpBxHeatbedPID = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtBxKdBed = new System.Windows.Forms.TextBox();
            this.txtBxKiBed = new System.Windows.Forms.TextBox();
            this.txtBxKpBed = new System.Windows.Forms.TextBox();
            this.btnUpdateBedPid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateBedPid = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numUpDownPidBedCykles = new System.Windows.Forms.NumericUpDown();
            this.trkBarPidBedCykles = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.trkBarPidBedTemp = new System.Windows.Forms.TrackBar();
            this.numUpDownPidBedTemp = new System.Windows.Forms.NumericUpDown();
            this.grpBxExtruderPID = new System.Windows.Forms.GroupBox();
            this.cmbBxPidExtruder = new System.Windows.Forms.ComboBox();
            this.grpBxPidExtruder = new System.Windows.Forms.GroupBox();
            this.txtBxKdExtruder = new System.Windows.Forms.TextBox();
            this.txtBxKiExtruder = new System.Windows.Forms.TextBox();
            this.txtBxKpExtruder = new System.Windows.Forms.TextBox();
            this.lblKdExtruder = new System.Windows.Forms.Label();
            this.btnUpdateExtruderPid = new System.Windows.Forms.Button();
            this.lblKiExtruder = new System.Windows.Forms.Label();
            this.lblKpExtruder = new System.Windows.Forms.Label();
            this.grpBxPidExtruderTemp = new System.Windows.Forms.GroupBox();
            this.trkBarPidExtruderTemp = new System.Windows.Forms.TrackBar();
            this.numUpDownPidExtruderTemp = new System.Windows.Forms.NumericUpDown();
            this.grpBxPidExtruderCykles = new System.Windows.Forms.GroupBox();
            this.numUpDownPidExtruderCykles = new System.Windows.Forms.NumericUpDown();
            this.trkBarPidExtruderCykles = new System.Windows.Forms.TrackBar();
            this.btnCalculateExtruderPid = new System.Windows.Forms.Button();
            this.tabPageExtruderCalibration = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBxExtruderCalibration = new System.Windows.Forms.ComboBox();
            this.chkBxColdExtruderCalibration = new System.Windows.Forms.CheckBox();
            this.numUpDnCalibrateExtruderTemp = new System.Windows.Forms.NumericUpDown();
            this.btnHeatExtruderForCalibration = new System.Windows.Forms.Button();
            this.trkBarTemperature = new System.Windows.Forms.TrackBar();
            this.grpBxTestExtrude = new System.Windows.Forms.GroupBox();
            this.txtBxCurrentStepsPermm = new System.Windows.Forms.TextBox();
            this.lblExtrude = new System.Windows.Forms.Label();
            this.lblMeassure = new System.Windows.Forms.Label();
            this.numUpDnMeassure = new System.Windows.Forms.NumericUpDown();
            this.btnExtruderCalibation = new System.Windows.Forms.Button();
            this.btnExtruderCalibrationCalculate = new System.Windows.Forms.Button();
            this.lblCurrentStepsPermm = new System.Windows.Forms.Label();
            this.numUpDnExtrude = new System.Windows.Forms.NumericUpDown();
            this.tabPageZMaintenance = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grpBxZMaintenance = new System.Windows.Forms.GroupBox();
            this.txtBxZmaintenanceDescription = new System.Windows.Forms.TextBox();
            this.grpZprobeConfigMax = new System.Windows.Forms.GroupBox();
            this.lblZmaxTravel = new System.Windows.Forms.Label();
            this.btnZmaxTravel = new System.Windows.Forms.Button();
            this.numUpDnZmaxTravel = new System.Windows.Forms.NumericUpDown();
            this.trkBrZmaxTravel = new System.Windows.Forms.TrackBar();
            this.btnZmaintenanceRun = new System.Windows.Forms.Button();
            this.btnZmaintenanceCancel = new System.Windows.Forms.Button();
            this.grpBxZmaintMax = new System.Windows.Forms.GroupBox();
            this.trackBarZmaintenanceMin = new System.Windows.Forms.TrackBar();
            this.trackBarZmaintenanceMax = new System.Windows.Forms.TrackBar();
            this.lblZmaintenanceRepetitions = new System.Windows.Forms.Label();
            this.numUpDnZmaintenanceRepetitions = new System.Windows.Forms.NumericUpDown();
            this.bindingControl = new Marlin3DprinterToolUserControls.BindingControl();
            this.tabPageCalculations = new System.Windows.Forms.TabPage();
            this.grpBxFeedRate = new System.Windows.Forms.GroupBox();
            this.numUpDnFeedRateMMperMinute = new System.Windows.Forms.NumericUpDown();
            this.lblFeedRateMMperMinute = new System.Windows.Forms.Label();
            this.lblFeedRateMMperSecund = new System.Windows.Forms.Label();
            this.numUpDnFeedRateMMperSecund = new System.Windows.Forms.NumericUpDown();
            this.grpBxExtruderCalculation = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExtruderUpdateStepsPerMMinEEPROM = new System.Windows.Forms.Button();
            this.lblExtruderOldFirmware = new System.Windows.Forms.Label();
            this.numUpDnExtruderOldFirmware = new System.Windows.Forms.NumericUpDown();
            this.numUpDnExtruderMeassuredExtrusion = new System.Windows.Forms.NumericUpDown();
            this.lblExtruderMeassuredValue = new System.Windows.Forms.Label();
            this.lblExtruderExpectedValue = new System.Windows.Forms.Label();
            this.numUpDnExtruderExpectedValue = new System.Windows.Forms.NumericUpDown();
            this.fastColoredTextBoxExtruderStepsPerMM = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grpBxBelts = new System.Windows.Forms.GroupBox();
            this.numUpDnBeltPulleyTeethCount = new System.Windows.Forms.NumericUpDown();
            this.lblBeltPulleyTeethCount = new System.Windows.Forms.Label();
            this.cmbBxBeltPitch = new System.Windows.Forms.ComboBox();
            this.lblBeltPitch = new System.Windows.Forms.Label();
            this.fastColoredTextBoxBeltStepsPerMM = new FastColoredTextBoxNS.FastColoredTextBox();
            this.numUpDnBeltTeethCount = new System.Windows.Forms.NumericUpDown();
            this.lblBeltTeethCount = new System.Windows.Forms.Label();
            this.numUpDnBeltMotorTeethCount = new System.Windows.Forms.NumericUpDown();
            this.chkBxBeltDirectDriven = new System.Windows.Forms.CheckBox();
            this.lblBeltMotorTeethCount = new System.Windows.Forms.Label();
            this.cmbBxBeltDriverMicrostepping = new System.Windows.Forms.ComboBox();
            this.lblBeltDriverMicrostepping = new System.Windows.Forms.Label();
            this.cmbBxBeltMotorStepAngle = new System.Windows.Forms.ComboBox();
            this.lblBeltMotorStepAngle = new System.Windows.Forms.Label();
            this.grpBxLeadScrew = new System.Windows.Forms.GroupBox();
            this.cmbBxLeadScrewPitch = new System.Windows.Forms.ComboBox();
            this.lblLeadScrewPitch = new System.Windows.Forms.Label();
            this.fastColoredTextBoxLeadScrewStepsPerMM = new FastColoredTextBoxNS.FastColoredTextBox();
            this.numUpDnLeadScrewTeethCount = new System.Windows.Forms.NumericUpDown();
            this.lblLeadscrewTeethCount = new System.Windows.Forms.Label();
            this.numUpDnLeadScrewMotorTeethCount = new System.Windows.Forms.NumericUpDown();
            this.chkBxLeadScrewDirectDriven = new System.Windows.Forms.CheckBox();
            this.lblLeadScrewMotorTeethCount = new System.Windows.Forms.Label();
            this.cmbBxLeadScrewDriverMicrostepping = new System.Windows.Forms.ComboBox();
            this.lblLeadScrewDriverMicrostepping = new System.Windows.Forms.Label();
            this.cmbBxLeadScrewMotorStepAngle = new System.Windows.Forms.ComboBox();
            this.lblLeadScrewMotorStepAngle = new System.Windows.Forms.Label();
            this.tabPageParameters = new System.Windows.Forms.TabPage();
            this.btnResetFactorySettings = new System.Windows.Forms.Button();
            this.btnM501ReadEeprom = new System.Windows.Forms.Button();
            this.grpMeshBedLevel = new System.Windows.Forms.GroupBox();
            this.btnShowMeshInSurfaceChart = new System.Windows.Forms.Button();
            this.txtBxMeshBedLevelPointY = new System.Windows.Forms.TextBox();
            this.txtBxMeshBedLevelPointX = new System.Windows.Forms.TextBox();
            this.lblMeshBedLevelPointY = new System.Windows.Forms.Label();
            this.lblMeshBedLevelPointX = new System.Windows.Forms.Label();
            this.btnM500SaveEeprom = new System.Windows.Forms.Button();
            this.grpPidBed = new System.Windows.Forms.GroupBox();
            this.btnPidBedParameters = new System.Windows.Forms.Button();
            this.lblBedKd = new System.Windows.Forms.Label();
            this.lblBedKi = new System.Windows.Forms.Label();
            this.txtBxBedKd = new System.Windows.Forms.TextBox();
            this.txtBxBedKi = new System.Windows.Forms.TextBox();
            this.txtBxBedKp = new System.Windows.Forms.TextBox();
            this.lblBedKp = new System.Windows.Forms.Label();
            this.grpPidExtruder = new System.Windows.Forms.GroupBox();
            this.btnPidExtruderParameters = new System.Windows.Forms.Button();
            this.lblPidExtruderKd = new System.Windows.Forms.Label();
            this.lblPidExtruderKi = new System.Windows.Forms.Label();
            this.txtBxPidExtruderKd = new System.Windows.Forms.TextBox();
            this.txtBxPidExtruderKi = new System.Windows.Forms.TextBox();
            this.txtBxPidExtruderKp = new System.Windows.Forms.TextBox();
            this.lblPidExtruderKp = new System.Windows.Forms.Label();
            this.grpHomeOffset = new System.Windows.Forms.GroupBox();
            this.btnHomeOffsetParameters = new System.Windows.Forms.Button();
            this.lblHomeOffsetZ = new System.Windows.Forms.Label();
            this.lblHomeOffsetY = new System.Windows.Forms.Label();
            this.txtBxHomeOffsetZ = new System.Windows.Forms.TextBox();
            this.txtBxHomeOffsetY = new System.Windows.Forms.TextBox();
            this.txtBxHomeOffsetX = new System.Windows.Forms.TextBox();
            this.lblHomeOffsetX = new System.Windows.Forms.Label();
            this.grpBxAcceleration = new System.Windows.Forms.GroupBox();
            this.btnM204paremeters = new System.Windows.Forms.Button();
            this.lblBxAccelerationTravel = new System.Windows.Forms.Label();
            this.lblBxAccelerationRetract = new System.Windows.Forms.Label();
            this.txtBxAccelerationTravel = new System.Windows.Forms.TextBox();
            this.txtBxAccelerationRetract = new System.Windows.Forms.TextBox();
            this.txtBxAccelerationPrint = new System.Windows.Forms.TextBox();
            this.lblBxAccelerationPrint = new System.Windows.Forms.Label();
            this.grpBxMaxAccelation = new System.Windows.Forms.GroupBox();
            this.btnM201paremeters = new System.Windows.Forms.Button();
            this.lblMaxAccelationE = new System.Windows.Forms.Label();
            this.lblMaxAccelationZ = new System.Windows.Forms.Label();
            this.lblMaxAccelationY = new System.Windows.Forms.Label();
            this.txtBxMaxAccelationE = new System.Windows.Forms.TextBox();
            this.txtBxMaxAccelationZ = new System.Windows.Forms.TextBox();
            this.txtBxMaxAccelationY = new System.Windows.Forms.TextBox();
            this.txtBxMaxAccelationX = new System.Windows.Forms.TextBox();
            this.lblMaxAccelationX = new System.Windows.Forms.Label();
            this.grpBxMaxFeedrate = new System.Windows.Forms.GroupBox();
            this.btnM203parameters = new System.Windows.Forms.Button();
            this.lblMaxFeedRateE = new System.Windows.Forms.Label();
            this.lblMaxFeedRateZ = new System.Windows.Forms.Label();
            this.lblMaxFeedRateY = new System.Windows.Forms.Label();
            this.txtBxMaxFeedRateE = new System.Windows.Forms.TextBox();
            this.txtBxMaxFeedRateZ = new System.Windows.Forms.TextBox();
            this.txtBxMaxFeedRateY = new System.Windows.Forms.TextBox();
            this.txtBxMaxFeedRateX = new System.Windows.Forms.TextBox();
            this.lblMaxFeedRateX = new System.Windows.Forms.Label();
            this.grpBxStepsPerUnit = new System.Windows.Forms.GroupBox();
            this.btnM92paremeters = new System.Windows.Forms.Button();
            this.lblStepsPerUnitE = new System.Windows.Forms.Label();
            this.lblStepsPerUnitZ = new System.Windows.Forms.Label();
            this.lblStepsPerUnitY = new System.Windows.Forms.Label();
            this.txtBxStepsPerUnitE = new System.Windows.Forms.TextBox();
            this.txtBxStepsPerUnitZ = new System.Windows.Forms.TextBox();
            this.txtBxStepsPerUnitY = new System.Windows.Forms.TextBox();
            this.txtBxStepsPerUnitX = new System.Windows.Forms.TextBox();
            this.lblStepsPerUnitX = new System.Windows.Forms.Label();
            this.fctbInit = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grpBxNavigation = new System.Windows.Forms.GroupBox();
            this.btnRetractZprobe = new System.Windows.Forms.Button();
            this.kompass = new Marlin3DprinterToolUserControls.Kompass();
            this.btnEngageZprobe = new System.Windows.Forms.Button();
            this.grpBxBed = new System.Windows.Forms.Button();
            this.btnHomeY = new System.Windows.Forms.Button();
            this.btnHomeX = new System.Windows.Forms.Button();
            this.verticalJogZprobeHeight = new Marlin3DprinterToolUserControls.VerticalJog();
            this.btnOpenMarlin = new System.Windows.Forms.Button();
            this.btnSaveArduinoIDE = new System.Windows.Forms.Button();
            this.txtBxArduinoIDE = new System.Windows.Forms.TextBox();
            this.lblStepperDriverPulley = new System.Windows.Forms.GroupBox();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnShowCommunication = new System.Windows.Forms.Button();
            this.cmbBxComPort = new System.Windows.Forms.ComboBox();
            this.cmbBxBaud = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.toolTip3DprinterTool = new System.Windows.Forms.ToolTip(this.components);
            this.txtBxCurrentBedSet = new System.Windows.Forms.TextBox();
            this.txtBxCurrentBedTemp = new System.Windows.Forms.TextBox();
            this.txtBxCurrentExtruder2Set = new System.Windows.Forms.TextBox();
            this.txtBxCurrentExtruder2Temp = new System.Windows.Forms.TextBox();
            this.txtBxCurrentExtruder1Set = new System.Windows.Forms.TextBox();
            this.txtBxCurrentExtruder1Temp = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpBxTemperature = new System.Windows.Forms.GroupBox();
            this.btnGetTemp = new System.Windows.Forms.Button();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnFirmware = new System.Windows.Forms.Button();
            this.timerEndstop = new System.Windows.Forms.Timer(this.components);
            this.btnPayPal = new System.Windows.Forms.Button();
            this.tabControl3DprinterTool.SuspendLayout();
            this.tabPageEndstop.SuspendLayout();
            this.grpBxZ.SuspendLayout();
            this.grpBxY.SuspendLayout();
            this.grpBxX.SuspendLayout();
            this.tabPageZoffset.SuspendLayout();
            this.grpBxM48Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumberOfM48Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbM48Test)).BeginInit();
            this.grpBxZextraDistance.SuspendLayout();
            this.grpBxMeassureUsingProbe.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.grpBxZprobeXoffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWorkInProgressZprobe)).BeginInit();
            this.tabPageConfigurationBed.SuspendLayout();
            this.panelConfigurationBedTab.SuspendLayout();
            this.panelBed.SuspendLayout();
            this.grpBxAdjusters.SuspendLayout();
            this.tabPageConfigurationZprobe.SuspendLayout();
            this.grpBxBlTouch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxApprovedByBLTouch)).BeginInit();
            this.grpAutoBedLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbAutoBedLevelResponce)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpBxEngageZprobe.SuspendLayout();
            this.tabPageScanSurface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumberOfRepetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYpoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownXpoints)).BeginInit();
            this.tabPagePID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbPidResponce)).BeginInit();
            this.grpBxHeatbedPID.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidBedCykles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidBedCykles)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidBedTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidBedTemp)).BeginInit();
            this.grpBxExtruderPID.SuspendLayout();
            this.grpBxPidExtruder.SuspendLayout();
            this.grpBxPidExtruderTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidExtruderTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidExtruderTemp)).BeginInit();
            this.grpBxPidExtruderCykles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidExtruderCykles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidExtruderCykles)).BeginInit();
            this.tabPageExtruderCalibration.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCalibrateExtruderTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarTemperature)).BeginInit();
            this.grpBxTestExtrude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMeassure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtrude)).BeginInit();
            this.tabPageZMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.grpBxZMaintenance.SuspendLayout();
            this.grpZprobeConfigMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaxTravel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrZmaxTravel)).BeginInit();
            this.grpBxZmaintMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaintenanceRepetitions)).BeginInit();
            this.tabPageCalculations.SuspendLayout();
            this.grpBxFeedRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperSecund)).BeginInit();
            this.grpBxExtruderCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtruderOldFirmware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtruderMeassuredExtrusion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtruderExpectedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxExtruderStepsPerMM)).BeginInit();
            this.grpBxBelts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBeltPulleyTeethCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxBeltStepsPerMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBeltTeethCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBeltMotorTeethCount)).BeginInit();
            this.grpBxLeadScrew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxLeadScrewStepsPerMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLeadScrewTeethCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLeadScrewMotorTeethCount)).BeginInit();
            this.tabPageParameters.SuspendLayout();
            this.grpMeshBedLevel.SuspendLayout();
            this.grpPidBed.SuspendLayout();
            this.grpPidExtruder.SuspendLayout();
            this.grpHomeOffset.SuspendLayout();
            this.grpBxAcceleration.SuspendLayout();
            this.grpBxMaxAccelation.SuspendLayout();
            this.grpBxMaxFeedrate.SuspendLayout();
            this.grpBxStepsPerUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbInit)).BeginInit();
            this.grpBxNavigation.SuspendLayout();
            this.lblStepperDriverPulley.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpBxTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl3DprinterTool
            // 
            this.tabControl3DprinterTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3DprinterTool.Controls.Add(this.tabPageEndstop);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageZoffset);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageConfigurationBed);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageConfigurationZprobe);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageScanSurface);
            this.tabControl3DprinterTool.Controls.Add(this.tabPagePID);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageExtruderCalibration);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageZMaintenance);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageCalculations);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageParameters);
            this.tabControl3DprinterTool.Location = new System.Drawing.Point(3, 3);
            this.tabControl3DprinterTool.Multiline = true;
            this.tabControl3DprinterTool.Name = "tabControl3DprinterTool";
            this.tabControl3DprinterTool.SelectedIndex = 0;
            this.tabControl3DprinterTool.Size = new System.Drawing.Size(660, 620);
            this.tabControl3DprinterTool.TabIndex = 0;
            this.tabControl3DprinterTool.SelectedIndexChanged += new System.EventHandler(this.tabControl3DprinterTool_SelectedIndexChanged);
            // 
            // tabPageEndstop
            // 
            this.tabPageEndstop.Controls.Add(this.grpBxZ);
            this.tabPageEndstop.Controls.Add(this.grpBxY);
            this.tabPageEndstop.Controls.Add(this.grpBxX);
            this.tabPageEndstop.Location = new System.Drawing.Point(4, 40);
            this.tabPageEndstop.Name = "tabPageEndstop";
            this.tabPageEndstop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndstop.Size = new System.Drawing.Size(652, 576);
            this.tabPageEndstop.TabIndex = 0;
            this.tabPageEndstop.Text = "Endstop";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageEndstop, "Check the status of the Endstop(s)");
            this.tabPageEndstop.UseVisualStyleBackColor = true;
            this.tabPageEndstop.Click += new System.EventHandler(this.tabPageEndstop_Click);
            // 
            // grpBxZ
            // 
            this.grpBxZ.Controls.Add(this.ledZmax);
            this.grpBxZ.Controls.Add(this.ledZmin);
            this.grpBxZ.Controls.Add(this.lblZmax);
            this.grpBxZ.Controls.Add(this.lblZmin);
            this.grpBxZ.Location = new System.Drawing.Point(445, 9);
            this.grpBxZ.Name = "grpBxZ";
            this.grpBxZ.Size = new System.Drawing.Size(198, 569);
            this.grpBxZ.TabIndex = 2;
            this.grpBxZ.TabStop = false;
            this.grpBxZ.Text = "Z";
            this.grpBxZ.Enter += new System.EventHandler(this.grpBxZ_Enter);
            // 
            // ledZmax
            // 
            this.ledZmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledZmax.Location = new System.Drawing.Point(13, 387);
            this.ledZmax.Name = "ledZmax";
            this.ledZmax.On = false;
            this.ledZmax.Size = new System.Drawing.Size(179, 167);
            this.ledZmax.TabIndex = 7;
            // 
            // ledZmin
            // 
            this.ledZmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledZmin.Location = new System.Drawing.Point(13, 36);
            this.ledZmin.Name = "ledZmin";
            this.ledZmin.On = false;
            this.ledZmin.Size = new System.Drawing.Size(179, 167);
            this.ledZmin.TabIndex = 6;
            // 
            // lblZmax
            // 
            this.lblZmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZmax.AutoSize = true;
            this.lblZmax.Location = new System.Drawing.Point(10, 371);
            this.lblZmax.Name = "lblZmax";
            this.lblZmax.Size = new System.Drawing.Size(27, 13);
            this.lblZmax.TabIndex = 5;
            this.lblZmax.Text = "Max";
            // 
            // lblZmin
            // 
            this.lblZmin.AutoSize = true;
            this.lblZmin.Location = new System.Drawing.Point(10, 20);
            this.lblZmin.Name = "lblZmin";
            this.lblZmin.Size = new System.Drawing.Size(24, 13);
            this.lblZmin.TabIndex = 4;
            this.lblZmin.Text = "Min";
            // 
            // grpBxY
            // 
            this.grpBxY.Controls.Add(this.ledYmax);
            this.grpBxY.Controls.Add(this.ledYmin);
            this.grpBxY.Controls.Add(this.lblYmax);
            this.grpBxY.Controls.Add(this.lblYmin);
            this.grpBxY.Location = new System.Drawing.Point(228, 9);
            this.grpBxY.Name = "grpBxY";
            this.grpBxY.Size = new System.Drawing.Size(198, 569);
            this.grpBxY.TabIndex = 1;
            this.grpBxY.TabStop = false;
            this.grpBxY.Text = "Y";
            // 
            // ledYmax
            // 
            this.ledYmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledYmax.Location = new System.Drawing.Point(13, 387);
            this.ledYmax.Name = "ledYmax";
            this.ledYmax.On = false;
            this.ledYmax.Size = new System.Drawing.Size(179, 167);
            this.ledYmax.TabIndex = 5;
            // 
            // ledYmin
            // 
            this.ledYmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledYmin.Location = new System.Drawing.Point(13, 36);
            this.ledYmin.Name = "ledYmin";
            this.ledYmin.On = false;
            this.ledYmin.Size = new System.Drawing.Size(179, 167);
            this.ledYmin.TabIndex = 4;
            // 
            // lblYmax
            // 
            this.lblYmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYmax.AutoSize = true;
            this.lblYmax.Location = new System.Drawing.Point(10, 371);
            this.lblYmax.Name = "lblYmax";
            this.lblYmax.Size = new System.Drawing.Size(27, 13);
            this.lblYmax.TabIndex = 3;
            this.lblYmax.Text = "Max";
            // 
            // lblYmin
            // 
            this.lblYmin.AutoSize = true;
            this.lblYmin.Location = new System.Drawing.Point(10, 20);
            this.lblYmin.Name = "lblYmin";
            this.lblYmin.Size = new System.Drawing.Size(24, 13);
            this.lblYmin.TabIndex = 2;
            this.lblYmin.Text = "Min";
            // 
            // grpBxX
            // 
            this.grpBxX.Controls.Add(this.ledXmax);
            this.grpBxX.Controls.Add(this.ledXmin);
            this.grpBxX.Controls.Add(this.lblXmax);
            this.grpBxX.Controls.Add(this.lblXmin);
            this.grpBxX.Location = new System.Drawing.Point(11, 9);
            this.grpBxX.Name = "grpBxX";
            this.grpBxX.Size = new System.Drawing.Size(198, 569);
            this.grpBxX.TabIndex = 0;
            this.grpBxX.TabStop = false;
            this.grpBxX.Text = "X";
            // 
            // ledXmax
            // 
            this.ledXmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledXmax.Location = new System.Drawing.Point(13, 387);
            this.ledXmax.Name = "ledXmax";
            this.ledXmax.On = false;
            this.ledXmax.Size = new System.Drawing.Size(179, 167);
            this.ledXmax.TabIndex = 3;
            // 
            // ledXmin
            // 
            this.ledXmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledXmin.Location = new System.Drawing.Point(13, 36);
            this.ledXmin.Name = "ledXmin";
            this.ledXmin.On = false;
            this.ledXmin.Size = new System.Drawing.Size(179, 167);
            this.ledXmin.TabIndex = 2;
            // 
            // lblXmax
            // 
            this.lblXmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblXmax.AutoSize = true;
            this.lblXmax.Location = new System.Drawing.Point(10, 371);
            this.lblXmax.Name = "lblXmax";
            this.lblXmax.Size = new System.Drawing.Size(27, 13);
            this.lblXmax.TabIndex = 1;
            this.lblXmax.Text = "Max";
            // 
            // lblXmin
            // 
            this.lblXmin.AutoSize = true;
            this.lblXmin.Location = new System.Drawing.Point(10, 20);
            this.lblXmin.Name = "lblXmin";
            this.lblXmin.Size = new System.Drawing.Size(24, 13);
            this.lblXmin.TabIndex = 0;
            this.lblXmin.Text = "Min";
            // 
            // tabPageZoffset
            // 
            this.tabPageZoffset.Controls.Add(this.grpBxM48Test);
            this.tabPageZoffset.Controls.Add(this.grpBxZextraDistance);
            this.tabPageZoffset.Controls.Add(this.grpBxMeassureUsingProbe);
            this.tabPageZoffset.Controls.Add(this.grpBxZprobeXoffset);
            this.tabPageZoffset.Location = new System.Drawing.Point(4, 40);
            this.tabPageZoffset.Name = "tabPageZoffset";
            this.tabPageZoffset.Size = new System.Drawing.Size(652, 576);
            this.tabPageZoffset.TabIndex = 14;
            this.tabPageZoffset.Text = "Z Probe offset";
            this.tabPageZoffset.UseVisualStyleBackColor = true;
            // 
            // grpBxM48Test
            // 
            this.grpBxM48Test.Controls.Add(this.lblNumberOfM48Test);
            this.grpBxM48Test.Controls.Add(this.trackBarNumberOfM48Test);
            this.grpBxM48Test.Controls.Add(this.btnM48Test);
            this.grpBxM48Test.Controls.Add(this.fctbM48Test);
            this.grpBxM48Test.Location = new System.Drawing.Point(393, 12);
            this.grpBxM48Test.Name = "grpBxM48Test";
            this.grpBxM48Test.Size = new System.Drawing.Size(260, 545);
            this.grpBxM48Test.TabIndex = 55;
            this.grpBxM48Test.TabStop = false;
            this.grpBxM48Test.Text = "Testing Z Probe";
            // 
            // lblNumberOfM48Test
            // 
            this.lblNumberOfM48Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberOfM48Test.AutoSize = true;
            this.lblNumberOfM48Test.Location = new System.Drawing.Point(8, 55);
            this.lblNumberOfM48Test.Name = "lblNumberOfM48Test";
            this.lblNumberOfM48Test.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfM48Test.TabIndex = 21;
            this.lblNumberOfM48Test.Text = "Perform 4 test(s)";
            // 
            // trackBarNumberOfM48Test
            // 
            this.trackBarNumberOfM48Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarNumberOfM48Test.Location = new System.Drawing.Point(11, 70);
            this.trackBarNumberOfM48Test.Maximum = 50;
            this.trackBarNumberOfM48Test.Minimum = 4;
            this.trackBarNumberOfM48Test.Name = "trackBarNumberOfM48Test";
            this.trackBarNumberOfM48Test.Size = new System.Drawing.Size(243, 45);
            this.trackBarNumberOfM48Test.TabIndex = 20;
            this.trackBarNumberOfM48Test.Value = 4;
            this.trackBarNumberOfM48Test.Scroll += new System.EventHandler(this.trackBarNumberOfM48Test_Scroll);
            // 
            // btnM48Test
            // 
            this.btnM48Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnM48Test.Location = new System.Drawing.Point(11, 19);
            this.btnM48Test.Name = "btnM48Test";
            this.btnM48Test.Size = new System.Drawing.Size(243, 32);
            this.btnM48Test.TabIndex = 19;
            this.btnM48Test.Text = " Measure Z-Probe repeatability (M48)";
            this.btnM48Test.UseVisualStyleBackColor = true;
            this.btnM48Test.Click += new System.EventHandler(this.btnM48Test_Click);
            // 
            // fctbM48Test
            // 
            this.fctbM48Test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbM48Test.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbM48Test.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctbM48Test.BackBrush = null;
            this.fctbM48Test.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctbM48Test.CharHeight = 14;
            this.fctbM48Test.CharWidth = 8;
            this.fctbM48Test.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbM48Test.DescriptionFile = "";
            this.fctbM48Test.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbM48Test.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbM48Test.IsReplaceMode = false;
            this.fctbM48Test.Location = new System.Drawing.Point(11, 125);
            this.fctbM48Test.Name = "fctbM48Test";
            this.fctbM48Test.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbM48Test.ReadOnly = true;
            this.fctbM48Test.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbM48Test.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbM48Test.ServiceColors")));
            this.fctbM48Test.ShowLineNumbers = false;
            this.fctbM48Test.Size = new System.Drawing.Size(243, 405);
            this.fctbM48Test.TabIndex = 18;
            this.fctbM48Test.Zoom = 100;
            // 
            // grpBxZextraDistance
            // 
            this.grpBxZextraDistance.Controls.Add(this.lblZextraDistance);
            this.grpBxZextraDistance.Controls.Add(this.txtBxZextraDistance);
            this.grpBxZextraDistance.Controls.Add(this.txtBxZextraDistanceInstruct);
            this.grpBxZextraDistance.Location = new System.Drawing.Point(6, 330);
            this.grpBxZextraDistance.Name = "grpBxZextraDistance";
            this.grpBxZextraDistance.Size = new System.Drawing.Size(380, 114);
            this.grpBxZextraDistance.TabIndex = 54;
            this.grpBxZextraDistance.TabStop = false;
            this.grpBxZextraDistance.Text = "Z Extra Distance";
            // 
            // lblZextraDistance
            // 
            this.lblZextraDistance.AutoSize = true;
            this.lblZextraDistance.Location = new System.Drawing.Point(15, 90);
            this.lblZextraDistance.Name = "lblZextraDistance";
            this.lblZextraDistance.Size = new System.Drawing.Size(202, 13);
            this.lblZextraDistance.TabIndex = 2;
            this.lblZextraDistance.Text = "Extra distanze when travel using Z-probe:";
            // 
            // txtBxZextraDistance
            // 
            this.txtBxZextraDistance.Location = new System.Drawing.Point(223, 87);
            this.txtBxZextraDistance.Name = "txtBxZextraDistance";
            this.txtBxZextraDistance.Size = new System.Drawing.Size(72, 20);
            this.txtBxZextraDistance.TabIndex = 1;
            this.txtBxZextraDistance.TextChanged += new System.EventHandler(this.txtBxZextraDistance_TextChanged);
            // 
            // txtBxZextraDistanceInstruct
            // 
            this.txtBxZextraDistanceInstruct.Location = new System.Drawing.Point(18, 28);
            this.txtBxZextraDistanceInstruct.Multiline = true;
            this.txtBxZextraDistanceInstruct.Name = "txtBxZextraDistanceInstruct";
            this.txtBxZextraDistanceInstruct.ReadOnly = true;
            this.txtBxZextraDistanceInstruct.Size = new System.Drawing.Size(349, 53);
            this.txtBxZextraDistanceInstruct.TabIndex = 0;
            this.txtBxZextraDistanceInstruct.Text = resources.GetString("txtBxZextraDistanceInstruct.Text");
            // 
            // grpBxMeassureUsingProbe
            // 
            this.grpBxMeassureUsingProbe.Controls.Add(this.ledBulbZprobeGauge);
            this.grpBxMeassureUsingProbe.Controls.Add(this.groupBox12);
            this.grpBxMeassureUsingProbe.Controls.Add(this.btnNozzleIsTouchingBed);
            this.grpBxMeassureUsingProbe.Controls.Add(this.txtBxZprobePosition);
            this.grpBxMeassureUsingProbe.Controls.Add(this.btnProbeDown);
            this.grpBxMeassureUsingProbe.Controls.Add(this.txtBxDockZprobe);
            this.grpBxMeassureUsingProbe.Controls.Add(this.btnProbeUp);
            this.grpBxMeassureUsingProbe.Controls.Add(this.btnDockZprobe);
            this.grpBxMeassureUsingProbe.Controls.Add(this.aGaugeProbe);
            this.grpBxMeassureUsingProbe.Location = new System.Drawing.Point(6, 12);
            this.grpBxMeassureUsingProbe.Name = "grpBxMeassureUsingProbe";
            this.grpBxMeassureUsingProbe.Size = new System.Drawing.Size(380, 312);
            this.grpBxMeassureUsingProbe.TabIndex = 25;
            this.grpBxMeassureUsingProbe.TabStop = false;
            this.grpBxMeassureUsingProbe.Text = "Meassure the bed using the Z-probe";
            // 
            // ledBulbZprobeGauge
            // 
            this.ledBulbZprobeGauge.Location = new System.Drawing.Point(101, 154);
            this.ledBulbZprobeGauge.Name = "ledBulbZprobeGauge";
            this.ledBulbZprobeGauge.On = false;
            this.ledBulbZprobeGauge.Size = new System.Drawing.Size(18, 19);
            this.ledBulbZprobeGauge.TabIndex = 27;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnM851);
            this.groupBox12.Controls.Add(this.txtBxM851);
            this.groupBox12.Controls.Add(this.lblM851);
            this.groupBox12.Location = new System.Drawing.Point(270, 97);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(97, 81);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Z-Probe";
            // 
            // btnM851
            // 
            this.btnM851.Location = new System.Drawing.Point(6, 51);
            this.btnM851.Name = "btnM851";
            this.btnM851.Size = new System.Drawing.Size(85, 23);
            this.btnM851.TabIndex = 8;
            this.btnM851.Text = "M851";
            this.btnM851.UseVisualStyleBackColor = true;
            this.btnM851.Click += new System.EventHandler(this.btnM851_Click);
            // 
            // txtBxM851
            // 
            this.txtBxM851.Location = new System.Drawing.Point(47, 25);
            this.txtBxM851.Name = "txtBxM851";
            this.txtBxM851.Size = new System.Drawing.Size(44, 20);
            this.txtBxM851.TabIndex = 1;
            // 
            // lblM851
            // 
            this.lblM851.AutoSize = true;
            this.lblM851.Location = new System.Drawing.Point(7, 28);
            this.lblM851.Name = "lblM851";
            this.lblM851.Size = new System.Drawing.Size(37, 13);
            this.lblM851.TabIndex = 0;
            this.lblM851.Text = "M851:";
            // 
            // btnNozzleIsTouchingBed
            // 
            this.btnNozzleIsTouchingBed.Location = new System.Drawing.Point(270, 42);
            this.btnNozzleIsTouchingBed.Name = "btnNozzleIsTouchingBed";
            this.btnNozzleIsTouchingBed.Size = new System.Drawing.Size(97, 49);
            this.btnNozzleIsTouchingBed.TabIndex = 26;
            this.btnNozzleIsTouchingBed.Text = "Nozzle is touching Bed";
            this.btnNozzleIsTouchingBed.UseVisualStyleBackColor = true;
            this.btnNozzleIsTouchingBed.Click += new System.EventHandler(this.btnNozzleIsTouchingBed_Click);
            // 
            // txtBxZprobePosition
            // 
            this.txtBxZprobePosition.Location = new System.Drawing.Point(81, 177);
            this.txtBxZprobePosition.Name = "txtBxZprobePosition";
            this.txtBxZprobePosition.Size = new System.Drawing.Size(53, 20);
            this.txtBxZprobePosition.TabIndex = 4;
            // 
            // btnProbeDown
            // 
            this.btnProbeDown.Location = new System.Drawing.Point(18, 267);
            this.btnProbeDown.Name = "btnProbeDown";
            this.btnProbeDown.Size = new System.Drawing.Size(75, 34);
            this.btnProbeDown.TabIndex = 6;
            this.btnProbeDown.Text = "Probe Down";
            this.btnProbeDown.UseVisualStyleBackColor = true;
            this.btnProbeDown.Click += new System.EventHandler(this.btnProbeDown_Click);
            // 
            // txtBxDockZprobe
            // 
            this.txtBxDockZprobe.Location = new System.Drawing.Point(270, 16);
            this.txtBxDockZprobe.Name = "txtBxDockZprobe";
            this.txtBxDockZprobe.ReadOnly = true;
            this.txtBxDockZprobe.Size = new System.Drawing.Size(97, 20);
            this.txtBxDockZprobe.TabIndex = 7;
            this.txtBxDockZprobe.TextChanged += new System.EventHandler(this.txtBxDockZprobe_TextChanged);
            // 
            // btnProbeUp
            // 
            this.btnProbeUp.Location = new System.Drawing.Point(18, 227);
            this.btnProbeUp.Name = "btnProbeUp";
            this.btnProbeUp.Size = new System.Drawing.Size(75, 34);
            this.btnProbeUp.TabIndex = 5;
            this.btnProbeUp.Text = "Probe Up";
            this.btnProbeUp.UseVisualStyleBackColor = true;
            this.btnProbeUp.Click += new System.EventHandler(this.btnProbeUp_Click);
            // 
            // btnDockZprobe
            // 
            this.btnDockZprobe.Location = new System.Drawing.Point(207, 16);
            this.btnDockZprobe.Name = "btnDockZprobe";
            this.btnDockZprobe.Size = new System.Drawing.Size(57, 75);
            this.btnDockZprobe.TabIndex = 3;
            this.btnDockZprobe.Text = "Dock Z probe";
            this.toolTip3DprinterTool.SetToolTip(this.btnDockZprobe, "Search for the bed using the probe. \r\nSerach is done in steps and stops\r\nwhen the" +
        " probe is incontact with then bed.\r\nThis can be adjusted with the Probe Up/Down");
            this.btnDockZprobe.UseVisualStyleBackColor = true;
            this.btnDockZprobe.Click += new System.EventHandler(this.btnDockZprobe_Click);
            // 
            // aGaugeProbe
            // 
            this.aGaugeProbe.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.dialGauge;
            this.aGaugeProbe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aGaugeProbe.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeProbe.BaseArcRadius = 80;
            this.aGaugeProbe.BaseArcStart = 120;
            this.aGaugeProbe.BaseArcSweep = 300;
            this.aGaugeProbe.BaseArcWidth = 2;
            this.aGaugeProbe.Center = new System.Drawing.Point(103, 105);
            this.aGaugeProbe.Location = new System.Drawing.Point(6, 16);
            this.aGaugeProbe.MaxValue = 10F;
            this.aGaugeProbe.MinValue = 0F;
            this.aGaugeProbe.Name = "aGaugeProbe";
            this.aGaugeProbe.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.aGaugeProbe.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGaugeProbe.NeedleRadius = 80;
            this.aGaugeProbe.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.aGaugeProbe.NeedleWidth = 2;
            this.aGaugeProbe.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeProbe.ScaleLinesInterInnerRadius = 73;
            this.aGaugeProbe.ScaleLinesInterOuterRadius = 80;
            this.aGaugeProbe.ScaleLinesInterWidth = 1;
            this.aGaugeProbe.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeProbe.ScaleLinesMajorInnerRadius = 70;
            this.aGaugeProbe.ScaleLinesMajorOuterRadius = 80;
            this.aGaugeProbe.ScaleLinesMajorStepValue = 1F;
            this.aGaugeProbe.ScaleLinesMajorWidth = 2;
            this.aGaugeProbe.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeProbe.ScaleLinesMinorInnerRadius = 75;
            this.aGaugeProbe.ScaleLinesMinorOuterRadius = 80;
            this.aGaugeProbe.ScaleLinesMinorTicks = 9;
            this.aGaugeProbe.ScaleLinesMinorWidth = 1;
            this.aGaugeProbe.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeProbe.ScaleNumbersFormat = null;
            this.aGaugeProbe.ScaleNumbersRadius = 60;
            this.aGaugeProbe.ScaleNumbersRotation = 0;
            this.aGaugeProbe.ScaleNumbersStartScaleLine = 0;
            this.aGaugeProbe.ScaleNumbersStepScaleLines = 1;
            this.aGaugeProbe.Size = new System.Drawing.Size(205, 285);
            this.aGaugeProbe.TabIndex = 28;
            this.aGaugeProbe.Text = "aGauge1";
            this.toolTip3DprinterTool.SetToolTip(this.aGaugeProbe, "Nozzle distance over bed after G28 Z");
            this.aGaugeProbe.Value = 0F;
            // 
            // grpBxZprobeXoffset
            // 
            this.grpBxZprobeXoffset.Controls.Add(this.pictureWorkInProgressZprobe);
            this.grpBxZprobeXoffset.Controls.Add(this.txtBxZprobeYoffset);
            this.grpBxZprobeXoffset.Controls.Add(this.txtBxZprobeXoffset);
            this.grpBxZprobeXoffset.Controls.Add(this.cmbBxZprobeYoffset);
            this.grpBxZprobeXoffset.Controls.Add(this.lblZprobeYoffsetmm);
            this.grpBxZprobeXoffset.Controls.Add(this.lblZprobeYoffset);
            this.grpBxZprobeXoffset.Controls.Add(this.cmbBxZprobeXoffset);
            this.grpBxZprobeXoffset.Controls.Add(this.lblZprobeXoffsetmm);
            this.grpBxZprobeXoffset.Controls.Add(this.lblZprobeXoffset);
            this.grpBxZprobeXoffset.Location = new System.Drawing.Point(13, 450);
            this.grpBxZprobeXoffset.Name = "grpBxZprobeXoffset";
            this.grpBxZprobeXoffset.Size = new System.Drawing.Size(374, 107);
            this.grpBxZprobeXoffset.TabIndex = 11;
            this.grpBxZprobeXoffset.TabStop = false;
            this.grpBxZprobeXoffset.Text = "Description of the probe offset to nozzle";
            // 
            // pictureWorkInProgressZprobe
            // 
            this.pictureWorkInProgressZprobe.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Work_in_progress;
            this.pictureWorkInProgressZprobe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureWorkInProgressZprobe.Location = new System.Drawing.Point(298, 14);
            this.pictureWorkInProgressZprobe.Name = "pictureWorkInProgressZprobe";
            this.pictureWorkInProgressZprobe.Size = new System.Drawing.Size(61, 56);
            this.pictureWorkInProgressZprobe.TabIndex = 27;
            this.pictureWorkInProgressZprobe.TabStop = false;
            // 
            // txtBxZprobeYoffset
            // 
            this.txtBxZprobeYoffset.Location = new System.Drawing.Point(73, 49);
            this.txtBxZprobeYoffset.Name = "txtBxZprobeYoffset";
            this.txtBxZprobeYoffset.Size = new System.Drawing.Size(32, 20);
            this.txtBxZprobeYoffset.TabIndex = 17;
            this.txtBxZprobeYoffset.TextChanged += new System.EventHandler(this.txtBxZprobeYoffset_TextChanged);
            // 
            // txtBxZprobeXoffset
            // 
            this.txtBxZprobeXoffset.Location = new System.Drawing.Point(73, 26);
            this.txtBxZprobeXoffset.Name = "txtBxZprobeXoffset";
            this.txtBxZprobeXoffset.Size = new System.Drawing.Size(32, 20);
            this.txtBxZprobeXoffset.TabIndex = 12;
            this.txtBxZprobeXoffset.TextChanged += new System.EventHandler(this.txtBxZprobeXoffset_TextChanged);
            // 
            // cmbBxZprobeYoffset
            // 
            this.cmbBxZprobeYoffset.FormattingEnabled = true;
            this.cmbBxZprobeYoffset.Items.AddRange(new object[] {
            "behind the nozzle.",
            "in front of the nozzle."});
            this.cmbBxZprobeYoffset.Location = new System.Drawing.Point(128, 49);
            this.cmbBxZprobeYoffset.Name = "cmbBxZprobeYoffset";
            this.cmbBxZprobeYoffset.Size = new System.Drawing.Size(136, 21);
            this.cmbBxZprobeYoffset.TabIndex = 16;
            this.cmbBxZprobeYoffset.Text = "behind the nozzle.";
            this.cmbBxZprobeYoffset.SelectedIndexChanged += new System.EventHandler(this.cmbBxZprobeYoffset_SelectedIndexChanged);
            // 
            // lblZprobeYoffsetmm
            // 
            this.lblZprobeYoffsetmm.AutoSize = true;
            this.lblZprobeYoffsetmm.Location = new System.Drawing.Point(104, 49);
            this.lblZprobeYoffsetmm.Name = "lblZprobeYoffsetmm";
            this.lblZprobeYoffsetmm.Size = new System.Drawing.Size(23, 13);
            this.lblZprobeYoffsetmm.TabIndex = 15;
            this.lblZprobeYoffsetmm.Text = "mm";
            // 
            // lblZprobeYoffset
            // 
            this.lblZprobeYoffset.AutoSize = true;
            this.lblZprobeYoffset.Location = new System.Drawing.Point(42, 49);
            this.lblZprobeYoffset.Name = "lblZprobeYoffset";
            this.lblZprobeYoffset.Size = new System.Drawing.Size(25, 13);
            this.lblZprobeYoffset.TabIndex = 13;
            this.lblZprobeYoffset.Text = "and";
            // 
            // cmbBxZprobeXoffset
            // 
            this.cmbBxZprobeXoffset.FormattingEnabled = true;
            this.cmbBxZprobeXoffset.Items.AddRange(new object[] {
            "to the left of the nozzle",
            "to the right of the nozzle"});
            this.cmbBxZprobeXoffset.Location = new System.Drawing.Point(128, 26);
            this.cmbBxZprobeXoffset.Name = "cmbBxZprobeXoffset";
            this.cmbBxZprobeXoffset.Size = new System.Drawing.Size(136, 21);
            this.cmbBxZprobeXoffset.TabIndex = 12;
            this.cmbBxZprobeXoffset.Text = "to the left of the nozzle.";
            this.cmbBxZprobeXoffset.SelectedIndexChanged += new System.EventHandler(this.cmbBxZprobeXoffset_SelectedIndexChanged);
            // 
            // lblZprobeXoffsetmm
            // 
            this.lblZprobeXoffsetmm.AutoSize = true;
            this.lblZprobeXoffsetmm.Location = new System.Drawing.Point(104, 29);
            this.lblZprobeXoffsetmm.Name = "lblZprobeXoffsetmm";
            this.lblZprobeXoffsetmm.Size = new System.Drawing.Size(23, 13);
            this.lblZprobeXoffsetmm.TabIndex = 8;
            this.lblZprobeXoffsetmm.Text = "mm";
            // 
            // lblZprobeXoffset
            // 
            this.lblZprobeXoffset.AutoSize = true;
            this.lblZprobeXoffset.Location = new System.Drawing.Point(10, 29);
            this.lblZprobeXoffset.Name = "lblZprobeXoffset";
            this.lblZprobeXoffset.Size = new System.Drawing.Size(66, 13);
            this.lblZprobeXoffset.TabIndex = 7;
            this.lblZprobeXoffset.Text = "The probe is";
            // 
            // tabPageConfigurationBed
            // 
            this.tabPageConfigurationBed.Controls.Add(this.panelConfigurationBedTab);
            this.tabPageConfigurationBed.Controls.Add(this.grpBxAdjusters);
            this.tabPageConfigurationBed.Location = new System.Drawing.Point(4, 40);
            this.tabPageConfigurationBed.Name = "tabPageConfigurationBed";
            this.tabPageConfigurationBed.Size = new System.Drawing.Size(652, 576);
            this.tabPageConfigurationBed.TabIndex = 4;
            this.tabPageConfigurationBed.Text = "Configure Bed";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageConfigurationBed, "Navigate and save positions for other features to use");
            this.tabPageConfigurationBed.ToolTipText = "Configuration of Bed";
            this.tabPageConfigurationBed.UseVisualStyleBackColor = true;
            // 
            // panelConfigurationBedTab
            // 
            this.panelConfigurationBedTab.Controls.Add(this.btnProbeTheBed);
            this.panelConfigurationBedTab.Controls.Add(this.panelBed);
            this.panelConfigurationBedTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfigurationBedTab.Location = new System.Drawing.Point(0, 0);
            this.panelConfigurationBedTab.Name = "panelConfigurationBedTab";
            this.panelConfigurationBedTab.Size = new System.Drawing.Size(652, 576);
            this.panelConfigurationBedTab.TabIndex = 32;
            // 
            // btnProbeTheBed
            // 
            this.btnProbeTheBed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProbeTheBed.Location = new System.Drawing.Point(6, 529);
            this.btnProbeTheBed.Name = "btnProbeTheBed";
            this.btnProbeTheBed.Size = new System.Drawing.Size(164, 44);
            this.btnProbeTheBed.TabIndex = 0;
            this.btnProbeTheBed.Text = "Probe the Bed";
            this.btnProbeTheBed.UseVisualStyleBackColor = true;
            this.btnProbeTheBed.Click += new System.EventHandler(this.btnProbeTheBed_Click);
            // 
            // panelBed
            // 
            this.panelBed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBed.BackColor = System.Drawing.SystemColors.Control;
            this.panelBed.Controls.Add(this.bedCornerControlFrontRight);
            this.panelBed.Controls.Add(this.bedCornerControlFrontLeft);
            this.panelBed.Controls.Add(this.bedAdjusterLeftSingle);
            this.panelBed.Controls.Add(this.bedCornerControlBackRight);
            this.panelBed.Controls.Add(this.bedAdjusterFrontSingle);
            this.panelBed.Controls.Add(this.bedCornerControlBackLeft);
            this.panelBed.Controls.Add(this.bedAdjusterRightSingle);
            this.panelBed.Controls.Add(this.bedAdjusterBackRight);
            this.panelBed.Controls.Add(this.bedAdjusterFrontRight);
            this.panelBed.Controls.Add(this.bedAdjusterFrontLeft);
            this.panelBed.Controls.Add(this.bedCornerControlSafeHome);
            this.panelBed.Controls.Add(this.bedAdjusterBackLeft);
            this.panelBed.Location = new System.Drawing.Point(6, 13);
            this.panelBed.Name = "panelBed";
            this.panelBed.Size = new System.Drawing.Size(633, 510);
            this.panelBed.TabIndex = 30;
            // 
            // bedCornerControlFrontRight
            // 
            this.bedCornerControlFrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bedCornerControlFrontRight.Communication = null;
            this.bedCornerControlFrontRight.Corner = Marlin3DprinterToolUserControls.CornerType.FrontRightCorner;
            this.bedCornerControlFrontRight.Location = new System.Drawing.Point(430, 429);
            this.bedCornerControlFrontRight.MaximumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlFrontRight.MinimumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlFrontRight.Name = "bedCornerControlFrontRight";
            this.bedCornerControlFrontRight.Size = new System.Drawing.Size(195, 65);
            this.bedCornerControlFrontRight.TabIndex = 28;
            // 
            // bedCornerControlFrontLeft
            // 
            this.bedCornerControlFrontLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bedCornerControlFrontLeft.Communication = null;
            this.bedCornerControlFrontLeft.Corner = Marlin3DprinterToolUserControls.CornerType.FrontLeftCorner;
            this.bedCornerControlFrontLeft.Location = new System.Drawing.Point(16, 429);
            this.bedCornerControlFrontLeft.MaximumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlFrontLeft.MinimumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlFrontLeft.Name = "bedCornerControlFrontLeft";
            this.bedCornerControlFrontLeft.Size = new System.Drawing.Size(195, 65);
            this.bedCornerControlFrontLeft.TabIndex = 27;
            // 
            // bedAdjusterLeftSingle
            // 
            this.bedAdjusterLeftSingle.Adjuster = Marlin3DprinterToolUserControls.AdjusterType.LeftSingleAdjuster;
            this.bedAdjusterLeftSingle.AdjusterThread = Marlin3DprinterToolUserControls.AdjusterThreadType.M3;
            this.bedAdjusterLeftSingle.Fix = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterLeftSingle.Location = new System.Drawing.Point(12, 193);
            this.bedAdjusterLeftSingle.MaximumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterLeftSingle.MinimumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterLeftSingle.Name = "bedAdjusterLeftSingle";
            position1.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position1.Xstring = "0";
            position1.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position1.Ystring = "0";
            position1.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position1.Zstring = "0";
            this.bedAdjusterLeftSingle.Position = position1;
            this.bedAdjusterLeftSingle.Size = new System.Drawing.Size(180, 50);
            this.bedAdjusterLeftSingle.TabIndex = 36;
            this.bedAdjusterLeftSingle.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterLeftSingle.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterLeftSingle.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // bedCornerControlBackRight
            // 
            this.bedCornerControlBackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bedCornerControlBackRight.Communication = null;
            this.bedCornerControlBackRight.Corner = Marlin3DprinterToolUserControls.CornerType.BackRightCorner;
            this.bedCornerControlBackRight.Location = new System.Drawing.Point(429, 13);
            this.bedCornerControlBackRight.MaximumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlBackRight.MinimumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlBackRight.Name = "bedCornerControlBackRight";
            this.bedCornerControlBackRight.Size = new System.Drawing.Size(195, 65);
            this.bedCornerControlBackRight.TabIndex = 26;
            // 
            // bedAdjusterFrontSingle
            // 
            this.bedAdjusterFrontSingle.Adjuster = Marlin3DprinterToolUserControls.AdjusterType.FrontSingleAdjuster;
            this.bedAdjusterFrontSingle.AdjusterThread = Marlin3DprinterToolUserControls.AdjusterThreadType.M3;
            this.bedAdjusterFrontSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bedAdjusterFrontSingle.Fix = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontSingle.Location = new System.Drawing.Point(245, 444);
            this.bedAdjusterFrontSingle.MaximumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontSingle.MinimumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontSingle.Name = "bedAdjusterFrontSingle";
            position2.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position2.Xstring = "0";
            position2.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position2.Ystring = "0";
            position2.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position2.Zstring = "0";
            this.bedAdjusterFrontSingle.Position = position2;
            this.bedAdjusterFrontSingle.Size = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontSingle.TabIndex = 35;
            this.bedAdjusterFrontSingle.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontSingle.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontSingle.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // bedCornerControlBackLeft
            // 
            this.bedCornerControlBackLeft.Communication = null;
            this.bedCornerControlBackLeft.Corner = Marlin3DprinterToolUserControls.CornerType.BackLeftCorner;
            this.bedCornerControlBackLeft.Location = new System.Drawing.Point(14, 13);
            this.bedCornerControlBackLeft.MaximumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlBackLeft.MinimumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlBackLeft.Name = "bedCornerControlBackLeft";
            this.bedCornerControlBackLeft.Size = new System.Drawing.Size(195, 65);
            this.bedCornerControlBackLeft.TabIndex = 25;
            // 
            // bedAdjusterRightSingle
            // 
            this.bedAdjusterRightSingle.Adjuster = Marlin3DprinterToolUserControls.AdjusterType.RightSingleAdjuster;
            this.bedAdjusterRightSingle.AdjusterThread = Marlin3DprinterToolUserControls.AdjusterThreadType.M3;
            this.bedAdjusterRightSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bedAdjusterRightSingle.Fix = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterRightSingle.Location = new System.Drawing.Point(444, 193);
            this.bedAdjusterRightSingle.MaximumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterRightSingle.MinimumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterRightSingle.Name = "bedAdjusterRightSingle";
            position3.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position3.Xstring = "0";
            position3.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position3.Ystring = "0";
            position3.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position3.Zstring = "0";
            this.bedAdjusterRightSingle.Position = position3;
            this.bedAdjusterRightSingle.Size = new System.Drawing.Size(180, 50);
            this.bedAdjusterRightSingle.TabIndex = 34;
            this.bedAdjusterRightSingle.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterRightSingle.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterRightSingle.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // bedAdjusterBackRight
            // 
            this.bedAdjusterBackRight.Adjuster = Marlin3DprinterToolUserControls.AdjusterType.BackRightAdjuster;
            this.bedAdjusterBackRight.AdjusterThread = Marlin3DprinterToolUserControls.AdjusterThreadType.M3;
            this.bedAdjusterBackRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bedAdjusterBackRight.Fix = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterBackRight.Location = new System.Drawing.Point(444, 77);
            this.bedAdjusterBackRight.MaximumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterBackRight.MinimumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterBackRight.Name = "bedAdjusterBackRight";
            position4.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position4.Xstring = "0";
            position4.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position4.Ystring = "0";
            position4.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position4.Zstring = "0";
            this.bedAdjusterBackRight.Position = position4;
            this.bedAdjusterBackRight.Size = new System.Drawing.Size(180, 50);
            this.bedAdjusterBackRight.TabIndex = 33;
            this.bedAdjusterBackRight.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterBackRight.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterBackRight.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // bedAdjusterFrontRight
            // 
            this.bedAdjusterFrontRight.Adjuster = Marlin3DprinterToolUserControls.AdjusterType.FrontRightAdjuster;
            this.bedAdjusterFrontRight.AdjusterThread = Marlin3DprinterToolUserControls.AdjusterThreadType.M3;
            this.bedAdjusterFrontRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bedAdjusterFrontRight.Fix = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontRight.Location = new System.Drawing.Point(442, 384);
            this.bedAdjusterFrontRight.MaximumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontRight.MinimumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontRight.Name = "bedAdjusterFrontRight";
            position5.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position5.Xstring = "0";
            position5.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position5.Ystring = "0";
            position5.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position5.Zstring = "0";
            this.bedAdjusterFrontRight.Position = position5;
            this.bedAdjusterFrontRight.Size = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontRight.TabIndex = 32;
            this.bedAdjusterFrontRight.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontRight.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontRight.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // bedAdjusterFrontLeft
            // 
            this.bedAdjusterFrontLeft.Adjuster = Marlin3DprinterToolUserControls.AdjusterType.FrontLeftAdjuster;
            this.bedAdjusterFrontLeft.AdjusterThread = Marlin3DprinterToolUserControls.AdjusterThreadType.M3;
            this.bedAdjusterFrontLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bedAdjusterFrontLeft.Fix = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontLeft.Location = new System.Drawing.Point(14, 384);
            this.bedAdjusterFrontLeft.MaximumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontLeft.MinimumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontLeft.Name = "bedAdjusterFrontLeft";
            position6.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position6.Xstring = "0";
            position6.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position6.Ystring = "0";
            position6.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position6.Zstring = "0";
            this.bedAdjusterFrontLeft.Position = position6;
            this.bedAdjusterFrontLeft.Size = new System.Drawing.Size(180, 50);
            this.bedAdjusterFrontLeft.TabIndex = 31;
            this.bedAdjusterFrontLeft.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontLeft.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterFrontLeft.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // bedCornerControlSafeHome
            // 
            this.bedCornerControlSafeHome.Communication = null;
            this.bedCornerControlSafeHome.Corner = Marlin3DprinterToolUserControls.CornerType.SafeHome;
            this.bedCornerControlSafeHome.Location = new System.Drawing.Point(232, 193);
            this.bedCornerControlSafeHome.MaximumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlSafeHome.MinimumSize = new System.Drawing.Size(195, 65);
            this.bedCornerControlSafeHome.Name = "bedCornerControlSafeHome";
            this.bedCornerControlSafeHome.Size = new System.Drawing.Size(195, 65);
            this.bedCornerControlSafeHome.TabIndex = 30;
            // 
            // bedAdjusterBackLeft
            // 
            this.bedAdjusterBackLeft.Adjuster = Marlin3DprinterToolUserControls.AdjusterType.BackLeftAdjuster;
            this.bedAdjusterBackLeft.AdjusterThread = Marlin3DprinterToolUserControls.AdjusterThreadType.M3;
            this.bedAdjusterBackLeft.Fix = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterBackLeft.Location = new System.Drawing.Point(12, 77);
            this.bedAdjusterBackLeft.MaximumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterBackLeft.MinimumSize = new System.Drawing.Size(180, 50);
            this.bedAdjusterBackLeft.Name = "bedAdjusterBackLeft";
            position7.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position7.Xstring = "0";
            position7.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position7.Ystring = "0";
            position7.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            position7.Zstring = "0";
            this.bedAdjusterBackLeft.Position = position7;
            this.bedAdjusterBackLeft.Size = new System.Drawing.Size(180, 50);
            this.bedAdjusterBackLeft.TabIndex = 29;
            this.bedAdjusterBackLeft.X = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterBackLeft.Y = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bedAdjusterBackLeft.Z = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // grpBxAdjusters
            // 
            this.grpBxAdjusters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBxAdjusters.Controls.Add(this.rdoBn3pointFront);
            this.grpBxAdjusters.Controls.Add(this.chkListBxAdjustment);
            this.grpBxAdjusters.Controls.Add(this.rdoBn3pointRight);
            this.grpBxAdjusters.Controls.Add(this.rdoBn3pointLeft);
            this.grpBxAdjusters.Controls.Add(this.rdoBn4point);
            this.grpBxAdjusters.Location = new System.Drawing.Point(373, 1068);
            this.grpBxAdjusters.Name = "grpBxAdjusters";
            this.grpBxAdjusters.Size = new System.Drawing.Size(253, 100);
            this.grpBxAdjusters.TabIndex = 20;
            this.grpBxAdjusters.TabStop = false;
            this.grpBxAdjusters.Text = "Type of Adjusters";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxAdjusters, "Assign the type of bed adjusters");
            // 
            // rdoBn3pointFront
            // 
            this.rdoBn3pointFront.AutoSize = true;
            this.rdoBn3pointFront.Location = new System.Drawing.Point(131, 77);
            this.rdoBn3pointFront.Name = "rdoBn3pointFront";
            this.rdoBn3pointFront.Size = new System.Drawing.Size(84, 17);
            this.rdoBn3pointFront.TabIndex = 33;
            this.rdoBn3pointFront.Text = "3 point Front";
            this.rdoBn3pointFront.UseVisualStyleBackColor = true;
            this.rdoBn3pointFront.CheckedChanged += new System.EventHandler(this.rdoBn3pointFront_CheckedChanged);
            // 
            // chkListBxAdjustment
            // 
            this.chkListBxAdjustment.FormattingEnabled = true;
            this.chkListBxAdjustment.Items.AddRange(new object[] {
            "M3",
            "M4",
            "M5"});
            this.chkListBxAdjustment.Location = new System.Drawing.Point(6, 31);
            this.chkListBxAdjustment.Name = "chkListBxAdjustment";
            this.chkListBxAdjustment.Size = new System.Drawing.Size(88, 49);
            this.chkListBxAdjustment.TabIndex = 18;
            this.toolTip3DprinterTool.SetToolTip(this.chkListBxAdjustment, "Assign the type of bed adjusters");
            this.chkListBxAdjustment.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListBxAdjustment_ItemCheck);
            this.chkListBxAdjustment.SelectedIndexChanged += new System.EventHandler(this.chkListBxAdjustment_SelectedIndexChanged);
            // 
            // rdoBn3pointRight
            // 
            this.rdoBn3pointRight.AutoSize = true;
            this.rdoBn3pointRight.Location = new System.Drawing.Point(131, 54);
            this.rdoBn3pointRight.Name = "rdoBn3pointRight";
            this.rdoBn3pointRight.Size = new System.Drawing.Size(85, 17);
            this.rdoBn3pointRight.TabIndex = 32;
            this.rdoBn3pointRight.Text = "3 point Right";
            this.rdoBn3pointRight.UseVisualStyleBackColor = true;
            this.rdoBn3pointRight.CheckedChanged += new System.EventHandler(this.rdoBn3pointRight_CheckedChanged);
            // 
            // rdoBn3pointLeft
            // 
            this.rdoBn3pointLeft.AutoSize = true;
            this.rdoBn3pointLeft.Location = new System.Drawing.Point(131, 31);
            this.rdoBn3pointLeft.Name = "rdoBn3pointLeft";
            this.rdoBn3pointLeft.Size = new System.Drawing.Size(78, 17);
            this.rdoBn3pointLeft.TabIndex = 31;
            this.rdoBn3pointLeft.Text = "3 point Left";
            this.rdoBn3pointLeft.UseVisualStyleBackColor = true;
            this.rdoBn3pointLeft.CheckedChanged += new System.EventHandler(this.rdoBn3pointLeft_CheckedChanged);
            // 
            // rdoBn4point
            // 
            this.rdoBn4point.AutoSize = true;
            this.rdoBn4point.Checked = true;
            this.rdoBn4point.Location = new System.Drawing.Point(131, 8);
            this.rdoBn4point.Name = "rdoBn4point";
            this.rdoBn4point.Size = new System.Drawing.Size(102, 17);
            this.rdoBn4point.TabIndex = 21;
            this.rdoBn4point.TabStop = true;
            this.rdoBn4point.Text = "4 point adjusters";
            this.rdoBn4point.UseVisualStyleBackColor = true;
            this.rdoBn4point.CheckedChanged += new System.EventHandler(this.rdoBn4point_CheckedChanged);
            // 
            // tabPageConfigurationZprobe
            // 
            this.tabPageConfigurationZprobe.Controls.Add(this.grpBxBlTouch);
            this.tabPageConfigurationZprobe.Controls.Add(this.grpAutoBedLevel);
            this.tabPageConfigurationZprobe.Controls.Add(this.groupBox3);
            this.tabPageConfigurationZprobe.Controls.Add(this.grpBxEngageZprobe);
            this.tabPageConfigurationZprobe.Location = new System.Drawing.Point(4, 40);
            this.tabPageConfigurationZprobe.Name = "tabPageConfigurationZprobe";
            this.tabPageConfigurationZprobe.Size = new System.Drawing.Size(652, 576);
            this.tabPageConfigurationZprobe.TabIndex = 6;
            this.tabPageConfigurationZprobe.Text = "Configure Z-probe";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageConfigurationZprobe, "Configuration and Test of the Z-probe");
            this.tabPageConfigurationZprobe.UseVisualStyleBackColor = true;
            // 
            // grpBxBlTouch
            // 
            this.grpBxBlTouch.Controls.Add(this.picBxApprovedByBLTouch);
            this.grpBxBlTouch.Controls.Add(this.btnBlTouchSave);
            this.grpBxBlTouch.Controls.Add(this.btnBlTouchRelease);
            this.grpBxBlTouch.Controls.Add(this.btnBlTouchEngage);
            this.grpBxBlTouch.Controls.Add(this.btnBlTouchResetAlarm);
            this.grpBxBlTouch.Controls.Add(this.btnBlTouchSelftest);
            this.grpBxBlTouch.Controls.Add(this.chkBxBlTouch);
            this.grpBxBlTouch.Location = new System.Drawing.Point(7, 237);
            this.grpBxBlTouch.Name = "grpBxBlTouch";
            this.grpBxBlTouch.Size = new System.Drawing.Size(636, 74);
            this.grpBxBlTouch.TabIndex = 52;
            this.grpBxBlTouch.TabStop = false;
            this.grpBxBlTouch.Text = "BLTouch Z-probe";
            // 
            // picBxApprovedByBLTouch
            // 
            this.picBxApprovedByBLTouch.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.ApprovedByBLTouch;
            this.picBxApprovedByBLTouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxApprovedByBLTouch.Location = new System.Drawing.Point(7, 14);
            this.picBxApprovedByBLTouch.Name = "picBxApprovedByBLTouch";
            this.picBxApprovedByBLTouch.Size = new System.Drawing.Size(144, 50);
            this.picBxApprovedByBLTouch.TabIndex = 20;
            this.picBxApprovedByBLTouch.TabStop = false;
            // 
            // btnBlTouchSave
            // 
            this.btnBlTouchSave.Location = new System.Drawing.Point(233, 14);
            this.btnBlTouchSave.Name = "btnBlTouchSave";
            this.btnBlTouchSave.Size = new System.Drawing.Size(53, 23);
            this.btnBlTouchSave.TabIndex = 19;
            this.btnBlTouchSave.Text = "Save";
            this.btnBlTouchSave.UseVisualStyleBackColor = true;
            this.btnBlTouchSave.Click += new System.EventHandler(this.btnBlTouchSave_Click);
            // 
            // btnBlTouchRelease
            // 
            this.btnBlTouchRelease.Location = new System.Drawing.Point(383, 14);
            this.btnBlTouchRelease.Name = "btnBlTouchRelease";
            this.btnBlTouchRelease.Size = new System.Drawing.Size(85, 23);
            this.btnBlTouchRelease.TabIndex = 19;
            this.btnBlTouchRelease.Text = "Test Release";
            this.btnBlTouchRelease.UseVisualStyleBackColor = true;
            this.btnBlTouchRelease.Click += new System.EventHandler(this.btnBlTouchRelease_Click);
            // 
            // btnBlTouchEngage
            // 
            this.btnBlTouchEngage.Location = new System.Drawing.Point(292, 14);
            this.btnBlTouchEngage.Name = "btnBlTouchEngage";
            this.btnBlTouchEngage.Size = new System.Drawing.Size(85, 23);
            this.btnBlTouchEngage.TabIndex = 17;
            this.btnBlTouchEngage.Text = "Test Engage";
            this.btnBlTouchEngage.UseVisualStyleBackColor = true;
            this.btnBlTouchEngage.Click += new System.EventHandler(this.btnBlTouchEngage_Click_1);
            // 
            // btnBlTouchResetAlarm
            // 
            this.btnBlTouchResetAlarm.Location = new System.Drawing.Point(555, 14);
            this.btnBlTouchResetAlarm.Name = "btnBlTouchResetAlarm";
            this.btnBlTouchResetAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnBlTouchResetAlarm.TabIndex = 19;
            this.btnBlTouchResetAlarm.Text = "Reset Alarm";
            this.btnBlTouchResetAlarm.UseVisualStyleBackColor = true;
            this.btnBlTouchResetAlarm.Click += new System.EventHandler(this.btnBlTouchResetAlarm_Click);
            // 
            // btnBlTouchSelftest
            // 
            this.btnBlTouchSelftest.Location = new System.Drawing.Point(474, 14);
            this.btnBlTouchSelftest.Name = "btnBlTouchSelftest";
            this.btnBlTouchSelftest.Size = new System.Drawing.Size(75, 23);
            this.btnBlTouchSelftest.TabIndex = 18;
            this.btnBlTouchSelftest.Text = "Selftest";
            this.btnBlTouchSelftest.UseVisualStyleBackColor = true;
            this.btnBlTouchSelftest.Click += new System.EventHandler(this.btnBlTouchSelftest_Click);
            // 
            // chkBxBlTouch
            // 
            this.chkBxBlTouch.AutoSize = true;
            this.chkBxBlTouch.Location = new System.Drawing.Point(157, 18);
            this.chkBxBlTouch.Name = "chkBxBlTouch";
            this.chkBxBlTouch.Size = new System.Drawing.Size(70, 17);
            this.chkBxBlTouch.TabIndex = 17;
            this.chkBxBlTouch.Text = "BLTouch";
            this.toolTip3DprinterTool.SetToolTip(this.chkBxBlTouch, "Check this box if you have a BLTouch Z-probe");
            this.chkBxBlTouch.UseVisualStyleBackColor = true;
            this.chkBxBlTouch.CheckedChanged += new System.EventHandler(this.chkBxBlTouch_CheckedChanged);
            // 
            // grpAutoBedLevel
            // 
            this.grpAutoBedLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAutoBedLevel.Controls.Add(this.fctbAutoBedLevelResponce);
            this.grpAutoBedLevel.Controls.Add(this.btnAutoBedLevel);
            this.grpAutoBedLevel.Location = new System.Drawing.Point(7, 317);
            this.grpAutoBedLevel.Name = "grpAutoBedLevel";
            this.grpAutoBedLevel.Size = new System.Drawing.Size(636, 261);
            this.grpAutoBedLevel.TabIndex = 49;
            this.grpAutoBedLevel.TabStop = false;
            this.grpAutoBedLevel.Text = "Auto Bed Level";
            // 
            // fctbAutoBedLevelResponce
            // 
            this.fctbAutoBedLevelResponce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbAutoBedLevelResponce.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbAutoBedLevelResponce.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctbAutoBedLevelResponce.BackBrush = null;
            this.fctbAutoBedLevelResponce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctbAutoBedLevelResponce.CharHeight = 14;
            this.fctbAutoBedLevelResponce.CharWidth = 8;
            this.fctbAutoBedLevelResponce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbAutoBedLevelResponce.DescriptionFile = "";
            this.fctbAutoBedLevelResponce.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbAutoBedLevelResponce.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbAutoBedLevelResponce.IsReplaceMode = false;
            this.fctbAutoBedLevelResponce.Location = new System.Drawing.Point(6, 19);
            this.fctbAutoBedLevelResponce.Name = "fctbAutoBedLevelResponce";
            this.fctbAutoBedLevelResponce.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbAutoBedLevelResponce.ReadOnly = true;
            this.fctbAutoBedLevelResponce.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbAutoBedLevelResponce.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbAutoBedLevelResponce.ServiceColors")));
            this.fctbAutoBedLevelResponce.ShowLineNumbers = false;
            this.fctbAutoBedLevelResponce.Size = new System.Drawing.Size(552, 236);
            this.fctbAutoBedLevelResponce.TabIndex = 17;
            this.fctbAutoBedLevelResponce.Zoom = 100;
            // 
            // btnAutoBedLevel
            // 
            this.btnAutoBedLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoBedLevel.Location = new System.Drawing.Point(564, 19);
            this.btnAutoBedLevel.Name = "btnAutoBedLevel";
            this.btnAutoBedLevel.Size = new System.Drawing.Size(66, 90);
            this.btnAutoBedLevel.TabIndex = 1;
            this.btnAutoBedLevel.Text = "Auto Bed Level (G29)";
            this.btnAutoBedLevel.UseVisualStyleBackColor = true;
            this.btnAutoBedLevel.Click += new System.EventHandler(this.btnAutoBedLevel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTestZprobeRelease);
            this.groupBox3.Controls.Add(this.btnTestZprobeReleaseSave);
            this.groupBox3.Controls.Add(this.txtBxGcodeAssistZprobeRelease);
            this.groupBox3.Location = new System.Drawing.Point(7, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 105);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Release Z-probe";
            // 
            // btnTestZprobeRelease
            // 
            this.btnTestZprobeRelease.Location = new System.Drawing.Point(433, 74);
            this.btnTestZprobeRelease.Name = "btnTestZprobeRelease";
            this.btnTestZprobeRelease.Size = new System.Drawing.Size(85, 23);
            this.btnTestZprobeRelease.TabIndex = 18;
            this.btnTestZprobeRelease.Text = "Test Release";
            this.btnTestZprobeRelease.UseVisualStyleBackColor = true;
            this.btnTestZprobeRelease.Click += new System.EventHandler(this.btnTestZprobeRelease_Click);
            // 
            // btnTestZprobeReleaseSave
            // 
            this.btnTestZprobeReleaseSave.Location = new System.Drawing.Point(524, 74);
            this.btnTestZprobeReleaseSave.Name = "btnTestZprobeReleaseSave";
            this.btnTestZprobeReleaseSave.Size = new System.Drawing.Size(53, 23);
            this.btnTestZprobeReleaseSave.TabIndex = 17;
            this.btnTestZprobeReleaseSave.Text = "Save";
            this.btnTestZprobeReleaseSave.UseVisualStyleBackColor = true;
            this.btnTestZprobeReleaseSave.Click += new System.EventHandler(this.btnTestZprobeReleaseSave_Click);
            // 
            // txtBxGcodeAssistZprobeRelease
            // 
            this.txtBxGcodeAssistZprobeRelease.Location = new System.Drawing.Point(6, 19);
            this.txtBxGcodeAssistZprobeRelease.Multiline = true;
            this.txtBxGcodeAssistZprobeRelease.Name = "txtBxGcodeAssistZprobeRelease";
            this.txtBxGcodeAssistZprobeRelease.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxGcodeAssistZprobeRelease.Size = new System.Drawing.Size(420, 78);
            this.txtBxGcodeAssistZprobeRelease.TabIndex = 11;
            // 
            // grpBxEngageZprobe
            // 
            this.grpBxEngageZprobe.Controls.Add(this.btnTestZprobeEngage);
            this.grpBxEngageZprobe.Controls.Add(this.btnTestZprobeEngageSave);
            this.grpBxEngageZprobe.Controls.Add(this.txtBxGcodeAssistZprobeEngage);
            this.grpBxEngageZprobe.Location = new System.Drawing.Point(7, 14);
            this.grpBxEngageZprobe.Name = "grpBxEngageZprobe";
            this.grpBxEngageZprobe.Size = new System.Drawing.Size(636, 106);
            this.grpBxEngageZprobe.TabIndex = 50;
            this.grpBxEngageZprobe.TabStop = false;
            this.grpBxEngageZprobe.Text = "Engage Z-probe";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxEngageZprobe, "How the Z-probe is engaged in meassure position");
            // 
            // btnTestZprobeEngage
            // 
            this.btnTestZprobeEngage.Location = new System.Drawing.Point(433, 77);
            this.btnTestZprobeEngage.Name = "btnTestZprobeEngage";
            this.btnTestZprobeEngage.Size = new System.Drawing.Size(85, 23);
            this.btnTestZprobeEngage.TabIndex = 16;
            this.btnTestZprobeEngage.Text = "Test Engage";
            this.btnTestZprobeEngage.UseVisualStyleBackColor = true;
            this.btnTestZprobeEngage.Click += new System.EventHandler(this.btnTestZprobeEngage_Click);
            // 
            // btnTestZprobeEngageSave
            // 
            this.btnTestZprobeEngageSave.Location = new System.Drawing.Point(524, 77);
            this.btnTestZprobeEngageSave.Name = "btnTestZprobeEngageSave";
            this.btnTestZprobeEngageSave.Size = new System.Drawing.Size(53, 23);
            this.btnTestZprobeEngageSave.TabIndex = 15;
            this.btnTestZprobeEngageSave.Text = "Save";
            this.btnTestZprobeEngageSave.UseVisualStyleBackColor = true;
            this.btnTestZprobeEngageSave.Click += new System.EventHandler(this.btnTestZprobeEngageSave_Click);
            // 
            // txtBxGcodeAssistZprobeEngage
            // 
            this.txtBxGcodeAssistZprobeEngage.Location = new System.Drawing.Point(6, 19);
            this.txtBxGcodeAssistZprobeEngage.Multiline = true;
            this.txtBxGcodeAssistZprobeEngage.Name = "txtBxGcodeAssistZprobeEngage";
            this.txtBxGcodeAssistZprobeEngage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxGcodeAssistZprobeEngage.Size = new System.Drawing.Size(421, 78);
            this.txtBxGcodeAssistZprobeEngage.TabIndex = 11;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxGcodeAssistZprobeEngage, "G-Code that engage the Z-probe");
            // 
            // tabPageScanSurface
            // 
            this.tabPageScanSurface.Controls.Add(this.nChartControlSurface);
            this.tabPageScanSurface.Controls.Add(this.btnResetSurfaceChart);
            this.tabPageScanSurface.Controls.Add(this.numUpDownNumberOfRepetitions);
            this.tabPageScanSurface.Controls.Add(this.lblNumberOfRepetitions);
            this.tabPageScanSurface.Controls.Add(this.lblYpoints);
            this.tabPageScanSurface.Controls.Add(this.lblXpoints);
            this.tabPageScanSurface.Controls.Add(this.btnScanSurface);
            this.tabPageScanSurface.Controls.Add(this.numUpDownYpoints);
            this.tabPageScanSurface.Controls.Add(this.numUpDownXpoints);
            this.tabPageScanSurface.Location = new System.Drawing.Point(4, 40);
            this.tabPageScanSurface.Name = "tabPageScanSurface";
            this.tabPageScanSurface.Size = new System.Drawing.Size(652, 576);
            this.tabPageScanSurface.TabIndex = 9;
            this.tabPageScanSurface.Text = "Scan buildsurface";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageScanSurface, "Scan the building surface");
            this.tabPageScanSurface.UseVisualStyleBackColor = true;
            // 
            // nChartControlSurface
            // 
            this.nChartControlSurface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nChartControlSurface.AutoRefresh = false;
            this.nChartControlSurface.BackColor = System.Drawing.SystemColors.Control;
            this.nChartControlSurface.InputKeys = new System.Windows.Forms.Keys[0];
            this.nChartControlSurface.Location = new System.Drawing.Point(10, 74);
            this.nChartControlSurface.Name = "nChartControlSurface";
            this.nChartControlSurface.Size = new System.Drawing.Size(630, 508);
            this.nChartControlSurface.State = ((Nevron.Chart.WinForm.NState)(resources.GetObject("nChartControlSurface.State")));
            this.nChartControlSurface.TabIndex = 21;
            this.nChartControlSurface.Text = "nChartControl1";
            this.nChartControlSurface.Click += new System.EventHandler(this.nChartControlSurface_Click);
            // 
            // btnResetSurfaceChart
            // 
            this.btnResetSurfaceChart.Location = new System.Drawing.Point(314, 41);
            this.btnResetSurfaceChart.Name = "btnResetSurfaceChart";
            this.btnResetSurfaceChart.Size = new System.Drawing.Size(160, 23);
            this.btnResetSurfaceChart.TabIndex = 20;
            this.btnResetSurfaceChart.Text = "Reset";
            this.btnResetSurfaceChart.UseVisualStyleBackColor = true;
            this.btnResetSurfaceChart.Click += new System.EventHandler(this.btnMeshLevel_Click);
            // 
            // numUpDownNumberOfRepetitions
            // 
            this.numUpDownNumberOfRepetitions.Location = new System.Drawing.Point(263, 44);
            this.numUpDownNumberOfRepetitions.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownNumberOfRepetitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownNumberOfRepetitions.Name = "numUpDownNumberOfRepetitions";
            this.numUpDownNumberOfRepetitions.Size = new System.Drawing.Size(45, 20);
            this.numUpDownNumberOfRepetitions.TabIndex = 19;
            this.numUpDownNumberOfRepetitions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberOfRepetitions
            // 
            this.lblNumberOfRepetitions.AutoSize = true;
            this.lblNumberOfRepetitions.Location = new System.Drawing.Point(134, 46);
            this.lblNumberOfRepetitions.Name = "lblNumberOfRepetitions";
            this.lblNumberOfRepetitions.Size = new System.Drawing.Size(115, 13);
            this.lblNumberOfRepetitions.TabIndex = 18;
            this.lblNumberOfRepetitions.Text = "Number of Repetitions:";
            // 
            // lblYpoints
            // 
            this.lblYpoints.AutoSize = true;
            this.lblYpoints.Location = new System.Drawing.Point(157, 15);
            this.lblYpoints.Name = "lblYpoints";
            this.lblYpoints.Size = new System.Drawing.Size(100, 13);
            this.lblYpoints.TabIndex = 16;
            this.lblYpoints.Text = "Number of Y-points:";
            // 
            // lblXpoints
            // 
            this.lblXpoints.AutoSize = true;
            this.lblXpoints.Location = new System.Drawing.Point(3, 15);
            this.lblXpoints.Name = "lblXpoints";
            this.lblXpoints.Size = new System.Drawing.Size(100, 13);
            this.lblXpoints.TabIndex = 15;
            this.lblXpoints.Text = "Number of X-points:";
            // 
            // btnScanSurface
            // 
            this.btnScanSurface.Location = new System.Drawing.Point(314, 10);
            this.btnScanSurface.Name = "btnScanSurface";
            this.btnScanSurface.Size = new System.Drawing.Size(160, 23);
            this.btnScanSurface.TabIndex = 14;
            this.btnScanSurface.Text = "Start Scan of bed surface";
            this.btnScanSurface.UseVisualStyleBackColor = true;
            this.btnScanSurface.Click += new System.EventHandler(this.btnScanSurface_Click);
            // 
            // numUpDownYpoints
            // 
            this.numUpDownYpoints.Location = new System.Drawing.Point(263, 13);
            this.numUpDownYpoints.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDownYpoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownYpoints.Name = "numUpDownYpoints";
            this.numUpDownYpoints.Size = new System.Drawing.Size(45, 20);
            this.numUpDownYpoints.TabIndex = 1;
            this.numUpDownYpoints.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numUpDownXpoints
            // 
            this.numUpDownXpoints.Location = new System.Drawing.Point(106, 13);
            this.numUpDownXpoints.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDownXpoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownXpoints.Name = "numUpDownXpoints";
            this.numUpDownXpoints.Size = new System.Drawing.Size(45, 20);
            this.numUpDownXpoints.TabIndex = 0;
            this.numUpDownXpoints.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPagePID
            // 
            this.tabPagePID.Controls.Add(this.fctbPidResponce);
            this.tabPagePID.Controls.Add(this.grpBxHeatbedPID);
            this.tabPagePID.Controls.Add(this.grpBxExtruderPID);
            this.tabPagePID.Location = new System.Drawing.Point(4, 40);
            this.tabPagePID.Name = "tabPagePID";
            this.tabPagePID.Size = new System.Drawing.Size(652, 576);
            this.tabPagePID.TabIndex = 10;
            this.tabPagePID.Text = "PID";
            this.tabPagePID.UseVisualStyleBackColor = true;
            // 
            // fctbPidResponce
            // 
            this.fctbPidResponce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbPidResponce.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbPidResponce.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctbPidResponce.BackBrush = null;
            this.fctbPidResponce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctbPidResponce.CharHeight = 14;
            this.fctbPidResponce.CharWidth = 8;
            this.fctbPidResponce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbPidResponce.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbPidResponce.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbPidResponce.IsReplaceMode = false;
            this.fctbPidResponce.Location = new System.Drawing.Point(7, 376);
            this.fctbPidResponce.Name = "fctbPidResponce";
            this.fctbPidResponce.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbPidResponce.ReadOnly = true;
            this.fctbPidResponce.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbPidResponce.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbPidResponce.ServiceColors")));
            this.fctbPidResponce.ShowLineNumbers = false;
            this.fctbPidResponce.Size = new System.Drawing.Size(640, 334);
            this.fctbPidResponce.TabIndex = 16;
            this.fctbPidResponce.Zoom = 100;
            // 
            // grpBxHeatbedPID
            // 
            this.grpBxHeatbedPID.Controls.Add(this.groupBox9);
            this.grpBxHeatbedPID.Controls.Add(this.btnCalculateBedPid);
            this.grpBxHeatbedPID.Controls.Add(this.groupBox8);
            this.grpBxHeatbedPID.Controls.Add(this.groupBox7);
            this.grpBxHeatbedPID.Location = new System.Drawing.Point(332, 5);
            this.grpBxHeatbedPID.Name = "grpBxHeatbedPID";
            this.grpBxHeatbedPID.Size = new System.Drawing.Size(315, 373);
            this.grpBxHeatbedPID.TabIndex = 1;
            this.grpBxHeatbedPID.TabStop = false;
            this.grpBxHeatbedPID.Text = "Heatbed";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtBxKdBed);
            this.groupBox9.Controls.Add(this.txtBxKiBed);
            this.groupBox9.Controls.Add(this.txtBxKpBed);
            this.groupBox9.Controls.Add(this.btnUpdateBedPid);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Location = new System.Drawing.Point(3, 283);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(306, 82);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Result";
            // 
            // txtBxKdBed
            // 
            this.txtBxKdBed.Location = new System.Drawing.Point(181, 18);
            this.txtBxKdBed.Name = "txtBxKdBed";
            this.txtBxKdBed.Size = new System.Drawing.Size(43, 20);
            this.txtBxKdBed.TabIndex = 20;
            // 
            // txtBxKiBed
            // 
            this.txtBxKiBed.Location = new System.Drawing.Point(103, 18);
            this.txtBxKiBed.Name = "txtBxKiBed";
            this.txtBxKiBed.Size = new System.Drawing.Size(43, 20);
            this.txtBxKiBed.TabIndex = 19;
            // 
            // txtBxKpBed
            // 
            this.txtBxKpBed.Location = new System.Drawing.Point(29, 18);
            this.txtBxKpBed.Name = "txtBxKpBed";
            this.txtBxKpBed.Size = new System.Drawing.Size(43, 20);
            this.txtBxKpBed.TabIndex = 18;
            // 
            // btnUpdateBedPid
            // 
            this.btnUpdateBedPid.Location = new System.Drawing.Point(6, 45);
            this.btnUpdateBedPid.Name = "btnUpdateBedPid";
            this.btnUpdateBedPid.Size = new System.Drawing.Size(294, 23);
            this.btnUpdateBedPid.TabIndex = 11;
            this.btnUpdateBedPid.Text = "Update and Save EEPROM";
            this.btnUpdateBedPid.UseVisualStyleBackColor = true;
            this.btnUpdateBedPid.Click += new System.EventHandler(this.btnUpdateBedPid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ki:";
            // 
            // btnCalculateBedPid
            // 
            this.btnCalculateBedPid.Location = new System.Drawing.Point(3, 254);
            this.btnCalculateBedPid.Name = "btnCalculateBedPid";
            this.btnCalculateBedPid.Size = new System.Drawing.Size(306, 23);
            this.btnCalculateBedPid.TabIndex = 9;
            this.btnCalculateBedPid.Text = "PID Autotune for the Bed";
            this.btnCalculateBedPid.UseVisualStyleBackColor = true;
            this.btnCalculateBedPid.Click += new System.EventHandler(this.btnCalculateBedPid_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numUpDownPidBedCykles);
            this.groupBox8.Controls.Add(this.trkBarPidBedCykles);
            this.groupBox8.Location = new System.Drawing.Point(3, 150);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(306, 98);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Number of cykles";
            // 
            // numUpDownPidBedCykles
            // 
            this.numUpDownPidBedCykles.Location = new System.Drawing.Point(6, 70);
            this.numUpDownPidBedCykles.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDownPidBedCykles.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownPidBedCykles.Name = "numUpDownPidBedCykles";
            this.numUpDownPidBedCykles.Size = new System.Drawing.Size(294, 20);
            this.numUpDownPidBedCykles.TabIndex = 8;
            this.numUpDownPidBedCykles.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownPidBedCykles.ValueChanged += new System.EventHandler(this.numUpDownPidBedCykles_ValueChanged);
            // 
            // trkBarPidBedCykles
            // 
            this.trkBarPidBedCykles.LargeChange = 10;
            this.trkBarPidBedCykles.Location = new System.Drawing.Point(6, 18);
            this.trkBarPidBedCykles.Maximum = 20;
            this.trkBarPidBedCykles.Minimum = 2;
            this.trkBarPidBedCykles.Name = "trkBarPidBedCykles";
            this.trkBarPidBedCykles.Size = new System.Drawing.Size(294, 45);
            this.trkBarPidBedCykles.SmallChange = 5;
            this.trkBarPidBedCykles.TabIndex = 7;
            this.trkBarPidBedCykles.Value = 5;
            this.trkBarPidBedCykles.Scroll += new System.EventHandler(this.trkBarPidBedCykles_Scroll);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.trkBarPidBedTemp);
            this.groupBox7.Controls.Add(this.numUpDownPidBedTemp);
            this.groupBox7.Location = new System.Drawing.Point(3, 45);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(306, 100);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Temperature for Extruder PID calibration";
            // 
            // trkBarPidBedTemp
            // 
            this.trkBarPidBedTemp.LargeChange = 10;
            this.trkBarPidBedTemp.Location = new System.Drawing.Point(6, 19);
            this.trkBarPidBedTemp.Maximum = 300;
            this.trkBarPidBedTemp.Minimum = 170;
            this.trkBarPidBedTemp.Name = "trkBarPidBedTemp";
            this.trkBarPidBedTemp.Size = new System.Drawing.Size(294, 45);
            this.trkBarPidBedTemp.SmallChange = 5;
            this.trkBarPidBedTemp.TabIndex = 6;
            this.trkBarPidBedTemp.TickFrequency = 5;
            this.trkBarPidBedTemp.Value = 170;
            this.trkBarPidBedTemp.Scroll += new System.EventHandler(this.trkBarPidBedTemp_Scroll);
            // 
            // numUpDownPidBedTemp
            // 
            this.numUpDownPidBedTemp.Location = new System.Drawing.Point(6, 70);
            this.numUpDownPidBedTemp.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this.numUpDownPidBedTemp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDownPidBedTemp.Name = "numUpDownPidBedTemp";
            this.numUpDownPidBedTemp.Size = new System.Drawing.Size(294, 20);
            this.numUpDownPidBedTemp.TabIndex = 7;
            this.numUpDownPidBedTemp.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numUpDownPidBedTemp.ValueChanged += new System.EventHandler(this.numUpDownPidBedTemp_ValueChanged);
            // 
            // grpBxExtruderPID
            // 
            this.grpBxExtruderPID.Controls.Add(this.cmbBxPidExtruder);
            this.grpBxExtruderPID.Controls.Add(this.grpBxPidExtruder);
            this.grpBxExtruderPID.Controls.Add(this.grpBxPidExtruderTemp);
            this.grpBxExtruderPID.Controls.Add(this.grpBxPidExtruderCykles);
            this.grpBxExtruderPID.Controls.Add(this.btnCalculateExtruderPid);
            this.grpBxExtruderPID.Location = new System.Drawing.Point(3, 3);
            this.grpBxExtruderPID.Name = "grpBxExtruderPID";
            this.grpBxExtruderPID.Size = new System.Drawing.Size(323, 375);
            this.grpBxExtruderPID.TabIndex = 0;
            this.grpBxExtruderPID.TabStop = false;
            this.grpBxExtruderPID.Text = "Extruder(s)";
            // 
            // cmbBxPidExtruder
            // 
            this.cmbBxPidExtruder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxPidExtruder.FormattingEnabled = true;
            this.cmbBxPidExtruder.Location = new System.Drawing.Point(6, 20);
            this.cmbBxPidExtruder.Name = "cmbBxPidExtruder";
            this.cmbBxPidExtruder.Size = new System.Drawing.Size(311, 21);
            this.cmbBxPidExtruder.TabIndex = 9;
            // 
            // grpBxPidExtruder
            // 
            this.grpBxPidExtruder.Controls.Add(this.txtBxKdExtruder);
            this.grpBxPidExtruder.Controls.Add(this.txtBxKiExtruder);
            this.grpBxPidExtruder.Controls.Add(this.txtBxKpExtruder);
            this.grpBxPidExtruder.Controls.Add(this.lblKdExtruder);
            this.grpBxPidExtruder.Controls.Add(this.btnUpdateExtruderPid);
            this.grpBxPidExtruder.Controls.Add(this.lblKiExtruder);
            this.grpBxPidExtruder.Controls.Add(this.lblKpExtruder);
            this.grpBxPidExtruder.Location = new System.Drawing.Point(6, 285);
            this.grpBxPidExtruder.Name = "grpBxPidExtruder";
            this.grpBxPidExtruder.Size = new System.Drawing.Size(311, 82);
            this.grpBxPidExtruder.TabIndex = 7;
            this.grpBxPidExtruder.TabStop = false;
            this.grpBxPidExtruder.Text = "Result";
            // 
            // txtBxKdExtruder
            // 
            this.txtBxKdExtruder.Location = new System.Drawing.Point(184, 18);
            this.txtBxKdExtruder.Name = "txtBxKdExtruder";
            this.txtBxKdExtruder.Size = new System.Drawing.Size(43, 20);
            this.txtBxKdExtruder.TabIndex = 16;
            // 
            // txtBxKiExtruder
            // 
            this.txtBxKiExtruder.Location = new System.Drawing.Point(106, 18);
            this.txtBxKiExtruder.Name = "txtBxKiExtruder";
            this.txtBxKiExtruder.Size = new System.Drawing.Size(43, 20);
            this.txtBxKiExtruder.TabIndex = 15;
            // 
            // txtBxKpExtruder
            // 
            this.txtBxKpExtruder.Location = new System.Drawing.Point(32, 18);
            this.txtBxKpExtruder.Name = "txtBxKpExtruder";
            this.txtBxKpExtruder.Size = new System.Drawing.Size(43, 20);
            this.txtBxKpExtruder.TabIndex = 7;
            // 
            // lblKdExtruder
            // 
            this.lblKdExtruder.AutoSize = true;
            this.lblKdExtruder.Location = new System.Drawing.Point(155, 21);
            this.lblKdExtruder.Name = "lblKdExtruder";
            this.lblKdExtruder.Size = new System.Drawing.Size(23, 13);
            this.lblKdExtruder.TabIndex = 14;
            this.lblKdExtruder.Text = "Kd:";
            // 
            // btnUpdateExtruderPid
            // 
            this.btnUpdateExtruderPid.Location = new System.Drawing.Point(6, 45);
            this.btnUpdateExtruderPid.Name = "btnUpdateExtruderPid";
            this.btnUpdateExtruderPid.Size = new System.Drawing.Size(299, 23);
            this.btnUpdateExtruderPid.TabIndex = 10;
            this.btnUpdateExtruderPid.Text = "Update and Save EEPROM";
            this.btnUpdateExtruderPid.UseVisualStyleBackColor = true;
            this.btnUpdateExtruderPid.Click += new System.EventHandler(this.btnUpdateExtruderPid_Click);
            // 
            // lblKiExtruder
            // 
            this.lblKiExtruder.AutoSize = true;
            this.lblKiExtruder.Location = new System.Drawing.Point(81, 21);
            this.lblKiExtruder.Name = "lblKiExtruder";
            this.lblKiExtruder.Size = new System.Drawing.Size(19, 13);
            this.lblKiExtruder.TabIndex = 13;
            this.lblKiExtruder.Text = "Ki:";
            // 
            // lblKpExtruder
            // 
            this.lblKpExtruder.AutoSize = true;
            this.lblKpExtruder.Location = new System.Drawing.Point(3, 21);
            this.lblKpExtruder.Name = "lblKpExtruder";
            this.lblKpExtruder.Size = new System.Drawing.Size(23, 13);
            this.lblKpExtruder.TabIndex = 12;
            this.lblKpExtruder.Text = "Kp:";
            // 
            // grpBxPidExtruderTemp
            // 
            this.grpBxPidExtruderTemp.Controls.Add(this.trkBarPidExtruderTemp);
            this.grpBxPidExtruderTemp.Controls.Add(this.numUpDownPidExtruderTemp);
            this.grpBxPidExtruderTemp.Location = new System.Drawing.Point(6, 47);
            this.grpBxPidExtruderTemp.Name = "grpBxPidExtruderTemp";
            this.grpBxPidExtruderTemp.Size = new System.Drawing.Size(311, 100);
            this.grpBxPidExtruderTemp.TabIndex = 8;
            this.grpBxPidExtruderTemp.TabStop = false;
            this.grpBxPidExtruderTemp.Text = "Temperature for Extruder PID calibration";
            // 
            // trkBarPidExtruderTemp
            // 
            this.trkBarPidExtruderTemp.LargeChange = 10;
            this.trkBarPidExtruderTemp.Location = new System.Drawing.Point(6, 19);
            this.trkBarPidExtruderTemp.Maximum = 300;
            this.trkBarPidExtruderTemp.Minimum = 170;
            this.trkBarPidExtruderTemp.Name = "trkBarPidExtruderTemp";
            this.trkBarPidExtruderTemp.Size = new System.Drawing.Size(299, 45);
            this.trkBarPidExtruderTemp.SmallChange = 5;
            this.trkBarPidExtruderTemp.TabIndex = 6;
            this.trkBarPidExtruderTemp.TickFrequency = 5;
            this.trkBarPidExtruderTemp.Value = 170;
            this.trkBarPidExtruderTemp.Scroll += new System.EventHandler(this.trkBarPidExtruderTemp_Scroll);
            // 
            // numUpDownPidExtruderTemp
            // 
            this.numUpDownPidExtruderTemp.Location = new System.Drawing.Point(6, 70);
            this.numUpDownPidExtruderTemp.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numUpDownPidExtruderTemp.Minimum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.numUpDownPidExtruderTemp.Name = "numUpDownPidExtruderTemp";
            this.numUpDownPidExtruderTemp.Size = new System.Drawing.Size(299, 20);
            this.numUpDownPidExtruderTemp.TabIndex = 7;
            this.numUpDownPidExtruderTemp.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.numUpDownPidExtruderTemp.ValueChanged += new System.EventHandler(this.numUpDownPidExtruderTemp_ValueChanged);
            // 
            // grpBxPidExtruderCykles
            // 
            this.grpBxPidExtruderCykles.Controls.Add(this.numUpDownPidExtruderCykles);
            this.grpBxPidExtruderCykles.Controls.Add(this.trkBarPidExtruderCykles);
            this.grpBxPidExtruderCykles.Location = new System.Drawing.Point(6, 153);
            this.grpBxPidExtruderCykles.Name = "grpBxPidExtruderCykles";
            this.grpBxPidExtruderCykles.Size = new System.Drawing.Size(311, 98);
            this.grpBxPidExtruderCykles.TabIndex = 6;
            this.grpBxPidExtruderCykles.TabStop = false;
            this.grpBxPidExtruderCykles.Text = "Number of cykles";
            // 
            // numUpDownPidExtruderCykles
            // 
            this.numUpDownPidExtruderCykles.Location = new System.Drawing.Point(6, 70);
            this.numUpDownPidExtruderCykles.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDownPidExtruderCykles.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownPidExtruderCykles.Name = "numUpDownPidExtruderCykles";
            this.numUpDownPidExtruderCykles.Size = new System.Drawing.Size(299, 20);
            this.numUpDownPidExtruderCykles.TabIndex = 8;
            this.numUpDownPidExtruderCykles.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownPidExtruderCykles.ValueChanged += new System.EventHandler(this.numUpDownPidExtruderCykles_ValueChanged);
            // 
            // trkBarPidExtruderCykles
            // 
            this.trkBarPidExtruderCykles.LargeChange = 10;
            this.trkBarPidExtruderCykles.Location = new System.Drawing.Point(6, 18);
            this.trkBarPidExtruderCykles.Maximum = 20;
            this.trkBarPidExtruderCykles.Minimum = 2;
            this.trkBarPidExtruderCykles.Name = "trkBarPidExtruderCykles";
            this.trkBarPidExtruderCykles.Size = new System.Drawing.Size(299, 45);
            this.trkBarPidExtruderCykles.SmallChange = 5;
            this.trkBarPidExtruderCykles.TabIndex = 7;
            this.trkBarPidExtruderCykles.Value = 5;
            this.trkBarPidExtruderCykles.Scroll += new System.EventHandler(this.trkBarPidExtruderCykles_Scroll);
            // 
            // btnCalculateExtruderPid
            // 
            this.btnCalculateExtruderPid.Location = new System.Drawing.Point(6, 256);
            this.btnCalculateExtruderPid.Name = "btnCalculateExtruderPid";
            this.btnCalculateExtruderPid.Size = new System.Drawing.Size(311, 23);
            this.btnCalculateExtruderPid.TabIndex = 3;
            this.btnCalculateExtruderPid.Text = "PID Autotune for the Extruder";
            this.btnCalculateExtruderPid.UseVisualStyleBackColor = true;
            this.btnCalculateExtruderPid.Click += new System.EventHandler(this.btnCalculateExtruderPid_Click);
            // 
            // tabPageExtruderCalibration
            // 
            this.tabPageExtruderCalibration.Controls.Add(this.groupBox2);
            this.tabPageExtruderCalibration.Controls.Add(this.grpBxTestExtrude);
            this.tabPageExtruderCalibration.Location = new System.Drawing.Point(4, 40);
            this.tabPageExtruderCalibration.Name = "tabPageExtruderCalibration";
            this.tabPageExtruderCalibration.Size = new System.Drawing.Size(652, 576);
            this.tabPageExtruderCalibration.TabIndex = 2;
            this.tabPageExtruderCalibration.Text = "Extruder Calibration";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageExtruderCalibration, "Extruder calibration");
            this.tabPageExtruderCalibration.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmbBxExtruderCalibration);
            this.groupBox2.Controls.Add(this.chkBxColdExtruderCalibration);
            this.groupBox2.Controls.Add(this.numUpDnCalibrateExtruderTemp);
            this.groupBox2.Controls.Add(this.btnHeatExtruderForCalibration);
            this.groupBox2.Controls.Add(this.trkBarTemperature);
            this.groupBox2.Location = new System.Drawing.Point(7, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 174);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperarure";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbBxExtruderCalibration
            // 
            this.cmbBxExtruderCalibration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxExtruderCalibration.FormattingEnabled = true;
            this.cmbBxExtruderCalibration.Location = new System.Drawing.Point(6, 11);
            this.cmbBxExtruderCalibration.Name = "cmbBxExtruderCalibration";
            this.cmbBxExtruderCalibration.Size = new System.Drawing.Size(273, 21);
            this.cmbBxExtruderCalibration.TabIndex = 13;
            // 
            // chkBxColdExtruderCalibration
            // 
            this.chkBxColdExtruderCalibration.AutoSize = true;
            this.chkBxColdExtruderCalibration.Location = new System.Drawing.Point(9, 38);
            this.chkBxColdExtruderCalibration.Name = "chkBxColdExtruderCalibration";
            this.chkBxColdExtruderCalibration.Size = new System.Drawing.Size(139, 17);
            this.chkBxColdExtruderCalibration.TabIndex = 4;
            this.chkBxColdExtruderCalibration.Text = "Cold extruder calibration";
            this.chkBxColdExtruderCalibration.UseVisualStyleBackColor = true;
            this.chkBxColdExtruderCalibration.CheckedChanged += new System.EventHandler(this.chkBxColdExtruderCalibration_CheckedChanged);
            // 
            // numUpDnCalibrateExtruderTemp
            // 
            this.numUpDnCalibrateExtruderTemp.Location = new System.Drawing.Point(6, 112);
            this.numUpDnCalibrateExtruderTemp.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numUpDnCalibrateExtruderTemp.Minimum = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.numUpDnCalibrateExtruderTemp.Name = "numUpDnCalibrateExtruderTemp";
            this.numUpDnCalibrateExtruderTemp.Size = new System.Drawing.Size(273, 20);
            this.numUpDnCalibrateExtruderTemp.TabIndex = 3;
            this.numUpDnCalibrateExtruderTemp.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.numUpDnCalibrateExtruderTemp.ValueChanged += new System.EventHandler(this.NumUpDnCalibrateExtruderTemp_ValueChanged);
            // 
            // btnHeatExtruderForCalibration
            // 
            this.btnHeatExtruderForCalibration.Location = new System.Drawing.Point(6, 138);
            this.btnHeatExtruderForCalibration.Name = "btnHeatExtruderForCalibration";
            this.btnHeatExtruderForCalibration.Size = new System.Drawing.Size(273, 29);
            this.btnHeatExtruderForCalibration.TabIndex = 2;
            this.btnHeatExtruderForCalibration.Text = "Heat Extruder For Calibaration";
            this.btnHeatExtruderForCalibration.UseVisualStyleBackColor = true;
            this.btnHeatExtruderForCalibration.Click += new System.EventHandler(this.btnHeatExtruderForCalibration_Click);
            // 
            // trkBarTemperature
            // 
            this.trkBarTemperature.LargeChange = 10;
            this.trkBarTemperature.Location = new System.Drawing.Point(5, 61);
            this.trkBarTemperature.Maximum = 300;
            this.trkBarTemperature.Minimum = 170;
            this.trkBarTemperature.Name = "trkBarTemperature";
            this.trkBarTemperature.Size = new System.Drawing.Size(274, 45);
            this.trkBarTemperature.SmallChange = 5;
            this.trkBarTemperature.TabIndex = 0;
            this.trkBarTemperature.Value = 170;
            this.trkBarTemperature.Scroll += new System.EventHandler(this.trkBarTemperature_Scroll);
            // 
            // grpBxTestExtrude
            // 
            this.grpBxTestExtrude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxTestExtrude.Controls.Add(this.txtBxCurrentStepsPermm);
            this.grpBxTestExtrude.Controls.Add(this.lblExtrude);
            this.grpBxTestExtrude.Controls.Add(this.lblMeassure);
            this.grpBxTestExtrude.Controls.Add(this.numUpDnMeassure);
            this.grpBxTestExtrude.Controls.Add(this.btnExtruderCalibation);
            this.grpBxTestExtrude.Controls.Add(this.btnExtruderCalibrationCalculate);
            this.grpBxTestExtrude.Controls.Add(this.lblCurrentStepsPermm);
            this.grpBxTestExtrude.Controls.Add(this.numUpDnExtrude);
            this.grpBxTestExtrude.Location = new System.Drawing.Point(7, 193);
            this.grpBxTestExtrude.Name = "grpBxTestExtrude";
            this.grpBxTestExtrude.Size = new System.Drawing.Size(635, 142);
            this.grpBxTestExtrude.TabIndex = 9;
            this.grpBxTestExtrude.TabStop = false;
            this.grpBxTestExtrude.Text = "Test extrusion";
            this.grpBxTestExtrude.Visible = false;
            // 
            // txtBxCurrentStepsPermm
            // 
            this.txtBxCurrentStepsPermm.Location = new System.Drawing.Point(136, 65);
            this.txtBxCurrentStepsPermm.Name = "txtBxCurrentStepsPermm";
            this.txtBxCurrentStepsPermm.ReadOnly = true;
            this.txtBxCurrentStepsPermm.Size = new System.Drawing.Size(78, 20);
            this.txtBxCurrentStepsPermm.TabIndex = 12;
            // 
            // lblExtrude
            // 
            this.lblExtrude.AutoSize = true;
            this.lblExtrude.Location = new System.Drawing.Point(32, 27);
            this.lblExtrude.Name = "lblExtrude";
            this.lblExtrude.Size = new System.Drawing.Size(98, 13);
            this.lblExtrude.TabIndex = 3;
            this.lblExtrude.Text = "Test extrude length";
            // 
            // lblMeassure
            // 
            this.lblMeassure.AutoSize = true;
            this.lblMeassure.Location = new System.Drawing.Point(6, 95);
            this.lblMeassure.Name = "lblMeassure";
            this.lblMeassure.Size = new System.Drawing.Size(124, 13);
            this.lblMeassure.TabIndex = 7;
            this.lblMeassure.Text = "Meassured used filament";
            // 
            // numUpDnMeassure
            // 
            this.numUpDnMeassure.Location = new System.Drawing.Point(136, 93);
            this.numUpDnMeassure.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDnMeassure.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnMeassure.Name = "numUpDnMeassure";
            this.numUpDnMeassure.Size = new System.Drawing.Size(78, 20);
            this.numUpDnMeassure.TabIndex = 6;
            this.numUpDnMeassure.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnExtruderCalibation
            // 
            this.btnExtruderCalibation.Location = new System.Drawing.Point(220, 23);
            this.btnExtruderCalibation.Name = "btnExtruderCalibation";
            this.btnExtruderCalibation.Size = new System.Drawing.Size(97, 21);
            this.btnExtruderCalibation.TabIndex = 8;
            this.btnExtruderCalibation.Text = "Test extrude";
            this.btnExtruderCalibation.UseVisualStyleBackColor = true;
            this.btnExtruderCalibation.Click += new System.EventHandler(this.btnExtruderCalibation_Click);
            // 
            // btnExtruderCalibrationCalculate
            // 
            this.btnExtruderCalibrationCalculate.Location = new System.Drawing.Point(220, 64);
            this.btnExtruderCalibrationCalculate.Name = "btnExtruderCalibrationCalculate";
            this.btnExtruderCalibrationCalculate.Size = new System.Drawing.Size(97, 49);
            this.btnExtruderCalibrationCalculate.TabIndex = 10;
            this.btnExtruderCalibrationCalculate.Text = "Calculate";
            this.btnExtruderCalibrationCalculate.UseVisualStyleBackColor = true;
            this.btnExtruderCalibrationCalculate.Click += new System.EventHandler(this.btnExtruderCalibrationCalculate_Click);
            // 
            // lblCurrentStepsPermm
            // 
            this.lblCurrentStepsPermm.AutoSize = true;
            this.lblCurrentStepsPermm.Location = new System.Drawing.Point(21, 68);
            this.lblCurrentStepsPermm.Name = "lblCurrentStepsPermm";
            this.lblCurrentStepsPermm.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentStepsPermm.TabIndex = 5;
            this.lblCurrentStepsPermm.Text = "Current Steps-Per-mm";
            // 
            // numUpDnExtrude
            // 
            this.numUpDnExtrude.Location = new System.Drawing.Point(136, 25);
            this.numUpDnExtrude.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnExtrude.Name = "numUpDnExtrude";
            this.numUpDnExtrude.Size = new System.Drawing.Size(78, 20);
            this.numUpDnExtrude.TabIndex = 1;
            this.numUpDnExtrude.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabPageZMaintenance
            // 
            this.tabPageZMaintenance.Controls.Add(this.pictureBox5);
            this.tabPageZMaintenance.Controls.Add(this.grpBxZMaintenance);
            this.tabPageZMaintenance.Controls.Add(this.bindingControl);
            this.tabPageZMaintenance.Location = new System.Drawing.Point(4, 40);
            this.tabPageZMaintenance.Name = "tabPageZMaintenance";
            this.tabPageZMaintenance.Size = new System.Drawing.Size(652, 576);
            this.tabPageZMaintenance.TabIndex = 7;
            this.tabPageZMaintenance.Text = "Z  Maintenance";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageZMaintenance, "Move Z up and down for oiling and check for binding(s)");
            this.tabPageZMaintenance.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Work_in_progress;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(515, 450);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(116, 103);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // grpBxZMaintenance
            // 
            this.grpBxZMaintenance.Controls.Add(this.txtBxZmaintenanceDescription);
            this.grpBxZMaintenance.Controls.Add(this.grpZprobeConfigMax);
            this.grpBxZMaintenance.Controls.Add(this.btnZmaintenanceRun);
            this.grpBxZMaintenance.Controls.Add(this.btnZmaintenanceCancel);
            this.grpBxZMaintenance.Controls.Add(this.grpBxZmaintMax);
            this.grpBxZMaintenance.Controls.Add(this.lblZmaintenanceRepetitions);
            this.grpBxZMaintenance.Controls.Add(this.numUpDnZmaintenanceRepetitions);
            this.grpBxZMaintenance.Location = new System.Drawing.Point(11, 15);
            this.grpBxZMaintenance.Name = "grpBxZMaintenance";
            this.grpBxZMaintenance.Size = new System.Drawing.Size(638, 308);
            this.grpBxZMaintenance.TabIndex = 3;
            this.grpBxZMaintenance.TabStop = false;
            this.grpBxZMaintenance.Text = "Travel up and Down";
            // 
            // txtBxZmaintenanceDescription
            // 
            this.txtBxZmaintenanceDescription.Location = new System.Drawing.Point(321, 55);
            this.txtBxZmaintenanceDescription.Multiline = true;
            this.txtBxZmaintenanceDescription.Name = "txtBxZmaintenanceDescription";
            this.txtBxZmaintenanceDescription.ReadOnly = true;
            this.txtBxZmaintenanceDescription.Size = new System.Drawing.Size(311, 205);
            this.txtBxZmaintenanceDescription.TabIndex = 4;
            // 
            // grpZprobeConfigMax
            // 
            this.grpZprobeConfigMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpZprobeConfigMax.Controls.Add(this.lblZmaxTravel);
            this.grpZprobeConfigMax.Controls.Add(this.btnZmaxTravel);
            this.grpZprobeConfigMax.Controls.Add(this.numUpDnZmaxTravel);
            this.grpZprobeConfigMax.Controls.Add(this.trkBrZmaxTravel);
            this.grpZprobeConfigMax.Location = new System.Drawing.Point(6, 20);
            this.grpZprobeConfigMax.Name = "grpZprobeConfigMax";
            this.grpZprobeConfigMax.Size = new System.Drawing.Size(135, 283);
            this.grpZprobeConfigMax.TabIndex = 52;
            this.grpZprobeConfigMax.TabStop = false;
            this.grpZprobeConfigMax.Text = "Max Z travel";
            // 
            // lblZmaxTravel
            // 
            this.lblZmaxTravel.AutoSize = true;
            this.lblZmaxTravel.Location = new System.Drawing.Point(59, 18);
            this.lblZmaxTravel.Name = "lblZmaxTravel";
            this.lblZmaxTravel.Size = new System.Drawing.Size(67, 13);
            this.lblZmaxTravel.TabIndex = 2;
            this.lblZmaxTravel.Text = "Max Z in mm";
            // 
            // btnZmaxTravel
            // 
            this.btnZmaxTravel.Location = new System.Drawing.Point(59, 35);
            this.btnZmaxTravel.Name = "btnZmaxTravel";
            this.btnZmaxTravel.Size = new System.Drawing.Size(67, 23);
            this.btnZmaxTravel.TabIndex = 3;
            this.btnZmaxTravel.Text = "Save";
            this.btnZmaxTravel.UseVisualStyleBackColor = true;
            this.btnZmaxTravel.Click += new System.EventHandler(this.btnZmaxTravel_Click);
            // 
            // numUpDnZmaxTravel
            // 
            this.numUpDnZmaxTravel.Location = new System.Drawing.Point(59, 64);
            this.numUpDnZmaxTravel.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numUpDnZmaxTravel.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDnZmaxTravel.Name = "numUpDnZmaxTravel";
            this.numUpDnZmaxTravel.Size = new System.Drawing.Size(67, 20);
            this.numUpDnZmaxTravel.TabIndex = 1;
            this.numUpDnZmaxTravel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDnZmaxTravel.ValueChanged += new System.EventHandler(this.numUpDnZmaxTravel_ValueChanged);
            // 
            // trkBrZmaxTravel
            // 
            this.trkBrZmaxTravel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trkBrZmaxTravel.Location = new System.Drawing.Point(8, 18);
            this.trkBrZmaxTravel.Maximum = 300;
            this.trkBrZmaxTravel.Minimum = 100;
            this.trkBrZmaxTravel.Name = "trkBrZmaxTravel";
            this.trkBrZmaxTravel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBrZmaxTravel.Size = new System.Drawing.Size(45, 258);
            this.trkBrZmaxTravel.TabIndex = 0;
            this.trkBrZmaxTravel.Value = 100;
            this.trkBrZmaxTravel.Scroll += new System.EventHandler(this.trkBrZmaxTravel_Scroll);
            // 
            // btnZmaintenanceRun
            // 
            this.btnZmaintenanceRun.Location = new System.Drawing.Point(391, 274);
            this.btnZmaintenanceRun.Name = "btnZmaintenanceRun";
            this.btnZmaintenanceRun.Size = new System.Drawing.Size(75, 23);
            this.btnZmaintenanceRun.TabIndex = 6;
            this.btnZmaintenanceRun.Text = "Run";
            this.btnZmaintenanceRun.UseVisualStyleBackColor = true;
            this.btnZmaintenanceRun.Click += new System.EventHandler(this.btnZmaintenanceRun_Click);
            // 
            // btnZmaintenanceCancel
            // 
            this.btnZmaintenanceCancel.Location = new System.Drawing.Point(321, 274);
            this.btnZmaintenanceCancel.Name = "btnZmaintenanceCancel";
            this.btnZmaintenanceCancel.Size = new System.Drawing.Size(68, 23);
            this.btnZmaintenanceCancel.TabIndex = 7;
            this.btnZmaintenanceCancel.Text = "Cancel";
            this.btnZmaintenanceCancel.UseVisualStyleBackColor = true;
            this.btnZmaintenanceCancel.Click += new System.EventHandler(this.btnZmaintenanceCancel_Click);
            // 
            // grpBxZmaintMax
            // 
            this.grpBxZmaintMax.Controls.Add(this.trackBarZmaintenanceMin);
            this.grpBxZmaintMax.Controls.Add(this.trackBarZmaintenanceMax);
            this.grpBxZmaintMax.Location = new System.Drawing.Point(161, 21);
            this.grpBxZmaintMax.Name = "grpBxZmaintMax";
            this.grpBxZmaintMax.Size = new System.Drawing.Size(151, 282);
            this.grpBxZmaintMax.TabIndex = 6;
            this.grpBxZmaintMax.TabStop = false;
            this.grpBxZmaintMax.Text = "Move Z Between limits";
            // 
            // trackBarZmaintenanceMin
            // 
            this.trackBarZmaintenanceMin.Location = new System.Drawing.Point(6, 18);
            this.trackBarZmaintenanceMin.Maximum = 100;
            this.trackBarZmaintenanceMin.Minimum = 10;
            this.trackBarZmaintenanceMin.Name = "trackBarZmaintenanceMin";
            this.trackBarZmaintenanceMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarZmaintenanceMin.Size = new System.Drawing.Size(45, 258);
            this.trackBarZmaintenanceMin.TabIndex = 1;
            this.trackBarZmaintenanceMin.Value = 10;
            this.trackBarZmaintenanceMin.Scroll += new System.EventHandler(this.trackBarZmaintenanceMin_Scroll);
            // 
            // trackBarZmaintenanceMax
            // 
            this.trackBarZmaintenanceMax.Location = new System.Drawing.Point(100, 18);
            this.trackBarZmaintenanceMax.Maximum = 250;
            this.trackBarZmaintenanceMax.Minimum = 30;
            this.trackBarZmaintenanceMax.Name = "trackBarZmaintenanceMax";
            this.trackBarZmaintenanceMax.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarZmaintenanceMax.Size = new System.Drawing.Size(45, 256);
            this.trackBarZmaintenanceMax.TabIndex = 0;
            this.trackBarZmaintenanceMax.Value = 250;
            this.trackBarZmaintenanceMax.Scroll += new System.EventHandler(this.trackBarZmaintenanceMax_Scroll);
            // 
            // lblZmaintenanceRepetitions
            // 
            this.lblZmaintenanceRepetitions.AutoSize = true;
            this.lblZmaintenanceRepetitions.Location = new System.Drawing.Point(318, 15);
            this.lblZmaintenanceRepetitions.Name = "lblZmaintenanceRepetitions";
            this.lblZmaintenanceRepetitions.Size = new System.Drawing.Size(107, 13);
            this.lblZmaintenanceRepetitions.TabIndex = 5;
            this.lblZmaintenanceRepetitions.Text = "Number of repetitions";
            // 
            // numUpDnZmaintenanceRepetitions
            // 
            this.numUpDnZmaintenanceRepetitions.Location = new System.Drawing.Point(321, 31);
            this.numUpDnZmaintenanceRepetitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnZmaintenanceRepetitions.Name = "numUpDnZmaintenanceRepetitions";
            this.numUpDnZmaintenanceRepetitions.Size = new System.Drawing.Size(54, 20);
            this.numUpDnZmaintenanceRepetitions.TabIndex = 4;
            this.numUpDnZmaintenanceRepetitions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnZmaintenanceRepetitions.ValueChanged += new System.EventHandler(this.numUpDnZmaintenanceRepetitions_ValueChanged);
            // 
            // bindingControl
            // 
            this.bindingControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingControl.Location = new System.Drawing.Point(4, 334);
            this.bindingControl.Name = "bindingControl";
            this.bindingControl.Size = new System.Drawing.Size(645, 257);
            this.bindingControl.TabIndex = 53;
            // 
            // tabPageCalculations
            // 
            this.tabPageCalculations.Controls.Add(this.grpBxFeedRate);
            this.tabPageCalculations.Controls.Add(this.grpBxExtruderCalculation);
            this.tabPageCalculations.Controls.Add(this.grpBxBelts);
            this.tabPageCalculations.Controls.Add(this.grpBxLeadScrew);
            this.tabPageCalculations.Location = new System.Drawing.Point(4, 40);
            this.tabPageCalculations.Name = "tabPageCalculations";
            this.tabPageCalculations.Size = new System.Drawing.Size(652, 576);
            this.tabPageCalculations.TabIndex = 11;
            this.tabPageCalculations.Text = "Calculations";
            this.tabPageCalculations.UseVisualStyleBackColor = true;
            // 
            // grpBxFeedRate
            // 
            this.grpBxFeedRate.Controls.Add(this.numUpDnFeedRateMMperMinute);
            this.grpBxFeedRate.Controls.Add(this.lblFeedRateMMperMinute);
            this.grpBxFeedRate.Controls.Add(this.lblFeedRateMMperSecund);
            this.grpBxFeedRate.Controls.Add(this.numUpDnFeedRateMMperSecund);
            this.grpBxFeedRate.Location = new System.Drawing.Point(343, 380);
            this.grpBxFeedRate.Name = "grpBxFeedRate";
            this.grpBxFeedRate.Size = new System.Drawing.Size(200, 119);
            this.grpBxFeedRate.TabIndex = 25;
            this.grpBxFeedRate.TabStop = false;
            this.grpBxFeedRate.Text = "Feedrate";
            // 
            // numUpDnFeedRateMMperMinute
            // 
            this.numUpDnFeedRateMMperMinute.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperMinute.Location = new System.Drawing.Point(6, 92);
            this.numUpDnFeedRateMMperMinute.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperMinute.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperMinute.Name = "numUpDnFeedRateMMperMinute";
            this.numUpDnFeedRateMMperMinute.Size = new System.Drawing.Size(120, 20);
            this.numUpDnFeedRateMMperMinute.TabIndex = 34;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnFeedRateMMperMinute, "The standard feedrate as used within gcode is in millimeters per minute. For exam" +
        "ple:  G1 X90.6 Y13.8 E22.4 F3000");
            this.numUpDnFeedRateMMperMinute.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperMinute.ValueChanged += new System.EventHandler(this.numUpDnFeedRateMMperMinute_ValueChanged);
            // 
            // lblFeedRateMMperMinute
            // 
            this.lblFeedRateMMperMinute.AutoSize = true;
            this.lblFeedRateMMperMinute.Location = new System.Drawing.Point(3, 70);
            this.lblFeedRateMMperMinute.Name = "lblFeedRateMMperMinute";
            this.lblFeedRateMMperMinute.Size = new System.Drawing.Size(146, 13);
            this.lblFeedRateMMperMinute.TabIndex = 33;
            this.lblFeedRateMMperMinute.Text = "Gcode Feedrate (mm/Minute)";
            // 
            // lblFeedRateMMperSecund
            // 
            this.lblFeedRateMMperSecund.AutoSize = true;
            this.lblFeedRateMMperSecund.Location = new System.Drawing.Point(3, 20);
            this.lblFeedRateMMperSecund.Name = "lblFeedRateMMperSecund";
            this.lblFeedRateMMperSecund.Size = new System.Drawing.Size(84, 13);
            this.lblFeedRateMMperSecund.TabIndex = 32;
            this.lblFeedRateMMperSecund.Text = "Feedrate (mm/s)";
            // 
            // numUpDnFeedRateMMperSecund
            // 
            this.numUpDnFeedRateMMperSecund.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperSecund.Location = new System.Drawing.Point(6, 42);
            this.numUpDnFeedRateMMperSecund.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperSecund.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperSecund.Name = "numUpDnFeedRateMMperSecund";
            this.numUpDnFeedRateMMperSecund.Size = new System.Drawing.Size(120, 20);
            this.numUpDnFeedRateMMperSecund.TabIndex = 25;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnFeedRateMMperSecund, "Feedrate is normally used as mm per secund");
            this.numUpDnFeedRateMMperSecund.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnFeedRateMMperSecund.ValueChanged += new System.EventHandler(this.numUpDnFeedRateMMperSecund_ValueChanged);
            // 
            // grpBxExtruderCalculation
            // 
            this.grpBxExtruderCalculation.Controls.Add(this.pictureBox2);
            this.grpBxExtruderCalculation.Controls.Add(this.btnExtruderUpdateStepsPerMMinEEPROM);
            this.grpBxExtruderCalculation.Controls.Add(this.lblExtruderOldFirmware);
            this.grpBxExtruderCalculation.Controls.Add(this.numUpDnExtruderOldFirmware);
            this.grpBxExtruderCalculation.Controls.Add(this.numUpDnExtruderMeassuredExtrusion);
            this.grpBxExtruderCalculation.Controls.Add(this.lblExtruderMeassuredValue);
            this.grpBxExtruderCalculation.Controls.Add(this.lblExtruderExpectedValue);
            this.grpBxExtruderCalculation.Controls.Add(this.numUpDnExtruderExpectedValue);
            this.grpBxExtruderCalculation.Controls.Add(this.fastColoredTextBoxExtruderStepsPerMM);
            this.grpBxExtruderCalculation.Location = new System.Drawing.Point(343, 19);
            this.grpBxExtruderCalculation.Name = "grpBxExtruderCalculation";
            this.grpBxExtruderCalculation.Size = new System.Drawing.Size(200, 346);
            this.grpBxExtruderCalculation.TabIndex = 24;
            this.grpBxExtruderCalculation.TabStop = false;
            this.grpBxExtruderCalculation.Text = "Extruder";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Work_in_progress;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 82);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // btnExtruderUpdateStepsPerMMinEEPROM
            // 
            this.btnExtruderUpdateStepsPerMMinEEPROM.Location = new System.Drawing.Point(9, 216);
            this.btnExtruderUpdateStepsPerMMinEEPROM.Name = "btnExtruderUpdateStepsPerMMinEEPROM";
            this.btnExtruderUpdateStepsPerMMinEEPROM.Size = new System.Drawing.Size(174, 26);
            this.btnExtruderUpdateStepsPerMMinEEPROM.TabIndex = 30;
            this.btnExtruderUpdateStepsPerMMinEEPROM.Text = "Update and Save in EEPROM";
            this.toolTip3DprinterTool.SetToolTip(this.btnExtruderUpdateStepsPerMMinEEPROM, "Updates the EEPROM with the calculated value for Steps per mm");
            this.btnExtruderUpdateStepsPerMMinEEPROM.UseVisualStyleBackColor = true;
            this.btnExtruderUpdateStepsPerMMinEEPROM.Click += new System.EventHandler(this.btnExtruderUpdateStepsPerMMinEEPROM_Click);
            // 
            // lblExtruderOldFirmware
            // 
            this.lblExtruderOldFirmware.AutoSize = true;
            this.lblExtruderOldFirmware.Location = new System.Drawing.Point(6, 120);
            this.lblExtruderOldFirmware.Name = "lblExtruderOldFirmware";
            this.lblExtruderOldFirmware.Size = new System.Drawing.Size(143, 13);
            this.lblExtruderOldFirmware.TabIndex = 28;
            this.lblExtruderOldFirmware.Text = "Current Firmware Steps / mm";
            // 
            // numUpDnExtruderOldFirmware
            // 
            this.numUpDnExtruderOldFirmware.Location = new System.Drawing.Point(9, 142);
            this.numUpDnExtruderOldFirmware.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numUpDnExtruderOldFirmware.Name = "numUpDnExtruderOldFirmware";
            this.numUpDnExtruderOldFirmware.Size = new System.Drawing.Size(100, 20);
            this.numUpDnExtruderOldFirmware.TabIndex = 27;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnExtruderOldFirmware, "The current setting in Firmware. Can be found with M501");
            this.numUpDnExtruderOldFirmware.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numUpDnExtruderMeassuredExtrusion
            // 
            this.numUpDnExtruderMeassuredExtrusion.Location = new System.Drawing.Point(9, 92);
            this.numUpDnExtruderMeassuredExtrusion.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numUpDnExtruderMeassuredExtrusion.Name = "numUpDnExtruderMeassuredExtrusion";
            this.numUpDnExtruderMeassuredExtrusion.Size = new System.Drawing.Size(120, 20);
            this.numUpDnExtruderMeassuredExtrusion.TabIndex = 26;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnExtruderMeassuredExtrusion, "The actual amount of filament used");
            this.numUpDnExtruderMeassuredExtrusion.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblExtruderMeassuredValue
            // 
            this.lblExtruderMeassuredValue.AutoSize = true;
            this.lblExtruderMeassuredValue.Location = new System.Drawing.Point(6, 70);
            this.lblExtruderMeassuredValue.Name = "lblExtruderMeassuredValue";
            this.lblExtruderMeassuredValue.Size = new System.Drawing.Size(129, 13);
            this.lblExtruderMeassuredValue.TabIndex = 25;
            this.lblExtruderMeassuredValue.Text = "Meassured extrusion (mm)";
            // 
            // lblExtruderExpectedValue
            // 
            this.lblExtruderExpectedValue.AutoSize = true;
            this.lblExtruderExpectedValue.Location = new System.Drawing.Point(6, 20);
            this.lblExtruderExpectedValue.Name = "lblExtruderExpectedValue";
            this.lblExtruderExpectedValue.Size = new System.Drawing.Size(122, 13);
            this.lblExtruderExpectedValue.TabIndex = 23;
            this.lblExtruderExpectedValue.Text = "Expected extrusion (mm)";
            // 
            // numUpDnExtruderExpectedValue
            // 
            this.numUpDnExtruderExpectedValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnExtruderExpectedValue.Location = new System.Drawing.Point(9, 42);
            this.numUpDnExtruderExpectedValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDnExtruderExpectedValue.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDnExtruderExpectedValue.Name = "numUpDnExtruderExpectedValue";
            this.numUpDnExtruderExpectedValue.Size = new System.Drawing.Size(120, 20);
            this.numUpDnExtruderExpectedValue.TabIndex = 24;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnExtruderExpectedValue, "The amount of filament to be extruded ");
            this.numUpDnExtruderExpectedValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDnExtruderExpectedValue.ValueChanged += new System.EventHandler(this.numUpDnExtruderExpectedValue_ValueChanged);
            // 
            // fastColoredTextBoxExtruderStepsPerMM
            // 
            this.fastColoredTextBoxExtruderStepsPerMM.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxExtruderStepsPerMM.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBoxExtruderStepsPerMM.BackBrush = null;
            this.fastColoredTextBoxExtruderStepsPerMM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBoxExtruderStepsPerMM.CharHeight = 14;
            this.fastColoredTextBoxExtruderStepsPerMM.CharWidth = 8;
            this.fastColoredTextBoxExtruderStepsPerMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxExtruderStepsPerMM.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxExtruderStepsPerMM.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBoxExtruderStepsPerMM.IsReplaceMode = false;
            this.fastColoredTextBoxExtruderStepsPerMM.Location = new System.Drawing.Point(9, 168);
            this.fastColoredTextBoxExtruderStepsPerMM.Multiline = false;
            this.fastColoredTextBoxExtruderStepsPerMM.Name = "fastColoredTextBoxExtruderStepsPerMM";
            this.fastColoredTextBoxExtruderStepsPerMM.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxExtruderStepsPerMM.ReadOnly = true;
            this.fastColoredTextBoxExtruderStepsPerMM.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxExtruderStepsPerMM.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxExtruderStepsPerMM.ServiceColors")));
            this.fastColoredTextBoxExtruderStepsPerMM.ShowLineNumbers = false;
            this.fastColoredTextBoxExtruderStepsPerMM.ShowScrollBars = false;
            this.fastColoredTextBoxExtruderStepsPerMM.Size = new System.Drawing.Size(174, 27);
            this.fastColoredTextBoxExtruderStepsPerMM.TabIndex = 23;
            this.fastColoredTextBoxExtruderStepsPerMM.Zoom = 100;
            // 
            // grpBxBelts
            // 
            this.grpBxBelts.Controls.Add(this.numUpDnBeltPulleyTeethCount);
            this.grpBxBelts.Controls.Add(this.lblBeltPulleyTeethCount);
            this.grpBxBelts.Controls.Add(this.cmbBxBeltPitch);
            this.grpBxBelts.Controls.Add(this.lblBeltPitch);
            this.grpBxBelts.Controls.Add(this.fastColoredTextBoxBeltStepsPerMM);
            this.grpBxBelts.Controls.Add(this.numUpDnBeltTeethCount);
            this.grpBxBelts.Controls.Add(this.lblBeltTeethCount);
            this.grpBxBelts.Controls.Add(this.numUpDnBeltMotorTeethCount);
            this.grpBxBelts.Controls.Add(this.chkBxBeltDirectDriven);
            this.grpBxBelts.Controls.Add(this.lblBeltMotorTeethCount);
            this.grpBxBelts.Controls.Add(this.cmbBxBeltDriverMicrostepping);
            this.grpBxBelts.Controls.Add(this.lblBeltDriverMicrostepping);
            this.grpBxBelts.Controls.Add(this.cmbBxBeltMotorStepAngle);
            this.grpBxBelts.Controls.Add(this.lblBeltMotorStepAngle);
            this.grpBxBelts.Location = new System.Drawing.Point(180, 19);
            this.grpBxBelts.Name = "grpBxBelts";
            this.grpBxBelts.Size = new System.Drawing.Size(157, 385);
            this.grpBxBelts.TabIndex = 23;
            this.grpBxBelts.TabStop = false;
            this.grpBxBelts.Text = "Belts";
            // 
            // numUpDnBeltPulleyTeethCount
            // 
            this.numUpDnBeltPulleyTeethCount.Location = new System.Drawing.Point(6, 318);
            this.numUpDnBeltPulleyTeethCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnBeltPulleyTeethCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnBeltPulleyTeethCount.Name = "numUpDnBeltPulleyTeethCount";
            this.numUpDnBeltPulleyTeethCount.Size = new System.Drawing.Size(143, 20);
            this.numUpDnBeltPulleyTeethCount.TabIndex = 24;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnBeltPulleyTeethCount, "Pulley on Belt (Normally bigger pulley)");
            this.numUpDnBeltPulleyTeethCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnBeltPulleyTeethCount.ValueChanged += new System.EventHandler(this.numUpDnBeltPulleyTeethCount_ValueChanged);
            // 
            // lblBeltPulleyTeethCount
            // 
            this.lblBeltPulleyTeethCount.AutoSize = true;
            this.lblBeltPulleyTeethCount.Location = new System.Drawing.Point(3, 299);
            this.lblBeltPulleyTeethCount.Name = "lblBeltPulleyTeethCount";
            this.lblBeltPulleyTeethCount.Size = new System.Drawing.Size(112, 13);
            this.lblBeltPulleyTeethCount.TabIndex = 23;
            this.lblBeltPulleyTeethCount.Text = "Belt pulley teeth count";
            // 
            // cmbBxBeltPitch
            // 
            this.cmbBxBeltPitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBeltPitch.FormattingEnabled = true;
            this.cmbBxBeltPitch.Location = new System.Drawing.Point(6, 141);
            this.cmbBxBeltPitch.Name = "cmbBxBeltPitch";
            this.cmbBxBeltPitch.Size = new System.Drawing.Size(143, 21);
            this.cmbBxBeltPitch.TabIndex = 22;
            this.toolTip3DprinterTool.SetToolTip(this.cmbBxBeltPitch, "The pitch on the belt");
            this.cmbBxBeltPitch.SelectedIndexChanged += new System.EventHandler(this.cmbBxBeltPitch_SelectedIndexChanged);
            // 
            // lblBeltPitch
            // 
            this.lblBeltPitch.AutoSize = true;
            this.lblBeltPitch.Location = new System.Drawing.Point(3, 120);
            this.lblBeltPitch.Name = "lblBeltPitch";
            this.lblBeltPitch.Size = new System.Drawing.Size(51, 13);
            this.lblBeltPitch.TabIndex = 21;
            this.lblBeltPitch.Text = "Belt pitch";
            // 
            // fastColoredTextBoxBeltStepsPerMM
            // 
            this.fastColoredTextBoxBeltStepsPerMM.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxBeltStepsPerMM.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBoxBeltStepsPerMM.BackBrush = null;
            this.fastColoredTextBoxBeltStepsPerMM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBoxBeltStepsPerMM.CharHeight = 14;
            this.fastColoredTextBoxBeltStepsPerMM.CharWidth = 8;
            this.fastColoredTextBoxBeltStepsPerMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxBeltStepsPerMM.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxBeltStepsPerMM.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBoxBeltStepsPerMM.IsReplaceMode = false;
            this.fastColoredTextBoxBeltStepsPerMM.Location = new System.Drawing.Point(6, 344);
            this.fastColoredTextBoxBeltStepsPerMM.Multiline = false;
            this.fastColoredTextBoxBeltStepsPerMM.Name = "fastColoredTextBoxBeltStepsPerMM";
            this.fastColoredTextBoxBeltStepsPerMM.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxBeltStepsPerMM.ReadOnly = true;
            this.fastColoredTextBoxBeltStepsPerMM.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxBeltStepsPerMM.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxBeltStepsPerMM.ServiceColors")));
            this.fastColoredTextBoxBeltStepsPerMM.ShowLineNumbers = false;
            this.fastColoredTextBoxBeltStepsPerMM.ShowScrollBars = false;
            this.fastColoredTextBoxBeltStepsPerMM.Size = new System.Drawing.Size(143, 27);
            this.fastColoredTextBoxBeltStepsPerMM.TabIndex = 20;
            this.fastColoredTextBoxBeltStepsPerMM.Zoom = 100;
            // 
            // numUpDnBeltTeethCount
            // 
            this.numUpDnBeltTeethCount.Location = new System.Drawing.Point(6, 265);
            this.numUpDnBeltTeethCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnBeltTeethCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnBeltTeethCount.Name = "numUpDnBeltTeethCount";
            this.numUpDnBeltTeethCount.Size = new System.Drawing.Size(143, 20);
            this.numUpDnBeltTeethCount.TabIndex = 8;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnBeltTeethCount, "Pulley on Belt (Normally bigger pulley)");
            this.numUpDnBeltTeethCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnBeltTeethCount.ValueChanged += new System.EventHandler(this.numUpDnBeltTeethCount_ValueChanged);
            // 
            // lblBeltTeethCount
            // 
            this.lblBeltTeethCount.AutoSize = true;
            this.lblBeltTeethCount.Location = new System.Drawing.Point(3, 244);
            this.lblBeltTeethCount.Name = "lblBeltTeethCount";
            this.lblBeltTeethCount.Size = new System.Drawing.Size(82, 13);
            this.lblBeltTeethCount.TabIndex = 7;
            this.lblBeltTeethCount.Text = "Belt teeth count";
            // 
            // numUpDnBeltMotorTeethCount
            // 
            this.numUpDnBeltMotorTeethCount.Location = new System.Drawing.Point(6, 216);
            this.numUpDnBeltMotorTeethCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnBeltMotorTeethCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnBeltMotorTeethCount.Name = "numUpDnBeltMotorTeethCount";
            this.numUpDnBeltMotorTeethCount.Size = new System.Drawing.Size(143, 20);
            this.numUpDnBeltMotorTeethCount.TabIndex = 6;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnBeltMotorTeethCount, "The stepper motor pulley (Normally small pulley)");
            this.numUpDnBeltMotorTeethCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnBeltMotorTeethCount.ValueChanged += new System.EventHandler(this.numUpDnBeltMotorPulleyTeethCount_ValueChanged);
            // 
            // chkBxBeltDirectDriven
            // 
            this.chkBxBeltDirectDriven.AutoSize = true;
            this.chkBxBeltDirectDriven.Location = new System.Drawing.Point(6, 170);
            this.chkBxBeltDirectDriven.Name = "chkBxBeltDirectDriven";
            this.chkBxBeltDirectDriven.Size = new System.Drawing.Size(86, 17);
            this.chkBxBeltDirectDriven.TabIndex = 5;
            this.chkBxBeltDirectDriven.Text = "Direct driven";
            this.toolTip3DprinterTool.SetToolTip(this.chkBxBeltDirectDriven, "If directdrivven the ratio is 1:1");
            this.chkBxBeltDirectDriven.UseVisualStyleBackColor = true;
            this.chkBxBeltDirectDriven.CheckedChanged += new System.EventHandler(this.chkBxBeltDirectDriven_CheckedChanged);
            // 
            // lblBeltMotorTeethCount
            // 
            this.lblBeltMotorTeethCount.AutoSize = true;
            this.lblBeltMotorTeethCount.Location = new System.Drawing.Point(3, 195);
            this.lblBeltMotorTeethCount.Name = "lblBeltMotorTeethCount";
            this.lblBeltMotorTeethCount.Size = new System.Drawing.Size(91, 13);
            this.lblBeltMotorTeethCount.TabIndex = 4;
            this.lblBeltMotorTeethCount.Text = "Motor teeth count";
            // 
            // cmbBxBeltDriverMicrostepping
            // 
            this.cmbBxBeltDriverMicrostepping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBeltDriverMicrostepping.FormattingEnabled = true;
            this.cmbBxBeltDriverMicrostepping.Location = new System.Drawing.Point(6, 91);
            this.cmbBxBeltDriverMicrostepping.Name = "cmbBxBeltDriverMicrostepping";
            this.cmbBxBeltDriverMicrostepping.Size = new System.Drawing.Size(143, 21);
            this.cmbBxBeltDriverMicrostepping.TabIndex = 3;
            this.toolTip3DprinterTool.SetToolTip(this.cmbBxBeltDriverMicrostepping, "Microstepping (set by jumpers)");
            this.cmbBxBeltDriverMicrostepping.SelectedIndexChanged += new System.EventHandler(this.cmbBxBeltDriverMicrostepping_SelectedIndexChanged);
            // 
            // lblBeltDriverMicrostepping
            // 
            this.lblBeltDriverMicrostepping.AutoSize = true;
            this.lblBeltDriverMicrostepping.Location = new System.Drawing.Point(3, 70);
            this.lblBeltDriverMicrostepping.Name = "lblBeltDriverMicrostepping";
            this.lblBeltDriverMicrostepping.Size = new System.Drawing.Size(103, 13);
            this.lblBeltDriverMicrostepping.TabIndex = 2;
            this.lblBeltDriverMicrostepping.Text = "Driver microstepping";
            // 
            // cmbBxBeltMotorStepAngle
            // 
            this.cmbBxBeltMotorStepAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBeltMotorStepAngle.FormattingEnabled = true;
            this.cmbBxBeltMotorStepAngle.Location = new System.Drawing.Point(6, 41);
            this.cmbBxBeltMotorStepAngle.Name = "cmbBxBeltMotorStepAngle";
            this.cmbBxBeltMotorStepAngle.Size = new System.Drawing.Size(143, 21);
            this.cmbBxBeltMotorStepAngle.TabIndex = 1;
            this.toolTip3DprinterTool.SetToolTip(this.cmbBxBeltMotorStepAngle, "Microstepping (set by jumpers)");
            this.cmbBxBeltMotorStepAngle.SelectedIndexChanged += new System.EventHandler(this.cmbBxBeltMotorStepAngle_SelectedIndexChanged);
            // 
            // lblBeltMotorStepAngle
            // 
            this.lblBeltMotorStepAngle.AutoSize = true;
            this.lblBeltMotorStepAngle.Location = new System.Drawing.Point(3, 20);
            this.lblBeltMotorStepAngle.Name = "lblBeltMotorStepAngle";
            this.lblBeltMotorStepAngle.Size = new System.Drawing.Size(86, 13);
            this.lblBeltMotorStepAngle.TabIndex = 0;
            this.lblBeltMotorStepAngle.Text = "Motor step angle";
            // 
            // grpBxLeadScrew
            // 
            this.grpBxLeadScrew.Controls.Add(this.cmbBxLeadScrewPitch);
            this.grpBxLeadScrew.Controls.Add(this.lblLeadScrewPitch);
            this.grpBxLeadScrew.Controls.Add(this.fastColoredTextBoxLeadScrewStepsPerMM);
            this.grpBxLeadScrew.Controls.Add(this.numUpDnLeadScrewTeethCount);
            this.grpBxLeadScrew.Controls.Add(this.lblLeadscrewTeethCount);
            this.grpBxLeadScrew.Controls.Add(this.numUpDnLeadScrewMotorTeethCount);
            this.grpBxLeadScrew.Controls.Add(this.chkBxLeadScrewDirectDriven);
            this.grpBxLeadScrew.Controls.Add(this.lblLeadScrewMotorTeethCount);
            this.grpBxLeadScrew.Controls.Add(this.cmbBxLeadScrewDriverMicrostepping);
            this.grpBxLeadScrew.Controls.Add(this.lblLeadScrewDriverMicrostepping);
            this.grpBxLeadScrew.Controls.Add(this.cmbBxLeadScrewMotorStepAngle);
            this.grpBxLeadScrew.Controls.Add(this.lblLeadScrewMotorStepAngle);
            this.grpBxLeadScrew.Location = new System.Drawing.Point(17, 19);
            this.grpBxLeadScrew.Name = "grpBxLeadScrew";
            this.grpBxLeadScrew.Size = new System.Drawing.Size(157, 385);
            this.grpBxLeadScrew.TabIndex = 1;
            this.grpBxLeadScrew.TabStop = false;
            this.grpBxLeadScrew.Text = "Lead Screw";
            // 
            // cmbBxLeadScrewPitch
            // 
            this.cmbBxLeadScrewPitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLeadScrewPitch.FormattingEnabled = true;
            this.cmbBxLeadScrewPitch.Location = new System.Drawing.Point(6, 141);
            this.cmbBxLeadScrewPitch.Name = "cmbBxLeadScrewPitch";
            this.cmbBxLeadScrewPitch.Size = new System.Drawing.Size(143, 21);
            this.cmbBxLeadScrewPitch.TabIndex = 22;
            this.toolTip3DprinterTool.SetToolTip(this.cmbBxLeadScrewPitch, "The pitch on the leadscrew");
            this.cmbBxLeadScrewPitch.SelectedIndexChanged += new System.EventHandler(this.cmbBxLeadScrewPitch_SelectedIndexChanged);
            // 
            // lblLeadScrewPitch
            // 
            this.lblLeadScrewPitch.AutoSize = true;
            this.lblLeadScrewPitch.Location = new System.Drawing.Point(3, 120);
            this.lblLeadScrewPitch.Name = "lblLeadScrewPitch";
            this.lblLeadScrewPitch.Size = new System.Drawing.Size(85, 13);
            this.lblLeadScrewPitch.TabIndex = 21;
            this.lblLeadScrewPitch.Text = "Leadscrew pitch";
            // 
            // fastColoredTextBoxLeadScrewStepsPerMM
            // 
            this.fastColoredTextBoxLeadScrewStepsPerMM.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxLeadScrewStepsPerMM.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBoxLeadScrewStepsPerMM.BackBrush = null;
            this.fastColoredTextBoxLeadScrewStepsPerMM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBoxLeadScrewStepsPerMM.CharHeight = 14;
            this.fastColoredTextBoxLeadScrewStepsPerMM.CharWidth = 8;
            this.fastColoredTextBoxLeadScrewStepsPerMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxLeadScrewStepsPerMM.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxLeadScrewStepsPerMM.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBoxLeadScrewStepsPerMM.IsReplaceMode = false;
            this.fastColoredTextBoxLeadScrewStepsPerMM.Location = new System.Drawing.Point(6, 344);
            this.fastColoredTextBoxLeadScrewStepsPerMM.Multiline = false;
            this.fastColoredTextBoxLeadScrewStepsPerMM.Name = "fastColoredTextBoxLeadScrewStepsPerMM";
            this.fastColoredTextBoxLeadScrewStepsPerMM.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxLeadScrewStepsPerMM.ReadOnly = true;
            this.fastColoredTextBoxLeadScrewStepsPerMM.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxLeadScrewStepsPerMM.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxLeadScrewStepsPerMM.ServiceColors")));
            this.fastColoredTextBoxLeadScrewStepsPerMM.ShowLineNumbers = false;
            this.fastColoredTextBoxLeadScrewStepsPerMM.ShowScrollBars = false;
            this.fastColoredTextBoxLeadScrewStepsPerMM.Size = new System.Drawing.Size(143, 27);
            this.fastColoredTextBoxLeadScrewStepsPerMM.TabIndex = 20;
            this.fastColoredTextBoxLeadScrewStepsPerMM.Zoom = 100;
            // 
            // numUpDnLeadScrewTeethCount
            // 
            this.numUpDnLeadScrewTeethCount.Location = new System.Drawing.Point(6, 265);
            this.numUpDnLeadScrewTeethCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnLeadScrewTeethCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnLeadScrewTeethCount.Name = "numUpDnLeadScrewTeethCount";
            this.numUpDnLeadScrewTeethCount.Size = new System.Drawing.Size(143, 20);
            this.numUpDnLeadScrewTeethCount.TabIndex = 8;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnLeadScrewTeethCount, "Pulley on Leadscrew (Normally bigger pulley)");
            this.numUpDnLeadScrewTeethCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnLeadScrewTeethCount.ValueChanged += new System.EventHandler(this.numUpDnLeadScrewPulleyTeethCount_ValueChanged);
            // 
            // lblLeadscrewTeethCount
            // 
            this.lblLeadscrewTeethCount.AutoSize = true;
            this.lblLeadscrewTeethCount.Location = new System.Drawing.Point(3, 244);
            this.lblLeadscrewTeethCount.Name = "lblLeadscrewTeethCount";
            this.lblLeadscrewTeethCount.Size = new System.Drawing.Size(116, 13);
            this.lblLeadscrewTeethCount.TabIndex = 7;
            this.lblLeadscrewTeethCount.Text = "Leadscrew teeth count";
            // 
            // numUpDnLeadScrewMotorTeethCount
            // 
            this.numUpDnLeadScrewMotorTeethCount.Location = new System.Drawing.Point(6, 216);
            this.numUpDnLeadScrewMotorTeethCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnLeadScrewMotorTeethCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnLeadScrewMotorTeethCount.Name = "numUpDnLeadScrewMotorTeethCount";
            this.numUpDnLeadScrewMotorTeethCount.Size = new System.Drawing.Size(143, 20);
            this.numUpDnLeadScrewMotorTeethCount.TabIndex = 6;
            this.toolTip3DprinterTool.SetToolTip(this.numUpDnLeadScrewMotorTeethCount, "The stepper motor pulley (Normally small pulley)");
            this.numUpDnLeadScrewMotorTeethCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnLeadScrewMotorTeethCount.ValueChanged += new System.EventHandler(this.numUpDnLeadScrewMotorPulleyTeethCount_ValueChanged);
            // 
            // chkBxLeadScrewDirectDriven
            // 
            this.chkBxLeadScrewDirectDriven.AutoSize = true;
            this.chkBxLeadScrewDirectDriven.Location = new System.Drawing.Point(6, 170);
            this.chkBxLeadScrewDirectDriven.Name = "chkBxLeadScrewDirectDriven";
            this.chkBxLeadScrewDirectDriven.Size = new System.Drawing.Size(86, 17);
            this.chkBxLeadScrewDirectDriven.TabIndex = 5;
            this.chkBxLeadScrewDirectDriven.Text = "Direct driven";
            this.toolTip3DprinterTool.SetToolTip(this.chkBxLeadScrewDirectDriven, "If directdrivven the ratio is 1:1");
            this.chkBxLeadScrewDirectDriven.UseVisualStyleBackColor = true;
            this.chkBxLeadScrewDirectDriven.CheckedChanged += new System.EventHandler(this.chkBxLeadScrewDirectDriven_CheckedChanged);
            // 
            // lblLeadScrewMotorTeethCount
            // 
            this.lblLeadScrewMotorTeethCount.AutoSize = true;
            this.lblLeadScrewMotorTeethCount.Location = new System.Drawing.Point(3, 195);
            this.lblLeadScrewMotorTeethCount.Name = "lblLeadScrewMotorTeethCount";
            this.lblLeadScrewMotorTeethCount.Size = new System.Drawing.Size(91, 13);
            this.lblLeadScrewMotorTeethCount.TabIndex = 4;
            this.lblLeadScrewMotorTeethCount.Text = "Motor teeth count";
            // 
            // cmbBxLeadScrewDriverMicrostepping
            // 
            this.cmbBxLeadScrewDriverMicrostepping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLeadScrewDriverMicrostepping.FormattingEnabled = true;
            this.cmbBxLeadScrewDriverMicrostepping.Location = new System.Drawing.Point(6, 91);
            this.cmbBxLeadScrewDriverMicrostepping.Name = "cmbBxLeadScrewDriverMicrostepping";
            this.cmbBxLeadScrewDriverMicrostepping.Size = new System.Drawing.Size(143, 21);
            this.cmbBxLeadScrewDriverMicrostepping.TabIndex = 3;
            this.toolTip3DprinterTool.SetToolTip(this.cmbBxLeadScrewDriverMicrostepping, "Microstepping (set by jumpers)");
            this.cmbBxLeadScrewDriverMicrostepping.SelectedIndexChanged += new System.EventHandler(this.cmbBxLeadScrewDriverMicrostepping_SelectedIndexChanged);
            // 
            // lblLeadScrewDriverMicrostepping
            // 
            this.lblLeadScrewDriverMicrostepping.AutoSize = true;
            this.lblLeadScrewDriverMicrostepping.Location = new System.Drawing.Point(3, 70);
            this.lblLeadScrewDriverMicrostepping.Name = "lblLeadScrewDriverMicrostepping";
            this.lblLeadScrewDriverMicrostepping.Size = new System.Drawing.Size(103, 13);
            this.lblLeadScrewDriverMicrostepping.TabIndex = 2;
            this.lblLeadScrewDriverMicrostepping.Text = "Driver microstepping";
            // 
            // cmbBxLeadScrewMotorStepAngle
            // 
            this.cmbBxLeadScrewMotorStepAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLeadScrewMotorStepAngle.FormattingEnabled = true;
            this.cmbBxLeadScrewMotorStepAngle.Location = new System.Drawing.Point(6, 41);
            this.cmbBxLeadScrewMotorStepAngle.Name = "cmbBxLeadScrewMotorStepAngle";
            this.cmbBxLeadScrewMotorStepAngle.Size = new System.Drawing.Size(143, 21);
            this.cmbBxLeadScrewMotorStepAngle.TabIndex = 1;
            this.toolTip3DprinterTool.SetToolTip(this.cmbBxLeadScrewMotorStepAngle, "Stepperdriver type");
            this.cmbBxLeadScrewMotorStepAngle.SelectedIndexChanged += new System.EventHandler(this.cmbBxLeadScrewMotorStepAngle_SelectedIndexChanged);
            // 
            // lblLeadScrewMotorStepAngle
            // 
            this.lblLeadScrewMotorStepAngle.AutoSize = true;
            this.lblLeadScrewMotorStepAngle.Location = new System.Drawing.Point(3, 20);
            this.lblLeadScrewMotorStepAngle.Name = "lblLeadScrewMotorStepAngle";
            this.lblLeadScrewMotorStepAngle.Size = new System.Drawing.Size(86, 13);
            this.lblLeadScrewMotorStepAngle.TabIndex = 0;
            this.lblLeadScrewMotorStepAngle.Text = "Motor step angle";
            // 
            // tabPageParameters
            // 
            this.tabPageParameters.Controls.Add(this.btnResetFactorySettings);
            this.tabPageParameters.Controls.Add(this.btnM501ReadEeprom);
            this.tabPageParameters.Controls.Add(this.grpMeshBedLevel);
            this.tabPageParameters.Controls.Add(this.btnM500SaveEeprom);
            this.tabPageParameters.Controls.Add(this.grpPidBed);
            this.tabPageParameters.Controls.Add(this.grpPidExtruder);
            this.tabPageParameters.Controls.Add(this.grpHomeOffset);
            this.tabPageParameters.Controls.Add(this.grpBxAcceleration);
            this.tabPageParameters.Controls.Add(this.grpBxMaxAccelation);
            this.tabPageParameters.Controls.Add(this.grpBxMaxFeedrate);
            this.tabPageParameters.Controls.Add(this.grpBxStepsPerUnit);
            this.tabPageParameters.Controls.Add(this.fctbInit);
            this.tabPageParameters.Location = new System.Drawing.Point(4, 40);
            this.tabPageParameters.Name = "tabPageParameters";
            this.tabPageParameters.Size = new System.Drawing.Size(652, 576);
            this.tabPageParameters.TabIndex = 13;
            this.tabPageParameters.Text = "Parameters";
            this.tabPageParameters.UseVisualStyleBackColor = true;
            // 
            // btnResetFactorySettings
            // 
            this.btnResetFactorySettings.Location = new System.Drawing.Point(548, 524);
            this.btnResetFactorySettings.Name = "btnResetFactorySettings";
            this.btnResetFactorySettings.Size = new System.Drawing.Size(93, 34);
            this.btnResetFactorySettings.TabIndex = 31;
            this.btnResetFactorySettings.Text = "Reset To Factory (M502)";
            this.toolTip3DprinterTool.SetToolTip(this.btnResetFactorySettings, "Home Z");
            this.btnResetFactorySettings.UseVisualStyleBackColor = true;
            this.btnResetFactorySettings.Click += new System.EventHandler(this.btnResetFactorySettings_Click);
            // 
            // btnM501ReadEeprom
            // 
            this.btnM501ReadEeprom.Location = new System.Drawing.Point(450, 525);
            this.btnM501ReadEeprom.Name = "btnM501ReadEeprom";
            this.btnM501ReadEeprom.Size = new System.Drawing.Size(93, 34);
            this.btnM501ReadEeprom.TabIndex = 30;
            this.btnM501ReadEeprom.Text = "Read EEPROM (M501)";
            this.toolTip3DprinterTool.SetToolTip(this.btnM501ReadEeprom, "Home Z");
            this.btnM501ReadEeprom.UseVisualStyleBackColor = true;
            this.btnM501ReadEeprom.Click += new System.EventHandler(this.btnM501ReadEeprom_Click);
            // 
            // grpMeshBedLevel
            // 
            this.grpMeshBedLevel.Controls.Add(this.btnShowMeshInSurfaceChart);
            this.grpMeshBedLevel.Controls.Add(this.txtBxMeshBedLevelPointY);
            this.grpMeshBedLevel.Controls.Add(this.txtBxMeshBedLevelPointX);
            this.grpMeshBedLevel.Controls.Add(this.lblMeshBedLevelPointY);
            this.grpMeshBedLevel.Controls.Add(this.lblMeshBedLevelPointX);
            this.grpMeshBedLevel.Location = new System.Drawing.Point(351, 355);
            this.grpMeshBedLevel.Name = "grpMeshBedLevel";
            this.grpMeshBedLevel.Size = new System.Drawing.Size(118, 163);
            this.grpMeshBedLevel.TabIndex = 14;
            this.grpMeshBedLevel.TabStop = false;
            this.grpMeshBedLevel.Text = "Mesh Bed Level";
            // 
            // btnShowMeshInSurfaceChart
            // 
            this.btnShowMeshInSurfaceChart.Enabled = false;
            this.btnShowMeshInSurfaceChart.Location = new System.Drawing.Point(6, 122);
            this.btnShowMeshInSurfaceChart.Name = "btnShowMeshInSurfaceChart";
            this.btnShowMeshInSurfaceChart.Size = new System.Drawing.Size(106, 35);
            this.btnShowMeshInSurfaceChart.TabIndex = 9;
            this.btnShowMeshInSurfaceChart.Text = "Show Mesh in Surface Chart";
            this.btnShowMeshInSurfaceChart.UseVisualStyleBackColor = true;
            // 
            // txtBxMeshBedLevelPointY
            // 
            this.txtBxMeshBedLevelPointY.Location = new System.Drawing.Point(95, 24);
            this.txtBxMeshBedLevelPointY.Name = "txtBxMeshBedLevelPointY";
            this.txtBxMeshBedLevelPointY.Size = new System.Drawing.Size(17, 20);
            this.txtBxMeshBedLevelPointY.TabIndex = 3;
            // 
            // txtBxMeshBedLevelPointX
            // 
            this.txtBxMeshBedLevelPointX.Location = new System.Drawing.Point(57, 24);
            this.txtBxMeshBedLevelPointX.Name = "txtBxMeshBedLevelPointX";
            this.txtBxMeshBedLevelPointX.Size = new System.Drawing.Size(17, 20);
            this.txtBxMeshBedLevelPointX.TabIndex = 2;
            // 
            // lblMeshBedLevelPointY
            // 
            this.lblMeshBedLevelPointY.AutoSize = true;
            this.lblMeshBedLevelPointY.Location = new System.Drawing.Point(76, 27);
            this.lblMeshBedLevelPointY.Name = "lblMeshBedLevelPointY";
            this.lblMeshBedLevelPointY.Size = new System.Drawing.Size(17, 13);
            this.lblMeshBedLevelPointY.TabIndex = 1;
            this.lblMeshBedLevelPointY.Text = "Y:";
            // 
            // lblMeshBedLevelPointX
            // 
            this.lblMeshBedLevelPointX.AutoSize = true;
            this.lblMeshBedLevelPointX.Location = new System.Drawing.Point(6, 27);
            this.lblMeshBedLevelPointX.Name = "lblMeshBedLevelPointX";
            this.lblMeshBedLevelPointX.Size = new System.Drawing.Size(49, 13);
            this.lblMeshBedLevelPointX.TabIndex = 0;
            this.lblMeshBedLevelPointX.Text = "Points X:";
            // 
            // btnM500SaveEeprom
            // 
            this.btnM500SaveEeprom.Location = new System.Drawing.Point(352, 524);
            this.btnM500SaveEeprom.Name = "btnM500SaveEeprom";
            this.btnM500SaveEeprom.Size = new System.Drawing.Size(93, 34);
            this.btnM500SaveEeprom.TabIndex = 29;
            this.btnM500SaveEeprom.Text = "Save EEPROM (M500)";
            this.toolTip3DprinterTool.SetToolTip(this.btnM500SaveEeprom, "Home Z");
            this.btnM500SaveEeprom.UseVisualStyleBackColor = true;
            this.btnM500SaveEeprom.Click += new System.EventHandler(this.btnM500SaveEeprom_Click);
            // 
            // grpPidBed
            // 
            this.grpPidBed.Controls.Add(this.btnPidBedParameters);
            this.grpPidBed.Controls.Add(this.lblBedKd);
            this.grpPidBed.Controls.Add(this.lblBedKi);
            this.grpPidBed.Controls.Add(this.txtBxBedKd);
            this.grpPidBed.Controls.Add(this.txtBxBedKi);
            this.grpPidBed.Controls.Add(this.txtBxBedKp);
            this.grpPidBed.Controls.Add(this.lblBedKp);
            this.grpPidBed.Location = new System.Drawing.Point(549, 185);
            this.grpPidBed.Name = "grpPidBed";
            this.grpPidBed.Size = new System.Drawing.Size(93, 164);
            this.grpPidBed.TabIndex = 13;
            this.grpPidBed.TabStop = false;
            this.grpPidBed.Text = "PID bed";
            // 
            // btnPidBedParameters
            // 
            this.btnPidBedParameters.Location = new System.Drawing.Point(10, 129);
            this.btnPidBedParameters.Name = "btnPidBedParameters";
            this.btnPidBedParameters.Size = new System.Drawing.Size(75, 23);
            this.btnPidBedParameters.TabIndex = 8;
            this.btnPidBedParameters.Text = "M304";
            this.btnPidBedParameters.UseVisualStyleBackColor = true;
            this.btnPidBedParameters.Click += new System.EventHandler(this.btnPidBedParameters_Click);
            // 
            // lblBedKd
            // 
            this.lblBedKd.AutoSize = true;
            this.lblBedKd.Location = new System.Drawing.Point(7, 80);
            this.lblBedKd.Name = "lblBedKd";
            this.lblBedKd.Size = new System.Drawing.Size(18, 13);
            this.lblBedKd.TabIndex = 6;
            this.lblBedKd.Text = "D:";
            // 
            // lblBedKi
            // 
            this.lblBedKi.AutoSize = true;
            this.lblBedKi.Location = new System.Drawing.Point(7, 54);
            this.lblBedKi.Name = "lblBedKi";
            this.lblBedKi.Size = new System.Drawing.Size(13, 13);
            this.lblBedKi.TabIndex = 5;
            this.lblBedKi.Text = "I:";
            // 
            // txtBxBedKd
            // 
            this.txtBxBedKd.Location = new System.Drawing.Point(30, 77);
            this.txtBxBedKd.Name = "txtBxBedKd";
            this.txtBxBedKd.Size = new System.Drawing.Size(55, 20);
            this.txtBxBedKd.TabIndex = 3;
            // 
            // txtBxBedKi
            // 
            this.txtBxBedKi.Location = new System.Drawing.Point(30, 51);
            this.txtBxBedKi.Name = "txtBxBedKi";
            this.txtBxBedKi.Size = new System.Drawing.Size(55, 20);
            this.txtBxBedKi.TabIndex = 2;
            // 
            // txtBxBedKp
            // 
            this.txtBxBedKp.Location = new System.Drawing.Point(30, 25);
            this.txtBxBedKp.Name = "txtBxBedKp";
            this.txtBxBedKp.Size = new System.Drawing.Size(55, 20);
            this.txtBxBedKp.TabIndex = 1;
            // 
            // lblBedKp
            // 
            this.lblBedKp.AutoSize = true;
            this.lblBedKp.Location = new System.Drawing.Point(7, 28);
            this.lblBedKp.Name = "lblBedKp";
            this.lblBedKp.Size = new System.Drawing.Size(17, 13);
            this.lblBedKp.TabIndex = 0;
            this.lblBedKp.Text = "P:";
            // 
            // grpPidExtruder
            // 
            this.grpPidExtruder.Controls.Add(this.btnPidExtruderParameters);
            this.grpPidExtruder.Controls.Add(this.lblPidExtruderKd);
            this.grpPidExtruder.Controls.Add(this.lblPidExtruderKi);
            this.grpPidExtruder.Controls.Add(this.txtBxPidExtruderKd);
            this.grpPidExtruder.Controls.Add(this.txtBxPidExtruderKi);
            this.grpPidExtruder.Controls.Add(this.txtBxPidExtruderKp);
            this.grpPidExtruder.Controls.Add(this.lblPidExtruderKp);
            this.grpPidExtruder.Location = new System.Drawing.Point(450, 185);
            this.grpPidExtruder.Name = "grpPidExtruder";
            this.grpPidExtruder.Size = new System.Drawing.Size(93, 164);
            this.grpPidExtruder.TabIndex = 12;
            this.grpPidExtruder.TabStop = false;
            this.grpPidExtruder.Text = "PID extruder";
            // 
            // btnPidExtruderParameters
            // 
            this.btnPidExtruderParameters.Location = new System.Drawing.Point(10, 129);
            this.btnPidExtruderParameters.Name = "btnPidExtruderParameters";
            this.btnPidExtruderParameters.Size = new System.Drawing.Size(75, 23);
            this.btnPidExtruderParameters.TabIndex = 8;
            this.btnPidExtruderParameters.Text = "M301";
            this.btnPidExtruderParameters.UseVisualStyleBackColor = true;
            this.btnPidExtruderParameters.Click += new System.EventHandler(this.btnPidExtruderParameters_Click);
            // 
            // lblPidExtruderKd
            // 
            this.lblPidExtruderKd.AutoSize = true;
            this.lblPidExtruderKd.Location = new System.Drawing.Point(7, 80);
            this.lblPidExtruderKd.Name = "lblPidExtruderKd";
            this.lblPidExtruderKd.Size = new System.Drawing.Size(18, 13);
            this.lblPidExtruderKd.TabIndex = 6;
            this.lblPidExtruderKd.Text = "D:";
            // 
            // lblPidExtruderKi
            // 
            this.lblPidExtruderKi.AutoSize = true;
            this.lblPidExtruderKi.Location = new System.Drawing.Point(7, 54);
            this.lblPidExtruderKi.Name = "lblPidExtruderKi";
            this.lblPidExtruderKi.Size = new System.Drawing.Size(13, 13);
            this.lblPidExtruderKi.TabIndex = 5;
            this.lblPidExtruderKi.Text = "I:";
            // 
            // txtBxPidExtruderKd
            // 
            this.txtBxPidExtruderKd.Location = new System.Drawing.Point(30, 77);
            this.txtBxPidExtruderKd.Name = "txtBxPidExtruderKd";
            this.txtBxPidExtruderKd.Size = new System.Drawing.Size(55, 20);
            this.txtBxPidExtruderKd.TabIndex = 3;
            // 
            // txtBxPidExtruderKi
            // 
            this.txtBxPidExtruderKi.Location = new System.Drawing.Point(30, 51);
            this.txtBxPidExtruderKi.Name = "txtBxPidExtruderKi";
            this.txtBxPidExtruderKi.Size = new System.Drawing.Size(55, 20);
            this.txtBxPidExtruderKi.TabIndex = 2;
            // 
            // txtBxPidExtruderKp
            // 
            this.txtBxPidExtruderKp.Location = new System.Drawing.Point(30, 25);
            this.txtBxPidExtruderKp.Name = "txtBxPidExtruderKp";
            this.txtBxPidExtruderKp.Size = new System.Drawing.Size(55, 20);
            this.txtBxPidExtruderKp.TabIndex = 1;
            // 
            // lblPidExtruderKp
            // 
            this.lblPidExtruderKp.AutoSize = true;
            this.lblPidExtruderKp.Location = new System.Drawing.Point(7, 28);
            this.lblPidExtruderKp.Name = "lblPidExtruderKp";
            this.lblPidExtruderKp.Size = new System.Drawing.Size(17, 13);
            this.lblPidExtruderKp.TabIndex = 0;
            this.lblPidExtruderKp.Text = "P:";
            // 
            // grpHomeOffset
            // 
            this.grpHomeOffset.Controls.Add(this.btnHomeOffsetParameters);
            this.grpHomeOffset.Controls.Add(this.lblHomeOffsetZ);
            this.grpHomeOffset.Controls.Add(this.lblHomeOffsetY);
            this.grpHomeOffset.Controls.Add(this.txtBxHomeOffsetZ);
            this.grpHomeOffset.Controls.Add(this.txtBxHomeOffsetY);
            this.grpHomeOffset.Controls.Add(this.txtBxHomeOffsetX);
            this.grpHomeOffset.Controls.Add(this.lblHomeOffsetX);
            this.grpHomeOffset.Location = new System.Drawing.Point(351, 185);
            this.grpHomeOffset.Name = "grpHomeOffset";
            this.grpHomeOffset.Size = new System.Drawing.Size(93, 164);
            this.grpHomeOffset.TabIndex = 11;
            this.grpHomeOffset.TabStop = false;
            this.grpHomeOffset.Text = "Home offset";
            // 
            // btnHomeOffsetParameters
            // 
            this.btnHomeOffsetParameters.Location = new System.Drawing.Point(10, 129);
            this.btnHomeOffsetParameters.Name = "btnHomeOffsetParameters";
            this.btnHomeOffsetParameters.Size = new System.Drawing.Size(75, 23);
            this.btnHomeOffsetParameters.TabIndex = 8;
            this.btnHomeOffsetParameters.Text = "M206";
            this.btnHomeOffsetParameters.UseVisualStyleBackColor = true;
            this.btnHomeOffsetParameters.Click += new System.EventHandler(this.btnHomeOffsetParameters_Click);
            // 
            // lblHomeOffsetZ
            // 
            this.lblHomeOffsetZ.AutoSize = true;
            this.lblHomeOffsetZ.Location = new System.Drawing.Point(7, 80);
            this.lblHomeOffsetZ.Name = "lblHomeOffsetZ";
            this.lblHomeOffsetZ.Size = new System.Drawing.Size(17, 13);
            this.lblHomeOffsetZ.TabIndex = 6;
            this.lblHomeOffsetZ.Text = "Z:";
            // 
            // lblHomeOffsetY
            // 
            this.lblHomeOffsetY.AutoSize = true;
            this.lblHomeOffsetY.Location = new System.Drawing.Point(7, 54);
            this.lblHomeOffsetY.Name = "lblHomeOffsetY";
            this.lblHomeOffsetY.Size = new System.Drawing.Size(17, 13);
            this.lblHomeOffsetY.TabIndex = 5;
            this.lblHomeOffsetY.Text = "Y:";
            // 
            // txtBxHomeOffsetZ
            // 
            this.txtBxHomeOffsetZ.Location = new System.Drawing.Point(30, 77);
            this.txtBxHomeOffsetZ.Name = "txtBxHomeOffsetZ";
            this.txtBxHomeOffsetZ.Size = new System.Drawing.Size(55, 20);
            this.txtBxHomeOffsetZ.TabIndex = 3;
            // 
            // txtBxHomeOffsetY
            // 
            this.txtBxHomeOffsetY.Location = new System.Drawing.Point(30, 51);
            this.txtBxHomeOffsetY.Name = "txtBxHomeOffsetY";
            this.txtBxHomeOffsetY.Size = new System.Drawing.Size(55, 20);
            this.txtBxHomeOffsetY.TabIndex = 2;
            // 
            // txtBxHomeOffsetX
            // 
            this.txtBxHomeOffsetX.Location = new System.Drawing.Point(30, 25);
            this.txtBxHomeOffsetX.Name = "txtBxHomeOffsetX";
            this.txtBxHomeOffsetX.Size = new System.Drawing.Size(55, 20);
            this.txtBxHomeOffsetX.TabIndex = 1;
            // 
            // lblHomeOffsetX
            // 
            this.lblHomeOffsetX.AutoSize = true;
            this.lblHomeOffsetX.Location = new System.Drawing.Point(7, 28);
            this.lblHomeOffsetX.Name = "lblHomeOffsetX";
            this.lblHomeOffsetX.Size = new System.Drawing.Size(17, 13);
            this.lblHomeOffsetX.TabIndex = 0;
            this.lblHomeOffsetX.Text = "X:";
            // 
            // grpBxAcceleration
            // 
            this.grpBxAcceleration.Controls.Add(this.btnM204paremeters);
            this.grpBxAcceleration.Controls.Add(this.lblBxAccelerationTravel);
            this.grpBxAcceleration.Controls.Add(this.lblBxAccelerationRetract);
            this.grpBxAcceleration.Controls.Add(this.txtBxAccelerationTravel);
            this.grpBxAcceleration.Controls.Add(this.txtBxAccelerationRetract);
            this.grpBxAcceleration.Controls.Add(this.txtBxAccelerationPrint);
            this.grpBxAcceleration.Controls.Add(this.lblBxAccelerationPrint);
            this.grpBxAcceleration.Location = new System.Drawing.Point(480, 355);
            this.grpBxAcceleration.Name = "grpBxAcceleration";
            this.grpBxAcceleration.Size = new System.Drawing.Size(119, 164);
            this.grpBxAcceleration.TabIndex = 11;
            this.grpBxAcceleration.TabStop = false;
            this.grpBxAcceleration.Text = "Acceleration";
            // 
            // btnM204paremeters
            // 
            this.btnM204paremeters.Location = new System.Drawing.Point(10, 129);
            this.btnM204paremeters.Name = "btnM204paremeters";
            this.btnM204paremeters.Size = new System.Drawing.Size(103, 23);
            this.btnM204paremeters.TabIndex = 8;
            this.btnM204paremeters.Text = "M204";
            this.btnM204paremeters.UseVisualStyleBackColor = true;
            this.btnM204paremeters.Click += new System.EventHandler(this.btnM204paremeters_Click);
            // 
            // lblBxAccelerationTravel
            // 
            this.lblBxAccelerationTravel.AutoSize = true;
            this.lblBxAccelerationTravel.Location = new System.Drawing.Point(12, 80);
            this.lblBxAccelerationTravel.Name = "lblBxAccelerationTravel";
            this.lblBxAccelerationTravel.Size = new System.Drawing.Size(40, 13);
            this.lblBxAccelerationTravel.TabIndex = 6;
            this.lblBxAccelerationTravel.Text = "Travel:";
            // 
            // lblBxAccelerationRetract
            // 
            this.lblBxAccelerationRetract.AutoSize = true;
            this.lblBxAccelerationRetract.Location = new System.Drawing.Point(10, 54);
            this.lblBxAccelerationRetract.Name = "lblBxAccelerationRetract";
            this.lblBxAccelerationRetract.Size = new System.Drawing.Size(45, 13);
            this.lblBxAccelerationRetract.TabIndex = 5;
            this.lblBxAccelerationRetract.Text = "Retract:";
            // 
            // txtBxAccelerationTravel
            // 
            this.txtBxAccelerationTravel.Location = new System.Drawing.Point(58, 77);
            this.txtBxAccelerationTravel.Name = "txtBxAccelerationTravel";
            this.txtBxAccelerationTravel.Size = new System.Drawing.Size(55, 20);
            this.txtBxAccelerationTravel.TabIndex = 3;
            // 
            // txtBxAccelerationRetract
            // 
            this.txtBxAccelerationRetract.Location = new System.Drawing.Point(58, 51);
            this.txtBxAccelerationRetract.Name = "txtBxAccelerationRetract";
            this.txtBxAccelerationRetract.Size = new System.Drawing.Size(55, 20);
            this.txtBxAccelerationRetract.TabIndex = 2;
            // 
            // txtBxAccelerationPrint
            // 
            this.txtBxAccelerationPrint.Location = new System.Drawing.Point(58, 25);
            this.txtBxAccelerationPrint.Name = "txtBxAccelerationPrint";
            this.txtBxAccelerationPrint.Size = new System.Drawing.Size(55, 20);
            this.txtBxAccelerationPrint.TabIndex = 1;
            // 
            // lblBxAccelerationPrint
            // 
            this.lblBxAccelerationPrint.AutoSize = true;
            this.lblBxAccelerationPrint.Location = new System.Drawing.Point(21, 27);
            this.lblBxAccelerationPrint.Name = "lblBxAccelerationPrint";
            this.lblBxAccelerationPrint.Size = new System.Drawing.Size(31, 13);
            this.lblBxAccelerationPrint.TabIndex = 0;
            this.lblBxAccelerationPrint.Text = "Print:";
            // 
            // grpBxMaxAccelation
            // 
            this.grpBxMaxAccelation.Controls.Add(this.btnM201paremeters);
            this.grpBxMaxAccelation.Controls.Add(this.lblMaxAccelationE);
            this.grpBxMaxAccelation.Controls.Add(this.lblMaxAccelationZ);
            this.grpBxMaxAccelation.Controls.Add(this.lblMaxAccelationY);
            this.grpBxMaxAccelation.Controls.Add(this.txtBxMaxAccelationE);
            this.grpBxMaxAccelation.Controls.Add(this.txtBxMaxAccelationZ);
            this.grpBxMaxAccelation.Controls.Add(this.txtBxMaxAccelationY);
            this.grpBxMaxAccelation.Controls.Add(this.txtBxMaxAccelationX);
            this.grpBxMaxAccelation.Controls.Add(this.lblMaxAccelationX);
            this.grpBxMaxAccelation.Location = new System.Drawing.Point(549, 15);
            this.grpBxMaxAccelation.Name = "grpBxMaxAccelation";
            this.grpBxMaxAccelation.Size = new System.Drawing.Size(93, 164);
            this.grpBxMaxAccelation.TabIndex = 10;
            this.grpBxMaxAccelation.TabStop = false;
            this.grpBxMaxAccelation.Text = "Max Acceleration";
            // 
            // btnM201paremeters
            // 
            this.btnM201paremeters.Location = new System.Drawing.Point(10, 129);
            this.btnM201paremeters.Name = "btnM201paremeters";
            this.btnM201paremeters.Size = new System.Drawing.Size(75, 23);
            this.btnM201paremeters.TabIndex = 8;
            this.btnM201paremeters.Text = "M201";
            this.btnM201paremeters.UseVisualStyleBackColor = true;
            this.btnM201paremeters.Click += new System.EventHandler(this.btnM201paremeters_Click);
            // 
            // lblMaxAccelationE
            // 
            this.lblMaxAccelationE.AutoSize = true;
            this.lblMaxAccelationE.Location = new System.Drawing.Point(7, 106);
            this.lblMaxAccelationE.Name = "lblMaxAccelationE";
            this.lblMaxAccelationE.Size = new System.Drawing.Size(17, 13);
            this.lblMaxAccelationE.TabIndex = 7;
            this.lblMaxAccelationE.Text = "E:";
            // 
            // lblMaxAccelationZ
            // 
            this.lblMaxAccelationZ.AutoSize = true;
            this.lblMaxAccelationZ.Location = new System.Drawing.Point(7, 80);
            this.lblMaxAccelationZ.Name = "lblMaxAccelationZ";
            this.lblMaxAccelationZ.Size = new System.Drawing.Size(17, 13);
            this.lblMaxAccelationZ.TabIndex = 6;
            this.lblMaxAccelationZ.Text = "Z:";
            // 
            // lblMaxAccelationY
            // 
            this.lblMaxAccelationY.AutoSize = true;
            this.lblMaxAccelationY.Location = new System.Drawing.Point(7, 54);
            this.lblMaxAccelationY.Name = "lblMaxAccelationY";
            this.lblMaxAccelationY.Size = new System.Drawing.Size(17, 13);
            this.lblMaxAccelationY.TabIndex = 5;
            this.lblMaxAccelationY.Text = "Y:";
            // 
            // txtBxMaxAccelationE
            // 
            this.txtBxMaxAccelationE.Location = new System.Drawing.Point(30, 103);
            this.txtBxMaxAccelationE.Name = "txtBxMaxAccelationE";
            this.txtBxMaxAccelationE.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxAccelationE.TabIndex = 4;
            // 
            // txtBxMaxAccelationZ
            // 
            this.txtBxMaxAccelationZ.Location = new System.Drawing.Point(30, 77);
            this.txtBxMaxAccelationZ.Name = "txtBxMaxAccelationZ";
            this.txtBxMaxAccelationZ.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxAccelationZ.TabIndex = 3;
            // 
            // txtBxMaxAccelationY
            // 
            this.txtBxMaxAccelationY.Location = new System.Drawing.Point(30, 51);
            this.txtBxMaxAccelationY.Name = "txtBxMaxAccelationY";
            this.txtBxMaxAccelationY.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxAccelationY.TabIndex = 2;
            // 
            // txtBxMaxAccelationX
            // 
            this.txtBxMaxAccelationX.Location = new System.Drawing.Point(30, 25);
            this.txtBxMaxAccelationX.Name = "txtBxMaxAccelationX";
            this.txtBxMaxAccelationX.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxAccelationX.TabIndex = 1;
            // 
            // lblMaxAccelationX
            // 
            this.lblMaxAccelationX.AutoSize = true;
            this.lblMaxAccelationX.Location = new System.Drawing.Point(7, 28);
            this.lblMaxAccelationX.Name = "lblMaxAccelationX";
            this.lblMaxAccelationX.Size = new System.Drawing.Size(17, 13);
            this.lblMaxAccelationX.TabIndex = 0;
            this.lblMaxAccelationX.Text = "X:";
            // 
            // grpBxMaxFeedrate
            // 
            this.grpBxMaxFeedrate.Controls.Add(this.btnM203parameters);
            this.grpBxMaxFeedrate.Controls.Add(this.lblMaxFeedRateE);
            this.grpBxMaxFeedrate.Controls.Add(this.lblMaxFeedRateZ);
            this.grpBxMaxFeedrate.Controls.Add(this.lblMaxFeedRateY);
            this.grpBxMaxFeedrate.Controls.Add(this.txtBxMaxFeedRateE);
            this.grpBxMaxFeedrate.Controls.Add(this.txtBxMaxFeedRateZ);
            this.grpBxMaxFeedrate.Controls.Add(this.txtBxMaxFeedRateY);
            this.grpBxMaxFeedrate.Controls.Add(this.txtBxMaxFeedRateX);
            this.grpBxMaxFeedrate.Controls.Add(this.lblMaxFeedRateX);
            this.grpBxMaxFeedrate.Location = new System.Drawing.Point(450, 15);
            this.grpBxMaxFeedrate.Name = "grpBxMaxFeedrate";
            this.grpBxMaxFeedrate.Size = new System.Drawing.Size(93, 164);
            this.grpBxMaxFeedrate.TabIndex = 9;
            this.grpBxMaxFeedrate.TabStop = false;
            this.grpBxMaxFeedrate.Text = "Max Feedrate";
            // 
            // btnM203parameters
            // 
            this.btnM203parameters.Location = new System.Drawing.Point(10, 129);
            this.btnM203parameters.Name = "btnM203parameters";
            this.btnM203parameters.Size = new System.Drawing.Size(75, 23);
            this.btnM203parameters.TabIndex = 8;
            this.btnM203parameters.Text = "M203";
            this.btnM203parameters.UseVisualStyleBackColor = true;
            this.btnM203parameters.Click += new System.EventHandler(this.btnM203parameters_Click);
            // 
            // lblMaxFeedRateE
            // 
            this.lblMaxFeedRateE.AutoSize = true;
            this.lblMaxFeedRateE.Location = new System.Drawing.Point(7, 106);
            this.lblMaxFeedRateE.Name = "lblMaxFeedRateE";
            this.lblMaxFeedRateE.Size = new System.Drawing.Size(17, 13);
            this.lblMaxFeedRateE.TabIndex = 7;
            this.lblMaxFeedRateE.Text = "E:";
            // 
            // lblMaxFeedRateZ
            // 
            this.lblMaxFeedRateZ.AutoSize = true;
            this.lblMaxFeedRateZ.Location = new System.Drawing.Point(7, 80);
            this.lblMaxFeedRateZ.Name = "lblMaxFeedRateZ";
            this.lblMaxFeedRateZ.Size = new System.Drawing.Size(17, 13);
            this.lblMaxFeedRateZ.TabIndex = 6;
            this.lblMaxFeedRateZ.Text = "Z:";
            // 
            // lblMaxFeedRateY
            // 
            this.lblMaxFeedRateY.AutoSize = true;
            this.lblMaxFeedRateY.Location = new System.Drawing.Point(7, 54);
            this.lblMaxFeedRateY.Name = "lblMaxFeedRateY";
            this.lblMaxFeedRateY.Size = new System.Drawing.Size(17, 13);
            this.lblMaxFeedRateY.TabIndex = 5;
            this.lblMaxFeedRateY.Text = "Y:";
            // 
            // txtBxMaxFeedRateE
            // 
            this.txtBxMaxFeedRateE.Location = new System.Drawing.Point(30, 103);
            this.txtBxMaxFeedRateE.Name = "txtBxMaxFeedRateE";
            this.txtBxMaxFeedRateE.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxFeedRateE.TabIndex = 4;
            // 
            // txtBxMaxFeedRateZ
            // 
            this.txtBxMaxFeedRateZ.Location = new System.Drawing.Point(30, 77);
            this.txtBxMaxFeedRateZ.Name = "txtBxMaxFeedRateZ";
            this.txtBxMaxFeedRateZ.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxFeedRateZ.TabIndex = 3;
            // 
            // txtBxMaxFeedRateY
            // 
            this.txtBxMaxFeedRateY.Location = new System.Drawing.Point(30, 51);
            this.txtBxMaxFeedRateY.Name = "txtBxMaxFeedRateY";
            this.txtBxMaxFeedRateY.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxFeedRateY.TabIndex = 2;
            // 
            // txtBxMaxFeedRateX
            // 
            this.txtBxMaxFeedRateX.Location = new System.Drawing.Point(30, 25);
            this.txtBxMaxFeedRateX.Name = "txtBxMaxFeedRateX";
            this.txtBxMaxFeedRateX.Size = new System.Drawing.Size(55, 20);
            this.txtBxMaxFeedRateX.TabIndex = 1;
            // 
            // lblMaxFeedRateX
            // 
            this.lblMaxFeedRateX.AutoSize = true;
            this.lblMaxFeedRateX.Location = new System.Drawing.Point(7, 28);
            this.lblMaxFeedRateX.Name = "lblMaxFeedRateX";
            this.lblMaxFeedRateX.Size = new System.Drawing.Size(17, 13);
            this.lblMaxFeedRateX.TabIndex = 0;
            this.lblMaxFeedRateX.Text = "X:";
            // 
            // grpBxStepsPerUnit
            // 
            this.grpBxStepsPerUnit.Controls.Add(this.btnM92paremeters);
            this.grpBxStepsPerUnit.Controls.Add(this.lblStepsPerUnitE);
            this.grpBxStepsPerUnit.Controls.Add(this.lblStepsPerUnitZ);
            this.grpBxStepsPerUnit.Controls.Add(this.lblStepsPerUnitY);
            this.grpBxStepsPerUnit.Controls.Add(this.txtBxStepsPerUnitE);
            this.grpBxStepsPerUnit.Controls.Add(this.txtBxStepsPerUnitZ);
            this.grpBxStepsPerUnit.Controls.Add(this.txtBxStepsPerUnitY);
            this.grpBxStepsPerUnit.Controls.Add(this.txtBxStepsPerUnitX);
            this.grpBxStepsPerUnit.Controls.Add(this.lblStepsPerUnitX);
            this.grpBxStepsPerUnit.Location = new System.Drawing.Point(351, 15);
            this.grpBxStepsPerUnit.Name = "grpBxStepsPerUnit";
            this.grpBxStepsPerUnit.Size = new System.Drawing.Size(93, 164);
            this.grpBxStepsPerUnit.TabIndex = 3;
            this.grpBxStepsPerUnit.TabStop = false;
            this.grpBxStepsPerUnit.Text = "Steps Per Unit";
            // 
            // btnM92paremeters
            // 
            this.btnM92paremeters.Location = new System.Drawing.Point(10, 129);
            this.btnM92paremeters.Name = "btnM92paremeters";
            this.btnM92paremeters.Size = new System.Drawing.Size(75, 23);
            this.btnM92paremeters.TabIndex = 8;
            this.btnM92paremeters.Text = "M92";
            this.btnM92paremeters.UseVisualStyleBackColor = true;
            this.btnM92paremeters.Click += new System.EventHandler(this.btnM92paremeters_Click);
            // 
            // lblStepsPerUnitE
            // 
            this.lblStepsPerUnitE.AutoSize = true;
            this.lblStepsPerUnitE.Location = new System.Drawing.Point(7, 106);
            this.lblStepsPerUnitE.Name = "lblStepsPerUnitE";
            this.lblStepsPerUnitE.Size = new System.Drawing.Size(17, 13);
            this.lblStepsPerUnitE.TabIndex = 7;
            this.lblStepsPerUnitE.Text = "E:";
            // 
            // lblStepsPerUnitZ
            // 
            this.lblStepsPerUnitZ.AutoSize = true;
            this.lblStepsPerUnitZ.Location = new System.Drawing.Point(7, 80);
            this.lblStepsPerUnitZ.Name = "lblStepsPerUnitZ";
            this.lblStepsPerUnitZ.Size = new System.Drawing.Size(17, 13);
            this.lblStepsPerUnitZ.TabIndex = 6;
            this.lblStepsPerUnitZ.Text = "Z:";
            // 
            // lblStepsPerUnitY
            // 
            this.lblStepsPerUnitY.AutoSize = true;
            this.lblStepsPerUnitY.Location = new System.Drawing.Point(7, 54);
            this.lblStepsPerUnitY.Name = "lblStepsPerUnitY";
            this.lblStepsPerUnitY.Size = new System.Drawing.Size(17, 13);
            this.lblStepsPerUnitY.TabIndex = 5;
            this.lblStepsPerUnitY.Text = "Y:";
            // 
            // txtBxStepsPerUnitE
            // 
            this.txtBxStepsPerUnitE.Location = new System.Drawing.Point(30, 103);
            this.txtBxStepsPerUnitE.Name = "txtBxStepsPerUnitE";
            this.txtBxStepsPerUnitE.Size = new System.Drawing.Size(55, 20);
            this.txtBxStepsPerUnitE.TabIndex = 4;
            // 
            // txtBxStepsPerUnitZ
            // 
            this.txtBxStepsPerUnitZ.Location = new System.Drawing.Point(30, 77);
            this.txtBxStepsPerUnitZ.Name = "txtBxStepsPerUnitZ";
            this.txtBxStepsPerUnitZ.Size = new System.Drawing.Size(55, 20);
            this.txtBxStepsPerUnitZ.TabIndex = 3;
            // 
            // txtBxStepsPerUnitY
            // 
            this.txtBxStepsPerUnitY.Location = new System.Drawing.Point(30, 51);
            this.txtBxStepsPerUnitY.Name = "txtBxStepsPerUnitY";
            this.txtBxStepsPerUnitY.Size = new System.Drawing.Size(55, 20);
            this.txtBxStepsPerUnitY.TabIndex = 2;
            // 
            // txtBxStepsPerUnitX
            // 
            this.txtBxStepsPerUnitX.Location = new System.Drawing.Point(30, 25);
            this.txtBxStepsPerUnitX.Name = "txtBxStepsPerUnitX";
            this.txtBxStepsPerUnitX.Size = new System.Drawing.Size(55, 20);
            this.txtBxStepsPerUnitX.TabIndex = 1;
            // 
            // lblStepsPerUnitX
            // 
            this.lblStepsPerUnitX.AutoSize = true;
            this.lblStepsPerUnitX.Location = new System.Drawing.Point(7, 28);
            this.lblStepsPerUnitX.Name = "lblStepsPerUnitX";
            this.lblStepsPerUnitX.Size = new System.Drawing.Size(17, 13);
            this.lblStepsPerUnitX.TabIndex = 0;
            this.lblStepsPerUnitX.Text = "X:";
            // 
            // fctbInit
            // 
            this.fctbInit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fctbInit.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbInit.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctbInit.BackBrush = null;
            this.fctbInit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctbInit.CharHeight = 14;
            this.fctbInit.CharWidth = 8;
            this.fctbInit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbInit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbInit.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbInit.IsReplaceMode = false;
            this.fctbInit.Location = new System.Drawing.Point(3, 3);
            this.fctbInit.Name = "fctbInit";
            this.fctbInit.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbInit.ReadOnly = true;
            this.fctbInit.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbInit.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbInit.ServiceColors")));
            this.fctbInit.ShowLineNumbers = false;
            this.fctbInit.Size = new System.Drawing.Size(342, 550);
            this.fctbInit.TabIndex = 0;
            this.fctbInit.Zoom = 100;
            this.fctbInit.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctbInit_TextChanged);
            // 
            // grpBxNavigation
            // 
            this.grpBxNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxNavigation.Controls.Add(this.btnRetractZprobe);
            this.grpBxNavigation.Controls.Add(this.kompass);
            this.grpBxNavigation.Controls.Add(this.btnEngageZprobe);
            this.grpBxNavigation.Controls.Add(this.grpBxBed);
            this.grpBxNavigation.Controls.Add(this.btnHomeY);
            this.grpBxNavigation.Controls.Add(this.btnHomeX);
            this.grpBxNavigation.Controls.Add(this.verticalJogZprobeHeight);
            this.grpBxNavigation.Location = new System.Drawing.Point(3, 5);
            this.grpBxNavigation.MinimumSize = new System.Drawing.Size(310, 320);
            this.grpBxNavigation.Name = "grpBxNavigation";
            this.grpBxNavigation.Size = new System.Drawing.Size(310, 320);
            this.grpBxNavigation.TabIndex = 0;
            this.grpBxNavigation.TabStop = false;
            this.grpBxNavigation.Text = "Navigation";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxNavigation, "Navigation for saving positions");
            this.grpBxNavigation.Visible = false;
            this.grpBxNavigation.Enter += new System.EventHandler(this.grpBxNavigation_Enter);
            // 
            // btnRetractZprobe
            // 
            this.btnRetractZprobe.Location = new System.Drawing.Point(191, 267);
            this.btnRetractZprobe.Name = "btnRetractZprobe";
            this.btnRetractZprobe.Size = new System.Drawing.Size(57, 45);
            this.btnRetractZprobe.TabIndex = 28;
            this.btnRetractZprobe.Text = "Retract Z probe";
            this.toolTip3DprinterTool.SetToolTip(this.btnRetractZprobe, "Retract the Z-probe");
            this.btnRetractZprobe.UseVisualStyleBackColor = true;
            this.btnRetractZprobe.Click += new System.EventHandler(this.btnRetractZprobe_Click);
            // 
            // kompass
            // 
            this.kompass.Location = new System.Drawing.Point(6, 15);
            this.kompass.MarlinCommunication = null;
            this.kompass.MaximumSize = new System.Drawing.Size(246, 246);
            this.kompass.MinimumSize = new System.Drawing.Size(246, 246);
            this.kompass.Name = "kompass";
            this.kompass.SendCurrentPosition = true;
            this.kompass.Size = new System.Drawing.Size(246, 246);
            this.kompass.TabIndex = 4;
            this.toolTip3DprinterTool.SetToolTip(this.kompass, "Navigate the 3D printer in X and Y direction");
            this.kompass.Load += new System.EventHandler(this.txtBxProbeLift_Load);
            // 
            // btnEngageZprobe
            // 
            this.btnEngageZprobe.Location = new System.Drawing.Point(253, 267);
            this.btnEngageZprobe.Name = "btnEngageZprobe";
            this.btnEngageZprobe.Size = new System.Drawing.Size(52, 45);
            this.btnEngageZprobe.TabIndex = 13;
            this.btnEngageZprobe.Text = "Engage Z probe";
            this.toolTip3DprinterTool.SetToolTip(this.btnEngageZprobe, "Engage the Z-Probe ");
            this.btnEngageZprobe.UseVisualStyleBackColor = true;
            this.btnEngageZprobe.Click += new System.EventHandler(this.btnEngageZprobeScanSurface_Click);
            // 
            // grpBxBed
            // 
            this.grpBxBed.Location = new System.Drawing.Point(129, 267);
            this.grpBxBed.Name = "grpBxBed";
            this.grpBxBed.Size = new System.Drawing.Size(57, 45);
            this.grpBxBed.TabIndex = 2;
            this.grpBxBed.Text = "Home Z";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxBed, "Home Z");
            this.grpBxBed.UseVisualStyleBackColor = true;
            this.grpBxBed.Click += new System.EventHandler(this.btnHomeZ_Click);
            // 
            // btnHomeY
            // 
            this.btnHomeY.Location = new System.Drawing.Point(67, 267);
            this.btnHomeY.Name = "btnHomeY";
            this.btnHomeY.Size = new System.Drawing.Size(57, 45);
            this.btnHomeY.TabIndex = 1;
            this.btnHomeY.Text = "Home Y";
            this.toolTip3DprinterTool.SetToolTip(this.btnHomeY, "Home Y");
            this.btnHomeY.UseVisualStyleBackColor = true;
            this.btnHomeY.Click += new System.EventHandler(this.btnHomeY_Click);
            // 
            // btnHomeX
            // 
            this.btnHomeX.Location = new System.Drawing.Point(6, 267);
            this.btnHomeX.Name = "btnHomeX";
            this.btnHomeX.Size = new System.Drawing.Size(57, 45);
            this.btnHomeX.TabIndex = 0;
            this.btnHomeX.Text = "Home X";
            this.toolTip3DprinterTool.SetToolTip(this.btnHomeX, "Home X");
            this.btnHomeX.UseVisualStyleBackColor = true;
            this.btnHomeX.Click += new System.EventHandler(this.btnHomeX_Click);
            // 
            // verticalJogZprobeHeight
            // 
            this.verticalJogZprobeHeight.Location = new System.Drawing.Point(254, 15);
            this.verticalJogZprobeHeight.MarlinCommunication = null;
            this.verticalJogZprobeHeight.MaximumSize = new System.Drawing.Size(50, 250);
            this.verticalJogZprobeHeight.MinimumSize = new System.Drawing.Size(50, 250);
            this.verticalJogZprobeHeight.Name = "verticalJogZprobeHeight";
            this.verticalJogZprobeHeight.NegativeButtonsFirst = false;
            this.verticalJogZprobeHeight.SendCurrentPosition = false;
            this.verticalJogZprobeHeight.Size = new System.Drawing.Size(50, 250);
            this.verticalJogZprobeHeight.StepperMotor = "Z";
            this.verticalJogZprobeHeight.TabIndex = 27;
            this.verticalJogZprobeHeight.TextOver = "Z+";
            this.verticalJogZprobeHeight.TextUnder = "Z-";
            this.toolTip3DprinterTool.SetToolTip(this.verticalJogZprobeHeight, "Move the Nozzle Up and Down");
            this.verticalJogZprobeHeight.Visible100Movement = true;
            this.verticalJogZprobeHeight.Visible10Movement = true;
            this.verticalJogZprobeHeight.VisibleZero = true;
            this.verticalJogZprobeHeight.ZeroPositionAfterEachMove = true;
            // 
            // btnOpenMarlin
            // 
            this.btnOpenMarlin.Location = new System.Drawing.Point(0, 0);
            this.btnOpenMarlin.Name = "btnOpenMarlin";
            this.btnOpenMarlin.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMarlin.TabIndex = 0;
            // 
            // btnSaveArduinoIDE
            // 
            this.btnSaveArduinoIDE.Location = new System.Drawing.Point(541, 16);
            this.btnSaveArduinoIDE.Name = "btnSaveArduinoIDE";
            this.btnSaveArduinoIDE.Size = new System.Drawing.Size(75, 23);
            this.btnSaveArduinoIDE.TabIndex = 21;
            this.btnSaveArduinoIDE.Text = "Save";
            this.btnSaveArduinoIDE.UseVisualStyleBackColor = true;
            this.btnSaveArduinoIDE.Click += new System.EventHandler(this.btnSaveArduinoIDE_Click);
            // 
            // txtBxArduinoIDE
            // 
            this.txtBxArduinoIDE.Location = new System.Drawing.Point(10, 19);
            this.txtBxArduinoIDE.Name = "txtBxArduinoIDE";
            this.txtBxArduinoIDE.Size = new System.Drawing.Size(491, 20);
            this.txtBxArduinoIDE.TabIndex = 0;
            this.txtBxArduinoIDE.Text = "C:\\Program Files (x86)\\Arduino";
            // 
            // lblStepperDriverPulley
            // 
            this.lblStepperDriverPulley.Controls.Add(this.btnSetup);
            this.lblStepperDriverPulley.Controls.Add(this.btnShowCommunication);
            this.lblStepperDriverPulley.Controls.Add(this.cmbBxComPort);
            this.lblStepperDriverPulley.Controls.Add(this.cmbBxBaud);
            this.lblStepperDriverPulley.Controls.Add(this.btnConnect);
            this.lblStepperDriverPulley.Location = new System.Drawing.Point(12, 12);
            this.lblStepperDriverPulley.Name = "lblStepperDriverPulley";
            this.lblStepperDriverPulley.Size = new System.Drawing.Size(451, 50);
            this.lblStepperDriverPulley.TabIndex = 1;
            this.lblStepperDriverPulley.TabStop = false;
            this.lblStepperDriverPulley.Text = "Communication";
            // 
            // btnSetup
            // 
            this.btnSetup.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Setting;
            this.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetup.Location = new System.Drawing.Point(404, 12);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(41, 32);
            this.btnSetup.TabIndex = 22;
            this.btnSetup.Text = " ";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnShowCommunication
            // 
            this.btnShowCommunication.Location = new System.Drawing.Point(227, 18);
            this.btnShowCommunication.Name = "btnShowCommunication";
            this.btnShowCommunication.Size = new System.Drawing.Size(122, 21);
            this.btnShowCommunication.TabIndex = 21;
            this.btnShowCommunication.Text = "Show Communication";
            this.btnShowCommunication.UseVisualStyleBackColor = true;
            this.btnShowCommunication.Visible = false;
            this.btnShowCommunication.Click += new System.EventHandler(this.btnShowCommunication_Click_2);
            // 
            // cmbBxComPort
            // 
            this.cmbBxComPort.FormattingEnabled = true;
            this.cmbBxComPort.Location = new System.Drawing.Point(6, 19);
            this.cmbBxComPort.Name = "cmbBxComPort";
            this.cmbBxComPort.Size = new System.Drawing.Size(66, 21);
            this.cmbBxComPort.TabIndex = 5;
            this.cmbBxComPort.Text = "COM10";
            this.cmbBxComPort.SelectedIndexChanged += new System.EventHandler(this.cmbBxComPort_SelectedIndexChanged);
            // 
            // cmbBxBaud
            // 
            this.cmbBxBaud.FormattingEnabled = true;
            this.cmbBxBaud.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "230400",
            "250000",
            "256000",
            "460800",
            "921600"});
            this.cmbBxBaud.Location = new System.Drawing.Point(78, 19);
            this.cmbBxBaud.Name = "cmbBxBaud";
            this.cmbBxBaud.Size = new System.Drawing.Size(59, 21);
            this.cmbBxBaud.TabIndex = 6;
            this.cmbBxBaud.Text = "115200";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(143, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(78, 21);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBxCurrentBedSet
            // 
            this.txtBxCurrentBedSet.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBxCurrentBedSet.Location = new System.Drawing.Point(200, 19);
            this.txtBxCurrentBedSet.Name = "txtBxCurrentBedSet";
            this.txtBxCurrentBedSet.Size = new System.Drawing.Size(34, 20);
            this.txtBxCurrentBedSet.TabIndex = 6;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentBedSet, "Set Temp for Bed");
            // 
            // txtBxCurrentBedTemp
            // 
            this.txtBxCurrentBedTemp.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBxCurrentBedTemp.Location = new System.Drawing.Point(163, 19);
            this.txtBxCurrentBedTemp.Name = "txtBxCurrentBedTemp";
            this.txtBxCurrentBedTemp.Size = new System.Drawing.Size(34, 20);
            this.txtBxCurrentBedTemp.TabIndex = 5;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentBedTemp, "Temp of Bed");
            // 
            // txtBxCurrentExtruder2Set
            // 
            this.txtBxCurrentExtruder2Set.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtBxCurrentExtruder2Set.Location = new System.Drawing.Point(121, 19);
            this.txtBxCurrentExtruder2Set.Name = "txtBxCurrentExtruder2Set";
            this.txtBxCurrentExtruder2Set.Size = new System.Drawing.Size(34, 20);
            this.txtBxCurrentExtruder2Set.TabIndex = 4;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentExtruder2Set, "Set Temp for Secund Extruder");
            // 
            // txtBxCurrentExtruder2Temp
            // 
            this.txtBxCurrentExtruder2Temp.ForeColor = System.Drawing.Color.BlueViolet;
            this.txtBxCurrentExtruder2Temp.Location = new System.Drawing.Point(85, 19);
            this.txtBxCurrentExtruder2Temp.Name = "txtBxCurrentExtruder2Temp";
            this.txtBxCurrentExtruder2Temp.Size = new System.Drawing.Size(34, 20);
            this.txtBxCurrentExtruder2Temp.TabIndex = 3;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentExtruder2Temp, "Temp of Secund Extruder");
            // 
            // txtBxCurrentExtruder1Set
            // 
            this.txtBxCurrentExtruder1Set.ForeColor = System.Drawing.Color.Red;
            this.txtBxCurrentExtruder1Set.Location = new System.Drawing.Point(42, 19);
            this.txtBxCurrentExtruder1Set.Name = "txtBxCurrentExtruder1Set";
            this.txtBxCurrentExtruder1Set.Size = new System.Drawing.Size(34, 20);
            this.txtBxCurrentExtruder1Set.TabIndex = 2;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentExtruder1Set, "Set Temp for First Extruder");
            // 
            // txtBxCurrentExtruder1Temp
            // 
            this.txtBxCurrentExtruder1Temp.ForeColor = System.Drawing.Color.Red;
            this.txtBxCurrentExtruder1Temp.Location = new System.Drawing.Point(6, 19);
            this.txtBxCurrentExtruder1Temp.Name = "txtBxCurrentExtruder1Temp";
            this.txtBxCurrentExtruder1Temp.Size = new System.Drawing.Size(34, 20);
            this.txtBxCurrentExtruder1Temp.TabIndex = 1;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentExtruder1Temp, "Temp of First Extruder");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(5, 90);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl3DprinterTool);
            this.toolTip3DprinterTool.SetToolTip(this.splitContainer1.Panel1, "Adjust size with the splitbar in the middle");
            this.splitContainer1.Panel1MinSize = 670;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.grpBxTemperature);
            this.splitContainer1.Panel2.Controls.Add(this.grpBxNavigation);
            this.toolTip3DprinterTool.SetToolTip(this.splitContainer1.Panel2, "Adjust size with the splitbar in the middle");
            this.splitContainer1.Size = new System.Drawing.Size(999, 637);
            this.splitContainer1.SplitterDistance = 670;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 25;
            this.toolTip3DprinterTool.SetToolTip(this.splitContainer1, "Adjust size with the splitbar in the middle");
            // 
            // grpBxTemperature
            // 
            this.grpBxTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxTemperature.Controls.Add(this.btnGetTemp);
            this.grpBxTemperature.Controls.Add(this.txtBxCurrentBedSet);
            this.grpBxTemperature.Controls.Add(this.txtBxCurrentBedTemp);
            this.grpBxTemperature.Controls.Add(this.txtBxCurrentExtruder2Set);
            this.grpBxTemperature.Controls.Add(this.txtBxCurrentExtruder2Temp);
            this.grpBxTemperature.Controls.Add(this.txtBxCurrentExtruder1Set);
            this.grpBxTemperature.Controls.Add(this.txtBxCurrentExtruder1Temp);
            this.grpBxTemperature.Controls.Add(this.chartTemperature);
            this.grpBxTemperature.Location = new System.Drawing.Point(3, 331);
            this.grpBxTemperature.Name = "grpBxTemperature";
            this.grpBxTemperature.Size = new System.Drawing.Size(310, 292);
            this.grpBxTemperature.TabIndex = 22;
            this.grpBxTemperature.TabStop = false;
            this.grpBxTemperature.Text = "Extruder 1          Extruder 2           Bed";
            // 
            // btnGetTemp
            // 
            this.btnGetTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetTemp.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.nozzle_temperature;
            this.btnGetTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetTemp.Location = new System.Drawing.Point(241, 11);
            this.btnGetTemp.Name = "btnGetTemp";
            this.btnGetTemp.Size = new System.Drawing.Size(62, 34);
            this.btnGetTemp.TabIndex = 7;
            this.toolTip3DprinterTool.SetToolTip(this.btnGetTemp, "Get the current Temperature on all sensors");
            this.btnGetTemp.UseVisualStyleBackColor = true;
            this.btnGetTemp.Click += new System.EventHandler(this.btnGetTemp_Click);
            // 
            // chartTemperature
            // 
            this.chartTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea1);
            this.chartTemperature.Location = new System.Drawing.Point(3, 46);
            this.chartTemperature.Name = "chartTemperature";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chartTemperature.Series.Add(series1);
            this.chartTemperature.Size = new System.Drawing.Size(304, 243);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "chart1";
            // 
            // btnEmergency
            // 
            this.btnEmergency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmergency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmergency.Location = new System.Drawing.Point(638, 8);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(82, 76);
            this.btnEmergency.TabIndex = 22;
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Visible = false;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // btnFirmware
            // 
            this.btnFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirmware.Location = new System.Drawing.Point(724, 8);
            this.btnFirmware.Name = "btnFirmware";
            this.btnFirmware.Size = new System.Drawing.Size(113, 76);
            this.btnFirmware.TabIndex = 23;
            this.btnFirmware.Text = "Firmware and Arduino IDE";
            this.btnFirmware.UseVisualStyleBackColor = true;
            this.btnFirmware.Click += new System.EventHandler(this.btnFirmware_Click);
            // 
            // timerEndstop
            // 
            this.timerEndstop.Enabled = true;
            this.timerEndstop.Interval = 200;
            this.timerEndstop.Tick += new System.EventHandler(this.timerEndstop_Tick);
            // 
            // btnPayPal
            // 
            this.btnPayPal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayPal.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Donate;
            this.btnPayPal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayPal.Location = new System.Drawing.Point(843, 6);
            this.btnPayPal.Name = "btnPayPal";
            this.btnPayPal.Size = new System.Drawing.Size(161, 78);
            this.btnPayPal.TabIndex = 17;
            this.btnPayPal.UseVisualStyleBackColor = true;
            this.btnPayPal.Click += new System.EventHandler(this.btnPayPal_Click);
            // 
            // FrmMarlin3DprinterTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnPayPal);
            this.Controls.Add(this.btnFirmware);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.lblStepperDriverPulley);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FrmMarlin3DprinterTool";
            this.Text = "3DprinterTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm3DprinterTool_FormClosing);
            this.Load += new System.EventHandler(this.Frm3DprinterTool_Load);
            this.tabControl3DprinterTool.ResumeLayout(false);
            this.tabPageEndstop.ResumeLayout(false);
            this.grpBxZ.ResumeLayout(false);
            this.grpBxZ.PerformLayout();
            this.grpBxY.ResumeLayout(false);
            this.grpBxY.PerformLayout();
            this.grpBxX.ResumeLayout(false);
            this.grpBxX.PerformLayout();
            this.tabPageZoffset.ResumeLayout(false);
            this.grpBxM48Test.ResumeLayout(false);
            this.grpBxM48Test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumberOfM48Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbM48Test)).EndInit();
            this.grpBxZextraDistance.ResumeLayout(false);
            this.grpBxZextraDistance.PerformLayout();
            this.grpBxMeassureUsingProbe.ResumeLayout(false);
            this.grpBxMeassureUsingProbe.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.grpBxZprobeXoffset.ResumeLayout(false);
            this.grpBxZprobeXoffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWorkInProgressZprobe)).EndInit();
            this.tabPageConfigurationBed.ResumeLayout(false);
            this.panelConfigurationBedTab.ResumeLayout(false);
            this.panelBed.ResumeLayout(false);
            this.grpBxAdjusters.ResumeLayout(false);
            this.grpBxAdjusters.PerformLayout();
            this.tabPageConfigurationZprobe.ResumeLayout(false);
            this.grpBxBlTouch.ResumeLayout(false);
            this.grpBxBlTouch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxApprovedByBLTouch)).EndInit();
            this.grpAutoBedLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbAutoBedLevelResponce)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpBxEngageZprobe.ResumeLayout(false);
            this.grpBxEngageZprobe.PerformLayout();
            this.tabPageScanSurface.ResumeLayout(false);
            this.tabPageScanSurface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumberOfRepetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYpoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownXpoints)).EndInit();
            this.tabPagePID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbPidResponce)).EndInit();
            this.grpBxHeatbedPID.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidBedCykles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidBedCykles)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidBedTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidBedTemp)).EndInit();
            this.grpBxExtruderPID.ResumeLayout(false);
            this.grpBxPidExtruder.ResumeLayout(false);
            this.grpBxPidExtruder.PerformLayout();
            this.grpBxPidExtruderTemp.ResumeLayout(false);
            this.grpBxPidExtruderTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidExtruderTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidExtruderTemp)).EndInit();
            this.grpBxPidExtruderCykles.ResumeLayout(false);
            this.grpBxPidExtruderCykles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPidExtruderCykles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPidExtruderCykles)).EndInit();
            this.tabPageExtruderCalibration.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnCalibrateExtruderTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarTemperature)).EndInit();
            this.grpBxTestExtrude.ResumeLayout(false);
            this.grpBxTestExtrude.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMeassure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtrude)).EndInit();
            this.tabPageZMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.grpBxZMaintenance.ResumeLayout(false);
            this.grpBxZMaintenance.PerformLayout();
            this.grpZprobeConfigMax.ResumeLayout(false);
            this.grpZprobeConfigMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaxTravel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrZmaxTravel)).EndInit();
            this.grpBxZmaintMax.ResumeLayout(false);
            this.grpBxZmaintMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaintenanceRepetitions)).EndInit();
            this.tabPageCalculations.ResumeLayout(false);
            this.grpBxFeedRate.ResumeLayout(false);
            this.grpBxFeedRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperSecund)).EndInit();
            this.grpBxExtruderCalculation.ResumeLayout(false);
            this.grpBxExtruderCalculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtruderOldFirmware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtruderMeassuredExtrusion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtruderExpectedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxExtruderStepsPerMM)).EndInit();
            this.grpBxBelts.ResumeLayout(false);
            this.grpBxBelts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBeltPulleyTeethCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxBeltStepsPerMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBeltTeethCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBeltMotorTeethCount)).EndInit();
            this.grpBxLeadScrew.ResumeLayout(false);
            this.grpBxLeadScrew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxLeadScrewStepsPerMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLeadScrewTeethCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnLeadScrewMotorTeethCount)).EndInit();
            this.tabPageParameters.ResumeLayout(false);
            this.grpMeshBedLevel.ResumeLayout(false);
            this.grpMeshBedLevel.PerformLayout();
            this.grpPidBed.ResumeLayout(false);
            this.grpPidBed.PerformLayout();
            this.grpPidExtruder.ResumeLayout(false);
            this.grpPidExtruder.PerformLayout();
            this.grpHomeOffset.ResumeLayout(false);
            this.grpHomeOffset.PerformLayout();
            this.grpBxAcceleration.ResumeLayout(false);
            this.grpBxAcceleration.PerformLayout();
            this.grpBxMaxAccelation.ResumeLayout(false);
            this.grpBxMaxAccelation.PerformLayout();
            this.grpBxMaxFeedrate.ResumeLayout(false);
            this.grpBxMaxFeedrate.PerformLayout();
            this.grpBxStepsPerUnit.ResumeLayout(false);
            this.grpBxStepsPerUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbInit)).EndInit();
            this.grpBxNavigation.ResumeLayout(false);
            this.lblStepperDriverPulley.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpBxTemperature.ResumeLayout(false);
            this.grpBxTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl3DprinterTool;
        private TabPage tabPageEndstop;
        private GroupBox lblStepperDriverPulley;
        private GroupBox grpBxZ;
        private Label lblZmax;
        private Label lblZmin;
        private GroupBox grpBxY;
        private Label lblYmax;
        private Label lblYmin;
        private GroupBox grpBxX;
        private Label lblXmax;
        private Label lblXmin;
        private ComboBox cmbBxComPort;
        private ComboBox cmbBxBaud;
        private Button btnConnect;
        private TabPage tabPageExtruderCalibration;
        private GroupBox groupBox2;
        private TrackBar trkBarTemperature;
        private Button btnExtruderCalibrationCalculate;
        private Label lblCurrentStepsPermm;
        private NumericUpDown numUpDnMeassure;
        private Label lblMeassure;
        private GroupBox grpBxTestExtrude;
        private Label lblExtrude;
        private Button btnExtruderCalibation;
        private NumericUpDown numUpDnExtrude;
        private NumericUpDown numUpDnCalibrateExtruderTemp;
        private Button btnHeatExtruderForCalibration;
        private TextBox txtBxGcodeAssistZprobeEngage;
        private TabPage tabPageConfigurationBed;
        private ToolTip toolTip3DprinterTool;
        private GroupBox grpBxNavigation;
        private Button grpBxBed;
        private Button btnHomeY;
        private Button btnHomeX;
        private CheckedListBox chkListBxAdjustment;
        private Button btnProbeTheBed;
        private Button btnPayPal;
        private TabPage tabPageConfigurationZprobe;
        private GroupBox grpBxEngageZprobe;
        private GroupBox groupBox3;
        private TextBox txtBxGcodeAssistZprobeRelease;
        private Button btnTestZprobeRelease;
        private Button btnTestZprobeReleaseSave;
        private Button btnTestZprobeEngage;
        private Button btnTestZprobeEngageSave;
        private GroupBox grpAutoBedLevel;
        private Button btnAutoBedLevel;
        private TabPage tabPageZMaintenance;
        private TextBox txtBxZmaintenanceDescription;
        private GroupBox grpBxZMaintenance;
        private Label lblZmaintenanceRepetitions;
        private NumericUpDown numUpDnZmaintenanceRepetitions;
        private TrackBar trackBarZmaintenanceMin;
        private TrackBar trackBarZmaintenanceMax;
        private Button btnZmaintenanceCancel;
        private Button btnZmaintenanceRun;
        private GroupBox grpZprobeConfigMax;
        private Button btnZmaxTravel;
        private Label lblZmaxTravel;
        private NumericUpDown numUpDnZmaxTravel;
        private TrackBar trkBrZmaxTravel;
        private TextBox txtBxArduinoIDE;
        private Button btnSaveArduinoIDE;
        private Button btnOpenMarlin;
        private Button btnShowCommunication;
        private GroupBox grpBxAdjusters;
        private VerticalJog verticalJogZprobeHeight;
        private Kompass kompass;
        private GroupBox grpBxZmaintMax;
        private TabPage tabPageScanSurface;
        private Button btnEngageZprobe;
        private NumericUpDown numUpDownYpoints;
        private NumericUpDown numUpDownXpoints;
        private Label lblYpoints;
        private Label lblXpoints;
        private Button btnScanSurface;
        private CheckBox chkBxColdExtruderCalibration;
        private TabPage tabPagePID;
        private GroupBox grpBxHeatbedPID;
        private GroupBox grpBxExtruderPID;
        private NumericUpDown numUpDownNumberOfRepetitions;
        private Label lblNumberOfRepetitions;
        private LedBulbUserControl.LedBulb ledXmin;
        private LedBulbUserControl.LedBulb ledZmax;
        private LedBulbUserControl.LedBulb ledZmin;
        private LedBulbUserControl.LedBulb ledYmax;
        private LedBulbUserControl.LedBulb ledYmin;
        private LedBulbUserControl.LedBulb ledXmax;
        private Button btnCalculateExtruderPid;
        private Button btnRetractZprobe;
        private NumericUpDown numUpDownPidExtruderTemp;
        private TrackBar trkBarPidExtruderTemp;
        private GroupBox grpBxPidExtruderTemp;
        private GroupBox grpBxPidExtruderCykles;
        private NumericUpDown numUpDownPidExtruderCykles;
        private TrackBar trkBarPidExtruderCykles;
        private Button btnCalculateBedPid;
        private GroupBox groupBox8;
        private NumericUpDown numUpDownPidBedCykles;
        private TrackBar trkBarPidBedCykles;
        private GroupBox groupBox7;
        private TrackBar trkBarPidBedTemp;
        private NumericUpDown numUpDownPidBedTemp;
        private Button btnEmergency;
        private Button btnFirmware;
        private Button btnResetSurfaceChart;
        private Button btnUpdateBedPid;
        private Label lblKdExtruder;
        private Label lblKiExtruder;
        private Label lblKpExtruder;
        private Button btnUpdateExtruderPid;
        private GroupBox groupBox9;
        private TextBox txtBxKdBed;
        private TextBox txtBxKiBed;
        private TextBox txtBxKpBed;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox grpBxPidExtruder;
        private TextBox txtBxKdExtruder;
        private TextBox txtBxKiExtruder;
        private TextBox txtBxKpExtruder;
        private Button btnM501ReadEeprom;
        private Button btnM500SaveEeprom;
        private RadioButton rdoBn4point;
        private TabPage tabPageCalculations;
        private GroupBox grpBxLeadScrew;
        private FastColoredTextBox fastColoredTextBoxLeadScrewStepsPerMM;
        private NumericUpDown numUpDnLeadScrewTeethCount;
        private Label lblLeadscrewTeethCount;
        private NumericUpDown numUpDnLeadScrewMotorTeethCount;
        private CheckBox chkBxLeadScrewDirectDriven;
        private Label lblLeadScrewMotorTeethCount;
        private ComboBox cmbBxLeadScrewDriverMicrostepping;
        private Label lblLeadScrewDriverMicrostepping;
        private ComboBox cmbBxLeadScrewMotorStepAngle;
        private Label lblLeadScrewMotorStepAngle;
        private ComboBox cmbBxLeadScrewPitch;
        private Label lblLeadScrewPitch;
        private GroupBox grpBxBelts;
        private ComboBox cmbBxBeltPitch;
        private Label lblBeltPitch;
        private FastColoredTextBox fastColoredTextBoxBeltStepsPerMM;
        private NumericUpDown numUpDnBeltTeethCount;
        private Label lblBeltTeethCount;
        private NumericUpDown numUpDnBeltMotorTeethCount;
        private CheckBox chkBxBeltDirectDriven;
        private Label lblBeltMotorTeethCount;
        private ComboBox cmbBxBeltDriverMicrostepping;
        private Label lblBeltDriverMicrostepping;
        private ComboBox cmbBxBeltMotorStepAngle;
        private Label lblBeltMotorStepAngle;
        private GroupBox grpBxExtruderCalculation;
        private Button btnExtruderUpdateStepsPerMMinEEPROM;
        private Label lblExtruderOldFirmware;
        private NumericUpDown numUpDnExtruderOldFirmware;
        private NumericUpDown numUpDnExtruderMeassuredExtrusion;
        private Label lblExtruderMeassuredValue;
        private Label lblExtruderExpectedValue;
        private NumericUpDown numUpDnExtruderExpectedValue;
        private FastColoredTextBox fastColoredTextBoxExtruderStepsPerMM;
        private GroupBox grpBxFeedRate;
        private NumericUpDown numUpDnFeedRateMMperMinute;
        private Label lblFeedRateMMperMinute;
        private Label lblFeedRateMMperSecund;
        private NumericUpDown numUpDnFeedRateMMperSecund;
        private NumericUpDown numUpDnBeltPulleyTeethCount;
        private Label lblBeltPulleyTeethCount;
        private FastColoredTextBox fctbPidResponce;
        private TabPage tabPageParameters;
        private FastColoredTextBox fctbInit;
        private GroupBox grpBxStepsPerUnit;
        private Label lblStepsPerUnitE;
        private Label lblStepsPerUnitZ;
        private Label lblStepsPerUnitY;
        private TextBox txtBxStepsPerUnitE;
        private TextBox txtBxStepsPerUnitZ;
        private TextBox txtBxStepsPerUnitY;
        private TextBox txtBxStepsPerUnitX;
        private Label lblStepsPerUnitX;
        private Button btnM92paremeters;
        private GroupBox grpBxMaxFeedrate;
        private Button btnM203parameters;
        private Label lblMaxFeedRateE;
        private Label lblMaxFeedRateZ;
        private Label lblMaxFeedRateY;
        private TextBox txtBxMaxFeedRateE;
        private TextBox txtBxMaxFeedRateZ;
        private TextBox txtBxMaxFeedRateY;
        private TextBox txtBxMaxFeedRateX;
        private Label lblMaxFeedRateX;
        private GroupBox grpBxMaxAccelation;
        private Button btnM201paremeters;
        private Label lblMaxAccelationE;
        private Label lblMaxAccelationZ;
        private Label lblMaxAccelationY;
        private TextBox txtBxMaxAccelationE;
        private TextBox txtBxMaxAccelationZ;
        private TextBox txtBxMaxAccelationY;
        private TextBox txtBxMaxAccelationX;
        private Label lblMaxAccelationX;
        private GroupBox grpBxAcceleration;
        private Button btnM204paremeters;
        private Label lblBxAccelerationTravel;
        private Label lblBxAccelerationRetract;
        private TextBox txtBxAccelerationTravel;
        private TextBox txtBxAccelerationRetract;
        private TextBox txtBxAccelerationPrint;
        private Label lblBxAccelerationPrint;
        private GroupBox grpHomeOffset;
        private Button btnHomeOffsetParameters;
        private Label lblHomeOffsetZ;
        private Label lblHomeOffsetY;
        private TextBox txtBxHomeOffsetZ;
        private TextBox txtBxHomeOffsetY;
        private TextBox txtBxHomeOffsetX;
        private Label lblHomeOffsetX;
        private GroupBox grpPidBed;
        private Button btnPidBedParameters;
        private Label lblBedKd;
        private Label lblBedKi;
        private TextBox txtBxBedKd;
        private TextBox txtBxBedKi;
        private TextBox txtBxBedKp;
        private Label lblBedKp;
        private GroupBox grpPidExtruder;
        private Button btnPidExtruderParameters;
        private Label lblPidExtruderKd;
        private Label lblPidExtruderKi;
        private TextBox txtBxPidExtruderKd;
        private TextBox txtBxPidExtruderKi;
        private TextBox txtBxPidExtruderKp;
        private Label lblPidExtruderKp;
        private GroupBox grpMeshBedLevel;
        private Button btnShowMeshInSurfaceChart;
        private TextBox txtBxMeshBedLevelPointY;
        private TextBox txtBxMeshBedLevelPointX;
        private Label lblMeshBedLevelPointY;
        private Label lblMeshBedLevelPointX;
        private Button btnSetup;
        private Nevron.Chart.WinForm.NChartControl nChartControlSurface;
        private GroupBox grpBxZextraDistance;
        private Label lblZextraDistance;
        private TextBox txtBxZextraDistance;
        private TextBox txtBxZextraDistanceInstruct;
        private GroupBox grpBxZprobeXoffset;
        private ComboBox cmbBxZprobeXoffset;
        private Label lblZprobeXoffsetmm;
        private Label lblZprobeXoffset;
        private ComboBox cmbBxZprobeYoffset;
        private Label lblZprobeYoffsetmm;
        private Label lblZprobeYoffset;
        private TextBox txtBxZprobeYoffset;
        private TextBox txtBxZprobeXoffset;
        private GroupBox groupBox12;
        private Button btnM851;
        private TextBox txtBxM851;
        private Label lblM851;
        private TextBox txtBxZprobePosition;
        private Button btnDockZprobe;
        private Button btnProbeDown;
        private Button btnProbeUp;
        private TextBox txtBxDockZprobe;
        private GroupBox grpBxMeassureUsingProbe;
        private Button btnNozzleIsTouchingBed;
        private PictureBox pictureWorkInProgressZprobe;
        private PictureBox pictureBox2;
        private BedCorner bedCornerControlBackLeft;
        private BedCorner bedCornerControlFrontRight;
        private BedCorner bedCornerControlFrontLeft;
        private BedCorner bedCornerControlBackRight;
        private Panel panelBed;
        private BedAdjuster bedAdjusterBackLeft;
        private BedCorner bedCornerControlSafeHome;
        private RadioButton rdoBn3pointFront;
        private RadioButton rdoBn3pointRight;
        private RadioButton rdoBn3pointLeft;
        private BedAdjuster bedAdjusterLeftSingle;
        private BedAdjuster bedAdjusterFrontSingle;
        private BedAdjuster bedAdjusterRightSingle;
        private BedAdjuster bedAdjusterBackRight;
        private BedAdjuster bedAdjusterFrontRight;
        private BedAdjuster bedAdjusterFrontLeft;
        private SplitContainer splitContainer1;
        private GroupBox grpBxTemperature;
        private Chart chartTemperature;
        private Panel panelConfigurationBedTab;
        private FastColoredTextBox fctbAutoBedLevelResponce;
        private TabPage tabPageZoffset;
        private LedBulb ledBulbZprobeGauge;
        private ComboBox cmbBxPidExtruder;
        private ComboBox cmbBxExtruderCalibration;
        private TextBox txtBxCurrentStepsPermm;
        private Button btnResetFactorySettings;
        private GroupBox grpBxM48Test;
        private Label lblNumberOfM48Test;
        private TrackBar trackBarNumberOfM48Test;
        private Button btnM48Test;
        private FastColoredTextBox fctbM48Test;
        private PictureBox pictureBox5;
        private TextBox txtBxCurrentBedSet;
        private TextBox txtBxCurrentBedTemp;
        private TextBox txtBxCurrentExtruder2Set;
        private TextBox txtBxCurrentExtruder2Temp;
        private TextBox txtBxCurrentExtruder1Set;
        private TextBox txtBxCurrentExtruder1Temp;
        private Button btnGetTemp;
        private CheckBox chkBxBlTouch;
        private GroupBox grpBxBlTouch;
        private Button btnBlTouchResetAlarm;
        private Button btnBlTouchSelftest;
        private Button btnBlTouchRelease;
        private Button btnBlTouchEngage;
        private Button btnBlTouchSave;
        private Timer timerEndstop;
        private BindingControl bindingControl;
        private AGauge aGaugeProbe;
        private PictureBox picBxApprovedByBLTouch;
    }
}