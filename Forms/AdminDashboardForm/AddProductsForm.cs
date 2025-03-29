using OOADPROV2.Models;
using OOADPROV2.Utilities.Builder.Product;
using OOADPROV2.Utilities.Commands.Category;
using OOADPROV2.Utilities.Commands.Product;
using OOADPROV2.Utilities.Function;
using ScottPlot.Renderable;
using System.Drawing.Imaging;


namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class AddProductsForm : Form
{
    string? imgLocation = "";
    int productCount = 0;
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
        byte[] productImages = null;

        effectedProduct.ProductName = txtProductName.Text.Trim();
        effectedProduct.ProductDescription = rtxtProductDescription.Text.Trim();

        if (decimal.TryParse(txtPrice.Text, out decimal productPrice))
            effectedProduct.ProductsPrice = productPrice;

        if (int.TryParse(txtProductStock.Text, out int productStock))
            effectedProduct.ProductsStock = productStock;

        if (cBCategoryID.SelectedItem != null)
            effectedProduct.Category = new Categories { CategoryID = int.Parse(cBCategoryID.SelectedItem.ToString()) };

        if (picProduct.Image != null)
        {
            using var ms = new MemoryStream();
            picProduct.Image.Save(ms, ImageFormat.Png);
            productImages = ms.ToArray();
        }
        effectedProduct.ProductImage = productImages;

        var (isValid, errorMessage) = ProductValidatorBuilder.Create().Build().Validate(effectedProduct);

        if (!isValid)
        {
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }


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
        //if (!string.IsNullOrEmpty(imgLocation) && File.Exists(imgLocation))

        //{
        //    FileStream stream = new(imgLocation, FileMode.Open, FileAccess.Read);
        //    BinaryReader reader = new(stream);
        //    productImage = reader.ReadBytes((int)stream.Length);
        //}

        if (!string.IsNullOrEmpty(imgLocation) && File.Exists(imgLocation))
            productImage = File.ReadAllBytes(imgLocation);

        if (cBCategoryID.SelectedItem == null ||
            !int.TryParse(cBCategoryID.SelectedItem.ToString(), out int categoryId))
        {
            MessageBox.Show("No valid category selected. Please choose a category.",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }

        var newProduct = ProductBuilder.Create()
                    .WithName(txtProductName.Text)
                    .WithPrice(decimal.Parse(txtPrice.Text))
                    .WithDescription(rtxtProductDescription.Text)
                    .WithStock(int.Parse(txtProductStock.Text))
                    .WithCategoryId(categoryId)
                    .WithImage(productImage)
                    .Build();
        try
        {
            var result = ProductCommands.AddProduct(newProduct);
            if (result)
            {
                MessageBox.Show($"Product '{newProduct.ProductName}' created successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormInput();
            }
            else
            {
                MessageBox.Show($"Failed to create product '{newProduct.ProductName}'.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
