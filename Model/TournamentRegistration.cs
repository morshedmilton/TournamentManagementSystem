using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament_Management_System.Model
{
    public class TournamentRegistration
    {
        private int registrationId;
        private int tournamentId;
        private int teamId;

        public TournamentRegistration()
        {
        }

        public TournamentRegistration(int registrationId, int tournamentId, int teamId)
        {
            this.registrationId = registrationId;
            this.tournamentId = tournamentId;
            this.teamId = teamId;
        }

        public int RegistrationID
        {
            get { return this.registrationId; }
            set { this.registrationId = value; }
        }

        public int TournamentID
        {
            get { return this.tournamentId; }
            set { this.tournamentId = value; }
        }

        public int TeamID
        {
            get { return this.teamId; }
            set { this.teamId = value; }
        }
    }
}
