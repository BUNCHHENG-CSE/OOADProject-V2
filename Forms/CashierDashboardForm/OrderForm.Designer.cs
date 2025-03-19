namespace OOADPROV2.Forms.CashierDashboardForm;

partial class OrderForm
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
        btnAddStaff = new Button();
        dgvOrder = new DataGridView();
        OrderID = new DataGridViewTextBoxColumn();
        DataOrder = new DataGridViewTextBoxColumn();
        TotalPrice = new DataGridViewTextBoxColumn();
        CustomerID = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
        SuspendLayout();
        // 
        // btnAddStaff
        // 
        btnAddStaff.FlatStyle = FlatStyle.Flat;
        btnAddStaff.ForeColor = Color.FromArgb(243, 244, 243);
        btnAddStaff.Location = new Point(34, 44);
        btnAddStaff.Name = "btnAddStaff";
        btnAddStaff.Size = new Size(49, 46);
        btnAddStaff.TabIndex = 2;
        btnAddStaff.UseVisualStyleBackColor = true;
        // 
        // dgvOrder
        // 
        dgvOrder.AllowUserToAddRows = false;
        dgvOrder.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvOrder.ColumnHeadersHeight = 30;
        dgvOrder.Columns.AddRange(new DataGridViewColumn[] { OrderID, DataOrder, TotalPrice, CustomerID });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
        dgvOrder.Location = new Point(34, 112);
        dgvOrder.Name = "dgvOrder";
        dgvOrder.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvOrder.Size = new Size(1029, 607);
        dgvOrder.TabIndex = 4;
        // 
        // OrderID
        // 
        OrderID.HeaderText = "Order ID";
        OrderID.Name = "OrderID";
        OrderID.ReadOnly = true;
        OrderID.Width = 200;
        // 
        // DataOrder
        // 
        DataOrder.HeaderText = "Date Time";
        DataOrder.Name = "DataOrder";
        DataOrder.ReadOnly = true;
        DataOrder.Width = 300;
        // 
        // TotalPrice
        // 
        TotalPrice.HeaderText = "Total Price";
        TotalPrice.Name = "TotalPrice";
        TotalPrice.ReadOnly = true;
        TotalPrice.Width = 300;
        // 
        // CustomerID
        // 
        CustomerID.HeaderText = "CustomerID";
        CustomerID.Name = "CustomerID";
        CustomerID.ReadOnly = true;
        CustomerID.Width = 200;
        // 
        // OrderForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1076, 763);
        Controls.Add(dgvOrder);
        Controls.Add(btnAddStaff);
        FormBorderStyle = FormBorderStyle.None;
        Name = "OrderForm";
        Text = "OrderForm";
        Load += OrderForm_Load;
        ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btnAddStaff;
    private DataGridView dgvOrder;
    private DataGridViewTextBoxColumn OrderID;
    private DataGridViewTextBoxColumn DataOrder;
    private DataGridViewTextBoxColumn TotalPrice;
    private DataGridViewTextBoxColumn CustomerID;
}