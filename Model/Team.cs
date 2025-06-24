using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Team
    {
        private int teamId;
        private string teamName;
        private DateTime date_Created;
        private int? captain_PlayerID;

        public Team()
        {
        }

        public Team(int teamId, string teamName, DateTime dateCreated, int? captainPlayerId)
        {
            this.teamId = teamId;
            this.teamName = teamName;
            this.date_Created = dateCreated;
            this.captain_PlayerID = captainPlayerId;
        }

        public int TeamID
        {
            get { return this.teamId; }
            set { this.teamId = value; }
        }

        public string TeamName
        {
            get { return this.teamName; }
            set { this.teamName = value; }
        }

        public DateTime Date_Created
        {
            get { return this.date_Created; }
            set { this.date_Created = value; }
        }

        public int? Captain_PlayerID
        {
            get { return this.captain_PlayerID; }
            set { this.captain_PlayerID = value; }
        }
    }
}
