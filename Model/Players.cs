using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Players
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddPlayer(Player player)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Players (PlayerID, Player_FName, Player_LName, DateOfBirth, UserID, TeamID) VALUES(@playerId, @fName, @lName, @dob, @userId, @teamId);");
            cmd.Parameters.AddWithValue("@playerId", player.PlayerID);
            cmd.Parameters.AddWithValue("@fName", player.Player_FName);
            cmd.Parameters.AddWithValue("@lName", player.Player_LName);
            cmd.Parameters.AddWithValue("@dob", player.DateOfBirth);
            cmd.Parameters.AddWithValue("@userId", player.UserID);
            if (player.TeamID.HasValue)
            {
                cmd.Parameters.AddWithValue("@teamId", player.TeamID.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@teamId", DBNull.Value);
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdatePlayer(Player player)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Players SET Player_FName=@fName, Player_LName=@lName, DateOfBirth=@dob, UserID=@userId, TeamID=@teamId WHERE PlayerID=@playerId;");
            cmd.Parameters.AddWithValue("@playerId", player.PlayerID);
            cmd.Parameters.AddWithValue("@fName", player.Player_FName);
            cmd.Parameters.AddWithValue("@lName", player.Player_LName);
            cmd.Parameters.AddWithValue("@dob", player.DateOfBirth);
            cmd.Parameters.AddWithValue("@userId", player.UserID);
            if (player.TeamID.HasValue)
            {
                cmd.Parameters.AddWithValue("@teamId", player.TeamID.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@teamId", DBNull.Value);
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeletePlayer(int playerId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Players WHERE PlayerID=@playerId;");
            cmd.Parameters.AddWithValue("@playerId", playerId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public Player SearchPlayerById(int playerId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Players WHERE PlayerID=@playerId;");
            cmd.Parameters.AddWithValue("@playerId", playerId);
            cmd.CommandType = CommandType.Text;
            List<Player> playerList = this.GetData(cmd);
            if (playerList.Count > 0)
            {
                return playerList[0];
            }
            else
            {
                return null;
            }
        }

        public List<Player> GetAllPlayers()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Players;");
            cmd.CommandType = CommandType.Text;
            List<Player> playerList = this.GetData(cmd);
            return playerList;
        }

        private List<Player> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Player> playerList = new List<Player>();
            using (reader)
            {
                while (reader.Read())
                {
                    Player player = new Player();
                    player.PlayerID = reader.GetInt32(0);
                    player.Player_FName = reader.GetString(1);
                    player.Player_LName = reader.GetString(2);
                    player.DateOfBirth = reader.GetDateTime(3);
                    player.UserID = reader.GetInt32(4);
                    if (!reader.IsDBNull(5))
                    {
                        player.TeamID = reader.GetInt32(5);
                    }
                    else
                    {
                        player.TeamID = null;
                    }
                    playerList.Add(player);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return playerList;
        }
    }
}