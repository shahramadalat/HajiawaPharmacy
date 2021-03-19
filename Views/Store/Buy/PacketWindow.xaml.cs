using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PharmacyHajiawa.Views.Store.Buy
{
    /// <summary>
    /// Interaction logic for PacketWindow.xaml
    /// </summary>
    public partial class PacketWindow : Window
    {
        public static int Quantity, oneBuyPrice,oneSellPrice,lastPocketId;
        private int RealBuyId;
        public static int Q;
        public static bool isSuccess;
        bool isSell;
        public PacketWindow()
        {
            InitializeComponent();
            isSell = false;
        }
        public PacketWindow(int BId)
        {
            InitializeComponent();
            RealBuyId = BId;
            isSell = true;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (isSell)
            {
                string PocketId = await query.GetOneNoParameter($"select PocketId from RealBuy where BuyId={RealBuyId}");
                if (PocketId is "0")
                {
                    MessageBox.Show("ئەم کاڵایە پاکەتت بۆ دیاری نەکردوە");
                    this.Close();
                    return;
                }
                List<Models.Store.Pocket> pockets = dotNETConnection.ConvertSqlToList<Models.Store.Pocket>($"select * from Pocket where PocketId={PocketId}");
               
                inPacket.Text = "";
                inPacketBuyPrice.Text = pockets.FirstOrDefault().BuyPrice.ToString();
                inPacketSellPrice.Text = pockets.FirstOrDefault().SellPrice.ToString();
                inPacketQuantity.Text = pockets.FirstOrDefault().quantity.ToString();
            }
        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            if (isSell)
            {
                isSuccess = false;
            }
            this.Close();
        }
        Query query = new Query();
        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            if (isSell)
            {
                if (inPacket.Text is null || inPacket.Text is "")
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "ژمارەی پاکەت دیاری بکە بۆ فرۆشتن", "باشە");
                    alert.ShowDialog();
                    inPacket.Focus();
                }
                Q = int.Parse(inPacket.Text)*int.Parse(inPacketQuantity.Text);
                isSuccess = true;
            }
            Quantity = int.Parse(inPacketQuantity.Text)*int.Parse(inPacket.Text);
            oneBuyPrice = int.Parse(inPacketBuyPrice.Text)/int.Parse(inPacketQuantity.Text);
            oneSellPrice = int.Parse(inPacketSellPrice.Text) / int.Parse(inPacketQuantity.Text);
            await query.ExcuteAsync($"insert into Pocket values({inPacket.Text},{inPacketBuyPrice.Text},{inPacketSellPrice.Text},{inPacketQuantity.Text})");
            lastPocketId = int.Parse(await query.GetOneNoParameter("SELECT MAX(PocketId) FROM Pocket"));
            this.Close();
        }

        private void inPacket_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int userage;
                if (!int.TryParse(inPacket.Text, out userage) && inPacket.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inPacket.Text.Length != 0)
                    {
                        inPacket.Text = inPacket.Text.Remove(inPacket.Text.Length - 1, 1);
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

        private void inPacketPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int userage;
                if (!int.TryParse(inPacketBuyPrice.Text, out userage) && inPacketBuyPrice.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inPacketBuyPrice.Text.Length != 0)
                    {
                        inPacketBuyPrice.Text = inPacketBuyPrice.Text.Remove(inPacketBuyPrice.Text.Length - 1, 1);
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

        private void inSellPacketPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int userage;
                if (!int.TryParse(inPacketSellPrice.Text, out userage) && inPacketSellPrice.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inPacketSellPrice.Text.Length != 0)
                    {
                        inPacketSellPrice.Text = inPacketSellPrice.Text.Remove(inPacketSellPrice.Text.Length - 1, 1);
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

        private void inPacketQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int userage;
                if (!int.TryParse(inPacketQuantity.Text, out userage) && inPacketQuantity.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (inPacketQuantity.Text.Length != 0)
                    {
                        inPacketQuantity.Text = inPacketQuantity.Text.Remove(inPacketQuantity.Text.Length - 1, 1);
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
    }
}
