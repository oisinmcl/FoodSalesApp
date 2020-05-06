using System;
using System.Collections.Generic;
using System.Text;

namespace FoodSalesApp.Core.Entities
{
    [Serializable]
    public class CustomerProduct
    {
        public int CustomerProductId { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }

    }
}
