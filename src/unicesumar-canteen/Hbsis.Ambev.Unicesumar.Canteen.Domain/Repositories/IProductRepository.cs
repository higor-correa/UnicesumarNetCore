using Hbsis.Ambev.Unicesumar.Canteen.Domain.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> FindAsync(Guid id);
        Task<IEnumerable<Product>> FindAsync(params Guid[] id);
    }
}
