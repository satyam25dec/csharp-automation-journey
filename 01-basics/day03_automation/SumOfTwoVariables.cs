using System;
using System.Collections.Generic;
using System.Text;

namespace day03_automation
{
    internal class SumOfTwoVariables
    {
        public static void sum()
        {
            //Method1
            /*
            int a = 5;
            int b = 21;

            int sum = a + b;

            Console.WriteLine(sum);
            */

            //Method2

            Console.WriteLine("Enter two numbers a & b");
            int a = int.Parse(Console.ReadLine() ?? "0");
            int b = int.Parse(Console.ReadLine() ?? "0");


            Console.WriteLine("Sum of two numbers: "+(a+b));
            

        }
    }
}
