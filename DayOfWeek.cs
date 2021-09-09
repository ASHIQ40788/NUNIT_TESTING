using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitPrograms
{

  
    /// this is DayOfWeek
   
    public class DayOfWeek
    {
        
        public static void Days(int month, int day, int year)
        {
            string[] days = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
            int dayIndex = Utility.Days(month, day, year);
            Console.WriteLine("day= " + days[dayIndex]);
        }
    }
}