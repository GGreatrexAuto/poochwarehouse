using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.InformationalPages
{
    public static class ReturnsPolicy
    {
        public static IWebElement ContactUsLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[4]/a"));


    }
}
