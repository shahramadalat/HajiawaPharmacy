using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Message;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PharmacyHajiawa.Views.Items
{
    /// <summary>
    /// Interaction logic for ItemTypeEditWindow.xaml
    /// </summary>
    public partial class ItemTypeEditWindow : Window
    {
        bool _isAdd;
        int _id;
        List<Models.ItemType> items = new List<Models.ItemType>();
        public ItemTypeEditWindow(bool isAdd, int id)
        {
            InitializeComponent();
            this._isAdd = isAdd;
            this._id = id;
        }


        Query query1 = new Query();
        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            if (textboxItemName.Text == null || textboxItemName.Text == string.Empty)
            {
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە ناوی جۆری کاڵا داخڵ بکە", "باشە");
                alert.ShowDialog();
                textboxItemName.Focus();
                return;
            }

            if (_isAdd)
            {
                buttonDelete.Visibility = Visibility.Collapsed;
                Models.ItemType item = new Models.ItemType
                {
                    TypeName = textboxItemName.Text,
                    Status = false
                };
                await query1.InsertAsync(item);
                DisplayAlert alert = new DisplayAlert("زانیاری", "بەسەرکەوتویی تۆمارکرا", "باشە");
                alert.ShowDialog();
                this.Close();
            }
            else if (!_isAdd)
            {

                Models.ItemType item = new Models.ItemType();
                item.TypeName = textboxItemName.Text;
                item.Status = false;
                await query1.UpdateAsync(item, $"where ItemTypeId={_id}");
                DisplayAlert alert = new DisplayAlert("زانیاری", "بەسەرکەوتویی گۆڕدرا", "باشە");
                alert.ShowDialog();
                this.Close();

            }
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!_isAdd)
            {
                items = null;
                items = dotNETConnection.ConvertSqlToList<Models.ItemType>($"select * from ItemType where ItemTypeId={_id}");
                var itemName = from a in items
                               where a.ItemTypeId == _id
                               select a.TypeName;
                textboxItemName.Text = itemName.First();
                buttonDelete.Visibility = Visibility.Visible;
            }
            if (_isAdd)
            {
                buttonDelete.Visibility = Visibility.Collapsed;
            }
        }

        private async void OnDeleteClicked(object sender, RoutedEventArgs e)
        {
            var itemName = from a in items
                           where a.ItemTypeId == _id
                           select a.TypeName;
            DisplayAlert alert = new DisplayAlert("ئاگاداری", "دڵنیای لە ڕەشکردنەوەی " + " " + $"{itemName.First()}", "بەڵێ", "نەخێر");
            alert.ShowDialog();
            if (DisplayAlert.theResult == "نەخێر")
            {
                return;
            }
            await query1.ExcuteAsync($"update ItemType set status=1 where ItemTypeId={_id}");
            this.Close();
        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
