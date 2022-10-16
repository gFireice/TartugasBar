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
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FoodCategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            if(SearchCategoryFood.Visibility == Visibility.Visible)
            {
                SearchCategoryFood.Visibility=Visibility.Hidden;
            }
            else
            {
                SearchCategoryFood.Visibility = Visibility.Visible;
            }
        }

        private void BasketBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("WindowTar/PageTar/PageBascket.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
