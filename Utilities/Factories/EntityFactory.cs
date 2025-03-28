using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Factories;

public static class EntityFactory
{
    public static Products CreateProduct(
            int id,
            string name,
            decimal price,
            string description,
            int stock,
            byte[]? image,
            int category)
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
    public static Categories CreateCategory(
            int id,
            string name,
            string description)
    {
        return new Categories
        {
            CategoryID = id,
            CategoryName = name,
            CategoryDescription = description
        };
    }


}
