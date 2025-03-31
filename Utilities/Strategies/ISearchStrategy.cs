using OOADPROV2.Models;
namespace OOADPROV2.Utilities.Strategies;
public interface ISearchStrategy
{
    List<Products> Search(string searchText);
}

