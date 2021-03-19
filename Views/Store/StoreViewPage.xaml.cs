using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Message;
using PharmacyHajiawa.Views.Store.Buy;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace PharmacyHajiawa.Views.Store
{
    /// <summary>
    /// Interaction logic for StoreViewPage.xaml
    /// </summary>
    public partial class StoreViewPage : Page
    {
        public StoreViewPage()
        {
            InitializeComponent();
        }
        public static int RealBuyId;
        public static double BuyPrice;
        public static double SellPrice;
        bool _isSell;
        public StoreViewPage(bool IsSell)
        {
            InitializeComponent();
            _isSell=IsSell;
        }

        List<Models.View.ViewStore> viewStores = new List<Models.View.ViewStore>();
        private async void GetItems(bool isDeleted)
        {
            if (isDeleted)
            {
                mainDatagrid.ItemsSource = viewStores = dotNETConnection.ConvertSqlToList<Models.View.ViewStore>("select * from ViewStore where isDeleted=1");
                orderRows();
                mainDatagrid.UnselectAllCells();
            }
            else
            {
                mainDatagrid.ItemsSource = viewStores = dotNETConnection.ConvertSqlToList<Models.View.ViewStore>("select * from ViewStore where isDeleted=0 and Quantity!=0");
                orderRows();
                mainDatagrid.UnselectAllCells();
            }
        }
        void orderRows()
        {
            mainDatagrid.Columns[2].Visibility = Visibility.Hidden;
            mainDatagrid.Columns[0].Visibility = Visibility.Hidden;

            mainDatagrid.Columns[1].Header = "کۆدی پسوڵەی کڕین";
            mainDatagrid.Columns[3].Header = "بارکۆد";
            mainDatagrid.Columns[4].Header = "ناوی کاڵا";
            mainDatagrid.Columns[5].Header = "جۆری کاڵا";
            mainDatagrid.Columns[6].Header = "بەرواری کڕین";
            mainDatagrid.Columns[7].Header = "بەسەرچوون";
            mainDatagrid.Columns[8].Header = "نرخی کڕین";
            mainDatagrid.Columns[9].Header = "نرخی فرۆشتن";
            mainDatagrid.Columns[10].Visibility = Visibility.Hidden;
            mainDatagrid.Columns[11].Header = "دانە";
           


            mainDatagrid.Columns[7].Width = 100;
            mainDatagrid.Columns[8].Width = 100;
            mainDatagrid.Columns[9].Width = 100;
            mainDatagrid.Columns[11].Width = 100;

        }
        private void QueryInside(string theQuery)
        {
            Query query = new Query();
            query.ExcuteAsync(theQuery);
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetItems(false);
        }





        private void OnItemTextChanged(object sender, TextChangedEventArgs e)
        {

            var keyword = textboxSeatch.Text;
            var suggest = viewStores.Where(i =>  i.CommericalName.Contains(keyword) || i.TypeName.Contains(keyword)|| i.BuyInvoiceId.ToString().Contains(keyword) ||i.BuyDate.ToString().Contains(keyword) || i.Barcode.ToString().Contains(keyword));
            if ((keyword != null || keyword != string.Empty))
            {
                buttonRemoveSearchText.Visibility = Visibility.Visible;
                mainDatagrid.ItemsSource = suggest;
                if (mainDatagrid.Columns.Count > 1)
                {
                    orderRows();
                }
            }
            else
            {
                mainDatagrid.ItemsSource = viewStores;
                orderRows();
                buttonRemoveSearchText.Visibility = Visibility.Visible;
            }
        }

        private void OnRemoveTextboxSearch(object sender, RoutedEventArgs e)
        {
            textboxSeatch.Text = null;
            buttonRemoveSearchText.Visibility = Visibility.Hidden;

        }

        private async void OnAddClicked(object sender, RoutedEventArgs e)
        {
            //var person = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.Company;
            //CompanyEditWindow it = new CompanyEditWindow(true, 1) { };
            //it.ShowDialog();
            //GetItems(false);
        }



        private void mainDatagrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            if (_isSell)
            {

                var persons = mainDatagrid.SelectedItem as Models.View.ViewStore;
                if (persons is null)
                {
                    return;
                }
                RealBuyId = persons.BuyId;
                BuyPrice = persons.BuyPrice;
                SellPrice = persons.SellPrice;
                foreach (var wndOtherWindow in Application.Current.Windows)
                {
                    if (wndOtherWindow is ForPageWindow)
                    {
                        (wndOtherWindow as Window).Close();
                    }
                }
                return;
            }
           
        }
        Query query = new Query();

        private async void mainDatagrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var person = mainDatagrid.SelectedItem as Models.View.ViewStore;
            if (person is null)
            {
                MessageBox.Show("تکایە سەرەتا کلیک لەسەر ئەو شتە بکە کە دەتەوێ");
                return;
            }
            if (person.BuyId != 0 || person.BuyId != null)
            {
                DisplaySheet sh = new DisplaySheet(new List<string> { "ڕەشکردنەوە + گەڕاندنەوە","دەستکاریکردن" });
                sh.ShowDialog();
                if (DisplaySheet.theResult is "ڕەشکردنەوە + گەڕاندنەوە")
                {
                   string isdelet = await query.GetOneNoParameter($"select isDeleted from RealBuy where BuyId={person.BuyId}");
                    if (isdelet == "False")
                    {
                        await query.ExcuteAsync($"update RealBuy set isDeleted=1 where BuyId={person.BuyId}");
                        GetItems(false);
                    }
                    else if (isdelet == "True")
                    {
                        await query.ExcuteAsync($"update RealBuy set isDeleted=0 where BuyId={person.BuyId}");
                        GetItems(true);
                    }
                }
                else if( DisplaySheet.theResult == "دەستکاریکردن" )
                {

                }
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

        private void OnAddQuantityClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var person = mainDatagrid.SelectedItem as Models.View.ViewSell;
                MessageBox.Show(person.RealBuyId.ToString());
            }
        }

        private void OnMinusQuantityClicked(object sender, RoutedEventArgs e)
        {

        }


        private void onfinished(object sender, RoutedEventArgs e)
        {
            mainDatagrid.ItemsSource = viewStores = dotNETConnection.ConvertSqlToList<Models.View.ViewStore>("select * from ViewStore where isDeleted=0 and Quantity=0");
            orderRows();
            mainDatagrid.UnselectAllCells();
        }
    }
}
