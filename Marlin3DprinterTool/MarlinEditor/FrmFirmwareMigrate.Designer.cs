namespace MarlinEditor
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
            this.fastColoredTextBoxCurrentFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblFeatureValue = new System.Windows.Forms.Label();
            this.lblFeature = new System.Windows.Forms.Label();
            this.txtBxCurrentFirmwareValue = new System.Windows.Forms.TextBox();
            this.btnPassValue = new System.Windows.Forms.Button();
            this.cmbBxFirmwareFeatures = new System.Windows.Forms.ComboBox();
            this.btnSaveFirmwareLocation = new System.Windows.Forms.Button();
            this.btnExtruderBrowseFirmware = new System.Windows.Forms.Button();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.btnOpenArduinoIde = new System.Windows.Forms.Button();
            this.fastColoredTextBoxNewFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnUpdateExtruderInFirmware = new System.Windows.Forms.Button();
            this.btnExtruderFirmwareCopyToClipboard = new System.Windows.Forms.Button();
            this.grpBxOldFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxCurrentFirmware)).BeginInit();
            this.grpBxNewFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxNewFirmware)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxOldFirmware
            // 
            this.grpBxOldFirmware.Controls.Add(this.fastColoredTextBoxCurrentFirmware);
            this.grpBxOldFirmware.Controls.Add(this.lblFeatureValue);
            this.grpBxOldFirmware.Controls.Add(this.lblFeature);
            this.grpBxOldFirmware.Controls.Add(this.txtBxCurrentFirmwareValue);
            this.grpBxOldFirmware.Controls.Add(this.btnPassValue);
            this.grpBxOldFirmware.Controls.Add(this.cmbBxFirmwareFeatures);
            this.grpBxOldFirmware.Controls.Add(this.btnSaveFirmwareLocation);
            this.grpBxOldFirmware.Controls.Add(this.btnExtruderBrowseFirmware);
            this.grpBxOldFirmware.Location = new System.Drawing.Point(3, 12);
            this.grpBxOldFirmware.Name = "grpBxOldFirmware";
            this.grpBxOldFirmware.Size = new System.Drawing.Size(568, 639);
            this.grpBxOldFirmware.TabIndex = 28;
            this.grpBxOldFirmware.TabStop = false;
            this.grpBxOldFirmware.Text = "Current Firmware (configuration.h)";
            // 
            // fastColoredTextBoxCurrentFirmware
            // 
            this.fastColoredTextBoxCurrentFirmware.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextBoxCurrentFirmware.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBoxCurrentFirmware.BackBrush = null;
            this.fastColoredTextBoxCurrentFirmware.CharHeight = 14;
            this.fastColoredTextBoxCurrentFirmware.CharWidth = 8;
            this.fastColoredTextBoxCurrentFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fastColoredTextBoxCurrentFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxCurrentFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fastColoredTextBoxCurrentFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxCurrentFirmware.IsReplaceMode = false;
            this.fastColoredTextBoxCurrentFirmware.Location = new System.Drawing.Point(9, 19);
            this.fastColoredTextBoxCurrentFirmware.Name = "fastColoredTextBoxCurrentFirmware";
            this.fastColoredTextBoxCurrentFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxCurrentFirmware.ReadOnly = true;
            this.fastColoredTextBoxCurrentFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxCurrentFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxCurrentFirmware.ServiceColors")));
            this.fastColoredTextBoxCurrentFirmware.Size = new System.Drawing.Size(553, 505);
            this.fastColoredTextBoxCurrentFirmware.TabIndex = 48;
            this.fastColoredTextBoxCurrentFirmware.Zoom = 100;
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
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.Controls.Add(this.btnOpenArduinoIde);
            this.grpBxNewFirmware.Controls.Add(this.fastColoredTextBoxNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.btnUpdateExtruderInFirmware);
            this.grpBxNewFirmware.Controls.Add(this.btnExtruderFirmwareCopyToClipboard);
            this.grpBxNewFirmware.Location = new System.Drawing.Point(577, 12);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(626, 639);
            this.grpBxNewFirmware.TabIndex = 29;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "New Firmware  (configuration.h)";
            // 
            // btnOpenArduinoIde
            // 
            this.btnOpenArduinoIde.Location = new System.Drawing.Point(15, 610);
            this.btnOpenArduinoIde.Name = "btnOpenArduinoIde";
            this.btnOpenArduinoIde.Size = new System.Drawing.Size(595, 23);
            this.btnOpenArduinoIde.TabIndex = 22;
            this.btnOpenArduinoIde.Text = "Open Arduino IDE with Marlin.ino";
            this.btnOpenArduinoIde.UseVisualStyleBackColor = true;
            this.btnOpenArduinoIde.Click += new System.EventHandler(this.btnOpenArduinoIde_Click);
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
            this.fastColoredTextBoxNewFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fastColoredTextBoxNewFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxNewFirmware.IsReplaceMode = false;
            this.fastColoredTextBoxNewFirmware.Location = new System.Drawing.Point(13, 19);
            this.fastColoredTextBoxNewFirmware.Name = "fastColoredTextBoxNewFirmware";
            this.fastColoredTextBoxNewFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxNewFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxNewFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBoxNewFirmware.ServiceColors")));
            this.fastColoredTextBoxNewFirmware.Size = new System.Drawing.Size(605, 556);
            this.fastColoredTextBoxNewFirmware.TabIndex = 45;
            this.fastColoredTextBoxNewFirmware.Zoom = 100;
            // 
            // btnUpdateExtruderInFirmware
            // 
            this.btnUpdateExtruderInFirmware.Location = new System.Drawing.Point(119, 581);
            this.btnUpdateExtruderInFirmware.Name = "btnUpdateExtruderInFirmware";
            this.btnUpdateExtruderInFirmware.Size = new System.Drawing.Size(238, 23);
            this.btnUpdateExtruderInFirmware.TabIndex = 35;
            this.btnUpdateExtruderInFirmware.Text = "Update and Save Firmware (configuration.h)";
            this.btnUpdateExtruderInFirmware.UseVisualStyleBackColor = true;
            this.btnUpdateExtruderInFirmware.Click += new System.EventHandler(this.btnUpdateExtruderInFirmware_Click);
            // 
            // btnExtruderFirmwareCopyToClipboard
            // 
            this.btnExtruderFirmwareCopyToClipboard.Location = new System.Drawing.Point(15, 581);
            this.btnExtruderFirmwareCopyToClipboard.Name = "btnExtruderFirmwareCopyToClipboard";
            this.btnExtruderFirmwareCopyToClipboard.Size = new System.Drawing.Size(98, 23);
            this.btnExtruderFirmwareCopyToClipboard.TabIndex = 34;
            this.btnExtruderFirmwareCopyToClipboard.Text = "Copy to clipboard";
            this.btnExtruderFirmwareCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnExtruderFirmwareCopyToClipboard.Click += new System.EventHandler(this.btnExtruderFirmwareCopyToClipboard_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxCurrentFirmware)).EndInit();
            this.grpBxNewFirmware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxNewFirmware)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxOldFirmware;
        private System.Windows.Forms.Label lblFeatureValue;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.TextBox txtBxCurrentFirmwareValue;
        private System.Windows.Forms.Button btnPassValue;
        private System.Windows.Forms.ComboBox cmbBxFirmwareFeatures;
        private System.Windows.Forms.Button btnSaveFirmwareLocation;
        private System.Windows.Forms.Button btnExtruderBrowseFirmware;
        private System.Windows.Forms.GroupBox grpBxNewFirmware;
        private System.Windows.Forms.Button btnOpenArduinoIde;
        private System.Windows.Forms.Button btnUpdateExtruderInFirmware;
        private System.Windows.Forms.Button btnExtruderFirmwareCopyToClipboard;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxCurrentFirmware;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxNewFirmware;
    }
}