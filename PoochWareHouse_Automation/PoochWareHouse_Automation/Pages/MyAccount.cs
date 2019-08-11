using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class MyAccount
    {
        public static IWebElement MyAccountPageHeading => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div[1]/h1"));

        public static IWebElement LogOutLink => Driver._webdriver.FindElement(By.Id("customer_logout_link"));

        public static IWebElement ViewAddressButton => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div[2]/div[2]/p/a"));
    }
}
