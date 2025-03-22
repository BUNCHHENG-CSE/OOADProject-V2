using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Strategies;

class SortByPriceStrategy :IProductStrategy
{
    public IEnumerable<Products> ApplyStrategy(IEnumerable<Products> products)
    {
        return products.OrderBy(p => p.ProductsPrice);
    }

}
