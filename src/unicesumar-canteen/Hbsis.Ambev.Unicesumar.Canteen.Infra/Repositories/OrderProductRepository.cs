using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class OrderProductRepository : BaseRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(DbContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<OrderProduct>> GetFromOrderIdAsync(Guid orderId) =>
            await DbSet.Where(x => x.OrderId == orderId).ToListAsync();
    }
}
