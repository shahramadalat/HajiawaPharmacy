using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.View
{
   public class ViewStore
    {
        public int BuyId { get; set; }
        public int BuyInvoiceId { get; set; }
        public int ItemId { get; set; }
        public string Barcode { get; set; }
        public string CommericalName { get; set; }
        public string TypeName { get; set; }
        public DateTime BuyDate { get; set; }
        public DateTime Expire { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public int isDeleted { get; set; }
        public int Quantity { get; set; }
    }
}
