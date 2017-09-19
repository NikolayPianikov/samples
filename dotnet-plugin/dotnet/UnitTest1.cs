using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
		System.Console.WriteLine("Hello!!!");
        }

	[TestMethod]
        public void TestMethod2()
        {
		throw new System.Exception();
        }
    }
}
