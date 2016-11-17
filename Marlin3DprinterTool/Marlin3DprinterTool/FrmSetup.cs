using System;
using System.Windows.Forms;
using MarlinComunicationHelper;

namespace Marlin3DprinterTool
{
    /// <summary>
    /// Form for Setup of License and some other initial stuff
    /// </summary>
    public partial class FrmSetup : Form
    {
        /// <summary>
        /// /Form for Setup of License and some other initial stuff
        /// </summary>
        public FrmSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration();
            config.LicenseKey = txtBxUnlockKey.Text;
            Close();
        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {
            Configuration config = new Configuration();
            txtBxUnlockKey.Text = config.LicenseKey;
            ShowLicense();
        }

        private void ShowLicense()
        {
            if (string.IsNullOrEmpty(txtBxUnlockKey.Text)) return;

            txtBxShowLicence.Text = Configuration.Decrypt(txtBxUnlockKey.Text).Replace(";", Environment.NewLine);
        }

        private void txtBxUnlockKey_TextChanged(object sender, EventArgs e)
        {
            ShowLicense();
        }
    }
}
