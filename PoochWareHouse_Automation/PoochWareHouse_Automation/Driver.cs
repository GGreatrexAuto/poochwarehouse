using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
