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
    /// Interaction logic for DisplayAlert.xaml
    /// </summary>
    public partial class DisplayAlert : Window
    {
        public DisplayAlert()
        {
            InitializeComponent();
        }

        string _title, _message, _buttonCommand, _btnsecond;
        public static string theResult;


        public DisplayAlert(string title, string message, string buttonCommand)
        {
            InitializeComponent();
            theResult = null;

            _title = title;
            _message = message;
            _buttonCommand = buttonCommand;

            secondbutton.Visibility = Visibility.Collapsed;


            txtTitle.Text = _title;
            txtMessage.Text = _message;
            btnFirst.Content = _buttonCommand;



        }
        public DisplayAlert(string title, string message, string buttonCommand, string btnSecond)
        {
            InitializeComponent();
            theResult = null;

            _title = title;
            _message = message;
            _buttonCommand = buttonCommand;
            _btnsecond = btnSecond;

            txtTitle.Text = _title;
            txtMessage.Text = _message;

            btnFirst.Content = _buttonCommand;
            secondbutton.Content = _btnsecond;



        }
        private void OnSecondClicked(object sender, RoutedEventArgs e)
        {
            theResult = secondbutton.Content.ToString();
            this.Close();

        }
        private void OnOkClicked(object sender, RoutedEventArgs e)
        {
            theResult = btnFirst.Content.ToString();
            this.Close();
        }
    }
}
