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

		STRING CALCULATOR KATA - STEP 2
    Allow the Add method to handle an unknown amount of numbers.

    RULES:
    1. The method should handle any number of comma-separated integers (e.g., "1,2,3,4,5").
    2. Continue to return the sum of all numbers.
    3. Ensure previous functionality (empty string, single number) remains intact.

		STRING CALCULATOR KATA - STEP 3
    Allow the Add method to handle new lines between numbers (instead of commas).

    RULES:
    1. The following input is valid: "1\n2,3" (will equal 6).
    2. Support both comma (,) and newline (\n) as delimiters.
    3. You do NOT need to handle invalid inputs like "1,\n" (at least not yet).

    STRING CALCULATOR KATA - STEP 4
    Support different delimiters defined at the start of the string.

    RULES:
    1. To change a delimiter, the input string will begin with a specific format: "//[delimiter]\n[numbers...]"
    2. Example: "//;\n1;2" should return 3.
    3. The first line is optional. If absent, use the default delimiters (comma and newline).
    4. All previous scenarios (empty string, "1,2", "1\n2,3") must still work.

    STRING CALCULATOR KATA - STEP 5
    Handle negative numbers.

    RULES:
    1. Calling Add with a negative number will throw an exception.
    2. The exception message must be "negatives not allowed: " followed by the negative number.
    3. If there are multiple negative numbers, show **all** of them in the exception message, separated by commas.
       Example: "-1,-2" -> throws exception with message "negatives not allowed: -1,-2"

		*/

		#endregion [ Instructions ]

		/*
    STRING CALCULATOR KATA - STEP 6
    Ignore numbers bigger than 1000.

    RULES:
    1. Numbers bigger than 1000 should be ignored (treated as 0).
    2. Example: "2,1001" should return 2.
    3. Example: "1000,2" should return 1002 (1000 is included).
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
			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData("1", 1)]
		[InlineData("9", 9)]
		[InlineData("0", 0)]
		[InlineData("11", 11)]
		public void Add_SingleNumber_ReturnsSameValue(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(expectedResult, result);
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
			Assert.Equal(expectedResult, result);
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
			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData("1\n2,3", 6)]
		[InlineData(",1\n2,3,", 6)]
		[InlineData("\n8,1\n2,3,\n20,", 34)]
		[InlineData("\n200\n,\n2200,3", 2403)]
		public void Add_NumbersInStringsWithMultipleDelimiters_ReturnsCorrectSum(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData("//;\n1;2", 3)]
		[InlineData("//|||\n1|||2|||3", 6)]
		[InlineData("//.\n1.2.5.111.11", 130)]
		public void Add_CustomDelimiter_ReturnsSum(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(expectedResult, result);
		}

		[Theory]
		[InlineData("-1", "negatives not allowed: -1")]
		[InlineData("-1, 1, -5", "negatives not allowed: -1, -5")]
		[InlineData("-0, 1, -5, 8, 8, -55, -555", "negatives not allowed: -0, -5, -55, -555")]
		public void Add_NegativeNumbers_ReturnsExceptionMessage(string input, string expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			var ex = Assert.Throws<ArgumentException>(() => sut.Add(input));

			// Then
			Assert.Equal(expectedResult, ex.Message);
		}

		[Theory]
		[InlineData("1000,1", 1001)]
		[InlineData("1001,0", 0)]
		[InlineData("1111,10", 10)]
		[InlineData("1002,9", 9)]
		[InlineData("1001,6,7", 13)]
		public void Add_NumbersGreaterThan1000SetToZero_ReturnsCorrectSum(string input, int expectedResult)
		{
			// Given
			var sut = new StringCalculator();

			// When
			int result = sut.Add(input);

			// Then
			Assert.Equal(expectedResult, result);
		}
	}
}