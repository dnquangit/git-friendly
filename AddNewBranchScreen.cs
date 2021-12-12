using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitApp
{
    public partial class AddNewBranchScreen : Form
    {
        public String branchName = "";
        public Boolean switchToBranch = true;
        public AddNewBranchScreen()
        {
            InitializeComponent();
            this.checkBoxSwitchToNewBranch.Checked = true;
        }

        private void AddNewBranchScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtBranchName_TextChanged(object sender, EventArgs e)
        {
            this.branchName = this.txtBranchName.Text;
        }

        private void checkBoxSwitchToNewBranch_CheckedChanged(object sender, EventArgs e)
        {
            this.switchToBranch = this.checkBoxSwitchToNewBranch.Checked;
        }
    }
}
