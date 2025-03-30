using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Category.Action;

public class GetIDCommand : ICommand<IEnumerable<Categories>>
{
    public IEnumerable<Categories> Execute()
    {
        SqlCommand cmd = new("spReadAllCategoryID", Helper.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Category > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
            
        }
        if (reader != null && reader.HasRows == true)
        {
            var queryAbles = reader.Cast<IDataRecord>().AsQueryable();
            foreach (var record in queryAbles)
            {
                yield return reader.ToDisplayCategoryID();
            }
        }
        reader?.Close();
        Helper.Instance.CloseConnection();
    }
}
