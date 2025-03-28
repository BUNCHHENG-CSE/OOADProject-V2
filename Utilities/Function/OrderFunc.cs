using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Function;

public static class OrderFunc
{
    public static IEnumerable<Orders> GetAllOrder(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spReadAllOrder", con);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting all Order > {ex.Message}");
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
                yield return reader.ToDisplayOrder();
            }
        }
        reader?.Close();
    }

    
    public static bool InsertOrderDetail(SqlConnection con, OrderDetails order)
    {
        SqlCommand cmd = new SqlCommand("spInsertOrderDetail", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@oid", order.Order.OrderID);
        cmd.Parameters.AddWithValue("@pid", order.Products.ProductsID);
        cmd.Parameters.AddWithValue("@oq", order.OrderQty);
        cmd.Parameters.AddWithValue("@up", order.UnitPrice);

        try
        {
            int affectedRows = cmd.ExecuteNonQuery();
            return affectedRows > 0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to insert order detail > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }


    }


    public static int CreateNewCustomer(SqlConnection con)
    {
        SqlCommand cmd = new SqlCommand("spCreateNewCustomer", con);
        cmd.CommandType = CommandType.StoredProcedure;

        try
        {
            int newCustomerId = Convert.ToInt32(cmd.ExecuteScalar());
            return newCustomerId; 
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to create new customer: {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }

}
