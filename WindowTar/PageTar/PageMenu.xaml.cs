using BarTargu.Class;
using BarTargu.SqlBase;
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
            Filter();
        }

        public void Filter() 
        {
            MenuListView.ItemsSource = AppData.Context.Product.ToList();
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

            Class.NavigationController.MainFrame.Content = new PageCart();
        }

        private void MenuListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button) 
            {
                if (button.DataContext is Product addProduct) 
                {
                    addProduct.QuantityInCart++;
                    AppData.Cart.Add(addProduct);
                    //MessageBox.Show($"Блюдо {addProduct.Title} добавлено в корзину", "Меню", MessageBoxButton.OK, MessageBoxImage.Information);
                    Filter();
                }
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.DataContext is Product product)
                {
                    product.QuantityInCart--;
                    if (product.QuantityInCart == 0) 
                    { 
                        AppData.Cart.Remove(product);
                    }
                    Filter();
                }
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button.DataContext is Product product)
                {
                    product.QuantityInCart++;
                }
                Filter();
            }
        }
    }
}
