namespace Tournament_Management_System.View
{
    partial class PlayerDashboard
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.viewTournamentsButton = new System.Windows.Forms.Button();
            this.viewMyMatchesButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.manageTeamButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(411, 69);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(228, 47);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // viewTournamentsButton
            // 
            this.viewTournamentsButton.Location = new System.Drawing.Point(328, 132);
            this.viewTournamentsButton.Name = "viewTournamentsButton";
            this.viewTournamentsButton.Size = new System.Drawing.Size(311, 60);
            this.viewTournamentsButton.TabIndex = 1;
            this.viewTournamentsButton.Text = "View Tournaments";
            this.viewTournamentsButton.UseVisualStyleBackColor = true;
            // 
            // viewMyMatchesButton
            // 
            this.viewMyMatchesButton.Location = new System.Drawing.Point(328, 222);
            this.viewMyMatchesButton.Name = "viewMyMatchesButton";
            this.viewMyMatchesButton.Size = new System.Drawing.Size(311, 56);
            this.viewMyMatchesButton.TabIndex = 2;
            this.viewMyMatchesButton.Text = "View My Matches/Schedule";
            this.viewMyMatchesButton.UseVisualStyleBackColor = true;
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(328, 299);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(311, 61);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "Profile / Change Password";
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(37, 638);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(155, 41);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.manageTeamButton);
            this.panel1.Controls.Add(this.teamNameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 174);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Team:";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(247, 11);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(85, 16);
            this.teamNameLabel.TabIndex = 1;
            this.teamNameLabel.Text = "Not in a team";
            // 
            // manageTeamButton
            // 
            this.manageTeamButton.Location = new System.Drawing.Point(560, 78);
            this.manageTeamButton.Name = "manageTeamButton";
            this.manageTeamButton.Size = new System.Drawing.Size(134, 42);
            this.manageTeamButton.TabIndex = 2;
            this.manageTeamButton.Text = "Manage Team";
            this.manageTeamButton.UseVisualStyleBackColor = true;
            // 
            // PlayerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.viewMyMatchesButton);
            this.Controls.Add(this.viewTournamentsButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "PlayerDashboard";
            this.Text = "PlayerDashboard";
            this.Load += new System.EventHandler(this.PlayerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button viewTournamentsButton;
        private System.Windows.Forms.Button viewMyMatchesButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageTeamButton;
        private System.Windows.Forms.Label teamNameLabel;
    }
}