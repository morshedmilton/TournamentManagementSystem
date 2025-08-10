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
        private Team playerTeam;

        public PlayerDashboard(User user)
        {
            InitializeComponent();
            this.playerUser = user;

            this.Load += new System.EventHandler(this.PlayerDashboard_Load);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            this.manageTeamButton.Click += new System.EventHandler(this.manageTeamButton_Click);
            this.viewTournamentsButton.Click += new System.EventHandler(this.viewTournamentsButton_Click);
            this.viewMyMatchesButton.Click += new System.EventHandler(this.viewMyMatchesButton_Click);
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
        }

        private void PlayerDashboard_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, " + playerUser.Username;

            PlayerController pc = new PlayerController();
            this.playerInfo = pc.SearchPlayerByUserId(this.playerUser.UserID);

            if (playerInfo != null && playerInfo.TeamID.HasValue)
            {
                TeamController tc = new TeamController();
                this.playerTeam = tc.SearchTeamById((int)playerInfo.TeamID);
                if (this.playerTeam != null)
                {
                    teamNameLabel.Text = this.playerTeam.TeamName;
                }
            }
            else
            {
                teamNameLabel.Text = "Not in a team";
            }
        }

        private void viewTournamentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewTournamentsForm vtf = new ViewTournamentsForm(this.playerUser);
            vtf.Show();
        }

        private void viewMyMatchesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewMyMatchesForm vmf = new ViewMyMatchesForm(this.playerUser);
            vmf.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerProfileForm ppf = new PlayerProfileForm(this.playerUser);
            ppf.Show();
        }

        private void manageTeamButton_Click(object sender, EventArgs e)
        {
            if (this.playerTeam == null)
            {
                MessageBox.Show("You must be on a team to manage it.", "No Team", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.playerTeam.Captain_PlayerID == this.playerInfo.PlayerID)
            {
                this.Hide();
                ManageTeamForm mtf = new ManageTeamForm(this.playerUser);
                mtf.Show();
            }
            else
            {
                MessageBox.Show("Only the team captain can manage the team.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
            // This empty method is required by the form designer.
        }
    }
}
