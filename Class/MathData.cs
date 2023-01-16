using System;


namespace BarTargu.Class
{
    public class MathData
    {
        public static decimal MathSunday(decimal allCost, DayOfWeek date, int datetime)
        {
            if (date == DayOfWeek.Saturday && ((datetime - 1) / 7 + 1) == 5)
            {

              allCost = Math.Round(allCost - (allCost * 0.11M), 2);
              return allCost;
               
            }
            return allCost;
        }



    }
}
