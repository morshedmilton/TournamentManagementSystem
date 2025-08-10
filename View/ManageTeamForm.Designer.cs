namespace Tournament_Management_System.View
{
    partial class ManageTeamForm
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
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamMembersGroupBox = new System.Windows.Forms.GroupBox();
            this.teamMembersDataGridView = new System.Windows.Forms.DataGridView();
            this.captainActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.removeFromTeamButton = new System.Windows.Forms.Button();
            this.makeCaptainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.teamMembersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersDataGridView)).BeginInit();
            this.captainActionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(300, 48);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(374, 29);
            this.teamNameLabel.TabIndex = 0;
            this.teamNameLabel.Text = "Managing Team: [Team Name]";
            // 
            // teamMembersGroupBox
            // 
            this.teamMembersGroupBox.Controls.Add(this.teamMembersDataGridView);
            this.teamMembersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamMembersGroupBox.Location = new System.Drawing.Point(12, 111);
            this.teamMembersGroupBox.Name = "teamMembersGroupBox";
            this.teamMembersGroupBox.Size = new System.Drawing.Size(684, 477);
            this.teamMembersGroupBox.TabIndex = 1;
            this.teamMembersGroupBox.TabStop = false;
            this.teamMembersGroupBox.Text = "Team Members";
            // 
            // teamMembersDataGridView
            // 
            this.teamMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamMembersDataGridView.Location = new System.Drawing.Point(6, 26);
            this.teamMembersDataGridView.Name = "teamMembersDataGridView";
            this.teamMembersDataGridView.RowHeadersWidth = 51;
            this.teamMembersDataGridView.RowTemplate.Height = 24;
            this.teamMembersDataGridView.Size = new System.Drawing.Size(672, 445);
            this.teamMembersDataGridView.TabIndex = 0;
            // 
            // captainActionsGroupBox
            // 
            this.captainActionsGroupBox.Controls.Add(this.removeFromTeamButton);
            this.captainActionsGroupBox.Controls.Add(this.makeCaptainButton);
            this.captainActionsGroupBox.Controls.Add(this.label1);
            this.captainActionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captainActionsGroupBox.Location = new System.Drawing.Point(753, 111);
            this.captainActionsGroupBox.Name = "captainActionsGroupBox";
            this.captainActionsGroupBox.Size = new System.Drawing.Size(385, 477);
            this.captainActionsGroupBox.TabIndex = 2;
            this.captainActionsGroupBox.TabStop = false;
            this.captainActionsGroupBox.Text = "Captain\'s Actions";
            // 
            // removeFromTeamButton
            // 
            this.removeFromTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromTeamButton.Location = new System.Drawing.Point(87, 299);
            this.removeFromTeamButton.Name = "removeFromTeamButton";
            this.removeFromTeamButton.Size = new System.Drawing.Size(238, 76);
            this.removeFromTeamButton.TabIndex = 2;
            this.removeFromTeamButton.Text = "Remove from Team";
            this.removeFromTeamButton.UseVisualStyleBackColor = true;
            // 
            // makeCaptainButton
            // 
            this.makeCaptainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeCaptainButton.Location = new System.Drawing.Point(87, 168);
            this.makeCaptainButton.Name = "makeCaptainButton";
            this.makeCaptainButton.Size = new System.Drawing.Size(232, 78);
            this.makeCaptainButton.TabIndex = 1;
            this.makeCaptainButton.Text = "Promote to Captain";
            this.makeCaptainButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a player from the list to manage.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 629);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(162, 60);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back to Dashboard";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ManageTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 710);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.captainActionsGroupBox);
            this.Controls.Add(this.teamMembersGroupBox);
            this.Controls.Add(this.teamNameLabel);
            this.Name = "ManageTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage My Team";
            this.teamMembersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersDataGridView)).EndInit();
            this.captainActionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.GroupBox teamMembersGroupBox;
        private System.Windows.Forms.DataGridView teamMembersDataGridView;
        private System.Windows.Forms.GroupBox captainActionsGroupBox;
        private System.Windows.Forms.Button makeCaptainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeFromTeamButton;
        private System.Windows.Forms.Button backButton;
    }
}
