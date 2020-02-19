using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories
{
    public interface IOrderProductRepository
    {
        Task AddAsync(OrderProduct entity);
        Task UpdateAsync(OrderProduct entity);
        Task RemoveAsync(OrderProduct entity);
        Task AddOrUpdateAsync(OrderProduct orderProduct);
    }
}
