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
    public partial class ViewTournamentsForm : Form
    {
        private User playerUser;
        private Player playerInfo;
        private Team playerTeam;
        private Tournament selectedTournament;

        public ViewTournamentsForm(User user)
        {
            InitializeComponent();
            this.playerUser = user;
            this.Load += new System.EventHandler(this.ViewTournamentsForm_Load);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.tournamentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tournamentsDataGridView_CellClick);
            this.registerTeamButton.Click += new System.EventHandler(this.registerTeamButton_Click);
        }

        private void ViewTournamentsForm_Load(object sender, EventArgs e)
        {
            LoadPlayerAndTeamInfo();
            PopulateTournamentsGrid();
        }

        private void LoadPlayerAndTeamInfo()
        {
            PlayerController pc = new PlayerController();
            this.playerInfo = pc.SearchPlayerByUserId(this.playerUser.UserID);

            if (playerInfo != null && playerInfo.TeamID.HasValue)
            {
                TeamController tc = new TeamController();
                this.playerTeam = tc.SearchTeamById(playerInfo.TeamID.Value);
                myTeamLabel.Text = "My Team: " + this.playerTeam.TeamName;
            }
            else
            {
                myTeamLabel.Text = "My Team: Not assigned to a team";
                registerTeamButton.Enabled = false;
            }
        }

        private void PopulateTournamentsGrid()
        {
            TournamentController tc = new TournamentController();
            tournamentsDataGridView.DataSource = tc.GetAllTournaments();
        }

        private void tournamentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int tournamentId = Convert.ToInt32(tournamentsDataGridView.Rows[e.RowIndex].Cells["TournamentID"].Value);
                TournamentController tc = new TournamentController();
                this.selectedTournament = tc.SearchTournamentById(tournamentId);

                if (this.selectedTournament != null)
                {
                    selectedTournamentLabel.Text = "Selected Tournament: " + this.selectedTournament.TournamentName;
                }
            }
        }

        private void registerTeamButton_Click(object sender, EventArgs e)
        {
            if (this.selectedTournament == null)
            {
                MessageBox.Show("Please select a tournament from the list.", "No Tournament Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.playerTeam == null)
            {
                MessageBox.Show("You must be part of a team to register for a tournament.", "No Team", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TournamentRegistrationController trc = new TournamentRegistrationController();
                if (trc.IsTeamRegistered(this.selectedTournament.TournamentID, this.playerTeam.TeamID))
                {
                    MessageBox.Show("Your team is already registered for this tournament.", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                TournamentRegistration newReg = new TournamentRegistration();
                newReg.TournamentID = this.selectedTournament.TournamentID;
                newReg.TeamID = this.playerTeam.TeamID;

                trc.AddRegistration(newReg);
                MessageBox.Show("Your team has been successfully registered for " + this.selectedTournament.TournamentName, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerDashboard pd = new PlayerDashboard(this.playerUser);
            pd.Show();
        }
    }
}
