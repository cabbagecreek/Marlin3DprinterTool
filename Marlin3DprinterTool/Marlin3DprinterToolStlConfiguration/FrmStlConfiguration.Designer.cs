namespace Marlin3DprinterToolStlConfiguration
{
    partial class FrmStlConfiguration
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBxInstallingStlThumbnailServer = new System.Windows.Forms.GroupBox();
            this.btnAssociateStlViewer = new System.Windows.Forms.Button();
            this.btnColorStl = new System.Windows.Forms.Button();
            this.btnRestartWindowsFileExplorer = new System.Windows.Forms.Button();
            this.btnUnInstallStlServer = new System.Windows.Forms.Button();
            this.btnInstallStlServer = new System.Windows.Forms.Button();
            this.btnPayPal = new System.Windows.Forms.Button();
            this.grpBxInstallingStlThumbnailServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxInstallingStlThumbnailServer
            // 
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnPayPal);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnAssociateStlViewer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnColorStl);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnRestartWindowsFileExplorer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnUnInstallStlServer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnInstallStlServer);
            this.grpBxInstallingStlThumbnailServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxInstallingStlThumbnailServer.Location = new System.Drawing.Point(0, 0);
            this.grpBxInstallingStlThumbnailServer.Name = "grpBxInstallingStlThumbnailServer";
            this.grpBxInstallingStlThumbnailServer.Size = new System.Drawing.Size(428, 247);
            this.grpBxInstallingStlThumbnailServer.TabIndex = 7;
            this.grpBxInstallingStlThumbnailServer.TabStop = false;
            this.grpBxInstallingStlThumbnailServer.Text = "Installing the STL thumbnail Shell Extension";
            // 
            // btnAssociateStlViewer
            // 
            this.btnAssociateStlViewer.Location = new System.Drawing.Point(218, 107);
            this.btnAssociateStlViewer.Name = "btnAssociateStlViewer";
            this.btnAssociateStlViewer.Size = new System.Drawing.Size(195, 23);
            this.btnAssociateStlViewer.TabIndex = 5;
            this.btnAssociateStlViewer.Text = "STL Viewer prefered STL viewer";
            this.btnAssociateStlViewer.UseVisualStyleBackColor = true;
            this.btnAssociateStlViewer.Click += new System.EventHandler(this.btnAssociateStlViewer_Click);
            // 
            // btnColorStl
            // 
            this.btnColorStl.Location = new System.Drawing.Point(218, 35);
            this.btnColorStl.Name = "btnColorStl";
            this.btnColorStl.Size = new System.Drawing.Size(195, 37);
            this.btnColorStl.TabIndex = 14;
            this.btnColorStl.Text = "Color on STL";
            this.btnColorStl.UseVisualStyleBackColor = true;
            this.btnColorStl.Click += new System.EventHandler(this.btnColorStl_Click);
            // 
            // btnRestartWindowsFileExplorer
            // 
            this.btnRestartWindowsFileExplorer.Location = new System.Drawing.Point(218, 78);
            this.btnRestartWindowsFileExplorer.Name = "btnRestartWindowsFileExplorer";
            this.btnRestartWindowsFileExplorer.Size = new System.Drawing.Size(195, 23);
            this.btnRestartWindowsFileExplorer.TabIndex = 5;
            this.btnRestartWindowsFileExplorer.Text = "Restart Windows File Explorer";
            this.btnRestartWindowsFileExplorer.UseVisualStyleBackColor = true;
            this.btnRestartWindowsFileExplorer.Click += new System.EventHandler(this.btnRestartWindowsFileExplorer_Click);
            // 
            // btnUnInstallStlServer
            // 
            this.btnUnInstallStlServer.Location = new System.Drawing.Point(6, 71);
            this.btnUnInstallStlServer.Name = "btnUnInstallStlServer";
            this.btnUnInstallStlServer.Size = new System.Drawing.Size(194, 23);
            this.btnUnInstallStlServer.TabIndex = 3;
            this.btnUnInstallStlServer.Text = "UnInstall and unregister Stl Thumbnail";
            this.btnUnInstallStlServer.UseVisualStyleBackColor = true;
            this.btnUnInstallStlServer.Click += new System.EventHandler(this.btnUnInstallStlServer_Click);
            // 
            // btnInstallStlServer
            // 
            this.btnInstallStlServer.Location = new System.Drawing.Point(6, 42);
            this.btnInstallStlServer.Name = "btnInstallStlServer";
            this.btnInstallStlServer.Size = new System.Drawing.Size(194, 23);
            this.btnInstallStlServer.TabIndex = 0;
            this.btnInstallStlServer.Text = "Install  and Register STL Thumbnail";
            this.btnInstallStlServer.UseVisualStyleBackColor = true;
            this.btnInstallStlServer.Click += new System.EventHandler(this.btnInstallStlServer_Click);
            // 
            // btnPayPal
            // 
            this.btnPayPal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayPal.BackgroundImage = global::Marlin3DprinterToolStlConfiguration.Properties.Resources.Donate;
            this.btnPayPal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayPal.Location = new System.Drawing.Point(257, 163);
            this.btnPayPal.Name = "btnPayPal";
            this.btnPayPal.Size = new System.Drawing.Size(156, 78);
            this.btnPayPal.TabIndex = 19;
            this.btnPayPal.UseVisualStyleBackColor = true;
            this.btnPayPal.Click += new System.EventHandler(this.btnPayPal_Click);
            // 
            // FrmStlConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 247);
            this.Controls.Add(this.grpBxInstallingStlThumbnailServer);
            this.Name = "FrmStlConfiguration";
            this.Text = "Configuration for STL thumbnails in Windows Explorer";
            this.grpBxInstallingStlThumbnailServer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxInstallingStlThumbnailServer;
        private System.Windows.Forms.Button btnAssociateStlViewer;
        private System.Windows.Forms.Button btnColorStl;
        private System.Windows.Forms.Button btnRestartWindowsFileExplorer;
        private System.Windows.Forms.Button btnUnInstallStlServer;
        private System.Windows.Forms.Button btnInstallStlServer;
        private System.Windows.Forms.Button btnPayPal;
    }
}

