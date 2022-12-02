using System;

namespace ProjectCosmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input");
            string userInput = Console.ReadLine();

            //SubString(userInput);
            //Replace(userInput);
            //Modify(userInput);
            // AlterTextCase(userInput);
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
            string template = "Hello {name}, how are you?";
            string output = template.Replace("{name}", userInput);
            Console.WriteLine(output);
        }
        static void Modify(string userInput)
        {
            string removedString = userInput.Remove(5);
            string subString = userInput.Substring(5);
            string insertString = userInput.Insert(5, "Samolot");
            string trimedString = userInput.Trim();

            Console.WriteLine(removedString);
            Console.WriteLine(subString);
            Console.WriteLine(insertString);
            Console.WriteLine(trimedString);
        }
        static void AlterTextCase()
        {

        }
    }
}
