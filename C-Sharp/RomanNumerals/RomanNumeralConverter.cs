using System.Text;

namespace RomanNumerals;

internal class RomanNumeralConverter
{
	private static readonly (int Key, string Value)[] _RomanNumerals =
	[
		(1000, "M"),
		(900, "CM"),
		(500, "D"),
		(400, "CD"),
		(100, "C"),
		(90, "XC"),
		(50, "L"),
		(40, "XL"),
		(10, "X"),
		(9, "IX"),
		(5, "V"),
		(4, "IV"),
		(1, "I")
	];

	public string Convert(int number)
	{
		var result = new StringBuilder();

		// Refactor: lookup table to map keys to values,
		// and loop to match and return values

		foreach (var numeral in _RomanNumerals)
		{
			while (number >= numeral.Key)
			{
				result.Append(numeral.Value);
				number -= numeral.Key;
			}
		}

		return result.ToString();
	}
}