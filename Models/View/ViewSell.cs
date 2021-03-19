using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.View
{
   public class ViewSell
    {

        public int SellId { get; set; }
        public int RealBuyId { get; set; }
        public string Barcode { get; set; }
        public string TypeName { get; set; }
        public string CommericalName { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public int Quantity { get; set; }
        public double Total{ get; set; }
    }
}
