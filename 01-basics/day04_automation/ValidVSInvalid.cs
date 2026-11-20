using System;
using System.Collections.Generic;
using System.Text;

namespace day04_automation
{
    internal class Swapping
    {
        public static void swaptwo()
        {
            int a = 10;
            int b = 20;
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"a={a},b={b}");
        }
    }
}
