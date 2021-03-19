using PharmacyHajiawa.Models;
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
using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;

namespace PharmacyHajiawa.Views.Items.item
{
    /// <summary>
    /// Interaction logic for ItemEditWindow.xaml
    /// </summary>
    public partial class ItemEditWindow : Window
    {
        public ItemEditWindow()
        {
            InitializeComponent();
        }
        bool _isAdd;
        int ItemId;
        int typeId;
        public ItemEditWindow( bool isAdd, int Id)
        {
            InitializeComponent();
            _isAdd = isAdd;
            ItemId = Id;
        }

        private void textboxPwoer_TextChanged(object sender, TextChangedEventArgs e)
        {
            int userage;
            if (!int.TryParse(textboxPwoer.Text, out userage) && textboxPwoer.Text != null)
            {
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                alert.ShowDialog();
                if (textboxPwoer.Text.Length != 0)
                {
                    textboxPwoer.Text = textboxPwoer.Text.Remove(textboxPwoer.Text.Length - 1, 1);

                }
                return;
            }
        }
        List<Item> items = new List<Item>();
        Query query = new Query();
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!_isAdd)
                {
                    items = null;
                    items = dotNETConnection.ConvertSqlToList<Models.Item>($"select * from Item where ItemId={ItemId}"); ;
                    textboxCommericalName.Text = items.FirstOrDefault().CommericalName;
                    textboxBarcode.Text = items.FirstOrDefault().Barcode;
                    textboxPwoer.Text = items.FirstOrDefault().Power.ToString();
                    textboxScienceName.Text = items.FirstOrDefault().ScienceName;
                    buttonDelete.Visibility = Visibility.Visible;
                }
                if (_isAdd)
                {
                    buttonDelete.Visibility = Visibility.Collapsed;
                }
            }
            catch 
            {
                MessageBox.Show("کێشەکەی ڕویدا، تکایە بەرنامەکە دابخەو دوبارە کردارەکە ئەنجام بدەوە");
            }
        }

        private async void OnDeleteClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                var itemName = from a in items
                               where a.ItemId == ItemId
                               select a.CommericalName;
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "دڵنیای لە ڕەشکردنەوەی " + " " + $"{itemName.First()}", "بەڵێ", "نەخێر");
                alert.ShowDialog();
                if (DisplayAlert.theResult == "نەخێر")
                {
                    return;
                }
                Query q = new Query();
                 await q.ExcuteAsync($"update Item set Status=1 where ItemId={items.FirstOrDefault().ItemId}");
                this.Close();
            }
            catch
            {
                MessageBox.Show("کێشەکەی ڕویدا، تکایە بەرنامەکە دابخەو دوبارە کردارەکە ئەنجام بدەوە");
            }
        }

        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                #region validation
                if (textboxCommericalName.Text is null || textboxCommericalName.Text.Equals(string.Empty) || textboxCommericalName.Text is "")
                {
                    DisplayAlert a = new DisplayAlert("ئاگاداری", "تکایە ناوی بازرگانی داخڵ بکە", "باشە");
                    a.ShowDialog();
                    return;
                }
                if (textboxBarcode.Text is null || textboxBarcode.Text.Equals(string.Empty) || textboxBarcode.Text is "")
                {
                    DisplayAlert a = new DisplayAlert("ئاگاداری", "تکایە بارکۆد داخڵ بکە", "باشە");
                    a.ShowDialog();
                    return;
                }
              
                if (textboxPwoer.Text is null || textboxPwoer.Text.Equals(string.Empty) || textboxPwoer.Text is "")
                {
                    DisplayAlert a = new DisplayAlert("ئاگاداری", "تکایە بڕی هێز داخڵ بکە", "باشە");
                    a.ShowDialog();
                    return;
                }
                if (textboxScienceName.Text is null || textboxScienceName.Text.Equals(string.Empty) || textboxScienceName.Text is "")
                {
                    DisplayAlert a = new DisplayAlert("ئاگاداری", "تکایە ناوی زانستی داخڵ بکە", "باشە");
                    a.ShowDialog();
                    return;
                }
                #endregion
                if (_isAdd)
                {
                    Item item = new Item
                    {
                        ItemTypeId = ItemId,
                        ScienceName = textboxScienceName.Text,
                        CommericalName = textboxCommericalName.Text,
                        Barcode = textboxBarcode.Text,
                        Power = int.Parse(textboxPwoer.Text),
                        Status=false
                    };
                    await query.InsertAsync(item);
                    DisplayAlert alert = new DisplayAlert("زانیاری", "بەسەرکەوتویی تۆمارکرا", "باشە");
                    alert.ShowDialog();
                    this.Close();
                }
                else
                {
                    Item item = new Item
                    {
                        ItemTypeId = (from a in items where a.ItemId == ItemId select a.ItemTypeId).FirstOrDefault(),
                        ScienceName = textboxScienceName.Text,
                        CommericalName = textboxCommericalName.Text,
                        Barcode = textboxBarcode.Text,
                        Power = int.Parse(textboxPwoer.Text),
                        Status=false
                    };
                    await query.UpdateAsync(item,$"where ItemId={ItemId}");
                    DisplayAlert alert = new DisplayAlert("زانیاری", "بەسەرکەوتویی تۆمارکرا", "باشە");
                    alert.ShowDialog();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("کێشەکەی ڕویدا، تکایە بەرنامەکە دابخەو دوبارە کردارەکە ئەنجام بدەوە");
            }


        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
