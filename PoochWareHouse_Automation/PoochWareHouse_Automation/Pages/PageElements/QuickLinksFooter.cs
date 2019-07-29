using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages.PageElements
{
    public static class QuickLinksFooter
    {
        public static IWebElement QuickLinksHeading =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/p"));

        public static IWebElement NewsletterHeading =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[2]/div/p"));

        public static IWebElement AboutUsLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[1]/a"));

        public static IWebElement FAQLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[2]/a"));

        public static IWebElement DeliveryAndShippingLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[3]/a"));

        public static IWebElement ReturnsPolicyLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[4]/a"));

        public static IWebElement PrivacyPolicyLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[5]/a"));

        public static IWebElement TermsOfUseLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[6]/a"));

        public static IWebElement ContactUsLink =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"shopify-section-footer\"]/footer/div[1]/div/div[1]/div/ul/li[7]/a"));

        public static IWebElement NewsLetterEmailAddressField => Driver._webdriver.FindElement(By.Id("ContactFooter-email"));

        public static IWebElement SubscribeButton => Driver._webdriver.FindElement(By.Id("Subscribe"));
    }
}
