using System;

namespace StringSplosion
{
	// https://codingbat.com/prob/p118366
	// Given a non-empty string like "Code" return a string like "CCoCodCode".
	// string_splosion('Code') → 'CCoCodCode'
	// string_splosion('abc') → 'aababc'
	// string_splosion('ab') → 'aab'

	public class StringSplosion
	{
		public string Run(string word)
		{
			char[] characters = word.ToCharArray();
			string result = "";

			for (int i=0; i < characters.Length; i++)
			{
				for (int j=0; j <= i; j++)
				{
					result += characters[j];
				}
			}

			return result;
		}
	}
}
