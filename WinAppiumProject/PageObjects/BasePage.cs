using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObjects
{

    class BasePage
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        protected const string CalculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
        protected static WindowsDriver<WindowsElement> session;

        public BasePage() 
        {
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", CalculatorAppId);
            appCapabilities.SetCapability("platformName", "Windows");
            appCapabilities.SetCapability("deviceName", "WindowsPC");
            session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);

        }


    }

    
}
