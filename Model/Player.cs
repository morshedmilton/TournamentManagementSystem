using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Player
    {
        private int playerId;
        private string player_FName;
        private string player_LName;
        private DateTime dateOfBirth;
        private int userId;
        private int? teamId;

        public Player()
        {
        }

        public Player(int playerId, string fName, string lName, DateTime dob, int userId, int? teamId)
        {
            this.playerId = playerId;
            this.player_FName = fName;
            this.player_LName = lName;
            this.dateOfBirth = dob;
            this.userId = userId;
            this.teamId = teamId;
        }

        public int PlayerID
        {
            get { return this.playerId; }
            set { this.playerId = value; }
        }

        public string Player_FName
        {
            get { return this.player_FName; }
            set { this.player_FName = value; }
        }

        public string Player_LName
        {
            get { return this.player_LName; }
            set { this.player_LName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public int UserID
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        public int? TeamID
        {
            get { return this.teamId; }
            set { this.teamId = value; }
        }
    }
}
