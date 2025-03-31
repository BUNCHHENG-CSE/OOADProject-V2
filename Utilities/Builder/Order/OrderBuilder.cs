using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Builder.Order
{
    public class OrderBuilder : IBuilder<OrderDetails>
    {
        private int _orderQty;
        private float _unitPrice;
        private Customers? _customer;
        private Products? _product;
        private OrderBuilder() { }
        public static OrderBuilder Create() => new();

        public OrderBuilder SetProduct(Products product)
        {
            _product = product;
            return this;
        }

        public OrderBuilder SetQuantity(int qty)
        {
            _orderQty = qty;
            return this;
        }

        public OrderBuilder SetPrice(float price)
        {
            _unitPrice = price;
            return this;
        }

        public OrderBuilder SetCustomer(Customers customer)
        {
            _customer = customer;
            return this;
        }

        public OrderDetails Build()
        {
            return new OrderDetails
            {
                Products = _product,
                OrderQty = _orderQty,
                UnitPrice = _unitPrice,
                Customer = _customer
            };
        }
    }
}
