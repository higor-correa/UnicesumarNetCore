using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Responses
{
    public class OrderProductResponse
    {
        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
    }
}
