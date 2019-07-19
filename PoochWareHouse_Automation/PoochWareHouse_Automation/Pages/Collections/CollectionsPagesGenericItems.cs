﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.Collections
{
    public class CollectionsPagesGenericItems
    {
        public IWebElement CollectionsGenericPageHeading => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[1]/div[2]/h1/span"));

        public IWebElement CollectionsGenericPageDescription =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-collection-template\"]/div/header/div[2]"));
    }
}