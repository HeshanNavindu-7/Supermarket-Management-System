using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AllinOne.DataAccessLayer
{
    public  class ConnectionManger
    {
        public static SqlConnection newcon;
        public static string Constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            newcon = new SqlConnection(Constr);
            return newcon;
        }

        public static String type;
      
        
    }
}
