using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class ProductsDetail
    {
        public static IWebElement ProductName =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"ProductSection-product-template\"]/div/div[2]/div[1]/h1"));

        public static IWebElement ProductSizeDropDown =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"SingleOptionSelector-0\"]"));

        public static IWebElement QuantityTextBox =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"Quantity-product-template\"]"));

        public static IWebElement AddToCartButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"product_form_1959276380211\"]/div[4]/button"));

        public static IWebElement BuyItNowButton => Driver._webdriver.FindElement(By.XPath("//*[@id=\"product_form_1959276380211\"]/div[4]/div/div/div/div/button[1]"));

    }
}
