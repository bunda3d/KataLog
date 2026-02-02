namespace FizzBuzz;

public class LeapYear
{
	public bool IsLeapYear(int year)
	{
		bool isLeapYear = false;

		if (year % 400 == 0) return isLeapYear = true;
		if (year % 100 == 0) return isLeapYear = false;
		if (year % 4 == 0) isLeapYear = true;

		return isLeapYear;
	}
}