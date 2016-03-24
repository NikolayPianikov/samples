namespace dotNet40NUnitTests
{
	using dotNet40ClassLibrary;

	using NUnit.Framework;

	[TestFixture]
	public class Class1Tests
	{
		[Test]
		public void TestDo()
		{
			new Class1().Do();
		}
	}
}
