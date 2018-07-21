using System;
using System.Collections.Generic;

namespace Fibonacci
{
	public class Generator
	{
		private Dictionary<int, int> _cache = new Dictionary<int, int>();
		private int CachedFibonacciValue(int number)
		{
			if (!_cache.ContainsKey(number))
			{
				_cache.Add(number, FibonacciValue(number));
			}

			return _cache[number];
		}

		private int FibonacciValue(int number)
		{
			if (number < 2)
			{
				return number;
			}
			else
			{
				return CachedFibonacciValue(number - 1) + CachedFibonacciValue(number - 2);
			}
		}

		public IEnumerable<int> Generate(int n)
		{
			for(int i = 0; i < n; i++)
			{
				yield return CachedFibonacciValue(i);
			}
		}
	}
}