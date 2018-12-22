using Xunit;
using StringSplosion;

namespace StringSplosion.Tests
{
	public class StringSplosion_Run
	{
		private readonly StringSplosion _stringSplosion;

		public StringSplosion_Run()
		{
			_stringSplosion = new StringSplosion();
		}

		[Theory]
		[InlineData("Code", "CCoCodCode")]
		[InlineData("abc", "aababc")]
		[InlineData("ab", "aab")]
		public void ReturnASplosionOfTheString(string word, string expected)
		{
			var actual = _stringSplosion.Run(word);
			Assert.Equal(expected, actual);
		}
	}
}