using System;

namespace PharmacyHajiawa.Models
{
   public class Cost
    {
        public int CostId { get; set; }
        public string CostName { get; set; }
        public double CostAmount{ get; set; }
        public DateTime CostDate { get; set; }
        public string Detail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
