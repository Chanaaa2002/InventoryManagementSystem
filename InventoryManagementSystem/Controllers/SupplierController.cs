using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Utils;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem.Controllers
{
    public class SupplierController
    {
        public List<Supplier> GetAllSuppliers()
        {
            var suppliers = new List<Supplier>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM suppliers", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    suppliers.Add(new Supplier(
                        reader.GetInt32("id"),
                        reader.GetString("name"),
                        reader.GetString("contact_info")
                    ));
                }
            }
            return suppliers;
        }

        public void AddSupplier(Supplier supplier)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO suppliers (name, contact_info) VALUES (@name, @info)", conn);
                cmd.Parameters.AddWithValue("@name", supplier.Name);
                cmd.Parameters.AddWithValue("@info", supplier.ContactInfo);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("UPDATE suppliers SET name=@name, contact_info=@info WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@name", supplier.Name);
                cmd.Parameters.AddWithValue("@info", supplier.ContactInfo);
                cmd.Parameters.AddWithValue("@id", supplier.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSupplier(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("DELETE FROM suppliers WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
