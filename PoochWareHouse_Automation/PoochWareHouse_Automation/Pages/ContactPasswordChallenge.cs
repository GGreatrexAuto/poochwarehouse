using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class ContactPasswordChallenge
    {
        public IWebElement ChallengeContactPasswordBannerText =>
            Driver._webdriver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/p"));
    }
}
