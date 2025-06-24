using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Game
    {
        private int gameId;
        private string gameName;
        private string genre;

        public Game()
        {
        }

        public Game(int gameId, string gameName, string genre)
        {
            this.gameId = gameId;
            this.gameName = gameName;
            this.genre = genre;
        }

        public int GameID
        {
            get { return this.gameId; }
            set { this.gameId = value; }
        }

        public string GameName
        {
            get { return this.gameName; }
            set { this.gameName = value; }
        }

        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }
    }
}
