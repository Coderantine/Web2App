using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Web2App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WebAppDataService _dataSerice;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            _dataSerice = new WebAppDataService();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Apps.ItemsSource = _dataSerice.Get();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(UriBox.Text);
            var browserWindow = new Browser(uri);
            browserWindow.Show();
        }

        private void AddToSettings_Click(object sender, RoutedEventArgs e)
        {
            _dataSerice.Add(new WebAppData() { Url = new Uri(UriBox.Text) });
            Apps.ItemsSource = _dataSerice.Get();
        }

        private void LunchApp_Click(object sender, RoutedEventArgs e)
        {
            var uri = (sender as Button).Tag as Uri;
            var browserWindow = new Browser(uri);
            browserWindow.Show();
        }
    }
}
