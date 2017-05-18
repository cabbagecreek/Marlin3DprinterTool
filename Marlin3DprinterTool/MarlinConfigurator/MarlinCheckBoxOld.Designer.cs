namespace MarlinConfigurator
{
    partial class MarlinCheckBoxOld
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ledBulbEqualOldFirmware = new LedBulbUserControl.LedBulb();
            this.chkBxProperty = new System.Windows.Forms.CheckBox();
            this.toolTipCheckBox = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ledBulbEqualOldFirmware
            // 
            this.ledBulbEqualOldFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBulbEqualOldFirmware.Location = new System.Drawing.Point(59, 0);
            this.ledBulbEqualOldFirmware.Name = "ledBulbEqualOldFirmware";
            this.ledBulbEqualOldFirmware.On = true;
            this.ledBulbEqualOldFirmware.Size = new System.Drawing.Size(16, 17);
            this.ledBulbEqualOldFirmware.TabIndex = 0;
            this.ledBulbEqualOldFirmware.Click += new System.EventHandler(this.ledBulbEqualOldFirmware_Click);
            // 
            // chkBxProperty
            // 
            this.chkBxProperty.AutoSize = true;
            this.chkBxProperty.Location = new System.Drawing.Point(0, 0);
            this.chkBxProperty.Name = "chkBxProperty";
            this.chkBxProperty.Size = new System.Drawing.Size(56, 17);
            this.chkBxProperty.TabIndex = 1;
            this.chkBxProperty.Text = "chkBx";
            this.chkBxProperty.UseVisualStyleBackColor = true;
            this.chkBxProperty.CheckedChanged += new System.EventHandler(this.chkBxProperty_CheckedChanged);
            // 
            // MarlinCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBxProperty);
            this.Controls.Add(this.ledBulbEqualOldFirmware);
            this.MinimumSize = new System.Drawing.Size(80, 20);
            this.Name = "MarlinCheckBox";
            this.Size = new System.Drawing.Size(80, 20);
            this.Load += new System.EventHandler(this.MarlinCheckBox_Load);
            this.Enter += new System.EventHandler(this.MarlinCheckBox_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LedBulbUserControl.LedBulb ledBulbEqualOldFirmware;
        private System.Windows.Forms.CheckBox chkBxProperty;
        private System.Windows.Forms.ToolTip toolTipCheckBox;
    }
}
