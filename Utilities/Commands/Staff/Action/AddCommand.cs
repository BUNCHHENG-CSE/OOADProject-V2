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

public class AddCommand(Staffs staff) : ICommand<bool>
{
    public bool Execute()
    {
        SqlCommand cmd = new("spInsertStaff", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };
        cmd.Parameters.AddWithValue("@sn", staff.StaffName);
        cmd.Parameters.AddWithValue("@gen", staff.Gender);
        cmd.Parameters.AddWithValue("@bd", staff.BirthDate);
        cmd.Parameters.AddWithValue("@pos", staff.StaffPosition);
        cmd.Parameters.AddWithValue("@ad", staff.StaffAddress);
        cmd.Parameters.AddWithValue("@cn", staff.ContactNumber);
        cmd.Parameters.AddWithValue("@hd", staff.HiredDate);
        cmd.Parameters.AddWithValue("@ph", staff.Photo);
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
            Database.Instance.CloseConnection();
        }
    }
}
