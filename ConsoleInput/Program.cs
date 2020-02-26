using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please make an entry...");

            string userEntry = Console.ReadLine();
            var newString = "";
            var counter = 0;

            for (int i = 0; i < userEntry.Length; i++)
            {
                var largeText = userEntry.ToUpper();
                newString += largeText[i];
                if (counter > 0)
                {
                    for (int j = 0; j < counter; j++)
                    {
                        newString += userEntry[i];
                    }
                }
                newString += "-";
                counter++;
            }
            Console.WriteLine(newString);

            Console.ReadKey();
        }
    }
}
