namespace dotNet20NUnitTests
{
    using System;

    using dotNet20ClassLibrary;

    using NUnit.Framework;

    [TestFixture]
    public class SetupTests
    {
        [SetUp]
        public void SetUp()
        {
            throw new Exception("SetUp exception");
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
