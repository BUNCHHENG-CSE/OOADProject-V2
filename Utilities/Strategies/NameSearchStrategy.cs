using OOADPROV2.Models;

public class NameSearchStrategy : IProductSearchStrategy
{
    public List<Products> Search(List<Products> products, string filter)
    {
        return products
            .Where(p => p.ProductName.ToLower().Contains(filter.ToLower()))
            .ToList();
    }
}