using Hbsis.Ambev.Unicesumar.Canteen.Domain.Products;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext) { }
    }
}
