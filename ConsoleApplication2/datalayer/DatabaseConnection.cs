using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.dataLayer
{
    class DatabaseConnection
    {
        private static SqlConnection dBconnection;
        static DatabaseConnection()
            {
            dBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon2"].ConnectionString);
            }
        public static SqlConnection getConnection()
        {
            return dBconnection;
        }

      

    }
}
