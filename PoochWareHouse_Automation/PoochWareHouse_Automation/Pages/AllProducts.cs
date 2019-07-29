using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class AllProducts
    {
        public AllProducts()
        {
                
        }

        public static IWebElement ProductsPageHeading => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[1]/div/h1/span"));

        public static IWebElement PageNumberLabel =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"Collection\"]/ul[2]/li[2]"));
        
        public static IWebElement PreviousPageButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"Collection\"]/ul[2]/li[1]/a"));
        
        public static IWebElement NextPageButton => Driver._webdriver.FindElement(By.XPath("//*[@id=\"Collection\"]/ul[2]/li[3]/a"));

        public static IWebElement NextPageButtonDisabled => Driver._webdriver.FindElement(By.XPath("//*[@id=\"Collection\"]/ul[2]/li[3]/button"));

        public static IWebElement PreviousPageButtonDisabled =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"Collection\"]/ul[2]/li[1]/button"));

        public static IWebElement ProductCountText => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[2]/div/div/div[2]/span"));
    }
}
