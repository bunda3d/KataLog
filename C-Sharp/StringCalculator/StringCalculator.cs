namespace StringCalculator
{
	internal class StringCalculator
	{
		public int Add(string numbers)
		{
			var result = 0;
			var sumTotal = 0;

			// Bail early on empty input, return 0
			if (string.IsNullOrWhiteSpace(numbers)) return result;

			// return value of single number input
			int parsedNumber = int.Parse(numbers);
			result += parsedNumber;

			return result;
		}
	}
}