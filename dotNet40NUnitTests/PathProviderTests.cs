namespace dotNet40NUnitTests
{
	using System.Collections.Generic;
	using System.Linq;

	using NUnit.Framework;

	[TestFixture]
	public class PathProviderTests
	{
		public static IEnumerable<TestCaseData> TestDataList
		{
			get
			{
				return new[] {
					"simple-types.j.xml",
					"simple-types.k.xml",
					"simple-types.l.xml",
					"simple-types.m.xml",
				}.Select(
					x => new TestCaseData(x).SetName(x));
			}
		}

		[Test, TestCaseSource("TestDataList")]
		public void ReproduceTeamCityReportingBug(string data)
		{
		}
	}
}
