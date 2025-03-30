using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.User.Action;

public class GetOneCommand(Login login) : ICommand<Users>
{
    public Users Execute()
    {
        SqlCommand cmd = new("spReadOneUser", Helper.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@unname", login._username);
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
        Helper.Instance.CloseConnection();
        return result;
    }
}

