namespace OOADPROV2.Forms.AdminDashboardForm;

partial class AddCategoryForm
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
        rtxtCategoryDescription = new RichTextBox();
        btnUpdate = new Button();
        btnInsert = new Button();
        labelCategoryDescription = new Label();
        txtCategoryName = new TextBox();
        labelCategoryName = new Label();
        btnClear = new Button();
        labelCategoryID = new Label();
        txtCategoryID = new TextBox();
        SuspendLayout();
        // 
        // rtxtCategoryDescription
        // 
        rtxtCategoryDescription.Location = new Point(167, 159);
        rtxtCategoryDescription.Name = "rtxtCategoryDescription";
        rtxtCategoryDescription.Size = new Size(434, 52);
        rtxtCategoryDescription.TabIndex = 83;
        rtxtCategoryDescription.Text = "";
        // 
        // btnUpdate
        // 
        btnUpdate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnUpdate.Location = new Point(600, 251);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(121, 49);
        btnUpdate.TabIndex = 82;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // btnInsert
        // 
        btnInsert.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnInsert.Location = new Point(303, 251);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new Size(121, 49);
        btnInsert.TabIndex = 81;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // labelCategoryDescription
        // 
        labelCategoryDescription.AutoSize = true;
        labelCategoryDescription.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelCategoryDescription.Location = new Point(23, 174);
        labelCategoryDescription.Name = "labelCategoryDescription";
        labelCategoryDescription.Size = new Size(108, 23);
        labelCategoryDescription.TabIndex = 72;
        labelCategoryDescription.Text = "Description";
        // 
        // txtCategoryName
        // 
        txtCategoryName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtCategoryName.Location = new Point(167, 99);
        txtCategoryName.Name = "txtCategoryName";
        txtCategoryName.Size = new Size(246, 28);
        txtCategoryName.TabIndex = 68;
        // 
        // labelCategoryName
        // 
        labelCategoryName.AutoSize = true;
        labelCategoryName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelCategoryName.Location = new Point(23, 104);
        labelCategoryName.Name = "labelCategoryName";
        labelCategoryName.Size = new Size(138, 23);
        labelCategoryName.TabIndex = 67;
        labelCategoryName.Text = "Category Name";
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnClear.Location = new Point(23, 251);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(121, 49);
        btnClear.TabIndex = 65;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // labelCategoryID
        // 
        labelCategoryID.AutoSize = true;
        labelCategoryID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelCategoryID.Location = new Point(23, 39);
        labelCategoryID.Name = "labelCategoryID";
        labelCategoryID.Size = new Size(110, 23);
        labelCategoryID.TabIndex = 64;
        labelCategoryID.Text = "Category ID";
        // 
        // txtCategoryID
        // 
        txtCategoryID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtCategoryID.Location = new Point(167, 39);
        txtCategoryID.Name = "txtCategoryID";
        txtCategoryID.ReadOnly = true;
        txtCategoryID.Size = new Size(185, 28);
        txtCategoryID.TabIndex = 63;
        // 
        // AddCategoryForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 322);
        Controls.Add(rtxtCategoryDescription);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(labelCategoryDescription);
        Controls.Add(txtCategoryName);
        Controls.Add(labelCategoryName);
        Controls.Add(btnClear);
        Controls.Add(labelCategoryID);
        Controls.Add(txtCategoryID);
        Name = "AddCategoryForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "CategoryAddForm";
        Load += AddCategoryForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RichTextBox rtxtCategoryDescription;
    private Button btnUpdate;
    private Button btnInsert;
    private Label labelCategoryDescription;
    private TextBox txtCategoryName;
    private Label labelCategoryName;
    private Button btnClear;
    private Label labelCategoryID;
    private TextBox txtCategoryID;
}