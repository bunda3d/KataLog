namespace StringCalculator
{
	internal class StringCalculator
	{
		public int Add(string numbers)
		{
			var result = 0;
			var defaultDelimiters = new List<string> { ",", "\n" };
			var delimiters = defaultDelimiters;

			// Check for new delimiter "//[delimiter]\n[numbers...]"
			if (numbers.StartsWith("//") && numbers.Contains("\n"))
			{
				delimiters.Add(GetNewDelimiter(numbers));
				numbers = RemoveNewDelimiterSegment(numbers);
			}

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

		private static string GetNewDelimiter(string numbers)
		{
			return numbers[2..numbers.IndexOf("\n")];
		}

		private static string RemoveNewDelimiterSegment(string numbers)
		{
			// After extracting new delim, remove the new delim segment or it breaks process
			return numbers[(numbers.IndexOf("\n") + 1)..];
		}
	}
}