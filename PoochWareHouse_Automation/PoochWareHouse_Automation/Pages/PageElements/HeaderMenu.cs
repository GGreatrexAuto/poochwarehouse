using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.PageElements
{
    public class HeaderMenu
    {
        private IWebElement PoochWareHouseLogo => Driver._webdriver.FindElement(By.Id("fsb.bar"));
    }
}
