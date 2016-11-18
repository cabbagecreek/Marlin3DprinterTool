using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FastColoredTextBoxNS;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarlin3DprinterTool));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl3DprinterTool = new System.Windows.Forms.TabControl();
            this.tabPageEndstop = new System.Windows.Forms.TabPage();
            this.grpBxZ = new System.Windows.Forms.GroupBox();
            this.ledZmax = new MarlinComunicationHelper.LedBulb();
            this.ledZmin = new MarlinComunicationHelper.LedBulb();
            this.lblZmax = new System.Windows.Forms.Label();
            this.lblZmin = new System.Windows.Forms.Label();
            this.grpBxY = new System.Windows.Forms.GroupBox();
            this.ledYmax = new MarlinComunicationHelper.LedBulb();
            this.ledYmin = new MarlinComunicationHelper.LedBulb();
            this.lblYmax = new System.Windows.Forms.Label();
            this.lblYmin = new System.Windows.Forms.Label();
            this.grpBxX = new System.Windows.Forms.GroupBox();
            this.ledXmax = new MarlinComunicationHelper.LedBulb();
            this.ledXmin = new MarlinComunicationHelper.LedBulb();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblXmin = new System.Windows.Forms.Label();
            this.tabPageConfigurationBed = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdoBn3pointAdjusterFront = new System.Windows.Forms.RadioButton();
            this.rdoBn3pointAdjusterLeft = new System.Windows.Forms.RadioButton();
            this.rdoBn3pointAdjusterRight = new System.Windows.Forms.RadioButton();
            this.rdoBn4pointAdjuster = new System.Windows.Forms.RadioButton();
            this.grpBxAdjusters = new System.Windows.Forms.GroupBox();
            this.chkListBxAdjustment = new System.Windows.Forms.CheckedListBox();
            this.grpPosition = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBxCurrentPositionYConfigBed = new System.Windows.Forms.TextBox();
            this.lblCurrentPositionYConfigBed = new System.Windows.Forms.Label();
            this.txtBxCurrentPositionXConfigBed = new System.Windows.Forms.TextBox();
            this.lblCurrentPositionXConfigBed = new System.Windows.Forms.Label();
            this.btnMoveUpperLeftAdjuster = new System.Windows.Forms.Button();
            this.btnMoveUpperRightAdjuster = new System.Windows.Forms.Button();
            this.btnMoveLowerRightAdjuster = new System.Windows.Forms.Button();
            this.btnMoveLowerLeftAdjuster = new System.Windows.Forms.Button();
            this.btnSaveUpperLeftAdjuster = new System.Windows.Forms.Button();
            this.btnSaveUpperRightAdjuster = new System.Windows.Forms.Button();
            this.btnSaveLowerRightAdjuster = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoveSafeHome = new System.Windows.Forms.Button();
            this.btnSaveSafeHome = new System.Windows.Forms.Button();
            this.btnSaveUpperRightCorner = new System.Windows.Forms.Button();
            this.btnSaveUpperLeftCorner = new System.Windows.Forms.Button();
            this.btnSaveLowerLeftCorner = new System.Windows.Forms.Button();
            this.btnSaveLowerRightCorner = new System.Windows.Forms.Button();
            this.btnMoveLowerRightCorner = new System.Windows.Forms.Button();
            this.btnMoveLowerLeftCorner = new System.Windows.Forms.Button();
            this.btnMoveUpperRightCorner = new System.Windows.Forms.Button();
            this.btnMoveUpperLeftCorner = new System.Windows.Forms.Button();
            this.btnSaveLowerLeftAdjuster = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPageConfigurateZprobe = new System.Windows.Forms.TabPage();
            this.grpBxZprobeHeight = new System.Windows.Forms.GroupBox();
            this.btnZpromeEepromUpdate = new System.Windows.Forms.Button();
            this.btnZpromeFirmwareUpdate = new System.Windows.Forms.Button();
            this.txtBxJogControlZprobeHeightHelp = new System.Windows.Forms.TextBox();
            this.btnStartZprobeHeight = new System.Windows.Forms.Button();
            this.txtBxCalculatedZProbeOffset = new System.Windows.Forms.TextBox();
            this.btnZprobeHeightNext = new System.Windows.Forms.Button();
            this.lblCalculatedZProbeOffset = new System.Windows.Forms.Label();
            this.grpZprobeConfigMax = new System.Windows.Forms.GroupBox();
            this.btnZmaxTravel = new System.Windows.Forms.Button();
            this.lblZmaxTravel = new System.Windows.Forms.Label();
            this.numUpDnZmaxTravel = new System.Windows.Forms.NumericUpDown();
            this.trkBrZmaxTravel = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTestZprobeRelease = new System.Windows.Forms.Button();
            this.btnTestZprobeReleaseSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCreateExampleForZprobeServoRelease = new System.Windows.Forms.Button();
            this.btnCreateExampleForZprobeSledRelease = new System.Windows.Forms.Button();
            this.btnCreateExampleForZprobePositionRelease = new System.Windows.Forms.Button();
            this.txtBxGcodeAssistZprobeRelease = new System.Windows.Forms.TextBox();
            this.grpBxEngageZprobe = new System.Windows.Forms.GroupBox();
            this.btnTestZprobeEngage = new System.Windows.Forms.Button();
            this.btnTestZprobeEngageSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateExampleForZprobeServoEngage = new System.Windows.Forms.Button();
            this.btnCreateExampleForZprobeSledEngage = new System.Windows.Forms.Button();
            this.btnCreateExampleForZprobePositionEngage = new System.Windows.Forms.Button();
            this.txtBxGcodeAssistZprobeEngage = new System.Windows.Forms.TextBox();
            this.grpBxTestZprobe = new System.Windows.Forms.GroupBox();
            this.fctbM48Responce = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblM48Repetition = new System.Windows.Forms.Label();
            this.btnM48Repetition = new System.Windows.Forms.Button();
            this.numUpDnM48Repetitions = new System.Windows.Forms.NumericUpDown();
            this.tabPageBedLevel = new System.Windows.Forms.TabPage();
            this.grpAutoBedLevel = new System.Windows.Forms.GroupBox();
            this.btnAutoBedLevel = new System.Windows.Forms.Button();
            this.txtBxAutoBedLevelResponce = new System.Windows.Forms.TextBox();
            this.panelAdjust3 = new System.Windows.Forms.Panel();
            this.picBxTurn3 = new System.Windows.Forms.PictureBox();
            this.lblAdjustValue3 = new System.Windows.Forms.Label();
            this.lblTurn3 = new System.Windows.Forms.Label();
            this.panelAdjust2 = new System.Windows.Forms.Panel();
            this.picBxTurn2 = new System.Windows.Forms.PictureBox();
            this.lblAdjustValue2 = new System.Windows.Forms.Label();
            this.lblTurn2 = new System.Windows.Forms.Label();
            this.panelAdjust4 = new System.Windows.Forms.Panel();
            this.picBxTurn4 = new System.Windows.Forms.PictureBox();
            this.lblAdjustValue4 = new System.Windows.Forms.Label();
            this.lblTurn4 = new System.Windows.Forms.Label();
            this.panelAdjust1 = new System.Windows.Forms.Panel();
            this.picBxTurn1 = new System.Windows.Forms.PictureBox();
            this.lblAdjustValue1 = new System.Windows.Forms.Label();
            this.lblTurn1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProbeTheBed = new System.Windows.Forms.Button();
            this.picBxUpperLeftAdjuster = new System.Windows.Forms.PictureBox();
            this.picBxUpperRightAdjuster = new System.Windows.Forms.PictureBox();
            this.picBxLowerRightAdjuster = new System.Windows.Forms.PictureBox();
            this.picBxLowerLeftAdjuster = new System.Windows.Forms.PictureBox();
            this.tabPageScanSurface = new System.Windows.Forms.TabPage();
            this.nChartControlSurface = new Nevron.Chart.WinForm.NChartControl();
            this.btnMeshLevel = new System.Windows.Forms.Button();
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
            this.btnTransferBedPidKp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateBedPid = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numUpDownPidBedCykles = new System.Windows.Forms.NumericUpDown();
            this.trkBarPidBedCykles = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.trkBarPidBedTemp = new System.Windows.Forms.TrackBar();
            this.numUpDownPidBedTemp = new System.Windows.Forms.NumericUpDown();
            this.grpBxExtruderPID = new System.Windows.Forms.GroupBox();
            this.grpBxPidExtruder = new System.Windows.Forms.GroupBox();
            this.txtBxKdExtruder = new System.Windows.Forms.TextBox();
            this.txtBxKiExtruder = new System.Windows.Forms.TextBox();
            this.txtBxKpExtruder = new System.Windows.Forms.TextBox();
            this.btnTransferExtruderPidKp = new System.Windows.Forms.Button();
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
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBxColdExtruderCalibration = new System.Windows.Forms.CheckBox();
            this.numUpDnCalibrateExtruderTemp = new System.Windows.Forms.NumericUpDown();
            this.btnHeatExtruderForCalibration = new System.Windows.Forms.Button();
            this.trkBarTemperature = new System.Windows.Forms.TrackBar();
            this.grpBxCalculate = new System.Windows.Forms.GroupBox();
            this.btnExtruderCalibrationCalculate = new System.Windows.Forms.Button();
            this.btnM92Extruder = new System.Windows.Forms.Button();
            this.lblFirmware = new System.Windows.Forms.Label();
            this.numUpDnFirmware = new System.Windows.Forms.NumericUpDown();
            this.numUpDnMeassure = new System.Windows.Forms.NumericUpDown();
            this.lblMeassure = new System.Windows.Forms.Label();
            this.grpBxTestExtrude = new System.Windows.Forms.GroupBox();
            this.lblExtrude = new System.Windows.Forms.Label();
            this.btnExtruderCalibation = new System.Windows.Forms.Button();
            this.numUpDnExtrude = new System.Windows.Forms.NumericUpDown();
            this.tabPageZMaintenance = new System.Windows.Forms.TabPage();
            this.grpBxZMaintenance = new System.Windows.Forms.GroupBox();
            this.txtBxZmaintenanceDescription = new System.Windows.Forms.TextBox();
            this.btnZmaintenanceRun = new System.Windows.Forms.Button();
            this.btnZmaintenanceCancel = new System.Windows.Forms.Button();
            this.grpBxZmaintMin = new System.Windows.Forms.GroupBox();
            this.trackBarZmaintenanceMin = new System.Windows.Forms.TrackBar();
            this.grpBxZmaintMax = new System.Windows.Forms.GroupBox();
            this.trackBarZmaintenanceMax = new System.Windows.Forms.TrackBar();
            this.lblZmaintenanceRepetitions = new System.Windows.Forms.Label();
            this.numUpDnZmaintenanceRepetitions = new System.Windows.Forms.NumericUpDown();
            this.tabPageCalculations = new System.Windows.Forms.TabPage();
            this.grpBxFeedRate = new System.Windows.Forms.GroupBox();
            this.numUpDnFeedRateMMperMinute = new System.Windows.Forms.NumericUpDown();
            this.lblFeedRateMMperMinute = new System.Windows.Forms.Label();
            this.lblFeedRateMMperSecund = new System.Windows.Forms.Label();
            this.numUpDnFeedRateMMperSecund = new System.Windows.Forms.NumericUpDown();
            this.grpBxExtruderCalculation = new System.Windows.Forms.GroupBox();
            this.btnExtruderUpdateStepsPerMMinFirmware = new System.Windows.Forms.Button();
            this.btnExtruderUpdateStepsPerMMinEEPROM = new System.Windows.Forms.Button();
            this.btnExtruderOldFirmware = new System.Windows.Forms.Button();
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
            this.tabPageStlViewer = new System.Windows.Forms.TabPage();
            this.grpBxInstallingStlThumbnailServer = new System.Windows.Forms.GroupBox();
            this.grpBxAssociateStlViewer = new System.Windows.Forms.GroupBox();
            this.btnAssociateStlViewer = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBoxAssociations = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAssemblyPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxServerSecurity = new System.Windows.Forms.TextBox();
            this.textBoxServerCLSID = new System.Windows.Forms.TextBox();
            this.textBoxServerType = new System.Windows.Forms.TextBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColorStl = new System.Windows.Forms.Button();
            this.btnRestartWindowsFileExplorer = new System.Windows.Forms.Button();
            this.btnResetAndCleanExistingThumbnails = new System.Windows.Forms.Button();
            this.btnTroubleShootStl = new System.Windows.Forms.Button();
            this.grpBxServe32 = new System.Windows.Forms.GroupBox();
            this.lblRegistered32 = new System.Windows.Forms.Label();
            this.lblServer32 = new System.Windows.Forms.Label();
            this.ledRegister32 = new MarlinComunicationHelper.LedBulb();
            this.ledServer32 = new MarlinComunicationHelper.LedBulb();
            this.grpBxServe64 = new System.Windows.Forms.GroupBox();
            this.lblRegistered64 = new System.Windows.Forms.Label();
            this.lblServer64 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ledServer64 = new MarlinComunicationHelper.LedBulb();
            this.ledRegister64 = new MarlinComunicationHelper.LedBulb();
            this.chkBx32BitOS = new System.Windows.Forms.CheckBox();
            this.btnUnInstallStlServer = new System.Windows.Forms.Button();
            this.btnInstallStlServer = new System.Windows.Forms.Button();
            this.tabPageParameters = new System.Windows.Forms.TabPage();
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
            this.kompassControllConfigBed = new MarlinComunicationHelper.KompassControll();
            this.grpBxBed = new System.Windows.Forms.Button();
            this.btnHomeY = new System.Windows.Forms.Button();
            this.btnHomeX = new System.Windows.Forms.Button();
            this.verticalJogControlZprobeHeight = new MarlinComunicationHelper.VerticalJogControl();
            this.btnEngageZprobe = new System.Windows.Forms.Button();
            this.btnOpenMarlin = new System.Windows.Forms.Button();
            this.btnSaveArduinoIDE = new System.Windows.Forms.Button();
            this.txtBxArduinoIDE = new System.Windows.Forms.TextBox();
            this.lblStepperDriverPulley = new System.Windows.Forms.GroupBox();
            this.btnShowCommunication = new System.Windows.Forms.Button();
            this.cmbBxComPort = new System.Windows.Forms.ComboBox();
            this.cmbBxBaud = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.toolTip3DprinterTool = new System.Windows.Forms.ToolTip(this.components);
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnFirmware = new System.Windows.Forms.Button();
            this.btnPayPal = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.tabControl3DprinterTool.SuspendLayout();
            this.tabPageEndstop.SuspendLayout();
            this.grpBxZ.SuspendLayout();
            this.grpBxY.SuspendLayout();
            this.grpBxX.SuspendLayout();
            this.tabPageConfigurationBed.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grpBxAdjusters.SuspendLayout();
            this.grpPosition.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageConfigurateZprobe.SuspendLayout();
            this.grpBxZprobeHeight.SuspendLayout();
            this.grpZprobeConfigMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaxTravel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrZmaxTravel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpBxEngageZprobe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBxTestZprobe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbM48Responce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnM48Repetitions)).BeginInit();
            this.tabPageBedLevel.SuspendLayout();
            this.grpAutoBedLevel.SuspendLayout();
            this.panelAdjust3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn3)).BeginInit();
            this.panelAdjust2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn2)).BeginInit();
            this.panelAdjust4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn4)).BeginInit();
            this.panelAdjust1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperLeftAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperRightAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerRightAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerLeftAdjuster)).BeginInit();
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
            this.grpBxCalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFirmware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMeassure)).BeginInit();
            this.grpBxTestExtrude.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtrude)).BeginInit();
            this.tabPageZMaintenance.SuspendLayout();
            this.grpBxZMaintenance.SuspendLayout();
            this.grpBxZmaintMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMin)).BeginInit();
            this.grpBxZmaintMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaintenanceRepetitions)).BeginInit();
            this.tabPageCalculations.SuspendLayout();
            this.grpBxFeedRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperSecund)).BeginInit();
            this.grpBxExtruderCalculation.SuspendLayout();
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
            this.tabPageStlViewer.SuspendLayout();
            this.grpBxInstallingStlThumbnailServer.SuspendLayout();
            this.grpBxAssociateStlViewer.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.grpBxServe32.SuspendLayout();
            this.grpBxServe64.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl3DprinterTool
            // 
            this.tabControl3DprinterTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl3DprinterTool.Controls.Add(this.tabPageEndstop);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageConfigurationBed);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageConfigurateZprobe);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageBedLevel);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageScanSurface);
            this.tabControl3DprinterTool.Controls.Add(this.tabPagePID);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageExtruderCalibration);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageZMaintenance);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageCalculations);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageStlViewer);
            this.tabControl3DprinterTool.Controls.Add(this.tabPageParameters);
            this.tabControl3DprinterTool.Location = new System.Drawing.Point(14, 68);
            this.tabControl3DprinterTool.Name = "tabControl3DprinterTool";
            this.tabControl3DprinterTool.SelectedIndex = 0;
            this.tabControl3DprinterTool.Size = new System.Drawing.Size(882, 683);
            this.tabControl3DprinterTool.TabIndex = 0;
            this.tabControl3DprinterTool.SelectedIndexChanged += new System.EventHandler(this.tabControl3DprinterTool_SelectedIndexChanged);
            // 
            // tabPageEndstop
            // 
            this.tabPageEndstop.Controls.Add(this.grpBxZ);
            this.tabPageEndstop.Controls.Add(this.grpBxY);
            this.tabPageEndstop.Controls.Add(this.grpBxX);
            this.tabPageEndstop.Location = new System.Drawing.Point(4, 22);
            this.tabPageEndstop.Name = "tabPageEndstop";
            this.tabPageEndstop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEndstop.Size = new System.Drawing.Size(874, 657);
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
            this.grpBxZ.Location = new System.Drawing.Point(582, 6);
            this.grpBxZ.Name = "grpBxZ";
            this.grpBxZ.Size = new System.Drawing.Size(216, 361);
            this.grpBxZ.TabIndex = 2;
            this.grpBxZ.TabStop = false;
            this.grpBxZ.Text = "Z";
            // 
            // ledZmax
            // 
            this.ledZmax.Location = new System.Drawing.Point(16, 205);
            this.ledZmax.Name = "ledZmax";
            this.ledZmax.On = false;
            this.ledZmax.Size = new System.Drawing.Size(130, 130);
            this.ledZmax.TabIndex = 7;
            this.ledZmax.Text = "ledBulb1";
            // 
            // ledZmin
            // 
            this.ledZmin.Location = new System.Drawing.Point(13, 36);
            this.ledZmin.Name = "ledZmin";
            this.ledZmin.On = false;
            this.ledZmin.Size = new System.Drawing.Size(130, 130);
            this.ledZmin.TabIndex = 6;
            this.ledZmin.Text = "ledBulb1";
            // 
            // lblZmax
            // 
            this.lblZmax.AutoSize = true;
            this.lblZmax.Location = new System.Drawing.Point(13, 189);
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
            this.grpBxY.Location = new System.Drawing.Point(292, 6);
            this.grpBxY.Name = "grpBxY";
            this.grpBxY.Size = new System.Drawing.Size(216, 361);
            this.grpBxY.TabIndex = 1;
            this.grpBxY.TabStop = false;
            this.grpBxY.Text = "Y";
            // 
            // ledYmax
            // 
            this.ledYmax.Location = new System.Drawing.Point(13, 205);
            this.ledYmax.Name = "ledYmax";
            this.ledYmax.On = false;
            this.ledYmax.Size = new System.Drawing.Size(130, 130);
            this.ledYmax.TabIndex = 5;
            this.ledYmax.Text = "ledBulb1";
            // 
            // ledYmin
            // 
            this.ledYmin.Location = new System.Drawing.Point(13, 36);
            this.ledYmin.Name = "ledYmin";
            this.ledYmin.On = false;
            this.ledYmin.Size = new System.Drawing.Size(130, 130);
            this.ledYmin.TabIndex = 4;
            this.ledYmin.Text = "ledBulb1";
            // 
            // lblYmax
            // 
            this.lblYmax.AutoSize = true;
            this.lblYmax.Location = new System.Drawing.Point(10, 189);
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
            this.grpBxX.Location = new System.Drawing.Point(6, 6);
            this.grpBxX.Name = "grpBxX";
            this.grpBxX.Size = new System.Drawing.Size(216, 361);
            this.grpBxX.TabIndex = 0;
            this.grpBxX.TabStop = false;
            this.grpBxX.Text = "X";
            // 
            // ledXmax
            // 
            this.ledXmax.Location = new System.Drawing.Point(13, 205);
            this.ledXmax.Name = "ledXmax";
            this.ledXmax.On = false;
            this.ledXmax.Size = new System.Drawing.Size(130, 130);
            this.ledXmax.TabIndex = 3;
            this.ledXmax.Text = "ledBulb1";
            // 
            // ledXmin
            // 
            this.ledXmin.Location = new System.Drawing.Point(13, 36);
            this.ledXmin.Name = "ledXmin";
            this.ledXmin.On = false;
            this.ledXmin.Size = new System.Drawing.Size(130, 130);
            this.ledXmin.TabIndex = 2;
            this.ledXmin.Text = "ledBulb1";
            // 
            // lblXmax
            // 
            this.lblXmax.AutoSize = true;
            this.lblXmax.Location = new System.Drawing.Point(10, 189);
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
            // tabPageConfigurationBed
            // 
            this.tabPageConfigurationBed.Controls.Add(this.groupBox6);
            this.tabPageConfigurationBed.Controls.Add(this.grpPosition);
            this.tabPageConfigurationBed.Controls.Add(this.richTextBox2);
            this.tabPageConfigurationBed.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigurationBed.Name = "tabPageConfigurationBed";
            this.tabPageConfigurationBed.Size = new System.Drawing.Size(874, 657);
            this.tabPageConfigurationBed.TabIndex = 4;
            this.tabPageConfigurationBed.Text = "Configuration Bed";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageConfigurationBed, "Navigate and save positions for other features to use");
            this.tabPageConfigurationBed.ToolTipText = "Configuration of Bed";
            this.tabPageConfigurationBed.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdoBn3pointAdjusterFront);
            this.groupBox6.Controls.Add(this.rdoBn3pointAdjusterLeft);
            this.groupBox6.Controls.Add(this.rdoBn3pointAdjusterRight);
            this.groupBox6.Controls.Add(this.rdoBn4pointAdjuster);
            this.groupBox6.Controls.Add(this.grpBxAdjusters);
            this.groupBox6.Location = new System.Drawing.Point(28, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 275);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bed adjusters";
            // 
            // rdoBn3pointAdjusterFront
            // 
            this.rdoBn3pointAdjusterFront.AutoSize = true;
            this.rdoBn3pointAdjusterFront.Location = new System.Drawing.Point(7, 103);
            this.rdoBn3pointAdjusterFront.Name = "rdoBn3pointAdjusterFront";
            this.rdoBn3pointAdjusterFront.Size = new System.Drawing.Size(129, 17);
            this.rdoBn3pointAdjusterFront.TabIndex = 24;
            this.rdoBn3pointAdjusterFront.TabStop = true;
            this.rdoBn3pointAdjusterFront.Text = "3 point adjusters Front";
            this.rdoBn3pointAdjusterFront.UseVisualStyleBackColor = true;
            this.rdoBn3pointAdjusterFront.CheckedChanged += new System.EventHandler(this.rdoBn3pointAdjusterFront_CheckedChanged);
            // 
            // rdoBn3pointAdjusterLeft
            // 
            this.rdoBn3pointAdjusterLeft.AutoSize = true;
            this.rdoBn3pointAdjusterLeft.Location = new System.Drawing.Point(7, 78);
            this.rdoBn3pointAdjusterLeft.Name = "rdoBn3pointAdjusterLeft";
            this.rdoBn3pointAdjusterLeft.Size = new System.Drawing.Size(123, 17);
            this.rdoBn3pointAdjusterLeft.TabIndex = 23;
            this.rdoBn3pointAdjusterLeft.TabStop = true;
            this.rdoBn3pointAdjusterLeft.Text = "3 point adjusters Left";
            this.rdoBn3pointAdjusterLeft.UseVisualStyleBackColor = true;
            this.rdoBn3pointAdjusterLeft.CheckedChanged += new System.EventHandler(this.rdoBn3pointAdjusterLeft_CheckedChanged);
            // 
            // rdoBn3pointAdjusterRight
            // 
            this.rdoBn3pointAdjusterRight.AutoSize = true;
            this.rdoBn3pointAdjusterRight.Location = new System.Drawing.Point(7, 53);
            this.rdoBn3pointAdjusterRight.Name = "rdoBn3pointAdjusterRight";
            this.rdoBn3pointAdjusterRight.Size = new System.Drawing.Size(130, 17);
            this.rdoBn3pointAdjusterRight.TabIndex = 22;
            this.rdoBn3pointAdjusterRight.TabStop = true;
            this.rdoBn3pointAdjusterRight.Text = "3 point adjusters Right";
            this.rdoBn3pointAdjusterRight.UseVisualStyleBackColor = true;
            this.rdoBn3pointAdjusterRight.CheckedChanged += new System.EventHandler(this.rdoBn3pointAdjusterRight_CheckedChanged);
            // 
            // rdoBn4pointAdjuster
            // 
            this.rdoBn4pointAdjuster.AutoSize = true;
            this.rdoBn4pointAdjuster.Location = new System.Drawing.Point(7, 28);
            this.rdoBn4pointAdjuster.Name = "rdoBn4pointAdjuster";
            this.rdoBn4pointAdjuster.Size = new System.Drawing.Size(102, 17);
            this.rdoBn4pointAdjuster.TabIndex = 21;
            this.rdoBn4pointAdjuster.TabStop = true;
            this.rdoBn4pointAdjuster.Text = "4 point adjusters";
            this.rdoBn4pointAdjuster.UseVisualStyleBackColor = true;
            this.rdoBn4pointAdjuster.CheckedChanged += new System.EventHandler(this.rdoBn4pointAdjuster_CheckedChanged);
            // 
            // grpBxAdjusters
            // 
            this.grpBxAdjusters.Controls.Add(this.chkListBxAdjustment);
            this.grpBxAdjusters.Location = new System.Drawing.Point(7, 169);
            this.grpBxAdjusters.Name = "grpBxAdjusters";
            this.grpBxAdjusters.Size = new System.Drawing.Size(118, 100);
            this.grpBxAdjusters.TabIndex = 20;
            this.grpBxAdjusters.TabStop = false;
            this.grpBxAdjusters.Text = "Thread on Adjusters";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxAdjusters, "Assign the type of bed adjusters");
            // 
            // chkListBxAdjustment
            // 
            this.chkListBxAdjustment.FormattingEnabled = true;
            this.chkListBxAdjustment.Items.AddRange(new object[] {
            "M3",
            "M4",
            "M5"});
            this.chkListBxAdjustment.Location = new System.Drawing.Point(20, 16);
            this.chkListBxAdjustment.Name = "chkListBxAdjustment";
            this.chkListBxAdjustment.Size = new System.Drawing.Size(55, 49);
            this.chkListBxAdjustment.TabIndex = 18;
            this.toolTip3DprinterTool.SetToolTip(this.chkListBxAdjustment, "Assign the type of bed adjusters");
            this.chkListBxAdjustment.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListBxAdjustment_ItemCheck);
            this.chkListBxAdjustment.SelectedIndexChanged += new System.EventHandler(this.chkListBxAdjustment_SelectedIndexChanged);
            // 
            // grpPosition
            // 
            this.grpPosition.Controls.Add(this.groupBox5);
            this.grpPosition.Controls.Add(this.btnMoveUpperLeftAdjuster);
            this.grpPosition.Controls.Add(this.btnMoveUpperRightAdjuster);
            this.grpPosition.Controls.Add(this.btnMoveLowerRightAdjuster);
            this.grpPosition.Controls.Add(this.btnMoveLowerLeftAdjuster);
            this.grpPosition.Controls.Add(this.btnSaveUpperLeftAdjuster);
            this.grpPosition.Controls.Add(this.btnSaveUpperRightAdjuster);
            this.grpPosition.Controls.Add(this.btnSaveLowerRightAdjuster);
            this.grpPosition.Controls.Add(this.panel1);
            this.grpPosition.Controls.Add(this.btnSaveLowerLeftAdjuster);
            this.grpPosition.Location = new System.Drawing.Point(280, 27);
            this.grpPosition.Name = "grpPosition";
            this.grpPosition.Size = new System.Drawing.Size(531, 609);
            this.grpPosition.TabIndex = 1;
            this.grpPosition.TabStop = false;
            this.grpPosition.Text = "Position";
            this.toolTip3DprinterTool.SetToolTip(this.grpPosition, "Position the extruder to the corners and to positions close to adjusters and save" +
        " the positions");
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtBxCurrentPositionYConfigBed);
            this.groupBox5.Controls.Add(this.lblCurrentPositionYConfigBed);
            this.groupBox5.Controls.Add(this.txtBxCurrentPositionXConfigBed);
            this.groupBox5.Controls.Add(this.lblCurrentPositionXConfigBed);
            this.groupBox5.Location = new System.Drawing.Point(82, 485);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 49);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Current Position";
            // 
            // txtBxCurrentPositionYConfigBed
            // 
            this.txtBxCurrentPositionYConfigBed.Location = new System.Drawing.Point(189, 19);
            this.txtBxCurrentPositionYConfigBed.Name = "txtBxCurrentPositionYConfigBed";
            this.txtBxCurrentPositionYConfigBed.Size = new System.Drawing.Size(100, 20);
            this.txtBxCurrentPositionYConfigBed.TabIndex = 24;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentPositionYConfigBed, "Currevt Position");
            // 
            // lblCurrentPositionYConfigBed
            // 
            this.lblCurrentPositionYConfigBed.AutoSize = true;
            this.lblCurrentPositionYConfigBed.Location = new System.Drawing.Point(169, 22);
            this.lblCurrentPositionYConfigBed.Name = "lblCurrentPositionYConfigBed";
            this.lblCurrentPositionYConfigBed.Size = new System.Drawing.Size(14, 13);
            this.lblCurrentPositionYConfigBed.TabIndex = 23;
            this.lblCurrentPositionYConfigBed.Text = "Y";
            // 
            // txtBxCurrentPositionXConfigBed
            // 
            this.txtBxCurrentPositionXConfigBed.Location = new System.Drawing.Point(30, 19);
            this.txtBxCurrentPositionXConfigBed.Name = "txtBxCurrentPositionXConfigBed";
            this.txtBxCurrentPositionXConfigBed.Size = new System.Drawing.Size(100, 20);
            this.txtBxCurrentPositionXConfigBed.TabIndex = 21;
            this.toolTip3DprinterTool.SetToolTip(this.txtBxCurrentPositionXConfigBed, "Currevt Position");
            // 
            // lblCurrentPositionXConfigBed
            // 
            this.lblCurrentPositionXConfigBed.AutoSize = true;
            this.lblCurrentPositionXConfigBed.Location = new System.Drawing.Point(10, 22);
            this.lblCurrentPositionXConfigBed.Name = "lblCurrentPositionXConfigBed";
            this.lblCurrentPositionXConfigBed.Size = new System.Drawing.Size(14, 13);
            this.lblCurrentPositionXConfigBed.TabIndex = 22;
            this.lblCurrentPositionXConfigBed.Text = "X";
            // 
            // btnMoveUpperLeftAdjuster
            // 
            this.btnMoveUpperLeftAdjuster.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.btnMoveUpperLeftAdjuster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveUpperLeftAdjuster.Location = new System.Drawing.Point(50, 100);
            this.btnMoveUpperLeftAdjuster.Name = "btnMoveUpperLeftAdjuster";
            this.btnMoveUpperLeftAdjuster.Size = new System.Drawing.Size(32, 32);
            this.btnMoveUpperLeftAdjuster.TabIndex = 8;
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveUpperLeftAdjuster, "Move to \"Upper Left Adjustment\"");
            this.btnMoveUpperLeftAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveUpperLeftAdjuster.Click += new System.EventHandler(this.btnMoveUpperLeftAdjuster_Click);
            // 
            // btnMoveUpperRightAdjuster
            // 
            this.btnMoveUpperRightAdjuster.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.btnMoveUpperRightAdjuster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveUpperRightAdjuster.Location = new System.Drawing.Point(390, 100);
            this.btnMoveUpperRightAdjuster.Name = "btnMoveUpperRightAdjuster";
            this.btnMoveUpperRightAdjuster.Size = new System.Drawing.Size(32, 32);
            this.btnMoveUpperRightAdjuster.TabIndex = 7;
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveUpperRightAdjuster, "Move to \"Upper Right Adjustment\"");
            this.btnMoveUpperRightAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveUpperRightAdjuster.Click += new System.EventHandler(this.btnMoveUpperRightAdjuster_Click);
            // 
            // btnMoveLowerRightAdjuster
            // 
            this.btnMoveLowerRightAdjuster.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.btnMoveLowerRightAdjuster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveLowerRightAdjuster.Location = new System.Drawing.Point(390, 200);
            this.btnMoveLowerRightAdjuster.Name = "btnMoveLowerRightAdjuster";
            this.btnMoveLowerRightAdjuster.Size = new System.Drawing.Size(32, 32);
            this.btnMoveLowerRightAdjuster.TabIndex = 6;
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveLowerRightAdjuster, "Move to \"Lower Right Adjustment\"");
            this.btnMoveLowerRightAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveLowerRightAdjuster.Click += new System.EventHandler(this.btnMoveLowerRightAdjuster_Click);
            // 
            // btnMoveLowerLeftAdjuster
            // 
            this.btnMoveLowerLeftAdjuster.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.btnMoveLowerLeftAdjuster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoveLowerLeftAdjuster.Location = new System.Drawing.Point(50, 200);
            this.btnMoveLowerLeftAdjuster.Name = "btnMoveLowerLeftAdjuster";
            this.btnMoveLowerLeftAdjuster.Size = new System.Drawing.Size(32, 32);
            this.btnMoveLowerLeftAdjuster.TabIndex = 5;
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveLowerLeftAdjuster, "Move to \"Lower Left Adjustment\"");
            this.btnMoveLowerLeftAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveLowerLeftAdjuster.Click += new System.EventHandler(this.btnMoveLowerLeftAdjuster_Click);
            // 
            // btnSaveUpperLeftAdjuster
            // 
            this.btnSaveUpperLeftAdjuster.Location = new System.Drawing.Point(5, 100);
            this.btnSaveUpperLeftAdjuster.Name = "btnSaveUpperLeftAdjuster";
            this.btnSaveUpperLeftAdjuster.Size = new System.Drawing.Size(41, 23);
            this.btnSaveUpperLeftAdjuster.TabIndex = 4;
            this.btnSaveUpperLeftAdjuster.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveUpperLeftAdjuster, "Save the current position as \"Upper Left Adjustment\"");
            this.btnSaveUpperLeftAdjuster.UseVisualStyleBackColor = true;
            this.btnSaveUpperLeftAdjuster.Click += new System.EventHandler(this.btnSaveUpperLeftAdjuster_Click);
            // 
            // btnSaveUpperRightAdjuster
            // 
            this.btnSaveUpperRightAdjuster.Location = new System.Drawing.Point(430, 100);
            this.btnSaveUpperRightAdjuster.Name = "btnSaveUpperRightAdjuster";
            this.btnSaveUpperRightAdjuster.Size = new System.Drawing.Size(41, 23);
            this.btnSaveUpperRightAdjuster.TabIndex = 3;
            this.btnSaveUpperRightAdjuster.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveUpperRightAdjuster, "Save the current position as \"Upper Right Adjustment\"");
            this.btnSaveUpperRightAdjuster.UseVisualStyleBackColor = true;
            this.btnSaveUpperRightAdjuster.Click += new System.EventHandler(this.btnSaveUpperRightAdjuster_Click);
            // 
            // btnSaveLowerRightAdjuster
            // 
            this.btnSaveLowerRightAdjuster.Location = new System.Drawing.Point(430, 200);
            this.btnSaveLowerRightAdjuster.Name = "btnSaveLowerRightAdjuster";
            this.btnSaveLowerRightAdjuster.Size = new System.Drawing.Size(41, 23);
            this.btnSaveLowerRightAdjuster.TabIndex = 2;
            this.btnSaveLowerRightAdjuster.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveLowerRightAdjuster, "Save the current position as \"Lower Right Adjustment\"");
            this.btnSaveLowerRightAdjuster.UseVisualStyleBackColor = true;
            this.btnSaveLowerRightAdjuster.Click += new System.EventHandler(this.btnSaveLowerRightAdjuster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnMoveSafeHome);
            this.panel1.Controls.Add(this.btnSaveSafeHome);
            this.panel1.Controls.Add(this.btnSaveUpperRightCorner);
            this.panel1.Controls.Add(this.btnSaveUpperLeftCorner);
            this.panel1.Controls.Add(this.btnSaveLowerLeftCorner);
            this.panel1.Controls.Add(this.btnSaveLowerRightCorner);
            this.panel1.Controls.Add(this.btnMoveLowerRightCorner);
            this.panel1.Controls.Add(this.btnMoveLowerLeftCorner);
            this.panel1.Controls.Add(this.btnMoveUpperRightCorner);
            this.panel1.Controls.Add(this.btnMoveUpperLeftCorner);
            this.panel1.Location = new System.Drawing.Point(82, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 309);
            this.panel1.TabIndex = 1;
            // 
            // btnMoveSafeHome
            // 
            this.btnMoveSafeHome.Location = new System.Drawing.Point(142, 146);
            this.btnMoveSafeHome.Name = "btnMoveSafeHome";
            this.btnMoveSafeHome.Size = new System.Drawing.Size(16, 23);
            this.btnMoveSafeHome.TabIndex = 17;
            this.btnMoveSafeHome.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveSafeHome, "Move to \"Safe Home\"");
            this.btnMoveSafeHome.UseVisualStyleBackColor = true;
            this.btnMoveSafeHome.Click += new System.EventHandler(this.btnMoveSafeHome_Click);
            // 
            // btnSaveSafeHome
            // 
            this.btnSaveSafeHome.Location = new System.Drawing.Point(164, 146);
            this.btnSaveSafeHome.Name = "btnSaveSafeHome";
            this.btnSaveSafeHome.Size = new System.Drawing.Size(41, 23);
            this.btnSaveSafeHome.TabIndex = 16;
            this.btnSaveSafeHome.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveSafeHome, "Save the current position as \"Safe Home\"");
            this.btnSaveSafeHome.UseVisualStyleBackColor = true;
            this.btnSaveSafeHome.Click += new System.EventHandler(this.btnSaveSafeHome_Click);
            // 
            // btnSaveUpperRightCorner
            // 
            this.btnSaveUpperRightCorner.Location = new System.Drawing.Point(224, 6);
            this.btnSaveUpperRightCorner.Name = "btnSaveUpperRightCorner";
            this.btnSaveUpperRightCorner.Size = new System.Drawing.Size(41, 23);
            this.btnSaveUpperRightCorner.TabIndex = 15;
            this.btnSaveUpperRightCorner.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveUpperRightCorner, "Save the current position as \"Upper Right Corner\"");
            this.btnSaveUpperRightCorner.UseVisualStyleBackColor = true;
            this.btnSaveUpperRightCorner.Click += new System.EventHandler(this.btnSaveUpperRightCorner_Click);
            // 
            // btnSaveUpperLeftCorner
            // 
            this.btnSaveUpperLeftCorner.Location = new System.Drawing.Point(26, 6);
            this.btnSaveUpperLeftCorner.Name = "btnSaveUpperLeftCorner";
            this.btnSaveUpperLeftCorner.Size = new System.Drawing.Size(41, 23);
            this.btnSaveUpperLeftCorner.TabIndex = 14;
            this.btnSaveUpperLeftCorner.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveUpperLeftCorner, "Save the current position as \"Upper Left Corner\"");
            this.btnSaveUpperLeftCorner.UseVisualStyleBackColor = true;
            this.btnSaveUpperLeftCorner.Click += new System.EventHandler(this.btnSaveUpperLeftCorner_Click);
            // 
            // btnSaveLowerLeftCorner
            // 
            this.btnSaveLowerLeftCorner.Location = new System.Drawing.Point(26, 274);
            this.btnSaveLowerLeftCorner.Name = "btnSaveLowerLeftCorner";
            this.btnSaveLowerLeftCorner.Size = new System.Drawing.Size(41, 23);
            this.btnSaveLowerLeftCorner.TabIndex = 13;
            this.btnSaveLowerLeftCorner.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveLowerLeftCorner, "Save the current position as \"Lower Left Corner\"");
            this.btnSaveLowerLeftCorner.UseVisualStyleBackColor = true;
            this.btnSaveLowerLeftCorner.Click += new System.EventHandler(this.btnSaveLowerLeftCorner_Click);
            // 
            // btnSaveLowerRightCorner
            // 
            this.btnSaveLowerRightCorner.Location = new System.Drawing.Point(224, 274);
            this.btnSaveLowerRightCorner.Name = "btnSaveLowerRightCorner";
            this.btnSaveLowerRightCorner.Size = new System.Drawing.Size(41, 23);
            this.btnSaveLowerRightCorner.TabIndex = 9;
            this.btnSaveLowerRightCorner.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveLowerRightCorner, "Save the current position as \"Lower Right Corner\"");
            this.btnSaveLowerRightCorner.UseVisualStyleBackColor = true;
            this.btnSaveLowerRightCorner.Click += new System.EventHandler(this.btnSaveLowerRightCorner_Click);
            // 
            // btnMoveLowerRightCorner
            // 
            this.btnMoveLowerRightCorner.Location = new System.Drawing.Point(271, 274);
            this.btnMoveLowerRightCorner.Name = "btnMoveLowerRightCorner";
            this.btnMoveLowerRightCorner.Size = new System.Drawing.Size(16, 23);
            this.btnMoveLowerRightCorner.TabIndex = 12;
            this.btnMoveLowerRightCorner.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveLowerRightCorner, "Move to \"Lower Right Corner\"");
            this.btnMoveLowerRightCorner.UseVisualStyleBackColor = true;
            this.btnMoveLowerRightCorner.Click += new System.EventHandler(this.btnMoveLowerRightCorner_Click);
            // 
            // btnMoveLowerLeftCorner
            // 
            this.btnMoveLowerLeftCorner.Location = new System.Drawing.Point(6, 274);
            this.btnMoveLowerLeftCorner.Name = "btnMoveLowerLeftCorner";
            this.btnMoveLowerLeftCorner.Size = new System.Drawing.Size(16, 23);
            this.btnMoveLowerLeftCorner.TabIndex = 11;
            this.btnMoveLowerLeftCorner.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveLowerLeftCorner, "Move to \"Lower Left Corner\"");
            this.btnMoveLowerLeftCorner.UseVisualStyleBackColor = true;
            this.btnMoveLowerLeftCorner.Click += new System.EventHandler(this.btnMoveLowerLeftCorner_Click);
            // 
            // btnMoveUpperRightCorner
            // 
            this.btnMoveUpperRightCorner.Location = new System.Drawing.Point(271, 6);
            this.btnMoveUpperRightCorner.Name = "btnMoveUpperRightCorner";
            this.btnMoveUpperRightCorner.Size = new System.Drawing.Size(16, 23);
            this.btnMoveUpperRightCorner.TabIndex = 10;
            this.btnMoveUpperRightCorner.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveUpperRightCorner, "Move to \"Upper Right Corner\"");
            this.btnMoveUpperRightCorner.UseVisualStyleBackColor = true;
            this.btnMoveUpperRightCorner.Click += new System.EventHandler(this.btnMoveUpperRightCorner_Click);
            // 
            // btnMoveUpperLeftCorner
            // 
            this.btnMoveUpperLeftCorner.Location = new System.Drawing.Point(6, 6);
            this.btnMoveUpperLeftCorner.Name = "btnMoveUpperLeftCorner";
            this.btnMoveUpperLeftCorner.Size = new System.Drawing.Size(16, 23);
            this.btnMoveUpperLeftCorner.TabIndex = 9;
            this.btnMoveUpperLeftCorner.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveUpperLeftCorner, "Move to \"Upper Left Corner\"");
            this.btnMoveUpperLeftCorner.UseVisualStyleBackColor = true;
            this.btnMoveUpperLeftCorner.Click += new System.EventHandler(this.btnMoveUpperLeftCorner_Click);
            // 
            // btnSaveLowerLeftAdjuster
            // 
            this.btnSaveLowerLeftAdjuster.Location = new System.Drawing.Point(5, 200);
            this.btnSaveLowerLeftAdjuster.Name = "btnSaveLowerLeftAdjuster";
            this.btnSaveLowerLeftAdjuster.Size = new System.Drawing.Size(41, 23);
            this.btnSaveLowerLeftAdjuster.TabIndex = 0;
            this.btnSaveLowerLeftAdjuster.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveLowerLeftAdjuster, "Save the current position as \"Lower Left Adjustment\"");
            this.btnSaveLowerLeftAdjuster.UseVisualStyleBackColor = true;
            this.btnSaveLowerLeftAdjuster.Click += new System.EventHandler(this.btnSaveLowerLeftAdjuster_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(28, 27);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(246, 206);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // tabPageConfigurateZprobe
            // 
            this.tabPageConfigurateZprobe.Controls.Add(this.grpBxZprobeHeight);
            this.tabPageConfigurateZprobe.Controls.Add(this.grpZprobeConfigMax);
            this.tabPageConfigurateZprobe.Controls.Add(this.groupBox3);
            this.tabPageConfigurateZprobe.Controls.Add(this.grpBxEngageZprobe);
            this.tabPageConfigurateZprobe.Controls.Add(this.grpBxTestZprobe);
            this.tabPageConfigurateZprobe.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigurateZprobe.Name = "tabPageConfigurateZprobe";
            this.tabPageConfigurateZprobe.Size = new System.Drawing.Size(874, 657);
            this.tabPageConfigurateZprobe.TabIndex = 6;
            this.tabPageConfigurateZprobe.Text = "Configurate Z-probe";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageConfigurateZprobe, "Configuration and Test of the Z-probe");
            this.tabPageConfigurateZprobe.UseVisualStyleBackColor = true;
            // 
            // grpBxZprobeHeight
            // 
            this.grpBxZprobeHeight.Controls.Add(this.btnZpromeEepromUpdate);
            this.grpBxZprobeHeight.Controls.Add(this.btnZpromeFirmwareUpdate);
            this.grpBxZprobeHeight.Controls.Add(this.txtBxJogControlZprobeHeightHelp);
            this.grpBxZprobeHeight.Controls.Add(this.btnStartZprobeHeight);
            this.grpBxZprobeHeight.Controls.Add(this.txtBxCalculatedZProbeOffset);
            this.grpBxZprobeHeight.Controls.Add(this.btnZprobeHeightNext);
            this.grpBxZprobeHeight.Controls.Add(this.lblCalculatedZProbeOffset);
            this.grpBxZprobeHeight.Location = new System.Drawing.Point(400, 238);
            this.grpBxZprobeHeight.Name = "grpBxZprobeHeight";
            this.grpBxZprobeHeight.Size = new System.Drawing.Size(382, 290);
            this.grpBxZprobeHeight.TabIndex = 53;
            this.grpBxZprobeHeight.TabStop = false;
            this.grpBxZprobeHeight.Text = "Z Probe Offset";
            // 
            // btnZpromeEepromUpdate
            // 
            this.btnZpromeEepromUpdate.Location = new System.Drawing.Point(10, 223);
            this.btnZpromeEepromUpdate.Name = "btnZpromeEepromUpdate";
            this.btnZpromeEepromUpdate.Size = new System.Drawing.Size(366, 23);
            this.btnZpromeEepromUpdate.TabIndex = 32;
            this.btnZpromeEepromUpdate.Text = "Update/Save EEPROM with Z-probe offset";
            this.btnZpromeEepromUpdate.Visible = false;
            this.btnZpromeEepromUpdate.Click += new System.EventHandler(this.btnZpromeEepromUpdate_Click);
            // 
            // btnZpromeFirmwareUpdate
            // 
            this.btnZpromeFirmwareUpdate.Location = new System.Drawing.Point(10, 252);
            this.btnZpromeFirmwareUpdate.Name = "btnZpromeFirmwareUpdate";
            this.btnZpromeFirmwareUpdate.Size = new System.Drawing.Size(366, 23);
            this.btnZpromeFirmwareUpdate.TabIndex = 0;
            this.btnZpromeFirmwareUpdate.Text = "Update Current Firmware with Z-probe offset";
            this.btnZpromeFirmwareUpdate.Visible = false;
            this.btnZpromeFirmwareUpdate.Click += new System.EventHandler(this.btnZprobeFirmwareUpdate_Click);
            // 
            // txtBxJogControlZprobeHeightHelp
            // 
            this.txtBxJogControlZprobeHeightHelp.Location = new System.Drawing.Point(10, 48);
            this.txtBxJogControlZprobeHeightHelp.Multiline = true;
            this.txtBxJogControlZprobeHeightHelp.Name = "txtBxJogControlZprobeHeightHelp";
            this.txtBxJogControlZprobeHeightHelp.Size = new System.Drawing.Size(366, 57);
            this.txtBxJogControlZprobeHeightHelp.TabIndex = 31;
            this.txtBxJogControlZprobeHeightHelp.Text = "1. Put a paper under the nozzle.\r\n2. Using the jog-control to find where the nozz" +
    "le touch the paper\r\n3. Finish the manual adjustment when the nozzle is touching " +
    "the paper";
            this.txtBxJogControlZprobeHeightHelp.Visible = false;
            // 
            // btnStartZprobeHeight
            // 
            this.btnStartZprobeHeight.Location = new System.Drawing.Point(10, 19);
            this.btnStartZprobeHeight.Name = "btnStartZprobeHeight";
            this.btnStartZprobeHeight.Size = new System.Drawing.Size(366, 23);
            this.btnStartZprobeHeight.TabIndex = 28;
            this.btnStartZprobeHeight.Text = "Start finding the Z-Probe offset";
            this.btnStartZprobeHeight.UseVisualStyleBackColor = true;
            this.btnStartZprobeHeight.Click += new System.EventHandler(this.btnStartZprobeHeight_Click);
            // 
            // txtBxCalculatedZProbeOffset
            // 
            this.txtBxCalculatedZProbeOffset.Location = new System.Drawing.Point(148, 154);
            this.txtBxCalculatedZProbeOffset.Name = "txtBxCalculatedZProbeOffset";
            this.txtBxCalculatedZProbeOffset.Size = new System.Drawing.Size(100, 20);
            this.txtBxCalculatedZProbeOffset.TabIndex = 30;
            this.txtBxCalculatedZProbeOffset.Visible = false;
            this.txtBxCalculatedZProbeOffset.WordWrap = false;
            // 
            // btnZprobeHeightNext
            // 
            this.btnZprobeHeightNext.Location = new System.Drawing.Point(10, 111);
            this.btnZprobeHeightNext.Name = "btnZprobeHeightNext";
            this.btnZprobeHeightNext.Size = new System.Drawing.Size(366, 23);
            this.btnZprobeHeightNext.TabIndex = 24;
            this.btnZprobeHeightNext.Text = "Finish manual adjustment when the nozzle is touching the paper";
            this.btnZprobeHeightNext.UseVisualStyleBackColor = true;
            this.btnZprobeHeightNext.Visible = false;
            this.btnZprobeHeightNext.Click += new System.EventHandler(this.btnZprobeHeightNext_Click);
            // 
            // lblCalculatedZProbeOffset
            // 
            this.lblCalculatedZProbeOffset.AutoSize = true;
            this.lblCalculatedZProbeOffset.Location = new System.Drawing.Point(14, 157);
            this.lblCalculatedZProbeOffset.Name = "lblCalculatedZProbeOffset";
            this.lblCalculatedZProbeOffset.Size = new System.Drawing.Size(128, 13);
            this.lblCalculatedZProbeOffset.TabIndex = 29;
            this.lblCalculatedZProbeOffset.Text = "Calculated Z-probe Offset";
            this.lblCalculatedZProbeOffset.Visible = false;
            // 
            // grpZprobeConfigMax
            // 
            this.grpZprobeConfigMax.Controls.Add(this.btnZmaxTravel);
            this.grpZprobeConfigMax.Controls.Add(this.lblZmaxTravel);
            this.grpZprobeConfigMax.Controls.Add(this.numUpDnZmaxTravel);
            this.grpZprobeConfigMax.Controls.Add(this.trkBrZmaxTravel);
            this.grpZprobeConfigMax.Location = new System.Drawing.Point(589, 8);
            this.grpZprobeConfigMax.Name = "grpZprobeConfigMax";
            this.grpZprobeConfigMax.Size = new System.Drawing.Size(193, 223);
            this.grpZprobeConfigMax.TabIndex = 52;
            this.grpZprobeConfigMax.TabStop = false;
            this.grpZprobeConfigMax.Text = "Max Z travel";
            // 
            // btnZmaxTravel
            // 
            this.btnZmaxTravel.Location = new System.Drawing.Point(68, 70);
            this.btnZmaxTravel.Name = "btnZmaxTravel";
            this.btnZmaxTravel.Size = new System.Drawing.Size(75, 23);
            this.btnZmaxTravel.TabIndex = 3;
            this.btnZmaxTravel.Text = "Save";
            this.btnZmaxTravel.UseVisualStyleBackColor = true;
            this.btnZmaxTravel.Click += new System.EventHandler(this.btnZmaxTravel_Click);
            // 
            // lblZmaxTravel
            // 
            this.lblZmaxTravel.AutoSize = true;
            this.lblZmaxTravel.Location = new System.Drawing.Point(65, 28);
            this.lblZmaxTravel.Name = "lblZmaxTravel";
            this.lblZmaxTravel.Size = new System.Drawing.Size(67, 13);
            this.lblZmaxTravel.TabIndex = 2;
            this.lblZmaxTravel.Text = "Max Z in mm";
            // 
            // numUpDnZmaxTravel
            // 
            this.numUpDnZmaxTravel.Location = new System.Drawing.Point(68, 44);
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
            this.numUpDnZmaxTravel.Size = new System.Drawing.Size(84, 20);
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
            this.trkBrZmaxTravel.Location = new System.Drawing.Point(14, 19);
            this.trkBrZmaxTravel.Maximum = 300;
            this.trkBrZmaxTravel.Minimum = 100;
            this.trkBrZmaxTravel.Name = "trkBrZmaxTravel";
            this.trkBrZmaxTravel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBrZmaxTravel.Size = new System.Drawing.Size(45, 193);
            this.trkBrZmaxTravel.TabIndex = 0;
            this.trkBrZmaxTravel.Value = 100;
            this.trkBrZmaxTravel.Scroll += new System.EventHandler(this.trkBrZmaxTravel_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTestZprobeRelease);
            this.groupBox3.Controls.Add(this.btnTestZprobeReleaseSave);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtBxGcodeAssistZprobeRelease);
            this.groupBox3.Location = new System.Drawing.Point(13, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 105);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Release Z-probe";
            // 
            // btnTestZprobeRelease
            // 
            this.btnTestZprobeRelease.Location = new System.Drawing.Point(397, 71);
            this.btnTestZprobeRelease.Name = "btnTestZprobeRelease";
            this.btnTestZprobeRelease.Size = new System.Drawing.Size(85, 23);
            this.btnTestZprobeRelease.TabIndex = 18;
            this.btnTestZprobeRelease.Text = "Test Release";
            this.btnTestZprobeRelease.UseVisualStyleBackColor = true;
            this.btnTestZprobeRelease.Click += new System.EventHandler(this.btnTestZprobeRelease_Click);
            // 
            // btnTestZprobeReleaseSave
            // 
            this.btnTestZprobeReleaseSave.Location = new System.Drawing.Point(507, 71);
            this.btnTestZprobeReleaseSave.Name = "btnTestZprobeReleaseSave";
            this.btnTestZprobeReleaseSave.Size = new System.Drawing.Size(53, 23);
            this.btnTestZprobeReleaseSave.TabIndex = 17;
            this.btnTestZprobeReleaseSave.Text = "Save";
            this.btnTestZprobeReleaseSave.UseVisualStyleBackColor = true;
            this.btnTestZprobeReleaseSave.Click += new System.EventHandler(this.btnTestZprobeReleaseSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCreateExampleForZprobeServoRelease);
            this.groupBox4.Controls.Add(this.btnCreateExampleForZprobeSledRelease);
            this.groupBox4.Controls.Add(this.btnCreateExampleForZprobePositionRelease);
            this.groupBox4.Location = new System.Drawing.Point(386, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 52);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Create example for Z-probe Release";
            // 
            // btnCreateExampleForZprobeServoRelease
            // 
            this.btnCreateExampleForZprobeServoRelease.Location = new System.Drawing.Point(11, 19);
            this.btnCreateExampleForZprobeServoRelease.Name = "btnCreateExampleForZprobeServoRelease";
            this.btnCreateExampleForZprobeServoRelease.Size = new System.Drawing.Size(53, 23);
            this.btnCreateExampleForZprobeServoRelease.TabIndex = 12;
            this.btnCreateExampleForZprobeServoRelease.Text = "Servo";
            this.btnCreateExampleForZprobeServoRelease.UseVisualStyleBackColor = true;
            // 
            // btnCreateExampleForZprobeSledRelease
            // 
            this.btnCreateExampleForZprobeSledRelease.Location = new System.Drawing.Point(66, 19);
            this.btnCreateExampleForZprobeSledRelease.Name = "btnCreateExampleForZprobeSledRelease";
            this.btnCreateExampleForZprobeSledRelease.Size = new System.Drawing.Size(53, 23);
            this.btnCreateExampleForZprobeSledRelease.TabIndex = 14;
            this.btnCreateExampleForZprobeSledRelease.Text = "Sled";
            this.btnCreateExampleForZprobeSledRelease.UseVisualStyleBackColor = true;
            // 
            // btnCreateExampleForZprobePositionRelease
            // 
            this.btnCreateExampleForZprobePositionRelease.Location = new System.Drawing.Point(121, 19);
            this.btnCreateExampleForZprobePositionRelease.Name = "btnCreateExampleForZprobePositionRelease";
            this.btnCreateExampleForZprobePositionRelease.Size = new System.Drawing.Size(53, 23);
            this.btnCreateExampleForZprobePositionRelease.TabIndex = 13;
            this.btnCreateExampleForZprobePositionRelease.Text = "Position";
            this.btnCreateExampleForZprobePositionRelease.UseVisualStyleBackColor = true;
            // 
            // txtBxGcodeAssistZprobeRelease
            // 
            this.txtBxGcodeAssistZprobeRelease.Location = new System.Drawing.Point(6, 19);
            this.txtBxGcodeAssistZprobeRelease.Multiline = true;
            this.txtBxGcodeAssistZprobeRelease.Name = "txtBxGcodeAssistZprobeRelease";
            this.txtBxGcodeAssistZprobeRelease.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxGcodeAssistZprobeRelease.Size = new System.Drawing.Size(374, 78);
            this.txtBxGcodeAssistZprobeRelease.TabIndex = 11;
            this.txtBxGcodeAssistZprobeRelease.Text = "G28 Y\r\nG28 X\r\nG1 X300;";
            // 
            // grpBxEngageZprobe
            // 
            this.grpBxEngageZprobe.Controls.Add(this.btnTestZprobeEngage);
            this.grpBxEngageZprobe.Controls.Add(this.btnTestZprobeEngageSave);
            this.grpBxEngageZprobe.Controls.Add(this.groupBox1);
            this.grpBxEngageZprobe.Controls.Add(this.txtBxGcodeAssistZprobeEngage);
            this.grpBxEngageZprobe.Location = new System.Drawing.Point(13, 14);
            this.grpBxEngageZprobe.Name = "grpBxEngageZprobe";
            this.grpBxEngageZprobe.Size = new System.Drawing.Size(570, 106);
            this.grpBxEngageZprobe.TabIndex = 50;
            this.grpBxEngageZprobe.TabStop = false;
            this.grpBxEngageZprobe.Text = "Engage Z-probe";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxEngageZprobe, "How the Z-probe is engaged in meassure position");
            // 
            // btnTestZprobeEngage
            // 
            this.btnTestZprobeEngage.Location = new System.Drawing.Point(397, 77);
            this.btnTestZprobeEngage.Name = "btnTestZprobeEngage";
            this.btnTestZprobeEngage.Size = new System.Drawing.Size(85, 23);
            this.btnTestZprobeEngage.TabIndex = 16;
            this.btnTestZprobeEngage.Text = "Test Engage";
            this.btnTestZprobeEngage.UseVisualStyleBackColor = true;
            this.btnTestZprobeEngage.Click += new System.EventHandler(this.btnTestZprobeEngage_Click);
            // 
            // btnTestZprobeEngageSave
            // 
            this.btnTestZprobeEngageSave.Location = new System.Drawing.Point(507, 77);
            this.btnTestZprobeEngageSave.Name = "btnTestZprobeEngageSave";
            this.btnTestZprobeEngageSave.Size = new System.Drawing.Size(53, 23);
            this.btnTestZprobeEngageSave.TabIndex = 15;
            this.btnTestZprobeEngageSave.Text = "Save";
            this.btnTestZprobeEngageSave.UseVisualStyleBackColor = true;
            this.btnTestZprobeEngageSave.Click += new System.EventHandler(this.btnTestZprobeEngageSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateExampleForZprobeServoEngage);
            this.groupBox1.Controls.Add(this.btnCreateExampleForZprobeSledEngage);
            this.groupBox1.Controls.Add(this.btnCreateExampleForZprobePositionEngage);
            this.groupBox1.Location = new System.Drawing.Point(386, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 52);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create example for Z-probe Engage";
            // 
            // btnCreateExampleForZprobeServoEngage
            // 
            this.btnCreateExampleForZprobeServoEngage.Location = new System.Drawing.Point(11, 19);
            this.btnCreateExampleForZprobeServoEngage.Name = "btnCreateExampleForZprobeServoEngage";
            this.btnCreateExampleForZprobeServoEngage.Size = new System.Drawing.Size(53, 23);
            this.btnCreateExampleForZprobeServoEngage.TabIndex = 12;
            this.btnCreateExampleForZprobeServoEngage.Text = "Servo";
            this.btnCreateExampleForZprobeServoEngage.UseVisualStyleBackColor = true;
            this.btnCreateExampleForZprobeServoEngage.Click += new System.EventHandler(this.btnCreateExampleForZprobeServo_Click);
            // 
            // btnCreateExampleForZprobeSledEngage
            // 
            this.btnCreateExampleForZprobeSledEngage.Location = new System.Drawing.Point(66, 19);
            this.btnCreateExampleForZprobeSledEngage.Name = "btnCreateExampleForZprobeSledEngage";
            this.btnCreateExampleForZprobeSledEngage.Size = new System.Drawing.Size(53, 23);
            this.btnCreateExampleForZprobeSledEngage.TabIndex = 14;
            this.btnCreateExampleForZprobeSledEngage.Text = "Sled";
            this.btnCreateExampleForZprobeSledEngage.UseVisualStyleBackColor = true;
            this.btnCreateExampleForZprobeSledEngage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateExampleForZprobePositionEngage
            // 
            this.btnCreateExampleForZprobePositionEngage.Location = new System.Drawing.Point(121, 19);
            this.btnCreateExampleForZprobePositionEngage.Name = "btnCreateExampleForZprobePositionEngage";
            this.btnCreateExampleForZprobePositionEngage.Size = new System.Drawing.Size(53, 23);
            this.btnCreateExampleForZprobePositionEngage.TabIndex = 13;
            this.btnCreateExampleForZprobePositionEngage.Text = "Position";
            this.btnCreateExampleForZprobePositionEngage.UseVisualStyleBackColor = true;
            this.btnCreateExampleForZprobePositionEngage.Click += new System.EventHandler(this.btnCreateExampleForZprobePosition_Click);
            // 
            // txtBxGcodeAssistZprobeEngage
            // 
            this.txtBxGcodeAssistZprobeEngage.Location = new System.Drawing.Point(6, 19);
            this.txtBxGcodeAssistZprobeEngage.Multiline = true;
            this.txtBxGcodeAssistZprobeEngage.Name = "txtBxGcodeAssistZprobeEngage";
            this.txtBxGcodeAssistZprobeEngage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxGcodeAssistZprobeEngage.Size = new System.Drawing.Size(374, 78);
            this.txtBxGcodeAssistZprobeEngage.TabIndex = 11;
            this.txtBxGcodeAssistZprobeEngage.Text = "G28 Y\r\nG28 X\r\nG1 X300;";
            this.toolTip3DprinterTool.SetToolTip(this.txtBxGcodeAssistZprobeEngage, "G-Code that engage the Z-probe");
            // 
            // grpBxTestZprobe
            // 
            this.grpBxTestZprobe.Controls.Add(this.fctbM48Responce);
            this.grpBxTestZprobe.Controls.Add(this.lblM48Repetition);
            this.grpBxTestZprobe.Controls.Add(this.btnM48Repetition);
            this.grpBxTestZprobe.Controls.Add(this.numUpDnM48Repetitions);
            this.grpBxTestZprobe.Location = new System.Drawing.Point(13, 237);
            this.grpBxTestZprobe.Name = "grpBxTestZprobe";
            this.grpBxTestZprobe.Size = new System.Drawing.Size(380, 412);
            this.grpBxTestZprobe.TabIndex = 49;
            this.grpBxTestZprobe.TabStop = false;
            this.grpBxTestZprobe.Text = "Test Z-Probe";
            // 
            // fctbM48Responce
            // 
            this.fctbM48Responce.AutoCompleteBracketsList = new char[] {
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
            this.fctbM48Responce.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctbM48Responce.BackBrush = null;
            this.fctbM48Responce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fctbM48Responce.CharHeight = 14;
            this.fctbM48Responce.CharWidth = 8;
            this.fctbM48Responce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbM48Responce.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbM48Responce.IsReplaceMode = false;
            this.fctbM48Responce.Location = new System.Drawing.Point(6, 44);
            this.fctbM48Responce.Name = "fctbM48Responce";
            this.fctbM48Responce.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbM48Responce.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbM48Responce.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbM48Responce.ServiceColors")));
            this.fctbM48Responce.ShowLineNumbers = false;
            this.fctbM48Responce.Size = new System.Drawing.Size(361, 150);
            this.fctbM48Responce.TabIndex = 15;
            this.fctbM48Responce.Zoom = 100;
            // 
            // lblM48Repetition
            // 
            this.lblM48Repetition.AutoSize = true;
            this.lblM48Repetition.Location = new System.Drawing.Point(20, 20);
            this.lblM48Repetition.Name = "lblM48Repetition";
            this.lblM48Repetition.Size = new System.Drawing.Size(107, 13);
            this.lblM48Repetition.TabIndex = 14;
            this.lblM48Repetition.Text = "Number of Repetition";
            // 
            // btnM48Repetition
            // 
            this.btnM48Repetition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnM48Repetition.Location = new System.Drawing.Point(180, 15);
            this.btnM48Repetition.Name = "btnM48Repetition";
            this.btnM48Repetition.Size = new System.Drawing.Size(152, 23);
            this.btnM48Repetition.TabIndex = 13;
            this.btnM48Repetition.Text = "Z-Probe repetition M48";
            this.btnM48Repetition.UseVisualStyleBackColor = true;
            this.btnM48Repetition.Click += new System.EventHandler(this.btnM48Repetition_Click);
            // 
            // numUpDnM48Repetitions
            // 
            this.numUpDnM48Repetitions.Location = new System.Drawing.Point(130, 18);
            this.numUpDnM48Repetitions.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnM48Repetitions.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDnM48Repetitions.Name = "numUpDnM48Repetitions";
            this.numUpDnM48Repetitions.Size = new System.Drawing.Size(36, 20);
            this.numUpDnM48Repetitions.TabIndex = 12;
            this.numUpDnM48Repetitions.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // tabPageBedLevel
            // 
            this.tabPageBedLevel.Controls.Add(this.grpAutoBedLevel);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust3);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust2);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust4);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust1);
            this.tabPageBedLevel.Controls.Add(this.panel2);
            this.tabPageBedLevel.Controls.Add(this.picBxUpperLeftAdjuster);
            this.tabPageBedLevel.Controls.Add(this.picBxUpperRightAdjuster);
            this.tabPageBedLevel.Controls.Add(this.picBxLowerRightAdjuster);
            this.tabPageBedLevel.Controls.Add(this.picBxLowerLeftAdjuster);
            this.tabPageBedLevel.Location = new System.Drawing.Point(4, 22);
            this.tabPageBedLevel.Name = "tabPageBedLevel";
            this.tabPageBedLevel.Size = new System.Drawing.Size(874, 657);
            this.tabPageBedLevel.TabIndex = 5;
            this.tabPageBedLevel.Text = "Bed Level";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageBedLevel, "Help for level the building surface");
            this.tabPageBedLevel.UseVisualStyleBackColor = true;
            // 
            // grpAutoBedLevel
            // 
            this.grpAutoBedLevel.Controls.Add(this.btnAutoBedLevel);
            this.grpAutoBedLevel.Controls.Add(this.txtBxAutoBedLevelResponce);
            this.grpAutoBedLevel.Location = new System.Drawing.Point(20, 423);
            this.grpAutoBedLevel.Name = "grpAutoBedLevel";
            this.grpAutoBedLevel.Size = new System.Drawing.Size(596, 206);
            this.grpAutoBedLevel.TabIndex = 49;
            this.grpAutoBedLevel.TabStop = false;
            this.grpAutoBedLevel.Text = "Auto Bed Level";
            // 
            // btnAutoBedLevel
            // 
            this.btnAutoBedLevel.Location = new System.Drawing.Point(447, 19);
            this.btnAutoBedLevel.Name = "btnAutoBedLevel";
            this.btnAutoBedLevel.Size = new System.Drawing.Size(149, 35);
            this.btnAutoBedLevel.TabIndex = 1;
            this.btnAutoBedLevel.Text = "Auto Bed Level (G29)";
            this.btnAutoBedLevel.UseVisualStyleBackColor = true;
            this.btnAutoBedLevel.Click += new System.EventHandler(this.btnAutoBedLevel_Click);
            // 
            // txtBxAutoBedLevelResponce
            // 
            this.txtBxAutoBedLevelResponce.Location = new System.Drawing.Point(12, 19);
            this.txtBxAutoBedLevelResponce.Multiline = true;
            this.txtBxAutoBedLevelResponce.Name = "txtBxAutoBedLevelResponce";
            this.txtBxAutoBedLevelResponce.Size = new System.Drawing.Size(429, 165);
            this.txtBxAutoBedLevelResponce.TabIndex = 0;
            // 
            // panelAdjust3
            // 
            this.panelAdjust3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdjust3.Controls.Add(this.picBxTurn3);
            this.panelAdjust3.Controls.Add(this.lblAdjustValue3);
            this.panelAdjust3.Controls.Add(this.lblTurn3);
            this.panelAdjust3.Location = new System.Drawing.Point(668, 38);
            this.panelAdjust3.Name = "panelAdjust3";
            this.panelAdjust3.Size = new System.Drawing.Size(100, 60);
            this.panelAdjust3.TabIndex = 43;
            // 
            // picBxTurn3
            // 
            this.picBxTurn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxTurn3.Location = new System.Drawing.Point(4, 3);
            this.picBxTurn3.Name = "picBxTurn3";
            this.picBxTurn3.Size = new System.Drawing.Size(32, 32);
            this.picBxTurn3.TabIndex = 24;
            this.picBxTurn3.TabStop = false;
            // 
            // lblAdjustValue3
            // 
            this.lblAdjustValue3.AutoSize = true;
            this.lblAdjustValue3.Location = new System.Drawing.Point(42, 3);
            this.lblAdjustValue3.Name = "lblAdjustValue3";
            this.lblAdjustValue3.Size = new System.Drawing.Size(53, 13);
            this.lblAdjustValue3.TabIndex = 31;
            this.lblAdjustValue3.Text = "Unknown";
            this.lblAdjustValue3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTurn3
            // 
            this.lblTurn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTurn3.AutoSize = true;
            this.lblTurn3.Location = new System.Drawing.Point(3, 43);
            this.lblTurn3.Name = "lblTurn3";
            this.lblTurn3.Size = new System.Drawing.Size(25, 13);
            this.lblTurn3.TabIndex = 27;
            this.lblTurn3.Text = "turn";
            this.lblTurn3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAdjust2
            // 
            this.panelAdjust2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdjust2.Controls.Add(this.picBxTurn2);
            this.panelAdjust2.Controls.Add(this.lblAdjustValue2);
            this.panelAdjust2.Controls.Add(this.lblTurn2);
            this.panelAdjust2.Location = new System.Drawing.Point(663, 233);
            this.panelAdjust2.Name = "panelAdjust2";
            this.panelAdjust2.Size = new System.Drawing.Size(100, 60);
            this.panelAdjust2.TabIndex = 44;
            // 
            // picBxTurn2
            // 
            this.picBxTurn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxTurn2.Location = new System.Drawing.Point(4, 3);
            this.picBxTurn2.Name = "picBxTurn2";
            this.picBxTurn2.Size = new System.Drawing.Size(32, 32);
            this.picBxTurn2.TabIndex = 24;
            this.picBxTurn2.TabStop = false;
            // 
            // lblAdjustValue2
            // 
            this.lblAdjustValue2.AutoSize = true;
            this.lblAdjustValue2.Location = new System.Drawing.Point(42, 3);
            this.lblAdjustValue2.Name = "lblAdjustValue2";
            this.lblAdjustValue2.Size = new System.Drawing.Size(53, 13);
            this.lblAdjustValue2.TabIndex = 31;
            this.lblAdjustValue2.Text = "Unknown";
            this.lblAdjustValue2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTurn2
            // 
            this.lblTurn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTurn2.AutoSize = true;
            this.lblTurn2.Location = new System.Drawing.Point(3, 38);
            this.lblTurn2.Name = "lblTurn2";
            this.lblTurn2.Size = new System.Drawing.Size(25, 13);
            this.lblTurn2.TabIndex = 27;
            this.lblTurn2.Text = "turn";
            this.lblTurn2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAdjust4
            // 
            this.panelAdjust4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdjust4.Controls.Add(this.picBxTurn4);
            this.panelAdjust4.Controls.Add(this.lblAdjustValue4);
            this.panelAdjust4.Controls.Add(this.lblTurn4);
            this.panelAdjust4.Location = new System.Drawing.Point(20, 38);
            this.panelAdjust4.Name = "panelAdjust4";
            this.panelAdjust4.Size = new System.Drawing.Size(100, 60);
            this.panelAdjust4.TabIndex = 42;
            // 
            // picBxTurn4
            // 
            this.picBxTurn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxTurn4.Location = new System.Drawing.Point(6, 3);
            this.picBxTurn4.Name = "picBxTurn4";
            this.picBxTurn4.Size = new System.Drawing.Size(32, 32);
            this.picBxTurn4.TabIndex = 24;
            this.picBxTurn4.TabStop = false;
            // 
            // lblAdjustValue4
            // 
            this.lblAdjustValue4.AutoSize = true;
            this.lblAdjustValue4.Location = new System.Drawing.Point(44, 3);
            this.lblAdjustValue4.Name = "lblAdjustValue4";
            this.lblAdjustValue4.Size = new System.Drawing.Size(53, 13);
            this.lblAdjustValue4.TabIndex = 31;
            this.lblAdjustValue4.Text = "Unknown";
            this.lblAdjustValue4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTurn4
            // 
            this.lblTurn4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTurn4.AutoSize = true;
            this.lblTurn4.Location = new System.Drawing.Point(3, 43);
            this.lblTurn4.Name = "lblTurn4";
            this.lblTurn4.Size = new System.Drawing.Size(25, 13);
            this.lblTurn4.TabIndex = 27;
            this.lblTurn4.Text = "turn";
            this.lblTurn4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelAdjust1
            // 
            this.panelAdjust1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdjust1.Controls.Add(this.picBxTurn1);
            this.panelAdjust1.Controls.Add(this.lblAdjustValue1);
            this.panelAdjust1.Controls.Add(this.lblTurn1);
            this.panelAdjust1.Location = new System.Drawing.Point(20, 234);
            this.panelAdjust1.Name = "panelAdjust1";
            this.panelAdjust1.Size = new System.Drawing.Size(100, 60);
            this.panelAdjust1.TabIndex = 41;
            // 
            // picBxTurn1
            // 
            this.picBxTurn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBxTurn1.Location = new System.Drawing.Point(5, 3);
            this.picBxTurn1.Name = "picBxTurn1";
            this.picBxTurn1.Size = new System.Drawing.Size(32, 32);
            this.picBxTurn1.TabIndex = 24;
            this.picBxTurn1.TabStop = false;
            // 
            // lblAdjustValue1
            // 
            this.lblAdjustValue1.AutoSize = true;
            this.lblAdjustValue1.Location = new System.Drawing.Point(42, 3);
            this.lblAdjustValue1.Name = "lblAdjustValue1";
            this.lblAdjustValue1.Size = new System.Drawing.Size(0, 13);
            this.lblAdjustValue1.TabIndex = 31;
            this.lblAdjustValue1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTurn1
            // 
            this.lblTurn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTurn1.AutoSize = true;
            this.lblTurn1.Location = new System.Drawing.Point(3, 38);
            this.lblTurn1.Name = "lblTurn1";
            this.lblTurn1.Size = new System.Drawing.Size(25, 13);
            this.lblTurn1.TabIndex = 27;
            this.lblTurn1.Text = "turn";
            this.lblTurn1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnProbeTheBed);
            this.panel2.Location = new System.Drawing.Point(164, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 300);
            this.panel2.TabIndex = 40;
            // 
            // btnProbeTheBed
            // 
            this.btnProbeTheBed.Location = new System.Drawing.Point(181, 108);
            this.btnProbeTheBed.Name = "btnProbeTheBed";
            this.btnProbeTheBed.Size = new System.Drawing.Size(75, 47);
            this.btnProbeTheBed.TabIndex = 0;
            this.btnProbeTheBed.Text = "Probe the Bed";
            this.btnProbeTheBed.UseVisualStyleBackColor = true;
            this.btnProbeTheBed.Click += new System.EventHandler(this.btnProbeTheBed_Click);
            // 
            // picBxUpperLeftAdjuster
            // 
            this.picBxUpperLeftAdjuster.Image = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.picBxUpperLeftAdjuster.Location = new System.Drawing.Point(126, 42);
            this.picBxUpperLeftAdjuster.Name = "picBxUpperLeftAdjuster";
            this.picBxUpperLeftAdjuster.Size = new System.Drawing.Size(32, 32);
            this.picBxUpperLeftAdjuster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxUpperLeftAdjuster.TabIndex = 48;
            this.picBxUpperLeftAdjuster.TabStop = false;
            // 
            // picBxUpperRightAdjuster
            // 
            this.picBxUpperRightAdjuster.Image = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.picBxUpperRightAdjuster.Location = new System.Drawing.Point(624, 42);
            this.picBxUpperRightAdjuster.Name = "picBxUpperRightAdjuster";
            this.picBxUpperRightAdjuster.Size = new System.Drawing.Size(32, 32);
            this.picBxUpperRightAdjuster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxUpperRightAdjuster.TabIndex = 47;
            this.picBxUpperRightAdjuster.TabStop = false;
            // 
            // picBxLowerRightAdjuster
            // 
            this.picBxLowerRightAdjuster.Image = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.picBxLowerRightAdjuster.Location = new System.Drawing.Point(624, 238);
            this.picBxLowerRightAdjuster.Name = "picBxLowerRightAdjuster";
            this.picBxLowerRightAdjuster.Size = new System.Drawing.Size(32, 32);
            this.picBxLowerRightAdjuster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLowerRightAdjuster.TabIndex = 46;
            this.picBxLowerRightAdjuster.TabStop = false;
            // 
            // picBxLowerLeftAdjuster
            // 
            this.picBxLowerLeftAdjuster.Image = global::Marlin3DprinterTool.Properties.Resources.adjuster;
            this.picBxLowerLeftAdjuster.Location = new System.Drawing.Point(126, 238);
            this.picBxLowerLeftAdjuster.Name = "picBxLowerLeftAdjuster";
            this.picBxLowerLeftAdjuster.Size = new System.Drawing.Size(32, 32);
            this.picBxLowerLeftAdjuster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLowerLeftAdjuster.TabIndex = 45;
            this.picBxLowerLeftAdjuster.TabStop = false;
            // 
            // tabPageScanSurface
            // 
            this.tabPageScanSurface.Controls.Add(this.nChartControlSurface);
            this.tabPageScanSurface.Controls.Add(this.btnMeshLevel);
            this.tabPageScanSurface.Controls.Add(this.numUpDownNumberOfRepetitions);
            this.tabPageScanSurface.Controls.Add(this.lblNumberOfRepetitions);
            this.tabPageScanSurface.Controls.Add(this.lblYpoints);
            this.tabPageScanSurface.Controls.Add(this.lblXpoints);
            this.tabPageScanSurface.Controls.Add(this.btnScanSurface);
            this.tabPageScanSurface.Controls.Add(this.numUpDownYpoints);
            this.tabPageScanSurface.Controls.Add(this.numUpDownXpoints);
            this.tabPageScanSurface.Location = new System.Drawing.Point(4, 22);
            this.tabPageScanSurface.Name = "tabPageScanSurface";
            this.tabPageScanSurface.Size = new System.Drawing.Size(874, 657);
            this.tabPageScanSurface.TabIndex = 9;
            this.tabPageScanSurface.Text = "Scan buildsurface";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageScanSurface, "Scan the building surface");
            this.tabPageScanSurface.UseVisualStyleBackColor = true;
            // 
            // nChartControlSurface
            // 
            this.nChartControlSurface.AutoRefresh = false;
            this.nChartControlSurface.BackColor = System.Drawing.SystemColors.Control;
            this.nChartControlSurface.InputKeys = new System.Windows.Forms.Keys[0];
            this.nChartControlSurface.Location = new System.Drawing.Point(19, 64);
            this.nChartControlSurface.Name = "nChartControlSurface";
            this.nChartControlSurface.Size = new System.Drawing.Size(814, 578);
            this.nChartControlSurface.State = ((Nevron.Chart.WinForm.NState)(resources.GetObject("nChartControlSurface.State")));
            this.nChartControlSurface.TabIndex = 21;
            this.nChartControlSurface.Text = "nChartControl1";
            // 
            // btnMeshLevel
            // 
            this.btnMeshLevel.Location = new System.Drawing.Point(652, 10);
            this.btnMeshLevel.Name = "btnMeshLevel";
            this.btnMeshLevel.Size = new System.Drawing.Size(116, 23);
            this.btnMeshLevel.TabIndex = 20;
            this.btnMeshLevel.Text = "Mash Bed Level";
            this.btnMeshLevel.UseVisualStyleBackColor = true;
            this.btnMeshLevel.Click += new System.EventHandler(this.btnMeshLevel_Click);
            // 
            // numUpDownNumberOfRepetitions
            // 
            this.numUpDownNumberOfRepetitions.Location = new System.Drawing.Point(435, 13);
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
            this.lblNumberOfRepetitions.Location = new System.Drawing.Point(314, 15);
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
            this.btnScanSurface.Location = new System.Drawing.Point(486, 10);
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
            this.tabPagePID.Location = new System.Drawing.Point(4, 22);
            this.tabPagePID.Name = "tabPagePID";
            this.tabPagePID.Size = new System.Drawing.Size(874, 657);
            this.tabPagePID.TabIndex = 10;
            this.tabPagePID.Text = "PID";
            this.tabPagePID.UseVisualStyleBackColor = true;
            // 
            // fctbPidResponce
            // 
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
            this.fctbPidResponce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fctbPidResponce.IsReplaceMode = false;
            this.fctbPidResponce.Location = new System.Drawing.Point(0, 411);
            this.fctbPidResponce.Name = "fctbPidResponce";
            this.fctbPidResponce.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbPidResponce.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbPidResponce.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbPidResponce.ServiceColors")));
            this.fctbPidResponce.ShowLineNumbers = false;
            this.fctbPidResponce.Size = new System.Drawing.Size(874, 246);
            this.fctbPidResponce.TabIndex = 16;
            this.fctbPidResponce.Zoom = 100;
            // 
            // grpBxHeatbedPID
            // 
            this.grpBxHeatbedPID.Controls.Add(this.groupBox9);
            this.grpBxHeatbedPID.Controls.Add(this.btnCalculateBedPid);
            this.grpBxHeatbedPID.Controls.Add(this.groupBox8);
            this.grpBxHeatbedPID.Controls.Add(this.groupBox7);
            this.grpBxHeatbedPID.Location = new System.Drawing.Point(294, 5);
            this.grpBxHeatbedPID.Name = "grpBxHeatbedPID";
            this.grpBxHeatbedPID.Size = new System.Drawing.Size(285, 389);
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
            this.groupBox9.Controls.Add(this.btnTransferBedPidKp);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Location = new System.Drawing.Point(6, 258);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(270, 125);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Result";
            // 
            // txtBxKdBed
            // 
            this.txtBxKdBed.Location = new System.Drawing.Point(29, 69);
            this.txtBxKdBed.Name = "txtBxKdBed";
            this.txtBxKdBed.Size = new System.Drawing.Size(43, 20);
            this.txtBxKdBed.TabIndex = 20;
            // 
            // txtBxKiBed
            // 
            this.txtBxKiBed.Location = new System.Drawing.Point(29, 43);
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
            this.btnUpdateBedPid.Location = new System.Drawing.Point(29, 95);
            this.btnUpdateBedPid.Name = "btnUpdateBedPid";
            this.btnUpdateBedPid.Size = new System.Drawing.Size(235, 23);
            this.btnUpdateBedPid.TabIndex = 11;
            this.btnUpdateBedPid.Text = "Update and Save EEPROM";
            this.btnUpdateBedPid.UseVisualStyleBackColor = true;
            this.btnUpdateBedPid.Click += new System.EventHandler(this.btnUpdateBedPid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
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
            // btnTransferBedPidKp
            // 
            this.btnTransferBedPidKp.Location = new System.Drawing.Point(78, 16);
            this.btnTransferBedPidKp.Name = "btnTransferBedPidKp";
            this.btnTransferBedPidKp.Size = new System.Drawing.Size(148, 23);
            this.btnTransferBedPidKp.TabIndex = 11;
            this.btnTransferBedPidKp.Text = "Transfer To Firmware";
            this.btnTransferBedPidKp.UseVisualStyleBackColor = true;
            this.btnTransferBedPidKp.Click += new System.EventHandler(this.btnTransferBedPid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ki:";
            // 
            // btnCalculateBedPid
            // 
            this.btnCalculateBedPid.Location = new System.Drawing.Point(6, 229);
            this.btnCalculateBedPid.Name = "btnCalculateBedPid";
            this.btnCalculateBedPid.Size = new System.Drawing.Size(273, 23);
            this.btnCalculateBedPid.TabIndex = 9;
            this.btnCalculateBedPid.Text = "PID Autotune for the Bed";
            this.btnCalculateBedPid.UseVisualStyleBackColor = true;
            this.btnCalculateBedPid.Click += new System.EventHandler(this.btnCalculateBedPid_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numUpDownPidBedCykles);
            this.groupBox8.Controls.Add(this.trkBarPidBedCykles);
            this.groupBox8.Location = new System.Drawing.Point(6, 125);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(273, 98);
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
            this.numUpDownPidBedCykles.Size = new System.Drawing.Size(261, 20);
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
            this.trkBarPidBedCykles.Size = new System.Drawing.Size(261, 45);
            this.trkBarPidBedCykles.SmallChange = 5;
            this.trkBarPidBedCykles.TabIndex = 7;
            this.trkBarPidBedCykles.Value = 5;
            this.trkBarPidBedCykles.Scroll += new System.EventHandler(this.trkBarPidBedCykles_Scroll);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.trkBarPidBedTemp);
            this.groupBox7.Controls.Add(this.numUpDownPidBedTemp);
            this.groupBox7.Location = new System.Drawing.Point(6, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 100);
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
            this.trkBarPidBedTemp.Size = new System.Drawing.Size(261, 45);
            this.trkBarPidBedTemp.SmallChange = 5;
            this.trkBarPidBedTemp.TabIndex = 6;
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
            this.numUpDownPidBedTemp.Size = new System.Drawing.Size(261, 20);
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
            this.grpBxExtruderPID.Controls.Add(this.grpBxPidExtruder);
            this.grpBxExtruderPID.Controls.Add(this.grpBxPidExtruderTemp);
            this.grpBxExtruderPID.Controls.Add(this.grpBxPidExtruderCykles);
            this.grpBxExtruderPID.Controls.Add(this.btnCalculateExtruderPid);
            this.grpBxExtruderPID.Location = new System.Drawing.Point(3, 3);
            this.grpBxExtruderPID.Name = "grpBxExtruderPID";
            this.grpBxExtruderPID.Size = new System.Drawing.Size(285, 391);
            this.grpBxExtruderPID.TabIndex = 0;
            this.grpBxExtruderPID.TabStop = false;
            this.grpBxExtruderPID.Text = "Extruder(s)";
            // 
            // grpBxPidExtruder
            // 
            this.grpBxPidExtruder.Controls.Add(this.txtBxKdExtruder);
            this.grpBxPidExtruder.Controls.Add(this.txtBxKiExtruder);
            this.grpBxPidExtruder.Controls.Add(this.txtBxKpExtruder);
            this.grpBxPidExtruder.Controls.Add(this.btnTransferExtruderPidKp);
            this.grpBxPidExtruder.Controls.Add(this.lblKdExtruder);
            this.grpBxPidExtruder.Controls.Add(this.btnUpdateExtruderPid);
            this.grpBxPidExtruder.Controls.Add(this.lblKiExtruder);
            this.grpBxPidExtruder.Controls.Add(this.lblKpExtruder);
            this.grpBxPidExtruder.Location = new System.Drawing.Point(6, 260);
            this.grpBxPidExtruder.Name = "grpBxPidExtruder";
            this.grpBxPidExtruder.Size = new System.Drawing.Size(273, 125);
            this.grpBxPidExtruder.TabIndex = 7;
            this.grpBxPidExtruder.TabStop = false;
            this.grpBxPidExtruder.Text = "Result";
            // 
            // txtBxKdExtruder
            // 
            this.txtBxKdExtruder.Location = new System.Drawing.Point(32, 69);
            this.txtBxKdExtruder.Name = "txtBxKdExtruder";
            this.txtBxKdExtruder.Size = new System.Drawing.Size(43, 20);
            this.txtBxKdExtruder.TabIndex = 16;
            // 
            // txtBxKiExtruder
            // 
            this.txtBxKiExtruder.Location = new System.Drawing.Point(32, 43);
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
            // btnTransferExtruderPidKp
            // 
            this.btnTransferExtruderPidKp.Location = new System.Drawing.Point(81, 16);
            this.btnTransferExtruderPidKp.Name = "btnTransferExtruderPidKp";
            this.btnTransferExtruderPidKp.Size = new System.Drawing.Size(148, 23);
            this.btnTransferExtruderPidKp.TabIndex = 9;
            this.btnTransferExtruderPidKp.Text = "Transfer To Firmware";
            this.btnTransferExtruderPidKp.UseVisualStyleBackColor = true;
            this.btnTransferExtruderPidKp.Click += new System.EventHandler(this.btnTransferExtruderPid_Click);
            // 
            // lblKdExtruder
            // 
            this.lblKdExtruder.AutoSize = true;
            this.lblKdExtruder.Location = new System.Drawing.Point(6, 72);
            this.lblKdExtruder.Name = "lblKdExtruder";
            this.lblKdExtruder.Size = new System.Drawing.Size(23, 13);
            this.lblKdExtruder.TabIndex = 14;
            this.lblKdExtruder.Text = "Kd:";
            // 
            // btnUpdateExtruderPid
            // 
            this.btnUpdateExtruderPid.Location = new System.Drawing.Point(32, 95);
            this.btnUpdateExtruderPid.Name = "btnUpdateExtruderPid";
            this.btnUpdateExtruderPid.Size = new System.Drawing.Size(197, 23);
            this.btnUpdateExtruderPid.TabIndex = 10;
            this.btnUpdateExtruderPid.Text = "Update and Save EEPROM";
            this.btnUpdateExtruderPid.UseVisualStyleBackColor = true;
            this.btnUpdateExtruderPid.Click += new System.EventHandler(this.btnUpdateExtruderPid_Click);
            // 
            // lblKiExtruder
            // 
            this.lblKiExtruder.AutoSize = true;
            this.lblKiExtruder.Location = new System.Drawing.Point(7, 50);
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
            this.grpBxPidExtruderTemp.Location = new System.Drawing.Point(6, 21);
            this.grpBxPidExtruderTemp.Name = "grpBxPidExtruderTemp";
            this.grpBxPidExtruderTemp.Size = new System.Drawing.Size(273, 100);
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
            this.trkBarPidExtruderTemp.Size = new System.Drawing.Size(267, 45);
            this.trkBarPidExtruderTemp.SmallChange = 5;
            this.trkBarPidExtruderTemp.TabIndex = 6;
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
            this.numUpDownPidExtruderTemp.Size = new System.Drawing.Size(267, 20);
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
            this.grpBxPidExtruderCykles.Location = new System.Drawing.Point(6, 127);
            this.grpBxPidExtruderCykles.Name = "grpBxPidExtruderCykles";
            this.grpBxPidExtruderCykles.Size = new System.Drawing.Size(273, 98);
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
            this.numUpDownPidExtruderCykles.Size = new System.Drawing.Size(267, 20);
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
            this.trkBarPidExtruderCykles.Size = new System.Drawing.Size(267, 45);
            this.trkBarPidExtruderCykles.SmallChange = 5;
            this.trkBarPidExtruderCykles.TabIndex = 7;
            this.trkBarPidExtruderCykles.Value = 5;
            this.trkBarPidExtruderCykles.Scroll += new System.EventHandler(this.trkBarPidExtruderCykles_Scroll);
            // 
            // btnCalculateExtruderPid
            // 
            this.btnCalculateExtruderPid.Location = new System.Drawing.Point(6, 231);
            this.btnCalculateExtruderPid.Name = "btnCalculateExtruderPid";
            this.btnCalculateExtruderPid.Size = new System.Drawing.Size(273, 23);
            this.btnCalculateExtruderPid.TabIndex = 3;
            this.btnCalculateExtruderPid.Text = "PID Autotune for the Extruder";
            this.btnCalculateExtruderPid.UseVisualStyleBackColor = true;
            this.btnCalculateExtruderPid.Click += new System.EventHandler(this.btnCalculateExtruderPid_Click);
            // 
            // tabPageExtruderCalibration
            // 
            this.tabPageExtruderCalibration.Controls.Add(this.richTextBox3);
            this.tabPageExtruderCalibration.Controls.Add(this.groupBox2);
            this.tabPageExtruderCalibration.Controls.Add(this.grpBxCalculate);
            this.tabPageExtruderCalibration.Controls.Add(this.grpBxTestExtrude);
            this.tabPageExtruderCalibration.Location = new System.Drawing.Point(4, 22);
            this.tabPageExtruderCalibration.Name = "tabPageExtruderCalibration";
            this.tabPageExtruderCalibration.Size = new System.Drawing.Size(874, 657);
            this.tabPageExtruderCalibration.TabIndex = 2;
            this.tabPageExtruderCalibration.Text = "Extruder Calibration";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageExtruderCalibration, "Extruder calibration");
            this.tabPageExtruderCalibration.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(7, 352);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(777, 168);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkBxColdExtruderCalibration);
            this.groupBox2.Controls.Add(this.numUpDnCalibrateExtruderTemp);
            this.groupBox2.Controls.Add(this.btnHeatExtruderForCalibration);
            this.groupBox2.Controls.Add(this.trkBarTemperature);
            this.groupBox2.Location = new System.Drawing.Point(7, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1069, 174);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperarure";
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
            this.numUpDnCalibrateExtruderTemp.Size = new System.Drawing.Size(250, 20);
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
            this.btnHeatExtruderForCalibration.Size = new System.Drawing.Size(251, 29);
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
            this.trkBarTemperature.Size = new System.Drawing.Size(251, 45);
            this.trkBarTemperature.SmallChange = 5;
            this.trkBarTemperature.TabIndex = 0;
            this.trkBarTemperature.Value = 170;
            this.trkBarTemperature.Scroll += new System.EventHandler(this.trkBarTemperature_Scroll);
            // 
            // grpBxCalculate
            // 
            this.grpBxCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxCalculate.Controls.Add(this.btnExtruderCalibrationCalculate);
            this.grpBxCalculate.Controls.Add(this.btnM92Extruder);
            this.grpBxCalculate.Controls.Add(this.lblFirmware);
            this.grpBxCalculate.Controls.Add(this.numUpDnFirmware);
            this.grpBxCalculate.Controls.Add(this.numUpDnMeassure);
            this.grpBxCalculate.Controls.Add(this.lblMeassure);
            this.grpBxCalculate.Location = new System.Drawing.Point(7, 252);
            this.grpBxCalculate.Name = "grpBxCalculate";
            this.grpBxCalculate.Size = new System.Drawing.Size(1069, 83);
            this.grpBxCalculate.TabIndex = 10;
            this.grpBxCalculate.TabStop = false;
            this.grpBxCalculate.Text = "Calculate";
            this.grpBxCalculate.Visible = false;
            // 
            // btnExtruderCalibrationCalculate
            // 
            this.btnExtruderCalibrationCalculate.Location = new System.Drawing.Point(226, 24);
            this.btnExtruderCalibrationCalculate.Name = "btnExtruderCalibrationCalculate";
            this.btnExtruderCalibrationCalculate.Size = new System.Drawing.Size(97, 46);
            this.btnExtruderCalibrationCalculate.TabIndex = 10;
            this.btnExtruderCalibrationCalculate.Text = "Calculate";
            this.btnExtruderCalibrationCalculate.UseVisualStyleBackColor = true;
            this.btnExtruderCalibrationCalculate.Click += new System.EventHandler(this.btnExtruderCalibrationCalculate_Click);
            // 
            // btnM92Extruder
            // 
            this.btnM92Extruder.Location = new System.Drawing.Point(335, 24);
            this.btnM92Extruder.Name = "btnM92Extruder";
            this.btnM92Extruder.Size = new System.Drawing.Size(118, 46);
            this.btnM92Extruder.TabIndex = 8;
            this.btnM92Extruder.Text = "Update in EEPROM";
            this.btnM92Extruder.UseVisualStyleBackColor = true;
            this.btnM92Extruder.Click += new System.EventHandler(this.btnM92_Click);
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.Location = new System.Drawing.Point(6, 26);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(86, 13);
            this.lblFirmware.TabIndex = 5;
            this.lblFirmware.Text = "Current Firmware";
            // 
            // numUpDnFirmware
            // 
            this.numUpDnFirmware.Location = new System.Drawing.Point(137, 24);
            this.numUpDnFirmware.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDnFirmware.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnFirmware.Name = "numUpDnFirmware";
            this.numUpDnFirmware.Size = new System.Drawing.Size(78, 20);
            this.numUpDnFirmware.TabIndex = 2;
            this.numUpDnFirmware.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numUpDnMeassure
            // 
            this.numUpDnMeassure.Location = new System.Drawing.Point(137, 50);
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
            // lblMeassure
            // 
            this.lblMeassure.AutoSize = true;
            this.lblMeassure.Location = new System.Drawing.Point(6, 52);
            this.lblMeassure.Name = "lblMeassure";
            this.lblMeassure.Size = new System.Drawing.Size(124, 13);
            this.lblMeassure.TabIndex = 7;
            this.lblMeassure.Text = "Meassured used filament";
            // 
            // grpBxTestExtrude
            // 
            this.grpBxTestExtrude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxTestExtrude.Controls.Add(this.lblExtrude);
            this.grpBxTestExtrude.Controls.Add(this.btnExtruderCalibation);
            this.grpBxTestExtrude.Controls.Add(this.numUpDnExtrude);
            this.grpBxTestExtrude.Location = new System.Drawing.Point(7, 193);
            this.grpBxTestExtrude.Name = "grpBxTestExtrude";
            this.grpBxTestExtrude.Size = new System.Drawing.Size(1069, 53);
            this.grpBxTestExtrude.TabIndex = 9;
            this.grpBxTestExtrude.TabStop = false;
            this.grpBxTestExtrude.Text = "Test extrusion";
            this.grpBxTestExtrude.Visible = false;
            // 
            // lblExtrude
            // 
            this.lblExtrude.AutoSize = true;
            this.lblExtrude.Location = new System.Drawing.Point(6, 25);
            this.lblExtrude.Name = "lblExtrude";
            this.lblExtrude.Size = new System.Drawing.Size(98, 13);
            this.lblExtrude.TabIndex = 3;
            this.lblExtrude.Text = "Test extrude length";
            // 
            // btnExtruderCalibation
            // 
            this.btnExtruderCalibation.Location = new System.Drawing.Point(226, 23);
            this.btnExtruderCalibation.Name = "btnExtruderCalibation";
            this.btnExtruderCalibation.Size = new System.Drawing.Size(118, 21);
            this.btnExtruderCalibation.TabIndex = 8;
            this.btnExtruderCalibation.Text = "Test extrude";
            this.btnExtruderCalibation.UseVisualStyleBackColor = true;
            this.btnExtruderCalibation.Click += new System.EventHandler(this.btnExtruderCalibation_Click);
            // 
            // numUpDnExtrude
            // 
            this.numUpDnExtrude.Location = new System.Drawing.Point(137, 24);
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
            this.tabPageZMaintenance.Controls.Add(this.grpBxZMaintenance);
            this.tabPageZMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tabPageZMaintenance.Name = "tabPageZMaintenance";
            this.tabPageZMaintenance.Size = new System.Drawing.Size(874, 657);
            this.tabPageZMaintenance.TabIndex = 7;
            this.tabPageZMaintenance.Text = "Z  Maintenance";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageZMaintenance, "Move Z up and down for oiling and check for binding(s)");
            this.tabPageZMaintenance.UseVisualStyleBackColor = true;
            // 
            // grpBxZMaintenance
            // 
            this.grpBxZMaintenance.Controls.Add(this.txtBxZmaintenanceDescription);
            this.grpBxZMaintenance.Controls.Add(this.btnZmaintenanceRun);
            this.grpBxZMaintenance.Controls.Add(this.btnZmaintenanceCancel);
            this.grpBxZMaintenance.Controls.Add(this.grpBxZmaintMin);
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
            this.txtBxZmaintenanceDescription.Location = new System.Drawing.Point(259, 61);
            this.txtBxZmaintenanceDescription.Multiline = true;
            this.txtBxZmaintenanceDescription.Name = "txtBxZmaintenanceDescription";
            this.txtBxZmaintenanceDescription.Size = new System.Drawing.Size(215, 205);
            this.txtBxZmaintenanceDescription.TabIndex = 4;
            // 
            // btnZmaintenanceRun
            // 
            this.btnZmaintenanceRun.Location = new System.Drawing.Point(333, 272);
            this.btnZmaintenanceRun.Name = "btnZmaintenanceRun";
            this.btnZmaintenanceRun.Size = new System.Drawing.Size(75, 23);
            this.btnZmaintenanceRun.TabIndex = 6;
            this.btnZmaintenanceRun.Text = "Run";
            this.btnZmaintenanceRun.UseVisualStyleBackColor = true;
            this.btnZmaintenanceRun.Click += new System.EventHandler(this.btnZmaintenanceRun_Click);
            // 
            // btnZmaintenanceCancel
            // 
            this.btnZmaintenanceCancel.Location = new System.Drawing.Point(259, 272);
            this.btnZmaintenanceCancel.Name = "btnZmaintenanceCancel";
            this.btnZmaintenanceCancel.Size = new System.Drawing.Size(68, 23);
            this.btnZmaintenanceCancel.TabIndex = 7;
            this.btnZmaintenanceCancel.Text = "Cancel";
            this.btnZmaintenanceCancel.UseVisualStyleBackColor = true;
            this.btnZmaintenanceCancel.Click += new System.EventHandler(this.btnZmaintenanceCancel_Click);
            // 
            // grpBxZmaintMin
            // 
            this.grpBxZmaintMin.Controls.Add(this.trackBarZmaintenanceMin);
            this.grpBxZmaintMin.Location = new System.Drawing.Point(122, 19);
            this.grpBxZmaintMin.Name = "grpBxZmaintMin";
            this.grpBxZmaintMin.Size = new System.Drawing.Size(119, 282);
            this.grpBxZmaintMin.TabIndex = 7;
            this.grpBxZmaintMin.TabStop = false;
            this.grpBxZmaintMin.Text = "Move Z Lower Limit";
            // 
            // trackBarZmaintenanceMin
            // 
            this.trackBarZmaintenanceMin.Location = new System.Drawing.Point(12, 18);
            this.trackBarZmaintenanceMin.Maximum = 100;
            this.trackBarZmaintenanceMin.Minimum = 2;
            this.trackBarZmaintenanceMin.Name = "trackBarZmaintenanceMin";
            this.trackBarZmaintenanceMin.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarZmaintenanceMin.Size = new System.Drawing.Size(45, 258);
            this.trackBarZmaintenanceMin.TabIndex = 1;
            this.trackBarZmaintenanceMin.Value = 2;
            this.trackBarZmaintenanceMin.Scroll += new System.EventHandler(this.trackBarZmaintenanceMin_Scroll);
            // 
            // grpBxZmaintMax
            // 
            this.grpBxZmaintMax.Controls.Add(this.trackBarZmaintenanceMax);
            this.grpBxZmaintMax.Location = new System.Drawing.Point(6, 19);
            this.grpBxZmaintMax.Name = "grpBxZmaintMax";
            this.grpBxZmaintMax.Size = new System.Drawing.Size(110, 282);
            this.grpBxZmaintMax.TabIndex = 6;
            this.grpBxZmaintMax.TabStop = false;
            this.grpBxZmaintMax.Text = "Move Z High Limit";
            // 
            // trackBarZmaintenanceMax
            // 
            this.trackBarZmaintenanceMax.Location = new System.Drawing.Point(6, 20);
            this.trackBarZmaintenanceMax.Maximum = 250;
            this.trackBarZmaintenanceMax.Minimum = 100;
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
            this.lblZmaintenanceRepetitions.Location = new System.Drawing.Point(256, 19);
            this.lblZmaintenanceRepetitions.Name = "lblZmaintenanceRepetitions";
            this.lblZmaintenanceRepetitions.Size = new System.Drawing.Size(107, 13);
            this.lblZmaintenanceRepetitions.TabIndex = 5;
            this.lblZmaintenanceRepetitions.Text = "Number of repetitions";
            // 
            // numUpDnZmaintenanceRepetitions
            // 
            this.numUpDnZmaintenanceRepetitions.Location = new System.Drawing.Point(259, 35);
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
            // tabPageCalculations
            // 
            this.tabPageCalculations.Controls.Add(this.grpBxFeedRate);
            this.tabPageCalculations.Controls.Add(this.grpBxExtruderCalculation);
            this.tabPageCalculations.Controls.Add(this.grpBxBelts);
            this.tabPageCalculations.Controls.Add(this.grpBxLeadScrew);
            this.tabPageCalculations.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalculations.Name = "tabPageCalculations";
            this.tabPageCalculations.Size = new System.Drawing.Size(874, 657);
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
            this.grpBxFeedRate.Location = new System.Drawing.Point(539, 19);
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
            this.grpBxExtruderCalculation.Controls.Add(this.btnExtruderUpdateStepsPerMMinFirmware);
            this.grpBxExtruderCalculation.Controls.Add(this.btnExtruderUpdateStepsPerMMinEEPROM);
            this.grpBxExtruderCalculation.Controls.Add(this.btnExtruderOldFirmware);
            this.grpBxExtruderCalculation.Controls.Add(this.lblExtruderOldFirmware);
            this.grpBxExtruderCalculation.Controls.Add(this.numUpDnExtruderOldFirmware);
            this.grpBxExtruderCalculation.Controls.Add(this.numUpDnExtruderMeassuredExtrusion);
            this.grpBxExtruderCalculation.Controls.Add(this.lblExtruderMeassuredValue);
            this.grpBxExtruderCalculation.Controls.Add(this.lblExtruderExpectedValue);
            this.grpBxExtruderCalculation.Controls.Add(this.numUpDnExtruderExpectedValue);
            this.grpBxExtruderCalculation.Controls.Add(this.fastColoredTextBoxExtruderStepsPerMM);
            this.grpBxExtruderCalculation.Location = new System.Drawing.Point(343, 19);
            this.grpBxExtruderCalculation.Name = "grpBxExtruderCalculation";
            this.grpBxExtruderCalculation.Size = new System.Drawing.Size(189, 346);
            this.grpBxExtruderCalculation.TabIndex = 24;
            this.grpBxExtruderCalculation.TabStop = false;
            this.grpBxExtruderCalculation.Text = "Extruder";
            // 
            // btnExtruderUpdateStepsPerMMinFirmware
            // 
            this.btnExtruderUpdateStepsPerMMinFirmware.Location = new System.Drawing.Point(9, 265);
            this.btnExtruderUpdateStepsPerMMinFirmware.Name = "btnExtruderUpdateStepsPerMMinFirmware";
            this.btnExtruderUpdateStepsPerMMinFirmware.Size = new System.Drawing.Size(174, 26);
            this.btnExtruderUpdateStepsPerMMinFirmware.TabIndex = 31;
            this.btnExtruderUpdateStepsPerMMinFirmware.Text = "Update current Firmware";
            this.toolTip3DprinterTool.SetToolTip(this.btnExtruderUpdateStepsPerMMinFirmware, "Update the current Firmwarefile (configuration.h) with the calculated steps per m" +
        "m");
            this.btnExtruderUpdateStepsPerMMinFirmware.UseVisualStyleBackColor = true;
            this.btnExtruderUpdateStepsPerMMinFirmware.Click += new System.EventHandler(this.btnExtruderUpdateStepsPerMMinFirmware_Click);
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
            // btnExtruderOldFirmware
            // 
            this.btnExtruderOldFirmware.Location = new System.Drawing.Point(115, 139);
            this.btnExtruderOldFirmware.Name = "btnExtruderOldFirmware";
            this.btnExtruderOldFirmware.Size = new System.Drawing.Size(68, 23);
            this.btnExtruderOldFirmware.TabIndex = 29;
            this.btnExtruderOldFirmware.Text = "Ask printer";
            this.toolTip3DprinterTool.SetToolTip(this.btnExtruderOldFirmware, "Sends a M501 and parse the result to get current Firmware Steps per mm");
            this.btnExtruderOldFirmware.UseVisualStyleBackColor = true;
            this.btnExtruderOldFirmware.Click += new System.EventHandler(this.btnExtruderOldFirmware_Click);
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
            this.fastColoredTextBoxExtruderStepsPerMM.CharHeight = 14;
            this.fastColoredTextBoxExtruderStepsPerMM.CharWidth = 8;
            this.fastColoredTextBoxExtruderStepsPerMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxExtruderStepsPerMM.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
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
            this.fastColoredTextBoxBeltStepsPerMM.CharHeight = 14;
            this.fastColoredTextBoxBeltStepsPerMM.CharWidth = 8;
            this.fastColoredTextBoxBeltStepsPerMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxBeltStepsPerMM.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
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
            this.fastColoredTextBoxLeadScrewStepsPerMM.CharHeight = 14;
            this.fastColoredTextBoxLeadScrewStepsPerMM.CharWidth = 8;
            this.fastColoredTextBoxLeadScrewStepsPerMM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxLeadScrewStepsPerMM.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
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
            // tabPageStlViewer
            // 
            this.tabPageStlViewer.Controls.Add(this.grpBxInstallingStlThumbnailServer);
            this.tabPageStlViewer.Location = new System.Drawing.Point(4, 22);
            this.tabPageStlViewer.Name = "tabPageStlViewer";
            this.tabPageStlViewer.Size = new System.Drawing.Size(874, 657);
            this.tabPageStlViewer.TabIndex = 12;
            this.tabPageStlViewer.Text = "STL viewer";
            this.tabPageStlViewer.UseVisualStyleBackColor = true;
            // 
            // grpBxInstallingStlThumbnailServer
            // 
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.grpBxAssociateStlViewer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.groupBox11);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnColorStl);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnRestartWindowsFileExplorer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnResetAndCleanExistingThumbnails);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnTroubleShootStl);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.grpBxServe32);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.grpBxServe64);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.chkBx32BitOS);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnUnInstallStlServer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnInstallStlServer);
            this.grpBxInstallingStlThumbnailServer.Location = new System.Drawing.Point(17, 19);
            this.grpBxInstallingStlThumbnailServer.Name = "grpBxInstallingStlThumbnailServer";
            this.grpBxInstallingStlThumbnailServer.Size = new System.Drawing.Size(776, 388);
            this.grpBxInstallingStlThumbnailServer.TabIndex = 4;
            this.grpBxInstallingStlThumbnailServer.TabStop = false;
            this.grpBxInstallingStlThumbnailServer.Text = "Installing the STL thumbnail Shell Extension";
            // 
            // grpBxAssociateStlViewer
            // 
            this.grpBxAssociateStlViewer.Controls.Add(this.btnAssociateStlViewer);
            this.grpBxAssociateStlViewer.Location = new System.Drawing.Point(553, 160);
            this.grpBxAssociateStlViewer.Name = "grpBxAssociateStlViewer";
            this.grpBxAssociateStlViewer.Size = new System.Drawing.Size(217, 56);
            this.grpBxAssociateStlViewer.TabIndex = 5;
            this.grpBxAssociateStlViewer.TabStop = false;
            this.grpBxAssociateStlViewer.Text = "Associate STL viewer";
            // 
            // btnAssociateStlViewer
            // 
            this.btnAssociateStlViewer.Location = new System.Drawing.Point(6, 19);
            this.btnAssociateStlViewer.Name = "btnAssociateStlViewer";
            this.btnAssociateStlViewer.Size = new System.Drawing.Size(205, 23);
            this.btnAssociateStlViewer.TabIndex = 5;
            this.btnAssociateStlViewer.Text = "STL Viewer prefered STL viewer";
            this.btnAssociateStlViewer.UseVisualStyleBackColor = true;
            this.btnAssociateStlViewer.Click += new System.EventHandler(this.btnAssociateStlViewer_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.textBoxAssociations);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Controls.Add(this.textBoxAssemblyPath);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.textBoxServerSecurity);
            this.groupBox11.Controls.Add(this.textBoxServerCLSID);
            this.groupBox11.Controls.Add(this.textBoxServerType);
            this.groupBox11.Controls.Add(this.textBoxServerName);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Location = new System.Drawing.Point(6, 100);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(541, 198);
            this.groupBox11.TabIndex = 15;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Server";
            // 
            // textBoxAssociations
            // 
            this.textBoxAssociations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAssociations.Location = new System.Drawing.Point(128, 161);
            this.textBoxAssociations.Name = "textBoxAssociations";
            this.textBoxAssociations.ReadOnly = true;
            this.textBoxAssociations.Size = new System.Drawing.Size(395, 20);
            this.textBoxAssociations.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Specified Associations";
            // 
            // textBoxAssemblyPath
            // 
            this.textBoxAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAssemblyPath.Location = new System.Drawing.Point(128, 135);
            this.textBoxAssemblyPath.Name = "textBoxAssemblyPath";
            this.textBoxAssemblyPath.ReadOnly = true;
            this.textBoxAssemblyPath.Size = new System.Drawing.Size(395, 20);
            this.textBoxAssemblyPath.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Assembly Path";
            // 
            // textBoxServerSecurity
            // 
            this.textBoxServerSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerSecurity.Location = new System.Drawing.Point(128, 109);
            this.textBoxServerSecurity.Name = "textBoxServerSecurity";
            this.textBoxServerSecurity.ReadOnly = true;
            this.textBoxServerSecurity.Size = new System.Drawing.Size(395, 20);
            this.textBoxServerSecurity.TabIndex = 7;
            // 
            // textBoxServerCLSID
            // 
            this.textBoxServerCLSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerCLSID.Location = new System.Drawing.Point(128, 83);
            this.textBoxServerCLSID.Name = "textBoxServerCLSID";
            this.textBoxServerCLSID.ReadOnly = true;
            this.textBoxServerCLSID.Size = new System.Drawing.Size(395, 20);
            this.textBoxServerCLSID.TabIndex = 5;
            // 
            // textBoxServerType
            // 
            this.textBoxServerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerType.Location = new System.Drawing.Point(128, 57);
            this.textBoxServerType.Name = "textBoxServerType";
            this.textBoxServerType.ReadOnly = true;
            this.textBoxServerType.Size = new System.Drawing.Size(395, 20);
            this.textBoxServerType.TabIndex = 3;
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerName.Location = new System.Drawing.Point(128, 31);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.ReadOnly = true;
            this.textBoxServerName.Size = new System.Drawing.Size(395, 20);
            this.textBoxServerName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Security";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Server CLSID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Server Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // btnColorStl
            // 
            this.btnColorStl.Location = new System.Drawing.Point(553, 54);
            this.btnColorStl.Name = "btnColorStl";
            this.btnColorStl.Size = new System.Drawing.Size(217, 37);
            this.btnColorStl.TabIndex = 14;
            this.btnColorStl.Text = "Color on STL";
            this.btnColorStl.UseVisualStyleBackColor = true;
            this.btnColorStl.Click += new System.EventHandler(this.btnColorStl_Click);
            // 
            // btnRestartWindowsFileExplorer
            // 
            this.btnRestartWindowsFileExplorer.Location = new System.Drawing.Point(553, 102);
            this.btnRestartWindowsFileExplorer.Name = "btnRestartWindowsFileExplorer";
            this.btnRestartWindowsFileExplorer.Size = new System.Drawing.Size(217, 23);
            this.btnRestartWindowsFileExplorer.TabIndex = 5;
            this.btnRestartWindowsFileExplorer.Text = "Restart Windows File Explorer";
            this.btnRestartWindowsFileExplorer.UseVisualStyleBackColor = true;
            this.btnRestartWindowsFileExplorer.Click += new System.EventHandler(this.btnRestartWindowsFileExplorer_Click);
            // 
            // btnResetAndCleanExistingThumbnails
            // 
            this.btnResetAndCleanExistingThumbnails.Location = new System.Drawing.Point(553, 131);
            this.btnResetAndCleanExistingThumbnails.Name = "btnResetAndCleanExistingThumbnails";
            this.btnResetAndCleanExistingThumbnails.Size = new System.Drawing.Size(217, 23);
            this.btnResetAndCleanExistingThumbnails.TabIndex = 13;
            this.btnResetAndCleanExistingThumbnails.Text = "Reset and Clean existing Thumbnails";
            this.btnResetAndCleanExistingThumbnails.UseVisualStyleBackColor = true;
            this.btnResetAndCleanExistingThumbnails.Click += new System.EventHandler(this.btnResetAndCleanExistingThumbnails_Click);
            // 
            // btnTroubleShootStl
            // 
            this.btnTroubleShootStl.Location = new System.Drawing.Point(553, 15);
            this.btnTroubleShootStl.Name = "btnTroubleShootStl";
            this.btnTroubleShootStl.Size = new System.Drawing.Size(217, 37);
            this.btnTroubleShootStl.TabIndex = 12;
            this.btnTroubleShootStl.Text = "Troubleshoot Guide";
            this.btnTroubleShootStl.UseVisualStyleBackColor = true;
            this.btnTroubleShootStl.Click += new System.EventHandler(this.btnTroubleShootStl_Click_1);
            // 
            // grpBxServe32
            // 
            this.grpBxServe32.Controls.Add(this.lblRegistered32);
            this.grpBxServe32.Controls.Add(this.lblServer32);
            this.grpBxServe32.Controls.Add(this.ledRegister32);
            this.grpBxServe32.Controls.Add(this.ledServer32);
            this.grpBxServe32.Location = new System.Drawing.Point(388, 19);
            this.grpBxServe32.Name = "grpBxServe32";
            this.grpBxServe32.Size = new System.Drawing.Size(159, 77);
            this.grpBxServe32.TabIndex = 11;
            this.grpBxServe32.TabStop = false;
            this.grpBxServe32.Text = "32-bit STL Thumbnail Server";
            // 
            // lblRegistered32
            // 
            this.lblRegistered32.AutoSize = true;
            this.lblRegistered32.Location = new System.Drawing.Point(54, 53);
            this.lblRegistered32.Name = "lblRegistered32";
            this.lblRegistered32.Size = new System.Drawing.Size(58, 13);
            this.lblRegistered32.TabIndex = 14;
            this.lblRegistered32.Text = "Registered";
            // 
            // lblServer32
            // 
            this.lblServer32.AutoSize = true;
            this.lblServer32.Location = new System.Drawing.Point(66, 24);
            this.lblServer32.Name = "lblServer32";
            this.lblServer32.Size = new System.Drawing.Size(46, 13);
            this.lblServer32.TabIndex = 14;
            this.lblServer32.Text = "Installed";
            // 
            // ledRegister32
            // 
            this.ledRegister32.Color = System.Drawing.Color.Gray;
            this.ledRegister32.Location = new System.Drawing.Point(118, 42);
            this.ledRegister32.Name = "ledRegister32";
            this.ledRegister32.On = true;
            this.ledRegister32.Size = new System.Drawing.Size(24, 24);
            this.ledRegister32.TabIndex = 9;
            this.ledRegister32.Text = "ledBulb1";
            // 
            // ledServer32
            // 
            this.ledServer32.Color = System.Drawing.Color.Gray;
            this.ledServer32.Location = new System.Drawing.Point(118, 14);
            this.ledServer32.Name = "ledServer32";
            this.ledServer32.On = true;
            this.ledServer32.Size = new System.Drawing.Size(24, 24);
            this.ledServer32.TabIndex = 8;
            this.ledServer32.Text = "ledBulb1";
            // 
            // grpBxServe64
            // 
            this.grpBxServe64.Controls.Add(this.lblRegistered64);
            this.grpBxServe64.Controls.Add(this.lblServer64);
            this.grpBxServe64.Controls.Add(this.groupBox10);
            this.grpBxServe64.Controls.Add(this.ledServer64);
            this.grpBxServe64.Controls.Add(this.ledRegister64);
            this.grpBxServe64.Location = new System.Drawing.Point(225, 19);
            this.grpBxServe64.Name = "grpBxServe64";
            this.grpBxServe64.Size = new System.Drawing.Size(157, 77);
            this.grpBxServe64.TabIndex = 10;
            this.grpBxServe64.TabStop = false;
            this.grpBxServe64.Text = "64-bit STL Thumbnail Server";
            // 
            // lblRegistered64
            // 
            this.lblRegistered64.AutoSize = true;
            this.lblRegistered64.Location = new System.Drawing.Point(52, 55);
            this.lblRegistered64.Name = "lblRegistered64";
            this.lblRegistered64.Size = new System.Drawing.Size(58, 13);
            this.lblRegistered64.TabIndex = 13;
            this.lblRegistered64.Text = "Registered";
            // 
            // lblServer64
            // 
            this.lblServer64.AutoSize = true;
            this.lblServer64.Location = new System.Drawing.Point(64, 24);
            this.lblServer64.Name = "lblServer64";
            this.lblServer64.Size = new System.Drawing.Size(46, 13);
            this.lblServer64.TabIndex = 12;
            this.lblServer64.Text = "Installed";
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(0, 106);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 100);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // ledServer64
            // 
            this.ledServer64.Color = System.Drawing.Color.Gray;
            this.ledServer64.Location = new System.Drawing.Point(116, 14);
            this.ledServer64.Name = "ledServer64";
            this.ledServer64.On = true;
            this.ledServer64.Size = new System.Drawing.Size(24, 24);
            this.ledServer64.TabIndex = 6;
            this.ledServer64.Text = "ledBulb1";
            // 
            // ledRegister64
            // 
            this.ledRegister64.Color = System.Drawing.Color.Gray;
            this.ledRegister64.Location = new System.Drawing.Point(116, 44);
            this.ledRegister64.Name = "ledRegister64";
            this.ledRegister64.On = true;
            this.ledRegister64.Size = new System.Drawing.Size(24, 24);
            this.ledRegister64.TabIndex = 7;
            this.ledRegister64.Text = "ledBulb1";
            // 
            // chkBx32BitOS
            // 
            this.chkBx32BitOS.AutoSize = true;
            this.chkBx32BitOS.Location = new System.Drawing.Point(14, 19);
            this.chkBx32BitOS.Name = "chkBx32BitOS";
            this.chkBx32BitOS.Size = new System.Drawing.Size(70, 17);
            this.chkBx32BitOS.TabIndex = 4;
            this.chkBx32BitOS.Text = "32-bit OS";
            this.chkBx32BitOS.UseVisualStyleBackColor = true;
            // 
            // btnUnInstallStlServer
            // 
            this.btnUnInstallStlServer.Location = new System.Drawing.Point(6, 71);
            this.btnUnInstallStlServer.Name = "btnUnInstallStlServer";
            this.btnUnInstallStlServer.Size = new System.Drawing.Size(194, 23);
            this.btnUnInstallStlServer.TabIndex = 3;
            this.btnUnInstallStlServer.Text = "UnInstall and unregister Stl Thumbnail";
            this.btnUnInstallStlServer.UseVisualStyleBackColor = true;
            this.btnUnInstallStlServer.Click += new System.EventHandler(this.btnUnRegisterStlServer_Click);
            // 
            // btnInstallStlServer
            // 
            this.btnInstallStlServer.Location = new System.Drawing.Point(6, 42);
            this.btnInstallStlServer.Name = "btnInstallStlServer";
            this.btnInstallStlServer.Size = new System.Drawing.Size(194, 23);
            this.btnInstallStlServer.TabIndex = 0;
            this.btnInstallStlServer.Text = "Install  and Register STL Thumbnail";
            this.btnInstallStlServer.UseVisualStyleBackColor = true;
            this.btnInstallStlServer.Click += new System.EventHandler(this.btnInstallStlServer_Click);
            // 
            // tabPageParameters
            // 
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
            this.tabPageParameters.Location = new System.Drawing.Point(4, 22);
            this.tabPageParameters.Name = "tabPageParameters";
            this.tabPageParameters.Size = new System.Drawing.Size(874, 657);
            this.tabPageParameters.TabIndex = 13;
            this.tabPageParameters.Text = "Parameters";
            this.tabPageParameters.UseVisualStyleBackColor = true;
            // 
            // btnM501ReadEeprom
            // 
            this.btnM501ReadEeprom.Location = new System.Drawing.Point(648, 393);
            this.btnM501ReadEeprom.Name = "btnM501ReadEeprom";
            this.btnM501ReadEeprom.Size = new System.Drawing.Size(94, 23);
            this.btnM501ReadEeprom.TabIndex = 30;
            this.btnM501ReadEeprom.Text = "Read EEPROM";
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
            this.grpMeshBedLevel.Location = new System.Drawing.Point(649, 186);
            this.grpMeshBedLevel.Name = "grpMeshBedLevel";
            this.grpMeshBedLevel.Size = new System.Drawing.Size(118, 163);
            this.grpMeshBedLevel.TabIndex = 14;
            this.grpMeshBedLevel.TabStop = false;
            this.grpMeshBedLevel.Text = "Mesh Bed Level";
            // 
            // btnShowMeshInSurfaceChart
            // 
            this.btnShowMeshInSurfaceChart.Location = new System.Drawing.Point(6, 122);
            this.btnShowMeshInSurfaceChart.Name = "btnShowMeshInSurfaceChart";
            this.btnShowMeshInSurfaceChart.Size = new System.Drawing.Size(106, 35);
            this.btnShowMeshInSurfaceChart.TabIndex = 9;
            this.btnShowMeshInSurfaceChart.Text = "Show Mesh in Surface Chart";
            this.btnShowMeshInSurfaceChart.UseVisualStyleBackColor = true;
            this.btnShowMeshInSurfaceChart.Click += new System.EventHandler(this.btnShowMeshInSurfaceChart_Click);
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
            this.btnM500SaveEeprom.Location = new System.Drawing.Point(649, 422);
            this.btnM500SaveEeprom.Name = "btnM500SaveEeprom";
            this.btnM500SaveEeprom.Size = new System.Drawing.Size(97, 23);
            this.btnM500SaveEeprom.TabIndex = 29;
            this.btnM500SaveEeprom.Text = "Save EEPROM";
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
            this.grpBxAcceleration.Location = new System.Drawing.Point(648, 15);
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
            this.lblBxAccelerationRetract.Location = new System.Drawing.Point(7, 54);
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
            this.lblBxAccelerationPrint.Location = new System.Drawing.Point(21, 28);
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
            this.fctbInit.IsReplaceMode = false;
            this.fctbInit.Location = new System.Drawing.Point(3, 3);
            this.fctbInit.Name = "fctbInit";
            this.fctbInit.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbInit.ReadOnly = true;
            this.fctbInit.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbInit.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbInit.ServiceColors")));
            this.fctbInit.ShowLineNumbers = false;
            this.fctbInit.Size = new System.Drawing.Size(342, 619);
            this.fctbInit.TabIndex = 0;
            this.fctbInit.Zoom = 100;
            this.fctbInit.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctbInit_TextChanged);
            // 
            // grpBxNavigation
            // 
            this.grpBxNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxNavigation.Controls.Add(this.btnRetractZprobe);
            this.grpBxNavigation.Controls.Add(this.kompassControllConfigBed);
            this.grpBxNavigation.Controls.Add(this.grpBxBed);
            this.grpBxNavigation.Controls.Add(this.btnHomeY);
            this.grpBxNavigation.Controls.Add(this.btnHomeX);
            this.grpBxNavigation.Controls.Add(this.verticalJogControlZprobeHeight);
            this.grpBxNavigation.Controls.Add(this.btnEngageZprobe);
            this.grpBxNavigation.Location = new System.Drawing.Point(902, 106);
            this.grpBxNavigation.Name = "grpBxNavigation";
            this.grpBxNavigation.Size = new System.Drawing.Size(478, 301);
            this.grpBxNavigation.TabIndex = 0;
            this.grpBxNavigation.TabStop = false;
            this.grpBxNavigation.Text = "Navigation";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxNavigation, "Navigation for saving positions");
            this.grpBxNavigation.Visible = false;
            // 
            // btnRetractZprobe
            // 
            this.btnRetractZprobe.Location = new System.Drawing.Point(337, 48);
            this.btnRetractZprobe.Name = "btnRetractZprobe";
            this.btnRetractZprobe.Size = new System.Drawing.Size(94, 23);
            this.btnRetractZprobe.TabIndex = 28;
            this.btnRetractZprobe.Text = "Retract Z probe";
            this.toolTip3DprinterTool.SetToolTip(this.btnRetractZprobe, "Retract the Z-probe");
            this.btnRetractZprobe.UseVisualStyleBackColor = true;
            this.btnRetractZprobe.Click += new System.EventHandler(this.btnRetractZprobe_Click);
            // 
            // kompassControllConfigBed
            // 
            this.kompassControllConfigBed.Location = new System.Drawing.Point(6, 15);
            this.kompassControllConfigBed.MarlinCommunication = null;
            this.kompassControllConfigBed.MaximumSize = new System.Drawing.Size(246, 246);
            this.kompassControllConfigBed.MinimumSize = new System.Drawing.Size(246, 246);
            this.kompassControllConfigBed.Name = "kompassControllConfigBed";
            this.kompassControllConfigBed.SendCurrentPosition = true;
            this.kompassControllConfigBed.Size = new System.Drawing.Size(246, 246);
            this.kompassControllConfigBed.TabIndex = 4;
            this.toolTip3DprinterTool.SetToolTip(this.kompassControllConfigBed, "Navigate the 3D printer in X and Y direction");
            // 
            // grpBxBed
            // 
            this.grpBxBed.Location = new System.Drawing.Point(195, 272);
            this.grpBxBed.Name = "grpBxBed";
            this.grpBxBed.Size = new System.Drawing.Size(57, 23);
            this.grpBxBed.TabIndex = 2;
            this.grpBxBed.Text = "Home Z";
            this.toolTip3DprinterTool.SetToolTip(this.grpBxBed, "Home Z");
            this.grpBxBed.UseVisualStyleBackColor = true;
            this.grpBxBed.Click += new System.EventHandler(this.btnHomeZ_Click);
            // 
            // btnHomeY
            // 
            this.btnHomeY.Location = new System.Drawing.Point(107, 272);
            this.btnHomeY.Name = "btnHomeY";
            this.btnHomeY.Size = new System.Drawing.Size(57, 23);
            this.btnHomeY.TabIndex = 1;
            this.btnHomeY.Text = "Home Y";
            this.toolTip3DprinterTool.SetToolTip(this.btnHomeY, "Home Y");
            this.btnHomeY.UseVisualStyleBackColor = true;
            this.btnHomeY.Click += new System.EventHandler(this.btnHomeY_Click);
            // 
            // btnHomeX
            // 
            this.btnHomeX.Location = new System.Drawing.Point(6, 272);
            this.btnHomeX.Name = "btnHomeX";
            this.btnHomeX.Size = new System.Drawing.Size(57, 23);
            this.btnHomeX.TabIndex = 0;
            this.btnHomeX.Text = "Home X";
            this.toolTip3DprinterTool.SetToolTip(this.btnHomeX, "Home X");
            this.btnHomeX.UseVisualStyleBackColor = true;
            this.btnHomeX.Click += new System.EventHandler(this.btnHomeX_Click);
            // 
            // verticalJogControlZprobeHeight
            // 
            this.verticalJogControlZprobeHeight.Location = new System.Drawing.Point(281, 19);
            this.verticalJogControlZprobeHeight.MarlinCommunication = null;
            this.verticalJogControlZprobeHeight.MaximumSize = new System.Drawing.Size(50, 250);
            this.verticalJogControlZprobeHeight.MinimumSize = new System.Drawing.Size(50, 250);
            this.verticalJogControlZprobeHeight.Name = "verticalJogControlZprobeHeight";
            this.verticalJogControlZprobeHeight.NegativeButtonsFirst = false;
            this.verticalJogControlZprobeHeight.SendCurrentPosition = false;
            this.verticalJogControlZprobeHeight.Size = new System.Drawing.Size(50, 250);
            this.verticalJogControlZprobeHeight.StepperMotor = "Z";
            this.verticalJogControlZprobeHeight.TabIndex = 27;
            this.verticalJogControlZprobeHeight.TextOver = "Z+";
            this.verticalJogControlZprobeHeight.TextUnder = "Z-";
            this.toolTip3DprinterTool.SetToolTip(this.verticalJogControlZprobeHeight, "Move the Nozzle Up and Down");
            this.verticalJogControlZprobeHeight.Visible100Movement = true;
            this.verticalJogControlZprobeHeight.Visible10Movement = true;
            this.verticalJogControlZprobeHeight.VisibleZero = true;
            this.verticalJogControlZprobeHeight.ZeroPositionAfterEachMove = true;
            // 
            // btnEngageZprobe
            // 
            this.btnEngageZprobe.Location = new System.Drawing.Point(337, 19);
            this.btnEngageZprobe.Name = "btnEngageZprobe";
            this.btnEngageZprobe.Size = new System.Drawing.Size(94, 23);
            this.btnEngageZprobe.TabIndex = 13;
            this.btnEngageZprobe.Text = "Engage Z probe";
            this.toolTip3DprinterTool.SetToolTip(this.btnEngageZprobe, "Engage the Z-Probe ");
            this.btnEngageZprobe.UseVisualStyleBackColor = true;
            this.btnEngageZprobe.Click += new System.EventHandler(this.btnEngageZprobeScanSurface_Click);
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
            this.lblStepperDriverPulley.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStepperDriverPulley.Controls.Add(this.btnShowCommunication);
            this.lblStepperDriverPulley.Controls.Add(this.cmbBxComPort);
            this.lblStepperDriverPulley.Controls.Add(this.cmbBxBaud);
            this.lblStepperDriverPulley.Controls.Add(this.btnConnect);
            this.lblStepperDriverPulley.Location = new System.Drawing.Point(12, 12);
            this.lblStepperDriverPulley.Name = "lblStepperDriverPulley";
            this.lblStepperDriverPulley.Size = new System.Drawing.Size(374, 50);
            this.lblStepperDriverPulley.TabIndex = 1;
            this.lblStepperDriverPulley.TabStop = false;
            this.lblStepperDriverPulley.Text = "Communication";
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
            // chartTemperature
            // 
            this.chartTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Title = "Secunds";
            chartArea1.AxisY.Title = "Temp";
            chartArea1.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend1);
            this.chartTemperature.Location = new System.Drawing.Point(902, 413);
            this.chartTemperature.Name = "chartTemperature";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Extruder";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.LightCoral;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "SetExtruder";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Bed";
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.LightBlue;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "SetBed";
            this.chartTemperature.Series.Add(series1);
            this.chartTemperature.Series.Add(series2);
            this.chartTemperature.Series.Add(series3);
            this.chartTemperature.Series.Add(series4);
            this.chartTemperature.Size = new System.Drawing.Size(478, 331);
            this.chartTemperature.TabIndex = 21;
            this.chartTemperature.Text = "chart1";
            this.chartTemperature.Visible = false;
            // 
            // btnEmergency
            // 
            this.btnEmergency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmergency.Location = new System.Drawing.Point(1131, 3);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(96, 96);
            this.btnEmergency.TabIndex = 22;
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Visible = false;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // btnFirmware
            // 
            this.btnFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirmware.Location = new System.Drawing.Point(1003, 4);
            this.btnFirmware.Name = "btnFirmware";
            this.btnFirmware.Size = new System.Drawing.Size(122, 96);
            this.btnFirmware.TabIndex = 23;
            this.btnFirmware.Text = "Firmware and Arduino IDE";
            this.btnFirmware.UseVisualStyleBackColor = true;
            this.btnFirmware.Click += new System.EventHandler(this.btnFirmware_Click);
            // 
            // btnPayPal
            // 
            this.btnPayPal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayPal.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Donate;
            this.btnPayPal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayPal.Location = new System.Drawing.Point(1233, 3);
            this.btnPayPal.Name = "btnPayPal";
            this.btnPayPal.Size = new System.Drawing.Size(147, 96);
            this.btnPayPal.TabIndex = 17;
            this.btnPayPal.UseVisualStyleBackColor = true;
            this.btnPayPal.Click += new System.EventHandler(this.btnPayPal_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Setting;
            this.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetup.Location = new System.Drawing.Point(392, 26);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(41, 32);
            this.btnSetup.TabIndex = 22;
            this.btnSetup.Text = " ";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // FrmMarlin3DprinterTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.btnPayPal);
            this.Controls.Add(this.btnFirmware);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.tabControl3DprinterTool);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.grpBxNavigation);
            this.Controls.Add(this.lblStepperDriverPulley);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1400, 800);
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
            this.tabPageConfigurationBed.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grpBxAdjusters.ResumeLayout(false);
            this.grpPosition.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPageConfigurateZprobe.ResumeLayout(false);
            this.grpBxZprobeHeight.ResumeLayout(false);
            this.grpBxZprobeHeight.PerformLayout();
            this.grpZprobeConfigMax.ResumeLayout(false);
            this.grpZprobeConfigMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaxTravel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrZmaxTravel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.grpBxEngageZprobe.ResumeLayout(false);
            this.grpBxEngageZprobe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpBxTestZprobe.ResumeLayout(false);
            this.grpBxTestZprobe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbM48Responce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnM48Repetitions)).EndInit();
            this.tabPageBedLevel.ResumeLayout(false);
            this.grpAutoBedLevel.ResumeLayout(false);
            this.grpAutoBedLevel.PerformLayout();
            this.panelAdjust3.ResumeLayout(false);
            this.panelAdjust3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn3)).EndInit();
            this.panelAdjust2.ResumeLayout(false);
            this.panelAdjust2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn2)).EndInit();
            this.panelAdjust4.ResumeLayout(false);
            this.panelAdjust4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn4)).EndInit();
            this.panelAdjust1.ResumeLayout(false);
            this.panelAdjust1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperLeftAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperRightAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerRightAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerLeftAdjuster)).EndInit();
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
            this.grpBxCalculate.ResumeLayout(false);
            this.grpBxCalculate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFirmware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMeassure)).EndInit();
            this.grpBxTestExtrude.ResumeLayout(false);
            this.grpBxTestExtrude.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnExtrude)).EndInit();
            this.tabPageZMaintenance.ResumeLayout(false);
            this.grpBxZMaintenance.ResumeLayout(false);
            this.grpBxZMaintenance.PerformLayout();
            this.grpBxZmaintMin.ResumeLayout(false);
            this.grpBxZmaintMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMin)).EndInit();
            this.grpBxZmaintMax.ResumeLayout(false);
            this.grpBxZmaintMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZmaintenanceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnZmaintenanceRepetitions)).EndInit();
            this.tabPageCalculations.ResumeLayout(false);
            this.grpBxFeedRate.ResumeLayout(false);
            this.grpBxFeedRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFeedRateMMperSecund)).EndInit();
            this.grpBxExtruderCalculation.ResumeLayout(false);
            this.grpBxExtruderCalculation.PerformLayout();
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
            this.tabPageStlViewer.ResumeLayout(false);
            this.grpBxInstallingStlThumbnailServer.ResumeLayout(false);
            this.grpBxInstallingStlThumbnailServer.PerformLayout();
            this.grpBxAssociateStlViewer.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.grpBxServe32.ResumeLayout(false);
            this.grpBxServe32.PerformLayout();
            this.grpBxServe64.ResumeLayout(false);
            this.grpBxServe64.PerformLayout();
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
        private GroupBox grpBxCalculate;
        private Button btnExtruderCalibrationCalculate;
        private Button btnM92Extruder;
        private Label lblFirmware;
        private NumericUpDown numUpDnFirmware;
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
        private GroupBox grpPosition;
        private Panel panel1;
        private Button btnSaveLowerLeftAdjuster;
        private ToolTip toolTip3DprinterTool;
        private GroupBox grpBxNavigation;
        private Button grpBxBed;
        private Button btnHomeY;
        private Button btnHomeX;
        private Button btnMoveLowerLeftAdjuster;
        private Button btnSaveUpperLeftAdjuster;
        private Button btnSaveUpperRightAdjuster;
        private Button btnSaveLowerRightAdjuster;
        private Button btnMoveUpperLeftAdjuster;
        private Button btnMoveUpperRightAdjuster;
        private Button btnMoveLowerRightAdjuster;
        private Button btnMoveSafeHome;
        private Button btnSaveSafeHome;
        private Button btnSaveUpperRightCorner;
        private Button btnSaveUpperLeftCorner;
        private Button btnSaveLowerLeftCorner;
        private Button btnSaveLowerRightCorner;
        private Button btnMoveLowerRightCorner;
        private Button btnMoveLowerLeftCorner;
        private Button btnMoveUpperRightCorner;
        private Button btnMoveUpperLeftCorner;
        private TabPage tabPageBedLevel;
        private Panel panelAdjust3;
        private PictureBox picBxTurn3;
        private Label lblAdjustValue3;
        private Label lblTurn3;
        private Panel panelAdjust2;
        private PictureBox picBxTurn2;
        private Label lblAdjustValue2;
        private Label lblTurn2;
        private Panel panelAdjust4;
        private PictureBox picBxTurn4;
        private Label lblAdjustValue4;
        private Label lblTurn4;
        private Panel panelAdjust1;
        private PictureBox picBxTurn1;
        private Label lblAdjustValue1;
        private Label lblTurn1;
        private Panel panel2;
        private CheckedListBox chkListBxAdjustment;
        private PictureBox picBxUpperLeftAdjuster;
        private PictureBox picBxUpperRightAdjuster;
        private PictureBox picBxLowerRightAdjuster;
        private PictureBox picBxLowerLeftAdjuster;
        private GroupBox grpBxTestZprobe;
        private Label lblM48Repetition;
        private Button btnM48Repetition;
        private NumericUpDown numUpDnM48Repetitions;
        private Button btnProbeTheBed;
        private Button btnPayPal;
        private TabPage tabPageConfigurateZprobe;
        private GroupBox grpBxEngageZprobe;
        private GroupBox groupBox1;
        private Button btnCreateExampleForZprobeServoEngage;
        private Button btnCreateExampleForZprobeSledEngage;
        private Button btnCreateExampleForZprobePositionEngage;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnCreateExampleForZprobeServoRelease;
        private Button btnCreateExampleForZprobeSledRelease;
        private Button btnCreateExampleForZprobePositionRelease;
        private TextBox txtBxGcodeAssistZprobeRelease;
        private Button btnTestZprobeRelease;
        private Button btnTestZprobeReleaseSave;
        private Button btnTestZprobeEngage;
        private Button btnTestZprobeEngageSave;
        private GroupBox grpAutoBedLevel;
        private Button btnAutoBedLevel;
        private TextBox txtBxAutoBedLevelResponce;
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
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private VerticalJogControl verticalJogControlZprobeHeight;
        private KompassControll kompassControllConfigBed;
        private GroupBox groupBox5;
        private TextBox txtBxCurrentPositionYConfigBed;
        private Label lblCurrentPositionYConfigBed;
        private TextBox txtBxCurrentPositionXConfigBed;
        private Label lblCurrentPositionXConfigBed;
        private GroupBox grpBxZmaintMin;
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
        private LedBulb ledXmin;
        private LedBulb ledZmax;
        private LedBulb ledZmin;
        private LedBulb ledYmax;
        private LedBulb ledYmin;
        private LedBulb ledXmax;
        private Button btnCalculateExtruderPid;
        private Button btnZprobeHeightNext;
        private Button btnStartZprobeHeight;
        private Button btnZpromeFirmwareUpdate;
        private Label lblCalculatedZProbeOffset;
        private TextBox txtBxCalculatedZProbeOffset;
        private TextBox txtBxJogControlZprobeHeightHelp;
        private Chart chartTemperature;
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
        private GroupBox grpBxZprobeHeight;
        private Button btnEmergency;
        private Button btnFirmware;
        private FastColoredTextBox fctbM48Responce;
        private Button btnMeshLevel;
        private Button btnTransferBedPidKp;
        private Button btnUpdateBedPid;
        private Label lblKdExtruder;
        private Label lblKiExtruder;
        private Label lblKpExtruder;
        private Button btnUpdateExtruderPid;
        private Button btnTransferExtruderPidKp;
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
        private Button btnZpromeEepromUpdate;
        private GroupBox groupBox6;
        private RadioButton rdoBn3pointAdjusterLeft;
        private RadioButton rdoBn3pointAdjusterRight;
        private RadioButton rdoBn4pointAdjuster;
        private RadioButton rdoBn3pointAdjusterFront;
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
        private Button btnExtruderUpdateStepsPerMMinFirmware;
        private Button btnExtruderUpdateStepsPerMMinEEPROM;
        private Button btnExtruderOldFirmware;
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
        private TabPage tabPageStlViewer;
        private GroupBox grpBxInstallingStlThumbnailServer;
        private CheckBox chkBx32BitOS;
        private Button btnUnInstallStlServer;
        private Button btnInstallStlServer;
        private GroupBox grpBxAssociateStlViewer;
        private Button btnAssociateStlViewer;
        private Button btnRestartWindowsFileExplorer;
        private Button btnTroubleShootStl;
        private GroupBox grpBxServe32;
        private Label lblRegistered32;
        private Label lblServer32;
        private LedBulb ledRegister32;
        private LedBulb ledServer32;
        private GroupBox grpBxServe64;
        private Label lblRegistered64;
        private Label lblServer64;
        private GroupBox groupBox10;
        private LedBulb ledServer64;
        private LedBulb ledRegister64;
        private Button btnResetAndCleanExistingThumbnails;
        private Button btnColorStl;
        private GroupBox groupBox11;
        private TextBox textBoxAssociations;
        private Label label8;
        private TextBox textBoxAssemblyPath;
        private Label label9;
        private TextBox textBoxServerSecurity;
        private TextBox textBoxServerCLSID;
        private TextBox textBoxServerType;
        private TextBox textBoxServerName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
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
    }
}

