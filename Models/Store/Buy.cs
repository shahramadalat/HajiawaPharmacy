using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.Store
{
   public class Buy
    {
        public int BuyId { get; set; }
        public string Barcode { get; set; }
        public int BuyInvoiceId { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemId { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime Expire { get; set; }
        public int PocketId { get; set; }
    }
}
