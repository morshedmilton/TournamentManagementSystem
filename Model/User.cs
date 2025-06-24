using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class User
    {
        private int userId;
        private string username;
        private string passwordHash;
        private string email;
        private string role;
        private bool isActive;

        public User()
        {
        }

        public User(int userId, string username, string passwordHash, string email, string role, bool isActive)
        {
            this.userId = userId;
            this.username = username;
            this.passwordHash = passwordHash;
            this.email = email;
            this.role = role;
            this.isActive = isActive;
        }

        public int UserID
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string PasswordHash
        {
            get { return this.passwordHash; }
            set { this.passwordHash = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }
    }
}
