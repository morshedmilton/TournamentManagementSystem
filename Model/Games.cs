using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tournament_Management_System.Model
{
    public class Games
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddGame(Game game)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Games (GameID, GameName, Genre) VALUES(@gameId, @gameName, @genre);");
            cmd.Parameters.AddWithValue("@gameId", game.GameID);
            cmd.Parameters.AddWithValue("@gameName", game.GameName);
            cmd.Parameters.AddWithValue("@genre", game.Genre);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateGame(Game game)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Games SET GameName=@gameName, Genre=@genre WHERE GameID=@gameId;");
            cmd.Parameters.AddWithValue("@gameId", game.GameID);
            cmd.Parameters.AddWithValue("@gameName", game.GameName);
            cmd.Parameters.AddWithValue("@genre", game.Genre);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteGame(int gameId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Games WHERE GameID=@gameId;");
            cmd.Parameters.AddWithValue("@gameId", gameId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public Game SearchGameById(int gameId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Games WHERE GameID=@gameId;");
            cmd.Parameters.AddWithValue("@gameId", gameId);
            cmd.CommandType = CommandType.Text;
            List<Game> gameList = this.GetData(cmd);
            if (gameList.Count > 0)
            {
                return gameList[0];
            }
            else
            {
                return null;
            }
        }

        public List<Game> GetAllGames()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Games;");
            cmd.CommandType = CommandType.Text;
            List<Game> gameList = this.GetData(cmd);
            return gameList;
        }

        private List<Game> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Game> gameList = new List<Game>();
            using (reader)
            {
                while (reader.Read())
                {
                    Game game = new Game();
                    game.GameID = reader.GetInt32(0);
                    game.GameName = reader.GetString(1);
                    game.Genre = reader.GetString(2);
                    gameList.Add(game);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return gameList;
        }
    }
}