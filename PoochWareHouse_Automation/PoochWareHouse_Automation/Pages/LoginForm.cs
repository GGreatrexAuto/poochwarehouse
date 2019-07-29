using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class LoginForm
    {
        public static IWebElement LoginPageheader => Driver._webdriver.FindElement(By.Id("LoginHeading"));
    }
}
