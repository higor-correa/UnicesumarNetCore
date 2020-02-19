using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext dbContext) : base(dbContext) { }
        protected override IQueryable<Order> Including(IQueryable<Order> query) => query.Include(x => x.Products);
    }
}
