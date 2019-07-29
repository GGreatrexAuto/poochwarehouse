using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.InformationalPages
{
    public static class InformationalPagesGenericItems
    {
        public static IWebElement GenericPageHeading =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[1]/h1"));
    }
}
