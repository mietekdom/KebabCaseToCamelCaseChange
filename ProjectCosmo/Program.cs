using System;
using System.Text;

namespace ProjectCosmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert input by kebab case");
            string userInput = Console.ReadLine();

            //SubString(userInput);
            //Replace(userInput);
            //Modify(userInput);
            // AlterTextCase(userInput);
            //AlterTextCase(userInput);
            //Split(userInput);
            //CheckString(userInput);

            Console.WriteLine(ChangeFromKebabCaseToCamelCase(userInput));
        }

        //kebab case
        //some-variable-name

        //camel case
        //someVarsiableName


        static string ChangeFromKebabCaseToCamelCase(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChart = input[i];

                if(currentChart != '-')
                {
                    sb.Append(currentChart);
                }
                else
                {
                    char nextChar = input[i + 1];
                    sb.Append(char.ToUpper(nextChar));
                    i++;
                };
            }
            return sb.ToString();
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
        static void AlterTextCase(string userInput)
        {
            string uperCased = userInput.ToUpper();
            string lowerCased = userInput.ToLower();

            Console.WriteLine(uperCased);
            Console.WriteLine(lowerCased);
        }
        static void Split(string userInput)
        {
            string[] inputNames = userInput.Split(" ");
            string firstName = inputNames[0];
            string lastName = inputNames[inputNames.Length - 1];

            Console.WriteLine($"Hello {firstName} {lastName}");
        }
        static void CheckString(string userInput)
        {
            bool isTextFile = userInput.EndsWith(".txt");
            bool startWithString = userInput.StartsWith("doc-");

            bool containtText = userInput.Contains("text", StringComparison.CurrentCultureIgnoreCase); //litery pisane z małej i duzej

            Console.WriteLine($"is tectFile: {isTextFile}");
            Console.WriteLine($"is startWithDoc: {startWithString}");
            Console.WriteLine($"containts: {containtText}");
        }
    }
}
