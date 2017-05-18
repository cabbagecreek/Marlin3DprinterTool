namespace Marlin3DprinterToolUserControls
{
    partial class MarlinComboBox
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
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.cmbBxControl = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblControlText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ledBulbEqualcurrentFirmware
            // 
            this.ledBulbEqualcurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBulbEqualcurrentFirmware.Location = new System.Drawing.Point(205, 3);
            this.ledBulbEqualcurrentFirmware.Name = "ledBulbEqualcurrentFirmware";
            this.ledBulbEqualcurrentFirmware.On = true;
            this.ledBulbEqualcurrentFirmware.Size = new System.Drawing.Size(16, 16);
            this.ledBulbEqualcurrentFirmware.TabIndex = 0;
            this.ledBulbEqualcurrentFirmware.Click += new System.EventHandler(this.ledBulbEqualcurrentFirmware_Click);
            this.ledBulbEqualcurrentFirmware.MouseHover += new System.EventHandler(this.ledBulbEqualcurrentFirmware_MouseHover);
            // 
            // cmbBxControl
            // 
            this.cmbBxControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxControl.FormattingEnabled = true;
            this.cmbBxControl.Location = new System.Drawing.Point(3, 3);
            this.cmbBxControl.Name = "cmbBxControl";
            this.cmbBxControl.Size = new System.Drawing.Size(196, 21);
            this.cmbBxControl.TabIndex = 1;
            this.cmbBxControl.SelectedIndexChanged += new System.EventHandler(this.cmbBxControl_SelectedIndexChanged);
            this.cmbBxControl.MouseHover += new System.EventHandler(this.cmbBxControl_MouseHover);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblControlText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ledBulbEqualcurrentFirmware);
            this.splitContainer1.Panel2.Controls.Add(this.cmbBxControl);
            this.splitContainer1.Size = new System.Drawing.Size(342, 26);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblControlText
            // 
            this.lblControlText.AutoSize = true;
            this.lblControlText.Location = new System.Drawing.Point(3, 6);
            this.lblControlText.Name = "lblControlText";
            this.lblControlText.Size = new System.Drawing.Size(35, 13);
            this.lblControlText.TabIndex = 0;
            this.lblControlText.Text = "label1";
            // 
            // MarlinComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MarlinComboBox";
            this.Size = new System.Drawing.Size(342, 26);
            this.Enter += new System.EventHandler(this.MarlinComboBox_Enter);
            this.MouseHover += new System.EventHandler(this.MarlinComboBox_MouseHover);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Marlin3DprinterToolUserControls.LedBulb ledBulbEqualcurrentFirmware;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.ComboBox cmbBxControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblControlText;
    }
}
