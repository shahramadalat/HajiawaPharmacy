using PharmacyHajiawa.Views.Company;
using PharmacyHajiawa.Views.Items;
using System.Windows;

namespace PharmacyHajiawa.Views.Store.Buy
{
    /// <summary>
    /// Interaction logic for ForPageWindow.xaml
    /// </summary>
    /// 
    public partial class ForPageWindow : Window
    {
        private string _reason;
        public static int ItemId;
        public static int TypeId;
        public ForPageWindow(string reson)
        {
            InitializeComponent();
            _reason = reson;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_reason is "CompanySelect")
            {
                CompanyViewPage companyViewPage = new CompanyViewPage(true);
                mainFrame.Navigate(companyViewPage);
            }
            else if (_reason is "ItemSelect")
            {
                ItemTypePage itemTypePage = new ItemTypePage(true);
                mainFrame.Navigate(itemTypePage);
            }
            else if(_reason is "ForSell")
            {
                StoreViewPage itemTypePage = new StoreViewPage(true);
                this.WindowState = WindowState.Maximized;
                mainFrame.Navigate(itemTypePage);
            }


        }

        private void OnBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
