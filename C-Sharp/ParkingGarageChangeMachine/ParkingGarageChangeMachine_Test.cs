namespace ParkingGarageChangeMachine
{
	public class ParkingGarageChangeMachine_Test
	{
		/*

		PHASE 1

		1. The machine accepts an amount due and an amount paid.
		2. Return the correct change as a list of denominations.
		3. Use U.S. denominations:
				25¢, 10¢, 5¢, 1¢
		4. Always return the fewest coins possible.

		PHASE 2 - Consultant Twist

		The client adds a rule:
			“We want to discourage use of pennies.
			Only use pennies if absolutely necessary.”

		PHASE 3 - Another Twist

		The garage introduces a new coin:
			12¢ coin (yes, really)
		And they want the algorithm to adapt without rewriting everything.

		*/

		[Theory]
		[InlineData(100, 100, new int[] { })]
		[InlineData(175, 200, new int[] { 25 })]
		[InlineData(100, 126, new int[] { 25, 1 })]
		public void MakeChange_Phase1_ExpectedChangeMatchesChangeReturned(int amountDue, int amountPaid, int[] expectedChange)
		{
			var machine = new ParkingGarageChangeMachine();
			var change = machine.MakeChange(amountDue, amountPaid);
			Assert.Equal(expectedChange, change);
		}

		[Theory]
		[InlineData(100, 90)]
		public void MakeChange_Phase1_PaymentLessThanAmountDueReturnsErrorMsg(int amountDue, int amountPaid)
		{
			var machine = new ParkingGarageChangeMachine();
			var exception = Assert.Throws<ArgumentException>(() => machine.MakeChange(amountDue, amountPaid));
			Assert.Equal("Amount paid must be greater than or equal to amount due.", exception.Message);
		}

		[Theory]
		[InlineData(100, 130, new int[] { 25, 5 })] // 30 cents should be 1 quarter and 1 nickel, not 6 nickels, 30 pennies, etc...
		[InlineData(175, 300, new int[] { 25, 25, 25, 25, 25 })] // { 25, 25, 25, 25, 5, 5, 5, 5, 5 } should fail
		public void MakeChange_Phase1_ExpectedChangeIsLeastAmountOfCoins(int amountDue, int amountPaid, int[] expectedChange)
		{
			var machine = new ParkingGarageChangeMachine();
			var change = machine.MakeChange(amountDue, amountPaid);
			Assert.Equal(expectedChange, change);
		}

		[Theory]
		[InlineData(100, 103, new int[] { 1, 1, 1 })] // similar to MakeChange_Phase1_ExpectedChangeIsLeastAmountOfCoins, the smallest denomination should only be returned when necessary
		[InlineData(150, 157, new int[] { 5, 1, 1 })] // only 2 pennies should be returned, not 7 pennies
		public void MakeChange_Phase2_DiscouragePennies(int amountDue, int amountPaid, int[] expectedChange)
		{
			var machine = new ParkingGarageChangeMachine();
			var change = machine.MakeChange(amountDue, amountPaid);
			Assert.Equal(expectedChange, change);
		}

		[Theory]
		[InlineData(100, 103, new int[] { 5 })]          // 3¢ ? round up to 5¢
		[InlineData(150, 157, new int[] { 10 })]         // 7¢ ? round up to 10¢
		[InlineData(100, 120, new int[] { 10, 10 })]     // 20¢ ? already multiple of 5
		public void MakeChange_Phase2_NoPennies_RoundUpToNearestFive(
		int amountDue, int amountPaid, int[] expectedChange)
		{
			var machine = new ParkingGarageChangeMachine();
			var change = machine.MakeChangePhase2(amountDue, amountPaid);
			Assert.Equal(expectedChange, change);
		}
	}
}