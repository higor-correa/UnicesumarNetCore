namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Products
{
    public class Product : BaseEntity
    {
        protected Product() { }

        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
    }
}
