using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.InformationalPages
{
    public static class Faq
    {
        public static IWebElement ReturnPolicyLink =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[16]/a"));
    }
}
