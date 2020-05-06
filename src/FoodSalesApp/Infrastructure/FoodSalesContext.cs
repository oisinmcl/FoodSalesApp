using FoodSalesApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;


namespace Infrastructure
{
    public class FoodSalesContext: DbContext
    {
        private readonly string _connectionString;

        public FoodSalesContext(DbContextOptions<FoodSalesContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<CustomerPriceFile> CustomerPriceFiles { get; set; }

    }
}
