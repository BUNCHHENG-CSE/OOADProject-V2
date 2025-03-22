using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Models;

public class Products
{
    public int ProductsID { get; set; }
    public string? ProductName { get; set; }
    public decimal ProductsPrice { get; set; }
    public string? ProductDescription { get; set; }
    public int ProductsStock { get; set; }
    public byte[]? ProductImage { get; set; }
    public Category? Category { get; set; }

}
