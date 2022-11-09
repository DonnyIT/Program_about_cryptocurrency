using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
using TheFirstProgram.View;
using TheFirstProgram.ViewModel;

namespace TheFirstProgram
{
    public partial class MainWindow : Window
    {
        private CurrencyViewModel _CurrencyViewModel;
               
        public MainWindow()
        {
            InitializeComponent();
            _CurrencyViewModel = new CurrencyViewModel();
        }
        
        public CurrencyViewModel GetViewModel()
        {
            return _CurrencyViewModel;
        } 

        public Frame GetFrameMain()
        {
            return Main;
        }

        private void TopCryptocurrencies_Click(object sender, RoutedEventArgs e)
        {
            TopCryptocurrencies.IsEnabled = false;
            _CurrencyViewModel.LoadData();
            Main.Content = CryptingUpTopPage.GetInstance();
            TopCryptocurrencies.IsEnabled = true;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
