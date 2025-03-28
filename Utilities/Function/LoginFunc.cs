using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Function;

public class LoginFunc
{
    public static Users VerifiedCredentials(SqlConnection con, Login login)
    {
        SqlCommand cmd = new SqlCommand("spVerifiedUserCredential", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@usr", login._username);
        cmd.Parameters.AddWithValue("@passwd", login._password);
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
        Users? verify = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                verify = reader.ToUserAllDataToLogin();
            }
        }
        reader?.Close();
        return verify;
    }

}
