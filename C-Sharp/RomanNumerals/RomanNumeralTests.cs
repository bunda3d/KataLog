namespace RomanNumerals;

#region [ kata description ]

/*
Write a class RomanNumeralConverter with a method
Convert(int number) that returns the Roman numeral string.

1.	Symbols: I=1, V=5, X=10, L=50, C=100, D=500, M=1000.
2.	Additive: Symbols are written from largest to smallest and added.
	(e.g., VI = 5 + 1 = 6).
3.	Subtractive: If a smaller symbol appears before a larger one, it is subtracted.
•	I can be placed before V (5) and X (10) for 4 and 9.
•	X can be placed before L (50) and C (100) for 40 and 90.
•	C can be placed before D (500) and M (1000) for 400 and 900.

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
	[InlineData(2, "II")]
	[InlineData(3, "III")]
	[InlineData(5, "V")]
	[InlineData(10, "X")]
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