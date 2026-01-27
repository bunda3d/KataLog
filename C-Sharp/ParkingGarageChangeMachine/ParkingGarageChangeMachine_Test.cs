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
		[InlineData(100, 125, new int[] { 25 })]
		[InlineData(100, 126, new int[] { 25, 1 })]
		private MakeChange_Phase1(int amountDue, int amountPaid, int[] expectedChange)
		{
			var machine = new ParkingGarageChangeMachine();
			var change = machine.MakeChange(amountDue, amountPaid);
			Assert.Equal(expectedChange, change);
		}
	}
}