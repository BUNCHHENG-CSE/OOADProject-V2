﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Function;
using OOADPROV2.Utilities.Observer;
using OOADPROV2.Utilities.Strategies;
using OOADPROV2.Utilities.Strategies.Search;
using OOADPROV2.Utilities.Observer.Product;
namespace OOADPROV2.Forms.CashierDashboardForm
{
    public partial class CashierProductForm : Form ,IObservers<Products>
    {
        private SearchContext searchContext = new(new SearchByTextStrategy());

        public CashierProductForm()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;
            this.FormClosed += ProductForm_FormClosed;
            ProductNotifier.Instance.Attach(this);
            LoadProducts("");
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim();
            LoadProducts(filter);
        }
        public void Update(Products product)
        {
            LoadProducts(txtSearch.Text.Trim());
        }
        private void ProductForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ProductNotifier.Instance.Detach(this);
        }
        private void LoadProducts(string filter)
        {
            var products = searchContext.ExecuteSearch(filter);
            flowLayoutPanelProducts.Controls.Clear();

            foreach (var product in products)
            {
                Panel productPanel = new Panel
                {
                    Width = 180,
                    Height = 290,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(30),
                  
                };

                PictureBox pictureBox = new PictureBox
                {
                    Width = 150,
                    Height = 150,
                    Location = new Point(15, 10),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = product.ProductImage != null
                        ? ConvertImageClass.ConvertByteArrayToImage(product.ProductImage)
                        : null
                };

                Label categoryLabel = new Label
                {
                    Text = product.Category.CategoryName,
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    Size = new Size(150, 25),
                    Location = new Point(15, 200),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label nameLabel = new Label
                {
                    Text = product.ProductName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Size = new Size(150, 25),
                    Location = new Point(15, 225),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Label priceLabel = new Label
                {
                    Text = $"Price: {product.ProductsPrice:C}",
                    Font = new Font("Arial", 9),
                    Size = new Size(150, 20),
                    Location = new Point(15, 245),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                Label stockLabel = new Label
                {
                    Text = $"Stock: {product.ProductsStock}",
                    Font = new Font("Arial", 9),
                    Size = new Size(150, 20),
                    Location = new Point(15, 265),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(categoryLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(stockLabel);
                flowLayoutPanelProducts.Controls.Add(productPanel);

            }
        }
    }
}
