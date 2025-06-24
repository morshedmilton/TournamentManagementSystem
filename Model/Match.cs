using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Match
    {
        private int matchId;
        private string match_Round_Number;
        private DateTime match_DateTime;
        private string status;
        private int team1_Score;
        private int team2_Score;
        private int tournamentId;
        private int team1_ID;
        private int team2_ID;
        private int? winnerTeamId;

        public Match()
        {
        }

        public Match(int matchId, string roundNumber, DateTime dateTime, string status, int team1Score, int team2Score, int tournamentId, int team1Id, int team2Id, int? winnerTeamId)
        {
            this.matchId = matchId;
            this.match_Round_Number = roundNumber;
            this.match_DateTime = dateTime;
            this.status = status;
            this.team1_Score = team1Score;
            this.team2_Score = team2Score;
            this.tournamentId = tournamentId;
            this.team1_ID = team1Id;
            this.team2_ID = team2Id;
            this.winnerTeamId = winnerTeamId;
        }
        public int MatchID
        {
            get { return this.matchId; }
            set { this.matchId = value; }
        }

        public string Match_Round_Number
        {
            get { return this.match_Round_Number; }
            set { this.match_Round_Number = value; }
        }

        public DateTime Match_DateTime
        {
            get { return this.match_DateTime; }
            set { this.match_DateTime = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public int Team1_Score
        {
            get { return this.team1_Score; }
            set { this.team1_Score = value; }
        }

        public int Team2_Score
        {
            get { return this.team2_Score; }
            set { this.team2_Score = value; }
        }

        public int TournamentID
        {
            get { return this.tournamentId; }
            set { this.tournamentId = value; }
        }

        public int Team1_ID
        {
            get { return this.team1_ID; }
            set { this.team1_ID = value; }
        }

        public int Team2_ID
        {
            get { return this.team2_ID; }
            set { this.team2_ID = value; }
        }

        public int? WinnerTeamID
        {
            get { return this.winnerTeamId; }
            set { this.winnerTeamId = value; }
        }
    }
}
