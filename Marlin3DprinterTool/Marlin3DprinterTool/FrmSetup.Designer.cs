namespace Marlin3DprinterTool
{
    partial class FrmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetup));
            this.txtBxUnlockKey = new System.Windows.Forms.TextBox();
            this.grpBxLicensedTo = new System.Windows.Forms.GroupBox();
            this.btnPayPal = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBxShowLicence = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBxInstallingStlThumbnailServer = new System.Windows.Forms.GroupBox();
            this.grpBxAssociateStlViewer = new System.Windows.Forms.GroupBox();
            this.btnAssociateStlViewer = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBoxAssociations = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAssemblyPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxServerSecurity = new System.Windows.Forms.TextBox();
            this.textBoxServerCLSID = new System.Windows.Forms.TextBox();
            this.textBoxServerType = new System.Windows.Forms.TextBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnColorStl = new System.Windows.Forms.Button();
            this.btnRestartWindowsFileExplorer = new System.Windows.Forms.Button();
            this.btnResetAndCleanExistingThumbnails = new System.Windows.Forms.Button();
            this.btnTroubleShootStl = new System.Windows.Forms.Button();
            this.grpBxServe32 = new System.Windows.Forms.GroupBox();
            this.lblRegistered32 = new System.Windows.Forms.Label();
            this.lblServer32 = new System.Windows.Forms.Label();
            this.ledRegister32 = new Marlin3DprinterToolUserControls.LedBulb();
            this.ledServer32 = new Marlin3DprinterToolUserControls.LedBulb();
            this.grpBxServe64 = new System.Windows.Forms.GroupBox();
            this.lblRegistered64 = new System.Windows.Forms.Label();
            this.lblServer64 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.ledServer64 = new Marlin3DprinterToolUserControls.LedBulb();
            this.ledRegister64 = new Marlin3DprinterToolUserControls.LedBulb();
            this.chkBx32BitOS = new System.Windows.Forms.CheckBox();
            this.btnUnInstallStlServer = new System.Windows.Forms.Button();
            this.btnInstallStlServer = new System.Windows.Forms.Button();
            this.grpBxLicensedTo.SuspendLayout();
            this.grpBxInstallingStlThumbnailServer.SuspendLayout();
            this.grpBxAssociateStlViewer.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.grpBxServe32.SuspendLayout();
            this.grpBxServe64.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxUnlockKey
            // 
            this.txtBxUnlockKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxUnlockKey.Location = new System.Drawing.Point(6, 19);
            this.txtBxUnlockKey.Multiline = true;
            this.txtBxUnlockKey.Name = "txtBxUnlockKey";
            this.txtBxUnlockKey.Size = new System.Drawing.Size(798, 142);
            this.txtBxUnlockKey.TabIndex = 1;
            this.txtBxUnlockKey.TextChanged += new System.EventHandler(this.txtBxUnlockKey_TextChanged);
            // 
            // grpBxLicensedTo
            // 
            this.grpBxLicensedTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxLicensedTo.Controls.Add(this.btnPayPal);
            this.grpBxLicensedTo.Controls.Add(this.btnSave);
            this.grpBxLicensedTo.Controls.Add(this.txtBxShowLicence);
            this.grpBxLicensedTo.Controls.Add(this.btnCancel);
            this.grpBxLicensedTo.Controls.Add(this.txtBxUnlockKey);
            this.grpBxLicensedTo.Location = new System.Drawing.Point(2, 310);
            this.grpBxLicensedTo.Name = "grpBxLicensedTo";
            this.grpBxLicensedTo.Size = new System.Drawing.Size(810, 281);
            this.grpBxLicensedTo.TabIndex = 2;
            this.grpBxLicensedTo.TabStop = false;
            this.grpBxLicensedTo.Text = "License";
            this.grpBxLicensedTo.Enter += new System.EventHandler(this.grpBxLicensedTo_Enter);
            // 
            // btnPayPal
            // 
            this.btnPayPal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayPal.BackgroundImage = global::Marlin3DprinterTool.Properties.Resources.Donate;
            this.btnPayPal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayPal.Location = new System.Drawing.Point(646, 167);
            this.btnPayPal.Name = "btnPayPal";
            this.btnPayPal.Size = new System.Drawing.Size(156, 78);
            this.btnPayPal.TabIndex = 18;
            this.btnPayPal.UseVisualStyleBackColor = true;
            this.btnPayPal.Click += new System.EventHandler(this.btnPayPal_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(727, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBxShowLicence
            // 
            this.txtBxShowLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxShowLicence.Location = new System.Drawing.Point(6, 167);
            this.txtBxShowLicence.Multiline = true;
            this.txtBxShowLicence.Name = "txtBxShowLicence";
            this.txtBxShowLicence.ReadOnly = true;
            this.txtBxShowLicence.Size = new System.Drawing.Size(636, 108);
            this.txtBxShowLicence.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(646, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpBxInstallingStlThumbnailServer
            // 
            this.grpBxInstallingStlThumbnailServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.grpBxAssociateStlViewer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.groupBox11);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnColorStl);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnRestartWindowsFileExplorer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnResetAndCleanExistingThumbnails);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnTroubleShootStl);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.grpBxServe32);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.grpBxServe64);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.chkBx32BitOS);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnUnInstallStlServer);
            this.grpBxInstallingStlThumbnailServer.Controls.Add(this.btnInstallStlServer);
            this.grpBxInstallingStlThumbnailServer.Location = new System.Drawing.Point(8, 1);
            this.grpBxInstallingStlThumbnailServer.Name = "grpBxInstallingStlThumbnailServer";
            this.grpBxInstallingStlThumbnailServer.Size = new System.Drawing.Size(805, 303);
            this.grpBxInstallingStlThumbnailServer.TabIndex = 5;
            this.grpBxInstallingStlThumbnailServer.TabStop = false;
            this.grpBxInstallingStlThumbnailServer.Text = "Installing the STL thumbnail Shell Extension";
            // 
            // grpBxAssociateStlViewer
            // 
            this.grpBxAssociateStlViewer.Controls.Add(this.btnAssociateStlViewer);
            this.grpBxAssociateStlViewer.Location = new System.Drawing.Point(552, 238);
            this.grpBxAssociateStlViewer.Name = "grpBxAssociateStlViewer";
            this.grpBxAssociateStlViewer.Size = new System.Drawing.Size(244, 56);
            this.grpBxAssociateStlViewer.TabIndex = 5;
            this.grpBxAssociateStlViewer.TabStop = false;
            this.grpBxAssociateStlViewer.Text = "Associate STL viewer";
            // 
            // btnAssociateStlViewer
            // 
            this.btnAssociateStlViewer.Location = new System.Drawing.Point(6, 19);
            this.btnAssociateStlViewer.Name = "btnAssociateStlViewer";
            this.btnAssociateStlViewer.Size = new System.Drawing.Size(232, 23);
            this.btnAssociateStlViewer.TabIndex = 5;
            this.btnAssociateStlViewer.Text = "STL Viewer prefered STL viewer";
            this.btnAssociateStlViewer.UseVisualStyleBackColor = true;
            this.btnAssociateStlViewer.Click += new System.EventHandler(this.btnAssociateStlViewer_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBoxAssociations);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Controls.Add(this.textBoxAssemblyPath);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Controls.Add(this.textBoxServerSecurity);
            this.groupBox11.Controls.Add(this.textBoxServerCLSID);
            this.groupBox11.Controls.Add(this.textBoxServerType);
            this.groupBox11.Controls.Add(this.textBoxServerName);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Location = new System.Drawing.Point(6, 100);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(540, 197);
            this.groupBox11.TabIndex = 15;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Server";
            // 
            // textBoxAssociations
            // 
            this.textBoxAssociations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAssociations.Location = new System.Drawing.Point(128, 161);
            this.textBoxAssociations.Name = "textBoxAssociations";
            this.textBoxAssociations.ReadOnly = true;
            this.textBoxAssociations.Size = new System.Drawing.Size(394, 20);
            this.textBoxAssociations.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Specified Associations";
            // 
            // textBoxAssemblyPath
            // 
            this.textBoxAssemblyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAssemblyPath.Location = new System.Drawing.Point(128, 135);
            this.textBoxAssemblyPath.Name = "textBoxAssemblyPath";
            this.textBoxAssemblyPath.ReadOnly = true;
            this.textBoxAssemblyPath.Size = new System.Drawing.Size(394, 20);
            this.textBoxAssemblyPath.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Assembly Path";
            // 
            // textBoxServerSecurity
            // 
            this.textBoxServerSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerSecurity.Location = new System.Drawing.Point(128, 109);
            this.textBoxServerSecurity.Name = "textBoxServerSecurity";
            this.textBoxServerSecurity.ReadOnly = true;
            this.textBoxServerSecurity.Size = new System.Drawing.Size(394, 20);
            this.textBoxServerSecurity.TabIndex = 7;
            // 
            // textBoxServerCLSID
            // 
            this.textBoxServerCLSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerCLSID.Location = new System.Drawing.Point(128, 83);
            this.textBoxServerCLSID.Name = "textBoxServerCLSID";
            this.textBoxServerCLSID.ReadOnly = true;
            this.textBoxServerCLSID.Size = new System.Drawing.Size(394, 20);
            this.textBoxServerCLSID.TabIndex = 5;
            // 
            // textBoxServerType
            // 
            this.textBoxServerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerType.Location = new System.Drawing.Point(128, 57);
            this.textBoxServerType.Name = "textBoxServerType";
            this.textBoxServerType.ReadOnly = true;
            this.textBoxServerType.Size = new System.Drawing.Size(394, 20);
            this.textBoxServerType.TabIndex = 3;
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServerName.Location = new System.Drawing.Point(128, 31);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.ReadOnly = true;
            this.textBoxServerName.Size = new System.Drawing.Size(394, 20);
            this.textBoxServerName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Security";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Server CLSID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Server Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // btnColorStl
            // 
            this.btnColorStl.Location = new System.Drawing.Point(553, 60);
            this.btnColorStl.Name = "btnColorStl";
            this.btnColorStl.Size = new System.Drawing.Size(237, 37);
            this.btnColorStl.TabIndex = 14;
            this.btnColorStl.Text = "Color on STL";
            this.btnColorStl.UseVisualStyleBackColor = true;
            this.btnColorStl.Click += new System.EventHandler(this.btnColorStl_Click);
            // 
            // btnRestartWindowsFileExplorer
            // 
            this.btnRestartWindowsFileExplorer.Location = new System.Drawing.Point(553, 103);
            this.btnRestartWindowsFileExplorer.Name = "btnRestartWindowsFileExplorer";
            this.btnRestartWindowsFileExplorer.Size = new System.Drawing.Size(237, 23);
            this.btnRestartWindowsFileExplorer.TabIndex = 5;
            this.btnRestartWindowsFileExplorer.Text = "Restart Windows File Explorer";
            this.btnRestartWindowsFileExplorer.UseVisualStyleBackColor = true;
            this.btnRestartWindowsFileExplorer.Click += new System.EventHandler(this.btnRestartWindowsFileExplorer_Click);
            // 
            // btnResetAndCleanExistingThumbnails
            // 
            this.btnResetAndCleanExistingThumbnails.Location = new System.Drawing.Point(553, 134);
            this.btnResetAndCleanExistingThumbnails.Name = "btnResetAndCleanExistingThumbnails";
            this.btnResetAndCleanExistingThumbnails.Size = new System.Drawing.Size(237, 23);
            this.btnResetAndCleanExistingThumbnails.TabIndex = 13;
            this.btnResetAndCleanExistingThumbnails.Text = "Reset and Clean existing Thumbnails";
            this.btnResetAndCleanExistingThumbnails.UseVisualStyleBackColor = true;
            this.btnResetAndCleanExistingThumbnails.Click += new System.EventHandler(this.btnResetAndCleanExistingThumbnails_Click);
            // 
            // btnTroubleShootStl
            // 
            this.btnTroubleShootStl.Location = new System.Drawing.Point(552, 20);
            this.btnTroubleShootStl.Name = "btnTroubleShootStl";
            this.btnTroubleShootStl.Size = new System.Drawing.Size(238, 37);
            this.btnTroubleShootStl.TabIndex = 12;
            this.btnTroubleShootStl.Text = "Troubleshoot Guide";
            this.btnTroubleShootStl.UseVisualStyleBackColor = true;
            this.btnTroubleShootStl.Click += new System.EventHandler(this.btnTroubleShootStl_Click);
            // 
            // grpBxServe32
            // 
            this.grpBxServe32.Controls.Add(this.lblRegistered32);
            this.grpBxServe32.Controls.Add(this.lblServer32);
            this.grpBxServe32.Controls.Add(this.ledRegister32);
            this.grpBxServe32.Controls.Add(this.ledServer32);
            this.grpBxServe32.Location = new System.Drawing.Point(388, 19);
            this.grpBxServe32.Name = "grpBxServe32";
            this.grpBxServe32.Size = new System.Drawing.Size(159, 77);
            this.grpBxServe32.TabIndex = 11;
            this.grpBxServe32.TabStop = false;
            this.grpBxServe32.Text = "32-bit STL Thumbnail Server";
            // 
            // lblRegistered32
            // 
            this.lblRegistered32.AutoSize = true;
            this.lblRegistered32.Location = new System.Drawing.Point(54, 53);
            this.lblRegistered32.Name = "lblRegistered32";
            this.lblRegistered32.Size = new System.Drawing.Size(58, 13);
            this.lblRegistered32.TabIndex = 14;
            this.lblRegistered32.Text = "Registered";
            // 
            // lblServer32
            // 
            this.lblServer32.AutoSize = true;
            this.lblServer32.Location = new System.Drawing.Point(66, 24);
            this.lblServer32.Name = "lblServer32";
            this.lblServer32.Size = new System.Drawing.Size(46, 13);
            this.lblServer32.TabIndex = 14;
            this.lblServer32.Text = "Installed";
            // 
            // ledRegister32
            // 
            this.ledRegister32.Color = System.Drawing.Color.Gray;
            this.ledRegister32.Location = new System.Drawing.Point(118, 42);
            this.ledRegister32.Name = "ledRegister32";
            this.ledRegister32.On = true;
            this.ledRegister32.Size = new System.Drawing.Size(24, 24);
            this.ledRegister32.TabIndex = 9;
            this.ledRegister32.Text = "ledBulb1";
            // 
            // ledServer32
            // 
            this.ledServer32.Color = System.Drawing.Color.Gray;
            this.ledServer32.Location = new System.Drawing.Point(118, 14);
            this.ledServer32.Name = "ledServer32";
            this.ledServer32.On = true;
            this.ledServer32.Size = new System.Drawing.Size(24, 24);
            this.ledServer32.TabIndex = 8;
            this.ledServer32.Text = "ledBulb1";
            // 
            // grpBxServe64
            // 
            this.grpBxServe64.Controls.Add(this.lblRegistered64);
            this.grpBxServe64.Controls.Add(this.lblServer64);
            this.grpBxServe64.Controls.Add(this.groupBox10);
            this.grpBxServe64.Controls.Add(this.ledServer64);
            this.grpBxServe64.Controls.Add(this.ledRegister64);
            this.grpBxServe64.Location = new System.Drawing.Point(225, 19);
            this.grpBxServe64.Name = "grpBxServe64";
            this.grpBxServe64.Size = new System.Drawing.Size(157, 77);
            this.grpBxServe64.TabIndex = 10;
            this.grpBxServe64.TabStop = false;
            this.grpBxServe64.Text = "64-bit STL Thumbnail Server";
            // 
            // lblRegistered64
            // 
            this.lblRegistered64.AutoSize = true;
            this.lblRegistered64.Location = new System.Drawing.Point(52, 55);
            this.lblRegistered64.Name = "lblRegistered64";
            this.lblRegistered64.Size = new System.Drawing.Size(58, 13);
            this.lblRegistered64.TabIndex = 13;
            this.lblRegistered64.Text = "Registered";
            // 
            // lblServer64
            // 
            this.lblServer64.AutoSize = true;
            this.lblServer64.Location = new System.Drawing.Point(64, 24);
            this.lblServer64.Name = "lblServer64";
            this.lblServer64.Size = new System.Drawing.Size(46, 13);
            this.lblServer64.TabIndex = 12;
            this.lblServer64.Text = "Installed";
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(0, 106);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 100);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "groupBox10";
            // 
            // ledServer64
            // 
            this.ledServer64.Color = System.Drawing.Color.Gray;
            this.ledServer64.Location = new System.Drawing.Point(116, 14);
            this.ledServer64.Name = "ledServer64";
            this.ledServer64.On = true;
            this.ledServer64.Size = new System.Drawing.Size(24, 24);
            this.ledServer64.TabIndex = 6;
            this.ledServer64.Text = "ledBulb1";
            // 
            // ledRegister64
            // 
            this.ledRegister64.Color = System.Drawing.Color.Gray;
            this.ledRegister64.Location = new System.Drawing.Point(116, 44);
            this.ledRegister64.Name = "ledRegister64";
            this.ledRegister64.On = true;
            this.ledRegister64.Size = new System.Drawing.Size(24, 24);
            this.ledRegister64.TabIndex = 7;
            this.ledRegister64.Text = "ledBulb1";
            // 
            // chkBx32BitOS
            // 
            this.chkBx32BitOS.AutoSize = true;
            this.chkBx32BitOS.Location = new System.Drawing.Point(14, 19);
            this.chkBx32BitOS.Name = "chkBx32BitOS";
            this.chkBx32BitOS.Size = new System.Drawing.Size(70, 17);
            this.chkBx32BitOS.TabIndex = 4;
            this.chkBx32BitOS.Text = "32-bit OS";
            this.chkBx32BitOS.UseVisualStyleBackColor = true;
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
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(816, 596);
            this.Controls.Add(this.grpBxInstallingStlThumbnailServer);
            this.Controls.Add(this.grpBxLicensedTo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmSetup";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.FrmSetup_Load);
            this.grpBxLicensedTo.ResumeLayout(false);
            this.grpBxLicensedTo.PerformLayout();
            this.grpBxInstallingStlThumbnailServer.ResumeLayout(false);
            this.grpBxInstallingStlThumbnailServer.PerformLayout();
            this.grpBxAssociateStlViewer.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.grpBxServe32.ResumeLayout(false);
            this.grpBxServe32.PerformLayout();
            this.grpBxServe64.ResumeLayout(false);
            this.grpBxServe64.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxUnlockKey;
        private System.Windows.Forms.GroupBox grpBxLicensedTo;
        private System.Windows.Forms.TextBox txtBxShowLicence;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPayPal;
        private System.Windows.Forms.GroupBox grpBxInstallingStlThumbnailServer;
        private System.Windows.Forms.GroupBox grpBxAssociateStlViewer;
        private System.Windows.Forms.Button btnAssociateStlViewer;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBoxAssociations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAssemblyPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxServerSecurity;
        private System.Windows.Forms.TextBox textBoxServerCLSID;
        private System.Windows.Forms.TextBox textBoxServerType;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnColorStl;
        private System.Windows.Forms.Button btnRestartWindowsFileExplorer;
        private System.Windows.Forms.Button btnResetAndCleanExistingThumbnails;
        private System.Windows.Forms.Button btnTroubleShootStl;
        private System.Windows.Forms.GroupBox grpBxServe32;
        private System.Windows.Forms.Label lblRegistered32;
        private System.Windows.Forms.Label lblServer32;
        private Marlin3DprinterToolUserControls.LedBulb ledRegister32;
        private Marlin3DprinterToolUserControls.LedBulb ledServer32;
        private System.Windows.Forms.GroupBox grpBxServe64;
        private System.Windows.Forms.Label lblRegistered64;
        private System.Windows.Forms.Label lblServer64;
        private System.Windows.Forms.GroupBox groupBox10;
        private Marlin3DprinterToolUserControls.LedBulb ledServer64;
        private Marlin3DprinterToolUserControls.LedBulb ledRegister64;
        private System.Windows.Forms.CheckBox chkBx32BitOS;
        private System.Windows.Forms.Button btnUnInstallStlServer;
        private System.Windows.Forms.Button btnInstallStlServer;
    }
}