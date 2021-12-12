
namespace GitApp
{
    partial class MainScreen
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
            this.btnSwitchBranch = new System.Windows.Forms.Button();
            this.txtLogging = new System.Windows.Forms.RichTextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.Source = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPull = new System.Windows.Forms.Button();
            this.labelCurrentBranch = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnShowAllBranch = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.btnAddBranch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwitchBranch
            // 
            this.btnSwitchBranch.Location = new System.Drawing.Point(12, 119);
            this.btnSwitchBranch.Name = "btnSwitchBranch";
            this.btnSwitchBranch.Size = new System.Drawing.Size(104, 23);
            this.btnSwitchBranch.TabIndex = 0;
            this.btnSwitchBranch.Text = "Switch Branch";
            this.btnSwitchBranch.UseVisualStyleBackColor = true;
            this.btnSwitchBranch.Click += new System.EventHandler(this.btnSwitchBranch_Click);
            // 
            // txtLogging
            // 
            this.txtLogging.Location = new System.Drawing.Point(12, 336);
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.Size = new System.Drawing.Size(715, 278);
            this.txtLogging.TabIndex = 1;
            this.txtLogging.Text = "";
            this.txtLogging.TextChanged += new System.EventHandler(this.txtLogging_TextChanged);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(249, 122);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(478, 20);
            this.txtBranch.TabIndex = 2;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(623, 238);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(104, 23);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(623, 209);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(104, 23);
            this.btnCommit.TabIndex = 4;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(652, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(249, 30);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(478, 20);
            this.txtSource.TabIndex = 6;
            this.txtSource.Leave += new System.EventHandler(this.txtSource_Leave);
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Location = new System.Drawing.Point(686, 9);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(41, 13);
            this.Source.TabIndex = 7;
            this.Source.Text = "Source";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(12, 209);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(104, 23);
            this.btnPull.TabIndex = 9;
            this.btnPull.Text = "Pull";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // labelCurrentBranch
            // 
            this.labelCurrentBranch.AutoSize = true;
            this.labelCurrentBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentBranch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCurrentBranch.Location = new System.Drawing.Point(12, 182);
            this.labelCurrentBranch.Name = "labelCurrentBranch";
            this.labelCurrentBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelCurrentBranch.Size = new System.Drawing.Size(92, 13);
            this.labelCurrentBranch.TabIndex = 10;
            this.labelCurrentBranch.Text = "Current Branch";
            this.labelCurrentBranch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnShowAllBranch
            // 
            this.btnShowAllBranch.Location = new System.Drawing.Point(12, 71);
            this.btnShowAllBranch.Name = "btnShowAllBranch";
            this.btnShowAllBranch.Size = new System.Drawing.Size(104, 23);
            this.btnShowAllBranch.TabIndex = 12;
            this.btnShowAllBranch.Text = "Show All Branch";
            this.btnShowAllBranch.UseVisualStyleBackColor = true;
            this.btnShowAllBranch.Click += new System.EventHandler(this.btnShowAllBranch_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCommand.Location = new System.Drawing.Point(249, 283);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(478, 20);
            this.txtCommand.TabIndex = 13;
            // 
            // btnShowLog
            // 
            this.btnShowLog.Location = new System.Drawing.Point(12, 238);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(104, 23);
            this.btnShowLog.TabIndex = 14;
            this.btnShowLog.Text = "ShowLog";
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // btnAddBranch
            // 
            this.btnAddBranch.Location = new System.Drawing.Point(12, 145);
            this.btnAddBranch.Name = "btnAddBranch";
            this.btnAddBranch.Size = new System.Drawing.Size(104, 23);
            this.btnAddBranch.TabIndex = 15;
            this.btnAddBranch.Text = "Add New Branch";
            this.btnAddBranch.UseVisualStyleBackColor = true;
            this.btnAddBranch.Click += new System.EventHandler(this.btnAddBranch_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 626);
            this.Controls.Add(this.btnAddBranch);
            this.Controls.Add(this.btnShowLog);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnShowAllBranch);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelCurrentBranch);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtLogging);
            this.Controls.Add(this.btnSwitchBranch);
            this.Name = "MainScreen";
            this.Text = "Git Friendly";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchBranch;
        private System.Windows.Forms.RichTextBox txtLogging;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Label labelCurrentBranch;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnShowAllBranch;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Button btnAddBranch;
    }
}

