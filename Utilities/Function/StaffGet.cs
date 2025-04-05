using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Function;

public class StaffGet
{
    public static IEnumerable<Staffs> All()
    {
        SqlCommand cmd = new("spReadAllStaff", Database.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Staff > {ex.Message}");
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
                yield return reader.ToStaffAllData();
            }
        }
        reader?.Close();
        Database.Instance.CloseConnection();
    }
    public static IEnumerable<Staffs> ID()
    {
        SqlCommand cmd = new("spReadAllStaffID", Database.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Staff ID > {ex.Message}");
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
                yield return reader.ToDisplayStaffID();
            }
        }
        reader?.Close();
        Database.Instance.CloseConnection();
    }
    public static Staffs One(int staffID)
    {
        SqlCommand cmd = new("spReadOneStaffNameandPositionPhoto", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@id", staffID);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting staff with id, {staffID} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();

        }
        Staffs? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToStaffNameandPositionPhoto();
            }
        }
        reader?.Close();
        Database.Instance.CloseConnection();
        return result;
    }
}
