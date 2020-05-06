using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using FoodSalesApp.Core.Entities;

namespace FoodSalesApp.Core.Entities
{
    [Serializable]
    public class Category
    {
        public int CategoryId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
