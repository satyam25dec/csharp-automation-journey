using System;
using System.Collections.Generic;
using System.Text;

namespace day04_automation
{
    internal class SwapTwoVariable
    {
        public static void swapvariables()
        {
            int a = 10;
            int b = 20;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a={a}, b={b}");
        }
    }
}
