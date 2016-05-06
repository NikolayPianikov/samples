namespace dotNet40NUnitTests
{
	using System;
	using System.ComponentModel.Design;

	using dotNet40ClassLibrary;

	using NUnit.Framework;

	[TestFixture]
	public class OneTimeSetupTests
	{
		[OneTimeSetUp]
		public void OneTimeSetUp()
		{			
			throw new Exception("OneTimeSetUp exception");
		}

		[Test]
		public void TestDo1()
		{
			new Class1().Do();
		}

		[Test]
		public void TestDo2()
		{
			new Class1().Do();
		}
	}
}
