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

namespace Brouser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NextTabButtonClick(object sender, RoutedEventArgs e)
        {
            TabItem newTab = new TabItem();
            WebBrowser webBrowser = new WebBrowser();

            webBrowser.Source = new Uri("http://www.google.com");
            newTab.Header = new TextBlock { Text = "Новая вкладка "};
            newTab.Content = webBrowser;

            webBrouserPages.Items.Insert(webBrouserPages.Items.Count-1, newTab);
        }
    }
}
