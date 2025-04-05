using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Category.Action;

public class DelectCommand(int categoryID) : ICommand<bool>
{
    public bool Execute()
    {
        SqlCommand cmd = new("spDeleteCategory", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@id", categoryID);

        try
        {
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete category > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
            Database.Instance.CloseConnection();
        }
    }
}
