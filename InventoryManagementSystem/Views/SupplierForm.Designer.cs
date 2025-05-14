namespace InventoryManagementSystem
{
    partial class SupplierForm 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtContact1 = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnClear4 = new System.Windows.Forms.Button();
            this.btnBack5 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblSuppliers1 = new System.Windows.Forms.Label();
            this.dataGridSuppliers1 = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers1)).BeginInit();
            this.SuspendLayout();

            // txtName1
            this.txtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtName1.Location = new System.Drawing.Point(800, 140);
            this.txtName1.Size = new System.Drawing.Size(200, 24);
            this.txtName1.Name = "txtName1";
            this.txtName1.TextChanged += new System.EventHandler(this.txtName1_TextChanged);

            // txtContact1
            this.txtContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtContact1.Location = new System.Drawing.Point(800, 200);
            this.txtContact1.Size = new System.Drawing.Size(200, 24);
            this.txtContact1.Name = "txtContact1";
            this.txtContact1.TextChanged += new System.EventHandler(this.txtContact1_TextChanged);

            // btnAdd1
            this.btnAdd1.Text = "Add";
            this.btnAdd1.Location = new System.Drawing.Point(650, 300);
            this.btnAdd1.Size = new System.Drawing.Size(80, 40);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);

            // btnUpdate2
            this.btnUpdate2.Text = "Update";
            this.btnUpdate2.Location = new System.Drawing.Point(740, 300);
            this.btnUpdate2.Size = new System.Drawing.Size(80, 40);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);

            // btnDelete3
            this.btnDelete3.Text = "Delete";
            this.btnDelete3.Location = new System.Drawing.Point(830, 300);
            this.btnDelete3.Size = new System.Drawing.Size(80, 40);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Click += new System.EventHandler(this.btnDelete3_Click);

            // btnClear4
            this.btnClear4.Text = "Clear";
            this.btnClear4.Location = new System.Drawing.Point(920, 300);
            this.btnClear4.Size = new System.Drawing.Size(80, 40);
            this.btnClear4.Name = "btnClear4";
            this.btnClear4.Click += new System.EventHandler(this.btnClear4_Click);

            // btnBack5
            this.btnBack5.Text = "Back";
            this.btnBack5.Location = new System.Drawing.Point(950, 400);
            this.btnBack5.Size = new System.Drawing.Size(80, 30);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Click += new System.EventHandler(this.btnBack5_Click);

            // lblName
            this.lblName.Text = "Supplier Name";
            this.lblName.Location = new System.Drawing.Point(650, 140);
            this.lblName.Size = new System.Drawing.Size(120, 20);
            this.lblName.Name = "lblName";

            // lblContact
            this.lblContact.Text = "Contact Info";
            this.lblContact.Location = new System.Drawing.Point(650, 200);
            this.lblContact.Size = new System.Drawing.Size(100, 20);
            this.lblContact.Name = "lblContact";

            // lblSuppliers1
            this.lblSuppliers1.Text = "Suppliers:";
            this.lblSuppliers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblSuppliers1.Location = new System.Drawing.Point(50, 40);
            this.lblSuppliers1.Size = new System.Drawing.Size(150, 30);
            this.lblSuppliers1.Name = "lblSuppliers1";

            // dataGridSuppliers1
            this.dataGridSuppliers1.Location = new System.Drawing.Point(50, 90);
            this.dataGridSuppliers1.Size = new System.Drawing.Size(550, 350);
            this.dataGridSuppliers1.Name = "dataGridSuppliers1";
            this.dataGridSuppliers1.ReadOnly = true;
            this.dataGridSuppliers1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuppliers1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.Column0,
                this.SupplierName,
                this.ContactInfo
            });
            this.dataGridSuppliers1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSuppliers1_CellContentClick);

            // Column0 (Id)
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column0.HeaderText = "Id";
            this.Column0.Name = "Column0";
            this.Column0.Visible = false;

            // SupplierName
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Width = 200;

            // ContactInfo
            this.ContactInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactInfo.HeaderText = "Contact Info";
            this.ContactInfo.Name = "ContactInfo";
            this.ContactInfo.Width = 200;

            // Form setup
            this.ClientSize = new System.Drawing.Size(1080, 480);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.txtContact1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnDelete3);
            this.Controls.Add(this.btnClear4);
            this.Controls.Add(this.btnBack5);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSuppliers1);
            this.Controls.Add(this.dataGridSuppliers1);
            this.Name = "SupplierForm";
            this.Text = "Manage Suppliers";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtContact1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnClear4;
        private System.Windows.Forms.Button btnBack5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblSuppliers1;
        private System.Windows.Forms.DataGridView dataGridSuppliers1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactInfo;
    }
}

