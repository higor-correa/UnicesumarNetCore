using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Products
{
    public class Product
    {
        protected Product() { }

        public Guid Id { get; protected set; }
        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
    }
}
