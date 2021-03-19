using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.Store
{
   public class Sells
    {
        public int SellsId { get; set; }
        public int SellInvoiceId { get; set; }
        public int RealBuyId { get; set; }
        public double SellPrice { get; set; }


    }
}
