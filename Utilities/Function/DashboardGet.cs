using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace OOADPROV2.Utilities.Function;

public static class DashboardGet
{
    public static double TotalSalesAllTime()
    {
        SqlCommand cmd = new("spGetTotalSalesAllTime", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };

        double totalSales = 0;

        try
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    var value = reader["TotalSales"];
                    return (value != DBNull.Value) ? Convert.ToDouble(value) : 0.0;
                }
            }
            return 0.0;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to retrieve total sales > {ex.Message}");
        }
    }

    public static double OrderQuantityToday()
    {
        SqlCommand cmd = new("spGetOrderQuantityToday", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };

        double totalSales = 0;

        try
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    totalSales = Convert.ToDouble(reader["OrderQuantityToday"]);
                }
            }
            return totalSales;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to retrieve  quantity for today> {ex.Message}");
        }
    }
    public static int TotalUsers()
    {
        SqlCommand cmd = new("spGetTotalUsers", Database.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };

        int totalUsers = 0;
        try
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    totalUsers = reader.GetInt32(reader.GetOrdinal("TotalUsers"));
                }
            }
            return totalUsers;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to retrieve total users > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
}

