
namespace GitApp
{
    partial class AddNewBranchScreen
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
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBoxSwitchToNewBranch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(117, 15);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(558, 20);
            this.txtBranchName.TabIndex = 1;
            this.txtBranchName.TextChanged += new System.EventHandler(this.txtBranchName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Branch Name";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(510, 72);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkBoxSwitchToNewBranch
            // 
            this.checkBoxSwitchToNewBranch.AutoSize = true;
            this.checkBoxSwitchToNewBranch.Location = new System.Drawing.Point(117, 41);
            this.checkBoxSwitchToNewBranch.Name = "checkBoxSwitchToNewBranch";
            this.checkBoxSwitchToNewBranch.Size = new System.Drawing.Size(129, 17);
            this.checkBoxSwitchToNewBranch.TabIndex = 5;
            this.checkBoxSwitchToNewBranch.Text = "Switch to new branch";
            this.checkBoxSwitchToNewBranch.UseVisualStyleBackColor = true;
            this.checkBoxSwitchToNewBranch.CheckedChanged += new System.EventHandler(this.checkBoxSwitchToNewBranch_CheckedChanged);
            // 
            // AddNewBranchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 107);
            this.Controls.Add(this.checkBoxSwitchToNewBranch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBranchName);
            this.Name = "AddNewBranchScreen";
            this.Text = "Add New Branch";
            this.Load += new System.EventHandler(this.AddNewBranchScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox checkBoxSwitchToNewBranch;
    }
}