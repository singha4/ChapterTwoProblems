using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class HoursAndMinutes
    {
        static void Main(string[] args)
        {
            int minutes = 197, hours;
            hours = minutes / 60;
            minutes = minutes % 60;
            Console.WriteLine("{0} hours {1} minutes", hours, minutes);
        }
    }
}
 