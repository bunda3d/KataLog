namespace FizzBuzz;

public class LeapYearTests
{
	/*
	Write a function that checks if a year is a leap year.
	1.	Years divisible by 4 are leap years.
	2.	EXCEPT years divisible by 100 are NOT leap years.
	3.	UNLESS years divisible by 400 ARE leap years.
	*/

	[Theory]
	[InlineData(1920, true)]
	public void Divider_ReturnsCorrectString_PerDivisibility(int year, bool isLeapYear)
	{
		// Given
		var leapYear = new LeapYear();

		// When
		var result = leapYear.IsLeapYear(year);

		// Then
		Assert.Equal(isLeapYear, result);
	}
}