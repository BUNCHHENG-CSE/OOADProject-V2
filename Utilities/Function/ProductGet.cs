using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Function;

public class ProductGet
{
    public static IEnumerable<Products> All()
    {
        SqlCommand cmd = new("spReadAllProducts", Database.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Products > {ex.Message}");
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
                yield return reader.ToDisplayProduct();
            }
        }
        reader?.Close();
        Database.Instance.CloseConnection();
    }
}
