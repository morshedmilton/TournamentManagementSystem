namespace Tournament_Management_System.View
{
    partial class AdminDashboard
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
            this.manageTournamentsButton = new System.Windows.Forms.Button();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.manageGamesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageTournamentsButton
            // 
            this.manageTournamentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageTournamentsButton.Location = new System.Drawing.Point(269, 185);
            this.manageTournamentsButton.Name = "manageTournamentsButton";
            this.manageTournamentsButton.Size = new System.Drawing.Size(423, 80);
            this.manageTournamentsButton.TabIndex = 0;
            this.manageTournamentsButton.Text = "Manage Tournaments & Matches";
            this.manageTournamentsButton.UseVisualStyleBackColor = true;
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersButton.Location = new System.Drawing.Point(269, 333);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(423, 80);
            this.manageUsersButton.TabIndex = 1;
            this.manageUsersButton.Text = "Manage Users & Teams";
            this.manageUsersButton.UseVisualStyleBackColor = true;
            // 
            // manageGamesButton
            // 
            this.manageGamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageGamesButton.Location = new System.Drawing.Point(269, 475);
            this.manageGamesButton.Name = "manageGamesButton";
            this.manageGamesButton.Size = new System.Drawing.Size(423, 80);
            this.manageGamesButton.TabIndex = 2;
            this.manageGamesButton.Text = "Manage Games";
            this.manageGamesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome, Admin";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(40, 621);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(169, 57);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 710);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manageGamesButton);
            this.Controls.Add(this.manageUsersButton);
            this.Controls.Add(this.manageTournamentsButton);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageTournamentsButton;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.Button manageGamesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutButton;
    }
}