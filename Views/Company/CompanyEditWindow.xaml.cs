using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Message;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PharmacyHajiawa.Views.Company
{
    /// <summary>
    /// Interaction logic for CompanyEditWindow.xaml
    /// </summary>
    public partial class CompanyEditWindow : Window
    {
        bool _isAdd;
        int _id;
        List<Models.Company> items = new List<Models.Company>();
        Query query1 = new Query();
        public CompanyEditWindow(bool isAdd, int id)
        {
            InitializeComponent();
            this._isAdd = isAdd;
            this._id = id;
        }

        private void QueryInside(string theQuery)
        {
            Query query = new Query();
            query.ExcuteAsync(theQuery);
        }



        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == null || txtName.Text == string.Empty)
            {
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە ناوی کۆمپانیا داخڵ بکە", "باشە");
                alert.ShowDialog();
                txtName.Focus();
                return;
            }

            if (_isAdd)
            {
                buttonDelete.Visibility = Visibility.Collapsed;
                Models.Company item = new Models.Company
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    Status = false
                };
                await query1.InsertAsync(item);
                DisplayAlert alert = new DisplayAlert("زانیاری", "بەسەرکەوتویی تۆمارکرا", "باشە");
                alert.ShowDialog();
                this.Close();
            }
            else if (!_isAdd)
            {

                Models.Company item = new Models.Company();
                item.Address = txtAddress.Text;
                item.Name = txtName.Text;
                item.Phone = txtPhone.Text;
                item.Status = false;
                //await App.companyDatabase.SaveNoteAsync(item);
                await query1.UpdateAsync(item, $"where CompanyId={_id}");
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
                items = dotNETConnection.ConvertSqlToList<Models.Company>($"select * from Company where CompanyId={_id}");
                txtAddress.Text = items.FirstOrDefault().Address;
                txtName.Text = items.FirstOrDefault().Name;
                txtPhone.Text = items.FirstOrDefault().Phone;
                buttonDelete.Visibility = Visibility.Visible;
            }
            if (_isAdd)
            {
                buttonDelete.Visibility = Visibility.Collapsed;
            }
        }

        private async void OnDeleteClicked(object sender, RoutedEventArgs e)
        {
            DisplayAlert alert = new DisplayAlert("ئاگاداری", "دڵنیای لە ڕەشکردنەوەی " + " " + $"{items.FirstOrDefault().Name}", "بەڵێ", "نەخێر");
            alert.ShowDialog();
            if (DisplayAlert.theResult == "نەخێر")
            {
                return;
            }
            QueryInside($"update Company set status=1 where CompanyId={_id}");
            this.Close();
        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
