using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseStringExample
{
	public class ReverseString
	{
		public static string Reverse(string str)
		{
			int length = str.Length - 1;
			StringBuilder stringBuilder = new StringBuilder();

			while (length >= 0)
			{
				stringBuilder.Append(str[length]);
				length--;
			}

			return stringBuilder.ToString();
		}
	}
}
