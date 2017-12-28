using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            string input;

            int index = 0;
            int counter = 1;
            List<double> ints = new List<double>();
            int thenumber = 0;

            Prompt();

            input = Console.ReadLine();

            while (input != "Q") {

                if (input == "0")
                {
                    Console.WriteLine("dummy that can't be right...");
                }
                else if (!int.TryParse(input, out thenumber)){

                    Console.WriteLine("that wasn't a number");
                }
                else
                {
                    while (index < 10)
                    {
                        double result = Math.Pow((thenumber + 1) * 2, 2+ index);
                        ints.Add(result);

                        Console.WriteLine($"ints: {ints[index]} @ index: {index}");
                        counter++;
                        index = index + 1;
                    }
                }

                Prompt();
                index = 0;
                ints.Clear();
                input = Console.ReadLine();
           }    
            return 0;
        }

        static void Prompt()
        {
            string prompt = "Enter your age:";
            Console.Write(prompt);
            
        }
    }
}
