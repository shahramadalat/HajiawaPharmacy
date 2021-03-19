using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using PharmacyHajiawa.Models.View;
using System.Threading.Tasks;

namespace PharmacyHajiawa.Class
{
   public class classAdapter
    {
        classConnection con;

        public classAdapter()
        {
            con = new classConnection();
        }
       public List<ViewBuy> viewBuys = new List<ViewBuy>();
       

        public async void Adapting(string query)
        {
            await classConnection.con.OpenAsync();
            var createCommand = classConnection.con.CreateCommand();
            createCommand.CommandText = @"SELECT        Buy.BuyId, ItemType.TypeName, Item.ScienceName,Buy.BuyPrice,Buy.SellPrice, Buy.Quantity, Buy.Expire
FROM           Buy INNER JOIN
                         BuyInvoice ON Buy.BuyInvoiceId = BuyInvoice.BuyInvoiceId INNER JOIN
                         Company ON BuyInvoice.CompanyId = Company.CompanyId INNER JOIN
                         Item ON Buy.ItemId = Item.ItemId INNER JOIN
                       ItemType ON Buy.ItemTypeId = ItemType.ItemTypeId ";
            var reader = createCommand.ExecuteReader();
            while (reader.Read())
            {
                viewBuys.Add(new ViewBuy 
                { BuyId=int.Parse(reader[0].ToString()),
                  TypeName = reader[1].ToString(),
                  
                });
            }


        }



    }
}
