namespace MarlinConfigurator
{
    partial class MarlinControl
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
            this.ledBulbEqualOldFirmware = new LedBulbUserControl.LedBulb();
            this.SuspendLayout();
            // 
            // ledBulbEqualOldFirmware
            // 
            this.ledBulbEqualOldFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBulbEqualOldFirmware.Location = new System.Drawing.Point(61, 3);
            this.ledBulbEqualOldFirmware.Name = "ledBulbEqualOldFirmware";
            this.ledBulbEqualOldFirmware.On = true;
            this.ledBulbEqualOldFirmware.Size = new System.Drawing.Size(16, 17);
            this.ledBulbEqualOldFirmware.TabIndex = 1;
            // 
            // MarlinControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ledBulbEqualOldFirmware);
            this.Name = "MarlinControl";
            this.Size = new System.Drawing.Size(80, 20);
            this.Load += new System.EventHandler(this.MarlinControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public LedBulbUserControl.LedBulb ledBulbEqualOldFirmware;
    }
}
