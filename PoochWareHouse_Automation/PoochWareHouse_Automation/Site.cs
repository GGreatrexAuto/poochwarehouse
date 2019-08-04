using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace PoochWareHouse_Automation
{
    public class Site
    {
        public void InitialiseChromeDriverNavigate(string url)
        {
            Driver._webdriver = new ChromeDriver();
            Driver._webdriver.Navigate().GoToUrl(url);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
            Driver._webdriver.Manage().Window.Maximize();
        }

        public void InitialiseFirefoxDriver(string url)
        {
            Driver._webdriver = new FirefoxDriver();
            Driver._webdriver.Navigate().GoToUrl(url);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
            Driver._webdriver.Manage().Window.Maximize();
        }

        public void InitialiseChromeDriver()
        {
            Driver._webdriver = new ChromeDriver();
        }

        public void NavigateAndMaximise(string url)
        {
            Driver._webdriver.Navigate().GoToUrl(url);
            Driver.WaitForUpTo(Config.GlobalTimeOut);
            Driver._webdriver.Manage().Window.Maximize();
        }

        public string GetWebPageUrl()
        {
            var currentPageUrl = Driver._webdriver.Url;
            return currentPageUrl;
        }

        public void GoToUrl(string url)
        {
            Driver._webdriver.Navigate().GoToUrl(url);
        }
    }
}
