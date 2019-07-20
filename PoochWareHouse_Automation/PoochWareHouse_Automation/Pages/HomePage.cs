using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class HomePage
    {
        public static IWebElement HomePageImageFrame =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-1561397436218\"]"));

        public static IWebElement CollectionsSubHeading =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[1]/h2"));

        public static IWebElement CollectionsBedsBlankets => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[1]/div/a/div[2]/div"));

        public static IWebElement CollectionsBowlsFood => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[2]/div/a/div[2]/div"));

        public static IWebElement CollectionsGrooming => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[3]/div/a/div[2]/div"));

        public static IWebElement CollectionsCollarsLeads => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[4]/div/a/div[2]/div"));

        public static IWebElement CollectionsHealthCare => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[5]/div/a/div[2]/div"));

        public static IWebElement CollectionsTraining => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[6]/div/a/div[2]/div"));

        public static IWebElement CollectionsSmallDogsPuppies => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[7]/div/a/div[2]/div"));

        public static IWebElement CollectionsLargeDogs => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[8]/div/a/div[2]/div"));

        public static IWebElement CollectionsToysGames => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[9]/div/a/div[2]/div"));

        public static IWebElement CollectionsOnTheGo => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[10]/div/a/div[2]/div"));

        public static IWebElement CollectionsSummerTime => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[11]/div/a/div[2]/div"));

        public static IWebElement CollectionsWinterTime => Driver._webdriver.FindElement(
            By.XPath("//*[@id=\"shopify-section-1561394304928\"]/div/div[2]/ul/li[12]/div/a/div[2]/div"));

        public static IWebElement FreeShippingHeading =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-1561412313836\"]/div/div/div/div/h2"));

        public static IWebElement TestimonialHeading =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"shopify-section-1561398995819\"]/div/div[1]/h2"));
    }
}
