using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meniu - please type an option: ");
            Console.WriteLine("1) file ");
            Console.WriteLine("2) edit ");
            Console.WriteLine("3) view ");
            Console.Write("Please type your optinon: ");
            string optionLevel1 = Console.ReadLine();
            if (string.Equals(optionLevel1, "file", StringComparison.OrdinalIgnoreCase)) ;
            {
                Console.WriteLine("Meniu - please type an sub-option: ");
                Console.WriteLine("1.1) new ");
                Console.WriteLine("2.1) open ");
                Console.WriteLine("3.1) colne ");
                Console.Write("Please type your optinon: ");
                string optionLevel2 = Console.ReadLine();
                if (string.Equals(optionLevel2, "new", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("You created a new file.");
                }
                else if (string.Equals(optionLevel2, "open", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You opened a file.");
                }
                else if (string.Equals(optionLevel2, "clone", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You cloneed a file.");
                }
                else
                {
                    Console.WriteLine("Error option not found.");
                }

            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
