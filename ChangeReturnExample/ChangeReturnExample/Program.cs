using System;

namespace ChangeReturnExample
{
	class Program
	{
		private const string EnterTotalPurchaseMessage = "Please enter total purchase amount: ";
		private const string EnterAmountMessage = "Please enter amount you're going to pay: ";
		private const string ThankYouMessage = "Thank you for your purchase!";
		private const string ErrorMessage = "You have not provided the correct amount";

		static void Main(string[] args)
		{
			Console.Write(EnterTotalPurchaseMessage);
			var purchasePriceInput = Console.ReadLine();
			var purchasePriceDecimal = ValidateDecimal(purchasePriceInput);

			Console.Write(EnterAmountMessage);
			var moneyPaidInput = Console.ReadLine();
			var moneyPaidDecimal = ValidateDecimal(moneyPaidInput);

			if (moneyPaidDecimal > purchasePriceDecimal)
			{
				Console.WriteLine(ThankYouMessage);
				Console.WriteLine($"Here is your change: £{moneyPaidDecimal - purchasePriceDecimal}");
				Console.WriteLine();
				var totalChange = Purchase.ReceiveChange(purchasePriceDecimal, moneyPaidDecimal);

				foreach (var change in totalChange)
				{
					Console.WriteLine(change);
				}

				Console.ReadLine();
			}
			else
			{
				Console.WriteLine(ErrorMessage);
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
