using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.News
{
    public static class NewsArticleWhyHarness
    {
        public static IWebElement HarnessesLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[1]/a"));

        public static IWebElement PositiveReinforcementLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[3]/a"));

        public static IWebElement HarnessLinkTwo => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-article-template\"]/div[2]/p[16]/a"));
    }
}
