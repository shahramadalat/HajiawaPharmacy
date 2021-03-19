using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.Store
{
   public class RealSell
    {
        public int RealSellId { get; set; }
        public int SellInvoiceId { get; set; }
        public int RealBuyId { get; set; }
        public double SellPrice { get; set; }
    }
}
