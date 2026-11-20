using System;
using System.Collections.Generic;
using System.Text;

namespace day04_automation
{
    internal class FahrenheitFromCelcius
    {
        public static void temp()
        {
            float cel =23.321f;
            float fer = (cel * 9f / 5f)+ 32f ;

            Console.WriteLine("Celcius to Farenhiet conversion: " + fer);
        }
    }
}
