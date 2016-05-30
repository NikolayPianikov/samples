namespace dotNet20NUnitTests
{
	using System;

	using dotNet20ClassLibrary;

	using NUnit.Framework;

	[TestFixture]
	public class RuTests
	{
		[Test, Category("Sucess")]
		public void TestDo()
		{
			Console.WriteLine("Привет !!!");
			new Class1().Do();
		}

        [Test]
        public void TestFailed()
        {            
            Assert.Fail("Привет !!!");
        }
    }

}
