using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Models.View;
using PharmacyHajiawa.Views.Message;
using PharmacyHajiawa.Views.Store.Buy;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PharmacyHajiawa.Views.Store.Sell
{
    /// <summary>
    /// Interaction logic for MainSellPage.xaml
    /// </summary>
    public partial class MainSellPage : Page
    {
        public MainSellPage()
        {
            InitializeComponent();
        }
        List<ViewSell> viewSell = new List<ViewSell>();
        Query query = new Query();
        private async void getTotal()
        {
            string result = await query.GetOneNoParameter(" select sum(Total) as Total from ViewSell ");
            inTotal.Text = result;
        }
        public void getSells()
        {
            mainDatagrid.ItemsSource = viewSell = dotNETConnection.ConvertSqlToList<Models.View.ViewSell>("select * from ViewSell");
            mainDatagrid.Columns[2].Visibility = Visibility.Collapsed;
            mainDatagrid.Columns[3].Visibility = Visibility.Collapsed;
            mainDatagrid.Columns[4].Visibility = Visibility.Collapsed;
            mainDatagrid.Columns[5].Header = "جۆری کاڵا";
            mainDatagrid.Columns[6].Header = "ناوی بازرگانی";
            mainDatagrid.Columns[7].Header = "نرخی کڕین";
            mainDatagrid.Columns[8].Header = "نرخی فرۆشتن";
            mainDatagrid.Columns[9].Header = "دانە";
            mainDatagrid.Columns[10].Header = "سەرجەم";
            mainDatagrid.Columns[1].DisplayIndex = 8;
            mainDatagrid.Columns[0].DisplayIndex = 9;
            getTotal();
        }
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {

            getSells();
            inSellDate.SelectedDate = DateTime.Now.Date;
            inSellInvoiceId.Content = (int.Parse(await query.GetLastIdAsync("SellInvoiceId", "SellInvoice")) + 1).ToString();
        }
        private async void OnAddClicked(object sender, RoutedEventArgs e)
        {
            ForPageWindow forPage = new ForPageWindow("ForSell");
            forPage.ShowDialog();
            try
            {
                string buyId = StoreViewPage.RealBuyId.ToString();
                int quantity = int.Parse(await query.GetTwo($"SELECT Quantity from BuyQuantity WHERE RealBuyId={buyId}; ", 0));
                if (quantity == 0)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "هیچ دانەیەکت لەم کاڵایە نەماوە، ئەگەر بەردەستە تکایە لەبەشی کاڵادا زیادی بکە", "باشە");
                    alert.ShowDialog();
                    return;
                }
                else
                {
                    await query.ExcuteAsync($"update BuyQuantity set Quantity=Quantity-1 where RealBuyId={buyId}");
                }
                await query.ExcuteAsync($" insert into Sells(SellPrice,RealBuyId) values({StoreViewPage.SellPrice},{buyId})");
                inBarcode.Text = null;
                getSells();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("تکایە دووبارە هەوڵ بەرەوە، یاخوود ئەم کاڵایەت داخڵ نەکردوە لەبەشی کڕیندا");
                inBarcode.Text = null;
                inBarcode.Focus();
            }

        }
        private async void OnBuyClicked(object sender, RoutedEventArgs e)
        {
            //insert all from sell table to real sell table
            try
            {
                if (!mainDatagrid.HasItems)
                {
                    MessageBox.Show("کاڵات دیاری نەکردوە بۆ فرۆشتن");
                    return;
                }
                PrintWindow printWindow = new PrintWindow(int.Parse(inSellInvoiceId.Content.ToString()), double.Parse(inTotal.Text), double.Parse(inDiscount.Text));
                printWindow.ShowDialog();
                if (!PrintWindow.isSuccess)
                {
                    return;
                }
                query.ExcuteAsyncTrans(new List<string>() {
                $@"insert into RealSell(SellInvoiceId,RealBuyId,SellPrice)
                select {inSellInvoiceId.Content.ToString()},
                RealBuyId, SellPrice from Sells",
                "delete from Sells",
                $@"insert into SellInvoice(SellInvoiceId, Date, Total, DiscountAmount, IsDeleted)
                values({inSellInvoiceId.Content.ToString()},
                '{inSellDate.SelectedDate.Value.Date.ToString("dd-MM-yyyy")}',
                {inTotal.Text},{inDiscount.Text},0)"
                });
                inSellInvoiceId.Content = (int.Parse(await query.GetLastIdAsync("SellInvoiceId", "SellInvoice")) + 1).ToString();
                getSells();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "هەڵەیەک ڕوی دا تکایە دوبارە هەوڵ بەرەوە", "باشە");
                alert.ShowDialog();
                return;
            }
        }

        Models.Store.Sells sells = new Models.Store.Sells();
        List<Models.View.ViewSellForSellModel> viewSellForSellModels = new List<ViewSellForSellModel>();
        private async void inBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    string buyId = await query.GetOne("SELECT BuyId from RealBuy WHERE Barcode=@barcode;", new string[,] { { "@barcode", inBarcode.Text } });
                    int quantity = int.Parse(await query.GetTwo($"SELECT Quantity from BuyQuantity WHERE RealBuyId={buyId}; ", 0));
                    if (quantity == 0)
                    {
                        DisplayAlert alert = new DisplayAlert("ئاگاداری", "هیچ دانەیەکت لەم کاڵایە نەماوە، ئەگەر بەردەستە تکایە لەبەشی کاڵادا زیادی بکە", "باشە");
                        alert.ShowDialog();
                        return;
                    }
                    else
                    {
                        await query.ExcuteAsync($"update BuyQuantity set Quantity=Quantity-1 where RealBuyId={buyId}");
                    }
                    await query.GetTwo($"SELECT BuyId, SellPrice FROM RealBuy WHERE BuyId ={ buyId}", 1);
                    await query.ExcuteAsync($" insert into Sells(SellPrice,RealBuyId) values({Query.SecondValue},{Query.FirstValue})");
                    inBarcode.Text = null;
                    getSells();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("تکایە دووبارە هەوڵ بەرەوە، یاخوود ئەم کاڵایەت داخڵ نەکردوە");
                    inBarcode.Text = null;
                    inBarcode.Focus();
                }


            }
        }
        private async void OnMinusQuantityClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var person = mainDatagrid.SelectedItem as Models.View.ViewSell;
                await query.ExcuteAsync($"update BuyQuantity set Quantity=Quantity+1 where RealBuyId={person.RealBuyId}");
                await query.ExcuteAsync($"delete from Sells where SellId={person.SellId}");
                getSells();

            }
        }
        private async void OnAddQuantityClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var person = mainDatagrid.SelectedItem as Models.View.ViewSell;
                int quantity = int.Parse(await query.GetOne($"SELECT Quantity from BuyQuantity WHERE RealBuyId=@id; ", new string[,] { { "@id", person.RealBuyId.ToString() } }));
                if (quantity == 0)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "هیچ دانەیەکت لەم کاڵایە نەماوە، ئەگەر بەردەستە تکایە لەبەشی کاڵادا زیادی بکە", "باشە");
                    alert.ShowDialog();
                    return;
                }
                else
                {
                    await query.ExcuteAsync($"update BuyQuantity set Quantity=Quantity-1 where RealBuyId={person.RealBuyId}");
                    Models.Store.Sells sells = new Models.Store.Sells
                    {
                        RealBuyId = person.RealBuyId,
                        SellPrice = person.SellPrice
                    };
                    await query.InsertAsync(sells);
                    getSells();
                }
            }
        }
        private void inDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double userage;
                if (!double.TryParse(inDiscount.Text, out userage) && inDiscount.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inDiscount.Text.Length != 0)
                    {
                        inDiscount.Text = inDiscount.Text.Remove(inDiscount.Text.Length - 1, 1);
                    }
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                inDiscount.Text = "0";
                getTotal();

            }
        }
        private void inTotal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void inDiscount_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                if (inDiscount.Text is null || inDiscount.Text is "")
                {
                    inDiscount.Text = "0";
                    getTotal();
                }
                if (inDiscount.Text == "0")
                {
                    getTotal();
                }

                inTotal.Text = Convert.ToString(Convert.ToDouble(inTotal.Text) - Convert.ToDouble(inDiscount.Text));


            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕوی دا تکایە دوبارە هەوڵ بەرەوە");
                inDiscount.Text = "0";
                getTotal();
            }
        }

        private async void mainDatagrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var person = mainDatagrid.SelectedItem as Models.View.ViewSell;
            if (person is null)
            {
                return;
            }
            DisplaySheet sheet = new DisplaySheet(new List<string> { "گۆڕینی نرخی فرۆشتن", "ڕەشکردنەوە", "فرۆشتن بە پاکەت" });
            sheet.ShowDialog();
            if (DisplaySheet.theResult == "گۆڕینی نرخی فرۆشتن")
            {
                SellChange sellChange = new SellChange(person.RealBuyId, person.SellPrice);
                sellChange.ShowDialog();
                getSells();
            }
            else if (DisplaySheet.theResult == "ڕەشکردنەوە")
            {
                await query.ExcuteProcedureAsyncWithParameter("spTransUpdateQuantity", new string[,]
                    {{"@RealBuyId",person.RealBuyId.ToString() },
                    {"@quantity",person.Quantity.ToString() }
                    });
                getSells();
            }
            else if (DisplaySheet.theResult == "فرۆشتن بە پاکەت")
            {
                PacketWindow g = new PacketWindow(person.RealBuyId);
                g.ShowDialog();
                if (PacketWindow.isSuccess)
                {
                    for (int i = 0; i < PacketWindow.Q; i++)
                    {
                        int quantity = int.Parse(await query.GetOne($"SELECT Quantity from BuyQuantity WHERE RealBuyId=@id; ", new string[,] { { "@id", person.RealBuyId.ToString() } }));
                        if (quantity == 0)
                        {
                            DisplayAlert alert = new DisplayAlert("ئاگاداری", "هیچ دانەیەکت لەم کاڵایە نەماوە، ئەگەر بەردەستە تکایە لەبەشی کاڵادا زیادی بکە", "باشە");
                            alert.ShowDialog();
                            break;
                        }
                        await query.ExcuteAsync($"update BuyQuantity set Quantity=Quantity-1 where RealBuyId={person.RealBuyId}");
                        await query.ExcuteAsync($" insert into Sells(SellPrice,RealBuyId) values({person.SellPrice},{person.RealBuyId})");

                    }
                    getSells();

                }




            }
        }


    }
}
