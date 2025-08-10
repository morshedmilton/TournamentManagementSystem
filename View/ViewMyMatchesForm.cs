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
    public partial class ViewMyMatchesForm : Form
    {
        private User playerUser;
        private Player playerInfo;
        private Team playerTeam;

        public ViewMyMatchesForm(User user)
        {
            InitializeComponent();
            this.playerUser = user;
            this.Load += new System.EventHandler(this.ViewMyMatchesForm_Load);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.tournamentsComboBox.SelectedIndexChanged += new System.EventHandler(this.tournamentsComboBox_SelectedIndexChanged);
        }

        private void ViewMyMatchesForm_Load(object sender, EventArgs e)
        {
            LoadPlayerAndTeamInfo();
            PopulateTournamentsComboBox();
        }

        private void LoadPlayerAndTeamInfo()
        {
            PlayerController pc = new PlayerController();
            this.playerInfo = pc.SearchPlayerByUserId(this.playerUser.UserID);

            if (this.playerInfo != null && this.playerInfo.TeamID.HasValue)
            {
                TeamController tc = new TeamController();
                this.playerTeam = tc.SearchTeamById(this.playerInfo.TeamID.Value);
            }
        }

        private void PopulateTournamentsComboBox()
        {
            if (this.playerTeam == null)
            {
                MessageBox.Show("You are not currently on a team, so you cannot have any registered matches.", "No Team Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TournamentRegistrationController trc = new TournamentRegistrationController();
            List<TournamentRegistration> registrations = trc.GetRegistrationsByTeam(this.playerTeam.TeamID);

            if (registrations.Count == 0)
            {
                tournamentsComboBox.Items.Add("You have not registered for any tournaments.");
                tournamentsComboBox.Enabled = false;
                return;
            }

            TournamentController tc = new TournamentController();
            List<Tournament> registeredTournaments = new List<Tournament>();
            foreach (var reg in registrations)
            {
                Tournament t = tc.SearchTournamentById(reg.TournamentID);
                if (t != null)
                {
                    registeredTournaments.Add(t);
                }
            }

            tournamentsComboBox.DataSource = registeredTournaments;
            tournamentsComboBox.DisplayMember = "TournamentName";
            tournamentsComboBox.ValueMember = "TournamentID";
        }

        private void tournamentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tournamentsComboBox.SelectedValue is int tournamentId)
            {
                MatchController mc = new MatchController();
                matchesDataGridView.DataSource = mc.GetMatchesByTournamentAndTeam(tournamentId, this.playerTeam.TeamID);
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
