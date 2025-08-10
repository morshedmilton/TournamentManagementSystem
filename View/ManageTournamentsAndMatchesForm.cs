using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Management_System.Controller;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.View
{
    public partial class ManageTournamentsAndMatchesForm : Form
    {
        private User adminUser;
        private Tournament selectedTournament;

        public ManageTournamentsAndMatchesForm(User user)
        {
            InitializeComponent();
            this.adminUser = user;
            this.Load += new System.EventHandler(this.ManageTournamentsAndMatchesForm_Load);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);

            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            this.updateTournamentButton.Click += new System.EventHandler(this.updateTournamentButton_Click);
            this.deleteTournamentButton.Click += new System.EventHandler(this.deleteTournamentButton_Click);
            this.clearTournamentButton.Click += new System.EventHandler(this.clearTournamentButton_Click);
            this.tournamentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tournamentsDataGridView_CellClick);

            this.generateMatchesButton.Click += new System.EventHandler(this.generateMatchesButton_Click);
            this.deleteMatchesButton.Click += new System.EventHandler(this.deleteMatchesButton_Click);
            this.updateMatchButton.Click += new System.EventHandler(this.updateMatchButton_Click);
            this.clearMatchButton.Click += new System.EventHandler(this.clearMatchButton_Click);
            this.matchesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matchesDataGridView_CellClick);
        }

        private void ManageTournamentsAndMatchesForm_Load(object sender, EventArgs e)
        {
            PopulateTournamentsGrid();
            PopulateComboBoxes();
            clearTournamentButton_Click(sender, e);
            clearMatchButton_Click(sender, e);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard(this.adminUser);
            ad.Show();
        }

        private void PopulateTournamentsGrid()
        {
            TournamentController tc = new TournamentController();
            tournamentsDataGridView.DataSource = tc.GetAllTournaments();
        }

        private void PopulateComboBoxes()
        {
            statusComboBox.Items.Clear();
            statusComboBox.Items.Add("Scheduled");
            statusComboBox.Items.Add("Ongoing");
            statusComboBox.Items.Add("Completed");

            GameController gc = new GameController();
            gameIdComboBox.DataSource = gc.GetAllGames();
            gameIdComboBox.DisplayMember = "GameName";
            gameIdComboBox.ValueMember = "GameID";
        }

        private void tournamentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tournamentsDataGridView.Rows[e.RowIndex];

                int tournamentId = Convert.ToInt32(row.Cells["TournamentID"].Value);
                TournamentController tc = new TournamentController();
                selectedTournament = tc.SearchTournamentById(tournamentId);

                if (selectedTournament != null)
                {
                    tournamentIdTextBox.Text = selectedTournament.TournamentID.ToString();
                    tournamentNameTextBox.Text = selectedTournament.TournamentName;
                    startDatePicker.Value = selectedTournament.TournamentStartDate;
                    endDatePicker.Value = selectedTournament.TournamentEndDate;
                    statusComboBox.SelectedItem = selectedTournament.Status;
                    gameIdComboBox.SelectedValue = selectedTournament.GameID;
                    organizerIdTextBox.Text = selectedTournament.Organizer_UserID.ToString();

                    matchesTournamentLabel.Text = "Matches for Tournament: " + selectedTournament.TournamentName;
                    PopulateMatchesGrid(selectedTournament.TournamentID);
                    clearMatchButton_Click(sender, e);
                }
            }
        }

        private void clearTournamentButton_Click(object sender, EventArgs e)
        {
            selectedTournament = null;
            tournamentIdTextBox.Text = "[Auto-generated]";
            tournamentNameTextBox.Text = "";
            startDatePicker.Value = DateTime.Now;
            endDatePicker.Value = DateTime.Now.AddDays(7);
            statusComboBox.SelectedIndex = -1;
            gameIdComboBox.SelectedIndex = -1;
            organizerIdTextBox.Text = adminUser.UserID.ToString();
            tournamentsDataGridView.ClearSelection();

            matchesTournamentLabel.Text = "Matches for Tournament: (Please select a tournament)";
            matchesDataGridView.DataSource = null;
            clearMatchButton_Click(sender, e);
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tournamentNameTextBox.Text) || statusComboBox.SelectedItem == null || gameIdComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields: Name, Status, and Game.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Tournament newTournament = new Tournament();
                newTournament.TournamentName = tournamentNameTextBox.Text;
                newTournament.TournamentStartDate = startDatePicker.Value;
                newTournament.TournamentEndDate = endDatePicker.Value;
                newTournament.Status = statusComboBox.SelectedItem.ToString();
                newTournament.GameID = (int)gameIdComboBox.SelectedValue;
                newTournament.Organizer_UserID = this.adminUser.UserID;

                TournamentController tc = new TournamentController();
                tc.AddTournament(newTournament);

                MessageBox.Show("Tournament created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateTournamentsGrid();
                clearTournamentButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateTournamentButton_Click(object sender, EventArgs e)
        {
            if (selectedTournament == null)
            {
                MessageBox.Show("Please select a tournament from the list to update.", "No Tournament Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedTournament.TournamentName = tournamentNameTextBox.Text;
            selectedTournament.TournamentStartDate = startDatePicker.Value;
            selectedTournament.TournamentEndDate = endDatePicker.Value;
            selectedTournament.Status = statusComboBox.SelectedItem.ToString();
            selectedTournament.GameID = (int)gameIdComboBox.SelectedValue;

            TournamentController tc = new TournamentController();
            tc.UpdateTournament(selectedTournament);

            MessageBox.Show("Tournament updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateTournamentsGrid();
        }

        private void deleteTournamentButton_Click(object sender, EventArgs e)
        {
            if (selectedTournament == null)
            {
                MessageBox.Show("Please select a tournament to delete.", "No Tournament Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this tournament? This will also delete all its registrations and matches.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    MatchController mc = new MatchController();
                    mc.DeleteMatchesByTournament(selectedTournament.TournamentID);

                    TournamentRegistrationController trc = new TournamentRegistrationController();
                    trc.DeleteRegistrationsByTournament(selectedTournament.TournamentID);

                    TournamentController tc = new TournamentController();
                    tc.DeleteTournament(selectedTournament.TournamentID);

                    MessageBox.Show("Tournament deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateTournamentsGrid();
                    clearTournamentButton_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during deletion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopulateMatchesGrid(int tournamentId)
        {
            MatchController mc = new MatchController();
            matchesDataGridView.DataSource = mc.GetMatchesByTournament(tournamentId);
        }

        private void clearMatchButton_Click(object sender, EventArgs e)
        {
            matchIdTextBox.Text = "";
            team1NameTextBox.Text = "";
            team2NameTextBox.Text = "";
            team1ScoreNumericUpDown.Value = 0;
            team2ScoreNumericUpDown.Value = 0;
            winnerComboBox.DataSource = null;
            winnerComboBox.Items.Clear();
            matchesDataGridView.ClearSelection();
        }

        private void matchesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && selectedTournament != null)
            {
                DataGridViewRow row = this.matchesDataGridView.Rows[e.RowIndex];
                matchIdTextBox.Text = row.Cells["MatchID"].Value.ToString();

                int team1Id = Convert.ToInt32(row.Cells["Team1_ID"].Value);
                int team2Id = Convert.ToInt32(row.Cells["Team2_ID"].Value);

                TeamController tc = new TeamController();
                Team team1 = tc.SearchTeamById(team1Id);
                Team team2 = tc.SearchTeamById(team2Id);

                team1NameTextBox.Text = team1.TeamName;
                team2NameTextBox.Text = team2.TeamName;

                team1ScoreNumericUpDown.Value = Convert.ToDecimal(row.Cells["Team1_Score"].Value);
                team2ScoreNumericUpDown.Value = Convert.ToDecimal(row.Cells["Team2_Score"].Value);

                winnerComboBox.Items.Clear();
                winnerComboBox.Items.Add(team1);
                winnerComboBox.Items.Add(team2);
                winnerComboBox.DisplayMember = "TeamName";
                winnerComboBox.ValueMember = "TeamID";

                if (row.Cells["WinnerTeamID"].Value != DBNull.Value)
                {
                    int winnerId = Convert.ToInt32(row.Cells["WinnerTeamID"].Value);
                    winnerComboBox.SelectedValue = winnerId;
                }
                else
                {
                    winnerComboBox.SelectedIndex = -1;
                }
            }
        }

        private void updateMatchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(matchIdTextBox.Text))
            {
                MessageBox.Show("Please select a match from the list.", "No Match Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MatchController mc = new MatchController();
            Match match = mc.SearchMatchById(Convert.ToInt32(matchIdTextBox.Text));

            match.Team1_Score = (int)team1ScoreNumericUpDown.Value;
            match.Team2_Score = (int)team2ScoreNumericUpDown.Value;
            match.Status = "Completed";

            if (winnerComboBox.SelectedItem != null)
            {
                match.WinnerTeamID = ((Team)winnerComboBox.SelectedItem).TeamID;
            }
            else
            {
                match.WinnerTeamID = null;
            }

            mc.UpdateMatchResult(match);
            MessageBox.Show("Match result updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateMatchesGrid(selectedTournament.TournamentID);
        }

        private void generateMatchesButton_Click(object sender, EventArgs e)
        {
            if (selectedTournament == null)
            {
                MessageBox.Show("Please select a tournament before generating matches.", "No Tournament Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MatchController mc = new MatchController();
            if (mc.GetMatchesByTournament(selectedTournament.TournamentID).Any())
            {
                var result = MessageBox.Show("Matches already exist for this tournament. Do you want to delete them and regenerate the schedule?", "Confirm Regeneration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                mc.DeleteMatchesByTournament(selectedTournament.TournamentID);
            }

            TeamController tc = new TeamController();
            List<Team> teams = tc.GetAllTeams();
            if (teams.Count < 2)
            {
                MessageBox.Show("You need at least two teams in the system to generate a schedule.", "Not Enough Teams", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Match> matchesToCreate = new List<Match>();
            for (int i = 0; i < teams.Count; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {
                    Match newMatch = new Match
                    {
                        TournamentID = selectedTournament.TournamentID,
                        Team1_ID = teams[i].TeamID,
                        Team2_ID = teams[j].TeamID,
                        Match_Round_Number = "Round 1",
                        Match_DateTime = selectedTournament.TournamentStartDate.AddDays(i),
                        Status = "Scheduled",
                        Team1_Score = 0,
                        Team2_Score = 0,
                        WinnerTeamID = null
                    };
                    matchesToCreate.Add(newMatch);
                }
            }

            mc.AddMatches(matchesToCreate);
            MessageBox.Show("Match schedule generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateMatchesGrid(selectedTournament.TournamentID);
        }

        private void deleteMatchesButton_Click(object sender, EventArgs e)
        {
            if (selectedTournament == null)
            {
                MessageBox.Show("Please select a tournament first.", "No Tournament Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete all matches for this tournament?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                MatchController mc = new MatchController();
                mc.DeleteMatchesByTournament(selectedTournament.TournamentID);
                MessageBox.Show("All matches deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateMatchesGrid(selectedTournament.TournamentID);
                clearMatchButton_Click(sender, e);
            }
        }

        private void tournamentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
