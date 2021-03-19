using System;
using System.Windows;
using System.Windows.Controls;
using Ookii.Dialogs.Wpf;
using PharmacyHajiawa.Views.Message;
using PharmacyHajiawa.Class;
using System.Threading.Tasks;

namespace PharmacyHajiawa.Views.Security
{
    /// <summary>
    /// Interaction logic for SecurityMainPage.xaml
    /// </summary>
    public partial class SecurityMainPage : Page
    {
        public SecurityMainPage()
        {
            InitializeComponent();
        }
        Query query = new Query();
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void OnFindLocationClicked(object sender, RoutedEventArgs e)
        {
            try
            {

                VistaFolderBrowserDialog dialog = new VistaFolderBrowserDialog();
                if (dialog.ShowDialog().GetValueOrDefault())
                {
                    txtPlace.Text = dialog.SelectedPath;
                }
            }
            catch 
            {
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "سەرکەوتوو نەبوو تکایە دوبارە هەوڵبەرەوە", "باشە");
                alert.ShowDialog();
            }
        }

        private async void OnCheckClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtPlace.Text is null || txtPlace.Text == "" ||txtPlace.Text.Equals(string.Empty))
                {
                    DisplayAlert alert = new DisplayAlert("ئاگاداری", "تکایە شوێنی هەڵگرتنی باکئەپەکە دیاری بکە", "باشە");
                    alert.ShowDialog();
                    return;
                
                }
       
                await query.ExcuteAsync(@$"BACKUP DATABASE PharmasyDB 
                                        TO DISK = N'{txtPlace.Text}\Backup-{DateTime.Now.ToString("dd-MM-yyyy-HH_mm_ss")}.bak' ");
                MessageBox.Show("سەرکەوتوبوو");
                await Task.Delay(1000);
            }
            catch (Exception exz)
            {
                MessageBox.Show(exz.Message);

                DisplayAlert alert = new DisplayAlert("ئاگاداری","سەرکەوتوو نەبوو تکایە دوبارە هەوڵبەرەوە","باشە");
                alert.ShowDialog();
            }
        }

        private async void OnRecoverClicked(object sender, RoutedEventArgs e)
        {
            try
            {


                VistaOpenFileDialog dialog = new VistaOpenFileDialog();
                if (dialog.ShowDialog().GetValueOrDefault())
                {
                    string fileName = dialog.FileName;
                    string sub = fileName.Substring(fileName.Length - 3, 3);
                    if (sub != "bak")
                    {
                        DisplayAlert alert = new DisplayAlert("ئاگاداری", "ئەو فایلەی دیاریتکردوە هەڵەیە", "باشە");
                        alert.ShowDialog();
                        return;
                    }
                    await query.ExcuteAsync(@$"use master 
                                                
                                                RESTORE DATABASE PharmasyDB 
                                                FROM DISK = N'{fileName}' 
                                                with replace");
                    MessageBox.Show("سەرکەوتوبوو");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DisplayAlert alert = new DisplayAlert("ئاگاداری", "سەرکەوتوو نەبوو تکایە دوبارە هەوڵبەرەوە", "باشە");
                alert.ShowDialog();
            }
        }


        
    }
}
