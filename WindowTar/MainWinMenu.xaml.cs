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
using System.Windows.Shapes;
using BarTargu.WindowTar.PageTar;
using BarTargu.WindowTar;
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
