using OOADPROV2.Models;
using OOADPROV2.Utilities.Builder.Product;
using OOADPROV2.Utilities.Commands.Category;
using OOADPROV2.Utilities.Commands.Product;
using OOADPROV2.Utilities.Function;
using System.Drawing.Imaging;


namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class AddProductsForm : Form
{
    string? imgLocation = "";
    int productCount = 0;
    private readonly int indexOfUpdateProduct;
    Products? effectedProduct = null;
    public AddProductsForm(ProductsForm productsForm)
    {
        InitializeComponent();
        btnClear.Click += DoClickClearFormInput;
        btnInsert.Click += DoClickInsertProduct;
        btnUpdate.Click += DoClickUpdateProduct;
        btnUploadPhoto.Click += DoClickUploadProductPhoto;
    }

    private void DoClickUpdateProduct(object? sender, EventArgs e)
    {
        byte[] ProductImages = null;
        if (txtProductName.Text == "" || txtProductName.Text.Trim().Length > 100)
        {
            MessageBox.Show("Product is required or name too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (cBCategoryID.SelectedItem == null)
        {
            MessageBox.Show("Category is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (rtxtProductDescription.Text == "" || rtxtProductDescription.Text.Trim().Length > 1000)
        {
            MessageBox.Show("Staff Address is required or address too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (decimal.TryParse(txtPrice.Text.ToString(), out decimal productPrice) == false)
        {
            MessageBox.Show("Product price is required or something wrong", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (int.TryParse(txtProductStock.Text.ToString(), out int productStock) == false)
        {
            MessageBox.Show("Product stock is required or something wrong", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        effectedProduct.ProductName = txtProductName.Text.Trim();
        effectedProduct.ProductsPrice = productPrice;
        effectedProduct.ProductDescription = rtxtProductDescription.Text.Trim();
        effectedProduct.ProductsStock = productStock;
        effectedProduct.Category.CategoryID = int.Parse(cBCategoryID.SelectedItem.ToString());


        if (picProduct.Image != null)
        {
            Image image = picProduct.Image;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            ProductImages = ms.ToArray();
        }
        effectedProduct.ProductImage = ProductImages;
        try
        {

            var result = ProductCommands.UpdateProduct(effectedProduct);
            if (result == true)
            {

                MessageBox.Show($"Successfully updated an existing product with the id {txtProductID.Text}");
                ProductLoadingChanged?.Invoke(this, result);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to update an existing product > {ex.Message}");
        }
    }

    private void DoClickInsertProduct(object? sender, EventArgs e)
    {

        byte[]? productImage = null;
        if (!string.IsNullOrEmpty(imgLocation) && File.Exists(imgLocation))

        {
            FileStream stream = new(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new(stream);
            productImage = reader.ReadBytes((int)stream.Length);
        }
        if (cBCategoryID.SelectedItem == null)
        {
            throw new InvalidOperationException("No category selected. Please choose a category.");
        }

        if (!int.TryParse(cBCategoryID.SelectedItem.ToString(), out int categoryId))
        {
            throw new InvalidOperationException("Invalid category ID. Please choose a valid category.");
        }

        Products newproduct = ProductBuilder.Create()
                    .WithName(txtProductName.Text)
                    .WithPrice(decimal.Parse(txtPrice.Text))
                    .WithDescription(rtxtProductDescription.Text)
                    .WithStock(int.Parse(txtProductStock.Text))
                    .WithCategoryId(categoryId)
                    .WithImage(productImage)
                    .Build();
        try
        {
            var result = ProductCommands.AddProduct(newproduct);
            if (result)
            {

                MessageBox.Show($"Product created successfully: {newproduct.ProductName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Failed to create product: {newproduct.ProductName}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFormInput();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Inserting Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void DoClickClearFormInput(object? sender, EventArgs e)
    {
        ClearFormInput();
    }
    private void ClearFormInput()
    {
        txtProductID.Text = (productCount + 1).ToString();
        cBCategoryID.SelectedItem = null;
        txtProductName.Text = "";
        txtPrice.Text = "";
        txtProductStock.Text = "";
        rtxtProductDescription.Text = "";
        picProduct.Image = null;
    }
    private void DoClickUploadProductPhoto(object? sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "SELECT Photo(*.Jpg; *.png; *.Gif)|*.Jpg; *.png; *.Gif";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            imgLocation = dialog.FileName.ToString();
            picProduct.ImageLocation = imgLocation;
        }
    }
    private void LoadingDataCategoryID()
    {
        try
        {
            var result = CategoryCommands.GetCategoriesID();
            List<string> ls = [];
            foreach (var category in result)
            {
                ls.Add(category.CategoryID.ToString());
            }
            cBCategoryID.DataSource = ls;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving Category ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void LoadProduct()
    {
        try
        {
            var result = ProductCommands.GetAllProducts();
            if (result.LastOrDefault() != null) { productCount = result.LastOrDefault().ProductsID; }
            else { productCount = 0; }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void AddProductsForm_Load(object sender, EventArgs e)
    {
        LoadingDataCategoryID();
        LoadProduct();

        if (txtProductName.Text == "")
        {
            txtProductID.Text = (productCount + 1).ToString();
            cBCategoryID.SelectedIndex = -1;
        }
        else
        {
            cBCategoryID.SelectedItem = effectedProduct.Category.CategoryID.ToString();
        }
    }
    public void LoadProductDetails(Products products)
    {
        if (products == null)
            return;

        txtProductID.Clear();
        txtProductID.Text = products.ProductsID.ToString();

        // cBCategoryID.SelectedItem = products.Category.CategoryID.ToString();
        txtProductName.Text = products.ProductName;
        txtPrice.Text = products.ProductsPrice.ToString();
        txtProductStock.Text = products.ProductsStock.ToString();
        rtxtProductDescription.Text = products.ProductDescription;
        if (products.ProductImage != null)
        {
            picProduct.Image = ConvertImageClass.ConvertByteArrayToImage(products.ProductImage);
        }
        else
        {
            picProduct.Image = null;
        }

        effectedProduct = products;
    }
    public event LoadingEventHandler? ProductLoadingChanged;
}
