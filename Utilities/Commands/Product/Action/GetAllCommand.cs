using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using OOADPROV2.Utilities.Function;
using System.Data;
using System.Drawing;

namespace OOADPROV2.Utilities.Commands.Product.Action;

class GetAllCommand : ICommand<IEnumerable<Products>>
{
    public IEnumerable<Products> Execute()
    {
        SqlCommand cmd = new("spReadAllProducts", Helper.Instance.OpenConnection());
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
        Helper.Instance.CloseConnection();
    }
}
