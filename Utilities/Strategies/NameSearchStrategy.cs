using OOADPROV2.Models;

public class NameSearchStrategy : IProductSearchStrategy
{
    public IEnumerable<Products> Search(IEnumerable<Products> products, string keyword)
    {
        return products.Where(p =>
            !string.IsNullOrEmpty(p.ProductName) &&
            p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase));
    }
}