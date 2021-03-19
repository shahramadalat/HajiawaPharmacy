using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Items.item;
using PharmacyHajiawa.Views.Message;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PharmacyHajiawa.Views.Store.Buy
{
    /// <summary>
    /// Interaction logic for BuyWindow.xaml
    /// </summary>
    public partial class BuyWindow : Window
    {
        public bool _isAdd;

        private int ItemId;
        private int ItemTypeId;
        private string Barcode;
        Query query = new Query();



        public int ItemViewPage { get; private set; }

        private int _buyId;
        public BuyWindow(bool isAdd)
        {
            InitializeComponent();
            _isAdd = isAdd;
        }
        public BuyWindow(bool isAdd, int BuyId)
        {
            InitializeComponent();
            _isAdd = isAdd;
            _buyId = BuyId;
        }

        private int _isStore = 0;
        public BuyWindow(int isStore,int BuyId)

        {
            InitializeComponent();
            _isStore = isStore;
            _buyId = BuyId;
        }


        List<Models.Store.Buy> buysUp = new List<Models.Store.Buy>();
        List<Models.ItemType> itemTypes = new List<Models.ItemType>();
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_isStore==1)
                {
                    classConnection con = new classConnection();
                    SqlCommand command = new SqlCommand($"select from ");
                    return;
                }
                if (_isAdd)
                {
                    buttonDelete.Visibility = Visibility.Collapsed;
                }
                else
                {
                    buysUp = dotNETConnection.ConvertSqlToList<Models.Store.Buy>($"select * from Buy where BuyId={_buyId}");
                    ItemId = buysUp.FirstOrDefault().ItemId;
                    ItemTypeId = buysUp.FirstOrDefault().ItemTypeId;
                    itemTypes = dotNETConnection.ConvertSqlToList<Models.ItemType>($"select * from ItemType where ItemTypeId={buysUp.FirstOrDefault().ItemTypeId}");
                    Query q = new Query();
                    inBuyPrice.Text = buysUp.FirstOrDefault().BuyPrice.ToString();
                    inBarcode.Text = buysUp.FirstOrDefault().Barcode.ToString();
                    inSellPrice.Text = buysUp.FirstOrDefault().SellPrice.ToString();
                    inQuantity.Text = buysUp.FirstOrDefault().Quantity.ToString();
                    inExpire.SelectedDate = buysUp.FirstOrDefault().Expire;
                    inType.Text = itemTypes.FirstOrDefault().TypeName;
                    inItem.Text = await q.GetOne("SELECT ScienceName FROM Item WHERE ItemTypeId=@id AND ItemId=@iid", new string[,] { { "@id", buysUp.FirstOrDefault().ItemTypeId.ToString() }, { "@iid", buysUp.FirstOrDefault().ItemId.ToString() } });
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }
        }

        private async void OnDeleteClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "دڵنیای لەڕەشکردنەوەکە؟", "بەڵێ", "نەخێر");
                alert.ShowDialog();
                if (DisplayAlert.theResult is "نەخێر")
                {
                    return;
                }
                await query.ExcuteAsync($"delete from Buy where BuyId={_buyId}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }

        }

        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                
                #region validation
                if (inItem.Text is null || inItem.Text is "" || inType.Text is "" || inType.Text is null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە کاڵا هەڵبژێرە", "باشە"); alert.ShowDialog();
                    return;
                }

                if (inQuantity.Text is null || inQuantity.Text is "")
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە دانەی کاڵا دیاریبکە", "باشە"); alert.ShowDialog();
                    return;
                }
                if (inBuyPrice.Text is null || inBuyPrice.Text is "")
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە نرخی کڕین دیاریبکە", "باشە"); alert.ShowDialog();
                    return;
                }
                if (inSellPrice.Text == null || inSellPrice.Text == "")
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە نرخی فرۆشتن دیاریبکە", "باشە");
                    alert.ShowDialog();
                    return;
                }
                DateTime temp;
                if (!DateTime.TryParse(inExpire.Text, out temp))
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە بەرواری بەسەرچوون دیاریبکە", "باشە");
                    alert.ShowDialog();
                    return;
                }
                #endregion
                Models.Store.Buy buys = new Models.Store.Buy();

                if (!_isAdd)
                {
                    query.UpdateAsync(buys, $"where BuyId={buysUp.FirstOrDefault().BuyId}");
                    this.Close();
                    return;
                }
                buys.BuyInvoiceId = int.Parse(BuyMainPage.lastBuyInvoiceId);
                buys.Barcode = inBarcode.Text;
                buys.Expire = inExpire.SelectedDate.Value;
                buys.SellPrice = int.Parse(inSellPrice.Text);
                buys.Quantity = int.Parse(inQuantity.Text);
                buys.ItemTypeId = ItemTypeId;
                buys.ItemId = ItemId;
                if (PacketWindow.lastPocketId == null || PacketWindow.lastPocketId == 0)
                {
                    buys.PocketId = 0;
                }
                else 
                {
                buys.PocketId = PacketWindow.lastPocketId;
                }
                buys.BuyPrice = int.Parse(inBuyPrice.Text);
                await query.InsertAsync(buys);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("کێشەیەک ڕویدا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }
        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnItemAddClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                ForPageWindow forPageWindow = new ForPageWindow("ItemSelect");
                forPageWindow.ShowDialog();
                ItemId = ItemPage.ItemId;
                ItemTypeId = ItemPage.TypeId;
                Barcode = ItemPage.Barcode;

                inBarcode.Text = ItemPage.Barcode;
                inType.Text = ItemPage.TypeName;
                inItem.Text = ItemPage.ItemName;
            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }
        }

        private void inBuyPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double userage;
                if (!double.TryParse(inBuyPrice.Text, out userage) && inBuyPrice.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inBuyPrice.Text.Length != 0)
                    {
                        inBuyPrice.Text = inBuyPrice.Text.Remove(inBuyPrice.Text.Length - 1, 1);
                    }
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }
        }

        private void inSellPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double useragess;
                if (!double.TryParse(inSellPrice.Text, out useragess) && inSellPrice.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inSellPrice.Text.Length != 0)
                    {
                        inSellPrice.Text = inSellPrice.Text.Remove(inSellPrice.Text.Length - 1, 1);
                    }
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }
        }

        private void inQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                int userages;
                if (!int.TryParse(inQuantity.Text, out userages) && inQuantity.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inQuantity.Text.Length != 0)
                    {
                        inQuantity.Text = inQuantity.Text.Remove(inQuantity.Text.Length - 1, 1);
                    }
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }
        }

        private void OnPacketClicked(object sender, RoutedEventArgs e)
        {
            PacketWindow p = new PacketWindow();
            p.ShowDialog();
            inBuyPrice.Text = PacketWindow.oneBuyPrice.ToString();
            inSellPrice.Text= PacketWindow.oneSellPrice.ToString();
            inQuantity.Text = PacketWindow.Quantity.ToString();
        }

        private void OnBarcodeKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    classConnection con = new classConnection();
                    
                    SqlCommand command = new SqlCommand(@$"select Item.ItemId,Item.ItemTypeId,Item.Barcode, Item.CommericalName, ItemType.TypeName from Item inner join ItemType 
                                                    on Item.ItemTypeId = ItemType.ItemTypeId where Item.Barcode={inBarcode.Text} ",classConnection.con);
                    classConnection.con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            ItemId = int.Parse(reader[0].ToString());
                            ItemTypeId = int.Parse(reader[1].ToString());
                            Barcode = reader[2].ToString();

                            inBarcode.Text = reader[2].ToString();
                            inItem.Text = reader[3].ToString();
                            inType.Text = reader[4].ToString();
                        }
                        else
                        {
                            MessageBox.Show("کاڵای بەردەستمان نیە لەم بارکۆدەیا");
                            inBarcode.Text = "";

                        }
                        classConnection.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("هیچ کاڵایەکی نەهێنا");
                        inBarcode.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("بەهەڵە ئەنجام درا تکایە دووبارە هەوڵ بەەەوە");
                    inBarcode.Text = "";

                }
            }


        }
    }
}
