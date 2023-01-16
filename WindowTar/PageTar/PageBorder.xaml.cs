
using System.Windows;
using System.Windows.Controls;
using BarTargu.Class;


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
        

            NavigationController.MainFrame.Content = new PageTable();
        }
    }
}
