using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyHajiawa.Models.Store
{
   public class BuyInvoice
    {
        public int BuyInvoiceId { get; set; }
        public int CompanyId { get; set; }
        public DateTime BuyDate { get; set; }
        public double Total { get; set; }
        public bool IsDeleted { get; set; }

    }
}
