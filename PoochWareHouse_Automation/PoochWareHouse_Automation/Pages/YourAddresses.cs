using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class YourAddresses
    {
        public static IWebElement YourAddressesHeading => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[1]/header/h1"));

        public static IWebElement ReturnToAccountDetailLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[1]/header/p[1]/a"));

        public static IWebElement AddAddressButton => Driver._webdriver.FindElement(By.Id("AddressNewButton"));
    }
}
