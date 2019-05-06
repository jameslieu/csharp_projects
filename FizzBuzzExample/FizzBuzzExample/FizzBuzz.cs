using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzExample
{
	public class FizzBuzz
	{
		public static List<string> results(int number)
		{
			List<string> fizzBuzzList = new List<string>();
			StringBuilder stringBuilder = new StringBuilder();

			for (int i = 1; i <= number; i++)
			{
				bool isFizz = i % 3 == 0;
				bool isBuzz = i % 5 == 0;

				if (isFizz)
				{
					stringBuilder.Append("Fizz");
				}

				if (isBuzz)
				{
					stringBuilder.Append("Buzz");
				}

				if (String.IsNullOrEmpty(stringBuilder.ToString()))
				{
					stringBuilder.Append(i.ToString());
				}

				fizzBuzzList.Add(stringBuilder.ToString());
				stringBuilder.Clear();
			}

			return fizzBuzzList;
		}
	}
}
