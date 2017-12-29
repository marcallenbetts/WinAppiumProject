using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace UnitTestProject1.PageObjects
{
    class Calculator : BasePage
    {

        private WindowsElement clearMemoryButton;
        private WindowsElement memoryRecallButton;
        private WindowsElement memoryAddButton;
        private WindowsElement memorySubtractButton;
        private WindowsElement memoryStoreButton;

        private WindowsElement percentButton;
        private WindowsElement squareRootButton;
        private WindowsElement squareButton;
        private WindowsElement reciprocalButton;

        private WindowsElement divideByButton;
        private WindowsElement multiplyButton;
        private WindowsElement minusButton;
        private WindowsElement plusButton;
        private WindowsElement equalButton;

        private WindowsElement clearEntryButton;
        private WindowsElement clearButton;
        private WindowsElement backspaceButton;

        private WindowsElement calculatorResults;

        public Calculator() : base()
        {
            clearMemoryButton = session.FindElementByAccessibilityId("ClearMemoryButton");
            memoryRecallButton = session.FindElementByAccessibilityId("MemRecall");
            memoryAddButton = session.FindElementByAccessibilityId("MemPlus");
            memorySubtractButton = session.FindElementByAccessibilityId("MemMinus");
            memoryStoreButton = session.FindElementByAccessibilityId("memButton");

            percentButton = session.FindElementByAccessibilityId("percentButton");
            squareRootButton = session.FindElementByAccessibilityId("squareRootButton");
            squareButton = session.FindElementByAccessibilityId("xpower2Button");
            reciprocalButton = session.FindElementByAccessibilityId("invertButton");

            divideByButton = session.FindElementByAccessibilityId("divideButton");
            multiplyButton = session.FindElementByAccessibilityId("multiplyButton");
            minusButton = session.FindElementByAccessibilityId("minusButton");
            plusButton = session.FindElementByAccessibilityId("plusButton");
            equalButton = session.FindElementByAccessibilityId("equalButton");

            clearEntryButton = session.FindElementByAccessibilityId("clearEntryButton");
            clearButton = session.FindElementByAccessibilityId("clearButton");
            backspaceButton = session.FindElementByAccessibilityId("backSpaceButton");

            calculatorResults = session.FindElementByAccessibilityId("CalculatorResults");
        }

        public int AddNumbers(params int[] numbers)
        {
            for(int i = 0; i < numbers.Length-1; i++)
            {
                EnterNumber(numbers[i]);
                plusButton.Click();
            }
            EnterNumber(numbers[numbers.Length-1]);
            equalButton.Click();
            return GetCalculatorResults();
        }

        public Calculator EnterNumber(int number)
        {
            calculatorResults.SendKeys(number.ToString());
            return this;
        }

        public Calculator ClickMultiplyButton()
        {
            multiplyButton.Click();
            return this;
        }

        public Calculator ClickEqualsButton()
        {
            equalButton.Click();
            return this;
        }

        public Calculator ClickClearButton()
        {
            clearButton.Click();
            return this;
        }

        public int GetCalculatorResults()
        {
            String display = session.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Display is ", "").Replace(",", "");
            Int32.TryParse(display, out int results);
            return results;
        }


        public void CloseCalculator()
        {
            session.CloseApp();
            session = null;
        }

    }
}


