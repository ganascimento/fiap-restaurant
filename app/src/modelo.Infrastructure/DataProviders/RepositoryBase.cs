using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo.Infrastructure.Extensions;

namespace modelo.Infrastructure.DataProviders
{
    public abstract class RepositoryBase<TEntity, TKey> : IRepositoryGateway<TEntity, TKey> where TEntity : Entity<TKey>
    {
        private readonly DBContext dBContext;
        private readonly DbSet<TEntity> dbSet;

        public RepositoryBase(DBContext dBContext)
        {
            this.dBContext = dBContext;
            this.dbSet = dBContext.Set<TEntity>();
           
        }
    
        public async Task DeleteAsync(TKey key)
        {
            var entity = await dbSet.WhereIdEquals(x => x.Id, key).FirstOrDefaultAsync();

            if (entity != null)
            {
                dbSet.Remove(entity);
                await dBContext.SaveChangesAsync();
            }
        }

        public TEntity Get(TKey key) => dbSet.AsNoTracking().WhereIdEquals(x=>x.Id, key).FirstOrDefault();
        

        public IQueryable<TEntity> GetAll()
        {
            return dbSet.AsNoTracking();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await dbSet.AsNoTracking().ToListAsync();
        }

        public Task<TEntity> GetAsync(TKey key) => dbSet.AsNoTracking().WhereIdEquals(x => x.Id, key).FirstOrDefaultAsync();


        public async Task<IEnumerable<TEntity>> GetByIdAsync(IEnumerable<TKey> Keys)
        {
            return await dbSet.AsNoTracking().Where(x => Keys.Contains(x.Id)).ToListAsync();
        }

        public int Insert(TEntity entity)
        {
            dbSet.Add(entity);
            return dBContext.SaveChanges();
        }

        public Task InsertAsync(TEntity entity)
        {
            dbSet.Add(entity);
            return dBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> IQueryableToIEnumerableEntity(IQueryable<TEntity> query)
        {
            return await query.ToListAsync();
        }

        public int Update(TEntity entity)
        {
            dBContext.Update(entity).State = EntityState.Modified;
            return dBContext.SaveChanges();
        }

        public Task UpdateAsync(TEntity entity)
        {
            dBContext.Update(entity).State = EntityState.Modified;
            return dBContext.SaveChangesAsync();
        }
    }
}
