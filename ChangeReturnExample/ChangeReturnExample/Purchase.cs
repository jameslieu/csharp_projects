using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeReturnExample
{
	public class Purchase
	{
		public static List<string> ReceiveChange(Decimal purchasePrice, Decimal moneyPaid)
		{
			List<string> changeList = new List<string>();

			var totalChangeAmount = moneyPaid - purchasePrice;

			var coins = new[]
			{
				new { name = "pound", nominal = 1.00m },
				new { name = "fifty pence", nominal = 0.50m },
				new { name = "twenty pence", nominal = 0.20m },
				new { name = "ten pence", nominal = 0.10m },
				new { name = "five pence", nominal = 0.05m },
				new { name = "two pence", nominal = 0.02m },
				new { name = "one pence", nominal = 0.01m },
			};

			foreach (var coin in coins)
			{
				int count = (int) (totalChangeAmount / coin.nominal);
				totalChangeAmount -= count * coin.nominal;

				changeList.Add($"{count} {coin.name}");
			}

			return changeList;
		}
	}
}
