using BarTargu.WindowTar.PageTar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BarTargu.Class
{
    public class NavigationController
    {
        public static Frame MainFrame { get; set; } = new Frame();

        public static PageMenu StaticMenu = new PageMenu(); 
    }
}
