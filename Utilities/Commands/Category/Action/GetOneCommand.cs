using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Category.Action;

public class GetOneCommand(int categoryID) : ICommand<IEnumerable<Categories>>
{
    public IEnumerable<Categories> Execute()
    {
        SqlCommand cmd = new("spReadOneCategory", Helper.Instance.OpenConnection());
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", categoryID);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting category with id, {categoryID} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Categories? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayCategory();
            }
        }
        reader?.Close();
        yield return result;
    }
}
