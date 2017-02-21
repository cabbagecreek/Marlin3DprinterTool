namespace ArduinoIDE
{
    partial class MarlinFirmware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarlinFirmware));
            this.txtBxLength = new System.Windows.Forms.TextBox();
            this.txtBxCreationTime = new System.Windows.Forms.TextBox();
            this.txtBxLastAceess = new System.Windows.Forms.TextBox();
            this.txtBxLastWrite = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lblLastAceess = new System.Windows.Forms.Label();
            this.lblLastWrite = new System.Windows.Forms.Label();
            this.newLastWrite = new ArduinoIDE.New();
            this.newLastAceess = new ArduinoIDE.New();
            this.newCreationTime = new ArduinoIDE.New();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxLength
            // 
            this.txtBxLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxLength.Location = new System.Drawing.Point(363, 26);
            this.txtBxLength.Name = "txtBxLength";
            this.txtBxLength.ReadOnly = true;
            this.txtBxLength.Size = new System.Drawing.Size(100, 20);
            this.txtBxLength.TabIndex = 0;
            // 
            // txtBxCreationTime
            // 
            this.txtBxCreationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxCreationTime.Location = new System.Drawing.Point(363, 52);
            this.txtBxCreationTime.Name = "txtBxCreationTime";
            this.txtBxCreationTime.ReadOnly = true;
            this.txtBxCreationTime.Size = new System.Drawing.Size(100, 20);
            this.txtBxCreationTime.TabIndex = 1;
            // 
            // txtBxLastAceess
            // 
            this.txtBxLastAceess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxLastAceess.Location = new System.Drawing.Point(363, 78);
            this.txtBxLastAceess.Name = "txtBxLastAceess";
            this.txtBxLastAceess.ReadOnly = true;
            this.txtBxLastAceess.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastAceess.TabIndex = 2;
            // 
            // txtBxLastWrite
            // 
            this.txtBxLastWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxLastWrite.Location = new System.Drawing.Point(363, 104);
            this.txtBxLastWrite.Name = "txtBxLastWrite";
            this.txtBxLastWrite.ReadOnly = true;
            this.txtBxLastWrite.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastWrite.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(343, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Read Only";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.ReadOnly = true;
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ShowLineNumbers = false;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(263, 122);
            this.fastColoredTextBox1.TabIndex = 5;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // lblLength
            // 
            this.lblLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(327, 29);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(30, 13);
            this.lblLength.TabIndex = 6;
            this.lblLength.Text = "Size:";
            this.lblLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Location = new System.Drawing.Point(282, 55);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(75, 13);
            this.lblCreationTime.TabIndex = 7;
            this.lblCreationTime.Text = "Creation Time:";
            // 
            // lblLastAceess
            // 
            this.lblLastAceess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastAceess.AutoSize = true;
            this.lblLastAceess.Location = new System.Drawing.Point(289, 81);
            this.lblLastAceess.Name = "lblLastAceess";
            this.lblLastAceess.Size = new System.Drawing.Size(68, 13);
            this.lblLastAceess.TabIndex = 8;
            this.lblLastAceess.Text = "Last Aceess:";
            // 
            // lblLastWrite
            // 
            this.lblLastWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastWrite.AutoSize = true;
            this.lblLastWrite.Location = new System.Drawing.Point(302, 107);
            this.lblLastWrite.Name = "lblLastWrite";
            this.lblLastWrite.Size = new System.Drawing.Size(55, 13);
            this.lblLastWrite.TabIndex = 9;
            this.lblLastWrite.Text = "Last Write";
            // 
            // newLastWrite
            // 
            this.newLastWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newLastWrite.Location = new System.Drawing.Point(470, 104);
            this.newLastWrite.Name = "newLastWrite";
            this.newLastWrite.NewDate = new System.DateTime(((long)(0)));
            this.newLastWrite.Olddate = new System.DateTime(((long)(0)));
            this.newLastWrite.Size = new System.Drawing.Size(20, 20);
            this.newLastWrite.TabIndex = 12;
            // 
            // newLastAceess
            // 
            this.newLastAceess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newLastAceess.Location = new System.Drawing.Point(470, 81);
            this.newLastAceess.Name = "newLastAceess";
            this.newLastAceess.NewDate = new System.DateTime(((long)(0)));
            this.newLastAceess.Olddate = new System.DateTime(((long)(0)));
            this.newLastAceess.Size = new System.Drawing.Size(20, 20);
            this.newLastAceess.TabIndex = 11;
            // 
            // newCreationTime
            // 
            this.newCreationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newCreationTime.Location = new System.Drawing.Point(470, 52);
            this.newCreationTime.Name = "newCreationTime";
            this.newCreationTime.NewDate = new System.DateTime(((long)(0)));
            this.newCreationTime.Olddate = new System.DateTime(((long)(0)));
            this.newCreationTime.Size = new System.Drawing.Size(20, 20);
            this.newCreationTime.TabIndex = 10;
            // 
            // MarlinFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newLastWrite);
            this.Controls.Add(this.newLastAceess);
            this.Controls.Add(this.newCreationTime);
            this.Controls.Add(this.lblLastWrite);
            this.Controls.Add(this.lblLastAceess);
            this.Controls.Add(this.lblCreationTime);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtBxLastWrite);
            this.Controls.Add(this.txtBxLastAceess);
            this.Controls.Add(this.txtBxCreationTime);
            this.Controls.Add(this.txtBxLength);
            this.MinimumSize = new System.Drawing.Size(500, 130);
            this.Name = "MarlinFirmware";
            this.Size = new System.Drawing.Size(500, 130);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxLength;
        private System.Windows.Forms.TextBox txtBxCreationTime;
        private System.Windows.Forms.TextBox txtBxLastAceess;
        private System.Windows.Forms.TextBox txtBxLastWrite;
        private System.Windows.Forms.CheckBox checkBox1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label lblLastAceess;
        private System.Windows.Forms.Label lblLastWrite;
        private New newCreationTime;
        private New newLastAceess;
        private New newLastWrite;
    }
}
