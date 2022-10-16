﻿using BarTargu.Class;
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
    /// Логика взаимодействия для PageCart.xaml
    /// </summary>
    public partial class PageCart : Page
    {
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
        }

        private void btnBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            Class.NavigationController.StaticMenu.Filter();
            Class.NavigationController.MainFrame.Content = NavigationController.StaticMenu;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
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
