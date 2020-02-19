using Hbsis.Ambev.Unicesumar.Canteen.Domain;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContext _context;

        public DbSet<TEntity> DbSet { get; set; }

        public BaseRepository(DbContext dbContext)
        {
            _context = dbContext;
            DbSet = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> FindAsync(Guid id) =>
            await DbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<TEntity>> FindAsync(params Guid[] id) =>
            await DbSet.Where(x => id.Contains(x.Id)).ToListAsync();

        public async Task AddOrUpdateAsync(TEntity entity)
        {
            if (entity.Id == Guid.Empty)
                await AddAsync(entity);
            else
                await UpdateAsync(entity);
        }

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
