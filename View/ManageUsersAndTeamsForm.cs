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
    public partial class ManageUsersAndTeamsForm : Form
    {
        private User adminUser;

        public ManageUsersAndTeamsForm(User user)
        {
            InitializeComponent();
            this.adminUser = user;

            this.Load += new System.EventHandler(this.ManageUsersAndTeamsForm_Load);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);

            this.playersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.playersDataGridView_CellClick);
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);

            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            this.teamsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamsDataGridView_CellClick);
            this.teamMembersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamMembersDataGridView_CellClick);
            this.updateTeamButton.Click += new System.EventHandler(this.updateTeamButton_Click);
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            this.clearTeamButton.Click += new System.EventHandler(this.clearTeamButton_Click);
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
        }

        private void ManageUsersAndTeamsForm_Load(object sender, EventArgs e)
        {
            PopulatePlayersGrid();
            PopulateTeamsGrid();
            clearTeamButton_Click(sender, e);
        }

        private void PopulatePlayersGrid()
        {
            UserController uc = new UserController();
            List<User> allUsers = uc.GetAllUsers();
            List<User> playerUsers = allUsers.Where(u => u.Role == "Player").ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("UserID", typeof(int));
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("IsActive", typeof(bool));

            foreach (var user in playerUsers)
            {
                dt.Rows.Add(user.UserID, user.Username, user.Email, user.IsActive);
            }

            playersDataGridView.DataSource = dt;
            playersDataGridView.Columns["UserID"].HeaderText = "Player ID";
            playersDataGridView.Columns["IsActive"].HeaderText = "Account Active";
        }

        private void playersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.playersDataGridView.Rows[e.RowIndex];
                string username = row.Cells["Username"].Value.ToString();
                selectedPlayerLabel.Text = "Selected Player: " + username;
            }
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            SetPlayerStatus(true);
        }

        private void deactivateButton_Click(object sender, EventArgs e)
        {
            SetPlayerStatus(false);
        }

        private void SetPlayerStatus(bool isActive)
        {
            if (playersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a player from the list.", "No Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = Convert.ToInt32(playersDataGridView.CurrentRow.Cells["UserID"].Value);

            UserController uc = new UserController();
            User user = uc.SearchUserById(userId);

            if (user != null)
            {
                user.IsActive = isActive;
                uc.UpdateUser(user);
                string status = isActive ? "activated" : "deactivated";
                MessageBox.Show($"User account for '{user.Username}' has been {status}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulatePlayersGrid();
                selectedPlayerLabel.Text = "Selected Player: None";
            }
            else
            {
                MessageBox.Show("Could not find the selected user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateTeamsGrid()
        {
            TeamController tc = new TeamController();
            teamsDataGridView.DataSource = tc.GetAllTeams();
        }

        private void teamsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.teamsDataGridView.Rows[e.RowIndex];
                teamIdTextBox.Text = row.Cells["TeamID"].Value.ToString();
                teamNameTextBox.Text = row.Cells["TeamName"].Value.ToString();

                if (row.Cells["Captain_PlayerID"].Value != null && row.Cells["Captain_PlayerID"].Value != DBNull.Value)
                {
                    captainIdTextBox.Text = row.Cells["Captain_PlayerID"].Value.ToString();
                }
                else
                {
                    captainIdTextBox.Text = "";
                }

                int teamId = Convert.ToInt32(teamIdTextBox.Text);
                PopulateTeamMembersGrid(teamId);
            }
        }

        private void teamMembersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PopulateTeamMembersGrid(int teamId)
        {
            PlayerController pc = new PlayerController();
            List<Player> allPlayers = pc.GetAllPlayers();
            List<Player> teamMembers = allPlayers.Where(p => p.TeamID == teamId).ToList();
            teamMembersDataGridView.DataSource = teamMembers;
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teamNameTextBox.Text))
            {
                MessageBox.Show("Please enter a team name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Team newTeam = new Team();
            newTeam.TeamName = teamNameTextBox.Text;
            newTeam.Date_Created = DateTime.Now;

            TeamController tc = new TeamController();
            tc.AddTeam(newTeam);

            MessageBox.Show("Team created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateTeamsGrid();
            clearTeamButton_Click(sender, e);
        }

        private void updateTeamButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teamIdTextBox.Text) || teamIdTextBox.Text == "[Auto-generated]")
            {
                MessageBox.Show("Please select a team to update.", "No Team Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(teamNameTextBox.Text))
            {
                MessageBox.Show("Team Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TeamController tc = new TeamController();
            Team team = tc.SearchTeamById(Convert.ToInt32(teamIdTextBox.Text));

            team.TeamName = teamNameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(captainIdTextBox.Text))
            {
                if (int.TryParse(captainIdTextBox.Text, out int captainId))
                {
                    team.Captain_PlayerID = captainId;
                }
                else
                {
                    MessageBox.Show("Captain Player ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                team.Captain_PlayerID = null;
            }

            tc.UpdateTeam(team);
            MessageBox.Show("Team details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateTeamsGrid();
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teamIdTextBox.Text) || teamIdTextBox.Text == "[Auto-generated]")
            {
                MessageBox.Show("Please select a team to delete.", "No Team Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teamId = Convert.ToInt32(teamIdTextBox.Text);

            PlayerController pc = new PlayerController();
            if (pc.GetPlayerCountByTeam(teamId) > 0)
            {
                MessageBox.Show("Cannot delete this team because it still has players. Please remove all players from the team first.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MatchController mc = new MatchController();
            if (mc.GetMatchCountByTeam(teamId) > 0)
            {
                MessageBox.Show("Cannot delete this team because it has a match history. You must first delete the tournament(s) it played in.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentRegistrationController trc = new TournamentRegistrationController();
            if (trc.GetRegistrationCountByTeam(teamId) > 0)
            {
                MessageBox.Show("Cannot delete this team because it is registered for a tournament. You must first delete the tournament(s) it is registered in.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this team? This action cannot be undone.",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    TeamController tc = new TeamController();
                    tc.DeleteTeam(teamId);
                    MessageBox.Show("Team deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PopulateTeamsGrid();
                    clearTeamButton_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during deletion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearTeamButton_Click(object sender, EventArgs e)
        {
            teamIdTextBox.Text = "[Auto-generated]";
            teamNameTextBox.Text = "";
            captainIdTextBox.Text = "";
            addPlayerIdTextBox.Text = "";
            teamMembersDataGridView.DataSource = null;
            teamsDataGridView.ClearSelection();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teamIdTextBox.Text) || teamIdTextBox.Text == "[Auto-generated]")
            {
                MessageBox.Show("Please select a team first.", "No Team Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(addPlayerIdTextBox.Text) || !int.TryParse(addPlayerIdTextBox.Text, out int playerId))
            {
                MessageBox.Show("Please enter a valid Player ID to add.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlayerController pc = new PlayerController();
            Player player = pc.SearchPlayerById(playerId);

            if (player == null)
            {
                MessageBox.Show("No player found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (player.TeamID.HasValue)
            {
                MessageBox.Show($"This player is already in a team (Team ID: {player.TeamID}). Remove them from their current team first.", "Player Already in Team", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int teamId = Convert.ToInt32(teamIdTextBox.Text);
            player.TeamID = teamId;
            pc.UpdatePlayer(player);
            MessageBox.Show($"Player '{player.Player_FName}' added to the team.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PopulateTeamMembersGrid(teamId);
            addPlayerIdTextBox.Text = "";
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            if (teamMembersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a player from the team members list to remove.", "No Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int playerId = Convert.ToInt32(teamMembersDataGridView.CurrentRow.Cells["PlayerID"].Value);
            int teamId = Convert.ToInt32(teamIdTextBox.Text);

            PlayerController pc = new PlayerController();
            Player player = pc.SearchPlayerById(playerId);

            player.TeamID = null;
            pc.UpdatePlayer(player);

            TeamController tc = new TeamController();
            Team team = tc.SearchTeamById(teamId);
            if (team.Captain_PlayerID == playerId)
            {
                team.Captain_PlayerID = null;
                tc.UpdateTeam(team);
                captainIdTextBox.Text = "";
            }

            MessageBox.Show($"Player '{player.Player_FName}' has been removed from the team.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateTeamMembersGrid(teamId);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard(this.adminUser);
            ad.Show();
        }

        private void teamMembersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageUsersAndTeamsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
