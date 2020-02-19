using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<IEnumerable<Order>> ListAsync(OrderFilter filter, bool includes);
    }
}
