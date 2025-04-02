using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOADPROV2.Forms.CashierDashboardForm
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            LoadOrders();
            btnOrderDetail.Click += btnOrderDetail_Click;
        }

        private void LoadOrders()
        {
            dgvOrder.AutoGenerateColumns = false;
            dgvOrder.Rows.Clear();

            var orders = OrderCommands.GetAllOrder().ToList();
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
            var addForm = new AddOrderDetailForm();
            addForm.ShowDialog();
            LoadOrders();
        }
    }
}
