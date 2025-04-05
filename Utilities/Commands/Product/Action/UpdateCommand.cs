using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Product.Action;

class UpdateCommand(Products product) : ICommand<bool>
{
    public bool Execute()
    {
        SqlCommand cmd = new("spUpdateProduct", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
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
            Database.Instance.CloseConnection();
        }
    }
}
