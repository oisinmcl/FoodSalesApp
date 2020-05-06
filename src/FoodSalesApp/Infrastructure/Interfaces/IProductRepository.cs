using FoodSalesApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodSalesApp.Infrastructure.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<string>> GetAllProductNames();
    }
}
