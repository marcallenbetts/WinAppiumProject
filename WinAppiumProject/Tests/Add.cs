using UnitTestProject1.PageObjects;
using NUnit.Framework;
using UnitTestProject1.Tests;

namespace UnitTestProject1
{
    [TestFixture]
    class Add : BaseTest
    {

        [Test]
        public void AddNumbers()
        {
            int results = calc.AddNumbers(1, 2, 3, 4);
            Assert.AreEqual(10, results);
        }

        [Test]
        public void AddMoreNumbers()
        {
            int results = calc.AddNumbers(32554, 23, 896784, 324);
            Assert.AreEqual(929685, results);
        }

    }
}
