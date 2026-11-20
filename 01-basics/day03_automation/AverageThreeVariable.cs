using System;
using System.Collections.Generic;
using System.Text;

namespace day03_automation
{
    internal class AverageThreeVariable
    {
       public static void average()
        {
            int a = 100, b = 200, c = 300;

            int avg = (a + b + c) / 3;

            Console.WriteLine("Average of three numbers: " + avg);
        }

    }
}
