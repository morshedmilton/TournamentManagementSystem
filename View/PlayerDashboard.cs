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
    public partial class PlayerDashboard : Form
    {
        private User playerUser;
        private Player playerInfo;

        public PlayerDashboard(User user)
        {
            InitializeComponent();
            this.playerUser = user;

            this.Load += new System.EventHandler(this.PlayerDashboard_Load);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            this.manageTeamButton.Click += new System.EventHandler(this.manageTeamButton_Click);
        }

        private void PlayerDashboard_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, " + playerUser.Username;

            PlayerController pc = new PlayerController();
            List<Player> players = pc.GetAllPlayers();
            foreach (Player p in players)
            {
                if (p.UserID == playerUser.UserID)
                {
                    playerInfo = p;
                    break;
                }
            }

            if (playerInfo != null && playerInfo.TeamID.HasValue)
            {
                TeamController tc = new TeamController();
                Team team = tc.SearchTeamById((int)playerInfo.TeamID);
                if (team != null)
                {
                    teamNameLabel.Text = team.TeamName;
                }
            }
            else
            {
                teamNameLabel.Text = "Not in a team";
            }
        }

        private void manageTeamButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Manage Team page...");
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}