using System;

namespace ReverseStringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string reversedString = "";
            Console.WriteLine("Enter a string you want reversed:");
            str = Console.ReadLine();

            reversedString = ReverseString.Reverse(str);

            Console.WriteLine($"The Reversed string is '{reversedString}'");
            Console.ReadLine();
        }
    }
}
