using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Function;

public class CategoryGet
{
    public static IEnumerable<Categories> All()
    {
        SqlCommand cmd = new("spReadAllCategory", Helper.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Category > {ex.Message}");
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
                yield return reader.ToDisplayCategory();
            }
        }
        reader?.Close();
        Helper.Instance.CloseConnection();
    }
    public static IEnumerable<Categories> ID()
    {
        SqlCommand cmd = new("spReadAllCategoryID", Helper.Instance.OpenConnection());
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Category > {ex.Message}");
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
                yield return reader.ToDisplayCategoryID();
            }
        }
        reader?.Close();
        Helper.Instance.CloseConnection();
    }
    public static Categories One(int categoryID)
    {
        SqlCommand cmd = new("spReadOneCategory", Helper.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@id", categoryID);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting category with id, {categoryID} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();

        }
        Categories? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayCategory();
            }
        }
        reader?.Close();
        Helper.Instance.CloseConnection();
        return result;
    }
}
