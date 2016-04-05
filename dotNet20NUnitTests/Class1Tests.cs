namespace dotNet20NUnitTests
{
	using System;

	using dotNet20ClassLibrary;

	using NUnit.Framework;

	[TestFixture]
	public class Class1Tests
	{
		[Test]
		public void TestDo()
		{
			Console.WriteLine("Console output !!!");
			new Class1().Do();
		}
	}

}
