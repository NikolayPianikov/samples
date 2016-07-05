namespace dotNet40NUnitTests
{
    using System;

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

        [Test, Category("F")]
        public void TestFail()
        {
            Assert.Fail("Fail reason!!");
        }

        [Test, Category("ru")]
        public void TestRu()
        {
            Console.WriteLine("Все хорошо!!!");
        }
    }
}
