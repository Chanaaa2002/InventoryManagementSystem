using InventoryManagementSystem.Models;
using InventoryManagementSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.Controllers
{
    public class ReportController
    {
        public List<Report> GetReports(DateTime startDate, DateTime endDate, int? supplierId = null)
        {
            List<Report> reports = new List<Report>();

            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT s.name AS SupplierName, p.name AS ProductName, oi.quantity, o.order_date
                    FROM order_items oi
                    JOIN suppliers s ON oi.supplier_id = s.id
                    JOIN products p ON oi.product_id = p.id
                    JOIN orders o ON oi.order_id = o.id
                    WHERE o.order_date BETWEEN @start AND @end";

                if (supplierId.HasValue)
                {
                    query += " AND oi.supplier_id = @supplierId";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@start", startDate);
                cmd.Parameters.AddWithValue("@end", endDate);

                if (supplierId.HasValue)
                    cmd.Parameters.AddWithValue("@supplierId", supplierId.Value);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reports.Add(new Report
                    {
                        SupplierName = reader.GetString("SupplierName"),
                        ProductName = reader.GetString("ProductName"),
                        Quantity = reader.GetInt32("quantity"),
                        OrderDate = reader.GetDateTime("order_date")
                    });
                }
            }

            return reports;
        }
    }
}
