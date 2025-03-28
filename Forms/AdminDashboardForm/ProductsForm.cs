﻿using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Product;
using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPROV2.Forms.AdminDashboardForm;

public partial class ProductsForm : Form
{
    int productCount = 0;
    private System.Windows.Forms.Timer clickTimer;
    private new const int DoubleClick = 300;
    private Products _selectedProducts;
    public ProductsForm()
    {
        InitializeComponent();
        btnAddProduct.Click += DoClickAddProducts;
        clickTimer = new System.Windows.Forms.Timer
        {
            Interval = DoubleClick
        };
        clickTimer.Tick += ClickTimer_Tick;
    }
    private void DoClickAddProducts(object? sender, EventArgs e)
    {
        AddProductsForm productsAddForm = new AddProductsForm(this);
        productsAddForm.ProductLoadingChanged += (sender, result) =>
        {
            if (result)
            {
                flowLayoutPanelProducts.Controls.Clear();
                LoadingDataProducts();
            }
        };
        productsAddForm.Show();
    }
    private void LoadingDataProducts()
    {
        try
        {
            flowLayoutPanelProducts.Padding = new Padding(20, 20, 20, 20);
            var result = ProductCommands.GetAllProducts();
            foreach (var product in result)
            {

                Panel productPanel = new Panel
                {
                    Width = 185,
                    Height = 270,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(20)
                };
                productPanel.Margin = new Padding(20, 20, 20, 20);
                PictureBox pictureBox = new PictureBox
                {
                    Width = 180,
                    Height = 180,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = product.ProductImage != null ? ConvertImageClass.ConvertByteArrayToImage(product.ProductImage) : null
                };

                Label productNameLabel = new Label
                {
                    Text = $"Name: {product.ProductName}",
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Size = new Size(180, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = false,
                    Location = new Point(5, 220)
                };

                Label productStockLabel = new Label
                {
                    Text = $"Stock: {product.ProductsStock}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Size = new Size(180, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = false,

                    Location = new Point(5, 240)
                };
                Label categoryNameLabel = new Label
                {
                    Text = $"Category: {product.Category.CategoryName}",
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    Size = new Size(180, 30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = false,

                    Location = new Point(5, 190)
                };

                pictureBox.MouseDown += (s, e) =>
                {
                    if (e.Clicks == 1)
                    {
                        _selectedProducts = product;
                        clickTimer.Start();
                    }
                    else if (e.Clicks == 2)
                    {
                        clickTimer.Stop();
                        DeleteProductsById(product.ProductsID);
                    }
                };

                flowLayoutPanelProducts.Padding = new Padding(20);
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(categoryNameLabel);
                productPanel.Controls.Add(productNameLabel);
                productPanel.Controls.Add(productStockLabel);
                flowLayoutPanelProducts.Controls.Add(productPanel);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving product", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClickTimer_Tick(object? sender, EventArgs e)
    {
        clickTimer.Stop();
        if (_selectedProducts != null)
        {
            LoadProductForUpdate(_selectedProducts);
        }
    }

    private void LoadProductForUpdate(Products products)
    {
        AddProductsForm updateForm = new AddProductsForm(this);
        updateForm.LoadProductDetails(products);
        updateForm.ShowDialog();
        flowLayoutPanelProducts.Controls.Clear();
        LoadingDataProducts();
    }
    private void DeleteProductsById(int productID)
    {
        try
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this member?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                var result = ProductCommands.GetAllProducts();
                bool isDeleted = ProductCommands.DeleteProduct(productID);
                if (isDeleted)
                {
                    MessageBox.Show("Product deleted successfully!");
                    flowLayoutPanelProducts.Controls.Clear();
                    LoadingDataProducts();
                }
                else
                {
                    MessageBox.Show("Failed to delete the product member.");
                }
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting product: {ex.Message}");
        }
    }
    private void ProductsForm_Load(object sender, EventArgs e)
    {
        LoadingDataProducts();
    }
    
}
