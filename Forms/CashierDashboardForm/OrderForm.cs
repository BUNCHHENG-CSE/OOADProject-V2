using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Order;
using OOADPROV2.Utilities.Function;
using OOADPROV2.Utilities.Facade.Dashboard;
using OOADPROV2.Utilities.Observer.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OOADPROV2.Utilities.Observer;

namespace OOADPROV2.Forms.CashierDashboardForm
{
    public partial class OrderForm : Form, IObservers<Products>
    {
        public OrderForm()
        {
            InitializeComponent();
            ProductNotifier.Instance.Attach(this); 
            this.FormClosed += OrderForm_FormClosed;

            LoadOrders();
            btnOrderDetail.Click += btnOrderDetail_Click;
        }

        private void LoadOrders()
        {
            dgvOrder.AutoGenerateColumns = false;
            dgvOrder.Rows.Clear();

            var orders = OrderGet.All().ToList();
            foreach (var order in orders)
            {
                dgvOrder.Rows.Add(
                    order.OrderID,
                    order.DateOrder?.ToString("yyyy-MM-dd HH:mm"),
                    order.TotalPrice,
                    order.Customer?.CustomerID ?? 0
                );
            }
        }

        private void btnOrderDetail_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            AddOrderDetailForm addOrderForm = new AddOrderDetailForm();

            addOrderForm.FormClosed += (s, args) =>
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            };
            addOrderForm.Show();
        }

        public void Update(Products updatedProduct)
        {
            LoadOrders(); 
        }

        private void OrderForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ProductNotifier.Instance.Detach(this);
        }
    }
}
