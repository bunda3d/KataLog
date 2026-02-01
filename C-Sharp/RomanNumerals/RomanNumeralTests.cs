namespace RomanNumerals;

#region [ kata description ]

/*
Write a class RomanNumeralConverter with a method
Convert(int number) that returns the Roman numeral string.

 1.	Fundamental Constants:
•	1 ➔ "I"
•	2 ➔ "II"
2.	Simple Addition (Recursion/Loop hinting):
•	3 ➔ "III"
3.	New Symbols (The "If" Trap):
•	5 ➔ "V"
•	10 ➔ "X"
4.	Additive Combination:
•	6 ➔ "VI" (Does your logic handle 5 + 1 automatically or do you need to write it?)
5.	The Subtraction Rule (The Refactor Point):
•	4 ➔ "IV"
•	This is usually where you refactor from if/switch statements to a Dictionary or List of mappings to handle subtraction cases like any other symbol.
6.	Verify Algorithm:
•	9 ➔ "IX"
•	20 ➔ "XX"
7.	Big Impact (Acceptance):
•	1990 ➔ "MCMXC" or 3999 ➔ "MMMCMXCIX"

 */

#endregion [ kata description ]

public class RomanNumeralTests
{
	[Theory]
	[InlineData(1, "I")]
	public void Convert_ReturnsExpectedRomanNumeral(int number, string numeral)
	{
		//Given
		var converter = new RomanNumeralConverter();

		//When
		var result = converter.Convert(number);

		//Then
		Assert.Equal(numeral, result);
	}
}