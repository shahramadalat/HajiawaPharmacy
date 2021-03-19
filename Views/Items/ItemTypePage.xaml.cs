using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Items.item;
using PharmacyHajiawa.Views.Message;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace PharmacyHajiawa.Views.Items
{
    /// <summary>
    /// Interaction logic for ItemTypePage.xaml
    /// </summary>
    public partial class ItemTypePage : Page
    {
        List<PharmacyHajiawa.Models.ItemType> itemType = new List<Models.ItemType>();

        public ItemTypePage()
        {
            InitializeComponent();
        }
        bool _isbuy;
        public ItemTypePage(bool isBuy)
        {
            InitializeComponent();
            _isbuy = isBuy;
        }
     
        Query query1 = new Query();

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetItems(false);
            await query1.CreateIndexAsync("ItemTypeIndexForTypeName", "ItemType", new string[] { "ItemTypeId", "TypeName" });

        }

        private async void GetItems(bool isDeleted)
        {
            //1 is deleted
            if (isDeleted)
            {
                dotNETConnection dot = new dotNETConnection();
                itemType = dotNETConnection.ConvertSqlToList<Models.ItemType>("select * from ItemType where Status=1");
                mainDatagrid.ItemsSource = itemType;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "جۆری کاڵا";
                mainDatagrid.Columns[2].Visibility = Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
            else
            {
                itemType = dotNETConnection.ConvertSqlToList<Models.ItemType>("select * from ItemType where Status=0");
                mainDatagrid.ItemsSource = itemType;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "جۆری کاڵا";
                mainDatagrid.Columns[2].Visibility = Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
        }
        private void QueryInside(string theQuery)
        {
            Query query = new Query();
            query.ExcuteAsync(theQuery);
        }

        private void OnItemTextChanged(object sender, TextChangedEventArgs e)
        {

            var keyword = textboxSeatch.Text;
            var suggest = itemType.Where(i => i.TypeName.Contains(keyword));
            if ((keyword != null || keyword != string.Empty))
            {
                buttonRemoveSearchText.Visibility = Visibility.Visible;
                mainDatagrid.ItemsSource = suggest;
                if (mainDatagrid.Columns.Count > 1)
                {
                    mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                    mainDatagrid.Columns[1].Header = "جۆری کاڵا";
                    mainDatagrid.Columns[2].Visibility = Visibility.Hidden;

                }
            }
            else
            {

                mainDatagrid.ItemsSource = itemType;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Header = "جۆری کاڵا";
                mainDatagrid.Columns[2].Visibility = Visibility.Hidden;

            }



        }

        private void OnRemoveTextboxSearch(object sender, RoutedEventArgs e)
        {
            textboxSeatch.Text = null;
            buttonRemoveSearchText.Visibility = Visibility.Hidden;

        }

        private async void OnAddClicked(object sender, RoutedEventArgs e)
        {
            var person = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.ItemType;
            ItemTypeEditWindow it = new ItemTypeEditWindow(true, 1) { };
            it.ShowDialog();
            GetItems(false);
        }

        private async void mainDatagrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
          
            if (_isbuy)
            {
                var p = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.ItemType;
                if (p is null)
                {
                    return;
                }
                ItemPage it = new ItemPage(p.ItemTypeId, true);

                this.NavigationService.Navigate(it);
                return;
            }
            var person = mainDatagrid.SelectedItem as Models.ItemType;
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
                    QueryInside($"update ItemType set Status=0 where ItemTypeId={person.ItemTypeId}");
                    GetItems(true);
                }
                return;
            }


            DisplaySheet sheet = new DisplaySheet(new List<string> { "دەستکاریکردن", "جۆرەکانی" });
            sheet.ShowDialog();
            if (DisplaySheet.theResult != null)
            {
                if (DisplaySheet.theResult is "دەستکاریکردن")
                {
                    if (person is null)
                    {
                        return;
                    }
                    ItemTypeEditWindow it = new ItemTypeEditWindow(false, person.ItemTypeId) { };
                    it.ShowDialog();
                    GetItems(false);
                }

                if (DisplaySheet.theResult is "جۆرەکانی")
                {
                    if (person is null)
                    {
                        return;
                    }
                    ItemPage it = new ItemPage(person.ItemTypeId);

                    this.NavigationService.Navigate(it);
                    GetItems(false);
                }

            }
            else
            {
                mainDatagrid.UnselectAllCells();
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
