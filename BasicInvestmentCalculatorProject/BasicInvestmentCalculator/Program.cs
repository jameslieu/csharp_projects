using System;

namespace BasicInvestmentCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.GetInvestment();
        }

        public static void GetInvestment()
        {
            Console.WriteLine("How much is the investment (£):");
            var investmentEntry = Console.ReadLine();

            double price = Program.ValidateEntryAndReturn(investmentEntry);

            Console.WriteLine("How much interest (%):");
            var interestEntry = Console.ReadLine();

            Double interest = Program.ValidateEntryAndReturn(interestEntry);

            var returnOnInvestment = Program.GetReturnOnInvestment(price, interest);
            double total = returnOnInvestment + price;

            Console.WriteLine("The return on investment is: " + returnOnInvestment);
            Console.WriteLine("The total amount to repay is: " + total);
            // https://stackoverflow.com/questions/3161341/c-sharp-unit-test-for-a-method-which-calls-console-readline
        }

        private static double GetReturnOnInvestment(double price, double interest)
        {
            var result = price * (interest / 100);
            return result;
        }

        private static double ValidateEntryAndReturn(string value)
        {
            double result;
            if (!Double.TryParse(value, out result))
            {
                Console.WriteLine("Unknown format, please enter a number");
                Console.ReadLine();
            };

            return result;
        }

        public static void CalculateOverNumYears(Int32 year, Double interestGained, Double total)
        {

        }
    }
}
