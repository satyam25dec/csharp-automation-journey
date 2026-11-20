using System;
using System.Collections.Generic;
using System.Text;

namespace day04_automation
{
    internal class PrintArea
    {
        public static void rectangle()
        {
            int len = 121;
            double wid = 21.876;

            double area = len*wid;
            double perimeter = 2 * (len + wid);

            Console.WriteLine("Area of rectangle: " + area);
            Console.WriteLine("Area of perimeter: " + perimeter);


        }
    }
}
