using UnitTestProject1.PageObjects;
using NUnit.Framework;
using UnitTestProject1.Tests;

namespace UnitTestProject1
{
    [TestFixture]
    class Multiply : BaseTest
    {
        [Test]
        public void MultiplySingleDigitNumbers()
        {
            calc.EnterNumber(3)
                .ClickMultiplyButton()
                .EnterNumber(4)
                .ClickEqualsButton();
            Assert.AreEqual(12, calc.GetCalculatorResults());
        }

        [Test]
        public void MultiplyTwoDigitNumbers()
        {
            calc.EnterNumber(24)
                .ClickMultiplyButton()
                .EnterNumber(17)
                .ClickEqualsButton();
            Assert.AreEqual(408, calc.GetCalculatorResults());
        }
    }
}
