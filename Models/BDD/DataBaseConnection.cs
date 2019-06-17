using System.Data.SqlClient;
using System.Data.Common;
using System.Diagnostics;

namespace MatematicaFinanciera.Models.BDD
{
    public class DataBaseConnection
    {
        private static string stringConection = "Persist Security Info=False;User ID=sa;Password=Marvotouch-094027542;Initial Catalog=matematica_financiera;Server=giothcode-dev";
        private SqlConnection connection = new SqlConnection(stringConection);

        public SqlConnection getConnection()
        {
            return this.connection;
        }
    }
}