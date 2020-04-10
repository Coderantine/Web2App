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
using System.Windows.Shapes;

namespace Web2App
{
    /// <summary>
    /// Interaction logic for Browser.xaml
    /// </summary>
    public partial class Browser : Window
    {
        private Uri _uri;

        public Browser(Uri uri)
        {
            InitializeComponent();
            _uri = uri ?? throw new ArgumentNullException(nameof(uri));
            Loaded += Browser_Loaded;
        }

        private void Browser_Loaded(object sender, RoutedEventArgs e)
        {
            bro.Navigate(_uri);
        }
    }
}
