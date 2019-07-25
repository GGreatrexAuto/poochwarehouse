using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.Collections
{
    public static class ProductsPagesGenericItems
    {
        public static IWebElement ProductsGenericPageHeading => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[1]/div[2]/h1/span"));

        public static IWebElement ProductsGenericPageDescription =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[2]"));

        public static IWebElement ProductCountText => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[3]/div/div/div[2]/span"));
        
    }
}