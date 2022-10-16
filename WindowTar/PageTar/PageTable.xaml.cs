using BarTargu.Class;
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

        private void BtnTable_Click(object sender, RoutedEventArgs e)
        {

            if (sender is Button button) 
            {
                AppData.SelectedTableNumber = Convert.ToInt32(button.Content);
                Class.NavigationController.MainFrame.Content = NavigationController.StaticMenu;
            }

            //Uri uri = new Uri("WindowTar/PageTar/PageMenu.xaml", UriKind.Relative);
            //this.NavigationService.Navigate(uri);
        }
    }
}
