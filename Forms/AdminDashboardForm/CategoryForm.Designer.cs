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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
        dgvCategory = new DataGridView();
        CategoryID = new DataGridViewTextBoxColumn();
        CategoryName = new DataGridViewTextBoxColumn();
        CategoryDescription = new DataGridViewTextBoxColumn();
        btnAddCategory = new Button();
        btnClickUpdate = new Button();
        btnClickDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
        SuspendLayout();
        // 
        // dgvCategory
        // 
        dgvCategory.AllowUserToAddRows = false;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Control;
        dataGridViewCellStyle4.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvCategory.ColumnHeadersHeight = 30;
        dgvCategory.Columns.AddRange(new DataGridViewColumn[] { CategoryID, CategoryName, CategoryDescription });
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = SystemColors.Window;
        dataGridViewCellStyle5.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold);
        dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
        dgvCategory.DefaultCellStyle = dataGridViewCellStyle5;
        dgvCategory.Location = new Point(36, 132);
        dgvCategory.Name = "dgvCategory";
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = SystemColors.Control;
        dataGridViewCellStyle6.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold);
        dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
        dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
        // btnAddCategory
        // 
        btnAddCategory.FlatStyle = FlatStyle.Flat;
        btnAddCategory.ForeColor = Color.FromArgb(243, 244, 243);
        btnAddCategory.Image = (Image)resources.GetObject("btnAddCategory.Image");
        btnAddCategory.Location = new Point(36, 36);
        btnAddCategory.Name = "btnAddCategory";
        btnAddCategory.Size = new Size(49, 46);
        btnAddCategory.TabIndex = 6;
        btnAddCategory.UseVisualStyleBackColor = true;
        // 
        // btnClickUpdate
        // 
        btnClickUpdate.FlatStyle = FlatStyle.Flat;
        btnClickUpdate.ForeColor = Color.FromArgb(243, 244, 243);
        btnClickUpdate.Image = (Image)resources.GetObject("btnClickUpdate.Image");
        btnClickUpdate.Location = new Point(872, 71);
        btnClickUpdate.Name = "btnClickUpdate";
        btnClickUpdate.Size = new Size(49, 46);
        btnClickUpdate.TabIndex = 8;
        btnClickUpdate.UseVisualStyleBackColor = true;
        // 
        // btnClickDelete
        // 
        btnClickDelete.FlatStyle = FlatStyle.Flat;
        btnClickDelete.ForeColor = Color.FromArgb(243, 244, 243);
        btnClickDelete.Image = (Image)resources.GetObject("btnClickDelete.Image");
        btnClickDelete.Location = new Point(990, 73);
        btnClickDelete.Name = "btnClickDelete";
        btnClickDelete.Size = new Size(49, 46);
        btnClickDelete.TabIndex = 7;
        btnClickDelete.UseVisualStyleBackColor = true;
        // 
        // CategoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1092, 802);
        Controls.Add(btnClickUpdate);
        Controls.Add(btnClickDelete);
        Controls.Add(btnAddCategory);
        Controls.Add(dgvCategory);
        FormBorderStyle = FormBorderStyle.None;
        Name = "CategoryForm";
        Text = "CategoryForm";
        Load += CategoryForm_Load;
        ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btnAddCategory1;
    private DataGridView dgvCategory;
    private DataGridViewTextBoxColumn CategoryID;
    private DataGridViewTextBoxColumn CategoryName;
    private DataGridViewTextBoxColumn CategoryDescription;
    private Button btnAddCategory;
    private Button btnClickUpdate;
    private Button btnClickDelete;
}