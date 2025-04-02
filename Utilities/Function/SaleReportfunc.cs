using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace OOADPROV2.Utilities.Function;

public static class SaleReportfunc
{
    
    public static (decimal DailySales, decimal MonthlySales, decimal YearlySales) GetOverallIncome(SqlConnection con)
    {
        SqlCommand cmd = new("spGetOverallIncome", con)
        {
            CommandType = CommandType.StoredProcedure
        };

        decimal dailySales = 0;
        decimal monthlySales = 0;
        decimal yearlySales = 0;

        try
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dailySales = reader.GetDecimal(reader.GetOrdinal("DailySales"));
                    monthlySales = reader.GetDecimal(reader.GetOrdinal("MonthlySales"));
                    yearlySales = reader.GetDecimal(reader.GetOrdinal("YearlySales"));
                }
            }
            return (dailySales, monthlySales, yearlySales);
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to retrieve overall income > {ex.Message}");
        }
        finally
        {
            cmd.Dispose();
        }
    }
    public static List<(DateTime Date, double Sales)> GetDailySales()
    {
        List<(DateTime, double)> dailySales = [];

            SqlCommand cmd = new("spGetDailySales", Helper.Instance.OpenConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = Convert.ToDateTime(reader["Date"]);
                        double sales = Convert.ToDouble(reader["TotalSales"]);
                        dailySales.Add((date, sales));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to fetch daily sales data: {ex.Message}");
            }
        

        return dailySales;
    }

}
