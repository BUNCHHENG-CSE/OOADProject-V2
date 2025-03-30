using OOADPROV2.Models;

public interface IProductSearchStrategy
{
    List<Products> Search(List<Products> products, string filter);
}