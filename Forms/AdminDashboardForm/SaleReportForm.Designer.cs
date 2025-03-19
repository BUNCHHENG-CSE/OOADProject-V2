namespace OOADPROV2.Forms.AdminDashboardForm;

partial class SaleReportForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        formsPlotOverallIncome = new ScottPlot.FormsPlot();
        labelOverallIncome = new Label();
        txtDailyIncome = new Label();
        txtMonthlyIncome = new Label();
        txtYearlyIncome = new Label();
        SuspendLayout();
        // 
        // formsPlotOverallIncome
        // 
        formsPlotOverallIncome.Location = new Point(112, 84);
        formsPlotOverallIncome.Margin = new Padding(4, 3, 4, 3);
        formsPlotOverallIncome.Name = "formsPlotOverallIncome";
        formsPlotOverallIncome.Size = new Size(697, 490);
        formsPlotOverallIncome.TabIndex = 10;
        // 
        // labelOverallIncome
        // 
        labelOverallIncome.AutoSize = true;
        labelOverallIncome.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
        labelOverallIncome.Location = new Point(383, 32);
        labelOverallIncome.Name = "labelOverallIncome";
        labelOverallIncome.Size = new Size(170, 28);
        labelOverallIncome.TabIndex = 14;
        labelOverallIncome.Text = "Overall  Income";
        // 
        // txtDailyIncome
        // 
        txtDailyIncome.AutoSize = true;
        txtDailyIncome.Font = new Font("Segoe UI", 14F);
        txtDailyIncome.Location = new Point(170, 613);
        txtDailyIncome.Name = "txtDailyIncome";
        txtDailyIncome.Size = new Size(54, 25);
        txtDailyIncome.TabIndex = 15;
        txtDailyIncome.Text = "Daily";
        // 
        // txtMonthlyIncome
        // 
        txtMonthlyIncome.AutoSize = true;
        txtMonthlyIncome.Font = new Font("Segoe UI", 14F);
        txtMonthlyIncome.Location = new Point(170, 672);
        txtMonthlyIncome.Name = "txtMonthlyIncome";
        txtMonthlyIncome.Size = new Size(82, 25);
        txtMonthlyIncome.TabIndex = 16;
        txtMonthlyIncome.Text = "Monthly";
        // 
        // txtYearlyIncome
        // 
        txtYearlyIncome.AutoSize = true;
        txtYearlyIncome.Font = new Font("Segoe UI", 14F);
        txtYearlyIncome.Location = new Point(170, 736);
        txtYearlyIncome.Name = "txtYearlyIncome";
        txtYearlyIncome.Size = new Size(62, 25);
        txtYearlyIncome.TabIndex = 17;
        txtYearlyIncome.Text = "Yearly";
        // 
        // SaleReportForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1092, 802);
        Controls.Add(txtYearlyIncome);
        Controls.Add(txtMonthlyIncome);
        Controls.Add(txtDailyIncome);
        Controls.Add(labelOverallIncome);
        Controls.Add(formsPlotOverallIncome);
        FormBorderStyle = FormBorderStyle.None;
        Name = "SaleReportForm";
        Text = "SaleReportForm";
        Load += SaleReportForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ScottPlot.FormsPlot formsPlotOverallIncome;
    private Label labelOverallIncome;
    private Label txtDailyIncome;
    private Label txtMonthlyIncome;
    private Label txtYearlyIncome;
}