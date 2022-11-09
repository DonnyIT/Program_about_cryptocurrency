using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TheFirstProgram.Model;
using TheFirstProgram.ViewModel;

namespace TheFirstProgram.View
{
    public partial class CryptingUpTopPage : Page
    { 

        private CryptingUpTopPage()
        {
            InitializeComponent();
        }
        
        private static CryptingUpTopPage _instance;
                
        public static CryptingUpTopPage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CryptingUpTopPage();
            }
            return _instance;
        }

        public DataGrid GetGrid()
        {
            return TableTop;
        }

        private void TableTop_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TableTop.SelectedItem != null && TableTop.SelectedItem is Currency)
            {
                var mainWindow = ((MainWindow)Application.Current.MainWindow);
                InformationPage.GetInstance().SetContext((Currency)TableTop.SelectedItem);
                mainWindow.GetFrameMain().Content = InformationPage.GetInstance();
            }
            TableTop.SelectedIndex = -1;
        }

        public void SetContext(List<Currency> currencies)
        {
            var viewSource = ((CollectionViewSource)FindResource("CurrenciesData"));
            viewSource.Source = currencies;
            TableTop.SelectedIndex = -1;
        }

        private void CollectionViewSource_Filter(object sender, FilterEventArgs e)
        {
            var item = e.Item as Currency;
            if (item != null)
            {
                if (string.IsNullOrEmpty(SearchBox.Text))
                {
                    e.Accepted = true;
                    return;
                }
                if (item.Name.Contains(SearchBox.Text) || item.CurrencyCode.Contains(SearchBox.Text))
                    e.Accepted = true;
                else
                    e.Accepted = false;
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(TableTop.ItemsSource).Refresh();
        }
    }

}
