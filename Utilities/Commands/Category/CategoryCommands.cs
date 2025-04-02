using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Category.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Category;

public class CategoryCommands
{
    public static bool AddCategory(Categories category)
    {
        return new AddCommand(category).Execute();
    }
    public static bool UpdateCategory(Categories category)
    {
        return new UpdateCommand(category).Execute();
    }
    public static bool DeleteCategory(int categoryID)
    {
        return new DelectCommand(categoryID).Execute();
    }
 
}
