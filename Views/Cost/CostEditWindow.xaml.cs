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
using System.Windows.Shapes;

namespace PharmacyHajiawa.Views.Cost
{
    /// <summary>
    /// Interaction logic for CostEditWindow.xaml
    /// </summary>
    public partial class CostEditWindow : Window
    {
        public bool _isAdd;
        public int _costId;
        public CostEditWindow(bool isAdd,int costId)
        {
            InitializeComponent();
            _isAdd = isAdd;
            _costId = costId;
        }

        Query query = new Query();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_isAdd)
            {
                buttonDelete.Visibility = Visibility.Collapsed;
            }
            else 
            {
               List<Models.Cost> costs = dotNETConnection.ConvertSqlToList<Models.Cost>($"select * from Cost where CostId={_costId}");
                txtAmount.Text = costs.FirstOrDefault().CostAmount.ToString();
                txtDetail.Text = costs.FirstOrDefault().Detail;
                dtpDate.SelectedDate = costs.FirstOrDefault().CostDate;
                txtName.Text = costs.FirstOrDefault().CostName;
            }

        }

        private void OnCancelClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
           
            if (_isAdd)
            {
                Models.Cost cost = new Models.Cost()
                {
                    CostAmount = double.Parse(txtAmount.Text),
                    CostDate = dtpDate.SelectedDate.Value.Date,
                    CostName = txtName.Text,
                    Detail = txtDetail.Text,
                    IsDeleted = false
                };
               await query.InsertAsync(cost);
                this.Close();
            }
            else
            {
                Models.Cost cost = new Models.Cost()
                {
                    CostAmount = double.Parse(txtAmount.Text),
                    CostDate = dtpDate.SelectedDate.Value.Date,
                    CostName = txtName.Text,
                    Detail = txtDetail.Text,
                };
              await  query.UpdateAsync(cost,$"where CostId={_costId}");
                this.Close();
            }
           
        }

        private async void OnDeleteClicked(object sender, RoutedEventArgs e)
        {
            DisplayAlert alert = new DisplayAlert("ئاگاداری", "ئایا دڵنیای لە ڕەشکردنەوەکەت؟", "بەڵێ", "نەخێر");
            alert.ShowDialog();
            if (DisplayAlert.theResult is "نەخێر")
            {
                return;
            }
            await query.ExcuteAsync($"update Cost set IsDeleted=1 where CostId={_costId};");
            this.Close();
        }

        private void txtAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double userage;
                if (!double.TryParse(txtAmount.Text, out userage) && txtAmount.Text != null)
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تەنها دەتوانی ژمارە داخڵ بکەی", "باشە");
                    alert.ShowDialog();
                    if (txtAmount.Text.Length != 0)
                    {
                        txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1, 1);
                    }
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("هەڵەیەک ڕووی دا تکایە دووبارە هەوڵ بەرەوە");
                this.Close();
            }
        }
    }
}
