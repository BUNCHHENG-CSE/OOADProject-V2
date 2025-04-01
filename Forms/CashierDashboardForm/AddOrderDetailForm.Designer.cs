namespace OOADPROV2.Forms.CashierDashboardForm;

partial class AddOrderDetailForm
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        flowLayoutPanel1 = new FlowLayoutPanel();
        buttonpay = new Button();
        txtTotal = new Label();
        dataGridView1 = new DataGridView();
        txtProductName = new TextBox();
        labelOverview = new Label();
        btnClear = new Button();
        ProductsID = new DataGridViewTextBoxColumn();
        ProductsName = new DataGridViewTextBoxColumn();
        Qty = new DataGridViewTextBoxColumn();
        UnitPrice = new DataGridViewTextBoxColumn();
        Amount = new DataGridViewTextBoxColumn();
        OrderDetailID = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.Location = new Point(18, 48);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(555, 643);
        flowLayoutPanel1.TabIndex = 86;
        // 
        // buttonpay
        // 
        buttonpay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        buttonpay.Location = new Point(626, 582);
        buttonpay.Name = "buttonpay";
        buttonpay.Size = new Size(111, 42);
        buttonpay.TabIndex = 83;
        buttonpay.Text = "Pay Order";
        buttonpay.UseVisualStyleBackColor = true;
        // 
        // txtTotal
        // 
        txtTotal.AutoSize = true;
        txtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtTotal.Location = new Point(862, 463);
        txtTotal.Name = "txtTotal";
        txtTotal.Size = new Size(52, 25);
        txtTotal.TabIndex = 80;
        txtTotal.Text = "Total";
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductsID, ProductsName, Qty, UnitPrice, Amount, OrderDetailID });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
        dataGridView1.Location = new Point(588, 48);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.Size = new Size(460, 412);
        dataGridView1.TabIndex = 79;
        // 
        // txtProductName
        // 
        txtProductName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtProductName.Location = new Point(118, 7);
        txtProductName.Name = "txtProductName";
        txtProductName.Size = new Size(211, 28);
        txtProductName.TabIndex = 78;
        // 
        // labelOverview
        // 
        labelOverview.AutoSize = true;
        labelOverview.Font = new Font("Sitka Small Semibold", 14F, FontStyle.Bold);
        labelOverview.Location = new Point(19, 5);
        labelOverview.Name = "labelOverview";
        labelOverview.Size = new Size(94, 28);
        labelOverview.TabIndex = 77;
        labelOverview.Text = "Search :";
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnClear.Location = new Point(884, 582);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(111, 42);
        btnClear.TabIndex = 87;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // ProductsID
        // 
        ProductsID.HeaderText = "ID";
        ProductsID.Name = "ProductsID";
        ProductsID.ReadOnly = true;
        ProductsID.Width = 35;
        // 
        // ProductsName
        // 
        ProductsName.HeaderText = "Product";
        ProductsName.Name = "ProductsName";
        ProductsName.ReadOnly = true;
        ProductsName.Width = 90;
        // 
        // Qty
        // 
        Qty.HeaderText = "Qty";
        Qty.Name = "Qty";
        Qty.ReadOnly = true;
        Qty.Width = 40;
        // 
        // UnitPrice
        // 
        UnitPrice.HeaderText = "Unit Price";
        UnitPrice.Name = "UnitPrice";
        UnitPrice.ReadOnly = true;
        UnitPrice.Width = 120;
        // 
        // Amount
        // 
        Amount.HeaderText = "Total";
        Amount.Name = "Amount";
        Amount.ReadOnly = true;
        Amount.Width = 125;
        // 
        // OrderDetailID
        // 
        OrderDetailID.HeaderText = "SR";
        OrderDetailID.Name = "OrderDetailID";
        OrderDetailID.ReadOnly = true;
        OrderDetailID.Visible = false;
        // 
        // AddOrderDetailForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1060, 724);
        Controls.Add(btnClear);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(buttonpay);
        Controls.Add(txtTotal);
        Controls.Add(dataGridView1);
        Controls.Add(txtProductName);
        Controls.Add(labelOverview);
        Name = "AddOrderDetailForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Order Products";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private Button buttonpay;
    private Label txtTotal;
    private DataGridView dataGridView1;
    private TextBox txtProductName;
    private Label labelOverview;
    private Button btnClear;
    private DataGridViewTextBoxColumn ProductsID;
    private DataGridViewTextBoxColumn ProductsName;
    private DataGridViewTextBoxColumn Qty;
    private DataGridViewTextBoxColumn UnitPrice;
    private DataGridViewTextBoxColumn Amount;
    private DataGridViewTextBoxColumn OrderDetailID;
}