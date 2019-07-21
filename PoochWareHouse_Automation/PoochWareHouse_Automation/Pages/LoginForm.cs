using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class LoginForm
    {
        public static IWebElement LoginPageheader => Driver._webdriver.FindElement(By.Id("LoginHeading"));
    }
}
