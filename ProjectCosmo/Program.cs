using System;

namespace ProjectCosmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input");
            string userInput = Console.ReadLine();

            SubString(userInput);
            Replace(userInput);
        }

        static void SubString(string userInput)
        {
            if (userInput.Length > 10)
            {
                string startSubstring = userInput.Substring(0, 10);
                string endSubstring = userInput.Substring(userInput.Length - 10);
                Console.WriteLine($"{startSubstring}....,...{endSubstring}");
                Console.WriteLine(userInput);
            }
        }

        static void Replace(string userInput)
        {

        }
    }
}
