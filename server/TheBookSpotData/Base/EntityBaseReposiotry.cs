using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace TheBookSpotData.Base
{
    public class EntityBaseReposiotry<T> : IEntityBaseReposiotry<T> where T : class, IEntityBase, new()
    {
        protected readonly TheBookSpotContext _context;

        public EntityBaseReposiotry(TheBookSpotContext context)
        {
            _context = context;
        }
        public async Task<List<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        public async Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            var entities = await query.ToListAsync();

            return entities;
        }
        public async Task<T> GetAsync(Guid id) => await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);
        public async Task<T> GetAsync(Guid id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

            var entity = await query.FirstOrDefaultAsync(e => e.Id == id);

            return entity;
        }
        public async Task<T> AddAsync(T entity)
        {
            entity.Id = Guid.NewGuid();

            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
        public async Task<T> DeleteAsync(Guid id)
        {
            var entity = await GetAsync(id);

            if (entity == null)
                return null;

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
        public virtual async Task<T> UpdateAsync(Guid id, T entity)
        {
            var existingEntity = await GetAsync(id);

            if (existingEntity == null)
                return null;

            entity.Id = id;

            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
