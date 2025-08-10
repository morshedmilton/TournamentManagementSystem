namespace Tournament_Management_System.View
{
    partial class ViewTournamentsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tournamentsDataGridView = new System.Windows.Forms.DataGridView();
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.registerTeamButton = new System.Windows.Forms.Button();
            this.myTeamLabel = new System.Windows.Forms.Label();
            this.selectedTournamentLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsDataGridView)).BeginInit();
            this.registrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "View and Register for Tournaments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available Tournaments";
            // 
            // tournamentsDataGridView
            // 
            this.tournamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentsDataGridView.Location = new System.Drawing.Point(12, 166);
            this.tournamentsDataGridView.Name = "tournamentsDataGridView";
            this.tournamentsDataGridView.RowHeadersWidth = 51;
            this.tournamentsDataGridView.RowTemplate.Height = 24;
            this.tournamentsDataGridView.Size = new System.Drawing.Size(951, 216);
            this.tournamentsDataGridView.TabIndex = 2;
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.registerTeamButton);
            this.registrationGroupBox.Controls.Add(this.myTeamLabel);
            this.registrationGroupBox.Controls.Add(this.selectedTournamentLabel);
            this.registrationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationGroupBox.Location = new System.Drawing.Point(12, 416);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(951, 216);
            this.registrationGroupBox.TabIndex = 3;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Tournament Registration";
            // 
            // registerTeamButton
            // 
            this.registerTeamButton.Location = new System.Drawing.Point(683, 78);
            this.registerTeamButton.Name = "registerTeamButton";
            this.registerTeamButton.Size = new System.Drawing.Size(172, 60);
            this.registerTeamButton.TabIndex = 3;
            this.registerTeamButton.Text = "Register My Team";
            this.registerTeamButton.UseVisualStyleBackColor = true;
            // 
            // myTeamLabel
            // 
            this.myTeamLabel.AutoSize = true;
            this.myTeamLabel.Location = new System.Drawing.Point(93, 118);
            this.myTeamLabel.Name = "myTeamLabel";
            this.myTeamLabel.Size = new System.Drawing.Size(189, 20);
            this.myTeamLabel.TabIndex = 1;
            this.myTeamLabel.Text = "My Team: [Team Name]";
            // 
            // selectedTournamentLabel
            // 
            this.selectedTournamentLabel.AutoSize = true;
            this.selectedTournamentLabel.Location = new System.Drawing.Point(93, 70);
            this.selectedTournamentLabel.Name = "selectedTournamentLabel";
            this.selectedTournamentLabel.Size = new System.Drawing.Size(217, 20);
            this.selectedTournamentLabel.TabIndex = 0;
            this.selectedTournamentLabel.Text = "Selected Tournament: None";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(21, 653);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 62);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back to Dashboard";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ViewTournamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 764);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registrationGroupBox);
            this.Controls.Add(this.tournamentsDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewTournamentsForm";
            this.Text = "View & Register for Tournaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsDataGridView)).EndInit();
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tournamentsDataGridView;
        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button registerTeamButton;
        private System.Windows.Forms.Label myTeamLabel;
        private System.Windows.Forms.Label selectedTournamentLabel;
    }
}
