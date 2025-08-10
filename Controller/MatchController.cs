using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.Controller
{
    public class MatchController
    {
        public void AddMatch(Match match)
        {
            Matches matchesDataAccess = new Matches();
            matchesDataAccess.AddMatch(match);
        }

        public void AddMatches(List<Match> matches)
        {
            Matches matchesDataAccess = new Matches();
            matchesDataAccess.AddMatches(matches);
        }

        public void UpdateMatchResult(Match match)
        {
            Matches matchesDataAccess = new Matches();
            matchesDataAccess.UpdateMatchResult(match);
        }

        public void DeleteMatch(int matchId)
        {
            Matches matchesDataAccess = new Matches();
            matchesDataAccess.DeleteMatch(matchId);
        }

        public void DeleteMatchesByTournament(int tournamentId)
        {
            Matches matchesDataAccess = new Matches();
            matchesDataAccess.DeleteMatchesByTournament(tournamentId);
        }

        public int GetMatchCountByTeam(int teamId)
        {
            Matches matchesDataAccess = new Matches();
            return matchesDataAccess.GetMatchCountByTeam(teamId);
        }

        public Match SearchMatchById(int matchId)
        {
            Matches matchesDataAccess = new Matches();
            Match match = matchesDataAccess.SearchMatchById(matchId);
            return match;
        }

        public List<Match> GetMatchesByTournament(int tournamentId)
        {
            Matches matchesDataAccess = new Matches();
            List<Match> matchList = matchesDataAccess.GetMatchesByTournament(tournamentId);
            return matchList;
        }

        public List<Match> GetMatchesByTournamentAndTeam(int tournamentId, int teamId)
        {
            Matches matchesDataAccess = new Matches();
            return matchesDataAccess.GetMatchesByTournamentAndTeam(tournamentId, teamId);
        }
    }
}
