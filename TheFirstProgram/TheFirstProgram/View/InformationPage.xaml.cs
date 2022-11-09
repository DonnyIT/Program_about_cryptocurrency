using System;
using System.Collections.Generic;
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
using TheFirstProgram.Model;

namespace TheFirstProgram.View
{
    /// <summary>
    /// Interaction logic for InformationPage.xaml
    /// </summary>
    public partial class InformationPage : Page
    {

        private InformationPage()
        {
            InitializeComponent();
        }

        private static InformationPage _instance;

        public static InformationPage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new InformationPage();
            }
            return _instance;
        }

        public void SetContext(Currency cur)
        {
            Name.Text = cur.Name;
            CurrencyCode.Text = cur.CurrencyCode;
            Price.Text = cur.Price.ToString();
            Volume24h.Text = cur.Volume.ToString();
            Change1h.Text = cur.Change1h.ToString();
            Change24h.Text = cur.Change1d.ToString();
            Change7d.Text = cur.Change7d.ToString();
            Status.Text = cur.Status;
        }
    }
   
}

