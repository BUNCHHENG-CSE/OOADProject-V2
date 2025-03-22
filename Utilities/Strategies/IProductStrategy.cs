using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Strategies;

interface IProductStrategy
{
    IEnumerable<Products> ApplyStrategy(IEnumerable<Products> products);

}
