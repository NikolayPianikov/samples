namespace dotNet20NUnitTests
{
	using System.Collections.Generic;

	using NUnit.Framework;

	[TestFixture]
	public class PathProviderTests
	{
		public static IEnumerable<TestCaseData> TestDataList
		{
			get
			{
				var names = new[] {
					"simple-types.j.xml",
					"simple-types.k.xml",
					"simple-types.l.xml",
					"simple-types.m.xml",
				};

				foreach (var name in names)
				{
					yield return new TestCaseData(name).SetName(name);
				}				
			}
		}

		[Test, TestCaseSource("TestDataList")]
		public void ReproduceTeamCityReportingBug(string data)
		{
		}
	}
}
