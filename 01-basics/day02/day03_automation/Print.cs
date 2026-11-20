using System;
using System.Collections.Generic;
using System.Text;

namespace day03_automation
{
    internal class Print
    {
        public static void name()
        {
            Console.WriteLine("Enter your name");
            string sname="Welcome" + Console.ReadLine();
            Console.WriteLine(sname);
        }
    }
}
