using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Utils
{
    public class DBConnection
    {
        private static string connStr = "server=localhost;user=Chanaka;password=dinuka3698;database=inventory_system;";
        //private static string connStr = "server=localhost;user=root;password=;database=inventory_system;";
        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;

        }
    }
}
