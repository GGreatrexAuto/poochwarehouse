using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.PageElements
{
    public static class CookieOverlay
    {
        public static IWebElement CookieBanner => Driver._webdriver.FindElement(By.XPath("/html/body/div[1]"));

        public static IWebElement AcceptCookieButton =>
            Driver._webdriver.FindElement(By.XPath("/html/body/div[1]/div/a"));
    }
}
