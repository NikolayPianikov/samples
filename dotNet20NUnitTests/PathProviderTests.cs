namespace dotNet20NUnitTests
{
	using System;
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
					"simple_Name",
					"simple-types.j.xml",
					"simple-types k.xml",
					"simple-types \"l.\"xml",
					"simple-types \".m 'xml",
				};

				foreach (var name in names)
				{
					yield return new TestCaseData("arg1", "arg 2", "arg.3").SetName(name);
				}				
			}
		}

		[Test, TestCaseSource("TestDataList")]
		public void ReproduceTeamCityReportingBug(string arg1, string arg2, string arg3)
		{
			Console.WriteLine("Console output !!!");
		}

		[Test]
		[TestCase("arg1", "arg 2", "arg.3")]
		public void ReproduceTeamCityReportingBugForCases(string arg1, string arg2, string arg3)
		{
			Assert.Inconclusive("Inconclusive output !!!");
		}
	}
}
