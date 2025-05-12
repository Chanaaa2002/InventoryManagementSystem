namespace InventoryManagementSystem
{
    partial class SuppliersForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtContact1 = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.btnDelete3 = new System.Windows.Forms.Button();
            this.btnClear4 = new System.Windows.Forms.Button();
            this.btnBack5 = new System.Windows.Forms.Button();
            this.dataGridSuppliers1 = new System.Windows.Forms.DataGridView();
            this.lblSuppliers1 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(662, 142);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Supplier Name";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.Transparent;
            this.lblContact.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(671, 201);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(133, 26);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contact Info";
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName1.Location = new System.Drawing.Point(851, 142);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(200, 28);
            this.txtName1.TabIndex = 2;
            // 
            // txtContact1
            // 
            this.txtContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact1.Location = new System.Drawing.Point(851, 201);
            this.txtContact1.Name = "txtContact1";
            this.txtContact1.Size = new System.Drawing.Size(200, 28);
            this.txtContact1.TabIndex = 3;
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.Honeydew;
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd1.Location = new System.Drawing.Point(661, 315);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(93, 49);
            this.btnAdd1.TabIndex = 4;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = false;
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.BackColor = System.Drawing.Color.Honeydew;
            this.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate2.Location = new System.Drawing.Point(760, 315);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(93, 49);
            this.btnUpdate2.TabIndex = 5;
            this.btnUpdate2.Text = "Update";
            this.btnUpdate2.UseVisualStyleBackColor = false;
            // 
            // btnDelete3
            // 
            this.btnDelete3.BackColor = System.Drawing.Color.Honeydew;
            this.btnDelete3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete3.Location = new System.Drawing.Point(859, 315);
            this.btnDelete3.Name = "btnDelete3";
            this.btnDelete3.Size = new System.Drawing.Size(93, 49);
            this.btnDelete3.TabIndex = 6;
            this.btnDelete3.Text = "Delete";
            this.btnDelete3.UseVisualStyleBackColor = false;
            // 
            // btnClear4
            // 
            this.btnClear4.BackColor = System.Drawing.Color.Honeydew;
            this.btnClear4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear4.Location = new System.Drawing.Point(958, 315);
            this.btnClear4.Name = "btnClear4";
            this.btnClear4.Size = new System.Drawing.Size(93, 49);
            this.btnClear4.TabIndex = 7;
            this.btnClear4.Text = "Clear";
            this.btnClear4.UseVisualStyleBackColor = false;
            // 
            // btnBack5
            // 
            this.btnBack5.BackColor = System.Drawing.Color.Honeydew;
            this.btnBack5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack5.Location = new System.Drawing.Point(1001, 471);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Size = new System.Drawing.Size(76, 32);
            this.btnBack5.TabIndex = 8;
            this.btnBack5.Text = "Back";
            this.btnBack5.UseVisualStyleBackColor = false;
            // 
            // dataGridSuppliers1
            // 
            this.dataGridSuppliers1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierName,
            this.ContactInfo});
            this.dataGridSuppliers1.Location = new System.Drawing.Point(46, 114);
            this.dataGridSuppliers1.Name = "dataGridSuppliers1";
            this.dataGridSuppliers1.RowHeadersWidth = 51;
            this.dataGridSuppliers1.RowTemplate.Height = 24;
            this.dataGridSuppliers1.Size = new System.Drawing.Size(597, 360);
            this.dataGridSuppliers1.TabIndex = 9;
            this.dataGridSuppliers1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSuppliers1_CellContentClick);
            // 
            // lblSuppliers1
            // 
            this.lblSuppliers1.AutoSize = true;
            this.lblSuppliers1.BackColor = System.Drawing.Color.Transparent;
            this.lblSuppliers1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers1.Location = new System.Drawing.Point(40, 53);
            this.lblSuppliers1.Name = "lblSuppliers1";
            this.lblSuppliers1.Size = new System.Drawing.Size(152, 32);
            this.lblSuppliers1.TabIndex = 10;
            this.lblSuppliers1.Text = "Suppliers:";
            // 
            // SupplierName
            // 
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Width = 125;
            // 
            // ContactInfo
            // 
            this.ContactInfo.HeaderText = "Contact Info";
            this.ContactInfo.MinimumWidth = 6;
            this.ContactInfo.Name = "ContactInfo";
            this.ContactInfo.Width = 125;
            // 
            // SuppliersForm
            // 
            this.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1089, 515);
            this.Controls.Add(this.lblSuppliers1);
            this.Controls.Add(this.dataGridSuppliers1);
            this.Controls.Add(this.btnBack5);
            this.Controls.Add(this.btnClear4);
            this.Controls.Add(this.btnDelete3);
            this.Controls.Add(this.btnUpdate2);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.txtContact1);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.Name = "SuppliersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtContact1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button btnDelete3;
        private System.Windows.Forms.Button btnClear4;
        private System.Windows.Forms.Button btnBack5;
        private System.Windows.Forms.DataGridView dataGridSuppliers1;
        private System.Windows.Forms.Label lblSuppliers1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactInfo;
    }
}

