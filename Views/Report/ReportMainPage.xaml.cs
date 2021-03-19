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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PharmacyHajiawa.Views.Report
{
    /// <summary>
    /// Interaction logic for ReportMainPage.xaml
    /// </summary>
    public partial class ReportMainPage : Page
    {
        public ReportMainPage()
        {
            InitializeComponent();
        }


        private void OnBenifitClicked(object sender, RoutedEventArgs e)
        {
            BenifitWindow bw = new BenifitWindow();
            bw.ShowDialog();
        }
    }
}
