using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FoodSalesApp.Core.Entities
{
    [Serializable]
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
