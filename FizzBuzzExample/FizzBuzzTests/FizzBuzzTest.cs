using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FizzBuzzTests
{
	[TestClass]
	public class FizzBuzzTest
	{
		[TestMethod]
		public void TestResults()
		{
			var expected = new List<string> {
				"1",
				"2",
				"Fizz",
				"4",
				"Buzz",
				"Fizz",
				"7",
				"8",
				"Fizz",
				"Buzz",
				"11",
				"Fizz",
				"13",
				"14",
				"FizzBuzz"
			};

			int fizzBuzzCount = 15;
			List<string> results = FizzBuzzExample.FizzBuzz.results(fizzBuzzCount);

			CollectionAssert.AreEqual(results, expected);
		}
	}
}
