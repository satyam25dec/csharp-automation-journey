using System;
using System.Collections.Generic;
using System.Text;

namespace day03_automation
{
    internal class GST
    {
        public static void gst()
        {
            const int tax = 18;
            int price = 2500;

            int GstAmount = (price * tax) / 100;
            Console.WriteLine(GstAmount);
        }
    }
}
