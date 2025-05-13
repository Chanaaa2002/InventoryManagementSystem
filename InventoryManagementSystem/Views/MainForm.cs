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

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click_1(object sender, EventArgs e)
        {

        }
    }
}
