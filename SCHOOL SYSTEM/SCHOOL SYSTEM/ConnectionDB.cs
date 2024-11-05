using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCHOOL_SYSTEM
{
    internal class ConnectionDB
    {
        public ConnectionDB() { }

        public MySqlConnection ConnectDB()
        {
            
            
            String con_string = "datasource=127.0.0.1;port=3306;username=root;Password=;Database=schoolmanagement;";

            MySqlConnection con = new MySqlConnection(con_string);
            return con;

        }
    }
}
