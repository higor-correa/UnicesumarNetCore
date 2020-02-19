using System;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task<TEntity> FindAsync(Guid id);
        Task<TEntity> FindAsync(Guid id, bool includes);
        Task RemoveAsync(Guid id);
        Task RemoveAsync(TEntity entity);
    }
}