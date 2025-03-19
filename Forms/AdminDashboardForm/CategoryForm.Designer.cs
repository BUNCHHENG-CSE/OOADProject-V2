namespace OOADPROV2.Forms.AdminDashboardForm;

partial class CategoryForm
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
        btnAddCategory = new Button();
        dgvCategory = new DataGridView();
        CategoryID = new DataGridViewTextBoxColumn();
        CategoryName = new DataGridViewTextBoxColumn();
        CategoryDescription = new DataGridViewTextBoxColumn();
        btnClickDelete = new Button();
        btnClickUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
        SuspendLayout();
        // 
        // btnAddCategory
        // 
        btnAddCategory.FlatStyle = FlatStyle.Flat;
        btnAddCategory.ForeColor = Color.FromArgb(243, 244, 243);
        btnAddCategory.Location = new Point(36, 36);
        btnAddCategory.Name = "btnAddCategory";
        btnAddCategory.Size = new Size(49, 46);
        btnAddCategory.TabIndex = 2;
        btnAddCategory.UseVisualStyleBackColor = true;
        // 
        // dgvCategory
        // 
        dgvCategory.AllowUserToAddRows = false;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvCategory.ColumnHeadersHeight = 30;
        dgvCategory.Columns.AddRange(new DataGridViewColumn[] { CategoryID, CategoryName, CategoryDescription });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Window;
        dataGridViewCellStyle2.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
        dgvCategory.Location = new Point(36, 132);
        dgvCategory.Name = "dgvCategory";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvCategory.Size = new Size(1029, 607);
        dgvCategory.TabIndex = 3;
        // 
        // CategoryID
        // 
        CategoryID.HeaderText = "Category ID";
        CategoryID.Name = "CategoryID";
        CategoryID.Width = 200;
        // 
        // CategoryName
        // 
        CategoryName.HeaderText = "Category Name";
        CategoryName.Name = "CategoryName";
        CategoryName.Width = 300;
        // 
        // CategoryDescription
        // 
        CategoryDescription.HeaderText = "Category Description";
        CategoryDescription.Name = "CategoryDescription";
        CategoryDescription.Width = 480;
        // 
        // btnClickDelete
        // 
        btnClickDelete.FlatStyle = FlatStyle.Flat;
        btnClickDelete.ForeColor = Color.FromArgb(243, 244, 243);
        btnClickDelete.Location = new Point(990, 80);
        btnClickDelete.Name = "btnClickDelete";
        btnClickDelete.Size = new Size(49, 46);
        btnClickDelete.TabIndex = 4;
        btnClickDelete.UseVisualStyleBackColor = true;
        // 
        // btnClickUpdate
        // 
        btnClickUpdate.FlatStyle = FlatStyle.Flat;
        btnClickUpdate.ForeColor = Color.FromArgb(243, 244, 243);
        btnClickUpdate.Location = new Point(872, 80);
        btnClickUpdate.Name = "btnClickUpdate";
        btnClickUpdate.Size = new Size(49, 46);
        btnClickUpdate.TabIndex = 5;
        btnClickUpdate.UseVisualStyleBackColor = true;
        // 
        // CategoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1092, 802);
        Controls.Add(btnClickUpdate);
        Controls.Add(btnClickDelete);
        Controls.Add(dgvCategory);
        Controls.Add(btnAddCategory);
        FormBorderStyle = FormBorderStyle.None;
        Name = "CategoryForm";
        Text = "CategoryForm";
        Load += CategoryForm_Load;
        ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btnAddCategory;
    private DataGridView dgvCategory;
    private DataGridViewTextBoxColumn CategoryID;
    private DataGridViewTextBoxColumn CategoryName;
    private DataGridViewTextBoxColumn CategoryDescription;
    private Button btnClickDelete;
    private Button btnClickUpdate;
}