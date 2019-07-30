using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.News
{
    public static class NewsArticleSummerIsHere
    {
        public static IWebElement ImageLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[1]/a"));
    }
}
