using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Management_System.Controller;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.View
{
    public partial class PlayerProfileForm : Form
    {
        private User playerUser;
        private Player playerInfo;

        public PlayerProfileForm(User user)
        {
            InitializeComponent();
            this.playerUser = user;
            this.Load += new System.EventHandler(this.PlayerProfileForm_Load);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
        }

        private void PlayerProfileForm_Load(object sender, EventArgs e)
        {
            LoadPlayerProfile();
        }

        private void LoadPlayerProfile()
        {
            PlayerController pc = new PlayerController();
            this.playerInfo = pc.SearchPlayerByUserId(this.playerUser.UserID);

            if (this.playerInfo != null)
            {
                firstNameTextBox.Text = this.playerInfo.Player_FName;
                lastNameTextBox.Text = this.playerInfo.Player_LName;
                emailTextBox.Text = this.playerUser.Email;
                dobTextBox.Text = this.playerInfo.DateOfBirth.ToShortDateString();

                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                dobTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Could not load player profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentPasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(newPasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Please fill in all password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedCurrentPassword = ComputeSha256Hash(currentPasswordTextBox.Text);

            if (this.playerUser.PasswordHash != hashedCurrentPassword)
            {
                MessageBox.Show("The current password you entered is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("The new passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.playerUser.PasswordHash = ComputeSha256Hash(newPasswordTextBox.Text);

            UserController uc = new UserController();
            uc.UpdateUser(this.playerUser);

            MessageBox.Show("Your password has been changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            currentPasswordTextBox.Text = "";
            newPasswordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerDashboard pd = new PlayerDashboard(this.playerUser);
            pd.Show();
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
