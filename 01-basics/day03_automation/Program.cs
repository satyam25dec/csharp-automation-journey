namespace day03_automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. VariablesDemo");
            Console.WriteLine("2. SalartPrint");
            Console.WriteLine("3. Sum");
            Console.WriteLine("4. Differences");
            Console.WriteLine("5. Print");
            Console.WriteLine("6. Average of three numbers");
            Console.WriteLine("7. GST Calculation");
            Console.WriteLine("Select");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    VariablesDemo.variables();
                    break;

                case "2":
                    SalarytPrint.salary();
                    break;

                case "3":
                    SumOfTwoVariables.sum();
                    break;

                case "4":
                    Differencecs.difference();
                    break;

                case "5":
                    Print.name();
                    break;

                case "6":
                    AverageThreeVariable.average();
                    break;

                case "7":
                    GST.gst();
                    break;




            }
        }
    }
}
