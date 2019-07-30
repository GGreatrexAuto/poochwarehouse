using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.News
{
    public static class NewsArticleSummerIsHere
    {
        public static IWebElement SummerCollectionImageLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[1]/a"));

        public static IWebElement TravelFlaskLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[5]/a"));

        public static IWebElement SummerCoolingVestLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[7]/a[1]"));

        public static IWebElement SummerCoolingScarfLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[7]/a[2]"));

        public static IWebElement ThickFurGroomingCombLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[15]/a"));

    }
}
