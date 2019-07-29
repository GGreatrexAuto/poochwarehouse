using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class ComingSoonLogonPage
    {
        public IWebElement PageTitle => Driver._webdriver.FindElement(By.Id("password-modal-heading"));

        public IWebElement PasswordField => Driver._webdriver.FindElement(By.Id("Password"));

        public IWebElement SubmitPasswordButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"login_form\"]/div/span/button"));

        public IWebElement ErrorSection => Driver._webdriver.FindElement(By.XPath("//*[@id=\"PasswordLoginForm-password-error\"]"));
    }
}
