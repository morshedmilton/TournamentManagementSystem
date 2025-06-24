using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Management_System.Controller;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(userIdTextBox.Text) ||
                    string.IsNullOrEmpty(usernameTextBox.Text) ||
                    string.IsNullOrEmpty(passwordTextBox.Text) ||
                    string.IsNullOrEmpty(confirmPasswordTextBox.Text) ||
                    string.IsNullOrEmpty(emailTextBox.Text) ||
                    string.IsNullOrEmpty(firstNameTextBox.Text) ||
                    string.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(userIdTextBox.Text, out int userId))
                {
                    MessageBox.Show("User ID must be a valid number.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
                {
                    MessageBox.Show("Passwords do not match.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserController uc = new UserController();
                if (uc.IsUserIdTaken(userId))
                {
                    MessageBox.Show("This User ID is already taken. Please choose another one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (uc.IsUsernameTaken(usernameTextBox.Text))
                {
                    MessageBox.Show("This Username is already taken. Please choose another one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (uc.IsEmailTaken(emailTextBox.Text))
                {
                    MessageBox.Show("This Email is already registered. Please use another one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;
                int playerId = userId;
                string fName = firstNameTextBox.Text;
                string lName = lastNameTextBox.Text;
                DateTime dob = dobPicker.Value;

                PlayerController playerController = new PlayerController();
                playerController.AddPlayer(userId, username, password, email, playerId, fName, lName, dob);

                MessageBox.Show("Player registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                LoginForm lf = new LoginForm();
                lf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred during registration. Please try again.\n\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
