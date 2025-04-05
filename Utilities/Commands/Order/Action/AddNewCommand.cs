using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Order.Action;

public class AddNewCommand : ICommand<int>
{
    public int Execute()
    {
        SqlCommand cmd = new("spCreateNewCustomer", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };

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
            Database.Instance.CloseConnection();
        }
    }
}
