using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
using PharmacyHajiawa.Views.Message;
using PharmacyHajiawa.Views.Store.Buy;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PharmacyHajiawa.Views.Items.item
{
    /// <summary>
    /// Interaction logic for ItemPage.xaml
    /// </summary>
    public partial class ItemPage : Page
    {

        public ItemPage()
        {
            InitializeComponent();
        }


        public static int ItemId;
        public static int TypeId;
        public static string Barcode;
        public static string ItemName;
        public static string TypeName;

        int _id;
        bool _isBuy;
        List<Models.Item> items = new List<Models.Item>();
        Query query1 = new Query();
        public ItemPage(int id)
        {
            InitializeComponent();
            _id = id;
            btnBack.Visibility = Visibility.Visible;

        }

        public ItemPage(int itemID, bool isBuy)
        {
            InitializeComponent();
            _id = itemID;
            _isBuy = isBuy;
            btnBack.Visibility = Visibility.Visible;
        }
      


        private async void GetItems(bool isDeleted)
        {
            //1 is deleted
            if (isDeleted)
            {
                items = dotNETConnection.ConvertSqlToList<Models.Item>($"select * from Item where ItemTypeId={_id} and Status=1 order by ItemTypeId desc");
                mainDatagrid.ItemsSource = items;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[2].Header = "بارکۆد";
                mainDatagrid.Columns[3].Header = "ناوی زانستی";
                mainDatagrid.Columns[4].Header = "ناوی بازرگانی";
                mainDatagrid.Columns[5].Header = "هیز";
                mainDatagrid.Columns[6].Visibility = Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
            else
            {
                items = dotNETConnection.ConvertSqlToList<Models.Item>($"select * from Item where ItemTypeId={_id} and Status=0");
                mainDatagrid.ItemsSource = items;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[2].Header = "بارکۆد";
                mainDatagrid.Columns[3].Header = "ناوی زانستی";
                mainDatagrid.Columns[4].Header = "ناوی بازرگانی";
                mainDatagrid.Columns[5].Header = "هیز";
                mainDatagrid.Columns[6].Visibility = Visibility.Hidden;
                mainDatagrid.UnselectAllCells();
            }
        }
        private async void QueryInside(string theQuery)
        {
            Query query = new Query();
            await query.ExcuteAsync(theQuery);
        }

        List<Models.ItemType> itemTypes = new List<Models.ItemType>();
        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //itemTypes = await App.itemTypeDatabase.GetNoteAsync(_id);
            Query query = new Query();
            query.CreateIndexAsync("ItemIndex", "Item", new string[] { "ItemId", "Barcode", "ScienceName", "PublicName", "Power" });
            query.CreateIndexAsync("ItemIndexWithoutItemId", "Item", new string[] { "Barcode", "ScienceName", "PublicName", "Power" });

            foreach (var i in itemTypes)
            {
                textblockItemName.Text = i.TypeName;
            }
            GetItems(false);

        }

        private async void OnAddClicked(object sender, RoutedEventArgs e)
        {
            ItemEditWindow it = new ItemEditWindow(true, _id);
            it.ShowDialog();
            GetItems(false);
        }

        private void OnItemTextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = textboxSeatch.Text;
            var suggest = items.Where(i => i.Barcode.Contains(keyword)  || i.ScienceName.Contains(keyword) || i.CommericalName.Contains(keyword));
            if ((keyword != null || keyword != string.Empty))
            {
                buttonRemoveSearchText.Visibility = Visibility.Visible;
                mainDatagrid.ItemsSource = suggest;
                if (mainDatagrid.Columns.Count > 1)
                {
                    mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                    mainDatagrid.Columns[1].Visibility = Visibility.Hidden;
                    mainDatagrid.Columns[2].Header = "بارکۆد";
                    mainDatagrid.Columns[3].Header = "ناوی زانستی";
                    mainDatagrid.Columns[4].Header = "ناوی بازرگانی";
                    mainDatagrid.Columns[5].Header = "هیز";
                    mainDatagrid.Columns[6].Visibility = Visibility.Hidden;
                }
            }
            else
            {
                mainDatagrid.ItemsSource = items;
                mainDatagrid.Columns[0].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[1].Visibility = Visibility.Hidden;
                mainDatagrid.Columns[2].Header = "بارکۆد";
                mainDatagrid.Columns[3].Header = "ناوی زانستی";
                mainDatagrid.Columns[4].Header = "ناوی بازرگانی";
                mainDatagrid.Columns[5].Header = "هیز";
                mainDatagrid.Columns[6].Visibility = Visibility.Hidden;
                buttonRemoveSearchText.Visibility = Visibility.Visible;

            }
        }

        private async void mainDatagrid_GotMouseCapture(object sender, MouseEventArgs e)
        {
         
            if (_isBuy)
            {
                var persons = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.Item;
                if (persons is null)
                {
                    return;
                }
                ItemId = persons.ItemId;
                TypeId = persons.ItemTypeId;
                Barcode = persons.Barcode;
                ItemName = persons.ScienceName;
                Query q = new Query();
                TypeName = await q.GetOne("select TypeName from ItemType where ItemTypeId=@id", new string[,] { { "@id", TypeId.ToString() } });
                foreach (var wndOtherWindow in Application.Current.Windows)
                {
                    if (wndOtherWindow is ForPageWindow)
                    {
                        (wndOtherWindow as Window).Close();
                    }
                }
                return;
            }

            var person = mainDatagrid.SelectedItem as PharmacyHajiawa.Models.Item;
            if (person is null)
            {
                return;
            }
            if (person.Status == true)
            {
                DisplaySheet displaySheet = new DisplaySheet(new List<string>() { "گەڕاندنەوە" });
                displaySheet.ShowDialog();
                if (DisplaySheet.theResult is "گەڕاندنەوە")
                {
                    QueryInside($"update Item set Status=0 where ItemId={person.ItemId}");

                    GetItems(true);
                }
                return;

            }
            ItemEditWindow it = new ItemEditWindow(false, person.ItemId) { };
            it.ShowDialog();
            GetItems(false);
        }

        private void OnRemoveTextboxSearch(object sender, RoutedEventArgs e)
        {
            textboxSeatch.Text = null;
            buttonRemoveSearchText.Visibility = Visibility.Collapsed;

        }
        private void OnBackClicked(object sender, RoutedEventArgs e)
        {
            if (_isBuy)
            {
                ItemTypePage its = new ItemTypePage(true);
                this.NavigationService.Navigate(its);

                return;
            }
            ItemTypePage it = new ItemTypePage();
            this.NavigationService.Navigate(it);

        }
        private async void OnDeletedClicked(object sender, RoutedEventArgs e)
        {
            GetItems(true);
        }
        private async void OnAvailableClicked(object sender, RoutedEventArgs e)
        {
            GetItems(false);
        }
    }
}
