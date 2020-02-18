using Hbsis.Ambev.Unicesumar.Canteen.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class BaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly DbContext _context;

        public DbSet<TEntity> DbSet { get; set; }

        public BaseRepository(DbContext dbContext)
        {
            _context = dbContext;
            DbSet = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> FindAsync(Guid id) => await DbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task AddAsync(TEntity entity) => await DbSet.AddAsync(entity);

        public Task UpdateAsync(TEntity entity)
        {
            var isDetached = _context.Entry(entity).State == EntityState.Detached;
            if (isDetached)
            {
                DbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }

            return Task.CompletedTask;
        }

        public Task RemoveAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public async Task RemoveAsync(Guid id)
        {
            var entity = await FindAsync(id);
            DbSet.Remove(entity);
        }
    }
}
