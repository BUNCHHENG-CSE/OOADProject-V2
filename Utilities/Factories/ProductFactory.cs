using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Factories;

class ProductFactory
{
    public static Products CreateProduct(
            int id,
            string name,
            decimal price,
            string description,
            int stock,
            byte[]? image,
            Category category)
    {
        return new Products
        {
            ProductsID = id,
            ProductName = name,
            ProductsPrice = price,
            ProductDescription = description,
            ProductsStock = stock,
            ProductImage = image,
            Category = category
        };
    }

}
