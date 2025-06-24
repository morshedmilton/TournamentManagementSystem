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
    }
}