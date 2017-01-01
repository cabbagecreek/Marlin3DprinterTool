namespace MarlinComunicationHelper
{
    partial class BedCornerControl
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
            this.grpBxBedControl = new System.Windows.Forms.GroupBox();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSight = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.maskedTxtBxX = new System.Windows.Forms.MaskedTextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.maskedTxtBxY = new System.Windows.Forms.MaskedTextBox();
            this.grpBxBedControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxBedControl
            // 
            this.grpBxBedControl.Controls.Add(this.btnPin);
            this.grpBxBedControl.Controls.Add(this.btnSave);
            this.grpBxBedControl.Controls.Add(this.btnSight);
            this.grpBxBedControl.Controls.Add(this.lblY);
            this.grpBxBedControl.Controls.Add(this.maskedTxtBxX);
            this.grpBxBedControl.Controls.Add(this.lblX);
            this.grpBxBedControl.Controls.Add(this.maskedTxtBxY);
            this.grpBxBedControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxBedControl.Location = new System.Drawing.Point(0, 0);
            this.grpBxBedControl.MinimumSize = new System.Drawing.Size(178, 65);
            this.grpBxBedControl.Name = "grpBxBedControl";
            this.grpBxBedControl.Size = new System.Drawing.Size(178, 65);
            this.grpBxBedControl.TabIndex = 9;
            this.grpBxBedControl.TabStop = false;
            // 
            // btnPin
            // 
            this.btnPin.Location = new System.Drawing.Point(101, 12);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(32, 32);
            this.btnPin.TabIndex = 3;
            this.btnPin.Text = "Pin";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSight
            // 
            this.btnSight.Location = new System.Drawing.Point(63, 12);
            this.btnSight.Name = "btnSight";
            this.btnSight.Size = new System.Drawing.Size(32, 32);
            this.btnSight.TabIndex = 2;
            this.btnSight.Text = "Sight";
            this.btnSight.UseVisualStyleBackColor = true;
            this.btnSight.Click += new System.EventHandler(this.btnSight_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(7, 41);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Y:";
            // 
            // maskedTxtBxX
            // 
            this.maskedTxtBxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBxX.Location = new System.Drawing.Point(30, 12);
            this.maskedTxtBxX.Mask = "##9";
            this.maskedTxtBxX.Name = "maskedTxtBxX";
            this.maskedTxtBxX.Size = new System.Drawing.Size(27, 20);
            this.maskedTxtBxX.TabIndex = 5;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(7, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // maskedTxtBxY
            // 
            this.maskedTxtBxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBxY.Location = new System.Drawing.Point(30, 38);
            this.maskedTxtBxY.Mask = "##9";
            this.maskedTxtBxY.Name = "maskedTxtBxY";
            this.maskedTxtBxY.Size = new System.Drawing.Size(27, 20);
            this.maskedTxtBxY.TabIndex = 6;
            // 
            // BedCornerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBxBedControl);
            this.MaximumSize = new System.Drawing.Size(178, 65);
            this.MinimumSize = new System.Drawing.Size(178, 65);
            this.Name = "BedCornerControl";
            this.Size = new System.Drawing.Size(178, 65);
            this.grpBxBedControl.ResumeLayout(false);
            this.grpBxBedControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxBedControl;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSight;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxY;
    }
}
