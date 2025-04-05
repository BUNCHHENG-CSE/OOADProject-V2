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

public class UpdateCommand(Categories categories) : ICommand<bool>
{
    public bool Execute()
    {
        SqlCommand cmd = new SqlCommand("spUpdateCategory", Database.Instance.OpenConnection());
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", categories.CategoryID);
        cmd.Parameters.AddWithValue("@cateN", categories.CategoryName);
        cmd.Parameters.AddWithValue("@cateDes", categories.CategoryDescription);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing category > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
            Database.Instance.CloseConnection();
        }
    }
}

