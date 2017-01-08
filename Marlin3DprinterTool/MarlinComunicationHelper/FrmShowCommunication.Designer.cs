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
            this.fctbMarlinCommunication = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbBxCommand = new System.Windows.Forms.ComboBox();
            this.chkBxRemoveProcessing = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fctbMarlinCommunication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClearResponces
            // 
            this.btnClearResponces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearResponces.Location = new System.Drawing.Point(220, 233);
            this.btnClearResponces.Name = "btnClearResponces";
            this.btnClearResponces.Size = new System.Drawing.Size(101, 25);
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
            this.chkBxNeverClear.Location = new System.Drawing.Point(132, 236);
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
            this.btnCopyToClipBoard.Location = new System.Drawing.Point(327, 232);
            this.btnCopyToClipBoard.Name = "btnCopyToClipBoard";
            this.btnCopyToClipBoard.Size = new System.Drawing.Size(106, 26);
            this.btnCopyToClipBoard.TabIndex = 15;
            this.btnCopyToClipBoard.Text = "Copy To Clipboard";
            this.btnCopyToClipBoard.UseVisualStyleBackColor = true;
            this.btnCopyToClipBoard.Click += new System.EventHandler(this.btnCopyToClipBoard_Click);
            // 
            // fctbMarlinCommunication
            // 
            this.fctbMarlinCommunication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbMarlinCommunication.AutoCompleteBracketsList = new char[] {
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
            this.fctbMarlinCommunication.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.fctbMarlinCommunication.BackBrush = null;
            this.fctbMarlinCommunication.CharHeight = 14;
            this.fctbMarlinCommunication.CharWidth = 8;
            this.fctbMarlinCommunication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbMarlinCommunication.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbMarlinCommunication.IsReplaceMode = false;
            this.fctbMarlinCommunication.Location = new System.Drawing.Point(6, 12);
            this.fctbMarlinCommunication.Name = "fctbMarlinCommunication";
            this.fctbMarlinCommunication.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbMarlinCommunication.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbMarlinCommunication.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbMarlinCommunication.ServiceColors")));
            this.fctbMarlinCommunication.ShowLineNumbers = false;
            this.fctbMarlinCommunication.Size = new System.Drawing.Size(426, 213);
            this.fctbMarlinCommunication.TabIndex = 18;
            this.fctbMarlinCommunication.Zoom = 100;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(356, 263);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbBxCommand
            // 
            this.cmbBxCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxCommand.FormattingEnabled = true;
            this.cmbBxCommand.Location = new System.Drawing.Point(6, 264);
            this.cmbBxCommand.Name = "cmbBxCommand";
            this.cmbBxCommand.Size = new System.Drawing.Size(344, 21);
            this.cmbBxCommand.TabIndex = 20;
            this.cmbBxCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBxCommand_KeyPress);
            // 
            // chkBxRemoveProcessing
            // 
            this.chkBxRemoveProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBxRemoveProcessing.AutoSize = true;
            this.chkBxRemoveProcessing.Checked = true;
            this.chkBxRemoveProcessing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxRemoveProcessing.Location = new System.Drawing.Point(6, 236);
            this.chkBxRemoveProcessing.Name = "chkBxRemoveProcessing";
            this.chkBxRemoveProcessing.Size = new System.Drawing.Size(120, 17);
            this.chkBxRemoveProcessing.TabIndex = 21;
            this.chkBxRemoveProcessing.Text = "Remove processing";
            this.chkBxRemoveProcessing.UseVisualStyleBackColor = true;
            // 
            // FrmShowCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.chkBxRemoveProcessing);
            this.Controls.Add(this.cmbBxCommand);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.fctbMarlinCommunication);
            this.Controls.Add(this.btnClearResponces);
            this.Controls.Add(this.chkBxNeverClear);
            this.Controls.Add(this.btnCopyToClipBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(460, 300);
            this.Name = "FrmShowCommunication";
            this.Text = "Show Communication";
            this.Load += new System.EventHandler(this.FrmShowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fctbMarlinCommunication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClearResponces;
        private CheckBox chkBxNeverClear;
        private Button btnCopyToClipBoard;
        private FastColoredTextBoxNS.FastColoredTextBox fctbMarlinCommunication;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private ComboBox cmbBxCommand;
        private Button btnSend;
        private CheckBox chkBxRemoveProcessing;
    }
}