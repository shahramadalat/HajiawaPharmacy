using MaterialDesignThemes.Wpf;
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

namespace PharmacyHajiawa.Views.Message
{
    /// <summary>
    /// Interaction logic for DisplaySheet.xaml
    /// </summary>
    public partial class DisplaySheet : Window
    {
        public DisplaySheet()
        {
            InitializeComponent();
        }

        public DisplaySheet(List<string> list)
        {
            InitializeComponent();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    Card c = new Card();


                    Button b = new Button();
                    b.Content = item;
                    b.BorderThickness = new Thickness(0);
                    b.Foreground = new SolidColorBrush(Colors.Black);
                    b.Margin = new Thickness(0, 5, 0, 5);
                    b.Background = new SolidColorBrush(Colors.Transparent);
                    b.Click += new RoutedEventHandler(btnTarget);
                    stackButtons.Children.Add(b);
                }
            }
            else
            {
                DisplayAlert alert = new DisplayAlert("هەبونی کێشە", "هەبوونی کێشە لە زیادکردنی ئامانجەکاندا", "باشە");
                alert.ShowDialog();
            }



        }

        public static string theResult;
        private void btnTarget(object sender, RoutedEventArgs e)
        {

            var a = (sender as Button).Content;
            theResult = a.ToString();
            this.Close();

        }

        private void OnAddClicked(object sender, RoutedEventArgs e)
        {

        }

        private void onChosenButton(object sender, RoutedEventArgs e)
        {
            theResult = null;
            this.Close();
        }
    }
}
