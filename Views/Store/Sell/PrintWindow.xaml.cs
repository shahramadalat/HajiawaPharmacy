using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Message;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PharmacyHajiawa.Views.Store.Sell
{
    public partial class PrintWindow : Window
    {
        public static bool isSuccess;
        public PrintWindow()
        {
            InitializeComponent();
        }
        private int _sellInvoiceId;
        double _total, _discount;
        public PrintWindow(int sellInvoice, double total, double discount)
        {
            InitializeComponent();
            datePicker.SelectedDate = DateTime.Now;
            timePicker.SelectedTime = DateTime.Now;
            _sellInvoiceId = sellInvoice;
            _total = total;
            _discount = discount;
        }
        Models.View.ViewSell viewSell = new Models.View.ViewSell();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainDatagrid.ItemsSource = dotNETConnection.ConvertSqlToList<Models.View.ViewSell>("select TypeName,CommericalName,SellPrice,Quantity,Total from ViewSell");
            mainDatagrid.Columns[0].Visibility = Visibility.Collapsed;
            mainDatagrid.Columns[1].Visibility = Visibility.Collapsed;
            mainDatagrid.Columns[2].Visibility = Visibility.Collapsed;
            mainDatagrid.Columns[5].Visibility = Visibility.Collapsed;
            mainDatagrid.Columns[3].Width = 100;
            mainDatagrid.Columns[4].Width = 100;
            mainDatagrid.Columns[3].Header = "جۆر";
            mainDatagrid.Columns[4].Header = "ناو";
            mainDatagrid.Columns[6].Header = "نرخ";
            mainDatagrid.Columns[7].Header = "دانە";
            mainDatagrid.Columns[8].Header = "سەرجەم";
            inTotal.Content = _total;
            inDiscount.Content = _discount;
            lblInvoiceNumber.Content = _sellInvoiceId;

        }
        private void OnPrintClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                PrintDialog print = new PrintDialog();
                if (print.ShowDialog() == true)
                {
                    print.PrintVisual(gridPrint, "فرۆشتن");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "دوبارە هەوڵ بەرەوە، ئەگەر چارەسەر نەبوو بەزوترین کات پەیوەندیمان پێوە بکە", "باشە");
                alert.ShowDialog();
                MessageBox.Show(ex.Message);
            }
        }

        private void OnIgnoreClicked(object sender, RoutedEventArgs e)
        {
            isSuccess = false;
            MessageBox.Show("پرنت نەکرا");
            this.Close();
        }

        private void OnBackClicked(object sender, RoutedEventArgs e)
        {
            isSuccess = true;
            MessageBox.Show("پرنت کرا");
            this.Close();
        }
    }
}
