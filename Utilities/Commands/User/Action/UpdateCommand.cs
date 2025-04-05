using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.User.Action;

public class UpdateCommand(Users user) : ICommand<bool>
{
    public bool Execute()
    {
        SqlCommand cmd = new("spUpdateUser", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@id", user.UserID);
        cmd.Parameters.AddWithValue("@usr", user.Username);
        cmd.Parameters.AddWithValue("@passwd", user.Password);
        cmd.Parameters.AddWithValue("@staid", user.Staff.StaffID);
        cmd.Parameters.AddWithValue("@stan", user.Staff.StaffName);
        cmd.Parameters.AddWithValue("@stapos", user.Staff.StaffPosition);
        try
        {
            int effected = cmd.ExecuteNonQuery();
            return (effected > 0);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed in updating existing user > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
            Database.Instance.CloseConnection();
        }
    }
}
