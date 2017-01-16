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
            this.fctbCurrentFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.contextMenuStripChangeConfigTypeFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CompareFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFeatureValue = new System.Windows.Forms.Label();
            this.lblFeature = new System.Windows.Forms.Label();
            this.txtBxCurrentFirmwareValue = new System.Windows.Forms.TextBox();
            this.btnPassValue = new System.Windows.Forms.Button();
            this.cmbBxFirmwareFeatures = new System.Windows.Forms.ComboBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnUpdateExtruderInFirmware = new System.Windows.Forms.Button();
            this.btnOpenArduinoIde = new System.Windows.Forms.Button();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.fctbNewFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.filesWithDifferancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBxOldFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCurrentFirmware)).BeginInit();
            this.contextMenuStripChangeConfigTypeFile.SuspendLayout();
            this.grpBxNewFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbNewFirmware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxOldFirmware
            // 
            this.grpBxOldFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxOldFirmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxOldFirmware.Controls.Add(this.fctbCurrentFirmware);
            this.grpBxOldFirmware.Controls.Add(this.lblFeatureValue);
            this.grpBxOldFirmware.Controls.Add(this.lblFeature);
            this.grpBxOldFirmware.Controls.Add(this.txtBxCurrentFirmwareValue);
            this.grpBxOldFirmware.Controls.Add(this.btnPassValue);
            this.grpBxOldFirmware.Controls.Add(this.cmbBxFirmwareFeatures);
            this.grpBxOldFirmware.Location = new System.Drawing.Point(3, 3);
            this.grpBxOldFirmware.Name = "grpBxOldFirmware";
            this.grpBxOldFirmware.Size = new System.Drawing.Size(495, 456);
            this.grpBxOldFirmware.TabIndex = 28;
            this.grpBxOldFirmware.TabStop = false;
            this.grpBxOldFirmware.Text = "Current Firmware (...)";
            // 
            // fctbCurrentFirmware
            // 
            this.fctbCurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbCurrentFirmware.AutoCompleteBracketsList = new char[] {
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
            this.fctbCurrentFirmware.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctbCurrentFirmware.BackBrush = null;
            this.fctbCurrentFirmware.BookmarkColor = System.Drawing.Color.Magenta;
            this.fctbCurrentFirmware.CharHeight = 14;
            this.fctbCurrentFirmware.CharWidth = 8;
            this.fctbCurrentFirmware.ContextMenuStrip = this.contextMenuStripChangeConfigTypeFile;
            this.fctbCurrentFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fctbCurrentFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbCurrentFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fctbCurrentFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbCurrentFirmware.IsReplaceMode = false;
            this.fctbCurrentFirmware.Location = new System.Drawing.Point(0, 19);
            this.fctbCurrentFirmware.Name = "fctbCurrentFirmware";
            this.fctbCurrentFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbCurrentFirmware.ReadOnly = true;
            this.fctbCurrentFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbCurrentFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbCurrentFirmware.ServiceColors")));
            this.fctbCurrentFirmware.ShowFoldingLines = true;
            this.fctbCurrentFirmware.Size = new System.Drawing.Size(489, 369);
            this.fctbCurrentFirmware.TabIndex = 48;
            this.toolTip1.SetToolTip(this.fctbCurrentFirmware, "Right Click to change filetype");
            this.fctbCurrentFirmware.Zoom = 100;
            this.fctbCurrentFirmware.SelectionChanged += new System.EventHandler(this.fctbCurrentFirmware_SelectionChanged);
            this.fctbCurrentFirmware.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctbCurrentFirmware_TextChangedDelayed);
            // 
            // contextMenuStripChangeConfigTypeFile
            // 
            this.contextMenuStripChangeConfigTypeFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseAFileToolStripMenuItem,
            this.CompareFiles,
            this.toolStripSeparator1,
            this.filesWithDifferancesToolStripMenuItem,
            this.toolStripTextBox1});
            this.contextMenuStripChangeConfigTypeFile.Name = "contextMenuStripChangeConfigTypeFile";
            this.contextMenuStripChangeConfigTypeFile.Size = new System.Drawing.Size(200, 123);
            // 
            // CompareFiles
            // 
            this.CompareFiles.Name = "CompareFiles";
            this.CompareFiles.Size = new System.Drawing.Size(199, 22);
            this.CompareFiles.Text = "Compare all config files";
            this.CompareFiles.Click += new System.EventHandler(this.compareFiles_Click);
            // 
            // chooseAFileToolStripMenuItem
            // 
            this.chooseAFileToolStripMenuItem.Name = "chooseAFileToolStripMenuItem";
            this.chooseAFileToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.chooseAFileToolStripMenuItem.Text = "Choose a file";
            this.chooseAFileToolStripMenuItem.Click += new System.EventHandler(this.chooseAFileToolStripMenuItem_Click);
            // 
            // lblFeatureValue
            // 
            this.lblFeatureValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeatureValue.AutoSize = true;
            this.lblFeatureValue.Location = new System.Drawing.Point(261, 406);
            this.lblFeatureValue.Name = "lblFeatureValue";
            this.lblFeatureValue.Size = new System.Drawing.Size(73, 13);
            this.lblFeatureValue.TabIndex = 47;
            this.lblFeatureValue.Text = "Feature Value";
            // 
            // lblFeature
            // 
            this.lblFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(7, 406);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(43, 13);
            this.lblFeature.TabIndex = 46;
            this.lblFeature.Text = "Feature";
            // 
            // txtBxCurrentFirmwareValue
            // 
            this.txtBxCurrentFirmwareValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxCurrentFirmwareValue.Location = new System.Drawing.Point(264, 430);
            this.txtBxCurrentFirmwareValue.Name = "txtBxCurrentFirmwareValue";
            this.txtBxCurrentFirmwareValue.Size = new System.Drawing.Size(225, 20);
            this.txtBxCurrentFirmwareValue.TabIndex = 45;
            // 
            // btnPassValue
            // 
            this.btnPassValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassValue.Location = new System.Drawing.Point(377, 401);
            this.btnPassValue.Name = "btnPassValue";
            this.btnPassValue.Size = new System.Drawing.Size(112, 23);
            this.btnPassValue.TabIndex = 44;
            this.btnPassValue.Text = "Transfer Value -->";
            this.btnPassValue.UseVisualStyleBackColor = true;
            this.btnPassValue.Click += new System.EventHandler(this.btnPassValue_Click);
            // 
            // cmbBxFirmwareFeatures
            // 
            this.cmbBxFirmwareFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxFirmwareFeatures.FormattingEnabled = true;
            this.cmbBxFirmwareFeatures.Location = new System.Drawing.Point(6, 430);
            this.cmbBxFirmwareFeatures.Name = "cmbBxFirmwareFeatures";
            this.cmbBxFirmwareFeatures.Size = new System.Drawing.Size(252, 21);
            this.cmbBxFirmwareFeatures.TabIndex = 42;
            this.cmbBxFirmwareFeatures.SelectedIndexChanged += new System.EventHandler(this.cmbBxFirmwareFeatures_SelectedIndexChanged);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(6, 397);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(98, 25);
            this.btnCopyToClipboard.TabIndex = 34;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnExtruderFirmwareCopyToClipboard_Click);
            // 
            // btnUpdateExtruderInFirmware
            // 
            this.btnUpdateExtruderInFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateExtruderInFirmware.Location = new System.Drawing.Point(110, 397);
            this.btnUpdateExtruderInFirmware.Name = "btnUpdateExtruderInFirmware";
            this.btnUpdateExtruderInFirmware.Size = new System.Drawing.Size(371, 23);
            this.btnUpdateExtruderInFirmware.TabIndex = 35;
            this.btnUpdateExtruderInFirmware.Text = "Update and Save Firmware (configuration.h)";
            this.btnUpdateExtruderInFirmware.UseVisualStyleBackColor = true;
            this.btnUpdateExtruderInFirmware.Click += new System.EventHandler(this.btnUpdateExtruderInFirmware_Click);
            // 
            // btnOpenArduinoIde
            // 
            this.btnOpenArduinoIde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenArduinoIde.Location = new System.Drawing.Point(6, 427);
            this.btnOpenArduinoIde.Name = "btnOpenArduinoIde";
            this.btnOpenArduinoIde.Size = new System.Drawing.Size(475, 23);
            this.btnOpenArduinoIde.TabIndex = 22;
            this.btnOpenArduinoIde.Text = "Open Arduino IDE with Marlin.ino";
            this.btnOpenArduinoIde.UseVisualStyleBackColor = true;
            this.btnOpenArduinoIde.Click += new System.EventHandler(this.btnOpenArduinoIde_Click);
            // 
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxNewFirmware.Controls.Add(this.fctbNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.btnOpenArduinoIde);
            this.grpBxNewFirmware.Controls.Add(this.btnUpdateExtruderInFirmware);
            this.grpBxNewFirmware.Controls.Add(this.btnCopyToClipboard);
            this.grpBxNewFirmware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxNewFirmware.Location = new System.Drawing.Point(0, 0);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(497, 459);
            this.grpBxNewFirmware.TabIndex = 29;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "New Firmware  (...)";
            // 
            // fctbNewFirmware
            // 
            this.fctbNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbNewFirmware.AutoCompleteBracketsList = new char[] {
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
            this.fctbNewFirmware.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctbNewFirmware.BackBrush = null;
            this.fctbNewFirmware.CharHeight = 14;
            this.fctbNewFirmware.CharWidth = 8;
            this.fctbNewFirmware.ContextMenuStrip = this.contextMenuStripChangeConfigTypeFile;
            this.fctbNewFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fctbNewFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbNewFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fctbNewFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbNewFirmware.IsReplaceMode = false;
            this.fctbNewFirmware.Location = new System.Drawing.Point(5, 22);
            this.fctbNewFirmware.Name = "fctbNewFirmware";
            this.fctbNewFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbNewFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbNewFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbNewFirmware.ServiceColors")));
            this.fctbNewFirmware.ShowFoldingLines = true;
            this.fctbNewFirmware.Size = new System.Drawing.Size(489, 369);
            this.fctbNewFirmware.TabIndex = 49;
            this.fctbNewFirmware.Zoom = 100;
            this.fctbNewFirmware.SelectionChanged += new System.EventHandler(this.fctbBoxNewFirmware_SelectionChanged);
            this.fctbNewFirmware.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctbNewFirmware_TextChangedDelayed);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpBxOldFirmware);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpBxNewFirmware);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 459);
            this.splitContainer1.SplitterDistance = 501;
            this.splitContainer1.TabIndex = 30;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // filesWithDifferancesToolStripMenuItem
            // 
            this.filesWithDifferancesToolStripMenuItem.Name = "filesWithDifferancesToolStripMenuItem";
            this.filesWithDifferancesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.filesWithDifferancesToolStripMenuItem.Text = "Files with differances";
            // 
            // FrmFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FrmFirmware";
            this.Text = "Marlin Firmware";
            this.Load += new System.EventHandler(this.FrmFirmware_Load);
            this.SizeChanged += new System.EventHandler(this.FrmFirmware_SizeChanged);
            this.grpBxOldFirmware.ResumeLayout(false);
            this.grpBxOldFirmware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCurrentFirmware)).EndInit();
            this.contextMenuStripChangeConfigTypeFile.ResumeLayout(false);
            this.contextMenuStripChangeConfigTypeFile.PerformLayout();
            this.grpBxNewFirmware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbNewFirmware)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxOldFirmware;
        private System.Windows.Forms.Label lblFeatureValue;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.TextBox txtBxCurrentFirmwareValue;
        private System.Windows.Forms.Button btnPassValue;
        private System.Windows.Forms.ComboBox cmbBxFirmwareFeatures;
        private FastColoredTextBoxNS.FastColoredTextBox fctbCurrentFirmware;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnUpdateExtruderInFirmware;
        private System.Windows.Forms.Button btnOpenArduinoIde;
        private System.Windows.Forms.GroupBox grpBxNewFirmware;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox fctbNewFirmware;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripChangeConfigTypeFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripMenuItem CompareFiles;
        private System.Windows.Forms.ToolStripMenuItem chooseAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem filesWithDifferancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}