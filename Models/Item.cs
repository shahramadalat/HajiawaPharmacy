namespace PharmacyHajiawa.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public int ItemTypeId { get; set; }
        public string Barcode { get; set; }
        public string ScienceName { get; set; }
        public string CommericalName { get; set; }
        public int Power { get; set; }
        public bool Status { get; set; }
    }
}
