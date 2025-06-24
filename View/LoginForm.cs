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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserController uc = new UserController();
            User user = uc.SearchUser(username, password);

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

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}