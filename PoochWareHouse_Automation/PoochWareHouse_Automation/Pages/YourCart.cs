using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class YourCart
    {
        public static IWebElement YourCartPageHeading =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-cart-template\"]/div/div/h1"));
    }
}
