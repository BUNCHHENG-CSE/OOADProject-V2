using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Strategies;

internal class ProductSearchEngine
{
    private IProductSearchStrategy _strategy;

    public void SetStrategy(IProductSearchStrategy strategy)
    {
        _strategy = strategy;
    }

    public IEnumerable<Products> Search(IEnumerable<Products> products, string keyword)
    {
        return _strategy.Search(products, keyword);
    }
}
