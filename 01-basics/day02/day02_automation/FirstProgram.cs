using System;
using System.Collections.Generic;
using System.Text;

namespace day02_automation
{
    internal class FirstProgram
    {
       public static void run()
        {
            Console.WriteLine("Enter Your name: ");
            string? Name = Console.ReadLine();

            Console.WriteLine("Enter your father's name: ");
            string? FatherName = Console.ReadLine();

            Console.WriteLine("Enter mother's name: ");
            string? MotherName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int? age = int.Parse(Console.ReadLine() ?? "0");


            Console.WriteLine("\n------Your Details---");

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"FatherName: {FatherName}");
            Console.WriteLine($"MotherName: {MotherName}");
            Console.WriteLine($"Age: {age}");


        }

    }
}
