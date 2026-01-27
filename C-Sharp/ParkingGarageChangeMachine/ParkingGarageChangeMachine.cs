namespace ParkingGarageChangeMachine
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

	internal class ParkingGarageChangeMachine
	{
		public List<int> Denominations { get; set; } = new List<int>() { 25, 10, 5, 1 };

		public List<int> MakeChange(int amountDue, int amountPaid)
		{

			if (amountDue == null || amountPaid == null)
			{
				throw new ArgumentNullException("Amount due and amount paid cannot be null.");
			}
			if (amountPaid < amountDue)
			{
				throw new ArgumentException("Amount paid must be greater than or equal to amount due.");
			}

			return Denominations;
		}
	}
}