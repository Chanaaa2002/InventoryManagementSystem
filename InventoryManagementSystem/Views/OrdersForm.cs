using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Utils;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class OrdersForm : Form
    {
        private List<OrderItem> orderItems = new List<OrderItem>();
        private Dictionary<string, int> supplierMap = new Dictionary<string, int>();
        private Dictionary<string, int> productMap = new Dictionary<string, int>();

        public OrdersForm()
        {
            InitializeComponent();
            LoadSuppliers();
            LoadProducts();

            lstOrderItems.Items.Clear();
           

            lstOrderItems.SelectionMode = SelectionMode.One;
        }

        private void LoadSuppliers()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    

                    var cmd = new MySqlCommand("SELECT * FROM suppliers", conn);
                    var reader = cmd.ExecuteReader();

                    supplierMap.Clear();
                    cmbSuppliers.Items.Clear();

                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        int id = reader.GetInt32("id");
                        supplierMap[name] = id;
                        cmbSuppliers.Items.Add(name);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }


        private void LoadProducts()
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                   

                    var cmd = new MySqlCommand("SELECT id, name FROM products", conn);
                    var reader = cmd.ExecuteReader();

                    productMap.Clear();
                    cmbProducts.Items.Clear();

                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        int id = reader.GetInt32("id");
                        productMap[name] = id;
                        cmbProducts.Items.Add(name);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }


        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedItem == null || cmbProducts.SelectedItem == null || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string supplierName = cmbSuppliers.SelectedItem.ToString();
                string productName = cmbProducts.SelectedItem.ToString();
                int quantity = int.Parse(txtQuantity.Text);

                var item = new OrderItem
                {
                    SupplierId = supplierMap[supplierName],
                    ProductId = productMap[productName],
                    Quantity = quantity
                };

                orderItems.Add(item);
                lstOrderItems.Items.Add($"{supplierName} - {productName} x {quantity}");
                txtQuantity.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to order: " + ex.Message);
            }
        }

       

        private void btnClear1_Click(object sender, EventArgs e)
        {
            ClearForm();
            orderItems.Clear();
            lstOrderItems.Items.Clear();
        }

        private void ClearForm()
        {
            cmbSuppliers.SelectedIndex = -1;
            cmbProducts.SelectedIndex = -1;
            txtQuantity.Clear();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Optional unused event handlers
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtQuantity_TextChanged(object sender, EventArgs e) { }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Add items before placing an order.");
                return;
            }

            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // Insert into orders table
                    var cmd = new MySqlCommand("INSERT INTO orders (order_date) VALUES (NOW()); SELECT LAST_INSERT_ID();", conn);
                    int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Insert into order_items
                    foreach (var item in orderItems)
                    {
                        var itemCmd = new MySqlCommand("INSERT INTO order_items (order_id, supplier_id, product_id, quantity) VALUES (@orderId, @supplierId, @productId, @qty)", conn);
                        itemCmd.Parameters.AddWithValue("@orderId", orderId);
                        itemCmd.Parameters.AddWithValue("@supplierId", item.SupplierId);
                        itemCmd.Parameters.AddWithValue("@productId", item.ProductId);
                        itemCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        itemCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order placed successfully!");
                orderItems.Clear();
                lstOrderItems.Items.Clear();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to place order: " + ex.Message);
            }
        }
    }

   
}
