using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FastColoredTextBoxNS;
using MarlinComunicationHelper;

namespace Marlin3DprinterTool
{
    partial class Frm3DprinterTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm3DprinterTool));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl3DprinterTool = new System.Windows.Forms.TabControl();
            this.tabPageEndstop = new System.Windows.Forms.TabPage();
            this.grpBxZ = new System.Windows.Forms.GroupBox();
            this.lblZmax = new System.Windows.Forms.Label();
            this.lblZmin = new System.Windows.Forms.Label();
            this.grpBxY = new System.Windows.Forms.GroupBox();
            this.lblYmax = new System.Windows.Forms.Label();
            this.lblYmin = new System.Windows.Forms.Label();
            this.grpBxX = new System.Windows.Forms.GroupBox();
            this.lblXmax = new System.Windows.Forms.Label();
            this.lblXmin = new System.Windows.Forms.Label();
            this.tabPageConfigurationBed = new System.Windows.Forms.TabPage();
            this.grpPosition = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBxCurrentPositionYConfigBed = new System.Windows.Forms.TextBox();
            this.lblCurrentPositionYConfigBed = new System.Windows.Forms.Label();
            this.txtBxCurrentPositionXConfigBed = new System.Windows.Forms.TextBox();
            this.lblCurrentPositionXConfigBed = new System.Windows.Forms.Label();
            this.grpBxAdjusters = new System.Windows.Forms.GroupBox();
            this.chkListBxAdjustment = new System.Windows.Forms.CheckedListBox();
            this.btnSaveAdjustment = new System.Windows.Forms.Button();
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
            this.fastColoredTextBoxM48Responce = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblM48Repetition = new System.Windows.Forms.Label();
            this.btnM48Repetition = new System.Windows.Forms.Button();
            this.numUpDnM48Repetitions = new System.Windows.Forms.NumericUpDown();
            this.tabPageBedLevel = new System.Windows.Forms.TabPage();
            this.grpAutoBedLevel = new System.Windows.Forms.GroupBox();
            this.btnAutoBedLevel = new System.Windows.Forms.Button();
            this.txtBxAutoBedLevelResponce = new System.Windows.Forms.TextBox();
            this.picBxUpperLeftAdjuster = new System.Windows.Forms.PictureBox();
            this.picBxUpperRightAdjuster = new System.Windows.Forms.PictureBox();
            this.picBxLowerRightAdjuster = new System.Windows.Forms.PictureBox();
            this.picBxLowerLeftAdjuster = new System.Windows.Forms.PictureBox();
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
            this.tabPageScanSurface = new System.Windows.Forms.TabPage();
            this.btnMeshLevel = new System.Windows.Forms.Button();
            this.numUpDownNumberOfRepetitions = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfRepetitions = new System.Windows.Forms.Label();
            this.nChartControlSurface = new Nevron.Chart.WinForm.NChartControl();
            this.lblYpoints = new System.Windows.Forms.Label();
            this.lblXpoints = new System.Windows.Forms.Label();
            this.btnScanSurface = new System.Windows.Forms.Button();
            this.numUpDownYpoints = new System.Windows.Forms.NumericUpDown();
            this.numUpDownXpoints = new System.Windows.Forms.NumericUpDown();
            this.tabPagePID = new System.Windows.Forms.TabPage();
            this.txtBxPIDresponce = new System.Windows.Forms.TextBox();
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
            this.btnM92 = new System.Windows.Forms.Button();
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
            this.grpBxNavigation = new System.Windows.Forms.GroupBox();
            this.btnRetractZprobe = new System.Windows.Forms.Button();
            this.btnHomeZ = new System.Windows.Forms.Button();
            this.btnHomeY = new System.Windows.Forms.Button();
            this.btnHomeX = new System.Windows.Forms.Button();
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
            this.timerTemperature = new System.Windows.Forms.Timer(this.components);
            this.btnPayPal = new System.Windows.Forms.Button();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnFirmware = new System.Windows.Forms.Button();
            this.btnTransferExtruderPidKi = new System.Windows.Forms.Button();
            this.btnTransferExtruderPidKd = new System.Windows.Forms.Button();
            this.btnTransferBedPidKi = new System.Windows.Forms.Button();
            this.btnTransferBedPidKd = new System.Windows.Forms.Button();
            this.btnM500SaveEeprom = new System.Windows.Forms.Button();
            this.btnM501ReadEeprom = new System.Windows.Forms.Button();
            this.ledZmax = new MarlinComunicationHelper.LedBulb();
            this.ledZmin = new MarlinComunicationHelper.LedBulb();
            this.ledYmax = new MarlinComunicationHelper.LedBulb();
            this.ledYmin = new MarlinComunicationHelper.LedBulb();
            this.ledXmax = new MarlinComunicationHelper.LedBulb();
            this.ledXmin = new MarlinComunicationHelper.LedBulb();
            this.kompassControllConfigBed = new MarlinComunicationHelper.KompassControll();
            this.verticalJogControlZprobeHeight = new MarlinComunicationHelper.VerticalJogControl();
            this.btnZpromeEepromUpdate = new System.Windows.Forms.Button();
            this.tabControl3DprinterTool.SuspendLayout();
            this.tabPageEndstop.SuspendLayout();
            this.grpBxZ.SuspendLayout();
            this.grpBxY.SuspendLayout();
            this.grpBxX.SuspendLayout();
            this.tabPageConfigurationBed.SuspendLayout();
            this.grpPosition.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpBxAdjusters.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxM48Responce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnM48Repetitions)).BeginInit();
            this.tabPageBedLevel.SuspendLayout();
            this.grpAutoBedLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperLeftAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperRightAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerRightAdjuster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerLeftAdjuster)).BeginInit();
            this.panelAdjust3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn3)).BeginInit();
            this.panelAdjust2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn2)).BeginInit();
            this.panelAdjust4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn4)).BeginInit();
            this.panelAdjust1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTurn1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPageScanSurface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumberOfRepetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYpoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownXpoints)).BeginInit();
            this.tabPagePID.SuspendLayout();
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
            this.tabControl3DprinterTool.Location = new System.Drawing.Point(12, 84);
            this.tabControl3DprinterTool.Name = "tabControl3DprinterTool";
            this.tabControl3DprinterTool.SelectedIndex = 0;
            this.tabControl3DprinterTool.Size = new System.Drawing.Size(812, 672);
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
            this.tabPageEndstop.Size = new System.Drawing.Size(804, 646);
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
            this.tabPageConfigurationBed.Controls.Add(this.grpPosition);
            this.tabPageConfigurationBed.Controls.Add(this.richTextBox2);
            this.tabPageConfigurationBed.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfigurationBed.Name = "tabPageConfigurationBed";
            this.tabPageConfigurationBed.Size = new System.Drawing.Size(804, 646);
            this.tabPageConfigurationBed.TabIndex = 4;
            this.tabPageConfigurationBed.Text = "Configuration Bed";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageConfigurationBed, "Navigate and save positions for other features to use");
            this.tabPageConfigurationBed.ToolTipText = "Configuration of Bed";
            this.tabPageConfigurationBed.UseVisualStyleBackColor = true;
            // 
            // grpPosition
            // 
            this.grpPosition.Controls.Add(this.groupBox5);
            this.grpPosition.Controls.Add(this.grpBxAdjusters);
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
            this.groupBox5.Location = new System.Drawing.Point(82, 334);
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
            // grpBxAdjusters
            // 
            this.grpBxAdjusters.Controls.Add(this.chkListBxAdjustment);
            this.grpBxAdjusters.Controls.Add(this.btnSaveAdjustment);
            this.grpBxAdjusters.Location = new System.Drawing.Point(387, 228);
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
            // 
            // btnSaveAdjustment
            // 
            this.btnSaveAdjustment.Location = new System.Drawing.Point(20, 71);
            this.btnSaveAdjustment.Name = "btnSaveAdjustment";
            this.btnSaveAdjustment.Size = new System.Drawing.Size(55, 23);
            this.btnSaveAdjustment.TabIndex = 19;
            this.btnSaveAdjustment.Text = "Save";
            this.toolTip3DprinterTool.SetToolTip(this.btnSaveAdjustment, "Save the current position as \"Upper Right Adjustment\"");
            this.btnSaveAdjustment.UseVisualStyleBackColor = true;
            this.btnSaveAdjustment.Click += new System.EventHandler(this.btnSaveAdjustment_Click);
            // 
            // btnMoveUpperLeftAdjuster
            // 
            this.btnMoveUpperLeftAdjuster.Location = new System.Drawing.Point(58, 98);
            this.btnMoveUpperLeftAdjuster.Name = "btnMoveUpperLeftAdjuster";
            this.btnMoveUpperLeftAdjuster.Size = new System.Drawing.Size(16, 23);
            this.btnMoveUpperLeftAdjuster.TabIndex = 8;
            this.btnMoveUpperLeftAdjuster.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveUpperLeftAdjuster, "Move to \"Lower Left Adjustment\"");
            this.btnMoveUpperLeftAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveUpperLeftAdjuster.Click += new System.EventHandler(this.btnMoveUpperLeftAdjuster_Click);
            // 
            // btnMoveUpperRightAdjuster
            // 
            this.btnMoveUpperRightAdjuster.Location = new System.Drawing.Point(387, 98);
            this.btnMoveUpperRightAdjuster.Name = "btnMoveUpperRightAdjuster";
            this.btnMoveUpperRightAdjuster.Size = new System.Drawing.Size(16, 23);
            this.btnMoveUpperRightAdjuster.TabIndex = 7;
            this.btnMoveUpperRightAdjuster.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveUpperRightAdjuster, "Move to \"Lower Left Adjustment\"");
            this.btnMoveUpperRightAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveUpperRightAdjuster.Click += new System.EventHandler(this.btnMoveUpperRightAdjuster_Click);
            // 
            // btnMoveLowerRightAdjuster
            // 
            this.btnMoveLowerRightAdjuster.Location = new System.Drawing.Point(387, 199);
            this.btnMoveLowerRightAdjuster.Name = "btnMoveLowerRightAdjuster";
            this.btnMoveLowerRightAdjuster.Size = new System.Drawing.Size(16, 23);
            this.btnMoveLowerRightAdjuster.TabIndex = 6;
            this.btnMoveLowerRightAdjuster.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveLowerRightAdjuster, "Move to \"Lower Left Adjustment\"");
            this.btnMoveLowerRightAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveLowerRightAdjuster.Click += new System.EventHandler(this.btnMoveLowerRightAdjuster_Click);
            // 
            // btnMoveLowerLeftAdjuster
            // 
            this.btnMoveLowerLeftAdjuster.Location = new System.Drawing.Point(60, 199);
            this.btnMoveLowerLeftAdjuster.Name = "btnMoveLowerLeftAdjuster";
            this.btnMoveLowerLeftAdjuster.Size = new System.Drawing.Size(16, 23);
            this.btnMoveLowerLeftAdjuster.TabIndex = 5;
            this.btnMoveLowerLeftAdjuster.Text = "X";
            this.toolTip3DprinterTool.SetToolTip(this.btnMoveLowerLeftAdjuster, "Move to \"Lower Left Adjustment\"");
            this.btnMoveLowerLeftAdjuster.UseVisualStyleBackColor = true;
            this.btnMoveLowerLeftAdjuster.Click += new System.EventHandler(this.btnMoveLowerLeftAdjuster_Click);
            // 
            // btnSaveUpperLeftAdjuster
            // 
            this.btnSaveUpperLeftAdjuster.Location = new System.Drawing.Point(13, 98);
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
            this.btnSaveUpperRightAdjuster.Location = new System.Drawing.Point(407, 98);
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
            this.btnSaveLowerRightAdjuster.Location = new System.Drawing.Point(407, 199);
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
            this.btnSaveLowerLeftAdjuster.Location = new System.Drawing.Point(13, 199);
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
            this.richTextBox2.Size = new System.Drawing.Size(246, 356);
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
            this.tabPageConfigurateZprobe.Size = new System.Drawing.Size(804, 646);
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
            this.grpBxTestZprobe.Controls.Add(this.fastColoredTextBoxM48Responce);
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
            // fastColoredTextBoxM48Responce
            // 
            this.fastColoredTextBoxM48Responce.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBoxM48Responce.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBoxM48Responce.BackBrush = null;
            this.fastColoredTextBoxM48Responce.CharHeight = 14;
            this.fastColoredTextBoxM48Responce.CharWidth = 8;
            this.fastColoredTextBoxM48Responce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxM48Responce.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxM48Responce.IsReplaceMode = false;
            this.fastColoredTextBoxM48Responce.Location = new System.Drawing.Point(6, 44);
            this.fastColoredTextBoxM48Responce.Name = "fastColoredTextBoxM48Responce";
            this.fastColoredTextBoxM48Responce.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxM48Responce.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxM48Responce.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxM48Responce.ServiceColors")));
            this.fastColoredTextBoxM48Responce.ShowLineNumbers = false;
            this.fastColoredTextBoxM48Responce.Size = new System.Drawing.Size(361, 150);
            this.fastColoredTextBoxM48Responce.TabIndex = 15;
            this.fastColoredTextBoxM48Responce.Zoom = 100;
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
            this.tabPageBedLevel.Controls.Add(this.picBxUpperLeftAdjuster);
            this.tabPageBedLevel.Controls.Add(this.picBxUpperRightAdjuster);
            this.tabPageBedLevel.Controls.Add(this.picBxLowerRightAdjuster);
            this.tabPageBedLevel.Controls.Add(this.picBxLowerLeftAdjuster);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust3);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust2);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust4);
            this.tabPageBedLevel.Controls.Add(this.panelAdjust1);
            this.tabPageBedLevel.Controls.Add(this.panel2);
            this.tabPageBedLevel.Location = new System.Drawing.Point(4, 22);
            this.tabPageBedLevel.Name = "tabPageBedLevel";
            this.tabPageBedLevel.Size = new System.Drawing.Size(804, 646);
            this.tabPageBedLevel.TabIndex = 5;
            this.tabPageBedLevel.Text = "Bed Level";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageBedLevel, "Help for level the building surface");
            this.tabPageBedLevel.UseVisualStyleBackColor = true;
            // 
            // grpAutoBedLevel
            // 
            this.grpAutoBedLevel.Controls.Add(this.btnAutoBedLevel);
            this.grpAutoBedLevel.Controls.Add(this.txtBxAutoBedLevelResponce);
            this.grpAutoBedLevel.Location = new System.Drawing.Point(22, 350);
            this.grpAutoBedLevel.Name = "grpAutoBedLevel";
            this.grpAutoBedLevel.Size = new System.Drawing.Size(596, 299);
            this.grpAutoBedLevel.TabIndex = 49;
            this.grpAutoBedLevel.TabStop = false;
            this.grpAutoBedLevel.Text = "Auto Bed Level";
            // 
            // btnAutoBedLevel
            // 
            this.btnAutoBedLevel.Location = new System.Drawing.Point(441, 19);
            this.btnAutoBedLevel.Name = "btnAutoBedLevel";
            this.btnAutoBedLevel.Size = new System.Drawing.Size(149, 35);
            this.btnAutoBedLevel.TabIndex = 1;
            this.btnAutoBedLevel.Text = "Auto Bed Level (G29)";
            this.btnAutoBedLevel.UseVisualStyleBackColor = true;
            this.btnAutoBedLevel.Click += new System.EventHandler(this.btnAutoBedLevel_Click);
            // 
            // txtBxAutoBedLevelResponce
            // 
            this.txtBxAutoBedLevelResponce.Location = new System.Drawing.Point(6, 19);
            this.txtBxAutoBedLevelResponce.Multiline = true;
            this.txtBxAutoBedLevelResponce.Name = "txtBxAutoBedLevelResponce";
            this.txtBxAutoBedLevelResponce.Size = new System.Drawing.Size(429, 274);
            this.txtBxAutoBedLevelResponce.TabIndex = 0;
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
            // tabPageScanSurface
            // 
            this.tabPageScanSurface.Controls.Add(this.btnMeshLevel);
            this.tabPageScanSurface.Controls.Add(this.numUpDownNumberOfRepetitions);
            this.tabPageScanSurface.Controls.Add(this.lblNumberOfRepetitions);
            this.tabPageScanSurface.Controls.Add(this.nChartControlSurface);
            this.tabPageScanSurface.Controls.Add(this.lblYpoints);
            this.tabPageScanSurface.Controls.Add(this.lblXpoints);
            this.tabPageScanSurface.Controls.Add(this.btnScanSurface);
            this.tabPageScanSurface.Controls.Add(this.numUpDownYpoints);
            this.tabPageScanSurface.Controls.Add(this.numUpDownXpoints);
            this.tabPageScanSurface.Location = new System.Drawing.Point(4, 22);
            this.tabPageScanSurface.Name = "tabPageScanSurface";
            this.tabPageScanSurface.Size = new System.Drawing.Size(804, 646);
            this.tabPageScanSurface.TabIndex = 9;
            this.tabPageScanSurface.Text = "Scan buildsurface";
            this.toolTip3DprinterTool.SetToolTip(this.tabPageScanSurface, "Scan the building surface");
            this.tabPageScanSurface.UseVisualStyleBackColor = true;
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
            // nChartControlSurface
            // 
            this.nChartControlSurface.AutoRefresh = false;
            this.nChartControlSurface.BackColor = System.Drawing.SystemColors.Control;
            this.nChartControlSurface.InputKeys = new System.Windows.Forms.Keys[0];
            this.nChartControlSurface.Location = new System.Drawing.Point(6, 53);
            this.nChartControlSurface.Name = "nChartControlSurface";
            this.nChartControlSurface.Size = new System.Drawing.Size(784, 574);
            this.nChartControlSurface.State = ((Nevron.Chart.WinForm.NState)(resources.GetObject("nChartControlSurface.State")));
            this.nChartControlSurface.TabIndex = 17;
            this.nChartControlSurface.Text = "Surface Scan";
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
            this.tabPagePID.Controls.Add(this.txtBxPIDresponce);
            this.tabPagePID.Controls.Add(this.grpBxHeatbedPID);
            this.tabPagePID.Controls.Add(this.grpBxExtruderPID);
            this.tabPagePID.Location = new System.Drawing.Point(4, 22);
            this.tabPagePID.Name = "tabPagePID";
            this.tabPagePID.Size = new System.Drawing.Size(804, 646);
            this.tabPagePID.TabIndex = 10;
            this.tabPagePID.Text = "PID";
            this.tabPagePID.UseVisualStyleBackColor = true;
            // 
            // txtBxPIDresponce
            // 
            this.txtBxPIDresponce.Location = new System.Drawing.Point(17, 433);
            this.txtBxPIDresponce.Multiline = true;
            this.txtBxPIDresponce.Name = "txtBxPIDresponce";
            this.txtBxPIDresponce.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBxPIDresponce.Size = new System.Drawing.Size(575, 196);
            this.txtBxPIDresponce.TabIndex = 6;
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
            this.groupBox9.Controls.Add(this.btnTransferBedPidKd);
            this.groupBox9.Controls.Add(this.btnTransferBedPidKi);
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
            this.grpBxPidExtruder.Controls.Add(this.btnTransferExtruderPidKd);
            this.grpBxPidExtruder.Controls.Add(this.btnTransferExtruderPidKi);
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
            this.tabPageExtruderCalibration.Size = new System.Drawing.Size(804, 646);
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
            this.groupBox2.Size = new System.Drawing.Size(999, 174);
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
            this.grpBxCalculate.Controls.Add(this.btnM92);
            this.grpBxCalculate.Controls.Add(this.lblFirmware);
            this.grpBxCalculate.Controls.Add(this.numUpDnFirmware);
            this.grpBxCalculate.Controls.Add(this.numUpDnMeassure);
            this.grpBxCalculate.Controls.Add(this.lblMeassure);
            this.grpBxCalculate.Location = new System.Drawing.Point(7, 252);
            this.grpBxCalculate.Name = "grpBxCalculate";
            this.grpBxCalculate.Size = new System.Drawing.Size(999, 83);
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
            // btnM92
            // 
            this.btnM92.Location = new System.Drawing.Point(335, 24);
            this.btnM92.Name = "btnM92";
            this.btnM92.Size = new System.Drawing.Size(118, 46);
            this.btnM92.TabIndex = 8;
            this.btnM92.Text = "Update in EEPROM";
            this.btnM92.UseVisualStyleBackColor = true;
            this.btnM92.Click += new System.EventHandler(this.btnM92_Click);
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
            this.grpBxTestExtrude.Size = new System.Drawing.Size(999, 53);
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
            this.tabPageZMaintenance.Size = new System.Drawing.Size(804, 646);
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
            // grpBxNavigation
            // 
            this.grpBxNavigation.Controls.Add(this.btnM501ReadEeprom);
            this.grpBxNavigation.Controls.Add(this.btnM500SaveEeprom);
            this.grpBxNavigation.Controls.Add(this.btnRetractZprobe);
            this.grpBxNavigation.Controls.Add(this.kompassControllConfigBed);
            this.grpBxNavigation.Controls.Add(this.btnHomeZ);
            this.grpBxNavigation.Controls.Add(this.btnHomeY);
            this.grpBxNavigation.Controls.Add(this.btnHomeX);
            this.grpBxNavigation.Controls.Add(this.verticalJogControlZprobeHeight);
            this.grpBxNavigation.Controls.Add(this.btnEngageZprobe);
            this.grpBxNavigation.Location = new System.Drawing.Point(830, 106);
            this.grpBxNavigation.Name = "grpBxNavigation";
            this.grpBxNavigation.Size = new System.Drawing.Size(484, 301);
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
            // btnHomeZ
            // 
            this.btnHomeZ.Location = new System.Drawing.Point(195, 272);
            this.btnHomeZ.Name = "btnHomeZ";
            this.btnHomeZ.Size = new System.Drawing.Size(57, 23);
            this.btnHomeZ.TabIndex = 2;
            this.btnHomeZ.Text = "Home Z";
            this.toolTip3DprinterTool.SetToolTip(this.btnHomeZ, "Home Z");
            this.btnHomeZ.UseVisualStyleBackColor = true;
            this.btnHomeZ.Click += new System.EventHandler(this.btnHomeZ_Click);
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
            this.lblStepperDriverPulley.Size = new System.Drawing.Size(384, 66);
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
            // timerTemperature
            // 
            this.timerTemperature.Interval = 1000;
            this.timerTemperature.Tick += new System.EventHandler(this.timerTemperature_Tick);
            // 
            // btnPayPal
            // 
            this.btnPayPal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayPal.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Donate;
            this.btnPayPal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayPal.Location = new System.Drawing.Point(1167, 3);
            this.btnPayPal.Name = "btnPayPal";
            this.btnPayPal.Size = new System.Drawing.Size(147, 96);
            this.btnPayPal.TabIndex = 17;
            this.btnPayPal.UseVisualStyleBackColor = true;
            this.btnPayPal.Click += new System.EventHandler(this.btnPayPal_Click);
            // 
            // chartTemperature
            // 
            chartArea2.AxisX.Title = "Secunds";
            chartArea2.AxisY.Title = "Temp";
            chartArea2.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend2);
            this.chartTemperature.Location = new System.Drawing.Point(830, 414);
            this.chartTemperature.Name = "chartTemperature";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Extruder";
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.LightCoral;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "SetExtruder";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Blue;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Bed";
            series8.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.LightBlue;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "SetBed";
            this.chartTemperature.Series.Add(series5);
            this.chartTemperature.Series.Add(series6);
            this.chartTemperature.Series.Add(series7);
            this.chartTemperature.Series.Add(series8);
            this.chartTemperature.Size = new System.Drawing.Size(484, 338);
            this.chartTemperature.TabIndex = 21;
            this.chartTemperature.Text = "chart1";
            this.chartTemperature.Visible = false;
            // 
            // btnEmergency
            // 
            this.btnEmergency.Location = new System.Drawing.Point(1065, 3);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Size = new System.Drawing.Size(96, 96);
            this.btnEmergency.TabIndex = 22;
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Visible = false;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // btnFirmware
            // 
            this.btnFirmware.Location = new System.Drawing.Point(937, 3);
            this.btnFirmware.Name = "btnFirmware";
            this.btnFirmware.Size = new System.Drawing.Size(122, 96);
            this.btnFirmware.TabIndex = 23;
            this.btnFirmware.Text = "Firmware and Arduino IDE";
            this.btnFirmware.UseVisualStyleBackColor = true;
            this.btnFirmware.Click += new System.EventHandler(this.btnFirmware_Click);
            // 
            // btnTransferExtruderPidKi
            // 
            this.btnTransferExtruderPidKi.Location = new System.Drawing.Point(81, 41);
            this.btnTransferExtruderPidKi.Name = "btnTransferExtruderPidKi";
            this.btnTransferExtruderPidKi.Size = new System.Drawing.Size(148, 23);
            this.btnTransferExtruderPidKi.TabIndex = 17;
            this.btnTransferExtruderPidKi.Text = "Transfer To Firmware";
            this.btnTransferExtruderPidKi.UseVisualStyleBackColor = true;
            this.btnTransferExtruderPidKi.Click += new System.EventHandler(this.btnTransferExtruderPidKi_Click);
            // 
            // btnTransferExtruderPidKd
            // 
            this.btnTransferExtruderPidKd.Location = new System.Drawing.Point(81, 67);
            this.btnTransferExtruderPidKd.Name = "btnTransferExtruderPidKd";
            this.btnTransferExtruderPidKd.Size = new System.Drawing.Size(148, 23);
            this.btnTransferExtruderPidKd.TabIndex = 18;
            this.btnTransferExtruderPidKd.Text = "Transfer To Firmware";
            this.btnTransferExtruderPidKd.UseVisualStyleBackColor = true;
            this.btnTransferExtruderPidKd.Click += new System.EventHandler(this.btnTransferExtruderPidKd_Click);
            // 
            // btnTransferBedPidKi
            // 
            this.btnTransferBedPidKi.Location = new System.Drawing.Point(78, 41);
            this.btnTransferBedPidKi.Name = "btnTransferBedPidKi";
            this.btnTransferBedPidKi.Size = new System.Drawing.Size(148, 23);
            this.btnTransferBedPidKi.TabIndex = 21;
            this.btnTransferBedPidKi.Text = "Transfer To Firmware";
            this.btnTransferBedPidKi.UseVisualStyleBackColor = true;
            this.btnTransferBedPidKi.Click += new System.EventHandler(this.btnTransferBedPidKi_Click);
            // 
            // btnTransferBedPidKd
            // 
            this.btnTransferBedPidKd.Location = new System.Drawing.Point(78, 67);
            this.btnTransferBedPidKd.Name = "btnTransferBedPidKd";
            this.btnTransferBedPidKd.Size = new System.Drawing.Size(148, 23);
            this.btnTransferBedPidKd.TabIndex = 22;
            this.btnTransferBedPidKd.Text = "Transfer To Firmware";
            this.btnTransferBedPidKd.UseVisualStyleBackColor = true;
            this.btnTransferBedPidKd.Click += new System.EventHandler(this.btnTransferBedPidKd_Click);
            // 
            // btnM500SaveEeprom
            // 
            this.btnM500SaveEeprom.Location = new System.Drawing.Point(281, 272);
            this.btnM500SaveEeprom.Name = "btnM500SaveEeprom";
            this.btnM500SaveEeprom.Size = new System.Drawing.Size(97, 23);
            this.btnM500SaveEeprom.TabIndex = 29;
            this.btnM500SaveEeprom.Text = "Save EEPROM";
            this.toolTip3DprinterTool.SetToolTip(this.btnM500SaveEeprom, "Home Z");
            this.btnM500SaveEeprom.UseVisualStyleBackColor = true;
            this.btnM500SaveEeprom.Click += new System.EventHandler(this.btnM500SaveEeprom_Click);
            // 
            // btnM501ReadEeprom
            // 
            this.btnM501ReadEeprom.Location = new System.Drawing.Point(384, 272);
            this.btnM501ReadEeprom.Name = "btnM501ReadEeprom";
            this.btnM501ReadEeprom.Size = new System.Drawing.Size(94, 23);
            this.btnM501ReadEeprom.TabIndex = 30;
            this.btnM501ReadEeprom.Text = "Read EEPROM";
            this.toolTip3DprinterTool.SetToolTip(this.btnM501ReadEeprom, "Home Z");
            this.btnM501ReadEeprom.UseVisualStyleBackColor = true;
            this.btnM501ReadEeprom.Click += new System.EventHandler(this.btnM501ReadEeprom_Click);
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
            // Frm3DprinterTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 762);
            this.Controls.Add(this.btnPayPal);
            this.Controls.Add(this.btnFirmware);
            this.Controls.Add(this.btnEmergency);
            this.Controls.Add(this.tabControl3DprinterTool);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.grpBxNavigation);
            this.Controls.Add(this.lblStepperDriverPulley);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "Frm3DprinterTool";
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
            this.grpPosition.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpBxAdjusters.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxM48Responce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnM48Repetitions)).EndInit();
            this.tabPageBedLevel.ResumeLayout(false);
            this.grpAutoBedLevel.ResumeLayout(false);
            this.grpAutoBedLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperLeftAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUpperRightAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerRightAdjuster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLowerLeftAdjuster)).EndInit();
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
            this.tabPageScanSurface.ResumeLayout(false);
            this.tabPageScanSurface.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumberOfRepetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownYpoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownXpoints)).EndInit();
            this.tabPagePID.ResumeLayout(false);
            this.tabPagePID.PerformLayout();
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
        private Button btnM92;
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
        private Button btnHomeZ;
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
        private Button btnSaveAdjustment;
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
        private Timer timerTemperature;
        private TabPage tabPagePID;
        private GroupBox grpBxHeatbedPID;
        private GroupBox grpBxExtruderPID;
        private Nevron.Chart.WinForm.NChartControl nChartControlSurface;
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
        private TextBox txtBxPIDresponce;
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
        private FastColoredTextBox fastColoredTextBoxM48Responce;
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
        private Button btnTransferExtruderPidKd;
        private Button btnTransferExtruderPidKi;
        private Button btnTransferBedPidKd;
        private Button btnTransferBedPidKi;
        private Button btnM501ReadEeprom;
        private Button btnM500SaveEeprom;
        private Button btnZpromeEepromUpdate;
    }
}

