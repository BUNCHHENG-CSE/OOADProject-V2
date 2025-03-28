using OOADPROV2.Models;
using OOADPROV2.Utilities.Factories;

namespace OOADPROV2.Utilities.Builder.Product;

public class ProductBuilder : IBuilder<Products>
{
    private string? _name;
    private int? _categoryId;
    private string? _description;
    private decimal? _price;
    private int? _stock;
    private byte[]? _image;
    private ProductBuilder() { }
    public static ProductBuilder Create() => new();

    public ProductBuilder WithName(string name)
    {
        _name = name;
        return this;
    }

    public ProductBuilder WithCategoryId(int categoryId)
    {
        _categoryId = categoryId;
        return this;
    }
    public ProductBuilder WithDescription(string? description)
    {
        _description = description;
        return this;
 
    }

    public ProductBuilder WithPrice(decimal price)
    {
        _price = price;
        return this;
    }

    public ProductBuilder WithStock(int stock)
    {
        _stock = stock;
        return this;
    }

    public ProductBuilder WithImage(byte[]? image)
    {
        _image = image;
        return this;
    }

    public Products Build()
    {

        if (string.IsNullOrWhiteSpace(_name) || _name.Trim().Length > 100)
            throw new InvalidOperationException("Product Name is required or too long");
        if (!_categoryId.HasValue)
            throw new InvalidOperationException("Category ID is required");
        if (!_price.HasValue)
            throw new InvalidOperationException("Product Price is required");
        if (!_stock.HasValue)
            throw new InvalidOperationException("Product Stock is required");

        return EntityFactory.CreateProduct(
            id: 0,
            name: _name.Trim(),
            price: _price.Value,
            description: _description.Trim(),
            stock: _stock.Value,
            image: _image,
            category: _categoryId.Value
         );
    }
}
