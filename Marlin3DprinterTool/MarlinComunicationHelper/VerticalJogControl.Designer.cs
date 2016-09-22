using System.ComponentModel;
using System.Windows.Forms;

namespace MarlinComunicationHelper
{
    partial class VerticalJogControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnMinus100 = new System.Windows.Forms.Button();
            this.btnMinus10 = new System.Windows.Forms.Button();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.btnMinus01 = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPlus01 = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.btnPlus10 = new System.Windows.Forms.Button();
            this.btnPlus100 = new System.Windows.Forms.Button();
            this.panelVerticalJogControl = new System.Windows.Forms.Panel();
            this.lblUnder = new System.Windows.Forms.Label();
            this.lblOver = new System.Windows.Forms.Label();
            this.panelVerticalJogControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinus100
            // 
            this.btnMinus100.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMinus100.Location = new System.Drawing.Point(3, 17);
            this.btnMinus100.Name = "btnMinus100";
            this.btnMinus100.Size = new System.Drawing.Size(41, 23);
            this.btnMinus100.TabIndex = 0;
            this.btnMinus100.Text = "100";
            this.btnMinus100.UseVisualStyleBackColor = false;
            this.btnMinus100.Click += new System.EventHandler(this.btnMinus100_Click);
            // 
            // btnMinus10
            // 
            this.btnMinus10.BackColor = System.Drawing.Color.Turquoise;
            this.btnMinus10.Location = new System.Drawing.Point(3, 40);
            this.btnMinus10.Name = "btnMinus10";
            this.btnMinus10.Size = new System.Drawing.Size(41, 23);
            this.btnMinus10.TabIndex = 1;
            this.btnMinus10.Text = "10";
            this.btnMinus10.UseVisualStyleBackColor = false;
            this.btnMinus10.Click += new System.EventHandler(this.btnMinus10_Click);
            // 
            // btnMinus1
            // 
            this.btnMinus1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMinus1.Location = new System.Drawing.Point(3, 63);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(41, 23);
            this.btnMinus1.TabIndex = 2;
            this.btnMinus1.Text = "1";
            this.btnMinus1.UseVisualStyleBackColor = false;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
            // 
            // btnMinus01
            // 
            this.btnMinus01.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMinus01.Location = new System.Drawing.Point(3, 86);
            this.btnMinus01.Name = "btnMinus01";
            this.btnMinus01.Size = new System.Drawing.Size(41, 23);
            this.btnMinus01.TabIndex = 3;
            this.btnMinus01.Text = "0.1";
            this.btnMinus01.UseVisualStyleBackColor = false;
            this.btnMinus01.Click += new System.EventHandler(this.btnMinus01_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Yellow;
            this.btnZero.Location = new System.Drawing.Point(3, 109);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(41, 23);
            this.btnZero.TabIndex = 4;
            this.btnZero.Text = "Zero";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnPlus01
            // 
            this.btnPlus01.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPlus01.Location = new System.Drawing.Point(3, 132);
            this.btnPlus01.Name = "btnPlus01";
            this.btnPlus01.Size = new System.Drawing.Size(41, 23);
            this.btnPlus01.TabIndex = 5;
            this.btnPlus01.Text = "0.1";
            this.btnPlus01.UseVisualStyleBackColor = false;
            this.btnPlus01.Click += new System.EventHandler(this.btnPlus01_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPlus1.Location = new System.Drawing.Point(3, 155);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(41, 23);
            this.btnPlus1.TabIndex = 6;
            this.btnPlus1.Text = "1";
            this.btnPlus1.UseVisualStyleBackColor = false;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // btnPlus10
            // 
            this.btnPlus10.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPlus10.Location = new System.Drawing.Point(3, 178);
            this.btnPlus10.Name = "btnPlus10";
            this.btnPlus10.Size = new System.Drawing.Size(41, 23);
            this.btnPlus10.TabIndex = 7;
            this.btnPlus10.Text = "10";
            this.btnPlus10.UseVisualStyleBackColor = false;
            this.btnPlus10.Click += new System.EventHandler(this.btnPlus10_Click);
            // 
            // btnPlus100
            // 
            this.btnPlus100.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlus100.Location = new System.Drawing.Point(3, 201);
            this.btnPlus100.Name = "btnPlus100";
            this.btnPlus100.Size = new System.Drawing.Size(41, 23);
            this.btnPlus100.TabIndex = 8;
            this.btnPlus100.Text = "100";
            this.btnPlus100.UseVisualStyleBackColor = false;
            this.btnPlus100.Click += new System.EventHandler(this.btnPlus100_Click);
            // 
            // panelVerticalJogControl
            // 
            this.panelVerticalJogControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVerticalJogControl.Controls.Add(this.lblUnder);
            this.panelVerticalJogControl.Controls.Add(this.btnPlus100);
            this.panelVerticalJogControl.Controls.Add(this.lblOver);
            this.panelVerticalJogControl.Controls.Add(this.btnPlus10);
            this.panelVerticalJogControl.Controls.Add(this.btnMinus100);
            this.panelVerticalJogControl.Controls.Add(this.btnPlus1);
            this.panelVerticalJogControl.Controls.Add(this.btnMinus10);
            this.panelVerticalJogControl.Controls.Add(this.btnPlus01);
            this.panelVerticalJogControl.Controls.Add(this.btnMinus1);
            this.panelVerticalJogControl.Controls.Add(this.btnZero);
            this.panelVerticalJogControl.Controls.Add(this.btnMinus01);
            this.panelVerticalJogControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVerticalJogControl.Location = new System.Drawing.Point(0, 0);
            this.panelVerticalJogControl.Name = "panelVerticalJogControl";
            this.panelVerticalJogControl.Size = new System.Drawing.Size(50, 250);
            this.panelVerticalJogControl.TabIndex = 9;
            // 
            // lblUnder
            // 
            this.lblUnder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUnder.AutoSize = true;
            this.lblUnder.Location = new System.Drawing.Point(23, 229);
            this.lblUnder.Name = "lblUnder";
            this.lblUnder.Size = new System.Drawing.Size(0, 13);
            this.lblUnder.TabIndex = 1;
            this.lblUnder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOver
            // 
            this.lblOver.AutoSize = true;
            this.lblOver.Location = new System.Drawing.Point(21, 1);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(0, 13);
            this.lblOver.TabIndex = 0;
            this.lblOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VerticalJogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelVerticalJogControl);
            this.MaximumSize = new System.Drawing.Size(50, 250);
            this.MinimumSize = new System.Drawing.Size(50, 250);
            this.Name = "VerticalJogControl";
            this.Size = new System.Drawing.Size(50, 250);
            this.panelVerticalJogControl.ResumeLayout(false);
            this.panelVerticalJogControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMinus100;
        private Button btnMinus10;
        private Button btnMinus1;
        private Button btnMinus01;
        private Button btnZero;
        private Button btnPlus01;
        private Button btnPlus1;
        private Button btnPlus10;
        private Button btnPlus100;
        private Panel panelVerticalJogControl;
        private Label lblUnder;
        private Label lblOver;
    }
}
