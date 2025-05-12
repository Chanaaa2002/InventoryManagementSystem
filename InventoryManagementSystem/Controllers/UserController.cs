using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Utils;


namespace InventoryManagementSystem.Controllers
{
    public class UserController
    {
        public User ValidateLogin(string username, string password)
        {
            MySqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            string query = "SELECT * FROM users WHERE username = @username AND password = @password";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User user = new User(
                    reader.GetInt32("id"),
                    reader.GetString("username"),
                    reader.GetString("password"),
                    reader.GetString("role")
                );


                conn.Close();
                return user;

            }

            conn.Close();
            return null;
        }
    }

}
