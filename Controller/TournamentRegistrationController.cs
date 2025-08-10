using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament_Management_System.Model;

namespace Tournament_Management_System.Controller
{
    public class TournamentRegistrationController
    {
        public void AddRegistration(TournamentRegistration reg)
        {
            TournamentRegistrations tournamentRegDataAccess = new TournamentRegistrations();
            tournamentRegDataAccess.AddRegistration(reg);
        }

        public void UpdateRegistration(TournamentRegistration reg)
        {
            TournamentRegistrations tournamentRegDataAccess = new TournamentRegistrations();
            tournamentRegDataAccess.UpdateRegistration(reg);
        }

        public void DeleteRegistration(int regId)
        {
            TournamentRegistrations tournamentRegDataAccess = new TournamentRegistrations();
            tournamentRegDataAccess.DeleteRegistration(regId);
        }

        public void DeleteRegistrationsByTournament(int tournamentId)
        {
            TournamentRegistrations trDataAccess = new TournamentRegistrations();
            trDataAccess.DeleteRegistrationsByTournament(tournamentId);
        }

        public bool IsTeamRegistered(int tournamentId, int teamId)
        {
            TournamentRegistrations trDataAccess = new TournamentRegistrations();
            return trDataAccess.IsTeamRegistered(tournamentId, teamId);
        }

        public int GetRegistrationCountByTeam(int teamId)
        {
            TournamentRegistrations trDataAccess = new TournamentRegistrations();
            return trDataAccess.GetRegistrationCountByTeam(teamId);
        }

        public TournamentRegistration SearchRegistrationById(int regId)
        {
            TournamentRegistrations tournamentRegDataAccess = new TournamentRegistrations();
            TournamentRegistration reg = tournamentRegDataAccess.SearchRegistrationById(regId);
            return reg;
        }

        public List<TournamentRegistration> GetAllRegistrations()
        {
            TournamentRegistrations tournamentRegDataAccess = new TournamentRegistrations();
            List<TournamentRegistration> regList = tournamentRegDataAccess.GetAllRegistrations();
            return regList;
        }

        public List<TournamentRegistration> GetRegistrationsByTeam(int teamId)
        {
            TournamentRegistrations trDataAccess = new TournamentRegistrations();
            return trDataAccess.GetRegistrationsByTeam(teamId);
        }
    }
}
