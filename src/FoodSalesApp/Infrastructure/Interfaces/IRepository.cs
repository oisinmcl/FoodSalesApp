using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodSalesApp.Infrastructure.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task Create(TEntity entity);
        void Delete(TEntity entity);
    }
}
