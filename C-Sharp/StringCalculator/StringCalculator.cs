namespace StringCalculator
{
	internal class StringCalculator
	{
		public int Add(string numbers)
		{
			var result = 0;
			var delimiters = new List<string> { ",", "\n" };

			// Bail early on empty input, return 0
			if (string.IsNullOrWhiteSpace(numbers)) return result;

			// Split input string by delimiters (if any), incl. multi-char delimiters
			var splitNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

			// return summed numbers from delimited string
			foreach (string number in splitNumbers)
			{
				int parsedNumber = int.Parse(number);
				result += parsedNumber;
			}

			return result;
		}
	}
}