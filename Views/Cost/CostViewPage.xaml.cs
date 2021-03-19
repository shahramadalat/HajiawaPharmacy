using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PharmacyHajiawa.Views.Cost
{
    /// <summary>
    /// Interaction logic for CostViewPage.xaml
    /// </summary>
    public partial class CostViewPage : Page
    {
        public CostViewPage()
        {
            InitializeComponent();
        }

        List<Models.Cost> costs = new List<Models.Cost>();
        Query query = new Query();
        private async void GetItems(bool isDeleted)
        {
            //1 is deleted
            if (isDeleted)
            {
                costs= dotNETConnection.ConvertSqlToList<Models.Cost>($"select * from Cost where IsDeleted=1");
                mainDatagrid.ItemsSource = costs;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "جۆری تێچوو";
                mainDatagrid.Columns[2].Header = "بڕی تێچوو";
                mainDatagrid.Columns[3].Header = "بەروار";
                mainDatagrid.Columns[4].Header = "تێبینی";
                mainDatagrid.Columns[5].Visibility= Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
            else
            {
                costs = dotNETConnection.ConvertSqlToList<Models.Cost>($"select * from Cost where IsDeleted=0");
                mainDatagrid.ItemsSource = costs;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "جۆری تێچوو";
                mainDatagrid.Columns[2].Header = "بڕی تێچوو";
                mainDatagrid.Columns[3].Header = "بەروار";
                mainDatagrid.Columns[4].Header = "تێبینی";
                mainDatagrid.Columns[5].Visibility = Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetItems(false);
        }

        private void mainDatagrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
            var person = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.Cost;
            if (person is null)
            {
                return;
            }
            if (person.IsDeleted == true)
            {
                DisplaySheet displaySheet = new DisplaySheet(new List<string>() { "گەڕاندنەوە" });
                displaySheet.ShowDialog();
                if (DisplaySheet.theResult is "گەڕاندنەوە")
                {
                    query.ExcuteAsync($"update Cost set IsDeleted=0 where CostId={person.CostId}");

                    GetItems(true);
                }
                return;

            }
            CostEditWindow it = new CostEditWindow(false, person.CostId) { };
            it.ShowDialog();
            GetItems(false);
        }

        private void OnAddClicked(object sender, RoutedEventArgs e)
        {
            CostEditWindow window = new CostEditWindow(true,1);
            window.ShowDialog();
            GetItems(false);
        }

        private void OnAvailableClicked(object sender, RoutedEventArgs e)
        {
            GetItems(false);
        }

        private void OnDeletedClicked(object sender, RoutedEventArgs e)
        {
            GetItems(true);
        }

        private void OnItemTextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = textboxSeatch.Text;
            var suggest = costs.Where(i => i.CostName.Contains(keyword) || i.CostAmount.ToString().Contains(keyword) || i.CostDate.ToString().Contains(keyword));
            if ((keyword != null || keyword != string.Empty))
            {
                buttonRemoveSearchText.Visibility = Visibility.Visible;
                mainDatagrid.ItemsSource = suggest;
                if (mainDatagrid.Columns.Count > 1)
                {
                    mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                    mainDatagrid.Columns[1].Header = "جۆری تێچوو";
                    mainDatagrid.Columns[2].Header = "بڕی تێچوو";
                    mainDatagrid.Columns[3].Header = "بەروار";
                    mainDatagrid.Columns[4].Header = "تێبینی";
                    mainDatagrid.Columns[5].Visibility = Visibility.Hidden;

                }
            }
            else
            {

                mainDatagrid.ItemsSource = costs;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "جۆری تێچوو";
                mainDatagrid.Columns[2].Header = "بڕی تێچوو";
                mainDatagrid.Columns[3].Header = "بەروار";
                mainDatagrid.Columns[4].Header = "تێبینی";
                mainDatagrid.Columns[5].Visibility = Visibility.Hidden;

            }
        }

        private void OnRemoveTextboxSearch(object sender, RoutedEventArgs e)
        {
            textboxSeatch.Text = null;
            buttonRemoveSearchText.Visibility = Visibility.Collapsed;
        }
    }
}
