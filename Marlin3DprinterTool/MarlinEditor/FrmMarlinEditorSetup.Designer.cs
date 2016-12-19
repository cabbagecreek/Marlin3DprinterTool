namespace MarlinEditor
{
    partial class FrmMarlinEditorSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarlinEditorSetup));
            this.grpBxCurrentFirmware = new System.Windows.Forms.GroupBox();
            this.btnDirectoryCurrentFirmware = new System.Windows.Forms.Button();
            this.txtBxDirectoryCurrentFirmware = new System.Windows.Forms.TextBox();
            this.lblDirectoryCurrentFirmware = new System.Windows.Forms.Label();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.btnDirectoryNewFirmware = new System.Windows.Forms.Button();
            this.txtBxDirectoryNewFirmware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxArduinoIDE = new System.Windows.Forms.GroupBox();
            this.btnArduinoIDE = new System.Windows.Forms.Button();
            this.txtBxArduinoIDE = new System.Windows.Forms.TextBox();
            this.lblArduinoIDE = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBxCurrentFirmware.SuspendLayout();
            this.grpBxNewFirmware.SuspendLayout();
            this.grpBxArduinoIDE.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxCurrentFirmware
            // 
            this.grpBxCurrentFirmware.Controls.Add(this.btnDirectoryCurrentFirmware);
            this.grpBxCurrentFirmware.Controls.Add(this.txtBxDirectoryCurrentFirmware);
            this.grpBxCurrentFirmware.Controls.Add(this.lblDirectoryCurrentFirmware);
            this.grpBxCurrentFirmware.Location = new System.Drawing.Point(12, 12);
            this.grpBxCurrentFirmware.Name = "grpBxCurrentFirmware";
            this.grpBxCurrentFirmware.Size = new System.Drawing.Size(1019, 155);
            this.grpBxCurrentFirmware.TabIndex = 0;
            this.grpBxCurrentFirmware.TabStop = false;
            this.grpBxCurrentFirmware.Text = "Current Firmware";
            // 
            // btnDirectoryCurrentFirmware
            // 
            this.btnDirectoryCurrentFirmware.Location = new System.Drawing.Point(989, 22);
            this.btnDirectoryCurrentFirmware.Name = "btnDirectoryCurrentFirmware";
            this.btnDirectoryCurrentFirmware.Size = new System.Drawing.Size(24, 23);
            this.btnDirectoryCurrentFirmware.TabIndex = 2;
            this.btnDirectoryCurrentFirmware.Text = "...";
            this.btnDirectoryCurrentFirmware.UseVisualStyleBackColor = true;
            this.btnDirectoryCurrentFirmware.Click += new System.EventHandler(this.btnDirectoryCurrentFirmware_Click);
            // 
            // txtBxDirectoryCurrentFirmware
            // 
            this.txtBxDirectoryCurrentFirmware.Location = new System.Drawing.Point(158, 24);
            this.txtBxDirectoryCurrentFirmware.Name = "txtBxDirectoryCurrentFirmware";
            this.txtBxDirectoryCurrentFirmware.Size = new System.Drawing.Size(825, 20);
            this.txtBxDirectoryCurrentFirmware.TabIndex = 1;
            // 
            // lblDirectoryCurrentFirmware
            // 
            this.lblDirectoryCurrentFirmware.AutoSize = true;
            this.lblDirectoryCurrentFirmware.Location = new System.Drawing.Point(6, 27);
            this.lblDirectoryCurrentFirmware.Name = "lblDirectoryCurrentFirmware";
            this.lblDirectoryCurrentFirmware.Size = new System.Drawing.Size(149, 13);
            this.lblDirectoryCurrentFirmware.TabIndex = 0;
            this.lblDirectoryCurrentFirmware.Text = "Directory for Current Firmware:";
            // 
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.Controls.Add(this.btnDirectoryNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.txtBxDirectoryNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.label1);
            this.grpBxNewFirmware.Location = new System.Drawing.Point(6, 186);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(1019, 114);
            this.grpBxNewFirmware.TabIndex = 1;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "New Firmware (  to be migrated  )";
            // 
            // btnDirectoryNewFirmware
            // 
            this.btnDirectoryNewFirmware.Location = new System.Drawing.Point(989, 21);
            this.btnDirectoryNewFirmware.Name = "btnDirectoryNewFirmware";
            this.btnDirectoryNewFirmware.Size = new System.Drawing.Size(24, 23);
            this.btnDirectoryNewFirmware.TabIndex = 5;
            this.btnDirectoryNewFirmware.Text = "...";
            this.btnDirectoryNewFirmware.UseVisualStyleBackColor = true;
            this.btnDirectoryNewFirmware.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBxDirectoryNewFirmware
            // 
            this.txtBxDirectoryNewFirmware.Location = new System.Drawing.Point(158, 23);
            this.txtBxDirectoryNewFirmware.Name = "txtBxDirectoryNewFirmware";
            this.txtBxDirectoryNewFirmware.Size = new System.Drawing.Size(825, 20);
            this.txtBxDirectoryNewFirmware.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory for New Firmware:";
            // 
            // grpBxArduinoIDE
            // 
            this.grpBxArduinoIDE.Controls.Add(this.btnArduinoIDE);
            this.grpBxArduinoIDE.Controls.Add(this.txtBxArduinoIDE);
            this.grpBxArduinoIDE.Controls.Add(this.lblArduinoIDE);
            this.grpBxArduinoIDE.Location = new System.Drawing.Point(6, 331);
            this.grpBxArduinoIDE.Name = "grpBxArduinoIDE";
            this.grpBxArduinoIDE.Size = new System.Drawing.Size(1019, 124);
            this.grpBxArduinoIDE.TabIndex = 6;
            this.grpBxArduinoIDE.TabStop = false;
            this.grpBxArduinoIDE.Text = "Arduino IDE";
            // 
            // btnArduinoIDE
            // 
            this.btnArduinoIDE.Location = new System.Drawing.Point(989, 23);
            this.btnArduinoIDE.Name = "btnArduinoIDE";
            this.btnArduinoIDE.Size = new System.Drawing.Size(24, 23);
            this.btnArduinoIDE.TabIndex = 5;
            this.btnArduinoIDE.Text = "...";
            this.btnArduinoIDE.UseVisualStyleBackColor = true;
            this.btnArduinoIDE.Click += new System.EventHandler(this.btnArduinoIDE_Click);
            // 
            // txtBxArduinoIDE
            // 
            this.txtBxArduinoIDE.Location = new System.Drawing.Point(158, 23);
            this.txtBxArduinoIDE.Name = "txtBxArduinoIDE";
            this.txtBxArduinoIDE.Size = new System.Drawing.Size(825, 20);
            this.txtBxArduinoIDE.TabIndex = 4;
            // 
            // lblArduinoIDE
            // 
            this.lblArduinoIDE.AutoSize = true;
            this.lblArduinoIDE.Location = new System.Drawing.Point(6, 26);
            this.lblArduinoIDE.Name = "lblArduinoIDE";
            this.lblArduinoIDE.Size = new System.Drawing.Size(127, 13);
            this.lblArduinoIDE.TabIndex = 3;
            this.lblArduinoIDE.Text = "Directory for Arduino IDE:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(950, 461);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(872, 461);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmMarlinEditorSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1034, 494);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpBxArduinoIDE);
            this.Controls.Add(this.grpBxNewFirmware);
            this.Controls.Add(this.grpBxCurrentFirmware);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMarlinEditorSetup";
            this.Text = "Marlin Editor Setup";
            this.Load += new System.EventHandler(this.FrmMarlinEditorSetup_Load);
            this.grpBxCurrentFirmware.ResumeLayout(false);
            this.grpBxCurrentFirmware.PerformLayout();
            this.grpBxNewFirmware.ResumeLayout(false);
            this.grpBxNewFirmware.PerformLayout();
            this.grpBxArduinoIDE.ResumeLayout(false);
            this.grpBxArduinoIDE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxCurrentFirmware;
        private System.Windows.Forms.Button btnDirectoryCurrentFirmware;
        private System.Windows.Forms.TextBox txtBxDirectoryCurrentFirmware;
        private System.Windows.Forms.Label lblDirectoryCurrentFirmware;
        private System.Windows.Forms.GroupBox grpBxNewFirmware;
        private System.Windows.Forms.Button btnDirectoryNewFirmware;
        private System.Windows.Forms.TextBox txtBxDirectoryNewFirmware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxArduinoIDE;
        private System.Windows.Forms.Button btnArduinoIDE;
        private System.Windows.Forms.TextBox txtBxArduinoIDE;
        private System.Windows.Forms.Label lblArduinoIDE;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}