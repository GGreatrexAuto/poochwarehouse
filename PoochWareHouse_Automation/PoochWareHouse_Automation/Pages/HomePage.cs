using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class HomePage
    {
        public HomePage()
        {
            
        }

        public IWebElement HomePageImageFrame =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-1561397436218\"]"));
    }
}
