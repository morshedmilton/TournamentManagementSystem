using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.Controller
{
    public class TeamController
    {
        public void AddTeam(Team team)
        {
            Teams teamsDataAccess = new Teams();
            teamsDataAccess.AddTeam(team);
        }

        public void UpdateTeam(Team team)
        {
            Teams teamsDataAccess = new Teams();
            teamsDataAccess.UpdateTeam(team);
        }

        public void DeleteTeam(int teamId)
        {
            Teams teamsDataAccess = new Teams();
            teamsDataAccess.DeleteTeam(teamId);
        }

        public List<Team> GetAllTeams()
        {
            Teams teamsDataAccess = new Teams();
            List<Team> teamList = teamsDataAccess.GetAllTeams();
            return teamList;
        }

        public Team SearchTeamById(int teamId)
        {
            Teams teamsDataAccess = new Teams();
            Team team = teamsDataAccess.SearchTeamById(teamId);
            return team;
        }
    }
}