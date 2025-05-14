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

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        private User currentUser; // Fix: Corrected the variable name

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            lblWelcome.Text = $"Welcome, {user.Username} ({user.Role})"; // Fix: Added 'lblWelcome' control reference

            // Optional: Restrict Report access to Admins only
            if (user.Role != "Admin")
            {
                btnReports.Enabled = false; // Fix: Added 'btnReports' control reference
            }
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

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm sf = new SupplierForm();
            sf.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm pf = new ProductForm(currentUser);
            pf.Show();
        }

        private void lblWelcome_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm of = new OrdersForm();
            of.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm sf = new ReportsForm();
            sf.Show();
        }
    }
}
