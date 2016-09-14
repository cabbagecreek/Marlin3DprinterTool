using System.ComponentModel;
using System.Windows.Forms;

namespace MarlinComunicationHelper
{
    partial class KompassControll
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
            this.components = new System.ComponentModel.Container();
            this.btnPlusY10 = new System.Windows.Forms.Button();
            this.btnPlusY1 = new System.Windows.Forms.Button();
            this.btnPlusY01 = new System.Windows.Forms.Button();
            this.btnMinusY01 = new System.Windows.Forms.Button();
            this.btnMinusY1 = new System.Windows.Forms.Button();
            this.btnMinusY10 = new System.Windows.Forms.Button();
            this.btnMinusY1100 = new System.Windows.Forms.Button();
            this.btnPlusX01 = new System.Windows.Forms.Button();
            this.btnPlusX1 = new System.Windows.Forms.Button();
            this.btnPlusX10 = new System.Windows.Forms.Button();
            this.btnPlusX100 = new System.Windows.Forms.Button();
            this.btnMinusX01 = new System.Windows.Forms.Button();
            this.btnMinusX1 = new System.Windows.Forms.Button();
            this.btnMinusX10 = new System.Windows.Forms.Button();
            this.btnMinusX100 = new System.Windows.Forms.Button();
            this.btnPlusY100 = new System.Windows.Forms.Button();
            this.toolTipKompass = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnPlusY10
            // 
            this.btnPlusY10.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPlusY10.Location = new System.Drawing.Point(43, 23);
            this.btnPlusY10.Name = "btnPlusY10";
            this.btnPlusY10.Size = new System.Drawing.Size(160, 20);
            this.btnPlusY10.TabIndex = 1;
            this.btnPlusY10.Text = "+10";
            this.toolTipKompass.SetToolTip(this.btnPlusY10, "Move Y 10mm");
            this.btnPlusY10.UseVisualStyleBackColor = false;
            this.btnPlusY10.Click += new System.EventHandler(this.btnPlusY10_Click);
            // 
            // btnPlusY1
            // 
            this.btnPlusY1.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPlusY1.Location = new System.Drawing.Point(63, 43);
            this.btnPlusY1.Name = "btnPlusY1";
            this.btnPlusY1.Size = new System.Drawing.Size(120, 20);
            this.btnPlusY1.TabIndex = 2;
            this.btnPlusY1.Text = "+1";
            this.toolTipKompass.SetToolTip(this.btnPlusY1, "Move Y 1mm");
            this.btnPlusY1.UseVisualStyleBackColor = false;
            this.btnPlusY1.Click += new System.EventHandler(this.btnPlusY1_Click);
            // 
            // btnPlusY01
            // 
            this.btnPlusY01.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPlusY01.Location = new System.Drawing.Point(83, 63);
            this.btnPlusY01.Name = "btnPlusY01";
            this.btnPlusY01.Size = new System.Drawing.Size(80, 20);
            this.btnPlusY01.TabIndex = 3;
            this.btnPlusY01.Text = "+0.1";
            this.toolTipKompass.SetToolTip(this.btnPlusY01, "Move Y 0.1 mm");
            this.btnPlusY01.UseVisualStyleBackColor = false;
            this.btnPlusY01.Click += new System.EventHandler(this.btnPlusY01_Click);
            // 
            // btnMinusY01
            // 
            this.btnMinusY01.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnMinusY01.Location = new System.Drawing.Point(83, 163);
            this.btnMinusY01.Name = "btnMinusY01";
            this.btnMinusY01.Size = new System.Drawing.Size(80, 20);
            this.btnMinusY01.TabIndex = 4;
            this.btnMinusY01.Text = "-0.1";
            this.toolTipKompass.SetToolTip(this.btnMinusY01, "Move Y 0.1 mm");
            this.btnMinusY01.UseVisualStyleBackColor = false;
            this.btnMinusY01.Click += new System.EventHandler(this.btnMinusY01_Click);
            // 
            // btnMinusY1
            // 
            this.btnMinusY1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMinusY1.Location = new System.Drawing.Point(63, 183);
            this.btnMinusY1.Name = "btnMinusY1";
            this.btnMinusY1.Size = new System.Drawing.Size(120, 20);
            this.btnMinusY1.TabIndex = 5;
            this.btnMinusY1.Text = "-1";
            this.toolTipKompass.SetToolTip(this.btnMinusY1, "Move Y 1mm");
            this.btnMinusY1.UseVisualStyleBackColor = false;
            this.btnMinusY1.Click += new System.EventHandler(this.btnMinusY1_Click);
            // 
            // btnMinusY10
            // 
            this.btnMinusY10.BackColor = System.Drawing.Color.Turquoise;
            this.btnMinusY10.Location = new System.Drawing.Point(43, 203);
            this.btnMinusY10.Name = "btnMinusY10";
            this.btnMinusY10.Size = new System.Drawing.Size(160, 20);
            this.btnMinusY10.TabIndex = 6;
            this.btnMinusY10.Text = "-10";
            this.toolTipKompass.SetToolTip(this.btnMinusY10, "Move Y 10mm");
            this.btnMinusY10.UseVisualStyleBackColor = false;
            this.btnMinusY10.Click += new System.EventHandler(this.btnMinusY10_Click);
            // 
            // btnMinusY1100
            // 
            this.btnMinusY1100.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMinusY1100.Location = new System.Drawing.Point(23, 223);
            this.btnMinusY1100.Name = "btnMinusY1100";
            this.btnMinusY1100.Size = new System.Drawing.Size(200, 20);
            this.btnMinusY1100.TabIndex = 7;
            this.btnMinusY1100.Text = "-100  Y";
            this.toolTipKompass.SetToolTip(this.btnMinusY1100, "Move Y 100mm");
            this.btnMinusY1100.UseVisualStyleBackColor = false;
            this.btnMinusY1100.Click += new System.EventHandler(this.btnMinusY1100_Click);
            // 
            // btnPlusX01
            // 
            this.btnPlusX01.BackColor = System.Drawing.Color.Salmon;
            this.btnPlusX01.Location = new System.Drawing.Point(163, 83);
            this.btnPlusX01.Name = "btnPlusX01";
            this.btnPlusX01.Size = new System.Drawing.Size(20, 80);
            this.btnPlusX01.TabIndex = 8;
            this.btnPlusX01.Text = "0.1";
            this.toolTipKompass.SetToolTip(this.btnPlusX01, "Move X 0.1 mm");
            this.btnPlusX01.UseVisualStyleBackColor = false;
            this.btnPlusX01.Click += new System.EventHandler(this.btnPlusX01_Click);
            // 
            // btnPlusX1
            // 
            this.btnPlusX1.BackColor = System.Drawing.Color.LightCoral;
            this.btnPlusX1.Location = new System.Drawing.Point(183, 63);
            this.btnPlusX1.Name = "btnPlusX1";
            this.btnPlusX1.Size = new System.Drawing.Size(20, 120);
            this.btnPlusX1.TabIndex = 9;
            this.btnPlusX1.Text = "+1";
            this.toolTipKompass.SetToolTip(this.btnPlusX1, "Move X 10mm");
            this.btnPlusX1.UseVisualStyleBackColor = false;
            this.btnPlusX1.Click += new System.EventHandler(this.btnPlusX1_Click);
            // 
            // btnPlusX10
            // 
            this.btnPlusX10.BackColor = System.Drawing.Color.Salmon;
            this.btnPlusX10.Location = new System.Drawing.Point(203, 43);
            this.btnPlusX10.Name = "btnPlusX10";
            this.btnPlusX10.Size = new System.Drawing.Size(20, 160);
            this.btnPlusX10.TabIndex = 10;
            this.btnPlusX10.Text = "+10";
            this.toolTipKompass.SetToolTip(this.btnPlusX10, "Move X 10mm");
            this.btnPlusX10.UseVisualStyleBackColor = false;
            this.btnPlusX10.Click += new System.EventHandler(this.btnPlusX10_Click);
            // 
            // btnPlusX100
            // 
            this.btnPlusX100.BackColor = System.Drawing.Color.Coral;
            this.btnPlusX100.Location = new System.Drawing.Point(223, 23);
            this.btnPlusX100.Name = "btnPlusX100";
            this.btnPlusX100.Size = new System.Drawing.Size(20, 200);
            this.btnPlusX100.TabIndex = 11;
            this.btnPlusX100.Text = "+100  X";
            this.toolTipKompass.SetToolTip(this.btnPlusX100, "Move X 100mm");
            this.btnPlusX100.UseVisualStyleBackColor = false;
            this.btnPlusX100.Click += new System.EventHandler(this.btnPlusX100_Click);
            // 
            // btnMinusX01
            // 
            this.btnMinusX01.BackColor = System.Drawing.Color.Violet;
            this.btnMinusX01.Location = new System.Drawing.Point(63, 83);
            this.btnMinusX01.Name = "btnMinusX01";
            this.btnMinusX01.Size = new System.Drawing.Size(20, 80);
            this.btnMinusX01.TabIndex = 12;
            this.btnMinusX01.Text = "0.1";
            this.toolTipKompass.SetToolTip(this.btnMinusX01, "Move X 0.1 mm");
            this.btnMinusX01.UseVisualStyleBackColor = false;
            this.btnMinusX01.Click += new System.EventHandler(this.btnMinusX01_Click);
            // 
            // btnMinusX1
            // 
            this.btnMinusX1.BackColor = System.Drawing.Color.Orchid;
            this.btnMinusX1.Location = new System.Drawing.Point(43, 63);
            this.btnMinusX1.Name = "btnMinusX1";
            this.btnMinusX1.Size = new System.Drawing.Size(20, 120);
            this.btnMinusX1.TabIndex = 13;
            this.btnMinusX1.Text = "-1";
            this.toolTipKompass.SetToolTip(this.btnMinusX1, "Move X 1mm");
            this.btnMinusX1.UseVisualStyleBackColor = false;
            this.btnMinusX1.Click += new System.EventHandler(this.btnMinusX1_Click);
            // 
            // btnMinusX10
            // 
            this.btnMinusX10.BackColor = System.Drawing.Color.HotPink;
            this.btnMinusX10.Location = new System.Drawing.Point(23, 43);
            this.btnMinusX10.Name = "btnMinusX10";
            this.btnMinusX10.Size = new System.Drawing.Size(20, 160);
            this.btnMinusX10.TabIndex = 14;
            this.btnMinusX10.Text = "-10";
            this.toolTipKompass.SetToolTip(this.btnMinusX10, "Move X 10mm");
            this.btnMinusX10.UseVisualStyleBackColor = false;
            this.btnMinusX10.Click += new System.EventHandler(this.btnMinusX10_Click);
            // 
            // btnMinusX100
            // 
            this.btnMinusX100.BackColor = System.Drawing.Color.Magenta;
            this.btnMinusX100.Location = new System.Drawing.Point(3, 23);
            this.btnMinusX100.Name = "btnMinusX100";
            this.btnMinusX100.Size = new System.Drawing.Size(20, 200);
            this.btnMinusX100.TabIndex = 15;
            this.btnMinusX100.Text = "-100   X";
            this.toolTipKompass.SetToolTip(this.btnMinusX100, "Move X 100mm");
            this.btnMinusX100.UseVisualStyleBackColor = false;
            this.btnMinusX100.Click += new System.EventHandler(this.btnMinusX100_Click);
            // 
            // btnPlusY100
            // 
            this.btnPlusY100.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlusY100.Location = new System.Drawing.Point(23, 3);
            this.btnPlusY100.Name = "btnPlusY100";
            this.btnPlusY100.Size = new System.Drawing.Size(200, 20);
            this.btnPlusY100.TabIndex = 16;
            this.btnPlusY100.Text = "+100  Y";
            this.toolTipKompass.SetToolTip(this.btnPlusY100, "Move Y 100mm ");
            this.btnPlusY100.UseVisualStyleBackColor = false;
            this.btnPlusY100.Click += new System.EventHandler(this.btnPlusY100_Click);
            // 
            // KompassControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlusY100);
            this.Controls.Add(this.btnMinusX100);
            this.Controls.Add(this.btnMinusX10);
            this.Controls.Add(this.btnMinusX1);
            this.Controls.Add(this.btnMinusX01);
            this.Controls.Add(this.btnPlusX100);
            this.Controls.Add(this.btnPlusX10);
            this.Controls.Add(this.btnPlusX1);
            this.Controls.Add(this.btnPlusX01);
            this.Controls.Add(this.btnMinusY1100);
            this.Controls.Add(this.btnMinusY10);
            this.Controls.Add(this.btnMinusY1);
            this.Controls.Add(this.btnMinusY01);
            this.Controls.Add(this.btnPlusY01);
            this.Controls.Add(this.btnPlusY1);
            this.Controls.Add(this.btnPlusY10);
            this.MaximumSize = new System.Drawing.Size(246, 246);
            this.MinimumSize = new System.Drawing.Size(246, 246);
            this.Name = "KompassControll";
            this.Size = new System.Drawing.Size(246, 246);
            this.toolTipKompass.SetToolTip(this, "Move extruder in X and Y directions");
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnPlusY10;
        private Button btnPlusY1;
        private Button btnPlusY01;
        private Button btnMinusY01;
        private Button btnMinusY1;
        private Button btnMinusY10;
        private Button btnMinusY1100;
        private Button btnPlusX01;
        private Button btnPlusX1;
        private Button btnPlusX10;
        private Button btnPlusX100;
        private Button btnMinusX01;
        private Button btnMinusX1;
        private Button btnMinusX10;
        private Button btnMinusX100;
        private Button btnPlusY100;
        private ToolTip toolTipKompass;
    }
}
