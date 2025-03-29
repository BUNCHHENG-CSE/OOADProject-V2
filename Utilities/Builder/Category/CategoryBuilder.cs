using OOADPROV2.Models;
using OOADPROV2.Utilities.Factories;


namespace OOADPROV2.Utilities.Builder.Category;

public class CategoryBuilder : IBuilder<Categories>
{
   private readonly Categories _category = new();
    private CategoryBuilder() { }

    public static CategoryBuilder Create() => new();

    public CategoryBuilder WithCategoryName(string categoryname)
    {
        _category.CategoryName = categoryname;
        return this;
    }

    public CategoryBuilder WithCategoryDescription(string categorydescription)
    {
        _category.CategoryDescription = categorydescription;
        return this;
    }

    public Categories Build()
    {

        var (isValid, errorMessage) = CategoryValidatorBuilder.Create().Build().Validate(_category);
        if (!isValid)
        
            throw new InvalidOperationException(errorMessage);
        

        return EntityFactory.CreateCategory(
            0,
            _category.CategoryName,
            _category.CategoryDescription
        );
    }
}

