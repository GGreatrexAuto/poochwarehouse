using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class ComingSoon
    {
        public IWebElement ComingSoonPageHeader => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-password-header\"]/div/span"));

        public IWebElement NotifyEmailAddress => Driver._webdriver.FindElement(By.Id("PasswordNewsletterForm-email"));

        public IWebElement NotifyMeButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"ContactPassword\"]/div/span[1]/button"));

        public IWebElement EnterUsingPasswordButton =>
            Driver._webdriver.FindElement(By.XPath("/html/body/div[2]/header/div/div/a"));

        public IWebElement NotifyEmailError =>
            Driver._webdriver.FindElement(By.Id("Passw0rdNewsletterForm-email-error"));
        
    }
}
