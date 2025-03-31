using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Builder.Order;
using OOADPROV2.Utilities.Commands.Order;
using OOADPROV2.Utilities.Commands.Product;
using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OOADPROV2.Forms.CashierDashboardForm
{
    public partial class AddOrderDetailForm : Form
    {
        private List<Products> availableProducts;
        private List<OrderDetails> currentCart = new();

        public AddOrderDetailForm()
        {
            InitializeComponent();
            LoadProducts();
            txtProductName.TextChanged += TxtProductName_TextChanged;
            buttonpay.Click += Buttonpay_Click;
            btnClear.Click += btnClear_Click;
        }

        private void LoadProducts()
        {
            availableProducts = ProductCommands.GetAllProducts().ToList();
            RefreshProductGrid();
        }

        private void TxtProductName_TextChanged(object sender, EventArgs e)
        {
            RefreshProductGrid();
        }

        private void RefreshProductGrid()
        {
            string filter = txtProductName.Text.ToLower();
            var filtered = availableProducts
                .Where(p => p.ProductName.ToLower().Contains(filter))
                .ToList();

            flowLayoutPanel1.Controls.Clear();

            foreach (var product in filtered)
            {
                Panel productPanel = new()
                {
                    Width = 185,
                    Height = 270,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(10)
                };

                PictureBox pictureBox = new()
                {
                    Width = 160,
                    Height = 160,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = product.ProductImage != null
                        ? ConvertImageClass.ConvertByteArrayToImage(product.ProductImage)
                        : null
                };

                Label nameLabel = new()
                {
                    Text = product.ProductName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Size = new Size(160, 25),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(10, 170)
                };

                Label priceLabel = new()
                {
                    Text = $"Price: {product.ProductsPrice:C}",
                    Font = new Font("Arial", 9),
                    Size = new Size(160, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(10, 195)
                };

                productPanel.Click += (s, e) => Product_Click(product);
                pictureBox.Click += (s, e) => Product_Click(product);
                nameLabel.Click += (s, e) => Product_Click(product);
                priceLabel.Click += (s, e) => Product_Click(product);

                productPanel.Controls.Add(pictureBox);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);

                flowLayoutPanel1.Controls.Add(productPanel);
            }
        }

        private void Product_Click(Products product)
        {
            var existing = currentCart.FirstOrDefault(x => x.Products.ProductsID == product.ProductsID);

            if (existing != null)
            {
                if (existing.OrderQty >= product.ProductsStock)
                {
                    MessageBox.Show($"Only {product.ProductsStock} in stock. You've reached the limit.");
                    return;
                }

                existing.OrderQty += 1;
            }
            else
            {
                if (product.ProductsStock <= 0)
                {
                    MessageBox.Show("Out of stock!");
                    return;
                }

                var newDetail = OrderBuilder.Create()
                    .SetProduct(product)
                    .SetQuantity(1)
                    .SetPrice((float)product.ProductsPrice)
                    .Build();

                currentCart.Add(newDetail);
            }

            RefreshCart();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            currentCart.Clear();
            dataGridView1.Rows.Clear();
            txtTotal.Text = "Total: $ 0.00";
        }


        private void RefreshCart()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Rows.Clear();

            foreach (var d in currentCart)
            {
                dataGridView1.Rows.Add(
                    d.Products?.ProductsID ?? 0,
                    d.Products?.ProductName ?? "",
                    d.OrderQty,
                    d.UnitPrice,
                    d.OrderQty * d.UnitPrice,
                    d.OrderDetailID
                );
            }

            txtTotal.Text = $"Total: {currentCart.Sum(d => d.OrderQty * d.UnitPrice):C2}";
        }

        private void Buttonpay_Click(object sender, EventArgs e)
        {
            if (currentCart.Count == 0)
            {
                MessageBox.Show("No items in the cart.");
                return;
            }

            int customerId = OrderCommands.AddNewCustomer();
            var customer = new Customers { CustomerID = customerId };

            var order = new Orders
            {
                Customer = customer,
                DateOrder = DateTime.Now,
                TotalPrice = currentCart.Sum(x => (decimal)x.OrderQty * (decimal)x.UnitPrice),
                StaffID = AppSession.GetStaffIDOrThrow()
            };

            int orderId = OrderCommands.AddOrderAndReturnId(order);
            order.OrderID = orderId;

            foreach (var item in currentCart)
            {
                var finalDetail = OrderBuilder().Create()
                    .SetProduct(item.Products!)
                    .SetQuantity(item.OrderQty)
                    .SetPrice(item.UnitPrice)
                    .SetCustomer(customer)
                    .Build();

                finalDetail.Order = order;

                OrderCommands.AddNewOrder(finalDetail);
            }

            MessageBox.Show("Order added successfully.");
            currentCart.Clear();
            RefreshCart();
        }
    }
}
