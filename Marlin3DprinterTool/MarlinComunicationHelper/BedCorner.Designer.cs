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
            this.btnGoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.maskedTxtBxX = new System.Windows.Forms.MaskedTextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.maskedTxtBxY = new System.Windows.Forms.MaskedTextBox();
            this.toolTipBedCorner = new System.Windows.Forms.ToolTip();
            this.grpBxBedControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxBedControl
            // 
            this.grpBxBedControl.Controls.Add(this.btnGoto);
            this.grpBxBedControl.Controls.Add(this.btnSave);
            this.grpBxBedControl.Controls.Add(this.btnPin);
            this.grpBxBedControl.Controls.Add(this.lblY);
            this.grpBxBedControl.Controls.Add(this.maskedTxtBxX);
            this.grpBxBedControl.Controls.Add(this.lblX);
            this.grpBxBedControl.Controls.Add(this.maskedTxtBxY);
            this.grpBxBedControl.Location = new System.Drawing.Point(0, 0);
            this.grpBxBedControl.Name = "grpBxBedControl";
            this.grpBxBedControl.Size = new System.Drawing.Size(192, 62);
            this.grpBxBedControl.TabIndex = 9;
            this.grpBxBedControl.TabStop = false;
            // 
            // btnGoto
            // 
            this.btnGoto.BackgroundImage = global::MarlinComunicationHelper.Properties.Resources.GoTo;
            this.btnGoto.Location = new System.Drawing.Point(97, 12);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(41, 42);
            this.btnGoto.TabIndex = 3;
            this.toolTipBedCorner.SetToolTip(this.btnGoto, "Goto the Position");
            this.btnGoto.UseVisualStyleBackColor = true;
            this.btnGoto.Click += new System.EventHandler(this.btnGoto_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::MarlinComunicationHelper.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(139, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 42);
            this.btnSave.TabIndex = 1;
            this.toolTipBedCorner.SetToolTip(this.btnSave, "Save the position for the corner");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPin
            // 
            this.btnPin.BackgroundImage = global::MarlinComunicationHelper.Properties.Resources.pin;
            this.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPin.Location = new System.Drawing.Point(54, 12);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(41, 42);
            this.btnPin.TabIndex = 2;
            this.toolTipBedCorner.SetToolTip(this.btnPin, "Pin the current position");
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(2, 41);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Y:";
            // 
            // maskedTxtBxX
            // 
            this.maskedTxtBxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBxX.Location = new System.Drawing.Point(20, 12);
            this.maskedTxtBxX.Mask = "##9";
            this.maskedTxtBxX.Name = "maskedTxtBxX";
            this.maskedTxtBxX.Size = new System.Drawing.Size(27, 20);
            this.maskedTxtBxX.TabIndex = 5;
            this.toolTipBedCorner.SetToolTip(this.maskedTxtBxX, "X for bed coener");
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(3, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // maskedTxtBxY
            // 
            this.maskedTxtBxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTxtBxY.Location = new System.Drawing.Point(20, 38);
            this.maskedTxtBxY.Mask = "##9";
            this.maskedTxtBxY.Name = "maskedTxtBxY";
            this.maskedTxtBxY.Size = new System.Drawing.Size(27, 20);
            this.maskedTxtBxY.TabIndex = 6;
            this.toolTipBedCorner.SetToolTip(this.maskedTxtBxY, "Y for bed coener");
            // 
            // BedCornerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBxBedControl);
            this.MaximumSize = new System.Drawing.Size(195, 65);
            this.MinimumSize = new System.Drawing.Size(195, 65);
            this.Name = "BedCornerControl";
            this.Size = new System.Drawing.Size(195, 65);
            this.grpBxBedControl.ResumeLayout(false);
            this.grpBxBedControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxBedControl;
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxY;
        private System.Windows.Forms.ToolTip toolTipBedCorner;
    }
}
