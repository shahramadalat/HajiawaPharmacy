using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PharmacyHajiawa.Views.Store.Stores
{
    /// <summary>
    /// Interaction logic for StoreWindow.xaml
    /// </summary>
    public partial class StoreWindow : Window
    {
        private int _buyId;
        public StoreWindow(int BuyId)
        {
            InitializeComponent();
            _buyId = BuyId;
        }

        private void OnItemAddClicked(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_buyId == null || _buyId is 0)
            {
                MessageBox.Show("error no Buy Id");
                this.Close();
            }



        }

        private void OnPacketClicked(object sender, RoutedEventArgs e)
        {

        }

        private void onCompanyClicked(object sender, RoutedEventArgs e)
        {

        }

        private void inBuyPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void inSellPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void inQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnBarcodeKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void OnCheckClicked(object sender, RoutedEventArgs e)
        {

        }

        private void OnDeleteClicked(object sender, RoutedEventArgs e)
        {

        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
