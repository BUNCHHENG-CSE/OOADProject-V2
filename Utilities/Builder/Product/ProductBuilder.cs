using OOADPROV2.Models;
using OOADPROV2.Utilities.Factories;

namespace OOADPROV2.Utilities.Builder.Product;

public class ProductBuilder : IBuilder<Products>
{
   private readonly Products _product = new();
    private ProductBuilder() { }
    public static ProductBuilder Create() => new();

    public ProductBuilder WithName(string name)
    {
        _product.ProductName = name;
        return this;
    }

    public ProductBuilder WithCategoryId(int categoryId)
    {
        _product.Category.CategoryID = categoryId;
        return this;
    }
    public ProductBuilder WithDescription(string? description)
    {
        _product.ProductDescription = description;
        return this;

    }

    public ProductBuilder WithPrice(decimal price)
    {
        _product.ProductsPrice = price;
        return this;
    }

    public ProductBuilder WithStock(int stock)
    {
        _product.ProductsStock = stock;
        return this;
    }

    public ProductBuilder WithImage(byte[]? image)
    {
        _product.ProductImage = image;
        return this;
    }

    public Products Build()
    {
        var (isValid, errorMessage) = ProductValidatorBuilder.Create().Build().Validate(_product);
        if (!isValid)
            throw new InvalidOperationException(errorMessage);

        return EntityFactory.CreateProduct(
            0,
            _product.ProductName,
            _product.ProductsPrice,
            _product.ProductDescription,
            _product.ProductsStock,
            _product.ProductImage,
            _product.Category.CategoryID
        );
    }
}
