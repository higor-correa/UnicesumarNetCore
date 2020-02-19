using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext dbContext) : base(dbContext) { }

        protected override IQueryable<Order> Including(IQueryable<Order> query) => query.Include(x => x.Products);

        public async Task<IEnumerable<Order>> ListAsync(OrderFilter filter, bool includes)
        {
            var query = DbSet.AsQueryable();
            query = includes ? Including(query) : query;

            if (filter.FinalDate.HasValue)
                query = query.Where(x => x.Date <= filter.FinalDate);

            if (filter.InitialDate.HasValue)
                query = query.Where(x => x.Date >= filter.InitialDate);

            if (!string.IsNullOrWhiteSpace(filter.ClientName))
                query = query.Where(x => x.ClientName.ToUpper().Contains(filter.ClientName.ToUpper()));

            return await query.ToListAsync();
        }
    }
}
