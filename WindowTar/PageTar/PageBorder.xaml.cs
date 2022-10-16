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
using BarTargu.Class;
using BarTargu.WindowTar;


namespace BarTargu.WindowTar.PageTar
{
    /// <summary>
    /// Логика взаимодействия для PageBorder.xaml
    /// </summary>
    public partial class PageBorder : Page
    {
        public PageBorder()
        {
            InitializeComponent();
        }

        private void NavigatTable_Click(object sender, RoutedEventArgs e)
        {
        //    Uri uri = new Uri("WindowTar/PageTar/PageTable.xaml", UriKind.Relative);
        //    this.NavigationService.Navigate(uri);

            NavigationController.MainFrame.Content = new PageTable();
        }
    }
}
