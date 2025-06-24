using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.View
{
    public partial class AdminDashboard : Form
    {
        private User adminUser;

        public AdminDashboard(User user)
        {
            InitializeComponent();
            this.adminUser = user;
            this.label1.Text = "Welcome, " + this.adminUser.Username;

            this.manageTournamentsButton.Click += new System.EventHandler(this.manageTournamentsButton_Click);
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            this.manageGamesButton.Click += new System.EventHandler(this.manageGamesButton_Click);
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
        }

        private void manageTournamentsButton_Click(object sender, EventArgs e)
        {
            // This feature is not implemented yet.
            MessageBox.Show("Manage Tournaments & Matches functionality is not yet available.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // The lines below are commented out because the form does not exist yet.
            // this.Hide();
            // ManageTournamentsAndMatchesForm mtmf = new ManageTournamentsAndMatchesForm(this.adminUser);
            // mtmf.Show();
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsersAndTeamsForm mutf = new ManageUsersAndTeamsForm(this.adminUser);
            mutf.Show();
        }

        private void manageGamesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageGamesForm mgf = new ManageGamesForm(this.adminUser);
            mgf.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
