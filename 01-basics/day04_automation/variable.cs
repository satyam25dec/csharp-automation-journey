using System;
using System.Collections.Generic;
using System.Text;

namespace day04_automation
{
    internal class variable
    {
        public static void fourvar()
        {
            var name = "Satyam Singh";
            var age = 25;
            var isWorking = true;
            var salary = 26000.50f;

            Console.WriteLine(name.GetType());
            Console.WriteLine(age.GetType());
            Console.WriteLine(isWorking.GetType());
            Console.WriteLine(salary.GetType());

        }
    }
}
