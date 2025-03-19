namespace OOADPROV2.Forms.AdminDashboardForm;

partial class AddProductsForm
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
        btnInsert = new Button();
        btnUploadPhoto = new Button();
        picProduct = new PictureBox();
        labelCategoryID = new Label();
        labelDescription = new Label();
        txtPrice = new TextBox();
        txtProductName = new TextBox();
        labelProductName = new Label();
        labelPrice = new Label();
        btnClear = new Button();
        labelProductID = new Label();
        txtProductID = new TextBox();
        btnUpdate = new Button();
        rtxtProductDescription = new RichTextBox();
        labelProductStock = new Label();
        txtProductStock = new TextBox();
        cBCategoryID = new ComboBox();
        ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
        SuspendLayout();
        // 
        // btnInsert
        // 
        btnInsert.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnInsert.Location = new Point(324, 340);
        btnInsert.Name = "btnInsert";
        btnInsert.Size = new Size(121, 49);
        btnInsert.TabIndex = 83;
        btnInsert.Text = "Insert";
        btnInsert.UseVisualStyleBackColor = true;
        // 
        // btnUploadPhoto
        // 
        btnUploadPhoto.Font = new Font("Sitka Small", 11F, FontStyle.Bold);
        btnUploadPhoto.Location = new Point(633, 215);
        btnUploadPhoto.Name = "btnUploadPhoto";
        btnUploadPhoto.Size = new Size(145, 30);
        btnUploadPhoto.TabIndex = 76;
        btnUploadPhoto.Text = "Upload Photo";
        btnUploadPhoto.UseVisualStyleBackColor = true;
        // 
        // picProduct
        // 
        picProduct.BorderStyle = BorderStyle.FixedSingle;
        picProduct.Location = new Point(633, 12);
        picProduct.Name = "picProduct";
        picProduct.Size = new Size(145, 185);
        picProduct.SizeMode = PictureBoxSizeMode.Zoom;
        picProduct.TabIndex = 75;
        picProduct.TabStop = false;
        // 
        // labelCategoryID
        // 
        labelCategoryID.AutoSize = true;
        labelCategoryID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelCategoryID.Location = new Point(279, 32);
        labelCategoryID.Name = "labelCategoryID";
        labelCategoryID.Size = new Size(110, 23);
        labelCategoryID.TabIndex = 71;
        labelCategoryID.Text = "Category ID";
        // 
        // labelDescription
        // 
        labelDescription.AutoSize = true;
        labelDescription.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelDescription.Location = new Point(25, 259);
        labelDescription.Name = "labelDescription";
        labelDescription.Size = new Size(108, 23);
        labelDescription.TabIndex = 70;
        labelDescription.Text = "Description";
        // 
        // txtPrice
        // 
        txtPrice.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtPrice.Location = new Point(172, 134);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(217, 28);
        txtPrice.TabIndex = 68;
        // 
        // txtProductName
        // 
        txtProductName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtProductName.Location = new Point(172, 85);
        txtProductName.Name = "txtProductName";
        txtProductName.Size = new Size(350, 28);
        txtProductName.TabIndex = 67;
        // 
        // labelProductName
        // 
        labelProductName.AutoSize = true;
        labelProductName.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelProductName.Location = new Point(23, 90);
        labelProductName.Name = "labelProductName";
        labelProductName.Size = new Size(129, 23);
        labelProductName.TabIndex = 66;
        labelProductName.Text = "Product Name";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelPrice.Location = new Point(23, 139);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(52, 23);
        labelPrice.TabIndex = 65;
        labelPrice.Text = "Price";
        // 
        // btnClear
        // 
        btnClear.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnClear.Location = new Point(25, 340);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(121, 49);
        btnClear.TabIndex = 64;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // labelProductID
        // 
        labelProductID.AutoSize = true;
        labelProductID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelProductID.Location = new Point(23, 32);
        labelProductID.Name = "labelProductID";
        labelProductID.Size = new Size(101, 23);
        labelProductID.TabIndex = 63;
        labelProductID.Text = "Product ID";
        // 
        // txtProductID
        // 
        txtProductID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtProductID.Location = new Point(130, 27);
        txtProductID.Name = "txtProductID";
        txtProductID.ReadOnly = true;
        txtProductID.Size = new Size(143, 28);
        txtProductID.TabIndex = 62;
        // 
        // btnUpdate
        // 
        btnUpdate.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
        btnUpdate.Location = new Point(618, 340);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(121, 49);
        btnUpdate.TabIndex = 84;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        // 
        // rtxtProductDescription
        // 
        rtxtProductDescription.Location = new Point(172, 237);
        rtxtProductDescription.Name = "rtxtProductDescription";
        rtxtProductDescription.Size = new Size(425, 63);
        rtxtProductDescription.TabIndex = 85;
        rtxtProductDescription.Text = "";
        // 
        // labelProductStock
        // 
        labelProductStock.AutoSize = true;
        labelProductStock.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        labelProductStock.Location = new Point(25, 191);
        labelProductStock.Name = "labelProductStock";
        labelProductStock.Size = new Size(55, 23);
        labelProductStock.TabIndex = 86;
        labelProductStock.Text = "Stock";
        // 
        // txtProductStock
        // 
        txtProductStock.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        txtProductStock.Location = new Point(172, 186);
        txtProductStock.Name = "txtProductStock";
        txtProductStock.Size = new Size(217, 28);
        txtProductStock.TabIndex = 87;
        // 
        // cBCategoryID
        // 
        cBCategoryID.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
        cBCategoryID.FormattingEnabled = true;
        cBCategoryID.Location = new Point(399, 33);
        cBCategoryID.Name = "cBCategoryID";
        cBCategoryID.Size = new Size(153, 31);
        cBCategoryID.TabIndex = 88;
        // 
        // AddProductsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(795, 405);
        Controls.Add(cBCategoryID);
        Controls.Add(txtProductStock);
        Controls.Add(labelProductStock);
        Controls.Add(rtxtProductDescription);
        Controls.Add(btnUpdate);
        Controls.Add(btnInsert);
        Controls.Add(btnUploadPhoto);
        Controls.Add(picProduct);
        Controls.Add(labelCategoryID);
        Controls.Add(labelDescription);
        Controls.Add(txtPrice);
        Controls.Add(txtProductName);
        Controls.Add(labelProductName);
        Controls.Add(labelPrice);
        Controls.Add(btnClear);
        Controls.Add(labelProductID);
        Controls.Add(txtProductID);
        Name = "AddProductsForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ProductsAddForm";
        Load += AddProductsForm_Load;
        ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button btnInsert;
    private TextBox textBox8;
    private TextBox textBox7;
    private Button btnUploadPhoto;
    private PictureBox picProduct;
    private Label labelPersonalNumber;
    private Label labelContactNumber;
    private Label labelStaffAddress;
    private Label labelDescription;
    private Label labelCategoryID;
    private TextBox txtPrice;
    private TextBox txtProductName;
    private Label labelProductName;
    private Label labelPrice;
    private Button btnClear;
    private Label labelProductID;
    private TextBox txtProductID;
    private Button btnUpdate;
    private RichTextBox rtxtProductDescription;
    private Label labelProductStock;
    private TextBox txtProductStock;
    private ComboBox cBCategoryID;
}