namespace FizzBuzz;

public class FizzBuzzTests
{
	/*
	Write a function that accepts an integer n and returns a string:
	1.	If n is divisible by 3, return "Fizz".
	2.	If n is divisible by 5, return "Buzz".
	3.	If n is divisible by both 3 and 5, return "FizzBuzz".
	4.	Otherwise, return the number itself as a string (e.g., input 1 -> output "1").
	*/

	[Theory]
	[InlineData(3, "Fizz")]
	public void Divider_ReturnsCorrectString_PerDivisibility(int number, string indicator)
	{
		// Given
		var fizzBuzz = new FizzBuzz();

		// When
		var result = fizzBuzz.Divider(number);

		// Then
		Assert.Equal(indicator, result);
	}
}