﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.InformationalPages
{
    public class ContactUs
    {
        public IWebElement ContactUsPageHeading =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[1]/h1"));

    }
}
