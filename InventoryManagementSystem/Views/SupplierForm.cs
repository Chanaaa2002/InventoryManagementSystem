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

namespace InventoryManagementSystem
{
    public partial class SupplierForm : Form
    {
        private SupplierController controller = new SupplierController();
        private int selectedSupplierId = -1;

        public SupplierForm()
        {
            InitializeComponent();
            LoadSuppliers();

            dataGridSuppliers1.ReadOnly = true;
            dataGridSuppliers1.AllowUserToAddRows = false;
            dataGridSuppliers1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadSuppliers()
        {
            var suppliers = controller.GetAllSuppliers();
            dataGridSuppliers1.Rows.Clear();

            foreach (var s in suppliers)
            {
                dataGridSuppliers1.Rows.Add(s.Id, s.Name, s.ContactInfo);
            }
        }

        private void ClearForm()
        {
            txtName1.Text = "";
            txtContact1.Text = "";
            selectedSupplierId = -1;
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            var s = new Supplier
            {
                Name = txtName1.Text,
                ContactInfo = txtContact1.Text
            };
            controller.AddSupplier(s);
            LoadSuppliers();
            ClearForm();
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to update.");
                return;
            }

            var s = new Supplier
            {
                Id = selectedSupplierId,
                Name = txtName1.Text,
                ContactInfo = txtContact1.Text
            };

            controller.UpdateSupplier(s);
            LoadSuppliers();
            ClearForm();
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == -1)
            {
                MessageBox.Show("Please select a supplier to delete.");
                return;
            }

            controller.DeleteSupplier(selectedSupplierId);
            LoadSuppliers();
            ClearForm();
        }

        private void btnClear4_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnBack5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtContact1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridSuppliers1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridSuppliers1.Rows[e.RowIndex];
                selectedSupplierId = Convert.ToInt32(row.Cells[0].Value);
                txtName1.Text = row.Cells[1].Value.ToString();
                txtContact1.Text = row.Cells[2].Value.ToString();
            }
        }
    }

}
