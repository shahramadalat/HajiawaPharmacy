using System;

namespace PharmacyHajiawa.Models.View
{
    public class ViewBuy
    {
        //Buy.BuyId, ItemType.TypeName, Item.ScienceName,Buy.BuyPrice,Buy.SellPrice, Buy.Quantity, Buy.Expire
        //FROM
        public int BuyId { get; set; }
        public string TypeName { get; set; }
        public string CommericalName { get; set; }
        public string Barcode { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime Expire { get; set; }

    }
}
