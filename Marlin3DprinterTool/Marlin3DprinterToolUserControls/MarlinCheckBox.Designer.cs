namespace Marlin3DprinterToolUserControls
{
    partial class MarlinCheckBox
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
            this.ledBulbEqualcurrentFirmware = new Marlin3DprinterToolUserControls.LedBulb();
            this.chkBxProperty = new System.Windows.Forms.CheckBox();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ledBulbEqualcurrentFirmware
            // 
            this.ledBulbEqualcurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBulbEqualcurrentFirmware.Location = new System.Drawing.Point(328, 2);
            this.ledBulbEqualcurrentFirmware.Name = "ledBulbEqualcurrentFirmware";
            this.ledBulbEqualcurrentFirmware.On = true;
            this.ledBulbEqualcurrentFirmware.Size = new System.Drawing.Size(16, 16);
            this.ledBulbEqualcurrentFirmware.TabIndex = 0;
            this.ledBulbEqualcurrentFirmware.Click += new System.EventHandler(this.ledBulbEqualcurrentFirmware_Click);
            this.ledBulbEqualcurrentFirmware.MouseHover += new System.EventHandler(this.ledBulbEqualcurrentFirmware_MouseHover);
            // 
            // chkBxProperty
            // 
            this.chkBxProperty.AutoSize = true;
            this.chkBxProperty.Location = new System.Drawing.Point(4, 4);
            this.chkBxProperty.Name = "chkBxProperty";
            this.chkBxProperty.Size = new System.Drawing.Size(80, 17);
            this.chkBxProperty.TabIndex = 1;
            this.chkBxProperty.Text = "checkBox1";
            this.chkBxProperty.UseVisualStyleBackColor = true;
            this.chkBxProperty.CheckedChanged += new System.EventHandler(this.chkBxProperty_CheckedChanged);
            this.chkBxProperty.MouseHover += new System.EventHandler(this.chkBxProperty_MouseHover);
            // 
            // MarlinCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBxProperty);
            this.Controls.Add(this.ledBulbEqualcurrentFirmware);
            this.Name = "MarlinCheckBox";
            this.Size = new System.Drawing.Size(347, 21);
            this.Enter += new System.EventHandler(this.MarlinCheckBox_Enter);
            this.MouseHover += new System.EventHandler(this.MarlinCheckBox_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Marlin3DprinterToolUserControls.LedBulb ledBulbEqualcurrentFirmware;
        private System.Windows.Forms.CheckBox chkBxProperty;
        private System.Windows.Forms.ToolTip toolTipControl;
    }
}
