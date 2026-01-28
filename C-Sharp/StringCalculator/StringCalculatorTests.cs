namespace StringCalculator
{
	public class StringCalculatorTests
	{
		#region [ Instructions ]

		/*
				STRING CALCULATOR KATA - STEP 1

				The owner of the system wants a simple calculator that handles converting string inputs into sums.

				REQUIREMENT:
				Create a class 'StringCalculator' with a method:
						public int Add(string numbers)

				RULES:
				1. The method can take 0, 1, or 2 numbers, separated by commas.
				2. Examples of valid inputs: "", "1", "1,2".
				3. For an empty string, the method should return 0.
				4. For a single number, it returns the number alone.
				5. For two numbers, it returns their sum.

				CONSTRAINTS:
				- Start with the simplest test case of an empty string.
				- Move to 1 and then 2 numbers.
				- Solve things as simply as possible!
		*/

		#endregion [ Instructions ]

		/*
    STRING CALCULATOR KATA - STEP 2

    Allow the Add method to handle an unknown amount of numbers.

    RULES:
    1. The method should handle any number of comma-separated integers (e.g., "1,2,3,4,5").
    2. Continue to return the sum of all numbers.
    3. Ensure previous functionality (empty string, single number) remains intact.
		*/

		[Theory]
		[InlineData("", 0)]
		public void Add_EmptyString_ReturnsZero(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData("1", 1)]
		[InlineData("9", 9)]
		[InlineData("0", 0)]
		[InlineData("1", 1)]
		public void Add_SingleNumber_ReturnsSameValue(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData("1,1", 2)]
		[InlineData("0,0", 0)]
		[InlineData("0,10", 10)]
		[InlineData("1,9", 10)]
		[InlineData("6,7", 13)]
		public void Add_TwoNumbers_ReturnsCorrectSum(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(result, expectedResult);
		}

		[Theory]
		[InlineData("1,1,1,1", 4)]
		[InlineData("0,7,9,4", 20)]
		[InlineData("5,5,0,1,9,10", 30)]
		[InlineData("100,1,100,1", 202)]
		[InlineData("6,7,6,7,1", 27)]
		public void Add_MultipleNumbers_ReturnsCorrectSum(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(result, expectedResult);
		}
	}
}