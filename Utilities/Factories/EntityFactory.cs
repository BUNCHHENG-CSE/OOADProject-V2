using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Factories;

public static class EntityFactory
{
    public static Products CreateProduct(int id, string name, decimal price, string description, int stock, byte[]? image, int category)
    {
        return new Products
        {
            ProductsID = id,
            ProductName = name,
            ProductsPrice = price,
            ProductDescription = description,
            ProductsStock = stock,
            ProductImage = image,
            Category = new Categories { CategoryID = category }
        };
    }
    public static Categories CreateCategory(int id, string name, string? description)
    {
        return new Categories
        {
            CategoryID = id,
            CategoryName = name,
            CategoryDescription = description
        };
    }
    public static Staffs CreateStaff(int id, string name, string gender, DateTime? birthdate, string position, string address, string contactnumber, DateTime? hireddate, byte[]? image)
    {
        return new Staffs
        {
            StaffID = id,
            StaffName = name,
            Gender = gender,
            BirthDate = birthdate,
            StaffPosition = position,
            StaffAddress = address,
            ContactNumber = contactnumber,
            HiredDate = hireddate,
            Photo = image
        };
    }
    public static Users CreateUser(int id, string name, string password, Staffs staff)
    {
        return new Users
        {
            UserID = id,
            Username = name,
            Password = password,
            Staff = staff
        };
    }
    public static string CreateConnectionString(string authType, string server, string database, string user = "", string password = "")
    {
        var helper = Helper.Instance;
        string connectionTemplate = helper.GetDBConnectionSetting(authType);

        return authType switch
        {
            "ServerAuth" => string.Format(connectionTemplate, server, database, user, password),
            "WindowAuth" => string.Format(connectionTemplate, server, database),
            _ => throw new ArgumentException("Unsupported Authentication Type")
        };
    }
}
