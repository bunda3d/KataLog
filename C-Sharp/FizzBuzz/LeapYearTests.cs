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
	[InlineData(1920, true)]  // years divisible by 4 are leap years
	[InlineData(1900, false)] // years divisible by 100 are NOT leap years
	[InlineData(2000, true)]  // years divisible by 400 ARE leap years
	[InlineData(2025, false)] // default: non leap year
	public void Divider_ReturnsIsLeapYearStatus_PerDivisibility(int year, bool isLeapYear)
	{
		// Given
		var leapYear = new LeapYear();

		// When
		var result = leapYear.IsLeapYear(year);

		// Then
		Assert.Equal(isLeapYear, result);
	}
}