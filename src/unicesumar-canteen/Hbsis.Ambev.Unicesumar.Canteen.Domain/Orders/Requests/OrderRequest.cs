using System.Collections.Generic;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders.Requests
{
    public class OrderRequest
    {
        public OrderRequest()
        {
            Products = new List<OrderProductRequest>();
        }

        public string ClientName { get; set; }
        public ICollection<OrderProductRequest> Products { get; set; }
    }
}
