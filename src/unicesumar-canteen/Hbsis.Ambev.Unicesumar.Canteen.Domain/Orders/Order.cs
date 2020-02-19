using Hbsis.Ambev.Unicesumar.Canteen.Domain.Products;
using System.Collections.Generic;
using System.Linq;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public class Order : BaseEntity
    {
        protected Order()
        {
            _products = new List<OrderProduct>();
        }

        public Order(string clientName) : this()
        {
            ClientName = clientName;
        }

        private readonly List<OrderProduct> _products;

        public string ClientName { get; protected set; }
        public decimal Total { get; protected set; }
        public IReadOnlyCollection<OrderProduct> Products => _products.AsReadOnly();

        public OrderProduct AddProduct(Product product, int quantity)
        {
            Total += product.Price * quantity;
            var orderProduct = _products.FirstOrDefault(x => x.ProductId == product.Id);

            if (orderProduct == null)
            {
                orderProduct = new OrderProduct(this, product, quantity);
                _products.Add(orderProduct);
            }
            else
                orderProduct.Increase(quantity);

            return orderProduct;
        }

        public OrderProduct RemoveProduct(Product product, int quantity)
        {
            var orderProduct = _products.FirstOrDefault(x => x.ProductId == product.Id);

            if (orderProduct != null)
            {
                var quantityToRemove = quantity > orderProduct.Quantity ? orderProduct.Quantity : quantity;

                Total -= product.Price * quantityToRemove;
                orderProduct.Decrease(quantityToRemove);
                if (orderProduct.IsEmpty())
                    _products.Remove(orderProduct);
            }

            return orderProduct;
        }
    }
}
