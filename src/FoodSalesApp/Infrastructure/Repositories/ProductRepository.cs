using FoodSalesApp.Core.Entities;
using FoodSalesApp.Infrastructure.Interfaces;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSalesApp.Infrastructure.Repositories
{
    class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(FoodSalesContext context)
            : base(context)
        { }

        public async Task<IEnumerable<string>> GetAllProductNames()
        {
            return await _context.Products
               .Select(p => p.Name)
               .ToListAsync();
        }
    }
}
