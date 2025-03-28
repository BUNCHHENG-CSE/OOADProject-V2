using Microsoft.Data.SqlClient;
using System.Data;

namespace OOADPROV2.Utilities.Commands.Product.Action;

public class DeleteCommand(int productID) : ICommand<bool>
{
    private readonly int _productID = productID;

    public bool Execute()
    {
        SqlCommand cmd = new SqlCommand("spDeleteProduct", Helper.Instance.OpenConnection());
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", _productID);

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
