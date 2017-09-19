using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VSTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestPlus()
        {
            Console.WriteLine("##teamcity[buildStatus text='Let rock reign!']");
            Assert.AreEqual(Calculator.Plus(1, 5), 6, "Wrong result");
        }
    }
}
