using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Strategies;

class FilterByStockStrategy : IProductStrategy
{
    private readonly int _minStock;

    public FilterByStockStrategy(int minStock)
    {
        _minStock = minStock;
    }

    public IEnumerable<Products> ApplyStrategy(IEnumerable<Products> products)
    {
        return products.Where(p => p.ProductsStock >= _minStock);
    }

}
