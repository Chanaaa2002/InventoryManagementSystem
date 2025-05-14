using InventoryManagementSystem.Models;
using InventoryManagementSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.Controllers
{
    public class ProductController
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product(
                        reader.GetInt32("id"),
                        reader.GetString("name"),
                        reader.GetString("sku"),
                        reader.GetInt32("quantity"),
                        reader.GetDecimal("price")
                    ));
                }
            }
            return products;
        }

        public void AddProduct(Product p)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO products (name, sku, quantity, price) VALUES (@name, @sku, @qty, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@sku", p.SKU);
                cmd.Parameters.AddWithValue("@qty", p.Quantity);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProduct(Product p)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE products SET name=@name, sku=@sku, quantity=@qty, price=@price WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@sku", p.SKU);
                cmd.Parameters.AddWithValue("@qty", p.Quantity);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@id", p.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM products WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
