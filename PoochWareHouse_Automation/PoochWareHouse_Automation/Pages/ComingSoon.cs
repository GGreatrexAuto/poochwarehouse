using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class ComingSoon
    {
        public IWebElement NotifyEmailAddress => Driver._webdriver.FindElement(By.Id("PasswordNewsletterForm-email"));

    }
}
