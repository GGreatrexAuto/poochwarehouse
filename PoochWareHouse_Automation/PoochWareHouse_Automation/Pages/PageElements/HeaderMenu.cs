using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.PageElements
{
    public static class HeaderMenu
    {
        public static IWebElement PoochWareHouseLogo =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[1]/div/a");
        public static IWebElement HomeLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[1]/a/span"));
        public static IWebElement OnSaleLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[2]/a/span"));
        public static IWebElement CollectionsDropDownLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[3]/button/span"));
        public static IWebElement AllProductsLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[4]/a/span"));
        public static IWebElement Search => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/button[1]/svg"));
        public static IWebElement Login => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/a[1]"));
        public static IWebElement YourCart => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/a[2]"));
        public static IWebElement CollectionsSubMenuBedsBlankets => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[1]/a/span"));
        public static IWebElement CollectionsSubMenuBowlsFood => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[2]/a/span"));
        public static IWebElement CollectionsSubMenuGrooming => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[3]/a/span"));
        public static IWebElement CollectionsSubMenuCollarsLeads => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[4]/a/span"));
        public static IWebElement CollectionsSubMenuHealthCare => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[5]/a/span"));
        public static IWebElement CollectionsSubMenuTraining => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[6]/a/span"));
        public static IWebElement CollectionsSubMenuSmallDogsPuppy => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[7]/a/span"));
        public static IWebElement CollectionsSubMenuLargeDogs => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[8]/a/span"));
        public static IWebElement CollectionsSubMenuToysGames => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[9]/a/span"));
        public static IWebElement CollectionsSubMenuOnTheGo => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[10]/a/span"));
        public static IWebElement CollectionsSubMenuSummerTime => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[11]/a/span"));
        public static IWebElement CollectionsSubMenuWinterTime => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNavLabel-collections\"]/ul/li[12]/a/span"));
    }
}
