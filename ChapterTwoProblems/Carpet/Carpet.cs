using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Carpet
    {
        static void Main(string[] args)
        {
            int length = 15, width = 25, area;
            double price;
            area = length * width;
            price = area * 5.25;
            Console.WriteLine("The cost of carpeting is ${0}", price);
        }
    }
}
