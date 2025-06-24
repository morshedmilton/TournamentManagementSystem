using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class TournamentRegistrations
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddRegistration(TournamentRegistration reg)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO TournamentRegistrations (RegistrationID, TournamentID, TeamID) VALUES(@regId, @tournamentId, @teamId);");
            cmd.Parameters.AddWithValue("@regId", reg.RegistrationID);
            cmd.Parameters.AddWithValue("@tournamentId", reg.TournamentID);
            cmd.Parameters.AddWithValue("@teamId", reg.TeamID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateRegistration(TournamentRegistration reg)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE TournamentRegistrations SET TournamentID=@tournamentId, TeamID=@teamId WHERE RegistrationID=@regId;");
            cmd.Parameters.AddWithValue("@regId", reg.RegistrationID);
            cmd.Parameters.AddWithValue("@tournamentId", reg.TournamentID);
            cmd.Parameters.AddWithValue("@teamId", reg.TeamID);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteRegistration(int regId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM TournamentRegistrations WHERE RegistrationID=@regId;");
            cmd.Parameters.AddWithValue("@regId", regId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public TournamentRegistration SearchRegistrationById(int regId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM TournamentRegistrations WHERE RegistrationID=@regId;");
            cmd.Parameters.AddWithValue("@regId", regId);
            cmd.CommandType = CommandType.Text;
            List<TournamentRegistration> regList = this.GetData(cmd);
            if (regList.Count > 0)
            {
                return regList[0];
            }
            else
            {
                return null;
            }
        }

        public List<TournamentRegistration> GetAllRegistrations()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM TournamentRegistrations;");
            cmd.CommandType = CommandType.Text;
            List<TournamentRegistration> regList = this.GetData(cmd);
            return regList;
        }

        public List<TournamentRegistration> GetRegistrationsByTournament(int tournamentId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM TournamentRegistrations WHERE TournamentID=@tId;");
            cmd.Parameters.AddWithValue("@tId", tournamentId);
            cmd.CommandType = CommandType.Text;
            List<TournamentRegistration> regList = this.GetData(cmd);
            return regList;
        }

        private List<TournamentRegistration> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<TournamentRegistration> regList = new List<TournamentRegistration>();
            using (reader)
            {
                while (reader.Read())
                {
                    TournamentRegistration reg = new TournamentRegistration();
                    reg.RegistrationID = reader.GetInt32(0);
                    reg.TournamentID = reader.GetInt32(1);
                    reg.TeamID = reader.GetInt32(2);
                    regList.Add(reg);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return regList;
        }
    }
}