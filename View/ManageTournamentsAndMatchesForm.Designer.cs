namespace Tournament_Management_System.View
{
    partial class ManageTournamentsAndMatchesForm
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
            this.tournamentsTabPage = new System.Windows.Forms.TabPage();
            this.tournamentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.clearTournamentButton = new System.Windows.Forms.Button();
            this.deleteTournamentButton = new System.Windows.Forms.Button();
            this.updateTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.gameIdComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.organizerIdTextBox = new System.Windows.Forms.TextBox();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.tournamentIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tournamentsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.matchesTabPage = new System.Windows.Forms.TabPage();
            this.matchDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.winnerComboBox = new System.Windows.Forms.ComboBox();
            this.team2ScoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.team1ScoreNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.team2NameTextBox = new System.Windows.Forms.TextBox();
            this.team1NameTextBox = new System.Windows.Forms.TextBox();
            this.matchIdTextBox = new System.Windows.Forms.TextBox();
            this.clearMatchButton = new System.Windows.Forms.Button();
            this.updateMatchButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.matchActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteMatchesButton = new System.Windows.Forms.Button();
            this.generateMatchesButton = new System.Windows.Forms.Button();
            this.matchesDataGridView = new System.Windows.Forms.DataGridView();
            this.matchesTournamentLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tournamentsTabPage.SuspendLayout();
            this.tournamentDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsDataGridView)).BeginInit();
            this.matchesTabPage.SuspendLayout();
            this.matchDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team2ScoreNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1ScoreNumericUpDown)).BeginInit();
            this.matchActionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tournamentsTabPage);
            this.mainTabControl.Controls.Add(this.matchesTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1356, 646);
            this.mainTabControl.TabIndex = 0;
            // 
            // tournamentsTabPage
            // 
            this.tournamentsTabPage.Controls.Add(this.tournamentDetailsGroupBox);
            this.tournamentsTabPage.Controls.Add(this.tournamentsDataGridView);
            this.tournamentsTabPage.Controls.Add(this.label1);
            this.tournamentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.tournamentsTabPage.Name = "tournamentsTabPage";
            this.tournamentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tournamentsTabPage.Size = new System.Drawing.Size(1348, 617);
            this.tournamentsTabPage.TabIndex = 0;
            this.tournamentsTabPage.Text = "Manage Tournaments";
            this.tournamentsTabPage.UseVisualStyleBackColor = true;
            // 
            // tournamentDetailsGroupBox
            // 
            this.tournamentDetailsGroupBox.Controls.Add(this.clearTournamentButton);
            this.tournamentDetailsGroupBox.Controls.Add(this.deleteTournamentButton);
            this.tournamentDetailsGroupBox.Controls.Add(this.updateTournamentButton);
            this.tournamentDetailsGroupBox.Controls.Add(this.createTournamentButton);
            this.tournamentDetailsGroupBox.Controls.Add(this.gameIdComboBox);
            this.tournamentDetailsGroupBox.Controls.Add(this.statusComboBox);
            this.tournamentDetailsGroupBox.Controls.Add(this.endDatePicker);
            this.tournamentDetailsGroupBox.Controls.Add(this.startDatePicker);
            this.tournamentDetailsGroupBox.Controls.Add(this.organizerIdTextBox);
            this.tournamentDetailsGroupBox.Controls.Add(this.tournamentNameTextBox);
            this.tournamentDetailsGroupBox.Controls.Add(this.tournamentIdTextBox);
            this.tournamentDetailsGroupBox.Controls.Add(this.label8);
            this.tournamentDetailsGroupBox.Controls.Add(this.label7);
            this.tournamentDetailsGroupBox.Controls.Add(this.label6);
            this.tournamentDetailsGroupBox.Controls.Add(this.label5);
            this.tournamentDetailsGroupBox.Controls.Add(this.label4);
            this.tournamentDetailsGroupBox.Controls.Add(this.label3);
            this.tournamentDetailsGroupBox.Controls.Add(this.label2);
            this.tournamentDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDetailsGroupBox.Location = new System.Drawing.Point(892, 38);
            this.tournamentDetailsGroupBox.Name = "tournamentDetailsGroupBox";
            this.tournamentDetailsGroupBox.Size = new System.Drawing.Size(439, 573);
            this.tournamentDetailsGroupBox.TabIndex = 2;
            this.tournamentDetailsGroupBox.TabStop = false;
            this.tournamentDetailsGroupBox.Text = "Tournament Details";
            // 
            // clearTournamentButton
            // 
            this.clearTournamentButton.Location = new System.Drawing.Point(232, 508);
            this.clearTournamentButton.Name = "clearTournamentButton";
            this.clearTournamentButton.Size = new System.Drawing.Size(149, 52);
            this.clearTournamentButton.TabIndex = 17;
            this.clearTournamentButton.Text = "Clear Form";
            this.clearTournamentButton.UseVisualStyleBackColor = true;
            // 
            // deleteTournamentButton
            // 
            this.deleteTournamentButton.Location = new System.Drawing.Point(54, 508);
            this.deleteTournamentButton.Name = "deleteTournamentButton";
            this.deleteTournamentButton.Size = new System.Drawing.Size(157, 52);
            this.deleteTournamentButton.TabIndex = 16;
            this.deleteTournamentButton.Text = "Delete Selected";
            this.deleteTournamentButton.UseVisualStyleBackColor = true;
            // 
            // updateTournamentButton
            // 
            this.updateTournamentButton.Location = new System.Drawing.Point(232, 444);
            this.updateTournamentButton.Name = "updateTournamentButton";
            this.updateTournamentButton.Size = new System.Drawing.Size(149, 52);
            this.updateTournamentButton.TabIndex = 15;
            this.updateTournamentButton.Text = "Update Selected";
            this.updateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(54, 444);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(157, 52);
            this.createTournamentButton.TabIndex = 14;
            this.createTournamentButton.Text = "Create New";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // gameIdComboBox
            // 
            this.gameIdComboBox.FormattingEnabled = true;
            this.gameIdComboBox.Location = new System.Drawing.Point(200, 313);
            this.gameIdComboBox.Name = "gameIdComboBox";
            this.gameIdComboBox.Size = new System.Drawing.Size(228, 28);
            this.gameIdComboBox.TabIndex = 13;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(200, 260);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(228, 28);
            this.statusComboBox.TabIndex = 12;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(201, 206);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(228, 27);
            this.endDatePicker.TabIndex = 11;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(201, 154);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(227, 27);
            this.startDatePicker.TabIndex = 10;
            // 
            // organizerIdTextBox
            // 
            this.organizerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.organizerIdTextBox.Location = new System.Drawing.Point(200, 368);
            this.organizerIdTextBox.Multiline = true;
            this.organizerIdTextBox.Name = "organizerIdTextBox";
            this.organizerIdTextBox.ReadOnly = true;
            this.organizerIdTextBox.Size = new System.Drawing.Size(228, 39);
            this.organizerIdTextBox.TabIndex = 9;
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameTextBox.Location = new System.Drawing.Point(201, 88);
            this.tournamentNameTextBox.Multiline = true;
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(227, 39);
            this.tournamentNameTextBox.TabIndex = 8;
            // 
            // tournamentIdTextBox
            // 
            this.tournamentIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentIdTextBox.Location = new System.Drawing.Point(201, 35);
            this.tournamentIdTextBox.Multiline = true;
            this.tournamentIdTextBox.Name = "tournamentIdTextBox";
            this.tournamentIdTextBox.ReadOnly = true;
            this.tournamentIdTextBox.Size = new System.Drawing.Size(227, 39);
            this.tournamentIdTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Organizer ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Game ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tournament Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tournament ID:";
            // 
            // tournamentsDataGridView
            // 
            this.tournamentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentsDataGridView.Location = new System.Drawing.Point(6, 38);
            this.tournamentsDataGridView.Name = "tournamentsDataGridView";
            this.tournamentsDataGridView.RowHeadersWidth = 51;
            this.tournamentsDataGridView.RowTemplate.Height = 24;
            this.tournamentsDataGridView.Size = new System.Drawing.Size(880, 573);
            this.tournamentsDataGridView.TabIndex = 1;
            this.tournamentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tournamentsDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Tournaments";
            // 
            // matchesTabPage
            // 
            this.matchesTabPage.Controls.Add(this.matchDetailsGroupBox);
            this.matchesTabPage.Controls.Add(this.matchActionsGroupBox);
            this.matchesTabPage.Controls.Add(this.matchesDataGridView);
            this.matchesTabPage.Controls.Add(this.matchesTournamentLabel);
            this.matchesTabPage.Location = new System.Drawing.Point(4, 25);
            this.matchesTabPage.Name = "matchesTabPage";
            this.matchesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.matchesTabPage.Size = new System.Drawing.Size(1348, 617);
            this.matchesTabPage.TabIndex = 1;
            this.matchesTabPage.Text = "Manage Matches";
            this.matchesTabPage.UseVisualStyleBackColor = true;
            // 
            // matchDetailsGroupBox
            // 
            this.matchDetailsGroupBox.Controls.Add(this.winnerComboBox);
            this.matchDetailsGroupBox.Controls.Add(this.team2ScoreNumericUpDown);
            this.matchDetailsGroupBox.Controls.Add(this.team1ScoreNumericUpDown);
            this.matchDetailsGroupBox.Controls.Add(this.team2NameTextBox);
            this.matchDetailsGroupBox.Controls.Add(this.team1NameTextBox);
            this.matchDetailsGroupBox.Controls.Add(this.matchIdTextBox);
            this.matchDetailsGroupBox.Controls.Add(this.clearMatchButton);
            this.matchDetailsGroupBox.Controls.Add(this.updateMatchButton);
            this.matchDetailsGroupBox.Controls.Add(this.label14);
            this.matchDetailsGroupBox.Controls.Add(this.label13);
            this.matchDetailsGroupBox.Controls.Add(this.label12);
            this.matchDetailsGroupBox.Controls.Add(this.label11);
            this.matchDetailsGroupBox.Controls.Add(this.label10);
            this.matchDetailsGroupBox.Controls.Add(this.label9);
            this.matchDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchDetailsGroupBox.Location = new System.Drawing.Point(888, 169);
            this.matchDetailsGroupBox.Name = "matchDetailsGroupBox";
            this.matchDetailsGroupBox.Size = new System.Drawing.Size(439, 442);
            this.matchDetailsGroupBox.TabIndex = 3;
            this.matchDetailsGroupBox.TabStop = false;
            this.matchDetailsGroupBox.Text = "Update Match Result";
            // 
            // winnerComboBox
            // 
            this.winnerComboBox.FormattingEnabled = true;
            this.winnerComboBox.Location = new System.Drawing.Point(198, 305);
            this.winnerComboBox.Name = "winnerComboBox";
            this.winnerComboBox.Size = new System.Drawing.Size(199, 28);
            this.winnerComboBox.TabIndex = 13;
            // 
            // team2ScoreNumericUpDown
            // 
            this.team2ScoreNumericUpDown.Location = new System.Drawing.Point(198, 254);
            this.team2ScoreNumericUpDown.Name = "team2ScoreNumericUpDown";
            this.team2ScoreNumericUpDown.Size = new System.Drawing.Size(199, 27);
            this.team2ScoreNumericUpDown.TabIndex = 12;
            // 
            // team1ScoreNumericUpDown
            // 
            this.team1ScoreNumericUpDown.Location = new System.Drawing.Point(198, 203);
            this.team1ScoreNumericUpDown.Name = "team1ScoreNumericUpDown";
            this.team1ScoreNumericUpDown.Size = new System.Drawing.Size(199, 27);
            this.team1ScoreNumericUpDown.TabIndex = 11;
            // 
            // team2NameTextBox
            // 
            this.team2NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team2NameTextBox.Location = new System.Drawing.Point(198, 145);
            this.team2NameTextBox.Multiline = true;
            this.team2NameTextBox.Name = "team2NameTextBox";
            this.team2NameTextBox.ReadOnly = true;
            this.team2NameTextBox.Size = new System.Drawing.Size(199, 36);
            this.team2NameTextBox.TabIndex = 10;
            // 
            // team1NameTextBox
            // 
            this.team1NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team1NameTextBox.Location = new System.Drawing.Point(198, 89);
            this.team1NameTextBox.Multiline = true;
            this.team1NameTextBox.Name = "team1NameTextBox";
            this.team1NameTextBox.ReadOnly = true;
            this.team1NameTextBox.Size = new System.Drawing.Size(199, 36);
            this.team1NameTextBox.TabIndex = 9;
            // 
            // matchIdTextBox
            // 
            this.matchIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchIdTextBox.Location = new System.Drawing.Point(198, 38);
            this.matchIdTextBox.Multiline = true;
            this.matchIdTextBox.Name = "matchIdTextBox";
            this.matchIdTextBox.ReadOnly = true;
            this.matchIdTextBox.Size = new System.Drawing.Size(199, 36);
            this.matchIdTextBox.TabIndex = 8;
            // 
            // clearMatchButton
            // 
            this.clearMatchButton.Location = new System.Drawing.Point(254, 381);
            this.clearMatchButton.Name = "clearMatchButton";
            this.clearMatchButton.Size = new System.Drawing.Size(143, 41);
            this.clearMatchButton.TabIndex = 7;
            this.clearMatchButton.Text = "Clear Selection";
            this.clearMatchButton.UseVisualStyleBackColor = true;
            // 
            // updateMatchButton
            // 
            this.updateMatchButton.Location = new System.Drawing.Point(45, 381);
            this.updateMatchButton.Name = "updateMatchButton";
            this.updateMatchButton.Size = new System.Drawing.Size(143, 41);
            this.updateMatchButton.TabIndex = 6;
            this.updateMatchButton.Text = "Update Result";
            this.updateMatchButton.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(107, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Winner:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Team 2 Score:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Team 1 Score:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Team 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(104, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Team 1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Match ID:";
            // 
            // matchActionsGroupBox
            // 
            this.matchActionsGroupBox.Controls.Add(this.deleteMatchesButton);
            this.matchActionsGroupBox.Controls.Add(this.generateMatchesButton);
            this.matchActionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchActionsGroupBox.Location = new System.Drawing.Point(888, 56);
            this.matchActionsGroupBox.Name = "matchActionsGroupBox";
            this.matchActionsGroupBox.Size = new System.Drawing.Size(439, 93);
            this.matchActionsGroupBox.TabIndex = 2;
            this.matchActionsGroupBox.TabStop = false;
            this.matchActionsGroupBox.Text = "Match Actions";
            // 
            // deleteMatchesButton
            // 
            this.deleteMatchesButton.Location = new System.Drawing.Point(243, 33);
            this.deleteMatchesButton.Name = "deleteMatchesButton";
            this.deleteMatchesButton.Size = new System.Drawing.Size(181, 46);
            this.deleteMatchesButton.TabIndex = 1;
            this.deleteMatchesButton.Text = "Delete All Matches";
            this.deleteMatchesButton.UseVisualStyleBackColor = true;
            // 
            // generateMatchesButton
            // 
            this.generateMatchesButton.AutoSize = true;
            this.generateMatchesButton.Location = new System.Drawing.Point(24, 35);
            this.generateMatchesButton.Name = "generateMatchesButton";
            this.generateMatchesButton.Size = new System.Drawing.Size(213, 44);
            this.generateMatchesButton.TabIndex = 0;
            this.generateMatchesButton.Text = "Generate Match Schedule";
            this.generateMatchesButton.UseVisualStyleBackColor = true;
            // 
            // matchesDataGridView
            // 
            this.matchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesDataGridView.Location = new System.Drawing.Point(6, 56);
            this.matchesDataGridView.Name = "matchesDataGridView";
            this.matchesDataGridView.RowHeadersWidth = 51;
            this.matchesDataGridView.RowTemplate.Height = 24;
            this.matchesDataGridView.Size = new System.Drawing.Size(863, 555);
            this.matchesDataGridView.TabIndex = 1;
            // 
            // matchesTournamentLabel
            // 
            this.matchesTournamentLabel.AutoSize = true;
            this.matchesTournamentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchesTournamentLabel.Location = new System.Drawing.Point(142, 16);
            this.matchesTournamentLabel.Name = "matchesTournamentLabel";
            this.matchesTournamentLabel.Size = new System.Drawing.Size(604, 25);
            this.matchesTournamentLabel.TabIndex = 0;
            this.matchesTournamentLabel.Text = "Matches for Tournament: (Please select a tournament in the first tab)";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 664);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(184, 58);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to Dashboard";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ManageTournamentsAndMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 734);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mainTabControl);
            this.Name = "ManageTournamentsAndMatchesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Tournaments & Matches";
            this.mainTabControl.ResumeLayout(false);
            this.tournamentsTabPage.ResumeLayout(false);
            this.tournamentsTabPage.PerformLayout();
            this.tournamentDetailsGroupBox.ResumeLayout(false);
            this.tournamentDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsDataGridView)).EndInit();
            this.matchesTabPage.ResumeLayout(false);
            this.matchesTabPage.PerformLayout();
            this.matchDetailsGroupBox.ResumeLayout(false);
            this.matchDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.team2ScoreNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team1ScoreNumericUpDown)).EndInit();
            this.matchActionsGroupBox.ResumeLayout(false);
            this.matchActionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tournamentsTabPage;
        private System.Windows.Forms.TabPage matchesTabPage;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView tournamentsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox tournamentDetailsGroupBox;
        private System.Windows.Forms.ComboBox gameIdComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.TextBox organizerIdTextBox;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.TextBox tournamentIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearTournamentButton;
        private System.Windows.Forms.Button deleteTournamentButton;
        private System.Windows.Forms.Button updateTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.GroupBox matchActionsGroupBox;
        private System.Windows.Forms.Button deleteMatchesButton;
        private System.Windows.Forms.Button generateMatchesButton;
        private System.Windows.Forms.DataGridView matchesDataGridView;
        private System.Windows.Forms.Label matchesTournamentLabel;
        private System.Windows.Forms.GroupBox matchDetailsGroupBox;
        private System.Windows.Forms.ComboBox winnerComboBox;
        private System.Windows.Forms.NumericUpDown team2ScoreNumericUpDown;
        private System.Windows.Forms.NumericUpDown team1ScoreNumericUpDown;
        private System.Windows.Forms.TextBox team2NameTextBox;
        private System.Windows.Forms.TextBox team1NameTextBox;
        private System.Windows.Forms.TextBox matchIdTextBox;
        private System.Windows.Forms.Button clearMatchButton;
        private System.Windows.Forms.Button updateMatchButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
