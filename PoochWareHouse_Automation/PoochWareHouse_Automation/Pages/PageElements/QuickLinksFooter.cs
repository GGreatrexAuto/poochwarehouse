using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.PageElements
{
    public class QuickLinksFooter
    {
        public IWebElement QuickLinksHeading =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/p"));

        public IWebElement NewsletterHeading =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[2]/div/p"));

        public IWebElement AboutUsLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[1]/a"));

        public IWebElement FAQLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[2]/a"));

        public IWebElement DeliveryAndShippingLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[3]/a"));

        public IWebElement ReturnsPolicyLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[4]/a"));

        public IWebElement PrivacyPolicyLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[5]/a"));

        public IWebElement TermsOfUseLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[6]/a"));

        public IWebElement ContactUsLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[7]/a"));

        public IWebElement NewsLetterEmailAddressField => Driver._webdriver.FindElement(By.Id("ContactFooter-email"));

        public IWebElement SubscribeButton => Driver._webdriver.FindElement(By.Id("Subscribe"));

    }
}
