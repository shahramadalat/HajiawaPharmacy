using PharmacyHajiawa.Class;
using PharmacyHajiawa.Class.dotNET;
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

namespace PharmacyHajiawa.Views.Report
{
    /// <summary>
    /// Interaction logic for BenifitWindow.xaml
    /// </summary>
    public partial class BenifitWindow : Window
    {
        public BenifitWindow()
        {
            InitializeComponent();
        }

        Query query = new Query();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datePickerFirst.SelectedDate = DateTime.Now;
            datePickerSecond.SelectedDate = DateTime.Now;
        }

        private void OnPrintClicked(object sender, RoutedEventArgs e)
        {
            PrintDialog dialog = new PrintDialog();
            if (dialog.ShowDialog() == true)
            {
                dialog.PrintVisual(stackPrint, "قازانجی ماوەی دیاریکراو");
            }
        }
        //Query query = new Query();
        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            //cost

            try
            {
                lblCost.Text =await query.GetOneNoParameter($"select sum(CostAmount) from Cost where CostDate between '{datePickerFirst.SelectedDate.ToString()}' and '{datePickerSecond.SelectedDate.ToString()}'");
                lblBuy.Text =  await query.GetOneNoParameter($"select sum(Total) from BuyInvoice where BuyDate between '{datePickerFirst.SelectedDate.ToString()}' and '{datePickerSecond.SelectedDate.ToString()}'");
                lblSold.Text = await  query.GetOneNoParameter($"select sum(Total) from SellInvoice where Date between '{datePickerFirst.SelectedDate.ToString()}' and '{datePickerSecond.SelectedDate.ToString()}'");
                lblSoldBenifit.Text =( int.Parse(lblSold.Text) - (int.Parse(lblBuy.Text) + int.Parse(lblCost.Text))).ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n سەرکەوتو نەبوو");
            }
            setZero(new List<TextBlock>() {lblCost,lblBuy,lblSoldBenifit });
        }

        void setZero(List<TextBlock> label)
        {

            foreach (var item in label)
            {
                if (item.Text == "")
                {
                    item.Text = "0";
                }
            }


        }

        private void OnCloseClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
