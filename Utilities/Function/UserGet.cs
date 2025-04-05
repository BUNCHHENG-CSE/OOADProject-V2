using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Function;

public class UserGet
{
    public static IEnumerable<Users> All()
    {
        SqlCommand cmd = new("spReadAllUser", Database.Instance.OpenConnection());
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
        Database.Instance.CloseConnection();
    }
    public static Users One(Login login)
    {
        SqlCommand cmd = new("spReadOneUser", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@uname", login._username);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting user with username, {login._username} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();

        }
        Users? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToUserOneData();
            }
        }
        reader?.Close();
        Database.Instance.CloseConnection();
        return result;
    }
}
