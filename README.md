# 🧾 Inventory Management System

A Windows Forms application for managing products, suppliers, orders, and generating reports using C# and MySQL.

## 🚀 Features

- 🔐 **Login System**
- 📦 **Product Management**  
  Add, update, delete, and view products.

- 🧑‍💼 **Supplier Management**  
  Manage supplier info and contact details.

- 📋 **Order Management**  
  Select products from suppliers and place orders.

- 📊 **Reports**  
  Generate filtered reports by date and supplier.

## 💻 Technologies Used

- **C# (.NET Framework - WinForms)**
- **MySQL Database**
- **MySQL Connector/NET**
- **Visual Studio 2022**

## 🛠️ Project Structure





## 🧰 Setup Instructions

### 📁 Prerequisites
- MySQL Server and Workbench
- Visual Studio with .NET Desktop Development
- MySQL Connector/NET

### 🗃️ Database Setup

1. Open **MySQL Workbench**
2. Run the `InventoryManagementSystem.sql` script provided
3. Ensure your `DBConnection.cs` has the correct credentials:
   ```csharp
   private static string connectionString = "server=localhost;user=root;database=inventory_db;password=yourpassword";
git clone https://github.com/your-username/InventoryManagementSystem.git
