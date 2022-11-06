using ExCSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarTargu.SqlBase
{
    public partial class Product
    {

        public List<Category> Categories
        {
            get
            {
                return Categories.ToList();
            }
        }
        public int QuantityInCart { get; set; }

        public string InCart 
        { 
            get 
            {
                if (QuantityInCart > 0)
                {
                    return "Visible";
                }
                else 
                {
                    return "Hidden";
                }
            }  
        }

        public string NoInCart
        {
            get
            {
                if (QuantityInCart < 1)
                {
                    return "Visible";
                }
                else
                {
                    return "Hidden";
                }
            }
        }

        
    }
}
