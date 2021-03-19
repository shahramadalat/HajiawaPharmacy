using PharmacyHajiawa.Views.Company;
using PharmacyHajiawa.Views.Cost;
using PharmacyHajiawa.Views.Items;
using PharmacyHajiawa.Views.Report;
using PharmacyHajiawa.Views.Security;
using PharmacyHajiawa.Views.Store;
using PharmacyHajiawa.Views.Store.Buy;
using PharmacyHajiawa.Views.Store.Sell;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace PharmacyHajiawa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            #region Creating KurdShopData Folder
            var FolderDir = System.IO.Path.Combine(documentPath, "PharmacyData");
            if (!Directory.Exists(FolderDir))
            {
                Directory.CreateDirectory(FolderDir);
            }
            #endregion

            //we use this code for creating the table of Item
            //App.path = System.IO.Path.Combine(FolderDir, "PharmacyDB.db3");

        }
        //bool isItem = true;

        private void button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void OnExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        int maximizecheck = 0;
        private void OnMaximinzeClicked(object sender, RoutedEventArgs e)
        {
            if (maximizecheck == 0)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
                maximizecheck = 1;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
                maximizecheck = 0;
            }

        }

        private void OnMinimizeClicked(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        //ItemViewPage itemView = new ItemViewPage();
        private void OnItemClicked(object sender, RoutedEventArgs e)
        {

            ItemTypePage itemView = new ItemTypePage();
            framePages.Navigate(itemView);
            buttonItem.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonItem.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));


            buttonCosts.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonCosts.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuy.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonSell.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonOrder.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonReport.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonReport.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
          
            buttonBackup.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBackup.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuyInvoice.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void OnCostsClicked(object sender, RoutedEventArgs e)
        {
            CostViewPage itemView = new CostViewPage();
            framePages.Navigate(itemView);

            buttonCosts.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonCosts.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));


            buttonItem.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonItem.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuy.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonSell.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonOrder.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonReport.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonReport.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
           
            buttonBackup.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBackup.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuyInvoice.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void OnSellClicked(object sender, RoutedEventArgs e)
        {
            MainSellPage ov = new MainSellPage();
            framePages.Navigate(ov);


            buttonSell.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));

            buttonCosts.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonCosts.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonItem.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonItem.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuy.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonOrder.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonReport.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonReport.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
          
            buttonBackup.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBackup.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuyInvoice.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void OnBuyClicked(object sender, RoutedEventArgs e)
        {
            CompanyViewPage itemView = new CompanyViewPage();
            framePages.Navigate(itemView);
            buttonBuy.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));


            buttonItem.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonItem.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonCosts.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonCosts.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonSell.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonOrder.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonReport.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonReport.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
           
            buttonBackup.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBackup.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuyInvoice.Foreground = new SolidColorBrush(Colors.WhiteSmoke);

        }
        private void OnOrderClicked(object sender, RoutedEventArgs e)
        {
            StoreViewPage itemView = new StoreViewPage();
            framePages.Navigate(itemView);
            buttonOrder.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));


            buttonItem.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonItem.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonCosts.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonCosts.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonSell.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuy.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonReport.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonReport.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
          
            buttonBackup.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBackup.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuyInvoice.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void OnReportClicked(object sender, RoutedEventArgs e)
        {
            ReportMainPage itemView = new ReportMainPage();
            framePages.Navigate(itemView);
            buttonReport.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonReport.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));

            buttonItem.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonItem.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonCosts.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonCosts.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonSell.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuy.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonOrder.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
          
            buttonBackup.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBackup.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuyInvoice.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
        }

    

        private void OnBackupClicked(object sender, RoutedEventArgs e)
        {
            SecurityMainPage security = new SecurityMainPage();
            framePages.Navigate(security);
            buttonBackup.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBackup.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));



            buttonReport.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonReport.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonItem.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonItem.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonCosts.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonCosts.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonSell.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuy.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonOrder.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuyInvoice.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void OnBuyInvoiceClicked(object sender, RoutedEventArgs e)
        {
            BuyMainPage b = new BuyMainPage();
            framePages.Navigate(b);

            buttonBuyInvoice.Background = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuyInvoice.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            

            buttonBackup.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBackup.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonReport.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonReport.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonItem.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonItem.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonCosts.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonCosts.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonSell.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonSell.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonBuy.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonBuy.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
            buttonOrder.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 120, 215));
            buttonOrder.Foreground = new SolidColorBrush(Colors.WhiteSmoke);
         
        }

        //int mouseX = 0, mouseY = 0;
        //bool mouseDown;

        private void Grid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            //FirstPage ov = new FirstPage();
            //framePages.Navigate(ov);
        }



        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

       
    }
}
