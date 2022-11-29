using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarTargu.Class
{
    public class MathData
    {
        public static decimal MathSunday(decimal allCost)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday && ((DateTime.Now.Day - 1) / 7 + 1) == 5)
            {

              allCost = Math.Round(allCost - (allCost * 0.11M), 2);
              return allCost;
               
            }
            return allCost;
        }



    }
}
