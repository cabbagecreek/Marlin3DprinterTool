using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Marlin3DprinterToolConfiguration
{
    partial class Marlin3DprinterSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marlin3DprinterSetup));
            this.tabControlSetup = new System.Windows.Forms.TabControl();
            this.tabPageLicense = new System.Windows.Forms.TabPage();
            this.grpBxLicensedTo = new System.Windows.Forms.GroupBox();
            this.btnPayPal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBxShowLicence = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBxUnlockKey = new System.Windows.Forms.TextBox();
            this.tabPageMarlinEditor = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpBxArduinoIDE = new System.Windows.Forms.GroupBox();
            this.btnArduinoIDE = new System.Windows.Forms.Button();
            this.txtBxArduinoIDE = new System.Windows.Forms.TextBox();
            this.lblArduinoIDE = new System.Windows.Forms.Label();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.btnDirectoryNewFirmware = new System.Windows.Forms.Button();
            this.txtBxDirectoryNewFirmware = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxCurrentFirmware = new System.Windows.Forms.GroupBox();
            this.btnDirectoryCurrentFirmware = new System.Windows.Forms.Button();
            this.txtBxDirectoryCurrentFirmware = new System.Windows.Forms.TextBox();
            this.lblDirectoryCurrentFirmware = new System.Windows.Forms.Label();
            this.tabPageForceUpdate = new System.Windows.Forms.TabPage();
            this.btnForceUpdate = new System.Windows.Forms.Button();
            this.tabControlSetup.SuspendLayout();
            this.tabPageLicense.SuspendLayout();
            this.grpBxLicensedTo.SuspendLayout();
            this.tabPageMarlinEditor.SuspendLayout();
            this.grpBxArduinoIDE.SuspendLayout();
            this.grpBxNewFirmware.SuspendLayout();
            this.grpBxCurrentFirmware.SuspendLayout();
            this.tabPageForceUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSetup
            // 
            this.tabControlSetup.Controls.Add(this.tabPageLicense);
            this.tabControlSetup.Controls.Add(this.tabPageMarlinEditor);
            this.tabControlSetup.Controls.Add(this.tabPageForceUpdate);
            this.tabControlSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSetup.Location = new System.Drawing.Point(0, 0);
            this.tabControlSetup.Name = "tabControlSetup";
            this.tabControlSetup.SelectedIndex = 0;
            this.tabControlSetup.Size = new System.Drawing.Size(784, 362);
            this.tabControlSetup.TabIndex = 0;
            // 
            // tabPageLicense
            // 
            this.tabPageLicense.Controls.Add(this.grpBxLicensedTo);
            this.tabPageLicense.Location = new System.Drawing.Point(4, 22);
            this.tabPageLicense.Name = "tabPageLicense";
            this.tabPageLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicense.Size = new System.Drawing.Size(776, 336);
            this.tabPageLicense.TabIndex = 0;
            this.tabPageLicense.Text = "License";
            this.tabPageLicense.UseVisualStyleBackColor = true;
            // 
            // grpBxLicensedTo
            // 
            this.grpBxLicensedTo.Controls.Add(this.btnPayPal);
            this.grpBxLicensedTo.Controls.Add(this.btnSave);
            this.grpBxLicensedTo.Controls.Add(this.txtBxShowLicence);
            this.grpBxLicensedTo.Controls.Add(this.btnCancel);
            this.grpBxLicensedTo.Controls.Add(this.txtBxUnlockKey);
            this.grpBxLicensedTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxLicensedTo.Location = new System.Drawing.Point(3, 3);
            this.grpBxLicensedTo.Name = "grpBxLicensedTo";
            this.grpBxLicensedTo.Size = new System.Drawing.Size(770, 330);
            this.grpBxLicensedTo.TabIndex = 3;
            this.grpBxLicensedTo.TabStop = false;
            this.grpBxLicensedTo.Text = "License";
            // 
            // btnPayPal
            // 
            this.btnPayPal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayPal.BackgroundImage = global::Marlin3DprinterToolConfiguration.Properties.Resources.Donate;
            this.btnPayPal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayPal.Location = new System.Drawing.Point(608, 217);
            this.btnPayPal.Name = "btnPayPal";
            this.btnPayPal.Size = new System.Drawing.Size(156, 78);
            this.btnPayPal.TabIndex = 18;
            this.btnPayPal.UseVisualStyleBackColor = true;
            this.btnPayPal.Click += new System.EventHandler(this.btnPayPal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(689, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBxShowLicence
            // 
            this.txtBxShowLicence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxShowLicence.Location = new System.Drawing.Point(6, 217);
            this.txtBxShowLicence.Multiline = true;
            this.txtBxShowLicence.Name = "txtBxShowLicence";
            this.txtBxShowLicence.ReadOnly = true;
            this.txtBxShowLicence.Size = new System.Drawing.Size(596, 108);
            this.txtBxShowLicence.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(608, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBxUnlockKey
            // 
            this.txtBxUnlockKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxUnlockKey.Location = new System.Drawing.Point(6, 19);
            this.txtBxUnlockKey.Multiline = true;
            this.txtBxUnlockKey.Name = "txtBxUnlockKey";
            this.txtBxUnlockKey.Size = new System.Drawing.Size(758, 192);
            this.txtBxUnlockKey.TabIndex = 1;
            this.txtBxUnlockKey.TextChanged += new System.EventHandler(this.txtBxUnlockKey_TextChanged);
            // 
            // tabPageMarlinEditor
            // 
            this.tabPageMarlinEditor.Controls.Add(this.button1);
            this.tabPageMarlinEditor.Controls.Add(this.button2);
            this.tabPageMarlinEditor.Controls.Add(this.grpBxArduinoIDE);
            this.tabPageMarlinEditor.Controls.Add(this.grpBxNewFirmware);
            this.tabPageMarlinEditor.Controls.Add(this.grpBxCurrentFirmware);
            this.tabPageMarlinEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarlinEditor.Name = "tabPageMarlinEditor";
            this.tabPageMarlinEditor.Size = new System.Drawing.Size(776, 336);
            this.tabPageMarlinEditor.TabIndex = 2;
            this.tabPageMarlinEditor.Text = "Marlin Editor";
            this.tabPageMarlinEditor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(692, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(611, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpBxArduinoIDE
            // 
            this.grpBxArduinoIDE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxArduinoIDE.Controls.Add(this.btnArduinoIDE);
            this.grpBxArduinoIDE.Controls.Add(this.txtBxArduinoIDE);
            this.grpBxArduinoIDE.Controls.Add(this.lblArduinoIDE);
            this.grpBxArduinoIDE.Location = new System.Drawing.Point(8, 186);
            this.grpBxArduinoIDE.Name = "grpBxArduinoIDE";
            this.grpBxArduinoIDE.Size = new System.Drawing.Size(762, 79);
            this.grpBxArduinoIDE.TabIndex = 11;
            this.grpBxArduinoIDE.TabStop = false;
            this.grpBxArduinoIDE.Text = "Arduino IDE";
            // 
            // btnArduinoIDE
            // 
            this.btnArduinoIDE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArduinoIDE.Location = new System.Drawing.Point(732, 23);
            this.btnArduinoIDE.Name = "btnArduinoIDE";
            this.btnArduinoIDE.Size = new System.Drawing.Size(24, 23);
            this.btnArduinoIDE.TabIndex = 5;
            this.btnArduinoIDE.Text = "...";
            this.btnArduinoIDE.UseVisualStyleBackColor = true;
            this.btnArduinoIDE.Click += new System.EventHandler(this.btnArduinoIDE_Click);
            // 
            // txtBxArduinoIDE
            // 
            this.txtBxArduinoIDE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxArduinoIDE.Location = new System.Drawing.Point(158, 23);
            this.txtBxArduinoIDE.Name = "txtBxArduinoIDE";
            this.txtBxArduinoIDE.Size = new System.Drawing.Size(568, 20);
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
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxNewFirmware.Controls.Add(this.btnDirectoryNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.txtBxDirectoryNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.label1);
            this.grpBxNewFirmware.Location = new System.Drawing.Point(8, 101);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(762, 79);
            this.grpBxNewFirmware.TabIndex = 10;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "New Firmware (  to be migrated  )";
            // 
            // btnDirectoryNewFirmware
            // 
            this.btnDirectoryNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectoryNewFirmware.Location = new System.Drawing.Point(732, 21);
            this.btnDirectoryNewFirmware.Name = "btnDirectoryNewFirmware";
            this.btnDirectoryNewFirmware.Size = new System.Drawing.Size(24, 23);
            this.btnDirectoryNewFirmware.TabIndex = 5;
            this.btnDirectoryNewFirmware.Text = "...";
            this.btnDirectoryNewFirmware.UseVisualStyleBackColor = true;
            this.btnDirectoryNewFirmware.Click += new System.EventHandler(this.btnDirectoryNewFirmware_Click);
            // 
            // txtBxDirectoryNewFirmware
            // 
            this.txtBxDirectoryNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxDirectoryNewFirmware.Location = new System.Drawing.Point(158, 23);
            this.txtBxDirectoryNewFirmware.Name = "txtBxDirectoryNewFirmware";
            this.txtBxDirectoryNewFirmware.Size = new System.Drawing.Size(568, 20);
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
            // grpBxCurrentFirmware
            // 
            this.grpBxCurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxCurrentFirmware.Controls.Add(this.btnDirectoryCurrentFirmware);
            this.grpBxCurrentFirmware.Controls.Add(this.txtBxDirectoryCurrentFirmware);
            this.grpBxCurrentFirmware.Controls.Add(this.lblDirectoryCurrentFirmware);
            this.grpBxCurrentFirmware.Location = new System.Drawing.Point(8, 16);
            this.grpBxCurrentFirmware.Name = "grpBxCurrentFirmware";
            this.grpBxCurrentFirmware.Size = new System.Drawing.Size(762, 79);
            this.grpBxCurrentFirmware.TabIndex = 9;
            this.grpBxCurrentFirmware.TabStop = false;
            this.grpBxCurrentFirmware.Text = "Current Firmware";
            // 
            // btnDirectoryCurrentFirmware
            // 
            this.btnDirectoryCurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirectoryCurrentFirmware.Location = new System.Drawing.Point(732, 22);
            this.btnDirectoryCurrentFirmware.Name = "btnDirectoryCurrentFirmware";
            this.btnDirectoryCurrentFirmware.Size = new System.Drawing.Size(24, 23);
            this.btnDirectoryCurrentFirmware.TabIndex = 2;
            this.btnDirectoryCurrentFirmware.Text = "...";
            this.btnDirectoryCurrentFirmware.UseVisualStyleBackColor = true;
            this.btnDirectoryCurrentFirmware.Click += new System.EventHandler(this.btnDirectoryCurrentFirmware_Click);
            // 
            // txtBxDirectoryCurrentFirmware
            // 
            this.txtBxDirectoryCurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxDirectoryCurrentFirmware.Location = new System.Drawing.Point(158, 24);
            this.txtBxDirectoryCurrentFirmware.Name = "txtBxDirectoryCurrentFirmware";
            this.txtBxDirectoryCurrentFirmware.Size = new System.Drawing.Size(568, 20);
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
            // tabPageForceUpdate
            // 
            this.tabPageForceUpdate.Controls.Add(this.btnForceUpdate);
            this.tabPageForceUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageForceUpdate.Name = "tabPageForceUpdate";
            this.tabPageForceUpdate.Size = new System.Drawing.Size(776, 336);
            this.tabPageForceUpdate.TabIndex = 3;
            this.tabPageForceUpdate.Text = "Force Update";
            this.tabPageForceUpdate.UseVisualStyleBackColor = true;
            // 
            // btnForceUpdate
            // 
            this.btnForceUpdate.Location = new System.Drawing.Point(18, 32);
            this.btnForceUpdate.Name = "btnForceUpdate";
            this.btnForceUpdate.Size = new System.Drawing.Size(405, 150);
            this.btnForceUpdate.TabIndex = 0;
            this.btnForceUpdate.Text = "Force update from www.Marlin3DprinterTool.se/LatestVersion/Marlin3Dprintertool.ms" +
    "i";
            this.btnForceUpdate.UseVisualStyleBackColor = true;
            this.btnForceUpdate.Click += new System.EventHandler(this.btnForceUpdate_Click);
            // 
            // Marlin3DprinterSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.tabControlSetup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Marlin3DprinterSetup";
            this.Text = "Marlin3DprinterSetup";
            this.Load += new System.EventHandler(this.Marlin3DprinterSetup_Load);
            this.tabControlSetup.ResumeLayout(false);
            this.tabPageLicense.ResumeLayout(false);
            this.grpBxLicensedTo.ResumeLayout(false);
            this.grpBxLicensedTo.PerformLayout();
            this.tabPageMarlinEditor.ResumeLayout(false);
            this.grpBxArduinoIDE.ResumeLayout(false);
            this.grpBxArduinoIDE.PerformLayout();
            this.grpBxNewFirmware.ResumeLayout(false);
            this.grpBxNewFirmware.PerformLayout();
            this.grpBxCurrentFirmware.ResumeLayout(false);
            this.grpBxCurrentFirmware.PerformLayout();
            this.tabPageForceUpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlSetup;
        private TabPage tabPageLicense;
        private TabPage tabPageMarlinEditor;
        private GroupBox grpBxLicensedTo;
        private Button btnPayPal;
        private Button btnSave;
        private TextBox txtBxShowLicence;
        private Button btnCancel;
        private TextBox txtBxUnlockKey;
        private Button button1;
        private Button button2;
        private GroupBox grpBxArduinoIDE;
        private Button btnArduinoIDE;
        private TextBox txtBxArduinoIDE;
        private Label lblArduinoIDE;
        private GroupBox grpBxNewFirmware;
        private Button btnDirectoryNewFirmware;
        private TextBox txtBxDirectoryNewFirmware;
        private Label label1;
        private GroupBox grpBxCurrentFirmware;
        private Button btnDirectoryCurrentFirmware;
        private TextBox txtBxDirectoryCurrentFirmware;
        private Label lblDirectoryCurrentFirmware;
        private TabPage tabPageForceUpdate;
        private Button btnForceUpdate;
    }
}