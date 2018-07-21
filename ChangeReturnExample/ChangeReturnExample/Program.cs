using System;

namespace ChangeReturnExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter total purchase amount: ");
            var purchasePriceInput = Console.ReadLine();
            var purchasePriceDecimal = ValidateDecimal(purchasePriceInput);

            Console.Write("Please enter amount you're going to pay: ");
            var moneyPaidInput = Console.ReadLine();
            var moneyPaidDecimal = ValidateDecimal(moneyPaidInput);

            if (moneyPaidDecimal > purchasePriceDecimal)
            {
                Console.WriteLine("Thank you for your purchase!");
                Console.WriteLine($"Here is your change: £{moneyPaidDecimal - purchasePriceDecimal}");
                Console.WriteLine();
                var totalChange = Purchase.ReceiveChange(purchasePriceDecimal, moneyPaidDecimal);

                foreach (var change in totalChange)
                {
                    Console.WriteLine(change);
                }

                Console.ReadLine();

            } else
            {
                Console.WriteLine("You have not provided the correct amount");
                Console.ReadLine();
            }


        }

        private static decimal ValidateDecimal(string input)
        {
            decimal output;
            if (!Decimal.TryParse(input, out output))
            {
                Console.WriteLine("Invalid input, please provide a valid amount");
                Console.ReadLine();
                Environment.Exit(0);
            }

            return output;
        }
    }
}
