using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Utils;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class ReportsForm : Form
    {
        private ReportController controller = new ReportController();
        private Dictionary<string, int> supplierMap = new Dictionary<string, int>();

        public ReportsForm()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT * FROM suppliers", conn);
                var reader = cmd.ExecuteReader();

                cmbSupplier.Items.Clear();
                supplierMap.Clear();
                cmbSupplier.Items.Add("ALL");

                while (reader.Read())
                {
                    string name = reader.GetString("name");
                    int id = reader.GetInt32("id");
                    supplierMap[name] = id;
                    cmbSupplier.Items.Add(name);
                }

                cmbSupplier.SelectedIndex = 0;
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateFrom.Value.Date;
            DateTime endDate = dateTo.Value.Date;

            int? supplierId = null;
            string selectedSupplier = cmbSupplier.SelectedItem.ToString();

            if (selectedSupplier != "ALL" && supplierMap.ContainsKey(selectedSupplier))
            {
                supplierId = supplierMap[selectedSupplier];
            }

            List<Report> entries = controller.GetReports(startDate, endDate, supplierId);

            string report = string.Join("\n", entries.Select(entry =>
                $"{entry.OrderDate:yyyy-MM-dd} | {entry.SupplierName} - {entry.ProductName} x {entry.Quantity}"
            ));

            MessageBox.Show(string.IsNullOrEmpty(report) ? "No data found for this filter." : report,
                "Report Results");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic on supplier change
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
