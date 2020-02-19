using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext dbContext) : base(dbContext) { }
    }
}
