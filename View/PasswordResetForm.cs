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
    public partial class PasswordResetForm : Form
    {
        public PasswordResetForm()
        {
            InitializeComponent();
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(newPasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("New passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserController uc = new UserController();
            User user = uc.SearchUserByUsername(usernameTextBox.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid details provided. Please check your information.", "Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlayerController pc = new PlayerController();
            Player player = pc.SearchPlayerByUserId(user.UserID);

            if (player == null)
            {
                MessageBox.Show("Invalid details provided. Please check your information.", "Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEmailCorrect = user.Email.Equals(emailTextBox.Text, StringComparison.OrdinalIgnoreCase);
            bool isDobCorrect = player.DateOfBirth.Date == dobPicker.Value.Date;

            if (isEmailCorrect && isDobCorrect)
            {
                user.PasswordHash = ComputeSha256Hash(newPasswordTextBox.Text);
                uc.UpdateUser(user);

                MessageBox.Show("Your password has been reset successfully. You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LoginForm lf = new LoginForm();
                lf.Show();
            }
            else
            {
                MessageBox.Show("Invalid details provided. Please check your information.", "Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
