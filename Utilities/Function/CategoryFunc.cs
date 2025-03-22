using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System.Data;

namespace OOADPROV2.Utilities.Function;

public class CategoryFunc
{
    public static IEnumerable<Category> GetAllCategory(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllCategory", con);
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
    }
    public static IEnumerable<Category> GetAllCategoryID(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllCategoryID", con);
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
    }
    public static Category GetOneCategory(SqlConnection con, int id)
    {
        SqlCommand cmd = new SqlCommand("spReadOneCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting category with id, {id} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Category? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToDisplayCategory();
            }
        }
        reader?.Close();
        return result;
    }
    public static bool AddCategory(SqlConnection con, Category category)
    {
        SqlCommand cmd = new SqlCommand("spInsertCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@cateN", category.CategoryName);
        cmd.Parameters.AddWithValue("@cateDes", category.CategoryDescription);

        try
        {
            int effected = cmd.ExecuteNonQuery();
            return effected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in adding new category > {ex.Message}");

        }
        finally
        {
            cmd.Dispose();
        }

    }
    public static bool UpdateCategory(SqlConnection con, Category category)
    {
        SqlCommand cmd = new SqlCommand("spUpdateCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", category.CategoryID);
        cmd.Parameters.AddWithValue("@cateN", category.CategoryName);
        cmd.Parameters.AddWithValue("@cateDes", category.CategoryDescription);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing category > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static bool DeleteCategory(SqlConnection con, int categoryID)
    {
        SqlCommand cmd = new SqlCommand("spDeleteCategory", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", categoryID);

        try
        {
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to delete category > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}
