using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace GitApp
{
    public partial class MainScreen : Form
    {
        Boolean notConfirmInstallTortoiseGit = false;
        String source = "";
        String currentBranch = "";
        GitManager gitManager = null;
        String gitBatDirectory = "";

        public MainScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.HideAll();
            this.txtLogging.ReadOnly = true;

            this.source = ConfigurationManager.AppSettings["Source"];
            this.gitBatDirectory = ConfigurationManager.AppSettings["GitBatDirectory"];
            this.notConfirmInstallTortoiseGit = 
                Boolean.Parse(ConfigurationManager.AppSettings["NotConfirmInstallTortoiseGit"]);
            this.txtSource.Text = source;
        }

        public void HideAll() {
            this.txtBranch.Enabled = false;
            this.btnSwitchBranch.Enabled = false;
            this.btnPush.Enabled = false;
            this.btnPull.Enabled = false;
            this.btnCommit.Enabled = false;
            this.btnClear.Enabled = false;
            this.btnStop.Enabled = false;
            this.btnShowAllBranch.Enabled = false;
            this.btnShowLog.Enabled = false;
            this.btnAddBranch.Enabled = false;
            this.txtBranch.Clear();
            this.txtLogging.Clear();
            this.txtCommand.Clear();
            this.labelCurrentBranch.Text = "CurrentBranch:";
        }

        public void ShowAll()
        {
            this.txtBranch.Enabled = true;
            this.btnSwitchBranch.Enabled = true;
            this.btnPush.Enabled = true;
            this.btnPull.Enabled = true;
            this.btnCommit.Enabled = true;
            this.btnClear.Enabled = true;
            this.btnStop.Enabled = true;
            this.btnStart.Enabled = true;
            this.btnShowAllBranch.Enabled = true;
            this.btnShowLog.Enabled = true;
            this.btnAddBranch.Enabled = true;
        }

        private void btnSwitchBranch_Click(object sender, EventArgs e)
        {
            String statement = "";
            String error = "";
            this.gitManager.SwitchBranch(this.txtBranch.Text.Trim(), out statement, out error);
            this.txtCommand.Text = StatementGit.SwitchBranch.Replace("&branch-name", this.txtBranch.Text.Trim());

            this.txtLogging.AppendText(statement);
            this.txtLogging.AppendText(error);

            this.currentBranch = this.gitManager.GetCurrentBranch();
            this.labelCurrentBranch.Text = "CurrentBranch: " + this.currentBranch;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtLogging.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.txtSource.Text == "") return;
            gitManager = new GitManager(this.txtSource.Text, gitBatDirectory);
            if (gitManager.GetCurrentBranch() == "") {
                string message = "Your folder doesn't exist or contain git repo.";
                string title = "Error";
                MessageBox.Show(message, title);

                return;
            }

            this.ShowAll();
            this.btnStart.Enabled = false;
            this.currentBranch = gitManager.GetCurrentBranch();
            this.labelCurrentBranch.Text = "CurrentBranch: " + this.currentBranch;
            this.txtBranch.Text = this.currentBranch;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.HideAll();
            this.btnStart.Enabled = true;
        }

        private void btnShowAllBranch_Click(object sender, EventArgs e)
        {
            string statement;
            string error;
            this.gitManager.GetAllBranch(out statement, out error);
            this.txtLogging.AppendText(statement);
            this.txtLogging.AppendText(error);
            this.txtCommand.Text = StatementGit.ShowAllBranch;
        }

        private void btnPull_Click(object sender, EventArgs e)
        {
            String statement = "";
            String error = "";
            this.gitManager.PullBranch(this.gitManager.GetCurrentBranch(), out statement, out error);
            this.txtLogging.AppendText(statement);
            this.txtLogging.AppendText(error);
            this.txtCommand.Text = StatementGit.PullBranch.Replace("&branch-name", this.currentBranch);
        }

        private void txtSource_Leave(object sender, EventArgs e)
        {
            this.source = this.txtSource.Text;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            String statement = "";
            String error = "";
            this.gitManager.PushBranch(this.gitManager.GetCurrentBranch(), out statement, out error);
            this.txtLogging.AppendText(statement);
            this.txtLogging.AppendText(error);
            this.txtCommand.Text = StatementGit.PushBranchUpStream.Replace("&branch-name", this.currentBranch);
            this.gitManager.ShowLogBranch();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (!notConfirmInstallTortoiseGit)
            {
                ConfirmInstallTortoiseGitScreen confirmInstallScreen = new ConfirmInstallTortoiseGitScreen();
                DialogResult dr = confirmInstallScreen.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    notConfirmInstallTortoiseGit = confirmInstallScreen.NotWaringTortoiseGit;
                    AppConfigExtension.UpdateSetting("NotConfirmInstallTortoiseGit", notConfirmInstallTortoiseGit.ToString());
                    confirmInstallScreen.Close();
                }
            }
            this.gitManager.CommitBranch();
            this.txtCommand.Text = StatementGit.CommitBranch;
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            if (!notConfirmInstallTortoiseGit) 
            {
                ConfirmInstallTortoiseGitScreen confirmInstallScreen = new ConfirmInstallTortoiseGitScreen();
                DialogResult dr = confirmInstallScreen.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    notConfirmInstallTortoiseGit = confirmInstallScreen.NotWaringTortoiseGit;
                    AppConfigExtension.UpdateSetting("NotConfirmInstallTortoiseGit", notConfirmInstallTortoiseGit.ToString());
                    confirmInstallScreen.Close();
                }
            }

            String statement = "";
            String error = "";
            this.gitManager.ShowLogBranch();
            this.txtLogging.AppendText(statement);
            this.txtLogging.AppendText(error);
            this.txtCommand.Text = StatementGit.LogBranch;
        }

        private void txtLogging_TextChanged(object sender, EventArgs e)
        {
            txtLogging.SelectionStart = txtLogging.Text.Length;
            txtLogging.ScrollToCaret();
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            AddNewBranchScreen addNewBranchScreen = new AddNewBranchScreen();
            DialogResult dr = addNewBranchScreen.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                addNewBranchScreen.Close();
            }
            else if (dr == DialogResult.OK)
            {
                string addBranchedName = addNewBranchScreen.branchName;
                Boolean switchToBranch = addNewBranchScreen.switchToBranch;
                addNewBranchScreen.Close();
                String statement = "";
                String error = "";

                this.gitManager.AddNewBranch(addBranchedName, out statement, out error);
                this.txtLogging.AppendText(statement);
                this.txtLogging.AppendText(error);
                this.txtCommand.Text = StatementGit.AddNewBranch.Replace("&branch-name", addBranchedName);

                if (switchToBranch) 
                {
                    this.gitManager.SwitchBranch(addBranchedName, out statement, out error);
                    this.txtLogging.AppendText(statement);
                    this.txtLogging.AppendText(error);
                }

                this.currentBranch = this.gitManager.GetCurrentBranch();
                this.labelCurrentBranch.Text = "CurrentBranch: " + this.currentBranch;
            }
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppConfigExtension.UpdateSetting("Source", this.source);
        }
    }
}
