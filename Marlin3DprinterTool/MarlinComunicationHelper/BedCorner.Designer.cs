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
<<<<<<< HEAD
            this.btnPin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSight = new System.Windows.Forms.Button();
=======
            this.btnGoto = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPin = new System.Windows.Forms.Button();
>>>>>>> develop
            this.lblY = new System.Windows.Forms.Label();
            this.maskedTxtBxX = new System.Windows.Forms.MaskedTextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.maskedTxtBxY = new System.Windows.Forms.MaskedTextBox();
<<<<<<< HEAD
=======
            this.toolTipBedCorner = new System.Windows.Forms.ToolTip();
>>>>>>> develop
            this.grpBxBedControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxBedControl
            // 
<<<<<<< HEAD
            this.grpBxBedControl.Controls.Add(this.btnPin);
            this.grpBxBedControl.Controls.Add(this.btnSave);
            this.grpBxBedControl.Controls.Add(this.btnSight);
=======
            this.grpBxBedControl.Controls.Add(this.btnGoto);
            this.grpBxBedControl.Controls.Add(this.btnSave);
            this.grpBxBedControl.Controls.Add(this.btnPin);
>>>>>>> develop
            this.grpBxBedControl.Controls.Add(this.lblY);
            this.grpBxBedControl.Controls.Add(this.maskedTxtBxX);
            this.grpBxBedControl.Controls.Add(this.lblX);
            this.grpBxBedControl.Controls.Add(this.maskedTxtBxY);
<<<<<<< HEAD
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
=======
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
>>>>>>> develop
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
<<<<<<< HEAD
            this.lblY.Location = new System.Drawing.Point(7, 41);
=======
            this.lblY.Location = new System.Drawing.Point(2, 41);
>>>>>>> develop
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Y:";
            // 
            // maskedTxtBxX
            // 
            this.maskedTxtBxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.maskedTxtBxX.Location = new System.Drawing.Point(30, 12);
=======
            this.maskedTxtBxX.Location = new System.Drawing.Point(20, 12);
>>>>>>> develop
            this.maskedTxtBxX.Mask = "##9";
            this.maskedTxtBxX.Name = "maskedTxtBxX";
            this.maskedTxtBxX.Size = new System.Drawing.Size(27, 20);
            this.maskedTxtBxX.TabIndex = 5;
<<<<<<< HEAD
=======
            this.toolTipBedCorner.SetToolTip(this.maskedTxtBxX, "X for bed coener");
>>>>>>> develop
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
<<<<<<< HEAD
            this.lblX.Location = new System.Drawing.Point(7, 15);
=======
            this.lblX.Location = new System.Drawing.Point(3, 15);
>>>>>>> develop
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // maskedTxtBxY
            // 
            this.maskedTxtBxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.maskedTxtBxY.Location = new System.Drawing.Point(30, 38);
=======
            this.maskedTxtBxY.Location = new System.Drawing.Point(20, 38);
>>>>>>> develop
            this.maskedTxtBxY.Mask = "##9";
            this.maskedTxtBxY.Name = "maskedTxtBxY";
            this.maskedTxtBxY.Size = new System.Drawing.Size(27, 20);
            this.maskedTxtBxY.TabIndex = 6;
<<<<<<< HEAD
=======
            this.toolTipBedCorner.SetToolTip(this.maskedTxtBxY, "Y for bed coener");
>>>>>>> develop
            // 
            // BedCornerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBxBedControl);
<<<<<<< HEAD
            this.MaximumSize = new System.Drawing.Size(178, 65);
            this.MinimumSize = new System.Drawing.Size(178, 65);
            this.Name = "BedCornerControl";
            this.Size = new System.Drawing.Size(178, 65);
=======
            this.MaximumSize = new System.Drawing.Size(195, 65);
            this.MinimumSize = new System.Drawing.Size(195, 65);
            this.Name = "BedCornerControl";
            this.Size = new System.Drawing.Size(195, 65);
>>>>>>> develop
            this.grpBxBedControl.ResumeLayout(false);
            this.grpBxBedControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxBedControl;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSight;
=======
        private System.Windows.Forms.Button btnGoto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPin;
>>>>>>> develop
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.MaskedTextBox maskedTxtBxY;
<<<<<<< HEAD
=======
        private System.Windows.Forms.ToolTip toolTipBedCorner;
>>>>>>> develop
    }
}
