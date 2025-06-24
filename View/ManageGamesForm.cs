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
    public partial class ManageGamesForm : Form
    {
        private User adminUser;

        public ManageGamesForm(User user)
        {
            InitializeComponent();
            this.adminUser = user;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.gamesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gamesDataGridView_CellClick);
        }

        private void ManageGamesForm_Load(object sender, EventArgs e)
        {
            PopulateGamesGrid();
        }

        private void PopulateGamesGrid()
        {
            GameController gc = new GameController();
            gamesDataGridView.DataSource = gc.GetAllGames();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gameIdTextBox.Text = "";
            gameNameTextBox.Text = "";
            genreTextBox.Text = "";
            gameIdTextBox.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gameIdTextBox.Text) || string.IsNullOrEmpty(gameNameTextBox.Text))
            {
                MessageBox.Show("Game ID and Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Game g = new Game();
            g.GameID = Convert.ToInt32(gameIdTextBox.Text);
            g.GameName = gameNameTextBox.Text;
            g.Genre = genreTextBox.Text;

            GameController gc = new GameController();
            gc.AddGame(g);

            MessageBox.Show("Game added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateGamesGrid();
            clearButton_Click(sender, e);
        }

        private void gamesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gamesDataGridView.Rows[e.RowIndex];
                gameIdTextBox.Text = row.Cells["GameID"].Value.ToString();
                gameNameTextBox.Text = row.Cells["GameName"].Value.ToString();
                genreTextBox.Text = row.Cells["Genre"].Value.ToString();
                gameIdTextBox.Enabled = false;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gameIdTextBox.Text))
            {
                MessageBox.Show("Please select a game from the list to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Game g = new Game();
            g.GameID = Convert.ToInt32(gameIdTextBox.Text);
            g.GameName = gameNameTextBox.Text;
            g.Genre = genreTextBox.Text;

            GameController gc = new GameController();
            gc.UpdateGame(g);

            MessageBox.Show("Game updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateGamesGrid();
            clearButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gameIdTextBox.Text))
            {
                MessageBox.Show("Please select a game from the list to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int gameId = Convert.ToInt32(gameIdTextBox.Text);

            GameController gc = new GameController();
            gc.DeleteGame(gameId);

            MessageBox.Show("Game deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateGamesGrid();
            clearButton_Click(sender, e);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard(this.adminUser);
            ad.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}