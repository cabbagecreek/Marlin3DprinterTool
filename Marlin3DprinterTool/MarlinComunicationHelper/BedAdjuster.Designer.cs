namespace MarlinComunicationHelper
{
    partial class BedAdjuster
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
            this.lblTurn = new System.Windows.Forms.Label();
            this.txtBxZ = new System.Windows.Forms.TextBox();
            this.picBxLeft = new System.Windows.Forms.PictureBox();
            this.picBxRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(49, 26);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 13);
            this.lblTurn.TabIndex = 7;
            // 
            // txtBxZ
            // 
            this.txtBxZ.Location = new System.Drawing.Point(49, 3);
            this.txtBxZ.Name = "txtBxZ";
            this.txtBxZ.ReadOnly = true;
            this.txtBxZ.Size = new System.Drawing.Size(84, 20);
            this.txtBxZ.TabIndex = 9;
            // 
            // picBxLeft
            // 
            this.picBxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxLeft.Location = new System.Drawing.Point(3, 3);
            this.picBxLeft.Name = "picBxLeft";
            this.picBxLeft.Size = new System.Drawing.Size(40, 40);
            this.picBxLeft.TabIndex = 8;
            this.picBxLeft.TabStop = false;
            // 
            // picBxRight
            // 
            this.picBxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBxRight.Location = new System.Drawing.Point(139, 3);
            this.picBxRight.Name = "picBxRight";
            this.picBxRight.Size = new System.Drawing.Size(40, 40);
            this.picBxRight.TabIndex = 6;
            this.picBxRight.TabStop = false;
            // 
            // BedAdjuster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBxZ);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.picBxLeft);
            this.Controls.Add(this.picBxRight);
            this.MaximumSize = new System.Drawing.Size(180, 50);
            this.MinimumSize = new System.Drawing.Size(180, 50);
            this.Name = "BedAdjuster";
            this.Size = new System.Drawing.Size(180, 50);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.PictureBox picBxRight;
        private System.Windows.Forms.PictureBox picBxLeft;
        private System.Windows.Forms.TextBox txtBxZ;
    }
}
