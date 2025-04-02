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

public partial class SaleReportForm : Form
{
    public SaleReportForm()
    {
        InitializeComponent();
    }

    private void OverallIncome()
    {
        try
        {
            var (dailyIncome, monthlyIncome, yearlyIncome) = SaleReportGet.OverallIncome();

            double[] values = [(double)dailyIncome, (double)monthlyIncome, (double)yearlyIncome];
            string[] labels = ["Daily", "Monthly", "Yearly"];
            Color[] labelColors = [Color.White, Color.White, Color.White];
            Color[] sliceColors = [Color.Gold, Color.BlueViolet, Color.Cyan];
            var pie = formsPlotOverallIncome.Plot.AddPie(values);
            pie.SliceLabels = labels;
            pie.ShowLabels = true;
            pie.SliceFillColors = sliceColors;
            pie.SliceLabelColors = labelColors;
            formsPlotOverallIncome.Plot.Style(this.BackColor, this.BackColor);
            formsPlotOverallIncome.Plot.XAxis.Ticks(false);
            formsPlotOverallIncome.Plot.YAxis.Ticks(false);
            formsPlotOverallIncome.Refresh();
            txtDailyIncome.Text = $"Daily Income:   ${dailyIncome:F2}";
            txtMonthlyIncome.Text = $"Monthly Income: ${monthlyIncome:F2}";
            txtYearlyIncome.Text = $"Yearly Income:  ${yearlyIncome:F2}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading overall income: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaleReportForm_Load(object sender, EventArgs e)
    {

        OverallIncome();
    }
}
