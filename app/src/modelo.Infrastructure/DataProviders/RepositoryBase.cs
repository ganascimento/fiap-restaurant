using Microsoft.EntityFrameworkCore;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modelo.Infrastructure.Extensions;
using modelo.Domain.Entities.Base;

namespace modelo.Infrastructure.DataProviders
{
    public abstract class RepositoryBase<TEntity, TKey> : IRepositoryGateway<TEntity, TKey> where TEntity : Entity<TKey>
    {
        private readonly DBContext _dBContext;
        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(DBContext dBContext)
        {
            _dBContext = dBContext;
            _dbSet = dBContext.Set<TEntity>();

        }

        public TEntity Get(TKey key) => _dbSet.AsNoTracking().WhereIdEquals(x => x.Id, key).FirstOrDefault();


        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public Task<TEntity> GetAsync(TKey key) =>
            _dbSet.AsNoTracking().WhereIdEquals(x => x.Id, key).FirstOrDefaultAsync();


        public async Task<IEnumerable<TEntity>> GetByIdAsync(IEnumerable<TKey> keys) =>
            await _dbSet.AsNoTracking().Where(x => keys.Contains(x.Id)).ToListAsync();

        public async Task<TEntity> GetByIdAsync(TKey key) =>
            await _dbSet.WhereIdEquals(x => x.Id, key).FirstOrDefaultAsync();

        public async Task<IEnumerable<TEntity>> IQueryableToIEnumerableEntity(IQueryable<TEntity> query)
        {
            return await query.ToListAsync();
        }

        public int Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            return _dBContext.SaveChanges();
        }

        public Task InsertAsync(TEntity entity)
        {
            entity.DataCriacao = DateTime.UtcNow;
            _dbSet.Add(entity);
            return _dBContext.SaveChangesAsync();
        }

        public int Update(TEntity entity)
        {
            _dBContext.Update(entity).State = EntityState.Modified;
            return _dBContext.SaveChanges();
        }

        public Task UpdateAsync(TEntity entity)
        {
            _dBContext.Update(entity).State = EntityState.Modified;
            return _dBContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TKey key)
        {
            var entity = await _dbSet.WhereIdEquals(x => x.Id, key).FirstOrDefaultAsync();

            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _dBContext.SaveChangesAsync();
            }
        }
    }
}
