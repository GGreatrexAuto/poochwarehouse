using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class CreateAccount
    {
        public static IWebElement FirstNameField => Driver._webdriver.FindElement(By.Id("RegisterForm-FirstName"));
        public static IWebElement LastNameField => Driver._webdriver.FindElement(By.Id("RegisterForm-LastName"));
        public static IWebElement EmailAddressField => Driver._webdriver.FindElement(By.Id("RegisterForm-email"));
        public static IWebElement PasswordField => Driver._webdriver.FindElement(By.Id("RegisterForm-password"));
        public static IWebElement CreateAccountButton => Driver._webdriver.FindElement(By.XPath("//*[@id=\"RegisterForm\"]/p/input"));
        public static IWebElement CreateAccountErrorSection => Driver._webdriver.FindElement(By.XPath("//*[@id=\"RegisterForm\"]/div"));
        public static IWebElement EmailErrorMessage => Driver._webdriver.FindElement(By.Id("RegisterForm-email-error"));
        public static IWebElement PasswordErrorMessage => Driver._webdriver.FindElement(By.Id("RegisterForm-password-error"));
    }
}
