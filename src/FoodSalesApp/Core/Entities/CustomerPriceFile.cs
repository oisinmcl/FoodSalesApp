using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodSalesApp.Core.Entities
{
    [Serializable]
    public class CustomerPriceFile
    {
        public int CustomerPriceFileId { get; set; }
        [Required]
        public CustomerProduct CustomerProduct { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
