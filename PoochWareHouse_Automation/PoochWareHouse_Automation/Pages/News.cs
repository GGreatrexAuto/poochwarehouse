﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class News
    {
        public static IWebElement NewsPageHeading => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-blog-template\"]/div[1]/header/h1"));
    }
}
