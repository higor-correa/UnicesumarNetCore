using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests
{
    public class OrderProductRequest
    {
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    }
}
