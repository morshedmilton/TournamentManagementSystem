using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Matches
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddMatch(Match match)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Matches (MatchID, Match_Round_Number, Match_DateTime, Status, Team1_Score, Team2_Score, TournamentID, Team1_ID, Team2_ID, WinnerTeamID) VALUES(@matchId, @roundNumber, @dateTime, @status, @t1Score, @t2Score, @tournamentId, @t1Id, @t2Id, @winnerId);");
            cmd.Parameters.AddWithValue("@matchId", match.MatchID);
            cmd.Parameters.AddWithValue("@roundNumber", match.Match_Round_Number);
            cmd.Parameters.AddWithValue("@dateTime", match.Match_DateTime);
            cmd.Parameters.AddWithValue("@status", match.Status);
            cmd.Parameters.AddWithValue("@t1Score", match.Team1_Score);
            cmd.Parameters.AddWithValue("@t2Score", match.Team2_Score);
            cmd.Parameters.AddWithValue("@tournamentId", match.TournamentID);
            cmd.Parameters.AddWithValue("@t1Id", match.Team1_ID);
            cmd.Parameters.AddWithValue("@t2Id", match.Team2_ID);
            if (match.WinnerTeamID.HasValue)
            {
                cmd.Parameters.AddWithValue("@winnerId", match.WinnerTeamID.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@winnerId", DBNull.Value);
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateMatchResult(Match match)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Matches SET Status=@status, Team1_Score=@t1Score, Team2_Score=@t2Score, WinnerTeamID=@winnerId WHERE MatchID=@matchId;");
            cmd.Parameters.AddWithValue("@matchId", match.MatchID);
            cmd.Parameters.AddWithValue("@status", match.Status);
            cmd.Parameters.AddWithValue("@t1Score", match.Team1_Score);
            cmd.Parameters.AddWithValue("@t2Score", match.Team2_Score);
            if (match.WinnerTeamID.HasValue)
            {
                cmd.Parameters.AddWithValue("@winnerId", match.WinnerTeamID.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@winnerId", DBNull.Value);
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteMatch(int matchId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Matches WHERE MatchID=@matchId;");
            cmd.Parameters.AddWithValue("@matchId", matchId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public Match SearchMatchById(int matchId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Matches WHERE MatchID=@matchId;");
            cmd.Parameters.AddWithValue("@matchId", matchId);
            cmd.CommandType = CommandType.Text;
            List<Match> matchList = this.GetData(cmd);
            if (matchList.Count > 0)
            {
                return matchList[0];
            }
            else
            {
                return null;
            }
        }

        public List<Match> GetMatchesByTournament(int tournamentId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Matches WHERE TournamentID=@tId;");
            cmd.Parameters.AddWithValue("@tId", tournamentId);
            cmd.CommandType = CommandType.Text;
            List<Match> matchList = this.GetData(cmd);
            return matchList;
        }

        private List<Match> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Match> matchList = new List<Match>();
            using (reader)
            {
                while (reader.Read())
                {
                    Match match = new Match();
                    match.MatchID = reader.GetInt32(0);
                    match.Match_Round_Number = reader.GetString(1);
                    match.Match_DateTime = reader.GetDateTime(2);
                    match.Status = reader.GetString(3);
                    match.Team1_Score = reader.GetInt32(4);
                    match.Team2_Score = reader.GetInt32(5);
                    match.TournamentID = reader.GetInt32(6);
                    match.Team1_ID = reader.GetInt32(7);
                    match.Team2_ID = reader.GetInt32(8);
                    if (!reader.IsDBNull(9))
                    {
                        match.WinnerTeamID = reader.GetInt32(9);
                    }
                    else
                    {
                        match.WinnerTeamID = null;
                    }
                    matchList.Add(match);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return matchList;
        }
    }
}