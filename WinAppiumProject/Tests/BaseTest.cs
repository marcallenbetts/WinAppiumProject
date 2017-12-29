using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.PageObjects;

namespace UnitTestProject1.Tests
{
    abstract class BaseTest
    {
        protected Calculator calc;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            calc.ClickClearButton();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            calc.CloseCalculator();
        }

    }
}
