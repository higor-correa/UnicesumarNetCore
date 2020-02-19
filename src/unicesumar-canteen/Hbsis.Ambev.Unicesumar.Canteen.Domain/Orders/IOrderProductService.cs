using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders
{
    public interface IOrderProductService
    {
        Task<IEnumerable<OrderProduct>> GetFromOrderIdAsync(Guid orderId);
    }
}