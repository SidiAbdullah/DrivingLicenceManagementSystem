namespace DrivingLicenseManagement
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.applicationsToolStripMenuItem.Image = global::DrivingLicenseManagement.Properties.Resources.Applications_64;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(208, 42);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.peopleToolStripMenuItem.Image = global::DrivingLicenseManagement.Properties.Resources.People_400;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(141, 42);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.driversToolStripMenuItem.Image = global::DrivingLicenseManagement.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(144, 42);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usersToolStripMenuItem.Image = global::DrivingLicenseManagement.Properties.Resources.Users_2_400;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(125, 42);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // accountSToolStripMenuItem
            // 
            this.accountSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.accountSToolStripMenuItem.Image = global::DrivingLicenseManagement.Properties.Resources.account_settings_64;
            this.accountSToolStripMenuItem.Name = "accountSToolStripMenuItem";
            this.accountSToolStripMenuItem.Size = new System.Drawing.Size(265, 42);
            this.accountSToolStripMenuItem.Text = "Account Settings";
            // 
            // ptbMain
            // 
            this.ptbMain.BackColor = System.Drawing.Color.Transparent;
            this.ptbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMain.Image = global::DrivingLicenseManagement.Properties.Resources.Logo_Final;
            this.ptbMain.Location = new System.Drawing.Point(0, 48);
            this.ptbMain.Name = "ptbMain";
            this.ptbMain.Size = new System.Drawing.Size(1149, 494);
            this.ptbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbMain.TabIndex = 3;
            this.ptbMain.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1149, 542);
            this.Controls.Add(this.ptbMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Driving License Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptbMain;
    }
}

