using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tournament_Management_System.Model
{
    public class SqlDbDataAccess
    {
        private const string connectionString = @"Data Source=DESKTOP-U1DMSHA; Initial Catalog=OnlineTournamentDB; Integrated Security=True";
        public SqlCommand GetQuery(string query)
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;

            return cmd;
        }
    }
}