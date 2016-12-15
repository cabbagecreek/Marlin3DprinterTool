using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MarlinAutomaticUpdate.MarlinAutomaticUpdateHelper;

namespace MarlinAutomaticUpdate
{
    public partial class DownloadConfirm : Form
    {

        #region The private fields
        List<DownloadFileInfo> downloadFileList = null;
        #endregion


        #region The constructor of DownloadConfirm
        public DownloadConfirm(List<DownloadFileInfo> downloadfileList)
        {
            InitializeComponent();

            downloadFileList = downloadfileList;
        }
        #endregion

        #region The private method
        private void OnLoad(object sender, EventArgs e)
        {
            foreach (DownloadFileInfo file in this.downloadFileList)
            {
                ListViewItem item = new ListViewItem(new string[] { file.FileName, file.LastVer, file.Size.ToString() });
            }

            this.Activate();
            this.Focus();
        }
        #endregion
    }
}
