using InventoryManagementSystem.Models;
using InventoryManagementSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.Controllers
{
    public class OrderController
    {
        public void PlaceOrder(List<OrderItem> items)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                try
                {
                    string orderQuery = "INSERT INTO orders (date) VALUES (NOW()); SELECT LAST_INSERT_ID();";
                    MySqlCommand orderCmd = new MySqlCommand(orderQuery, conn, transaction);
                    int orderId = Convert.ToInt32(orderCmd.ExecuteScalar());

                    foreach (var item in items)
                    {
                        string itemQuery = "INSERT INTO order_items (order_id, supplier_id, product_id, quantity) VALUES (@orderId, @supplierId, @productId, @qty)";
                        MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@orderId", orderId);
                        itemCmd.Parameters.AddWithValue("@supplierId", item.SupplierId);
                        itemCmd.Parameters.AddWithValue("@productId", item.ProductId);
                        itemCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        itemCmd.ExecuteNonQuery();

                        string updateStock = "UPDATE products SET quantity = quantity + @qty WHERE id = @productId";
                        MySqlCommand stockCmd = new MySqlCommand(updateStock, conn, transaction);
                        stockCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        stockCmd.Parameters.AddWithValue("@productId", item.ProductId);
                        stockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
