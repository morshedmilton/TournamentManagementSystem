using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Tournaments
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public int AddTournament(Tournament tournament)
        {
            // The SQL query no longer includes TournamentID in the INSERT list.
            // We added "SET @tId = SCOPE_IDENTITY();" to get the new ID back.
            SqlCommand cmd = sda.GetQuery("INSERT INTO Tournaments (TournamentName, TournamentStartDate, TournamentEndDate, Status, GameID, Organizer_UserID) VALUES(@tName, @startDate, @endDate, @status, @gameId, @organizerId); SET @tId = SCOPE_IDENTITY();");

            // This is an output parameter to receive the new ID from the database.
            cmd.Parameters.Add("@tId", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@tName", tournament.TournamentName);
            cmd.Parameters.AddWithValue("@startDate", tournament.TournamentStartDate);
            cmd.Parameters.AddWithValue("@endDate", tournament.TournamentEndDate);
            cmd.Parameters.AddWithValue("@status", tournament.Status);
            cmd.Parameters.AddWithValue("@gameId", tournament.GameID);
            cmd.Parameters.AddWithValue("@organizerId", tournament.Organizer_UserID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            int newTournamentId = Convert.ToInt32(cmd.Parameters["@tId"].Value);
            cmd.Connection.Close();
            return newTournamentId;
        }

        public void UpdateTournament(Tournament tournament)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Tournaments SET TournamentName=@tName, TournamentStartDate=@startDate, TournamentEndDate=@endDate, Status=@status, GameID=@gameId, Organizer_UserID=@organizerId WHERE TournamentID=@tId;");
            cmd.Parameters.AddWithValue("@tId", tournament.TournamentID);
            cmd.Parameters.AddWithValue("@tName", tournament.TournamentName);
            cmd.Parameters.AddWithValue("@startDate", tournament.TournamentStartDate);
            cmd.Parameters.AddWithValue("@endDate", tournament.TournamentEndDate);
            cmd.Parameters.AddWithValue("@status", tournament.Status);
            cmd.Parameters.AddWithValue("@gameId", tournament.GameID);
            cmd.Parameters.AddWithValue("@organizerId", tournament.Organizer_UserID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteTournament(int tournamentId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Tournaments WHERE TournamentID=@tId;");
            cmd.Parameters.AddWithValue("@tId", tournamentId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public Tournament SearchTournamentById(int tournamentId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Tournaments WHERE TournamentID=@tId;");
            cmd.Parameters.AddWithValue("@tId", tournamentId);
            cmd.CommandType = CommandType.Text;
            List<Tournament> tournamentList = this.GetData(cmd);
            if (tournamentList.Count > 0)
            {
                return tournamentList[0];
            }
            else
            {
                return null;
            }
        }

        public List<Tournament> GetAllTournaments()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Tournaments;");
            cmd.CommandType = CommandType.Text;
            List<Tournament> tournamentList = this.GetData(cmd);
            return tournamentList;
        }

        private List<Tournament> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Tournament> tournamentList = new List<Tournament>();
            using (reader)
            {
                while (reader.Read())
                {
                    Tournament tournament = new Tournament();
                    tournament.TournamentID = reader.GetInt32(0);
                    tournament.TournamentName = reader.GetString(1);
                    tournament.TournamentStartDate = reader.GetDateTime(2);
                    tournament.TournamentEndDate = reader.GetDateTime(3);
                    tournament.Status = reader.GetString(4);
                    tournament.GameID = reader.GetInt32(5);
                    tournament.Organizer_UserID = reader.GetInt32(6);
                    tournamentList.Add(tournament);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return tournamentList;
        }
    }
}
