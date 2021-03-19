using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.Store
{
   public class SellInvoice
    {
        public int SellInvoiceId { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public double DiscountAmount { get; set; }
        public int IsDeleted { get; set; }

    }
}
