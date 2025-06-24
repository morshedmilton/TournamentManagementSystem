using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Users
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddUser(User user)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Users (UserID, Username, PasswordHash, Email, Role, IsActive) VALUES(@userId, @username, @password, @email, @role, @isActive);");
            cmd.Parameters.AddWithValue("@userId", user.UserID);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.PasswordHash);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@isActive", user.IsActive);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateUser(User user)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Users SET Username=@username, PasswordHash=@password, Email=@email, Role=@role, IsActive=@isActive WHERE UserID=@userId;");
            cmd.Parameters.AddWithValue("@userId", user.UserID);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.PasswordHash);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@isActive", user.IsActive);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteUser(int userId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Users WHERE UserID=@userId;");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public User SearchUser(string username, string password)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users WHERE Username=@username AND PasswordHash=@password;");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.CommandType = CommandType.Text;
            List<User> userList = this.GetData(cmd);
            if (userList.Count > 0)
            {
                return userList[0];
            }
            else
            {
                return null;
            }
        }

        public User SearchUserById(int userId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users WHERE UserID=@userId;");
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.CommandType = CommandType.Text;
            List<User> userList = this.GetData(cmd);
            if (userList.Count > 0)
            {
                return userList[0];
            }
            else
            {
                return null;
            }
        }

        public List<User> GetAllUsers()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users;");
            cmd.CommandType = CommandType.Text;
            List<User> userList = this.GetData(cmd);
            return userList;
        }

        private List<User> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> userList = new List<User>();
            using (reader)
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.UserID = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.PasswordHash = reader.GetString(2);
                    user.Email = reader.GetString(3);
                    user.Role = reader.GetString(4);
                    user.IsActive = reader.GetBoolean(5);
                    userList.Add(user);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return userList;
        }
    }
}