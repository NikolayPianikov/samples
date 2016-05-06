namespace dotNet40NUnitTests
{
	using System;

	using NUnit.Framework;

	[TestFixture]
	public class DotCoverTests
	{
		[Test]
		public void TestToInt()
		{
			// Assert.AreEqual(0, ToInt(double.NaN), "NaN string");
		}

		public static int ToInt(object userInput, int defaultValue = 0)
		{
			var result = defaultValue;
			if (userInput == null)
			{
				return result;
			}

			double value;
			if (!double.TryParse(userInput.ToString().Trim(), out value))
			{
				return result;
			}

			if (value <= int.MaxValue && value >= int.MinValue)
			{
				result = Convert.ToInt32(Math.Truncate(value));
			}

			return result;
		}
	}
}
