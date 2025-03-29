using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Builder.Category;

public class CategoryValidatorBuilder : IBuilder<Validator<Categories>>
{
    private CategoryValidatorBuilder() { }
    public static CategoryValidatorBuilder Create() => new();
    public Validator<Categories> Build()
    {
        return new Validator<Categories>()
             .AddRule(c => (!string.IsNullOrWhiteSpace(c.CategoryName) && c.CategoryName.Length <= 100,
                "Category name is required or too long (max 100 characters)."))
            .AddRule(c => (c.CategoryDescription?.Length <= 1000,
                "Category description is too long (max 1000 characters)."));
    }
}

