using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.News
{
    public static class News
    {
        public static IWebElement NewsPageHeading => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-blog-template\"]/div[1]/header/h1"));

        public static IWebElement SummerIsHereImage =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"ArticleImageWrapper-8912175155\"]/div"));

        public static IWebElement SummerIsHereReadMoreButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-blog-template\"]/div[2]/ul/li[1]/div/ul/li/a"));

        public static IWebElement PoochCarSafetyImage =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"ArticleImageWrapper-8912273459\"]/div"));

        public static IWebElement PoochCarSafetyReadMoreButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-blog-template\"]/div[2]/ul/li[2]/div/ul/li/a"));

    }
}
