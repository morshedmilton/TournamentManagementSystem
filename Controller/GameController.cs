using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.Controller
{
    public class GameController
    {
        public void AddGame(Game game)
        {
            Games gamesDataAccess = new Games();
            gamesDataAccess.AddGame(game);
        }

        public void UpdateGame(Game game)
        {
            Games gamesDataAccess = new Games();
            gamesDataAccess.UpdateGame(game);
        }

        public void DeleteGame(int gameId)
        {
            Games gamesDataAccess = new Games();
            gamesDataAccess.DeleteGame(gameId);
        }

        public List<Game> GetAllGames()
        {
            Games gamesDataAccess = new Games();
            List<Game> gameList = gamesDataAccess.GetAllGames();
            return gameList;
        }

        public Game SearchGameById(int gameId)
        {
            Games gamesDataAccess = new Games();
            Game game = gamesDataAccess.SearchGameById(gameId);
            return game;
        }
    }
}