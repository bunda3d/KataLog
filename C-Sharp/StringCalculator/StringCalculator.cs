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

			// return summed numbers from delimited string
			foreach (string number in numbers.Split(','))
			{
				int parsedNumber = int.Parse(number);
				sumTotal += parsedNumber;
			}

			return result = sumTotal;
		}
	}
}