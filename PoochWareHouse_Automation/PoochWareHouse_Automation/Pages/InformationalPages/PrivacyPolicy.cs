using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.InformationalPages
{
    public class PrivacyPolicy
    {
        public IWebElement PoochWarehouseHyperlinkOne => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[2]/a"));

        public IWebElement PoochWarehouseHyperlinkTwo => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div/div/div/div[2]/p[3]/a"));

        //allAboutCookiesLink

        //spotifyLegalLink

        //googlePrivacy

        //googleOptOut

        //facebookAdvertising
    }
}
