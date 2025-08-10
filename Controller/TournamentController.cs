using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.Controller
{
    public class TournamentController
    {
        public int AddTournament(Tournament tournament)
        {
            Tournaments tournamentsDataAccess = new Tournaments();
            return tournamentsDataAccess.AddTournament(tournament);
        }

        public void UpdateTournament(Tournament tournament)
        {
            Tournaments tournamentsDataAccess = new Tournaments();
            tournamentsDataAccess.UpdateTournament(tournament);
        }

        public void DeleteTournament(int tournamentId)
        {
            Tournaments tournamentsDataAccess = new Tournaments();
            tournamentsDataAccess.DeleteTournament(tournamentId);
        }

        public List<Tournament> GetAllTournaments()
        {
            Tournaments tournamentsDataAccess = new Tournaments();
            List<Tournament> tournamentList = tournamentsDataAccess.GetAllTournaments();
            return tournamentList;
        }

        public Tournament SearchTournamentById(int tournamentId)
        {
            Tournaments tournamentsDataAccess = new Tournaments();
            Tournament tournament = tournamentsDataAccess.SearchTournamentById(tournamentId);
            return tournament;
        }
    }
}
