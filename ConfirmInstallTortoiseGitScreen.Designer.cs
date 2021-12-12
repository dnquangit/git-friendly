
namespace GitApp
{
    partial class ConfirmInstallTortoiseGitScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxWarningInstallTortoiseGit = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make sure that you have already installed tortoisegit.";
            // 
            // checkboxWarningInstallTortoiseGit
            // 
            this.checkboxWarningInstallTortoiseGit.AutoSize = true;
            this.checkboxWarningInstallTortoiseGit.Location = new System.Drawing.Point(113, 35);
            this.checkboxWarningInstallTortoiseGit.Name = "checkboxWarningInstallTortoiseGit";
            this.checkboxWarningInstallTortoiseGit.Size = new System.Drawing.Size(153, 17);
            this.checkboxWarningInstallTortoiseGit.TabIndex = 1;
            this.checkboxWarningInstallTortoiseGit.Text = "Don\'t see this waring again";
            this.checkboxWarningInstallTortoiseGit.UseVisualStyleBackColor = true;
            this.checkboxWarningInstallTortoiseGit.CheckedChanged += new System.EventHandler(this.checkboxWarningInstallTortoiseGit_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(191, 65);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ConfirmInstallTortoisegit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 100);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.checkboxWarningInstallTortoiseGit);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmInstallTortoisegit";
            this.Text = "Waring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxWarningInstallTortoiseGit;
        private System.Windows.Forms.Button btnOk;
    }
}