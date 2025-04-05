using Microsoft.Data.SqlClient;
using System.Data;

namespace OOADPROV2.Utilities.Commands.Staff.Action;

public class DeleteCommand(int staffID) : ICommand<bool>
{

    public bool Execute()
    {
        SqlCommand cmd = new("spDeleteStaff", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@id", staffID);

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
            Database.Instance.CloseConnection();
        }
    }
}
