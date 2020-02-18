using Hbsis.Ambev.Unicesumar.Canteen.Domain.Products;
using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public class OrderProduct
    {
        protected OrderProduct() { }
        public OrderProduct(Order order, Product product, int quantity)
        {
            Product = product;
            ProductId = product.Id;
            Order = order;
            OrderId = order.Id;
            Quantity = quantity;
        }

        public Guid Id { get; protected set; }
        public int Quantity { get; protected set; }

        public Guid ProductId { get; protected set; }
        public Product Product { get; protected set; }
        public Guid OrderId { get; protected set; }
        public Order Order { get; protected set; }
    }
}
