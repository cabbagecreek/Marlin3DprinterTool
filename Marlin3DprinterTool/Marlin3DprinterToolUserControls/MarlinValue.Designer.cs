namespace Marlin3DprinterToolUserControls
{
    partial class MarlinValue
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
            this.txtBxValue = new System.Windows.Forms.TextBox();
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
            this.ledBulbEqualcurrentFirmware.Location = new System.Drawing.Point(214, 3);
            this.ledBulbEqualcurrentFirmware.Name = "ledBulbEqualcurrentFirmware";
            this.ledBulbEqualcurrentFirmware.On = true;
            this.ledBulbEqualcurrentFirmware.Size = new System.Drawing.Size(16, 16);
            this.ledBulbEqualcurrentFirmware.TabIndex = 0;
            this.ledBulbEqualcurrentFirmware.Click += new System.EventHandler(this.ledBulbEqualcurrentFirmware_Click);
            this.ledBulbEqualcurrentFirmware.MouseHover += new System.EventHandler(this.ledBulbEqualcurrentFirmware_MouseHover);
            // 
            // txtBxValue
            // 
            this.txtBxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxValue.Location = new System.Drawing.Point(3, 3);
            this.txtBxValue.Name = "txtBxValue";
            this.txtBxValue.Size = new System.Drawing.Size(205, 20);
            this.txtBxValue.TabIndex = 2;
            this.txtBxValue.TextChanged += new System.EventHandler(this.txtBxValue_TextChanged);
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
            this.splitContainer1.Panel2.Controls.Add(this.txtBxValue);
            this.splitContainer1.Size = new System.Drawing.Size(276, 26);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 3;
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
            // MarlinValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MarlinValue";
            this.Size = new System.Drawing.Size(276, 26);
            this.Enter += new System.EventHandler(this.MarlinValue_Enter);
            this.MouseHover += new System.EventHandler(this.MarlinValue_MouseHover);
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
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.TextBox txtBxValue;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblControlText;
    }
}
