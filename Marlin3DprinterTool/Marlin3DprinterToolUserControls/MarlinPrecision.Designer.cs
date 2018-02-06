namespace Marlin3DprinterToolUserControls
{
    partial class MarlinPrecision
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
            this.chkBxAutomatic = new System.Windows.Forms.CheckBox();
            this.trkBarPrecision = new System.Windows.Forms.TrackBar();
            this.txtBxPrecision = new System.Windows.Forms.TextBox();
            this.lblPrecision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBxAutomatic
            // 
            this.chkBxAutomatic.AutoSize = true;
            this.chkBxAutomatic.Location = new System.Drawing.Point(3, 3);
            this.chkBxAutomatic.Name = "chkBxAutomatic";
            this.chkBxAutomatic.Size = new System.Drawing.Size(73, 17);
            this.chkBxAutomatic.TabIndex = 0;
            this.chkBxAutomatic.Text = "Automatic";
            this.chkBxAutomatic.UseVisualStyleBackColor = true;
            this.chkBxAutomatic.CheckedChanged += new System.EventHandler(this.chkBxAutomatic_CheckedChanged);
            // 
            // trkBarPrecision
            // 
            this.trkBarPrecision.Location = new System.Drawing.Point(3, 53);
            this.trkBarPrecision.Name = "trkBarPrecision";
            this.trkBarPrecision.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkBarPrecision.Size = new System.Drawing.Size(45, 77);
            this.trkBarPrecision.TabIndex = 1;
            // 
            // txtBxPrecision
            // 
            this.txtBxPrecision.Location = new System.Drawing.Point(3, 26);
            this.txtBxPrecision.Name = "txtBxPrecision";
            this.txtBxPrecision.Size = new System.Drawing.Size(53, 20);
            this.txtBxPrecision.TabIndex = 2;
            // 
            // lblPrecision
            // 
            this.lblPrecision.AutoSize = true;
            this.lblPrecision.Location = new System.Drawing.Point(33, 53);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(23, 13);
            this.lblPrecision.TabIndex = 3;
            this.lblPrecision.Text = "mm";
            // 
            // MarlinPrecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.txtBxPrecision);
            this.Controls.Add(this.trkBarPrecision);
            this.Controls.Add(this.chkBxAutomatic);
            this.Name = "MarlinPrecision";
            this.Size = new System.Drawing.Size(77, 136);
            ((System.ComponentModel.ISupportInitialize)(this.trkBarPrecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBxAutomatic;
        private System.Windows.Forms.TrackBar trkBarPrecision;
        private System.Windows.Forms.TextBox txtBxPrecision;
        private System.Windows.Forms.Label lblPrecision;
    }
}
