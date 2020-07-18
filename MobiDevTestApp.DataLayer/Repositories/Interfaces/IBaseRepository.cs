using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobiDevTestApp.DataLayer.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class, new()
    {
        Task<IEnumerable<TEntity>> GetList();

        Task Add(TEntity entity);
        Task Edit(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> Get(long id);

    }
}
