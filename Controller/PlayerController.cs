using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.Controller
{
    public class PlayerController
    {
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

        public void AddPlayer(int userId, string username, string password, string email, int playerId, string fName, string lName, DateTime dob)
        {
            Users usersDataAccess = new Users();
            Players playersDataAccess = new Players();

            string hashedPassword = this.ComputeSha256Hash(password);
            User newUser = new User(userId, username, hashedPassword, email, "Player", true);
            usersDataAccess.AddUser(newUser);

            Player newPlayer = new Player();
            newPlayer.PlayerID = playerId;
            newPlayer.Player_FName = fName;
            newPlayer.Player_LName = lName;
            newPlayer.DateOfBirth = dob;
            newPlayer.UserID = userId;
            newPlayer.TeamID = null;
            playersDataAccess.AddPlayer(newPlayer);
        }

        public void UpdatePlayer(Player player)
        {
            Players playersDataAccess = new Players();
            playersDataAccess.UpdatePlayer(player);
        }

        public void DeletePlayer(int playerId)
        {
            Players playersDataAccess = new Players();
            playersDataAccess.DeletePlayer(playerId);
        }

        public List<Player> GetAllPlayers()
        {
            Players playersDataAccess = new Players();
            List<Player> playerList = playersDataAccess.GetAllPlayers();
            return playerList;
        }

        public Player SearchPlayerById(int playerId)
        {
            Players playersDataAccess = new Players();
            Player player = playersDataAccess.SearchPlayerById(playerId);
            return player;
        }
    }
}
