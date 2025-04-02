using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Strategies.Search;
public class SearchContext(ISearchStrategy strategy)
{
    private readonly ISearchStrategy _strategy = strategy;

    public List<Products> ExecuteSearch(string searchText)
    {
        return _strategy.Search(searchText);
    }
}

