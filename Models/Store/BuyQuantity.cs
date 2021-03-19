using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.Store
{
   public class BuyQuantity
    {
        public int BuyQuantityId { get; set; }
        public int RealBuyId { get; set; }
        public int Quantity { get; set; }
    }
}
