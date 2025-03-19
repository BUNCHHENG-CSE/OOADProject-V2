# OOAD Project - Optimized Version

## 🚀 Project Overview
This project is a **Windows Forms-based Store Management System**, optimized using **Design Patterns** for better **scalability, maintainability, and performance**.

## 📌 Key Features
✅ **Product Management** (CRUD operations)  
✅ **Order & Staff Management**  
✅ **Secure Login with Role-Based Access**  
✅ **Discount System**  
✅ **Auto UI Updates**  
✅ **Optimized Database Queries**  


## 🛠 Applied Design Patterns
### 1️⃣ Structural Patterns


### 2️⃣ Creational Patterns
- **Factory Method Pattern** → `EntityFactory.cs` handles dynamic object creation.  

### 3️⃣ Behavioral Patterns
- **Observer Pattern** → Auto-refresh for product & order updates in UI.  
- **Strategy Pattern** → Flexible discount calculations for orders.  


## 🔧 Installation & Setup
### 1️⃣ Prerequisites
- **.NET 8.0 SDK**
- **SQL Server**
- **MSIX Packaging Tool (For Deployment)**

### 2️⃣ Database Setup
1. Open **SQL Server Management Studio (SSMS)**.  
2. Execute **`OOADProcv2.sql`** to create database & tables.  
3. Update **`appsettings.json`** with database connection string.

### 3️⃣ Running the Application
```sh
dotnet run
```
or open in **Visual Studio** and press `F5`.

## 📦 Deployment Guide
- Package using **MSIX** or **Inno Setup**
- Ensure **SQL Server** is hosted for production
- Secure `.config` files before deployment

## 👥 Contributors & Teams
- **[Keo Sivphanchart]** - Developer
- **[Kea Sorvan]** - Developer
- **[Chhean Silapin]** - Developer
- **[Hang Bunchheng]** - Chilling 

## 📞 Support
For issues, please report to **[tsosupport@gmail.com]** or create an issue on **GitHub**.

✅ **Project is Fully Optimized & Ready for Deployment!** 🚀🔥
