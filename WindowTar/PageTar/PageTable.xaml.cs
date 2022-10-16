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

namespace BarTargu.WindowTar.PageTar
{
    /// <summary>
    /// Логика взаимодействия для PageTable.xaml
    /// </summary>
    public partial class PageTable : Page
    {
        
        public PageTable()
        {
            InitializeComponent();
        }

        private void BtnTable1_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("WindowTar/PageTar/PageMenu.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void BtnTable3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTable10_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
