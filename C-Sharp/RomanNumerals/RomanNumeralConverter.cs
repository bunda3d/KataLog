using System.Text;

namespace RomanNumerals;

internal class RomanNumeralConverter
{
	public string Convert(int number)
	{
		var result = new StringBuilder();

		// Consume 10s
		while (number >= 10)
		{
			result.Append("X");
			number -= 10;
		}
		// Consume 5s
		while (number >= 5)
		{
			result.Append("V");
			number -= 5;
		}
		// Consume 1s
		while (number >= 1)
		{
			result.Append("I");
			number -= 1;
		}

		return result.ToString();
	}
}