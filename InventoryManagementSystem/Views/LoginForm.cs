using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Controllers;
using InventoryManagementSystem.Models;
//using InventoryManagementSystem.Controllers;
//using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        private UserController userController;
        public LoginForm()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            User loggedUser = userController.ValidateLogin(username, password);

            if (loggedUser != null)
            {
                MessageBox.Show($"Welcome, {loggedUser.Role}");

                MainForm main = new MainForm(loggedUser);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}