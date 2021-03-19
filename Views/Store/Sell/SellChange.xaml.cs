using PharmacyHajiawa.Class;
using PharmacyHajiawa.Views.Message;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PharmacyHajiawa.Views.Store.Sell
{
    /// <summary>
    /// Interaction logic for SellChange.xaml
    /// </summary>
    public partial class SellChange : Window
    {
        private int _sellId;
        private double _sellPrice;
        public SellChange(int SellId,double SellPrice)
        {
            InitializeComponent();
            _sellId = SellId;
            _sellPrice=SellPrice;
        }
        Query query = new Query();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                await query.ExcuteAsync($"update Sells set SellPrice={textboxBarcode.Text} where RealBuyId={_sellId}");
                this.Close();
            }
            catch (Exception)
            {
                DisplayAlert alert = new DisplayAlert("ئاگاداری","هەڵەیەک ڕوی دا تکایە دووبارە هەوڵ بدەوە","باشە");
                alert.ShowDialog();
                this.Close();
            }

        }
        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textboxBarcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double userage;
                if (!double.TryParse(textboxBarcode.Text, out userage) && textboxBarcode.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (textboxBarcode.Text.Length != 0)
                    {
                        textboxBarcode.Text = textboxBarcode.Text.Remove(textboxBarcode.Text.Length - 1, 1);
                    }
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");

            }
        }
    }
}
