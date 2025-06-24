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
    }
}