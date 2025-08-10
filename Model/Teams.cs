using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class Teams
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddTeam(Team team)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Teams (TeamName, Date_Created, Captain_PlayerID) VALUES(@teamName, @dateCreated, @captainPlayerId);");
            cmd.Parameters.AddWithValue("@teamName", team.TeamName);
            cmd.Parameters.AddWithValue("@dateCreated", team.Date_Created);
            if (team.Captain_PlayerID.HasValue)
            {
                cmd.Parameters.AddWithValue("@captainPlayerId", team.Captain_PlayerID.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@captainPlayerId", DBNull.Value);
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateTeam(Team team)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Teams SET TeamName=@teamName, Date_Created=@dateCreated, Captain_PlayerID=@captainPlayerId WHERE TeamID=@teamId;");
            cmd.Parameters.AddWithValue("@teamId", team.TeamID);
            cmd.Parameters.AddWithValue("@teamName", team.TeamName);
            cmd.Parameters.AddWithValue("@dateCreated", team.Date_Created);
            if (team.Captain_PlayerID.HasValue)
            {
                cmd.Parameters.AddWithValue("@captainPlayerId", team.Captain_PlayerID.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@captainPlayerId", DBNull.Value);
            }
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteTeam(int teamId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Teams WHERE TeamID=@teamId;");
            cmd.Parameters.AddWithValue("@teamId", teamId);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public Team SearchTeamById(int teamId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Teams WHERE TeamID=@teamId;");
            cmd.Parameters.AddWithValue("@teamId", teamId);
            cmd.CommandType = CommandType.Text;
            List<Team> teamList = this.GetData(cmd);
            if (teamList.Count > 0)
            {
                return teamList[0];
            }
            else
            {
                return null;
            }
        }

        public List<Team> GetAllTeams()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Teams;");
            cmd.CommandType = CommandType.Text;
            List<Team> teamList = this.GetData(cmd);
            return teamList;
        }

        private List<Team> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Team> teamList = new List<Team>();
            using (reader)
            {
                while (reader.Read())
                {
                    Team team = new Team();
                    team.TeamID = reader.GetInt32(0);
                    team.TeamName = reader.GetString(1);
                    team.Date_Created = reader.GetDateTime(2);
                    if (!reader.IsDBNull(3))
                    {
                        team.Captain_PlayerID = reader.GetInt32(3);
                    }
                    else
                    {
                        team.Captain_PlayerID = null;
                    }
                    teamList.Add(team);
                }
                reader.Close();
            }
            cmd.Connection.Close();
            return teamList;
        }
    }
}
