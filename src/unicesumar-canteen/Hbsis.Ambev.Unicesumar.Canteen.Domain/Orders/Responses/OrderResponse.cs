using System;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Responses
{
    public class OrderResponse
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public decimal Total { get; set; }
    }
}
