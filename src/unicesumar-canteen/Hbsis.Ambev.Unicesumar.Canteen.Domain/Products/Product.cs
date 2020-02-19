using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Products
{
    public class Product : BaseEntity
    {
        protected Product() { }

        public Product(Guid id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }

        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
    }
}
