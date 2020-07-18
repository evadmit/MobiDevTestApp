using Microsoft.EntityFrameworkCore;
using MobiDevTestApp.DataLayer.Entities;
using MobiDevTestApp.DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.DataLayer.Repositories
{
    public class BaseRepository<TEntity>: IBaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(TEntity entity)
        {
            await _dbContext.AddAsync<TEntity>(entity);
            await SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task Edit(TEntity entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> Get(long id)
        {
            TEntity entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetList()
        {
            List<TEntity> entities = await _dbContext.Set<TEntity>().ToListAsync();
            return entities;
        }
        private async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
