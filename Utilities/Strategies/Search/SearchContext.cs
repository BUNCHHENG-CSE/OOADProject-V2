using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Strategies.Search;
public class SearchContext
{
    private ISearchStrategy _strategy;

    public SearchContext(ISearchStrategy strategy)
    {
        _strategy = strategy;
    }

    public List<Products> ExecuteSearch(string searchText)
    {
        return _strategy.Search(searchText);
    }
}

