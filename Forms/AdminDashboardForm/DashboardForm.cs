using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
    }

    private void OnLoadingChanged(bool result)
    {
        LoadingChanged?.Invoke(this, result);
    }
    private void TodayVsYesterdaySales()
    {
        double[] values = new double[2];
        string[] labels = ["Yesterday", "Today"];
        Color[] labelColors = [Color.White, Color.White];
        Color[] sliceColors = [Color.Red, Color.Green];
        try
        {
            OnLoadingChanged(true);
            using (var command = new SqlCommand("spGetTodayVsYesterdaySales", Database.Instance.OpenConnection()))
            {
                command.CommandType = CommandType.StoredProcedure;
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    values[0] = !reader.IsDBNull(reader.GetOrdinal("YesterdaySales"))
                                ? reader.GetDouble(reader.GetOrdinal("YesterdaySales"))
                                : 0;

                    values[1] = !reader.IsDBNull(reader.GetOrdinal("TodaySales"))
                                ? reader.GetDouble(reader.GetOrdinal("TodaySales"))
                                : 0;
                }

            }
            if (values != null && values.Length == 2)
            {
                if (values[0] > 0 || values[1] > 0)
                {
                    var pie = formsPlotTodayvsYTD.Plot.AddPie(values);
                    pie.SliceLabels = labels;
                    pie.ShowLabels = true;
                    pie.SliceFillColors = sliceColors;
                    pie.SliceLabelColors = labelColors;
                    formsPlotTodayvsYTD.Plot.Style(this.BackColor, this.BackColor);
                    formsPlotTodayvsYTD.Plot.XAxis.Ticks(false);
                    formsPlotTodayvsYTD.Plot.YAxis.Ticks(false);
                    formsPlotTodayvsYTD.Refresh();

                    lblTodaySales.Text = $"Today = {values[1]:C2}";
                    lblYesterdaySales.Text = $"Yesterday = {values[0]:C2}";
                    lbIncometoday.Text = $"{values[1]:C2}";
                }
                else
                {
                    lblTodaySales.Text = "Today = $0.00";
                    lblYesterdaySales.Text = "Yesterday = $0.00";
                    lbIncometoday.Text = "$0.00";
                }
            }

        }
        catch (InvalidCastException)
        {
            MessageBox.Show("Sales data is unavailable or contains invalid types.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Unexpected error in TodayVsYesterdaySales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            OnLoadingChanged(false);
        }
    }
    private void WeeklySale()
    {
        double[] values = new double[2];
        string[] labels = ["Last Week", "This Week"];
        Color[] labelColors = [Color.White, Color.White];
        Color[] sliceColors = [Color.Blue, Color.Orange];

        try
        {
            OnLoadingChanged(true);
            using var command = new SqlCommand("spGetWeeklySales", Database.Instance.OpenConnection());
            command.CommandType = CommandType.StoredProcedure;

            using var reader = command.ExecuteReader();
            List<(DateTime WeekStartDate, double Sales)> weeklySales = [];
            while (reader.Read())
            {
                if(reader["WeekStartDate"] == DBNull.Value || reader["TotalSales"] == DBNull.Value)
                {
                    continue;
                }
                DateTime weekStart = Convert.ToDateTime(reader["WeekStartDate"]);
                double sales = Convert.ToDouble(reader["TotalSales"]);
                weeklySales.Add((weekStart, sales));
            }


            if (weeklySales.Count >= 2)
            {

                var (WeekStartDate, Sales) = weeklySales[weeklySales.Count - 2];
                var thisWeekSales = weeklySales[weeklySales.Count - 1];
                values[0] = Sales;
                values[1] = thisWeekSales.Sales;
                labels[0] = "Last Week ";
                labels[1] = "This Week ";
                var pie = formsPlotWeeklySale.Plot.AddPie(values);
                pie.SliceLabels = labels;
                pie.ShowLabels = true;
                pie.SliceFillColors = sliceColors;
                pie.SliceLabelColors = labelColors;
                formsPlotWeeklySale.Plot.Style(this.BackColor, this.BackColor);
                formsPlotWeeklySale.Plot.XAxis.Ticks(false);
                formsPlotWeeklySale.Plot.YAxis.Ticks(false);
                formsPlotWeeklySale.Refresh();
                lblThisWeekSales.Text = $"This Week = {values[1]:C2}";
                lblLastWeekSales.Text = $"Last Week = {values[0]:C2}";
            }
        }
        catch (InvalidCastException)
        {
            MessageBox.Show("Weekly sales data is incomplete or invalid.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Unexpected error in WeeklySale: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        finally
        {
            OnLoadingChanged(false);
        }
    }
    private void DisplayTotalSales()
    {
        try
        {
            OnLoadingChanged(true);
            double? totalSales = DashboardGet.TotalSalesAllTime();
            lblTotalSales.Text = totalSales.HasValue ? $"{totalSales.Value:C}" : "$0.00";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void DisplayOrderQuantityToday()
    {
        try
        {
            OnLoadingChanged(true);
            double orderQuantityToday = DashboardGet.OrderQuantityToday();
            lblTodayOrder.Text = $"{orderQuantityToday}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void DisplayTotalUsers()
    {
        try
        {
            OnLoadingChanged(true);
            int totalUsers = DashboardGet.TotalUsers();
            labelTotalUsers.Text = $"{totalUsers}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void DashboardForm_Load(object sender, EventArgs e)
    {
        TodayVsYesterdaySales();
        WeeklySale();
        DisplayTotalSales();
        DisplayOrderQuantityToday();
        DisplayTotalUsers();

    }
    public event LoadingEventHandler? LoadingChanged;
}
