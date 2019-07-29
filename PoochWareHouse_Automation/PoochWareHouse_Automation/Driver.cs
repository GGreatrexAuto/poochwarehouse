using System;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation
{
    public static class Driver
    {
        public static IWebDriver _webdriver;

        public static void WaitForUpTo(int seconds)
        {
            _webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        
    }
}
