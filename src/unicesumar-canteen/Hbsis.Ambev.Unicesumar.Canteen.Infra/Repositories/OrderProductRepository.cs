using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class OrderProductRepository : BaseRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(DbContext dbContext) : base(dbContext) { }
    }
}
