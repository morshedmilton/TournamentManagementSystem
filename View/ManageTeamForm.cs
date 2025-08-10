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
    public partial class ManageTeamForm : Form
    {
        private User playerUser;
        private Player playerInfo;
        private Team playerTeam;

        public ManageTeamForm(User user)
        {
            InitializeComponent();
            this.playerUser = user;

            this.Load += new System.EventHandler(this.ManageTeamForm_Load);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.makeCaptainButton.Click += new System.EventHandler(this.makeCaptainButton_Click);
            this.removeFromTeamButton.Click += new System.EventHandler(this.removeFromTeamButton_Click);
        }

        private void ManageTeamForm_Load(object sender, EventArgs e)
        {
            LoadPlayerAndTeamInfo();
        }

        private void LoadPlayerAndTeamInfo()
        {
            PlayerController pc = new PlayerController();
            this.playerInfo = pc.SearchPlayerByUserId(this.playerUser.UserID);

            if (this.playerInfo != null && this.playerInfo.TeamID.HasValue)
            {
                TeamController tc = new TeamController();
                this.playerTeam = tc.SearchTeamById(this.playerInfo.TeamID.Value);
                teamNameLabel.Text = "Managing Team: " + this.playerTeam.TeamName;
                PopulateTeamMembersGrid();
            }
            else
            {
                MessageBox.Show("An error occurred. You do not seem to be on a team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PopulateTeamMembersGrid()
        {
            PlayerController pc = new PlayerController();
            List<Player> allPlayers = pc.GetAllPlayers();
            List<Player> teamMembers = allPlayers.Where(p => p.TeamID == this.playerTeam.TeamID).ToList();
            teamMembersDataGridView.DataSource = teamMembers;
        }

        private void makeCaptainButton_Click(object sender, EventArgs e)
        {
            if (teamMembersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a player from the list to promote.", "No Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedPlayerId = Convert.ToInt32(teamMembersDataGridView.CurrentRow.Cells["PlayerID"].Value);

            if (selectedPlayerId == this.playerInfo.PlayerID)
            {
                MessageBox.Show("You are already the captain.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to make this player the new captain? You will lose your captain status.", "Confirm Promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.playerTeam.Captain_PlayerID = selectedPlayerId;
                TeamController tc = new TeamController();
                tc.UpdateTeam(this.playerTeam);

                MessageBox.Show("Captain has been changed successfully. The new captain now has management rights.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                PlayerDashboard pd = new PlayerDashboard(this.playerUser);
                pd.Show();
            }
        }

        private void removeFromTeamButton_Click(object sender, EventArgs e)
        {
            if (teamMembersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a player from the list to remove.", "No Player Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedPlayerId = Convert.ToInt32(teamMembersDataGridView.CurrentRow.Cells["PlayerID"].Value);

            if (selectedPlayerId == this.playerInfo.PlayerID)
            {
                MessageBox.Show("Captains cannot remove themselves from the team. You must promote another player to captain first.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlayerController pc = new PlayerController();
            Player playerToRemove = pc.SearchPlayerById(selectedPlayerId);

            playerToRemove.TeamID = null;
            pc.UpdatePlayer(playerToRemove);

            MessageBox.Show($"Player '{playerToRemove.Player_FName}' has been removed from the team.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateTeamMembersGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerDashboard pd = new PlayerDashboard(this.playerUser);
            pd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
