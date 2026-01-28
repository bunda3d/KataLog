namespace StringCalculator
{
	public class StringCalculatorTests
	{
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

		[Fact]
		public void Add_EmptyString_ReturnsZero()
		{
			// Arrange
			var sut = new StringCalculator();

			// Act
			int result = sut.Add("");

			// Assert
			Assert.Equal(0, result);
		}
	}
}