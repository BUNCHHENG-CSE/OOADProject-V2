using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System.Data;

namespace OOADPROV2.Utilities.Commands.Product.Action;

public class AddCommand(Products product) : ICommand<bool>
{

    public bool Execute()
    {
        SqlCommand cmd = new("spInsertProduct", Helper.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@pn", product.ProductName);
        cmd.Parameters.AddWithValue("@pm", product.ProductsPrice);
        cmd.Parameters.AddWithValue("@ps", product.ProductsStock);
        cmd.Parameters.AddWithValue("@pd", product.ProductDescription);
        cmd.Parameters.AddWithValue("@pi", product.ProductImage);
        cmd.Parameters.AddWithValue("@cid",product.Category.CategoryID);
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
            Helper.Instance.CloseConnection();
        }
    }
}
