using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Function;

public class UserFunc
{
    public static IEnumerable<User> GetAllUser(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllUser", con);
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
    }
    public static bool AddUser(SqlConnection con, User user)
    {
        SqlCommand cmd = new SqlCommand("spInsertUser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@usr", user.Username);
        cmd.Parameters.AddWithValue("@passwd", user.Password);
        cmd.Parameters.AddWithValue("@staid", user.Staff.StaffID);
        cmd.Parameters.AddWithValue("@stan", user.Staff.StaffName);
        cmd.Parameters.AddWithValue("@stapos", user.Staff.StaffPosition);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new user > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }

    }
    public static bool UpdateUser(SqlConnection con, User user)
    {
        SqlCommand cmd = new SqlCommand("spUpdateUser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", user.UserID);
        cmd.Parameters.AddWithValue("@usr", user.Username);
        cmd.Parameters.AddWithValue("@passwd", user.Password);
        cmd.Parameters.AddWithValue("@staid", user.Staff.StaffID);
        cmd.Parameters.AddWithValue("@stan", user.Staff.StaffName);
        cmd.Parameters.AddWithValue("@stapos", user.Staff.StaffPosition);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing user > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }

    }
    public static bool DeleteUser(SqlConnection con, int userID)
    {
        SqlCommand cmd = new SqlCommand("spDeleteUser", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", userID);

        try
        {
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete user > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}
