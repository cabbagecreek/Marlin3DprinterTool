namespace MarlinComunicationHelper
{
    partial class FrmFirmware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmware));
            this.grpBxOldFirmware = new System.Windows.Forms.GroupBox();
            this.btnEditCurrentFirmware = new System.Windows.Forms.Button();
            this.fastColoredTextBoxOldFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblFeatureValue = new System.Windows.Forms.Label();
            this.lblFeature = new System.Windows.Forms.Label();
            this.txtBxCurrentFirmwareValue = new System.Windows.Forms.TextBox();
            this.btnPassValue = new System.Windows.Forms.Button();
            this.cmbBxFirmwareFeatures = new System.Windows.Forms.ComboBox();
            this.chlBxUpdateCurrentFirmware = new System.Windows.Forms.CheckBox();
            this.btnCurrentFirmwareLocationSave = new System.Windows.Forms.Button();
            this.btnCurrentFirmwareLocationBrowse = new System.Windows.Forms.Button();
            this.btnSaveFirmwareLocation = new System.Windows.Forms.Button();
            this.btnExtruderBrowseFirmware = new System.Windows.Forms.Button();
            this.txtBxCurrentFirmwareLocation = new System.Windows.Forms.TextBox();
            this.lblCurrentFirmwareLocation = new System.Windows.Forms.Label();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.btnEditNewFirmware = new System.Windows.Forms.Button();
            this.fastColoredTextBoxNewFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grpBxArduinoIDE = new System.Windows.Forms.GroupBox();
            this.btnOpenArduinoIde = new System.Windows.Forms.Button();
            this.txtBxSavArduinoIdeLocation = new System.Windows.Forms.Button();
            this.btnBrowseArduinoIde = new System.Windows.Forms.Button();
            this.txtBxArduinoIdeLocation = new System.Windows.Forms.TextBox();
            this.btnUpdateExtruderInFirmware = new System.Windows.Forms.Button();
            this.btnNewFirmwareLocationSave = new System.Windows.Forms.Button();
            this.btnExtruderFirmwareCopyToClipboard = new System.Windows.Forms.Button();
            this.btnNewFirmwareLocationBrowse = new System.Windows.Forms.Button();
            this.txtBxNewFirmwareLocation = new System.Windows.Forms.TextBox();
            this.lblNewFirmwareLocation = new System.Windows.Forms.Label();
            this.grpBxOldFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxOldFirmware)).BeginInit();
            this.grpBxNewFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxNewFirmware)).BeginInit();
            this.grpBxArduinoIDE.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxOldFirmware
            // 
            this.grpBxOldFirmware.Controls.Add(this.btnEditCurrentFirmware);
            this.grpBxOldFirmware.Controls.Add(this.fastColoredTextBoxOldFirmware);
            this.grpBxOldFirmware.Controls.Add(this.lblFeatureValue);
            this.grpBxOldFirmware.Controls.Add(this.lblFeature);
            this.grpBxOldFirmware.Controls.Add(this.txtBxCurrentFirmwareValue);
            this.grpBxOldFirmware.Controls.Add(this.btnPassValue);
            this.grpBxOldFirmware.Controls.Add(this.cmbBxFirmwareFeatures);
            this.grpBxOldFirmware.Controls.Add(this.chlBxUpdateCurrentFirmware);
            this.grpBxOldFirmware.Controls.Add(this.btnCurrentFirmwareLocationSave);
            this.grpBxOldFirmware.Controls.Add(this.btnCurrentFirmwareLocationBrowse);
            this.grpBxOldFirmware.Controls.Add(this.btnSaveFirmwareLocation);
            this.grpBxOldFirmware.Controls.Add(this.btnExtruderBrowseFirmware);
            this.grpBxOldFirmware.Controls.Add(this.txtBxCurrentFirmwareLocation);
            this.grpBxOldFirmware.Controls.Add(this.lblCurrentFirmwareLocation);
            this.grpBxOldFirmware.Location = new System.Drawing.Point(3, 12);
            this.grpBxOldFirmware.Name = "grpBxOldFirmware";
            this.grpBxOldFirmware.Size = new System.Drawing.Size(568, 639);
            this.grpBxOldFirmware.TabIndex = 28;
            this.grpBxOldFirmware.TabStop = false;
            this.grpBxOldFirmware.Text = "Current Firmware (configuration.h)";
            // 
            // btnEditCurrentFirmware
            // 
            this.btnEditCurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCurrentFirmware.Location = new System.Drawing.Point(510, 17);
            this.btnEditCurrentFirmware.Name = "btnEditCurrentFirmware";
            this.btnEditCurrentFirmware.Size = new System.Drawing.Size(42, 23);
            this.btnEditCurrentFirmware.TabIndex = 49;
            this.btnEditCurrentFirmware.Text = "Edit";
            this.btnEditCurrentFirmware.UseVisualStyleBackColor = true;
            this.btnEditCurrentFirmware.Click += new System.EventHandler(this.btnEditCurrentFirmware_Click);
            // 
            // fastColoredTextBoxOldFirmware
            // 
            this.fastColoredTextBoxOldFirmware.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBoxOldFirmware.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBoxOldFirmware.BackBrush = null;
            this.fastColoredTextBoxOldFirmware.CharHeight = 14;
            this.fastColoredTextBoxOldFirmware.CharWidth = 8;
            this.fastColoredTextBoxOldFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fastColoredTextBoxOldFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxOldFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\MarlinComunicationHelper\\ArduinoSyntax.xml";
            this.fastColoredTextBoxOldFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxOldFirmware.IsReplaceMode = false;
            this.fastColoredTextBoxOldFirmware.Location = new System.Drawing.Point(9, 46);
            this.fastColoredTextBoxOldFirmware.Name = "fastColoredTextBoxOldFirmware";
            this.fastColoredTextBoxOldFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxOldFirmware.ReadOnly = true;
            this.fastColoredTextBoxOldFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxOldFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxOldFirmware.ServiceColors")));
            this.fastColoredTextBoxOldFirmware.Size = new System.Drawing.Size(553, 478);
            this.fastColoredTextBoxOldFirmware.TabIndex = 48;
            this.fastColoredTextBoxOldFirmware.Zoom = 100;
            this.fastColoredTextBoxOldFirmware.AutoIndentNeeded += new System.EventHandler<FastColoredTextBoxNS.AutoIndentEventArgs>(this.fastColoredTextBoxOldFirmware_AutoIndentNeeded);
            this.fastColoredTextBoxOldFirmware.Load += new System.EventHandler(this.fastColoredTextBoxOldFirmware_Load);
            // 
            // lblFeatureValue
            // 
            this.lblFeatureValue.AutoSize = true;
            this.lblFeatureValue.Location = new System.Drawing.Point(293, 535);
            this.lblFeatureValue.Name = "lblFeatureValue";
            this.lblFeatureValue.Size = new System.Drawing.Size(73, 13);
            this.lblFeatureValue.TabIndex = 47;
            this.lblFeatureValue.Text = "Feature Value";
            // 
            // lblFeature
            // 
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(6, 535);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(43, 13);
            this.lblFeature.TabIndex = 46;
            this.lblFeature.Text = "Feature";
            // 
            // txtBxCurrentFirmwareValue
            // 
            this.txtBxCurrentFirmwareValue.Location = new System.Drawing.Point(296, 559);
            this.txtBxCurrentFirmwareValue.Name = "txtBxCurrentFirmwareValue";
            this.txtBxCurrentFirmwareValue.Size = new System.Drawing.Size(266, 20);
            this.txtBxCurrentFirmwareValue.TabIndex = 45;
            // 
            // btnPassValue
            // 
            this.btnPassValue.Location = new System.Drawing.Point(372, 530);
            this.btnPassValue.Name = "btnPassValue";
            this.btnPassValue.Size = new System.Drawing.Size(196, 23);
            this.btnPassValue.TabIndex = 44;
            this.btnPassValue.Text = "Transfer Value -->";
            this.btnPassValue.UseVisualStyleBackColor = true;
            this.btnPassValue.Click += new System.EventHandler(this.btnPassValue_Click);
            // 
            // cmbBxFirmwareFeatures
            // 
            this.cmbBxFirmwareFeatures.FormattingEnabled = true;
            this.cmbBxFirmwareFeatures.Location = new System.Drawing.Point(9, 559);
            this.cmbBxFirmwareFeatures.Name = "cmbBxFirmwareFeatures";
            this.cmbBxFirmwareFeatures.Size = new System.Drawing.Size(281, 21);
            this.cmbBxFirmwareFeatures.TabIndex = 42;
            this.cmbBxFirmwareFeatures.SelectedIndexChanged += new System.EventHandler(this.cmbBxFirmwareFeatures_SelectedIndexChanged);
            // 
            // chlBxUpdateCurrentFirmware
            // 
            this.chlBxUpdateCurrentFirmware.AutoSize = true;
            this.chlBxUpdateCurrentFirmware.Location = new System.Drawing.Point(24, 607);
            this.chlBxUpdateCurrentFirmware.Name = "chlBxUpdateCurrentFirmware";
            this.chlBxUpdateCurrentFirmware.Size = new System.Drawing.Size(142, 17);
            this.chlBxUpdateCurrentFirmware.TabIndex = 41;
            this.chlBxUpdateCurrentFirmware.Text = "Update current Firmware";
            this.chlBxUpdateCurrentFirmware.UseVisualStyleBackColor = true;
            this.chlBxUpdateCurrentFirmware.CheckedChanged += new System.EventHandler(this.chlBxUpdateCurrentFirmware_CheckedChanged);
            // 
            // btnCurrentFirmwareLocationSave
            // 
            this.btnCurrentFirmwareLocationSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentFirmwareLocationSave.Location = new System.Drawing.Point(462, 17);
            this.btnCurrentFirmwareLocationSave.Name = "btnCurrentFirmwareLocationSave";
            this.btnCurrentFirmwareLocationSave.Size = new System.Drawing.Size(42, 23);
            this.btnCurrentFirmwareLocationSave.TabIndex = 40;
            this.btnCurrentFirmwareLocationSave.Text = "Save";
            this.btnCurrentFirmwareLocationSave.UseVisualStyleBackColor = true;
            this.btnCurrentFirmwareLocationSave.Click += new System.EventHandler(this.btnCurrentFirmwareLocationSave_Click);
            // 
            // btnCurrentFirmwareLocationBrowse
            // 
            this.btnCurrentFirmwareLocationBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurrentFirmwareLocationBrowse.Location = new System.Drawing.Point(428, 17);
            this.btnCurrentFirmwareLocationBrowse.Name = "btnCurrentFirmwareLocationBrowse";
            this.btnCurrentFirmwareLocationBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnCurrentFirmwareLocationBrowse.TabIndex = 39;
            this.btnCurrentFirmwareLocationBrowse.Text = "...";
            this.btnCurrentFirmwareLocationBrowse.UseVisualStyleBackColor = true;
            this.btnCurrentFirmwareLocationBrowse.Click += new System.EventHandler(this.btnCurrentFirmwareLocationBrowse_Click);
            // 
            // btnSaveFirmwareLocation
            // 
            this.btnSaveFirmwareLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFirmwareLocation.Location = new System.Drawing.Point(1104, 153);
            this.btnSaveFirmwareLocation.Name = "btnSaveFirmwareLocation";
            this.btnSaveFirmwareLocation.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFirmwareLocation.TabIndex = 38;
            this.btnSaveFirmwareLocation.Text = "Save";
            this.btnSaveFirmwareLocation.UseVisualStyleBackColor = true;
            // 
            // btnExtruderBrowseFirmware
            // 
            this.btnExtruderBrowseFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtruderBrowseFirmware.Location = new System.Drawing.Point(1070, 153);
            this.btnExtruderBrowseFirmware.Name = "btnExtruderBrowseFirmware";
            this.btnExtruderBrowseFirmware.Size = new System.Drawing.Size(28, 23);
            this.btnExtruderBrowseFirmware.TabIndex = 35;
            this.btnExtruderBrowseFirmware.Text = "...";
            this.btnExtruderBrowseFirmware.UseVisualStyleBackColor = true;
            // 
            // txtBxCurrentFirmwareLocation
            // 
            this.txtBxCurrentFirmwareLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxCurrentFirmwareLocation.Location = new System.Drawing.Point(103, 19);
            this.txtBxCurrentFirmwareLocation.Name = "txtBxCurrentFirmwareLocation";
            this.txtBxCurrentFirmwareLocation.Size = new System.Drawing.Size(322, 20);
            this.txtBxCurrentFirmwareLocation.TabIndex = 36;
            this.txtBxCurrentFirmwareLocation.TextChanged += new System.EventHandler(this.txtBxCurrentFirmwareLocation_TextChanged);
            // 
            // lblCurrentFirmwareLocation
            // 
            this.lblCurrentFirmwareLocation.AutoSize = true;
            this.lblCurrentFirmwareLocation.Location = new System.Drawing.Point(6, 20);
            this.lblCurrentFirmwareLocation.Name = "lblCurrentFirmwareLocation";
            this.lblCurrentFirmwareLocation.Size = new System.Drawing.Size(93, 13);
            this.lblCurrentFirmwareLocation.TabIndex = 37;
            this.lblCurrentFirmwareLocation.Text = "Firmware Location";
            // 
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.Controls.Add(this.btnEditNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.fastColoredTextBoxNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.grpBxArduinoIDE);
            this.grpBxNewFirmware.Controls.Add(this.btnUpdateExtruderInFirmware);
            this.grpBxNewFirmware.Controls.Add(this.btnNewFirmwareLocationSave);
            this.grpBxNewFirmware.Controls.Add(this.btnExtruderFirmwareCopyToClipboard);
            this.grpBxNewFirmware.Controls.Add(this.btnNewFirmwareLocationBrowse);
            this.grpBxNewFirmware.Controls.Add(this.txtBxNewFirmwareLocation);
            this.grpBxNewFirmware.Controls.Add(this.lblNewFirmwareLocation);
            this.grpBxNewFirmware.Location = new System.Drawing.Point(577, 12);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(626, 639);
            this.grpBxNewFirmware.TabIndex = 29;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "New Firmware  (configuration.h)";
            // 
            // btnEditNewFirmware
            // 
            this.btnEditNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditNewFirmware.Location = new System.Drawing.Point(530, 15);
            this.btnEditNewFirmware.Name = "btnEditNewFirmware";
            this.btnEditNewFirmware.Size = new System.Drawing.Size(42, 23);
            this.btnEditNewFirmware.TabIndex = 50;
            this.btnEditNewFirmware.Text = "Edit";
            this.btnEditNewFirmware.UseVisualStyleBackColor = true;
            this.btnEditNewFirmware.Click += new System.EventHandler(this.btnEditNewFirmware_Click);
            // 
            // fastColoredTextBoxNewFirmware
            // 
            this.fastColoredTextBoxNewFirmware.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBoxNewFirmware.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBoxNewFirmware.BackBrush = null;
            this.fastColoredTextBoxNewFirmware.ChangedLineColor = System.Drawing.Color.PaleGreen;
            this.fastColoredTextBoxNewFirmware.CharHeight = 14;
            this.fastColoredTextBoxNewFirmware.CharWidth = 8;
            this.fastColoredTextBoxNewFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fastColoredTextBoxNewFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxNewFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\MarlinComunicationHelper\\ArduinoSyntax.xml";
            this.fastColoredTextBoxNewFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxNewFirmware.IsReplaceMode = false;
            this.fastColoredTextBoxNewFirmware.Location = new System.Drawing.Point(13, 46);
            this.fastColoredTextBoxNewFirmware.Name = "fastColoredTextBoxNewFirmware";
            this.fastColoredTextBoxNewFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxNewFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxNewFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxNewFirmware.ServiceColors")));
            this.fastColoredTextBoxNewFirmware.Size = new System.Drawing.Size(605, 478);
            this.fastColoredTextBoxNewFirmware.TabIndex = 45;
            this.fastColoredTextBoxNewFirmware.Zoom = 100;
            this.fastColoredTextBoxNewFirmware.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBoxNewFirmware_TextChanged);
            // 
            // grpBxArduinoIDE
            // 
            this.grpBxArduinoIDE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxArduinoIDE.Controls.Add(this.btnOpenArduinoIde);
            this.grpBxArduinoIDE.Controls.Add(this.txtBxSavArduinoIdeLocation);
            this.grpBxArduinoIDE.Controls.Add(this.btnBrowseArduinoIde);
            this.grpBxArduinoIDE.Controls.Add(this.txtBxArduinoIdeLocation);
            this.grpBxArduinoIDE.Location = new System.Drawing.Point(9, 556);
            this.grpBxArduinoIDE.Name = "grpBxArduinoIDE";
            this.grpBxArduinoIDE.Size = new System.Drawing.Size(611, 77);
            this.grpBxArduinoIDE.TabIndex = 36;
            this.grpBxArduinoIDE.TabStop = false;
            this.grpBxArduinoIDE.Text = "Arduino IDE";
            // 
            // btnOpenArduinoIde
            // 
            this.btnOpenArduinoIde.Location = new System.Drawing.Point(10, 45);
            this.btnOpenArduinoIde.Name = "btnOpenArduinoIde";
            this.btnOpenArduinoIde.Size = new System.Drawing.Size(595, 23);
            this.btnOpenArduinoIde.TabIndex = 22;
            this.btnOpenArduinoIde.Text = "Open Arduino IDE with Marlin.ino";
            this.btnOpenArduinoIde.UseVisualStyleBackColor = true;
            this.btnOpenArduinoIde.Click += new System.EventHandler(this.btnOpenArduinoIde_Click);
            // 
            // txtBxSavArduinoIdeLocation
            // 
            this.txtBxSavArduinoIdeLocation.Location = new System.Drawing.Point(530, 19);
            this.txtBxSavArduinoIdeLocation.Name = "txtBxSavArduinoIdeLocation";
            this.txtBxSavArduinoIdeLocation.Size = new System.Drawing.Size(42, 23);
            this.txtBxSavArduinoIdeLocation.TabIndex = 21;
            this.txtBxSavArduinoIdeLocation.Text = "Save";
            this.txtBxSavArduinoIdeLocation.UseVisualStyleBackColor = true;
            this.txtBxSavArduinoIdeLocation.Click += new System.EventHandler(this.txtBxSavArduinoIdeLocation_Click);
            // 
            // btnBrowseArduinoIde
            // 
            this.btnBrowseArduinoIde.Location = new System.Drawing.Point(496, 19);
            this.btnBrowseArduinoIde.Name = "btnBrowseArduinoIde";
            this.btnBrowseArduinoIde.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseArduinoIde.TabIndex = 1;
            this.btnBrowseArduinoIde.Text = "...";
            this.btnBrowseArduinoIde.UseVisualStyleBackColor = true;
            this.btnBrowseArduinoIde.Click += new System.EventHandler(this.btnBrowseArduinoIde_Click);
            // 
            // txtBxArduinoIdeLocation
            // 
            this.txtBxArduinoIdeLocation.Location = new System.Drawing.Point(10, 19);
            this.txtBxArduinoIdeLocation.Name = "txtBxArduinoIdeLocation";
            this.txtBxArduinoIdeLocation.Size = new System.Drawing.Size(480, 20);
            this.txtBxArduinoIdeLocation.TabIndex = 0;
            this.txtBxArduinoIdeLocation.Text = "C:\\Program Files (x86)\\Arduino";
            // 
            // btnUpdateExtruderInFirmware
            // 
            this.btnUpdateExtruderInFirmware.Location = new System.Drawing.Point(119, 530);
            this.btnUpdateExtruderInFirmware.Name = "btnUpdateExtruderInFirmware";
            this.btnUpdateExtruderInFirmware.Size = new System.Drawing.Size(238, 23);
            this.btnUpdateExtruderInFirmware.TabIndex = 35;
            this.btnUpdateExtruderInFirmware.Text = "Update and Save Firmware (configuration.h)";
            this.btnUpdateExtruderInFirmware.UseVisualStyleBackColor = true;
            this.btnUpdateExtruderInFirmware.Click += new System.EventHandler(this.btnUpdateExtruderInFirmware_Click);
            // 
            // btnNewFirmwareLocationSave
            // 
            this.btnNewFirmwareLocationSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewFirmwareLocationSave.Location = new System.Drawing.Point(482, 15);
            this.btnNewFirmwareLocationSave.Name = "btnNewFirmwareLocationSave";
            this.btnNewFirmwareLocationSave.Size = new System.Drawing.Size(42, 23);
            this.btnNewFirmwareLocationSave.TabIndex = 44;
            this.btnNewFirmwareLocationSave.Text = "Save";
            this.btnNewFirmwareLocationSave.UseVisualStyleBackColor = true;
            this.btnNewFirmwareLocationSave.Click += new System.EventHandler(this.btnNewFirmwareLocationSave_Click);
            // 
            // btnExtruderFirmwareCopyToClipboard
            // 
            this.btnExtruderFirmwareCopyToClipboard.Location = new System.Drawing.Point(15, 530);
            this.btnExtruderFirmwareCopyToClipboard.Name = "btnExtruderFirmwareCopyToClipboard";
            this.btnExtruderFirmwareCopyToClipboard.Size = new System.Drawing.Size(98, 23);
            this.btnExtruderFirmwareCopyToClipboard.TabIndex = 34;
            this.btnExtruderFirmwareCopyToClipboard.Text = "Copy to clipboard";
            this.btnExtruderFirmwareCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnExtruderFirmwareCopyToClipboard.Click += new System.EventHandler(this.btnExtruderFirmwareCopyToClipboard_Click);
            // 
            // btnNewFirmwareLocationBrowse
            // 
            this.btnNewFirmwareLocationBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewFirmwareLocationBrowse.Location = new System.Drawing.Point(453, 15);
            this.btnNewFirmwareLocationBrowse.Name = "btnNewFirmwareLocationBrowse";
            this.btnNewFirmwareLocationBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnNewFirmwareLocationBrowse.TabIndex = 43;
            this.btnNewFirmwareLocationBrowse.Text = "...";
            this.btnNewFirmwareLocationBrowse.UseVisualStyleBackColor = true;
            this.btnNewFirmwareLocationBrowse.Click += new System.EventHandler(this.btnNewFirmwareLocationBrowse_Click);
            // 
            // txtBxNewFirmwareLocation
            // 
            this.txtBxNewFirmwareLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxNewFirmwareLocation.Location = new System.Drawing.Point(103, 17);
            this.txtBxNewFirmwareLocation.Name = "txtBxNewFirmwareLocation";
            this.txtBxNewFirmwareLocation.Size = new System.Drawing.Size(342, 20);
            this.txtBxNewFirmwareLocation.TabIndex = 41;
            this.txtBxNewFirmwareLocation.TextChanged += new System.EventHandler(this.txtBxNewFirmwareLocation_TextChanged);
            // 
            // lblNewFirmwareLocation
            // 
            this.lblNewFirmwareLocation.AutoSize = true;
            this.lblNewFirmwareLocation.Location = new System.Drawing.Point(6, 18);
            this.lblNewFirmwareLocation.Name = "lblNewFirmwareLocation";
            this.lblNewFirmwareLocation.Size = new System.Drawing.Size(93, 13);
            this.lblNewFirmwareLocation.TabIndex = 42;
            this.lblNewFirmwareLocation.Text = "Firmware Location";
            // 
            // FrmFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 663);
            this.Controls.Add(this.grpBxNewFirmware);
            this.Controls.Add(this.grpBxOldFirmware);
            this.Name = "FrmFirmware";
            this.Text = "Marlin Firmware";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFirmware_FormClosed);
            this.Load += new System.EventHandler(this.FrmFirmware_Load);
            this.grpBxOldFirmware.ResumeLayout(false);
            this.grpBxOldFirmware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxOldFirmware)).EndInit();
            this.grpBxNewFirmware.ResumeLayout(false);
            this.grpBxNewFirmware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxNewFirmware)).EndInit();
            this.grpBxArduinoIDE.ResumeLayout(false);
            this.grpBxArduinoIDE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxOldFirmware;
        private System.Windows.Forms.Label lblFeatureValue;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.TextBox txtBxCurrentFirmwareValue;
        private System.Windows.Forms.Button btnPassValue;
        private System.Windows.Forms.ComboBox cmbBxFirmwareFeatures;
        private System.Windows.Forms.CheckBox chlBxUpdateCurrentFirmware;
        private System.Windows.Forms.Button btnCurrentFirmwareLocationSave;
        private System.Windows.Forms.Button btnCurrentFirmwareLocationBrowse;
        private System.Windows.Forms.Button btnSaveFirmwareLocation;
        private System.Windows.Forms.Button btnExtruderBrowseFirmware;
        private System.Windows.Forms.TextBox txtBxCurrentFirmwareLocation;
        private System.Windows.Forms.Label lblCurrentFirmwareLocation;
        private System.Windows.Forms.GroupBox grpBxNewFirmware;
        private System.Windows.Forms.GroupBox grpBxArduinoIDE;
        private System.Windows.Forms.Button btnOpenArduinoIde;
        private System.Windows.Forms.Button txtBxSavArduinoIdeLocation;
        private System.Windows.Forms.Button btnBrowseArduinoIde;
        private System.Windows.Forms.TextBox txtBxArduinoIdeLocation;
        private System.Windows.Forms.Button btnUpdateExtruderInFirmware;
        private System.Windows.Forms.Button btnNewFirmwareLocationSave;
        private System.Windows.Forms.Button btnExtruderFirmwareCopyToClipboard;
        private System.Windows.Forms.Button btnNewFirmwareLocationBrowse;
        private System.Windows.Forms.TextBox txtBxNewFirmwareLocation;
        private System.Windows.Forms.Label lblNewFirmwareLocation;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxOldFirmware;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxNewFirmware;
        private System.Windows.Forms.Button btnEditCurrentFirmware;
        private System.Windows.Forms.Button btnEditNewFirmware;
    }
}