namespace MarlinEditor
{
    partial class FrmMigrationCompare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMigrationCompare));
            this.fctbCurrentFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fctbNewFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.progressBarWorkingOnFile = new System.Windows.Forms.ProgressBar();
            this.lblCurrentWorkingOnFile = new System.Windows.Forms.Label();
            this.lblFilesWithDifferances = new System.Windows.Forms.Label();
            this.backgroundWorkerCompare = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStopCompare = new System.Windows.Forms.Button();
            this.lstBxFileNames = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCurrentFirmware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbNewFirmware)).BeginInit();
            this.SuspendLayout();
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
            this.fctbCurrentFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fctbCurrentFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbCurrentFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fctbCurrentFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbCurrentFirmware.IsReplaceMode = false;
            this.fctbCurrentFirmware.Location = new System.Drawing.Point(12, -1);
            this.fctbCurrentFirmware.Name = "fctbCurrentFirmware";
            this.fctbCurrentFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbCurrentFirmware.ReadOnly = true;
            this.fctbCurrentFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbCurrentFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbCurrentFirmware.ServiceColors")));
            this.fctbCurrentFirmware.ShowFoldingLines = true;
            this.fctbCurrentFirmware.Size = new System.Drawing.Size(283, 29);
            this.fctbCurrentFirmware.TabIndex = 49;
            this.fctbCurrentFirmware.Zoom = 100;
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
            this.fctbNewFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fctbNewFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbNewFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fctbNewFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbNewFirmware.IsReplaceMode = false;
            this.fctbNewFirmware.Location = new System.Drawing.Point(111, 2);
            this.fctbNewFirmware.Name = "fctbNewFirmware";
            this.fctbNewFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbNewFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbNewFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbNewFirmware.ServiceColors")));
            this.fctbNewFirmware.ShowFoldingLines = true;
            this.fctbNewFirmware.Size = new System.Drawing.Size(412, 26);
            this.fctbNewFirmware.TabIndex = 50;
            this.fctbNewFirmware.Zoom = 100;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCompare.Location = new System.Drawing.Point(565, 395);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(66, 23);
            this.btnCompare.TabIndex = 51;
            this.btnCompare.Text = "OK";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // progressBarWorkingOnFile
            // 
            this.progressBarWorkingOnFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarWorkingOnFile.Location = new System.Drawing.Point(12, 61);
            this.progressBarWorkingOnFile.Name = "progressBarWorkingOnFile";
            this.progressBarWorkingOnFile.Size = new System.Drawing.Size(619, 23);
            this.progressBarWorkingOnFile.TabIndex = 53;
            // 
            // lblCurrentWorkingOnFile
            // 
            this.lblCurrentWorkingOnFile.AutoSize = true;
            this.lblCurrentWorkingOnFile.Location = new System.Drawing.Point(9, 45);
            this.lblCurrentWorkingOnFile.Name = "lblCurrentWorkingOnFile";
            this.lblCurrentWorkingOnFile.Size = new System.Drawing.Size(81, 13);
            this.lblCurrentWorkingOnFile.TabIndex = 54;
            this.lblCurrentWorkingOnFile.Text = "Working on file:";
            this.lblCurrentWorkingOnFile.Visible = false;
            // 
            // lblFilesWithDifferances
            // 
            this.lblFilesWithDifferances.AutoSize = true;
            this.lblFilesWithDifferances.Location = new System.Drawing.Point(9, 98);
            this.lblFilesWithDifferances.Name = "lblFilesWithDifferances";
            this.lblFilesWithDifferances.Size = new System.Drawing.Size(151, 13);
            this.lblFilesWithDifferances.TabIndex = 55;
            this.lblFilesWithDifferances.Text = "Files that contains a differance";
            // 
            // backgroundWorkerCompare
            // 
            this.backgroundWorkerCompare.WorkerReportsProgress = true;
            this.backgroundWorkerCompare.WorkerSupportsCancellation = true;
            this.backgroundWorkerCompare.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCompare_DoWork);
            this.backgroundWorkerCompare.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCompare_ProgressChanged);
            this.backgroundWorkerCompare.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCompare_RunWorkerCompleted);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(484, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnStopCompare
            // 
            this.btnStopCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopCompare.Location = new System.Drawing.Point(556, 2);
            this.btnStopCompare.Name = "btnStopCompare";
            this.btnStopCompare.Size = new System.Drawing.Size(75, 56);
            this.btnStopCompare.TabIndex = 57;
            this.btnStopCompare.Text = "Stop Compare";
            this.btnStopCompare.UseVisualStyleBackColor = true;
            this.btnStopCompare.Click += new System.EventHandler(this.btnStopCompare_Click);
            // 
            // lstBxFileNames
            // 
            this.lstBxFileNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBxFileNames.FormattingEnabled = true;
            this.lstBxFileNames.Location = new System.Drawing.Point(12, 114);
            this.lstBxFileNames.Name = "lstBxFileNames";
            this.lstBxFileNames.Size = new System.Drawing.Size(619, 264);
            this.lstBxFileNames.TabIndex = 58;
            // 
            // FrmMigrationCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(643, 430);
            this.Controls.Add(this.lstBxFileNames);
            this.Controls.Add(this.btnStopCompare);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblFilesWithDifferances);
            this.Controls.Add(this.lblCurrentWorkingOnFile);
            this.Controls.Add(this.progressBarWorkingOnFile);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.fctbNewFirmware);
            this.Controls.Add(this.fctbCurrentFirmware);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FrmMigrationCompare";
            this.Text = "FrmMigrationCompare";
            ((System.ComponentModel.ISupportInitialize)(this.fctbCurrentFirmware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbNewFirmware)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fctbCurrentFirmware;
        private FastColoredTextBoxNS.FastColoredTextBox fctbNewFirmware;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.ProgressBar progressBarWorkingOnFile;
        private System.Windows.Forms.Label lblCurrentWorkingOnFile;
        private System.Windows.Forms.Label lblFilesWithDifferances;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCompare;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStopCompare;
        private System.Windows.Forms.ListBox lstBxFileNames;
    }
}