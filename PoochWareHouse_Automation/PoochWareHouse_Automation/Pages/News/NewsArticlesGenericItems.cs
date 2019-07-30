using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.News
{
    public static class NewsArticlesGenericItems
    {
        public static IWebElement ArticlePageHeading => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[1]/h1"));

        public static IWebElement BackToNewsButton => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/a"));

    }
}
