using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.PageElements
{
    public static class HeaderMenu
    {
        public static IWebElement PoochWareHouseLogo => Driver._webdriver.FindElement(By.Id("fsb.bar"));
        public static IWebElement HomeLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[1]/a/span"));
        public static IWebElement OnSaleLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[2]/a/span"));
        public static IWebElement CollectionsDropDownLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[3]/button/span"));
        public static IWebElement AllProductsLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[4]/a/span"));
        public static IWebElement Search => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/button[1]/svg"));
        public static IWebElement Login => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/a[1]/svg"));
        public static IWebElement Basket => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/a[2]/svg"));
        //public IWebElement CollectionsSubMenuBedsBlankets
        //public IWebElement CollectionsSubMenuBowlsFood
        //public IWebElement CollectionsSubMenuGrooming
        //public IWebElement CollectionsSubMenuCollarsLeads
        //public IWebElement CollectionsSubMenuHealthCare
        //public IWebElement CollectionsSubMenuTraining
        //public IWebElement CollectionsSubMenuSmallDogsPuppy
        //public IWebElement CollectionsSubMenuLargeDogs
        //public IWebElement CollectionsSubMenuToysGames
        //public IWebElement CollectionsSubMenuOnTheGo
        //public IWebElement CollectionsSubMenuSummerTime
        //public IWebElement CollectionsSubMenuWinterTime















    }
}
