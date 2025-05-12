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

            UserController controller = new UserController();
            User user = controller.ValidateLogin(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Role}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SuppliersForm main = new MainForm();
                main.Show();
                this.Hide();  // hide login after success
            }
            else
            {
                lblMessage.Text = "Invalid username or password!";
            }
        }

    }
}