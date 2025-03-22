using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System.Data;

namespace OOADPROV2.Utilities.Function;

public static class StaffFunc
{

    public static IEnumerable<Staff> GetAllStaff(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllStaff", con);
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
    }
    public static IEnumerable<Staff> GetAllStaffID(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllStaffID", con);
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
    }
    public static Staff GetOneStaffNameandPositionPhoto(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneStaffNameandPositionPhoto", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting staff with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Staff? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToStaffNameandPositionPhoto();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddStaff(SqlConnection con, Staff staff)
    {
        SqlCommand cmd = new SqlCommand("spInsertStaff", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@sn", staff.StaffName);
        cmd.Parameters.AddWithValue("@gen", staff.Gender);
        cmd.Parameters.AddWithValue("@bd", staff.BirthDate);
        cmd.Parameters.AddWithValue("@pos", staff.StaffPosition);
        cmd.Parameters.AddWithValue("@ad", staff.StaffAddress);
        cmd.Parameters.AddWithValue("@cn", staff.ContactNumber);
        cmd.Parameters.AddWithValue("@hd", staff.HiredDate);
        cmd.Parameters.AddWithValue("@ph", staff.Photo);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new staff > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool UpdateStaff(SqlConnection con, Staff staff)
    {
        SqlCommand cmd = new SqlCommand("spUpdateStaff", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", staff.StaffID);
        cmd.Parameters.AddWithValue("@sn", staff.StaffName);
        cmd.Parameters.AddWithValue("@gen", staff.Gender);
        cmd.Parameters.AddWithValue("@bd", staff.BirthDate);
        cmd.Parameters.AddWithValue("@pos", staff.StaffPosition);
        cmd.Parameters.AddWithValue("@ad", staff.StaffAddress);
        cmd.Parameters.AddWithValue("@cn", staff.ContactNumber);
        cmd.Parameters.AddWithValue("@hd", staff.HiredDate);
        cmd.Parameters.AddWithValue("@ph", staff.Photo);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing staff > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool DeleteStaff(SqlConnection con, int staffid)
    {
        SqlCommand cmd = new SqlCommand("spDeleteStaff", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", staffid);

        try
        {
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete product > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}
