namespace day02_automation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== C# PRACTICE =====");
                Console.WriteLine("1. Person details");
                Console.WriteLine("2. Sum of two numbers");
                Console.WriteLine("3. Print the Integers");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");

                string? choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": FirstProgram.run(); break;
                    case "2": Third_Program.add(); break;
                    case "3": SecondProgram.variabledemo();break;
                    case "0": return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }

    }
}
