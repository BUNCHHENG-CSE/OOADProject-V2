using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Order.Action;

public class AddCommand(OrderDetails orderDetails) : ICommand<bool>
{
    public bool Execute()
    {
        SqlCommand cmd = new("spInsertOrderDetail", Helper.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@oid", orderDetails.Order.OrderID);
        cmd.Parameters.AddWithValue("@pid", orderDetails.Products.ProductsID);
        cmd.Parameters.AddWithValue("@oq", orderDetails.OrderQty);
        cmd.Parameters.AddWithValue("@up", orderDetails.UnitPrice);

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
            Helper.Instance.CloseConnection();
        }
    }
}
