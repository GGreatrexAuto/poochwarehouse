using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.InformationalPages
{
    public static class PrivacyPolicy
    {
        public static IWebElement PoochWarehouseHyperlinkOne => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[2]/a"));

        public static IWebElement PoochWarehouseHyperlinkTwo => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[3]/a"));

        public static IWebElement AllAboutCookiesLink =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/ul[1]/li[1]/a"));

        public static IWebElement ShopifyLegalLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[12]/a"));

        public static IWebElement GooglePrivacy => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[13]/a[1]"));

        public static IWebElement GoogleOptOut => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[13]/a[2]"));

        public static IWebElement FacebookAdvertising => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/ul[3]/li/a"));
    }
}
