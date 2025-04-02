using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace OOADPROV2.Utilities.Function;

public static class DashboardFunc
{
    public static double GetTotalSalesAllTime(SqlConnection con)
    {
        SqlCommand cmd = new("spGetTotalSalesAllTime", con)
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
                    totalSales = Convert.ToDouble(reader["TotalSales"]);
                }
            }
            return totalSales;
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to retrieve total sales > {ex.Message}");
        }
    }

    public static double GetOrderQuantityToday(SqlConnection con)
    {
        SqlCommand cmd = new("spGetOrderQuantityToday", con)
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
    public static int GetTotalUsers(SqlConnection con)
    {
        SqlCommand cmd = new("spGetTotalUsers", con)
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

