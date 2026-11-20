using System;
using System.Collections.Generic;
using System.Text;

namespace day03_automation
{
    internal class VariablesDemo
    {
        public static void variables()
        {
            Console.WriteLine("Enter your name: ");
            string? name = Console.ReadLine();

            Console.WriteLine("enter Mother's name: ");
            string? mname = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
