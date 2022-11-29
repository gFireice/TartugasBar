 using BarTargu.Class;
using BarTargu.SqlBase;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Логика взаимодействия для PageCart.xaml
    /// </summary>
    public partial class PageCart : Page
    {

        public decimal allCost = 0;
        public decimal AllCostSunday = 0;
        public PageCart()
        {
            InitializeComponent();
            Filter();

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void Filter()
        {
            CartListView.ItemsSource = AppData.Cart.ToList();
            

            allCost = 0;
            AllCostSunday = 0;
            foreach (SqlBase.Product product in AppData.Cart)
            {

                allCost += (product.Cost - (product.Discount* product.Cost)) * product.QuantityInCart;
                
            }
            AllCostSunday = MathData.MathSunday(allCost);
            if (allCost > AllCostSunday)
            {
                WhiteDay.Visibility = Visibility.Visible;
            }
            CartCostAll.Text =Convert.ToString(AllCostSunday);

        }

        private void btnBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            Class.NavigationController.StaticMenu.Filter();
            Class.NavigationController.MainFrame.Content = NavigationController.StaticMenu;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.Button button)
            {
                if (button.DataContext is Product product)
                {
                    product.QuantityInCart--;
                    if (product.QuantityInCart <= 0)
                    {
                        AppData.Cart.Remove(product);
                    }
                    Filter();
                }
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.Button button)
            {
                if (button.DataContext is Product product)
                {
                    product.QuantityInCart++;
                }
                Filter();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {




            SqlBase.OrderProduct orderProduct = new OrderProduct();
            
            Random random = new Random();
            SqlBase.Order order = new SqlBase.Order();
            if (MessageBox.Show("Оплатить?", "Оплатить?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                //try
                //{
                    
                    order.TotalCost = allCost;
                    order.TableNumID = AppData.SelectedTableNumber;
                    order.StaffID = random.Next(1, 5);
                     order.StatusID =1;
                    AppData.Context.Order.Add(order);
                    AppData.Context.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message.ToString());
                //}


                foreach (SqlBase.Product product in AppData.Cart)
                {

                    //try
                    //{
                        orderProduct.OrderID = order.OrderID;
                        orderProduct.ProductID = product.ProductID;
                        orderProduct.CountProduct = product.QuantityInCart;
                        AppData.Context.OrderProduct.Add(orderProduct);
                        AppData.Context.SaveChanges();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message.ToString());
                    //}
                    
                }
            }
        }
        
           
          
    }
}
