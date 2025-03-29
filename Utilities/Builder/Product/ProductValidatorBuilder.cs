using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Builder.Product;

public class ProductValidatorBuilder : IBuilder<Validator<Products>>
{
    private ProductValidatorBuilder() { }
    public static ProductValidatorBuilder Create() => new();
    public Validator<Products> Build()
    {
        return new Validator<Products>()
           .AddRule(p => (!string.IsNullOrWhiteSpace(p.ProductName) && p.ProductName.Length <= 100,
                "Product name is required or too long (max 100 characters)."))
            .AddRule(p => (p.Category != null && p.Category.CategoryID > 0,
                "Category is required."))
            .AddRule(p => ( p.ProductDescription?.Length <= 1000,
                "Product description is  too long (max 1000 characters)."))
            .AddRule(p => (p.ProductsPrice >= 0,
                "Product price is required and must be positive."))
            .AddRule(p => (p.ProductsStock >= 0,
                "Product stock is required and must be non-negative."));
    }
}
