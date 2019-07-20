using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.PageElements
{
    public class HeaderMenu
    {
        public IWebElement PoochWareHouseLogo => Driver._webdriver.FindElement(By.Id("fsb.bar"));
        public IWebElement HomeLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[1]/a/span"));
        public IWebElement OnSaleLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[2]/a/span"));
        public IWebElement CollectionsDropDownLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[3]/button/span"));
        public IWebElement AllProductsLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"SiteNav\"]/li[4]/a/span"));
        public IWebElement Search => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/button[1]/svg"));
        public IWebElement Login => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/a[1]/svg"));
        public IWebElement Basket => Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-header\"]/div[2]/header/div/div[2]/div/a[2]/svg"));
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
