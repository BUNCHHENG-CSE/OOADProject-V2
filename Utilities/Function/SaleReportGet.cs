using Microsoft.Data.SqlClient;
using OOADPROV2.Utilities;
using System.Data;

public static class SaleReportGet
{
    public static (decimal DailySales, decimal MonthlySales, decimal YearlySales) OverallIncome()
    {
        SqlCommand cmd = new("spGetOverallIncome", Helper.Instance.OpenConnection())
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
                    dailySales = !reader.IsDBNull(reader.GetOrdinal("DailySales"))
                        ? reader.GetDecimal(reader.GetOrdinal("DailySales"))
                        : 0;

                    monthlySales = !reader.IsDBNull(reader.GetOrdinal("MonthlySales"))
                        ? reader.GetDecimal(reader.GetOrdinal("MonthlySales"))
                        : 0;

                    yearlySales = !reader.IsDBNull(reader.GetOrdinal("YearlySales"))
                        ? reader.GetDecimal(reader.GetOrdinal("YearlySales"))
                        : 0;
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

    public static List<(DateTime Date, double Sales)> DailySales()
    {
        List<(DateTime, double)> dailySales = [];

        SqlCommand cmd = new("spGetDailySales", Helper.Instance.OpenConnection())
        {
            CommandType = CommandType.StoredProcedure
        };

        try
        {
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime date = !reader.IsDBNull(reader.GetOrdinal("Date"))
                    ? reader.GetDateTime(reader.GetOrdinal("Date"))
                    : DateTime.MinValue;

                double sales = !reader.IsDBNull(reader.GetOrdinal("TotalSales"))
                    ? Convert.ToDouble(reader["TotalSales"])
                    : 0;

                dailySales.Add((date, sales));
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Failed to fetch daily sales data: {ex.Message}");
        }

        return dailySales;
    }
}
