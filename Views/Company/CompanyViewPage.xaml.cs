using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Message;
using PharmacyHajiawa.Views.Store.Buy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace PharmacyHajiawa.Views.Company
{
    /// <summary>
    /// Interaction logic for CompanyViewPage.xaml
    /// </summary>
    public partial class CompanyViewPage : Page
    {
        public CompanyViewPage()
        {
            InitializeComponent();
        }
        private bool _isBuy;
        public static int CompanyId;
        public static string CompanyName;
        public CompanyViewPage(bool isBuy)
        {
            InitializeComponent();
            _isBuy = isBuy;
        }


        List<Models.Company> companies = new List<Models.Company>();
        private async void GetItems(bool isDeleted)
        {
            //1 is deleted
            if (isDeleted)
            {
                companies = dotNETConnection.ConvertSqlToList<Models.Company>($"select * from Company where Status=1");
                mainDatagrid.ItemsSource = companies;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "ناوی کۆمپانیا";
                mainDatagrid.Columns[2].Header = "ژ.مۆبایل";
                mainDatagrid.Columns[3].Header = "ناونیشان";
                mainDatagrid.Columns[4].Visibility = Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
            else
            {
                companies = dotNETConnection.ConvertSqlToList<Models.Company>($"select * from Company where Status=0");
                mainDatagrid.ItemsSource = companies;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "ناوی کۆمپانیا";
                mainDatagrid.Columns[2].Header = "ژ.مۆبایل";
                mainDatagrid.Columns[3].Header = "ناونیشان";
                mainDatagrid.Columns[4].Visibility = Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
        }
        private void QueryInside(string theQuery)
        {
            Query query = new Query();
            query.ExcuteAsync(theQuery);
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {

            GetItems(false);
            Query query = new Query();
            await query.CreateIndexAsync("CompanyIndex", "Company", new string[] { "CompanyId", "Name" });

        }





        private void OnItemTextChanged(object sender, TextChangedEventArgs e)
        {

            var keyword = textboxSeatch.Text;
            var suggest = companies.Where(i => i.Name.Contains(keyword) || i.Phone.Contains(keyword) || i.Address.Contains(keyword));
            if ((keyword != null || keyword != string.Empty))
            {
                buttonRemoveSearchText.Visibility = Visibility.Visible;
                mainDatagrid.ItemsSource = suggest;
                if (mainDatagrid.Columns.Count > 1)
                {
                    mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                    mainDatagrid.Columns[1].Header = "ناوی کۆمپانیا";
                    mainDatagrid.Columns[2].Header = "ژ.مۆبایل";
                    mainDatagrid.Columns[3].Header = "ناونیشان";
                    mainDatagrid.Columns[4].Visibility = Visibility.Hidden;

                }
            }
            else
            {

                mainDatagrid.ItemsSource = companies;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "ناوی کۆمپانیا";
                mainDatagrid.Columns[2].Header = "ژ.مۆبایل";
                mainDatagrid.Columns[3].Header = "ناونیشان";
                mainDatagrid.Columns[4].Visibility = Visibility.Hidden;

            }



        }

        private void OnRemoveTextboxSearch(object sender, RoutedEventArgs e)
        {
            textboxSeatch.Text = null;
            buttonRemoveSearchText.Visibility = Visibility.Hidden;

        }

        private async void OnAddClicked(object sender, RoutedEventArgs e)
        {
            var person = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.Company;
            CompanyEditWindow it = new CompanyEditWindow(true, 1) { };
            it.ShowDialog();
            GetItems(false);
        }

        private async void mainDatagrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (_isBuy)
            {
                try
                {
                    var p = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.Company;
                    if (p is null)
                    {
                        return;
                    }
                    CompanyId = p.CompanyId;
                    CompanyName = p.Name;
                    foreach (var wndOtherWindow in Application.Current.Windows)
                    {
                        if (wndOtherWindow is ForPageWindow)
                        {
                            (wndOtherWindow as Window).Close();
                        }
                    }
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("کێشەیەک ڕویدا تکایە دووبارە هەوڵ بەرەوە");
                    throw;
                }
            }
            var person = mainDatagrid.SelectedItem as Models.Company;
            if (person is null)
            {
                return;
            }
            if (person.Status is true)
            {
                DisplaySheet sh = new DisplaySheet(new List<string> { "گەڕاندنەوە" });
                sh.ShowDialog();
                if (DisplaySheet.theResult is "گەڕاندنەوە")
                {
                    QueryInside($"update Company set Status=0 where CompanyId={person.CompanyId}");
                    GetItems(true);
                }
                return;
            }
            else
            {
                CompanyEditWindow it = new CompanyEditWindow(false, person.CompanyId) { };
                it.ShowDialog();
                GetItems(false);
            }

        }

        private void OnDeletedClicked(object sender, RoutedEventArgs e)
        {
            GetItems(true);
        }

        private void OnAvailableClicked(object sender, RoutedEventArgs e)
        {
            GetItems(false);

        }
    }
}
