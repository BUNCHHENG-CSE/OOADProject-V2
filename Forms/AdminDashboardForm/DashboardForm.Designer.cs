namespace OOADPROV2.Forms.AdminDashboardForm;

partial class DashboardForm
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
        formsPlotTodayvsYTD = new ScottPlot.FormsPlot();
        panel1 = new Panel();
        labelTotalUsers = new Label();
        label1 = new Label();
        panel2 = new Panel();
        lblTotalSales = new Label();
        label4 = new Label();
        panel3 = new Panel();
        lbIncometoday = new Label();
        label6 = new Label();
        panel4 = new Panel();
        lblTodayOrder = new Label();
        label8 = new Label();
        formsPlotWeeklySale = new ScottPlot.FormsPlot();
        labelWeeklySale = new Label();
        labelTodayvsYTD = new Label();
        lblTodaySales = new Label();
        lblYesterdaySales = new Label();
        lblLastWeekSales = new Label();
        lblThisWeekSales = new Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // formsPlotTodayvsYTD
        // 
        formsPlotTodayvsYTD.Location = new Point(614, 417);
        formsPlotTodayvsYTD.Margin = new Padding(4, 3, 4, 3);
        formsPlotTodayvsYTD.Name = "formsPlotTodayvsYTD";
        formsPlotTodayvsYTD.Size = new Size(450, 286);
        formsPlotTodayvsYTD.TabIndex = 1;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(38, 57, 91);
        panel1.Controls.Add(labelTotalUsers);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(12, 25);
        panel1.Name = "panel1";
        panel1.Size = new Size(249, 133);
        panel1.TabIndex = 2;
        // 
        // labelTotalUsers
        // 
        labelTotalUsers.AutoSize = true;
        labelTotalUsers.Font = new Font("Sitka Small Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        labelTotalUsers.ForeColor = Color.White;
        labelTotalUsers.Location = new Point(19, 12);
        labelTotalUsers.Name = "labelTotalUsers";
        labelTotalUsers.Size = new Size(32, 35);
        labelTotalUsers.TabIndex = 4;
        labelTotalUsers.Text = "0";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.White;
        label1.Location = new Point(157, 99);
        label1.Name = "label1";
        label1.Size = new Size(77, 23);
        label1.TabIndex = 3;
        label1.Text = "All User";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(38, 57, 91);
        panel2.Controls.Add(lblTotalSales);
        panel2.Controls.Add(label4);
        panel2.Location = new Point(279, 25);
        panel2.Name = "panel2";
        panel2.Size = new Size(249, 133);
        panel2.TabIndex = 3;
        // 
        // lblTotalSales
        // 
        lblTotalSales.AutoSize = true;
        lblTotalSales.Font = new Font("Sitka Small Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTotalSales.ForeColor = Color.White;
        lblTotalSales.Location = new Point(19, 12);
        lblTotalSales.Name = "lblTotalSales";
        lblTotalSales.Size = new Size(32, 35);
        lblTotalSales.TabIndex = 7;
        lblTotalSales.Text = "0";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.White;
        label4.Location = new Point(143, 99);
        label4.Name = "label4";
        label4.Size = new Size(93, 23);
        label4.TabIndex = 3;
        label4.Text = "Total Sale";
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(38, 57, 91);
        panel3.Controls.Add(lbIncometoday);
        panel3.Controls.Add(label6);
        panel3.Location = new Point(547, 25);
        panel3.Name = "panel3";
        panel3.Size = new Size(249, 133);
        panel3.TabIndex = 5;
        // 
        // lbIncometoday
        // 
        lbIncometoday.AutoSize = true;
        lbIncometoday.Font = new Font("Sitka Small Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbIncometoday.ForeColor = Color.White;
        lbIncometoday.Location = new Point(19, 12);
        lbIncometoday.Name = "lbIncometoday";
        lbIncometoday.Size = new Size(32, 35);
        lbIncometoday.TabIndex = 8;
        lbIncometoday.Text = "0";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.ForeColor = Color.White;
        label6.Location = new Point(120, 99);
        label6.Name = "label6";
        label6.Size = new Size(126, 23);
        label6.TabIndex = 3;
        label6.Text = "Today Income";
        // 
        // panel4
        // 
        panel4.BackColor = Color.FromArgb(38, 57, 91);
        panel4.Controls.Add(lblTodayOrder);
        panel4.Controls.Add(label8);
        panel4.Location = new Point(815, 25);
        panel4.Name = "panel4";
        panel4.Size = new Size(249, 133);
        panel4.TabIndex = 5;
        // 
        // lblTodayOrder
        // 
        lblTodayOrder.AutoSize = true;
        lblTodayOrder.Font = new Font("Sitka Small Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTodayOrder.ForeColor = Color.White;
        lblTodayOrder.Location = new Point(15, 12);
        lblTodayOrder.Name = "lblTodayOrder";
        lblTodayOrder.Size = new Size(32, 35);
        lblTodayOrder.TabIndex = 9;
        lblTodayOrder.Text = "0";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label8.ForeColor = Color.White;
        label8.Location = new Point(120, 99);
        label8.Name = "label8";
        label8.Size = new Size(112, 23);
        label8.TabIndex = 3;
        label8.Text = "Today Order";
        // 
        // formsPlotWeeklySale
        // 
        formsPlotWeeklySale.AutoScroll = true;
        formsPlotWeeklySale.Location = new Point(31, 417);
        formsPlotWeeklySale.Margin = new Padding(4, 3, 4, 3);
        formsPlotWeeklySale.Name = "formsPlotWeeklySale";
        formsPlotWeeklySale.Size = new Size(450, 286);
        formsPlotWeeklySale.TabIndex = 6;
        // 
        // labelWeeklySale
        // 
        labelWeeklySale.AutoSize = true;
        labelWeeklySale.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
        labelWeeklySale.Location = new Point(198, 374);
        labelWeeklySale.Name = "labelWeeklySale";
        labelWeeklySale.Size = new Size(132, 28);
        labelWeeklySale.TabIndex = 7;
        labelWeeklySale.Text = "Weekly Sale";
        // 
        // labelTodayvsYTD
        // 
        labelTodayvsYTD.AutoSize = true;
        labelTodayvsYTD.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
        labelTodayvsYTD.Location = new Point(710, 374);
        labelTodayvsYTD.Name = "labelTodayvsYTD";
        labelTodayvsYTD.Size = new Size(287, 28);
        labelTodayvsYTD.TabIndex = 8;
        labelTodayvsYTD.Text = "Today VS Yesterday Income";
        // 
        // lblTodaySales
        // 
        lblTodaySales.AutoSize = true;
        lblTodaySales.Font = new Font("Segoe UI", 13F);
        lblTodaySales.Location = new Point(729, 695);
        lblTodaySales.Name = "lblTodaySales";
        lblTodaySales.Size = new Size(64, 25);
        lblTodaySales.TabIndex = 9;
        lblTodaySales.Text = "Today ";
        // 
        // lblYesterdaySales
        // 
        lblYesterdaySales.AutoSize = true;
        lblYesterdaySales.Font = new Font("Segoe UI", 13F);
        lblYesterdaySales.Location = new Point(729, 732);
        lblYesterdaySales.Name = "lblYesterdaySales";
        lblYesterdaySales.Size = new Size(44, 25);
        lblYesterdaySales.TabIndex = 10;
        lblYesterdaySales.Text = "YTD";
        // 
        // lblLastWeekSales
        // 
        lblLastWeekSales.AutoSize = true;
        lblLastWeekSales.Font = new Font("Segoe UI", 13F);
        lblLastWeekSales.Location = new Point(99, 732);
        lblLastWeekSales.Name = "lblLastWeekSales";
        lblLastWeekSales.Size = new Size(91, 25);
        lblLastWeekSales.TabIndex = 12;
        lblLastWeekSales.Text = "Last Week";
        // 
        // lblThisWeekSales
        // 
        lblThisWeekSales.AutoSize = true;
        lblThisWeekSales.Font = new Font("Segoe UI", 13F);
        lblThisWeekSales.Location = new Point(99, 695);
        lblThisWeekSales.Name = "lblThisWeekSales";
        lblThisWeekSales.Size = new Size(91, 25);
        lblThisWeekSales.TabIndex = 11;
        lblThisWeekSales.Text = "This Week";
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1092, 802);
        Controls.Add(lblLastWeekSales);
        Controls.Add(lblThisWeekSales);
        Controls.Add(lblYesterdaySales);
        Controls.Add(lblTodaySales);
        Controls.Add(labelTodayvsYTD);
        Controls.Add(labelWeeklySale);
        Controls.Add(formsPlotWeeklySale);
        Controls.Add(panel3);
        Controls.Add(panel4);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(formsPlotTodayvsYTD);
        FormBorderStyle = FormBorderStyle.None;
        Name = "DashboardForm";
        Text = "DashboardForm";
        Load += DashboardForm_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ScottPlot.FormsPlot formsPlotTodayvsYTD;
    private Panel panel1;
    private Label labelTotalUsers;
    private Label label1;
    private Panel panel2;
    private Label label4;
    private Panel panel3;
    private Label label6;
    private Panel panel4;
    private Label label8;
    private ScottPlot.FormsPlot formsPlotWeeklySale;
    private Label lblTotalSales;
    private Label lbIncometoday;
    private Label lblTodayOrder;
    private Label labelWeeklySale;
    private Label labelTodayvsYTD;
    private Label lblTodaySales;
    public Label lblYesterdaySales;
    public Label lblLastWeekSales;
    private Label lblThisWeekSales;
}