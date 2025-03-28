using OOADPROV2.Models;
using OOADPROV2.Utilities.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOADPROV2.Utilities.Builder.Category;

public class CategoryBuilder : IBuilder<Categories>
{
    private string? _categoryname;
    private string? _categorydescription;
    private CategoryBuilder() { }

    public static CategoryBuilder Create() => new();

    public CategoryBuilder WithCategoryName(string categoryname)
    {
        _categoryname = categoryname;
        return this;
    }

    public CategoryBuilder WithCategoryDescription(string categorydescription)
    {
        _categorydescription = categorydescription;
        return this;
    }

    public Categories Build()
    {
        return EntityFactory.CreateCategory(
            0,
            _categoryname ?? throw new InvalidOperationException("Category Name is required"),
            _categorydescription ?? throw new InvalidOperationException("Category Description is required")
        );
    }
}

