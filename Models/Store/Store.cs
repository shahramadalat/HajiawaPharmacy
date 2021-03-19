using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.Store
{
   public class Store
    {
        public int StoreId { get; set; }
        public int BuyId { get; set; }
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }

    }
}
