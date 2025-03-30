using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.User.Action;

public class GetAllCommand : ICommand<IEnumerable<Users>>
{
    public IEnumerable<Users> Execute()
    {
        SqlCommand cmd = new("spReadAllUser", Helper.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all User > {ex.Message}");
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
                yield return reader.ToUserAllData();
            }
        }
        reader?.Close();
        Helper.Instance.CloseConnection();
    }
}
