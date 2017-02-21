namespace ArduinoIDE
{
    partial class FrmCurrentOrNewFirmware
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
            this.btnCurrentFirmware = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBxCurrentFirmware = new System.Windows.Forms.GroupBox();
            this.marlinFirmwareCurrent = new ArduinoIDE.MarlinFirmware();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.marlinFirmwareNew = new ArduinoIDE.MarlinFirmware();
            this.btnNewFirmware = new System.Windows.Forms.Button();
            this.grpBxCurrentFirmware.SuspendLayout();
            this.grpBxNewFirmware.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCurrentFirmware
            // 
            this.btnCurrentFirmware.Location = new System.Drawing.Point(647, 20);
            this.btnCurrentFirmware.Name = "btnCurrentFirmware";
            this.btnCurrentFirmware.Size = new System.Drawing.Size(242, 129);
            this.btnCurrentFirmware.TabIndex = 0;
            this.btnCurrentFirmware.Text = "Current Firmware";
            this.btnCurrentFirmware.UseVisualStyleBackColor = true;
            this.btnCurrentFirmware.Click += new System.EventHandler(this.btnCurrentFirmware_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(832, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpBxCurrentFirmware
            // 
            this.grpBxCurrentFirmware.Controls.Add(this.marlinFirmwareCurrent);
            this.grpBxCurrentFirmware.Controls.Add(this.btnCurrentFirmware);
            this.grpBxCurrentFirmware.Location = new System.Drawing.Point(12, 21);
            this.grpBxCurrentFirmware.Name = "grpBxCurrentFirmware";
            this.grpBxCurrentFirmware.Size = new System.Drawing.Size(895, 162);
            this.grpBxCurrentFirmware.TabIndex = 3;
            this.grpBxCurrentFirmware.TabStop = false;
            this.grpBxCurrentFirmware.Text = "Firmware";
            // 
            // marlinFirmwareCurrent
            // 
            this.marlinFirmwareCurrent.Firmware = null;
            this.marlinFirmwareCurrent.FirmwareDirectory = null;
            this.marlinFirmwareCurrent.Location = new System.Drawing.Point(6, 20);
            this.marlinFirmwareCurrent.Name = "marlinFirmwareCurrent";
            this.marlinFirmwareCurrent.Size = new System.Drawing.Size(620, 130);
            this.marlinFirmwareCurrent.TabIndex = 1;
            // 
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.Controls.Add(this.marlinFirmwareNew);
            this.grpBxNewFirmware.Controls.Add(this.btnNewFirmware);
            this.grpBxNewFirmware.Location = new System.Drawing.Point(12, 189);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(895, 162);
            this.grpBxNewFirmware.TabIndex = 4;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "Firmware";
            // 
            // marlinFirmwareNew
            // 
            this.marlinFirmwareNew.Firmware = null;
            this.marlinFirmwareNew.FirmwareDirectory = null;
            this.marlinFirmwareNew.Location = new System.Drawing.Point(6, 20);
            this.marlinFirmwareNew.Name = "marlinFirmwareNew";
            this.marlinFirmwareNew.Size = new System.Drawing.Size(620, 130);
            this.marlinFirmwareNew.TabIndex = 1;
            // 
            // btnNewFirmware
            // 
            this.btnNewFirmware.Location = new System.Drawing.Point(647, 20);
            this.btnNewFirmware.Name = "btnNewFirmware";
            this.btnNewFirmware.Size = new System.Drawing.Size(242, 129);
            this.btnNewFirmware.TabIndex = 0;
            this.btnNewFirmware.Text = "New Firmware";
            this.btnNewFirmware.UseVisualStyleBackColor = true;
            this.btnNewFirmware.Click += new System.EventHandler(this.btnNewFirmware_Click);
            // 
            // FrmCurrentOrNewFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(919, 411);
            this.Controls.Add(this.grpBxNewFirmware);
            this.Controls.Add(this.grpBxCurrentFirmware);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmCurrentOrNewFirmware";
            this.Text = "Current Marlin Firmware or New Marlin Firmware";
            this.Load += new System.EventHandler(this.FrmCurrentOrNewFirmware_Load);
            this.grpBxCurrentFirmware.ResumeLayout(false);
            this.grpBxNewFirmware.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCurrentFirmware;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBxCurrentFirmware;
        private MarlinFirmware marlinFirmwareCurrent;
        private System.Windows.Forms.GroupBox grpBxNewFirmware;
        private MarlinFirmware marlinFirmwareNew;
        private System.Windows.Forms.Button btnNewFirmware;
    }
}