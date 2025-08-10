namespace Tournament_Management_System.View
{
    partial class ManageUsersAndTeamsForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deactivateButton = new System.Windows.Forms.Button();
            this.activateButton = new System.Windows.Forms.Button();
            this.selectedPlayerLabel = new System.Windows.Forms.Label();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.teamsTabPage = new System.Windows.Forms.TabPage();
            this.teamMembersGroupBox = new System.Windows.Forms.GroupBox();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.addPlayerIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teamMembersDataGridView = new System.Windows.Forms.DataGridView();
            this.teamDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.clearTeamButton = new System.Windows.Forms.Button();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.updateTeamButton = new System.Windows.Forms.Button();
            this.captainIdTextBox = new System.Windows.Forms.TextBox();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            this.teamsTabPage.SuspendLayout();
            this.teamMembersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersDataGridView)).BeginInit();
            this.teamDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.teamsTabPage);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.ItemSize = new System.Drawing.Size(400, 30);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(6, 5);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1285, 892);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 0;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.groupBox1);
            this.playersTabPage.Controls.Add(this.playersDataGridView);
            this.playersTabPage.Location = new System.Drawing.Point(4, 34);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersTabPage.Size = new System.Drawing.Size(1277, 854);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Manage Players";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deactivateButton);
            this.groupBox1.Controls.Add(this.activateButton);
            this.groupBox1.Controls.Add(this.selectedPlayerLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(752, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 463);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Account Actions";
            // 
            // deactivateButton
            // 
            this.deactivateButton.Location = new System.Drawing.Point(254, 109);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(156, 49);
            this.deactivateButton.TabIndex = 2;
            this.deactivateButton.Text = "Deactivate Account";
            this.deactivateButton.UseVisualStyleBackColor = true;
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(62, 109);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(156, 49);
            this.activateButton.TabIndex = 1;
            this.activateButton.Text = "Activate Account";
            this.activateButton.UseVisualStyleBackColor = true;
            // 
            // selectedPlayerLabel
            // 
            this.selectedPlayerLabel.AutoSize = true;
            this.selectedPlayerLabel.Location = new System.Drawing.Point(18, 58);
            this.selectedPlayerLabel.Name = "selectedPlayerLabel";
            this.selectedPlayerLabel.Size = new System.Drawing.Size(175, 20);
            this.selectedPlayerLabel.TabIndex = 0;
            this.selectedPlayerLabel.Text = "Selected Player: None";
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.RowHeadersWidth = 51;
            this.playersDataGridView.RowTemplate.Height = 24;
            this.playersDataGridView.Size = new System.Drawing.Size(711, 672);
            this.playersDataGridView.TabIndex = 0;
            // 
            // teamsTabPage
            // 
            this.teamsTabPage.Controls.Add(this.teamMembersGroupBox);
            this.teamsTabPage.Controls.Add(this.teamDetailsGroupBox);
            this.teamsTabPage.Controls.Add(this.teamsDataGridView);
            this.teamsTabPage.Controls.Add(this.label1);
            this.teamsTabPage.Location = new System.Drawing.Point(4, 34);
            this.teamsTabPage.Name = "teamsTabPage";
            this.teamsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.teamsTabPage.Size = new System.Drawing.Size(1277, 854);
            this.teamsTabPage.TabIndex = 1;
            this.teamsTabPage.Text = "Manage Teams";
            this.teamsTabPage.UseVisualStyleBackColor = true;
            // 
            // teamMembersGroupBox
            // 
            this.teamMembersGroupBox.Controls.Add(this.removePlayerButton);
            this.teamMembersGroupBox.Controls.Add(this.addPlayerButton);
            this.teamMembersGroupBox.Controls.Add(this.addPlayerIdTextBox);
            this.teamMembersGroupBox.Controls.Add(this.label5);
            this.teamMembersGroupBox.Controls.Add(this.teamMembersDataGridView);
            this.teamMembersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamMembersGroupBox.Location = new System.Drawing.Point(6, 576);
            this.teamMembersGroupBox.Name = "teamMembersGroupBox";
            this.teamMembersGroupBox.Size = new System.Drawing.Size(1250, 265);
            this.teamMembersGroupBox.TabIndex = 3;
            this.teamMembersGroupBox.TabStop = false;
            this.teamMembersGroupBox.Text = "Team Members";
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Location = new System.Drawing.Point(1020, 191);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(211, 58);
            this.removePlayerButton.TabIndex = 4;
            this.removePlayerButton.Text = "Remove Selected Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(1020, 120);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(211, 56);
            this.addPlayerButton.TabIndex = 3;
            this.addPlayerButton.Text = "Add Player to Team";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerIdTextBox
            // 
            this.addPlayerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPlayerIdTextBox.Location = new System.Drawing.Point(1020, 63);
            this.addPlayerIdTextBox.Multiline = true;
            this.addPlayerIdTextBox.Name = "addPlayerIdTextBox";
            this.addPlayerIdTextBox.Size = new System.Drawing.Size(154, 35);
            this.addPlayerIdTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1016, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Player ID:";
            // 
            // teamMembersDataGridView
            // 
            this.teamMembersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamMembersDataGridView.Location = new System.Drawing.Point(12, 41);
            this.teamMembersDataGridView.Name = "teamMembersDataGridView";
            this.teamMembersDataGridView.RowHeadersWidth = 51;
            this.teamMembersDataGridView.RowTemplate.Height = 24;
            this.teamMembersDataGridView.Size = new System.Drawing.Size(949, 187);
            this.teamMembersDataGridView.TabIndex = 0;
            this.teamMembersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamMembersDataGridView_CellContentClick);
            // 
            // teamDetailsGroupBox
            // 
            this.teamDetailsGroupBox.Controls.Add(this.createTeamButton);
            this.teamDetailsGroupBox.Controls.Add(this.clearTeamButton);
            this.teamDetailsGroupBox.Controls.Add(this.deleteTeamButton);
            this.teamDetailsGroupBox.Controls.Add(this.updateTeamButton);
            this.teamDetailsGroupBox.Controls.Add(this.captainIdTextBox);
            this.teamDetailsGroupBox.Controls.Add(this.teamNameTextBox);
            this.teamDetailsGroupBox.Controls.Add(this.teamIdTextBox);
            this.teamDetailsGroupBox.Controls.Add(this.label4);
            this.teamDetailsGroupBox.Controls.Add(this.label3);
            this.teamDetailsGroupBox.Controls.Add(this.label2);
            this.teamDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDetailsGroupBox.Location = new System.Drawing.Point(18, 277);
            this.teamDetailsGroupBox.Name = "teamDetailsGroupBox";
            this.teamDetailsGroupBox.Size = new System.Drawing.Size(1238, 267);
            this.teamDetailsGroupBox.TabIndex = 2;
            this.teamDetailsGroupBox.TabStop = false;
            this.teamDetailsGroupBox.Text = "Team Details";
            // 
            // createTeamButton
            // 
            this.createTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.Location = new System.Drawing.Point(718, 70);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(134, 62);
            this.createTeamButton.TabIndex = 9;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // clearTeamButton
            // 
            this.clearTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTeamButton.Location = new System.Drawing.Point(903, 175);
            this.clearTeamButton.Name = "clearTeamButton";
            this.clearTeamButton.Size = new System.Drawing.Size(145, 57);
            this.clearTeamButton.TabIndex = 8;
            this.clearTeamButton.Text = "Clear Selection";
            this.clearTeamButton.UseVisualStyleBackColor = true;
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeamButton.Location = new System.Drawing.Point(718, 175);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(134, 57);
            this.deleteTeamButton.TabIndex = 7;
            this.deleteTeamButton.Text = "Delete Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            // 
            // updateTeamButton
            // 
            this.updateTeamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTeamButton.Location = new System.Drawing.Point(903, 70);
            this.updateTeamButton.Name = "updateTeamButton";
            this.updateTeamButton.Size = new System.Drawing.Size(145, 62);
            this.updateTeamButton.TabIndex = 6;
            this.updateTeamButton.Text = "Update Details";
            this.updateTeamButton.UseVisualStyleBackColor = true;
            // 
            // captainIdTextBox
            // 
            this.captainIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captainIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captainIdTextBox.Location = new System.Drawing.Point(278, 200);
            this.captainIdTextBox.Multiline = true;
            this.captainIdTextBox.Name = "captainIdTextBox";
            this.captainIdTextBox.Size = new System.Drawing.Size(237, 38);
            this.captainIdTextBox.TabIndex = 5;
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextBox.Location = new System.Drawing.Point(278, 134);
            this.teamNameTextBox.Multiline = true;
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(237, 38);
            this.teamNameTextBox.TabIndex = 4;
            // 
            // teamIdTextBox
            // 
            this.teamIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamIdTextBox.Location = new System.Drawing.Point(278, 70);
            this.teamIdTextBox.Multiline = true;
            this.teamIdTextBox.Name = "teamIdTextBox";
            this.teamIdTextBox.ReadOnly = true;
            this.teamIdTextBox.Size = new System.Drawing.Size(237, 38);
            this.teamIdTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Captain Player ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Team Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team ID:";
            // 
            // teamsDataGridView
            // 
            this.teamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView.Location = new System.Drawing.Point(18, 42);
            this.teamsDataGridView.Name = "teamsDataGridView";
            this.teamsDataGridView.RowHeadersWidth = 51;
            this.teamsDataGridView.RowTemplate.Height = 24;
            this.teamsDataGridView.Size = new System.Drawing.Size(1238, 216);
            this.teamsDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Teams";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(34, 910);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(165, 56);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to Dashboard";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ManageUsersAndTeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 978);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mainTabControl);
            this.Name = "ManageUsersAndTeamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users & Teams";
            this.Load += new System.EventHandler(this.ManageUsersAndTeamsForm_Load_1);
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            this.teamsTabPage.ResumeLayout(false);
            this.teamsTabPage.PerformLayout();
            this.teamMembersGroupBox.ResumeLayout(false);
            this.teamMembersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamMembersDataGridView)).EndInit();
            this.teamDetailsGroupBox.ResumeLayout(false);
            this.teamDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.TabPage teamsTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label selectedPlayerLabel;
        private System.Windows.Forms.Button deactivateButton;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.DataGridView teamsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox teamDetailsGroupBox;
        private System.Windows.Forms.TextBox captainIdTextBox;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.TextBox teamIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearTeamButton;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Button updateTeamButton;
        private System.Windows.Forms.GroupBox teamMembersGroupBox;
        private System.Windows.Forms.DataGridView teamMembersDataGridView;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.TextBox addPlayerIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}
