using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Controllers;

namespace InventoryManagementSystem
{
    public partial class ProductForm : Form
    {
         private ProductController controller = new ProductController();
        private int selectedProductId = -1;
        private User currentUser;

        public ProductForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadProducts();

            // Setup grid properties
            dataGridProducts.ReadOnly = true;
            dataGridProducts.AllowUserToAddRows = false;
            dataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Load all products into DataGridView
        private void LoadProducts()
        {
            var products = controller.GetAllProducts();
            dataGridProducts.Rows.Clear();

            foreach (var p in products)
            {
                dataGridProducts.Rows.Add(p.Id, p.Name, p.SKU, p.Quantity, p.Price);
            }
        }
        private void ClearForm()
        {
            txtName.Text = "";
            txtSKU.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            selectedProductId = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lb1Welcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product
                {
                    Name = txtName.Text,
                    SKU = txtSKU.Text,
                    Quantity = int.Parse(txtQty.Text),
                    Price = decimal.Parse(txtPrice.Text)
                };

                controller.AddProduct(p);
                MessageBox.Show("Product added successfully!");
                LoadProducts();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            try
            {
                Product p = new Product
                {
                    Id = selectedProductId,
                    Name = txtName.Text,
                    SKU = txtSKU.Text,
                    Quantity = int.Parse(txtQty.Text),
                    Price = decimal.Parse(txtPrice.Text)
                };

                controller.UpdateProduct(p);
                MessageBox.Show("Product updated!");
                LoadProducts();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == -1)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            controller.DeleteProduct(selectedProductId);
            MessageBox.Show("Product deleted!");
            LoadProducts();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridProducts.Rows[e.RowIndex];

                    selectedProductId = Convert.ToInt32(row.Cells[0].Value); 

                    txtName.Text = row.Cells[1].Value.ToString();
                    txtSKU.Text = row.Cells[2].Value.ToString();
                    txtQty.Text = row.Cells[3].Value.ToString();
                    txtPrice.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        //private void btnBack_Click(object sender, EventArgs e)
       // {
       //     MainForm main = new MainForm(currentUser);
       //     main.Show();
        //    this.Close();
       // }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            MainForm main = new MainForm(currentUser);
            main.Show();
            this.Close();

        }
    }
    
}
