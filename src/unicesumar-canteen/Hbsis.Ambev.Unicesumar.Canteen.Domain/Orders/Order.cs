using Hbsis.Ambev.Unicesumar.Canteen.Domain.Products;
using System;
using System.Collections.Generic;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public class Order
    {
        protected Order() { }

        public Order(string clientName)
        {
            ClientName = clientName;
            _products = new List<OrderProduct>();
        }

        private readonly List<OrderProduct> _products;

        public Guid Id { get; protected set; }
        public string ClientName { get; protected set; }
        public decimal Total { get; protected set; }
        public IReadOnlyCollection<OrderProduct> Products => _products.AsReadOnly();

        public Order AddProduct(Product product, int quantity)
        {
            Total += product.Price * quantity;
            _products.Add(new OrderProduct(this, product, quantity));
            return this;
        }
    }
}
