using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Function;

public  static class ProductFunc
{
    public static IEnumerable<Products> GetAllProducts(SqlConnection con) {
        SqlCommand cmd = new SqlCommand("spReadAllProducts", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Products > {ex.Message}");
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
                yield return reader.ToDisplayProduct();
            }
        }
        reader?.Close();
    }
    public static bool AddProducts(SqlConnection con, Products product)
    {
        SqlCommand cmd = new SqlCommand("spInsertProduct", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@pn", product.ProductName);
        cmd.Parameters.AddWithValue("@pm", product.ProductsPrice);
        cmd.Parameters.AddWithValue("@ps", product.ProductsStock);
        cmd.Parameters.AddWithValue("@pd", product.ProductDescription);
        cmd.Parameters.AddWithValue("@pi", product.ProductImage);
        cmd.Parameters.AddWithValue("@cid", product.Category.CategoryID);
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
    public static bool UpdateProducts(SqlConnection con, Products product)
    {
        SqlCommand cmd = new SqlCommand("spUpdateProduct", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", product.ProductsID);
        cmd.Parameters.AddWithValue("@pn", product.ProductName);
        cmd.Parameters.AddWithValue("@pm", product.ProductsPrice);
        cmd.Parameters.AddWithValue("@ps", product.ProductsStock);
        cmd.Parameters.AddWithValue("@pd", product.ProductDescription);
        cmd.Parameters.AddWithValue("@pi", product.ProductImage);
        cmd.Parameters.AddWithValue("@cid", product.Category.CategoryID);
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
    public static bool DeleteProducts(SqlConnection con, int productID)
    {
        SqlCommand cmd = new SqlCommand("spDeleteProduct", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", productID);

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

