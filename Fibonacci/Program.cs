using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a number to see its Fibonacci sequence");
            var userInput = Console.ReadLine();

            int intUserInput = Convert.ToInt32(userInput);
            var generator = new Generator();
            foreach (var number in generator.Generate(intUserInput))
            {
                Console.WriteLine(number);
            }
        }
    }
}
