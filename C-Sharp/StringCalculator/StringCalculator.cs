namespace StringCalculator
{
	internal class StringCalculator
	{
		public int Add(string numbers)
		{
			var result = 0;
			var defaultDelimiters = new List<string> { ",", "\n" };
			var delimiters = defaultDelimiters;
			var negativeNumbers = new List<string>();

			// Check for new delimiter(s) "//[delimiter]\n[numbers...]"
			if (numbers.StartsWith("//") && numbers.Contains("\n"))
			{
				delimiters.AddRange(GetNewDelimiter(numbers));
				numbers = RemoveNewDelimiterSegment(numbers);
			}

			// Bail early on empty input, return 0
			if (string.IsNullOrWhiteSpace(numbers)) return result;

			// Split input string by delimiters (if any), incl. multi-char delimiters
			var splitNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

			// Return summed numbers from delimited string
			foreach (string number in splitNumbers)
			{
				// Negatives not allowed
				if (number.Trim().StartsWith("-"))
					negativeNumbers.Add(number.Trim());

				int parsedNumber = int.Parse(number);

				// Larger than 1000 set to zero
				if (parsedNumber > 1000) parsedNumber = 0;

				result += parsedNumber;
			}

			if (negativeNumbers.Count > 0)
			{
				string negativeNumbersString = string.Join(", ", negativeNumbers);
				throw new ArgumentException($"negatives not allowed: {negativeNumbersString}");
			}

			return result;
		}

		private static IEnumerable<string> GetNewDelimiter(string numbers)
		{
			// Get new delimiter header segment
			int newLineIndex = numbers.IndexOf("\n");
			string header = numbers[2..newLineIndex];

			// Scenario: 'add multiple new delims' (bracketed)
			if (header.StartsWith("[") && header.EndsWith("]"))
			{
				var trimmedHeader = header[1..^1]; // Remove outer brackets first
				return trimmedHeader.Split("][");  // use "][" as delimeter to get delimiters
			}
			// Scenario: 'add single new delim' (non-bracketed)
			return new[] { header };
		}

		private static string RemoveNewDelimiterSegment(string numbers)
		{
			// After extracting new delim, remove the new delim segment or it breaks process
			return numbers[(numbers.IndexOf("\n") + 1)..];
		}
	}
}