using System;
using System.Collections.Generic;
//System.Windows.Forms.Form;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.forgetPasswordButton.Click += new System.EventHandler(this.forgetPasswordButton_Click);
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = ComputeSha256Hash(password);

            UserController uc = new UserController();
            User user = uc.SearchUser(username, hashedPassword);

            if (user != null)
            {
                if (user.IsActive == false)
                {
                    MessageBox.Show("Your account is deactivated. Please contact admin.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user.Role.Equals("Admin"))
                {
                    this.Hide();
                    AdminDashboard ad = new AdminDashboard(user);
                    ad.Show();
                }
                else if (user.Role.Equals("Player"))
                {
                    this.Hide();
                    PlayerDashboard pd = new PlayerDashboard(user);
                    pd.Show();
                }
                else
                {
                    MessageBox.Show("Unknown user role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
        }

        private void forgetPasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordResetForm prf = new PasswordResetForm();
            prf.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
