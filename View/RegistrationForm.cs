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

            if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Passwords do not match.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(userIdTextBox.Text);
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;
            int playerId = userId;
            string fName = firstNameTextBox.Text;
            string lName = lastNameTextBox.Text;
            DateTime dob = dobPicker.Value;

            PlayerController playerController = new PlayerController();
            playerController.AddPlayer(userId, username, password, email, playerId, fName, lName, dob);

            MessageBox.Show("Player registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void userIdTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}