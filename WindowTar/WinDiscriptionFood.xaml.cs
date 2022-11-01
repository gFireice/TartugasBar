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
using System.Windows.Shapes;

namespace BarTargu.WindowTar
{
    /// <summary>
    /// Логика взаимодействия для WinDiscriptionFood.xaml
    /// </summary>
    public partial class WinDiscriptionFood : Window
    {
        public WinDiscriptionFood(int MenuID)
        {
            InitializeComponent();
            List<SqlBase.Product> products = AppData.Context.Product.ToList();
            products = products.Where(x => x.ProductID == MenuID).ToList();
            NameFood.DataContext = products;
            ComponentFood.DataContext=products;
            WeightFood.DataContext = products;
            DescriptionFood.DataContext = products;
            CategoryFood.DataContext = products;
            CostFood.DataContext = products;   
        }
    }
}
