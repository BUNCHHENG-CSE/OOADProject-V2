using Microsoft.Data.SqlClient;
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

namespace OOADPROV2.Forms.AdminDashboardForm
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        //private void OnLoadingChanged(bool result)
        //{
        //    LoadingChanged?.Invoke(this, result);
        //}
        //private void TodayVsYesterdaySales()
        //{
        //    double[] values = new double[2];
        //    string[] labels = { "Yesterday", "Today" };
        //    Color[] labelColors = { Color.White, Color.White };
        //    Color[] sliceColors = { Color.Red, Color.Green };
        //    try
        //    {
        //        OnLoadingChanged(true);
        //        using (var command = new SqlCommand("spGetTodayVsYesterdaySales", Program.Connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            using (var reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    values[0] = reader.GetDouble(reader.GetOrdinal("YesterdaySales"));
        //                    values[1] = reader.GetDouble(reader.GetOrdinal("TodaySales"));
        //                }

        //            }

        //        }
        //        if (values[0] > 0 || values[1] > 0)
        //        {
        //            var pie = formsPlotTodayvsYTD.Plot.AddPie(values);
        //            pie.SliceLabels = labels;
        //            pie.ShowLabels = true;
        //            pie.SliceFillColors = sliceColors;
        //            pie.SliceLabelColors = labelColors;
        //            formsPlotTodayvsYTD.Plot.Style(this.BackColor, this.BackColor);
        //            formsPlotTodayvsYTD.Plot.XAxis.Ticks(false);
        //            formsPlotTodayvsYTD.Plot.YAxis.Ticks(false);
        //            formsPlotTodayvsYTD.Refresh();
        //            lblTodaySales.Text = $"Today = {values[1]:C2}";
        //            lblYesterdaySales.Text = $"Yesterday = {values[0]:C2}";
        //            lbIncometoday.Text = $"{values[1]:C2}";
        //        }
        //        else
        //        {

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        OnLoadingChanged(false);
        //    }
        //}
        //private void WeeklySale()
        //{
        //    double[] values = new double[2];
        //    string[] labels = { "Last Week", "This Week" };
        //    Color[] labelColors = { Color.White, Color.White };
        //    Color[] sliceColors = { Color.Blue, Color.Orange };

        //    try
        //    {
        //        OnLoadingChanged(true);
        //        using (var command = new SqlCommand("spGetWeeklySales", Program.Connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            using (var reader = command.ExecuteReader())
        //            {
        //                List<(DateTime WeekStartDate, double Sales)> weeklySales = new List<(DateTime, double)>();
        //                while (reader.Read())
        //                {
        //                    DateTime weekStart = Convert.ToDateTime(reader["WeekStartDate"]);
        //                    double sales = Convert.ToDouble(reader["TotalSales"]);
        //                    weeklySales.Add((weekStart, sales));
        //                }


        //                if (weeklySales.Count >= 2)
        //                {

        //                    var lastWeekSales = weeklySales[weeklySales.Count - 2];
        //                    var thisWeekSales = weeklySales[weeklySales.Count - 1];
        //                    values[0] = lastWeekSales.Sales;
        //                    values[1] = thisWeekSales.Sales;
        //                    labels[0] = "Last Week ";
        //                    labels[1] = "This Week ";
        //                    var pie = formsPlotWeeklySale.Plot.AddPie(values);
        //                    pie.SliceLabels = labels;
        //                    pie.ShowLabels = true;
        //                    pie.SliceFillColors = sliceColors;
        //                    pie.SliceLabelColors = labelColors;
        //                    formsPlotWeeklySale.Plot.Style(this.BackColor, this.BackColor);
        //                    formsPlotWeeklySale.Plot.XAxis.Ticks(false);
        //                    formsPlotWeeklySale.Plot.YAxis.Ticks(false);


        //                    formsPlotWeeklySale.Refresh();


        //                    lblThisWeekSales.Text = $"This Week = {values[1]:C2}";
        //                    lblLastWeekSales.Text = $"Last Week = {values[0]:C2}";
        //                }
        //                else
        //                {

        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        OnLoadingChanged(false);
        //    }
        //}
        //private void DisplayTotalSales()
        //{
        //    try
        //    {
        //        OnLoadingChanged(true);
        //        double totalSales = DashboardFunc.GetTotalSalesAllTime(Program.Connection);
        //        lblTotalSales.Text = $"{totalSales:C}";
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //private void DisplayOrderQuantityToday()
        //{
        //    try
        //    {
        //        OnLoadingChanged(true);
        //        double orderQuantityToday = DashboardFunc.GetOrderQuantityToday(Program.Connection);
        //        lblTodayOrder.Text = $"{orderQuantityToday}";
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //private void DisplayTotalUsers()
        //{
        //    try
        //    {
        //        OnLoadingChanged(true);
        //        int totalUsers = DashboardFunc.GetTotalUsers(Program.Connection);
        //        labelTotalUsers.Text = $"{totalUsers}";
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //private void DashboardForm_Load(object sender, EventArgs e)
        //{
        //    TodayVsYesterdaySales();
        //    WeeklySale();
        //    DisplayTotalSales();
        //    DisplayOrderQuantityToday();
        //    DisplayTotalUsers();

        //}
        //public event LoadingEventHandler? LoadingChanged;
        private void DashboardForm_Load(object sender, EventArgs e)
        { }
    }
}
