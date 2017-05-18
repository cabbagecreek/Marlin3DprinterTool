namespace Marlin3DprinterToolUserControls
{
    partial class MarlinEnableValue
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
            this.txtBxValue = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ledBulbEqualcurrentFirmware
            // 
            this.ledBulbEqualcurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBulbEqualcurrentFirmware.Location = new System.Drawing.Point(165, 3);
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
            this.chkBxProperty.Location = new System.Drawing.Point(0, 5);
            this.chkBxProperty.Name = "chkBxProperty";
            this.chkBxProperty.Size = new System.Drawing.Size(80, 17);
            this.chkBxProperty.TabIndex = 1;
            this.chkBxProperty.Text = "checkBox1";
            this.chkBxProperty.UseVisualStyleBackColor = true;
            this.chkBxProperty.CheckedChanged += new System.EventHandler(this.chkBxProperty_CheckedChanged);
            this.chkBxProperty.Leave += new System.EventHandler(this.chkBxProperty_Leave);
            this.chkBxProperty.MouseHover += new System.EventHandler(this.chkBxProperty_MouseHover);
            // 
            // txtBxValue
            // 
            this.txtBxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxValue.Location = new System.Drawing.Point(3, 3);
            this.txtBxValue.Name = "txtBxValue";
            this.txtBxValue.Size = new System.Drawing.Size(156, 20);
            this.txtBxValue.TabIndex = 2;
            this.txtBxValue.TextChanged += new System.EventHandler(this.txtBxValue_TextChanged);
            this.txtBxValue.Leave += new System.EventHandler(this.txtBxValue_Leave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkBxProperty);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ledBulbEqualcurrentFirmware);
            this.splitContainer1.Panel2.Controls.Add(this.txtBxValue);
            this.splitContainer1.Size = new System.Drawing.Size(276, 26);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 3;
            // 
            // MarlinEnableValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MarlinEnableValue";
            this.Size = new System.Drawing.Size(276, 26);
            this.Enter += new System.EventHandler(this.MarlinEnableValue_Enter);
            this.MouseHover += new System.EventHandler(this.MarlinEnableValue_MouseHover);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Marlin3DprinterToolUserControls.LedBulb ledBulbEqualcurrentFirmware;
        private System.Windows.Forms.CheckBox chkBxProperty;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.TextBox txtBxValue;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
