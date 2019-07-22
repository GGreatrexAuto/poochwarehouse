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
        public void InitialiseChromeDriver(string url)
        {
            Driver._webdriver = new ChromeDriver();
            Driver._webdriver.Navigate().GoToUrl(url);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
            Driver._webdriver.Manage().Window.Maximize();
        }

        public void InitialiseFirefoxDriver(string url)
        {
            Driver._webdriver = new FirefoxDriver();
            Driver._webdriver.Navigate().GoToUrl(url);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
            Driver._webdriver.Manage().Window.Maximize();
        }
    }
}
