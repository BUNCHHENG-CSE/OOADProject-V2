using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Product.Action;

namespace OOADPROV2.Utilities.Commands.Product;

public class ProductCommands
{
    public static IEnumerable<Products> GetAllProducts()
    {
        return new GetAllCommand().Execute();
    }

    public static bool AddProduct(Products product)
    {
        return new AddCommand(product).Execute();
    }
    public static bool UpdateProduct(Products product)
    {
        return new UpdateCommand(product).Execute();
    }
    public static bool DeleteProduct(int productId)
    {
        return new DeleteCommand(productId).Execute();
    }
}
