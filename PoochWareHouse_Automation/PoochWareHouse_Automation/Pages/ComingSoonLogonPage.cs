﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public class ComingSoonLogonPage
    {
        public IWebElement PageTitle => Driver._webdriver.FindElement(By.Id("password-modal-heading"));

        public IWebElement PasswordField => Driver._webdriver.FindElement(By.Id("Password"));

        public IWebElement SubmitPasswordButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"login_form\"]/div/span/button"));

        public IWebElement ErrorSection => Driver._webdriver.FindElement(By.Id("PasswordLoginForm-password-error"));
    }
}
