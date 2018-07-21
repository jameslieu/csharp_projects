using System;
using System.Collections.Generic;

namespace FizzBuzzExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter FizzBuzz Count: ");
            int fizzBuzzCount = 0;

            var consoleInput = Console.ReadLine();
            Console.WriteLine();

            if (Int32.TryParse(consoleInput, out fizzBuzzCount))
            {
                var results = FizzBuzz.results(fizzBuzzCount);
                foreach(var result in results)
                {
                    Console.WriteLine(result);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid entry, please enter a number");
                Console.ReadLine();
            }
        }
    }
}
