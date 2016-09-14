using System.ComponentModel;
using System.Windows.Forms;

namespace MarlinComunicationHelper
{
    partial class FrmShowCommunication
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowCommunication));
            this.btnClearResponces = new System.Windows.Forms.Button();
            this.chkBxNeverClear = new System.Windows.Forms.CheckBox();
            this.btnCopyToClipBoard = new System.Windows.Forms.Button();
            this.fastColoredTextMarlinCommunication = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextMarlinCommunication)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearResponces
            // 
            this.btnClearResponces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearResponces.Location = new System.Drawing.Point(531, 396);
            this.btnClearResponces.Name = "btnClearResponces";
            this.btnClearResponces.Size = new System.Drawing.Size(125, 25);
            this.btnClearResponces.TabIndex = 17;
            this.btnClearResponces.Text = "Clear Responces";
            this.btnClearResponces.UseVisualStyleBackColor = true;
            this.btnClearResponces.Click += new System.EventHandler(this.btnClearResponces_Click);
            // 
            // chkBxNeverClear
            // 
            this.chkBxNeverClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBxNeverClear.AutoSize = true;
            this.chkBxNeverClear.Checked = true;
            this.chkBxNeverClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxNeverClear.Location = new System.Drawing.Point(443, 402);
            this.chkBxNeverClear.Name = "chkBxNeverClear";
            this.chkBxNeverClear.Size = new System.Drawing.Size(82, 17);
            this.chkBxNeverClear.TabIndex = 16;
            this.chkBxNeverClear.Text = "Never Clear";
            this.chkBxNeverClear.UseVisualStyleBackColor = true;
            this.chkBxNeverClear.CheckedChanged += new System.EventHandler(this.chkBxNeverClear_CheckedChanged);
            // 
            // btnCopyToClipBoard
            // 
            this.btnCopyToClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToClipBoard.Location = new System.Drawing.Point(662, 395);
            this.btnCopyToClipBoard.Name = "btnCopyToClipBoard";
            this.btnCopyToClipBoard.Size = new System.Drawing.Size(163, 26);
            this.btnCopyToClipBoard.TabIndex = 15;
            this.btnCopyToClipBoard.Text = "Copy To Clipboard";
            this.btnCopyToClipBoard.UseVisualStyleBackColor = true;
            this.btnCopyToClipBoard.Click += new System.EventHandler(this.btnCopyToClipBoard_Click);
            // 
            // fastColoredTextMarlinCommunication
            // 
            this.fastColoredTextMarlinCommunication.AutoCompleteBracketsList = new char[] {
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
            this.fastColoredTextMarlinCommunication.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextMarlinCommunication.BackBrush = null;
            this.fastColoredTextMarlinCommunication.CharHeight = 14;
            this.fastColoredTextMarlinCommunication.CharWidth = 8;
            this.fastColoredTextMarlinCommunication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextMarlinCommunication.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextMarlinCommunication.IsReplaceMode = false;
            this.fastColoredTextMarlinCommunication.Location = new System.Drawing.Point(6, 12);
            this.fastColoredTextMarlinCommunication.Name = "fastColoredTextMarlinCommunication";
            this.fastColoredTextMarlinCommunication.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextMarlinCommunication.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextMarlinCommunication.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextMarlinCommunication.ServiceColors")));
            this.fastColoredTextMarlinCommunication.Size = new System.Drawing.Size(819, 377);
            this.fastColoredTextMarlinCommunication.TabIndex = 18;
            this.fastColoredTextMarlinCommunication.Zoom = 100;
            // 
            // FrmShowCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 431);
            this.Controls.Add(this.fastColoredTextMarlinCommunication);
            this.Controls.Add(this.btnClearResponces);
            this.Controls.Add(this.chkBxNeverClear);
            this.Controls.Add(this.btnCopyToClipBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "FrmShowCommunication";
            this.Text = "Show Communication";
            this.Load += new System.EventHandler(this.FrmShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextMarlinCommunication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClearResponces;
        private CheckBox chkBxNeverClear;
        private Button btnCopyToClipBoard;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextMarlinCommunication;
    }
}