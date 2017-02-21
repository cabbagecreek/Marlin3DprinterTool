namespace ArduinoIDE
{
    partial class FrmArduinoIde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArduinoIde));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnProgram = new System.Windows.Forms.Button();
            this.fctbArduinoIde = new FastColoredTextBoxNS.FastColoredTextBox();
            this.grpBxArduinoPreferences = new System.Windows.Forms.GroupBox();
            this.radioBnOpenArduinoIde = new System.Windows.Forms.RadioButton();
            this.radioBnOnlyCompile = new System.Windows.Forms.RadioButton();
            this.radioBnCompileAndUpload = new System.Windows.Forms.RadioButton();
            this.chkBxShowArduinoResponce = new System.Windows.Forms.CheckBox();
            this.lblArduinoBoard = new System.Windows.Forms.Label();
            this.cmbBxArduinoBoard = new System.Windows.Forms.ComboBox();
            this.lblArduinoComport = new System.Windows.Forms.Label();
            this.cmbBxArduinoComport = new System.Windows.Forms.ComboBox();
            this.chkBxUseLastArduinoConfig = new System.Windows.Forms.CheckBox();
            this.btnSetup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fctbArduinoIde)).BeginInit();
            this.grpBxArduinoPreferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 521);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1407, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btnProgram
            // 
            this.btnProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProgram.Location = new System.Drawing.Point(12, 492);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(1406, 23);
            this.btnProgram.TabIndex = 4;
            this.btnProgram.Text = "Compile and Upload Marlin Firmware thru Arduino IDE";
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // fctbArduinoIde
            // 
            this.fctbArduinoIde.AutoCompleteBracketsList = new char[] {
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
            this.fctbArduinoIde.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctbArduinoIde.BackBrush = null;
            this.fctbArduinoIde.CharHeight = 14;
            this.fctbArduinoIde.CharWidth = 8;
            this.fctbArduinoIde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbArduinoIde.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbArduinoIde.IsReplaceMode = false;
            this.fctbArduinoIde.Location = new System.Drawing.Point(12, 54);
            this.fctbArduinoIde.Name = "fctbArduinoIde";
            this.fctbArduinoIde.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbArduinoIde.ReadOnly = true;
            this.fctbArduinoIde.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbArduinoIde.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbArduinoIde.ServiceColors")));
            this.fctbArduinoIde.Size = new System.Drawing.Size(1406, 343);
            this.fctbArduinoIde.TabIndex = 6;
            this.fctbArduinoIde.Zoom = 100;
            // 
            // grpBxArduinoPreferences
            // 
            this.grpBxArduinoPreferences.Controls.Add(this.radioBnOpenArduinoIde);
            this.grpBxArduinoPreferences.Controls.Add(this.radioBnOnlyCompile);
            this.grpBxArduinoPreferences.Controls.Add(this.radioBnCompileAndUpload);
            this.grpBxArduinoPreferences.Controls.Add(this.chkBxShowArduinoResponce);
            this.grpBxArduinoPreferences.Controls.Add(this.lblArduinoBoard);
            this.grpBxArduinoPreferences.Controls.Add(this.cmbBxArduinoBoard);
            this.grpBxArduinoPreferences.Controls.Add(this.lblArduinoComport);
            this.grpBxArduinoPreferences.Controls.Add(this.cmbBxArduinoComport);
            this.grpBxArduinoPreferences.Controls.Add(this.chkBxUseLastArduinoConfig);
            this.grpBxArduinoPreferences.Location = new System.Drawing.Point(12, 403);
            this.grpBxArduinoPreferences.Name = "grpBxArduinoPreferences";
            this.grpBxArduinoPreferences.Size = new System.Drawing.Size(1406, 83);
            this.grpBxArduinoPreferences.TabIndex = 7;
            this.grpBxArduinoPreferences.TabStop = false;
            this.grpBxArduinoPreferences.Text = "Arduino IDE parameters";
            // 
            // radioBnOpenArduinoIde
            // 
            this.radioBnOpenArduinoIde.AutoSize = true;
            this.radioBnOpenArduinoIde.Location = new System.Drawing.Point(503, 60);
            this.radioBnOpenArduinoIde.Name = "radioBnOpenArduinoIde";
            this.radioBnOpenArduinoIde.Size = new System.Drawing.Size(111, 17);
            this.radioBnOpenArduinoIde.TabIndex = 8;
            this.radioBnOpenArduinoIde.TabStop = true;
            this.radioBnOpenArduinoIde.Text = "Open Arduino IDE";
            this.radioBnOpenArduinoIde.UseVisualStyleBackColor = true;
            this.radioBnOpenArduinoIde.CheckedChanged += new System.EventHandler(this.radioBnOpenArduinoIde_CheckedChanged);
            // 
            // radioBnOnlyCompile
            // 
            this.radioBnOnlyCompile.AutoSize = true;
            this.radioBnOnlyCompile.Location = new System.Drawing.Point(503, 36);
            this.radioBnOnlyCompile.Name = "radioBnOnlyCompile";
            this.radioBnOnlyCompile.Size = new System.Drawing.Size(85, 17);
            this.radioBnOnlyCompile.TabIndex = 7;
            this.radioBnOnlyCompile.TabStop = true;
            this.radioBnOnlyCompile.Text = "Only compile";
            this.radioBnOnlyCompile.UseVisualStyleBackColor = true;
            this.radioBnOnlyCompile.CheckedChanged += new System.EventHandler(this.radioBnOnlyCompile_CheckedChanged);
            // 
            // radioBnCompileAndUpload
            // 
            this.radioBnCompileAndUpload.AutoSize = true;
            this.radioBnCompileAndUpload.Checked = true;
            this.radioBnCompileAndUpload.Location = new System.Drawing.Point(503, 13);
            this.radioBnCompileAndUpload.Name = "radioBnCompileAndUpload";
            this.radioBnCompileAndUpload.Size = new System.Drawing.Size(120, 17);
            this.radioBnCompileAndUpload.TabIndex = 6;
            this.radioBnCompileAndUpload.TabStop = true;
            this.radioBnCompileAndUpload.Text = "Compile and Upload";
            this.radioBnCompileAndUpload.UseVisualStyleBackColor = true;
            this.radioBnCompileAndUpload.CheckedChanged += new System.EventHandler(this.radioBnCompileAndUpload_CheckedChanged);
            // 
            // chkBxShowArduinoResponce
            // 
            this.chkBxShowArduinoResponce.AutoSize = true;
            this.chkBxShowArduinoResponce.Checked = true;
            this.chkBxShowArduinoResponce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxShowArduinoResponce.Location = new System.Drawing.Point(273, 21);
            this.chkBxShowArduinoResponce.Name = "chkBxShowArduinoResponce";
            this.chkBxShowArduinoResponce.Size = new System.Drawing.Size(160, 17);
            this.chkBxShowArduinoResponce.TabIndex = 5;
            this.chkBxShowArduinoResponce.Text = "Show Arduino IDE responce";
            this.chkBxShowArduinoResponce.UseVisualStyleBackColor = true;
            this.chkBxShowArduinoResponce.CheckedChanged += new System.EventHandler(this.chkBxShowArduinoResponce_CheckedChanged);
            // 
            // lblArduinoBoard
            // 
            this.lblArduinoBoard.AutoSize = true;
            this.lblArduinoBoard.Location = new System.Drawing.Point(991, 22);
            this.lblArduinoBoard.Name = "lblArduinoBoard";
            this.lblArduinoBoard.Size = new System.Drawing.Size(38, 13);
            this.lblArduinoBoard.TabIndex = 4;
            this.lblArduinoBoard.Text = "Board:";
            // 
            // cmbBxArduinoBoard
            // 
            this.cmbBxArduinoBoard.FormattingEnabled = true;
            this.cmbBxArduinoBoard.Location = new System.Drawing.Point(1035, 19);
            this.cmbBxArduinoBoard.Name = "cmbBxArduinoBoard";
            this.cmbBxArduinoBoard.Size = new System.Drawing.Size(144, 21);
            this.cmbBxArduinoBoard.TabIndex = 3;
            this.cmbBxArduinoBoard.SelectedIndexChanged += new System.EventHandler(this.cmbBxArduinoBoard_SelectedIndexChanged);
            // 
            // lblArduinoComport
            // 
            this.lblArduinoComport.AutoSize = true;
            this.lblArduinoComport.Location = new System.Drawing.Point(1199, 22);
            this.lblArduinoComport.Name = "lblArduinoComport";
            this.lblArduinoComport.Size = new System.Drawing.Size(50, 13);
            this.lblArduinoComport.TabIndex = 2;
            this.lblArduinoComport.Text = "ComPort:";
            // 
            // cmbBxArduinoComport
            // 
            this.cmbBxArduinoComport.FormattingEnabled = true;
            this.cmbBxArduinoComport.Location = new System.Drawing.Point(1255, 19);
            this.cmbBxArduinoComport.Name = "cmbBxArduinoComport";
            this.cmbBxArduinoComport.Size = new System.Drawing.Size(152, 21);
            this.cmbBxArduinoComport.TabIndex = 1;
            this.cmbBxArduinoComport.SelectedIndexChanged += new System.EventHandler(this.cmbBxArduinoComport_SelectedIndexChanged);
            // 
            // chkBxUseLastArduinoConfig
            // 
            this.chkBxUseLastArduinoConfig.AutoSize = true;
            this.chkBxUseLastArduinoConfig.Location = new System.Drawing.Point(6, 21);
            this.chkBxUseLastArduinoConfig.Name = "chkBxUseLastArduinoConfig";
            this.chkBxUseLastArduinoConfig.Size = new System.Drawing.Size(186, 17);
            this.chkBxUseLastArduinoConfig.TabIndex = 0;
            this.chkBxUseLastArduinoConfig.Text = "Use settings from last Arduino IDE";
            this.chkBxUseLastArduinoConfig.UseVisualStyleBackColor = true;
            this.chkBxUseLastArduinoConfig.CheckedChanged += new System.EventHandler(this.chkBxUseLastArduinoConfig_CheckedChanged);
            // 
            // btnSetup
            // 
            this.btnSetup.BackgroundImage = global::ArduinoIDE.Properties.Resources.Setting;
            this.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetup.Location = new System.Drawing.Point(1377, 12);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(41, 32);
            this.btnSetup.TabIndex = 23;
            this.btnSetup.Text = " ";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // FrmArduinoIde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 547);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.grpBxArduinoPreferences);
            this.Controls.Add(this.fctbArduinoIde);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnProgram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArduinoIde";
            this.Text = "Arduino IDE";
            this.Load += new System.EventHandler(this.FrmArduinoIde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fctbArduinoIde)).EndInit();
            this.grpBxArduinoPreferences.ResumeLayout(false);
            this.grpBxArduinoPreferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnProgram;
        private FastColoredTextBoxNS.FastColoredTextBox fctbArduinoIde;
        private System.Windows.Forms.GroupBox grpBxArduinoPreferences;
        private System.Windows.Forms.Label lblArduinoComport;
        private System.Windows.Forms.ComboBox cmbBxArduinoComport;
        private System.Windows.Forms.CheckBox chkBxUseLastArduinoConfig;
        private System.Windows.Forms.CheckBox chkBxShowArduinoResponce;
        private System.Windows.Forms.Label lblArduinoBoard;
        private System.Windows.Forms.ComboBox cmbBxArduinoBoard;
        private System.Windows.Forms.RadioButton radioBnOnlyCompile;
        private System.Windows.Forms.RadioButton radioBnCompileAndUpload;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.RadioButton radioBnOpenArduinoIde;
    }
}

