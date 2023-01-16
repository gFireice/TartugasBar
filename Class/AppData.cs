using BarTargu.SqlBase;
using System.Collections.Generic;

namespace BarTargu.Class
{
    public class AppData
    {
        public static SqlBase.Entities Context =new SqlBase.Entities();

        public static int SelectedTableNumber { get; set; } 

        public static List<Product> Cart { get; set; } = new List<Product>();

        public static void updateAppData()
        {
            Context = new Entities();
        }
    }
}
