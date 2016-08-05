namespace dotNet20NUnitTests
{
	using System;

	using dotNet20ClassLibrary;

	using NUnit.Framework;

	[TestFixture]
	public class Class1Tests
	{
		[Test, Category("Sucess")]
		public void TestDo()
		{
			Console.WriteLine($"Console output !!! IntPtr.Size={IntPtr.Size}");
			new Class1().Do();		    
		}
	}

}
