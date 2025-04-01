namespace OOADPROV2.Forms.CashierDashboardForm;

partial class CashierProductForm
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
        txtSearch = new TextBox();
        label1 = new Label();
        flowLayoutPanelProducts = new FlowLayoutPanel();
        SuspendLayout();
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Sitka Small", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSearch.Location = new Point(136, 20);
        txtSearch.Multiline = true;
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search products...";
        txtSearch.Size = new Size(323, 30);
        txtSearch.TabIndex = 70;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
        label1.Location = new Point(36, 22);
        label1.Name = "label1";
        label1.Size = new Size(94, 28);
        label1.TabIndex = 69;
        label1.Text = "Search :";
        // 
        // flowLayoutPanelProducts
        // 
        flowLayoutPanelProducts.AutoScroll = true;
        flowLayoutPanelProducts.Location = new Point(12, 78);
        flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
        flowLayoutPanelProducts.Size = new Size(1044, 551);
        flowLayoutPanelProducts.TabIndex = 71;
        // 
        // CashierProductForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1092, 802);
        Controls.Add(flowLayoutPanelProducts);
        Controls.Add(txtSearch);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "CashierProductForm";
        Text = "OverviewForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtSearch;
    private Label label1;
    private FlowLayoutPanel flowLayoutPanelProducts;
}