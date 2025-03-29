using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Order.Action;

public class GetAllCommand : ICommand<IEnumerable<Orders>>
{
    public IEnumerable<Orders> Execute()
    {
        SqlCommand cmd = new("spReadAllOrder", Helper.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Order > {ex.Message}");
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
                yield return reader.ToDisplayOrder();
            }
        }
        reader?.Close();
    }
}
