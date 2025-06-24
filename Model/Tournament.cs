using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Tournament
    {
        private int tournamentId;
        private string tournamentName;
        private DateTime tournamentStartDate;
        private DateTime tournamentEndDate;
        private string status;
        private int gameId;
        private int organizer_UserID;

        public Tournament()
        {
        }

        public Tournament(int tournamentId, string tournamentName, DateTime startDate, DateTime endDate, string status, int gameId, int organizerUserId)
        {
            this.tournamentId = tournamentId;
            this.tournamentName = tournamentName;
            this.tournamentStartDate = startDate;
            this.tournamentEndDate = endDate;
            this.status = status;
            this.gameId = gameId;
            this.organizer_UserID = organizerUserId;
        }

        public int TournamentID
        {
            get { return this.tournamentId; }
            set { this.tournamentId = value; }
        }

        public string TournamentName
        {
            get { return this.tournamentName; }
            set { this.tournamentName = value; }
        }

        public DateTime TournamentStartDate
        {
            get { return this.tournamentStartDate; }
            set { this.tournamentStartDate = value; }
        }

        public DateTime TournamentEndDate
        {
            get { return this.tournamentEndDate; }
            set { this.tournamentEndDate = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int GameID
        {
            get { return this.gameId; }
            set { this.gameId = value; }
        }

        public int Organizer_UserID
        {
            get { return this.organizer_UserID; }
            set { this.organizer_UserID = value; }
        }
    }
}
