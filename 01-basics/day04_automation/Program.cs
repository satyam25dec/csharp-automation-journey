namespace day04_automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Print four variables");
            Console.WriteLine("2. Swapping three variables");
            Console.WriteLine("3. Swapping two variables");
            Console.WriteLine("4. Print Area and Area of Perimeter");
            Console.WriteLine("5. Celcius to Farenheit conversion");

            string choice= Console.ReadLine() ?? "";

            switch(choice)
            {
                case "1":
                    variable.fourvar();
                    break;

                case "2":
                    Swapping.swaptwo();
                    break;

                case "3":
                    SwapTwoVariable.swapvariables();
                    break;

                case "4":
                    PrintArea.rectangle();
                    break;

                case "5":
                    FahrenheitFromCelcius.temp();
                    break;
            }


        }
    }
}
