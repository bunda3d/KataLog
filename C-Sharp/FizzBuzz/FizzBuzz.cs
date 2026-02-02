namespace FizzBuzz;

public class FizzBuzz
{
	public string Divider(int n)
	{
		string indicator = string.Empty;

		// Do first the check for both 3 and 5
		if ((n % 5 == 0) && (n % 3 == 0))
		{
			return indicator = "FizzBuzz";
		}

		if (n % 3 == 0) { return indicator = "Fizz"; }
		if (n % 5 == 0) { return indicator = "Buzz"; }

		// Else, return number as string
		return n.ToString();
	}
}