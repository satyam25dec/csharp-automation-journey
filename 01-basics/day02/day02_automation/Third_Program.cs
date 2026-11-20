using System;
using System.Collections.Generic;
using System.Text;

namespace day02_automation
{
    internal class Third_Program
    {
       public static void add()
        {
            //Sum of two numbers
            Console.WriteLine("Enter first number");
            int fnum = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Ener the second number");
            int snum = int.Parse(Console.ReadLine() ?? "0");

            int sum = fnum + snum;
            Console.WriteLine($"Sum of {fnum} and {snum} is: {sum}");

        }
    }
}
