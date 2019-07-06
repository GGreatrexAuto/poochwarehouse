using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PoochWareHouse_Automation
{
    public class Site
    {
        public void InitialiseChromeDriver()
        {
            Driver._webdriver = new ChromeDriver();
            Driver._webdriver.Navigate().GoToUrl(Config.SiteToTest);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
        }

        public void InitialiseFirefoxDriver()
        {
            Driver._webdriver = new FirefoxDriver();
            Driver._webdriver.Navigate().GoToUrl(Config.SiteToTest);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
        }
    }
}
