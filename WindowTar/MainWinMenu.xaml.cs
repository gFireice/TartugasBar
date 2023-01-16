
using System.Windows;

using BarTargu.WindowTar.PageTar;

using BarTargu.Class;


namespace BarTargu.WindowTar
{
    /// <summary>
    /// Логика взаимодействия для MainWinMenu.xaml
    /// </summary>
    public partial class MainWinMenu : Window
    {
        public MainWinMenu()
        {
            
            InitializeComponent();
           
            NavigationController.MainFrame = this.PageNavigate;
            NavigationController.MainFrame.Content = new PageBorder();
        }

     
     
    }
}
