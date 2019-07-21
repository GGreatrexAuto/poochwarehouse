using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class AllProducts
    {
        public AllProducts()
        {
                
        }

        public static IWebElement ProductsPageHeading => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[1]/div/h1/span"));

    }
}
