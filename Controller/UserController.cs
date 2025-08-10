using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.Controller
{
    public class UserController
    {
        public void AddUser(User user)
        {
            Users usersDataAccess = new Users();
            usersDataAccess.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            Users usersDataAccess = new Users();
            usersDataAccess.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            Users usersDataAccess = new Users();
            usersDataAccess.DeleteUser(userId);
        }

        public User SearchUser(string username, string password)
        {
            Users usersDataAccess = new Users();
            User user = usersDataAccess.SearchUser(username, password);
            return user;
        }
        public User SearchUserByUsername(string username)
        {
            Users usersDataAccess = new Users();
            User user = usersDataAccess.SearchUserByUsername(username);
            return user;
        }

        public User SearchUserById(int userId)
        {
            Users usersDataAccess = new Users();
            User user = usersDataAccess.SearchUserById(userId);
            return user;
        }

        public List<User> GetAllUsers()
        {
            Users usersDataAccess = new Users();
            List<User> userList = usersDataAccess.GetAllUsers();
            return userList;
        }

        public bool IsUserIdTaken(int userId)
        {
            Users usersDataAccess = new Users();
            return usersDataAccess.IsUserIdTaken(userId);
        }

        public bool IsUsernameTaken(string username)
        {
            Users usersDataAccess = new Users();
            return usersDataAccess.IsUsernameTaken(username);
        }

        public bool IsEmailTaken(string email)
        {
            Users usersDataAccess = new Users();
            return usersDataAccess.IsEmailTaken(email);
        }
    }
}
