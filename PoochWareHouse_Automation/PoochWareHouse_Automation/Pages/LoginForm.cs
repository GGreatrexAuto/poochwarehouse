using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class LoginForm
    {
        public static IWebElement LoginPageheader => Driver._webdriver.FindElement(By.Id("LoginHeading"));

        public static IWebElement ForgotPasswordLink => Driver._webdriver.FindElement(By.Id("RecoverPassword"));

        public static IWebElement CreateAccountLink => Driver._webdriver.FindElement(By.Id("customer_register_link"));

        public static IWebElement LoginButton => Driver._webdriver.FindElement(By.XPath("//*[@id=\"customer_login\"]/div/input"));

        public static IWebElement UserNameField => Driver._webdriver.FindElement(By.Id("CustomerEmail"));

        public static IWebElement PasswordField => Driver._webdriver.FindElement(By.Id("CustomerPassword"));
    }
}
