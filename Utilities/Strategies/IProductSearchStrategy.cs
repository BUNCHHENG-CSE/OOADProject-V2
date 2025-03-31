using OOADPROV2.Models;

public interface IProductSearchStrategy
{
    IEnumerable<Products> Search(IEnumerable<Products> products, string filter);
}