using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using ScottPlot;
using System;
using System.Data;

namespace OOADPROV2.Utilities;

public static class IDataRecordExtension
{
    #region Get Staff INFO. To Display On ListBox and Display Staff on TextBox When Click on ListBox
    //public static Staff ToDisplayStaff(this IDataReader record)
    //{
    //    int index = record.GetOrdinal("StaffID");
    //    int id = record.GetInt32(index);
    //    index = record.GetOrdinal("StaffName");
    //    string? staffname = record.GetString(index);
    //    index = record.GetOrdinal("StaffPosition");
    //    string? staffposition = record.GetString(index);
    //    index = record.GetOrdinal("Photo");
    //    byte[] photo = null;
    //    if (!record.IsDBNull(index)) photo = (byte[])record[index];
    //    return new Staff()
    //    {
    //        StaffID = id,
    //        StaffName = staffname,
    //        Gender = gender,
    //        BirthDate = birthdate,
    //        StaffPosition = staffposition,
    //        StaffAddress = staffaddress,
    //        ContactNumber = contactnumber,
    //        HiredDate = hireddate,
    //        Photo = photo,
    //    };
    //}
    public static Staff ToDisplayStaffID(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);

        return new Staff()
        {
            StaffID = id,
        };
    }

    public static Staff ToStaffAllData(this IDataReader record)
    {
        int index = record.GetOrdinal("StaffID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("StaffName");
        string? staffname = record.GetString(index);


        index = record.GetOrdinal("Gender");
        string? gender = record.GetString(index);

        index = record.GetOrdinal("BirthDate");
        DateTime birthdate = record.GetDateTime(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        index = record.GetOrdinal("StaffAddress");
        string? staffaddress = record.GetString(index);

        index = record.GetOrdinal("ContactNumber");
        string? contactnumber = record.GetString(index);


        index = record.GetOrdinal("HiredDate");
        DateTime hireddate = record.GetDateTime(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];



        return new Staff()
        {
            StaffID = id,
            StaffName = staffname,
            Gender = gender,
            BirthDate = birthdate,
            StaffPosition = staffposition,
            StaffAddress = staffaddress,
            ContactNumber = contactnumber,
            HiredDate = hireddate,
            Photo = photo,

        };
    }

    public static Staff ToStaffNameandPositionPhoto(this IDataReader record)
    {

        int index = record.GetOrdinal("StaffName");
        string? staffname = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        string? staffposition = record.GetString(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];
        return new Staff()
        {
            StaffName = staffname,
            StaffPosition = staffposition,
            Photo = photo,
        };
    }

    #endregion

    #region Get Staff INFO. To Display On ListBox and Display Product
    public static Products ToDisplayProduct(this IDataRecord record)
    {
        return new Products
        {
            ProductsID = record.GetInt32(record.GetOrdinal("ProductsID")),
            ProductName = record.GetString(record.GetOrdinal("ProductsName")),
            ProductsPrice = record.GetDecimal(record.GetOrdinal("Price")),
            ProductDescription = record.IsDBNull(record.GetOrdinal("ProductsDescription")) ? null : record.GetString(record.GetOrdinal("ProductsDescription")),
            ProductsStock = record.IsDBNull(record.GetOrdinal("ProductsStock")) ? 0 : record.GetInt32(record.GetOrdinal("ProductsStock")),
            ProductImage = record.IsDBNull(record.GetOrdinal("ProductsImage")) ? null : (byte[])record["ProductsImage"],
            Category = new Category
            {
                CategoryID = record.GetInt32(record.GetOrdinal("CategoryID")),
                CategoryName = record.IsDBNull(record.GetOrdinal("CategoryName")) ? null : record.GetString(record.GetOrdinal("CategoryName")),
                CategoryDescription = record.IsDBNull(record.GetOrdinal("CategoryDescription")) ? null : record.GetString(record.GetOrdinal("CategoryDescription"))
            }
        };
    }

    #endregion

    #region Get Category INFO. 
    public static Category ToDisplayCategory(this IDataReader record)
    {
        int index = record.GetOrdinal("CategoryID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("CategoryName");
        string? categoryName = record.GetString(index);

        index = record.GetOrdinal("CategoryDescription");
        string? categoryDescription = record.GetString(index);
        return new Category()
        {
           CategoryID = id,
           CategoryName = categoryName,
            CategoryDescription = categoryDescription
        };
    }
    public static Category ToDisplayCategoryID(this IDataReader record)
    {
        int index = record.GetOrdinal("CategoryID");
        int id = record.GetInt32(index);
        return new Category()
        {
            CategoryID = id,
        };
    }

    #endregion
    #region Get User INFO
    public static User ToDisplayUser(this IDataReader record)
    {
        int index = record.GetOrdinal("UserID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Username");
        string? username = record.GetString(index);
        return new User()
        {
            UserID = id,
            Username = username,
        };
    }
    public static User ToUserAllData(this IDataReader record)
    {
        Staff staff = new Staff();

        int index = record.GetOrdinal("UserID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Username");
        string? username = record.GetString(index);

        index = record.GetOrdinal("Password");
        string? password = record.GetString(index);

        index = record.GetOrdinal("StaffID");
        staff.StaffID = record.GetInt32(index);

        index = record.GetOrdinal("StaffName");
        staff.StaffName = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        staff.StaffPosition = record.GetString(index);

        index = record.GetOrdinal("Photo");
        byte[] photo = null;
        if (!record.IsDBNull(index)) photo = (byte[])record[index];
        staff.Photo = photo;
        return new User()
        {
            UserID = id,
            Username = username,
            Password = password,
            Staff = staff
        };
    }
    public static User ToUserAllDataToLogin(this IDataReader record)
    {
        Staff staff = new Staff();
        int index = record.GetOrdinal("UserID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("Username");
        string? username = record.GetString(index);

        index = record.GetOrdinal("Password");
        string? password = record.GetString(index);

        index = record.GetOrdinal("StaffID");
        staff.StaffID = record.GetInt32(index);

        index = record.GetOrdinal("StaffName");
        staff.StaffName = record.GetString(index);

        index = record.GetOrdinal("StaffPosition");
        staff.StaffPosition = record.GetString(index);

        return new User()
        {
            UserID = id,
            Username = username,
            Password = password,
            Staff = staff
        };

    }
        
    #endregion

        #region Order
    public static Order ToDisplayOrder(this IDataRecord record)
    {
        int index = record.GetOrdinal("OrderID");
        int orderid = record.GetInt32(index);

        index = record.GetOrdinal("DateOrder");
        DateTime dateorder = record.GetDateTime(index);

        index = record.GetOrdinal("TotalPrice");
        decimal totalprice = record.GetDecimal(index);

        index = record.GetOrdinal("CustomerID");
        int customerID = record.GetInt32(index);

        return new Order
        {
            OrderID = orderid,
            DateOrder = dateorder,
            TotalPrice = totalprice,
            Customer = new Customer
            {
                CustomerID = customerID
            }   
        };
    }

    public static Order ToOrderBasicInfo(this IDataRecord record)
    {
        return new Order
        {
            OrderID = record.GetInt32(record.GetOrdinal("OrderID")),
            DateOrder = record.GetDateTime(record.GetOrdinal("DateOrder"))
        };
    }

    
    #endregion

    #region OrderDetail
    public static OrderDetail ToDisplayOrderDetail(this IDataRecord record)
    {
        return new OrderDetail
        {
            OrderDetailID = record.GetInt32(record.GetOrdinal("OrderDetailID")),
            OrderQty = record.GetInt32(record.GetOrdinal("OrderQty")),
            UnitPrice = record.GetFloat(record.GetOrdinal("UnitPrice")),
            Order = new Order
            {
                OrderID = record.GetInt32(record.GetOrdinal("OrderID"))
            },
            Products = new Products
            {
                ProductsID = record.GetInt32(record.GetOrdinal("ProductID"))
            }
        };
    }
    public static OrderDetail ToOrderDetailWithProductInfo(this IDataReader record)
    {
        int orderDetailId = record.GetInt32(record.GetOrdinal("OrderDetailID"));
        int orderQty = record.GetInt32(record.GetOrdinal("OrderQty"));
        float unitPrice = record.GetFloat(record.GetOrdinal("UnitPrice"));
        int orderId = record.GetInt32(record.GetOrdinal("OrderID"));
        int productId = record.GetInt32(record.GetOrdinal("ProductsID"));
        string? productName = record.IsDBNull(record.GetOrdinal("ProductName")) ? null : record.GetString(record.GetOrdinal("ProductName"));

        return new OrderDetail
        {
            OrderDetailID = orderDetailId,
            OrderQty = orderQty,
            UnitPrice = unitPrice,
            Order = new Order
            {
                OrderID = orderId,
            },
            Products = new Products
            {
                ProductsID = productId,
            
            }
        };
    }

    public static OrderDetail ToOrderDetailBasicInfo(this IDataReader record)
    {
        return new OrderDetail
        {
            OrderDetailID = record.GetInt32(record.GetOrdinal("OrderDetailID")),
            Order = new Order {
                OrderID = record.GetInt32(record.GetOrdinal("OrderID"))
            }
        };
    }

    #endregion
}
