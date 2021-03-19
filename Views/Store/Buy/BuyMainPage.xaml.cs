using PharmacyHajiawa.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using PharmacyHajiawa.Models.Store;
using PharmacyHajiawa.Views.Message;
using PharmacyHajiawa.Class.dotNET;
using System.Data;
using PharmacyHajiawa.Views.Company;

namespace PharmacyHajiawa.Views.Store.Buy
{
    /// <summary>
    /// Interaction logic for BuyMainPage.xaml
    /// </summary>
    public partial class BuyMainPage : Page
    {
        List<BuyInvoice> buyInvoice = new List<BuyInvoice>();
        List<PharmacyHajiawa.Models.View.ViewBuy> viewBuys = new List<Models.View.ViewBuy>();

        public static string lastBuyInvoiceId;
        private int CompanyId;
        public BuyMainPage()
        {
            InitializeComponent();
          
        }
        bool _isSell;
        public BuyMainPage(bool isSell)
        {
            InitializeComponent();
            _isSell = isSell;
        }
        Query query = new Query();

        void GetBuys() 
        {
            dotNETConnection con = new dotNETConnection();
            viewBuys = dotNETConnection.ConvertSqlToList<PharmacyHajiawa.Models.View.ViewBuy>(@"
                SELECT Buy.BuyId, ItemType.TypeName, Item.CommericalName,Item.Barcode, Buy.BuyPrice, Buy.SellPrice, Buy.Quantity, Buy.Expire
                FROM Buy  INNER JOIN
                Item ON Buy.ItemId = Item.ItemId INNER JOIN
                ItemType ON Buy.ItemTypeId = ItemType.ItemTypeId");
            mainDatagrid.ItemsSource = viewBuys;
            mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
            mainDatagrid.Columns[1].Header= "جۆری کاڵا";
            mainDatagrid.Columns[2].Header = "ناوی بازرگانی";
            mainDatagrid.Columns[3].Header = "بارکۆد";
            mainDatagrid.Columns[4].Header = "نرخی کڕین";
            mainDatagrid.Columns[5].Header = "نرخی فرۆشتن";
            mainDatagrid.Columns[6].Header = "دانە";
            mainDatagrid.Columns[7].Header = "بەسەرچوون";
        }
        void getLastInvoiceId()
        {
            lastBuyInvoiceId = (int.Parse(query.GetLastId("BuyInvoiceId", "BuyInvoice")) + 1).ToString();
            inBuyInvoiceId.Content = lastBuyInvoiceId;
         
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            inBuyDate.SelectedDate = DateTime.Now;
            GetBuys();
            getLastInvoiceId();
        }

        private async void OnAddClicked(object sender, RoutedEventArgs e)
        {
            BuyWindow bw = new BuyWindow(true);
            bw.ShowDialog();
            GetBuys();
           
        }

        private async void mainDatagrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            var person = mainDatagrid.SelectedItem as Models.View.ViewBuy;
            if (person is null)
            {
                return;
            }
            BuyWindow buyWindow = new BuyWindow(false,person.BuyId);
            buyWindow.ShowDialog();
            GetBuys();
        }

        private async void OnBuyClicked(object sender, RoutedEventArgs e)
        {
            try
            {

                #region Validation
                DateTime outdate;
                if (!DateTime.TryParse(inBuyDate.Text, out outdate))
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە بەرواری کڕین دیاری بکە", "باشە");
                    alert.ShowDialog();
                    return;
                }
                if (inCompany.Content is null || inCompany.Content is "")
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە کۆمپانیا دیاری بکە", "باشە");
                    alert.ShowDialog();
                    return;
                }

                if (mainDatagrid.Items.Count < 1)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "هیچ کاڵایەک تۆمار نەکراوە بۆ کڕین", "باشە");
                    alert.ShowDialog();
                    return;
                }
                #endregion

                Query q = new Query();
               await q.ExcuteAsync(@"INSERT INTO BuyQuantity (RealBuyId,Quantity)
                            SELECT BuyId, Quantity FROM Buy; ");
               await q.ExcuteAsync(@"INSERT INTO RealBuy (BuyId,BuyInvoiceId,ItemTypeId,ItemId,BuyPrice,SellPrice,Quantity,Expire,IsDeleted,Barcode,PocketId)
                            SELECT BuyId,BuyInvoiceId,ItemTypeId,ItemId,BuyPrice,SellPrice,Quantity,Expire,0,Barcode,PocketId FROM Buy; 
                            DELETE FROM Buy;");
              
                BuyInvoice buyInvoice1 = new BuyInvoice();
            buyInvoice1.BuyInvoiceId = int.Parse(lastBuyInvoiceId);
            buyInvoice1.BuyDate = inBuyDate.SelectedDate.Value;
                buyInvoice1.CompanyId = CompanyId;
                buyInvoice1.IsDeleted = false;
                buyInvoice1.Total = viewBuys.Sum(i => i.BuyPrice*i.Quantity);
                await query.InsertAsync(buyInvoice1);
                getLastInvoiceId();
                GetBuys();
                DisplayAlert alert1 = new DisplayAlert("نامە", "سەرکەوتوبوو", "باشە");
                alert1.ShowDialog();
            }
            catch (Exception ex)
            {
                DisplayAlert alert1 = new DisplayAlert("ئاگاداری", "کێشەیەک ڕویدا تکایە دووبارە هەوڵ بەرەوە", "باشە");
                MessageBox.Show(ex.Message);
                alert1.ShowDialog();
            }

        }

        private void OnAddCompanyClicked(object sender, RoutedEventArgs e)
        {
            ForPageWindow forPageWindow = new ForPageWindow("CompanySelect");
            forPageWindow.ShowDialog();
            CompanyId = CompanyViewPage.CompanyId;
            inCompany.Content = CompanyViewPage.CompanyName;
        }
    }
}
