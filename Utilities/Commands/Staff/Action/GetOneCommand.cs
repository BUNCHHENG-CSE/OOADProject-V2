using Microsoft.Data.SqlClient;
using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Staff.Action;

public class GetOneCommand (int staffID) : ICommand<Staffs>
{
    public Staffs Execute()
    {
        SqlCommand cmd = new("spReadOneStaffNameandPositionPhoto", Helper.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@id", staffID);
        SqlDataReader? reader = null;
        try
        {
            reader = cmd.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error in getting staff with id, {staffID} > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
        Staffs? result = null;
        if (reader != null && reader.HasRows == true)
        {
            if (reader.Read() == true)
            {
                result = reader.ToStaffNameandPositionPhoto();
            }
        }
        reader?.Close();
        return result;
    }
}
