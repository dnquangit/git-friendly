using System.Windows.Forms;

namespace GitApp
{
    public partial class ConfirmInstallTortoiseGitScreen : Form
    {
        public bool NotWaringTortoiseGit = true;
        public ConfirmInstallTortoiseGitScreen()
        {
            InitializeComponent();
        }

        private void checkboxWarningInstallTortoiseGit_CheckedChanged(object sender, System.EventArgs e)
        {
            this.NotWaringTortoiseGit = this.checkboxWarningInstallTortoiseGit.Checked;
        }

        private void btnOk_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
