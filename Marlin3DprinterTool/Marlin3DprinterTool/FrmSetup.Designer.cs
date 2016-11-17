namespace Marlin3DprinterTool
{
    partial class FrmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetup));
            this.lblUnlockKey = new System.Windows.Forms.Label();
            this.txtBxUnlockKey = new System.Windows.Forms.TextBox();
            this.grpBxLicensedTo = new System.Windows.Forms.GroupBox();
            this.txtBxShowLicence = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBxLicensedTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnlockKey
            // 
            this.lblUnlockKey.AutoSize = true;
            this.lblUnlockKey.Location = new System.Drawing.Point(13, 13);
            this.lblUnlockKey.Name = "lblUnlockKey";
            this.lblUnlockKey.Size = new System.Drawing.Size(74, 13);
            this.lblUnlockKey.TabIndex = 0;
            this.lblUnlockKey.Text = "Serial number:";
            // 
            // txtBxUnlockKey
            // 
            this.txtBxUnlockKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxUnlockKey.Location = new System.Drawing.Point(16, 29);
            this.txtBxUnlockKey.Multiline = true;
            this.txtBxUnlockKey.Name = "txtBxUnlockKey";
            this.txtBxUnlockKey.Size = new System.Drawing.Size(695, 91);
            this.txtBxUnlockKey.TabIndex = 1;
            this.txtBxUnlockKey.TextChanged += new System.EventHandler(this.txtBxUnlockKey_TextChanged);
            // 
            // grpBxLicensedTo
            // 
            this.grpBxLicensedTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxLicensedTo.Controls.Add(this.txtBxShowLicence);
            this.grpBxLicensedTo.Location = new System.Drawing.Point(16, 128);
            this.grpBxLicensedTo.Name = "grpBxLicensedTo";
            this.grpBxLicensedTo.Size = new System.Drawing.Size(695, 101);
            this.grpBxLicensedTo.TabIndex = 2;
            this.grpBxLicensedTo.TabStop = false;
            this.grpBxLicensedTo.Text = "License";
            // 
            // txtBxShowLicence
            // 
            this.txtBxShowLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxShowLicence.Location = new System.Drawing.Point(6, 19);
            this.txtBxShowLicence.Multiline = true;
            this.txtBxShowLicence.Name = "txtBxShowLicence";
            this.txtBxShowLicence.ReadOnly = true;
            this.txtBxShowLicence.Size = new System.Drawing.Size(683, 68);
            this.txtBxShowLicence.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(555, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(636, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(723, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpBxLicensedTo);
            this.Controls.Add(this.txtBxUnlockKey);
            this.Controls.Add(this.lblUnlockKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "FrmSetup";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FrmSetup_Load);
            this.grpBxLicensedTo.ResumeLayout(false);
            this.grpBxLicensedTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnlockKey;
        private System.Windows.Forms.TextBox txtBxUnlockKey;
        private System.Windows.Forms.GroupBox grpBxLicensedTo;
        private System.Windows.Forms.TextBox txtBxShowLicence;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}