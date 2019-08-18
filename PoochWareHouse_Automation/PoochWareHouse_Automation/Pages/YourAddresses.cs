using OpenQA.Selenium;

namespace PoochWareHouse_Automation.Pages
{
    public static class YourAddresses
    {
        public static IWebElement YourAddressesHeading => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[1]/header/h1"));

        public static IWebElement ReturnToAccountDetailLink => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[1]/header/p[1]/a"));

        public static IWebElement AddNewAddressButton => Driver._webdriver.FindElement(By.Id("AddressNewButton"));

        public static IWebElement FirstName => Driver._webdriver.FindElement(By.Id("AddressFirstNameNew"));
        public static IWebElement LastName => Driver._webdriver.FindElement(By.Id("AddressLastNameNew"));
        public static IWebElement Company => Driver._webdriver.FindElement(By.Id("AddressCompanyNew"));
        public static IWebElement Address => Driver._webdriver.FindElement(By.Id("AddressAddress1New"));
        public static IWebElement Apartment => Driver._webdriver.FindElement(By.Id("AddressAddress2New"));
        public static IWebElement City => Driver._webdriver.FindElement(By.Id("AddressCityNew"));
        public static IWebElement Country => Driver._webdriver.FindElement(By.Id("AddressCountryNew"));
        public static IWebElement PostalCode => Driver._webdriver.FindElement(By.Id("AddressZipNew"));
        public static IWebElement Phone => Driver._webdriver.FindElement(By.Id("AddressPhoneNew"));
        public static IWebElement DefaultAddressCheckbox =>
            Driver._webdriver.FindElement(By.Id("address_default_address_new"));

        //public static IWebElement FullNameDefaultView => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/p/text()[1]"));
        //public static IWebElement CompanyDefaultView =>
        //    Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/p/text()[2]"));
        //public static IWebElement AddressDefaultView => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/p/text()[3]"));
        //public static IWebElement ApartmentDefaultView => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/p/text()[4]"));
        //public static IWebElement PostcodeCityDefaultView => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/p/text()[5]"));
        //public static IWebElement CountryDefaultView => Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/p/text()[6]"));

        public static IWebElement DefaultAddressView =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/p"));

        public static IWebElement AddAddressButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"address_form_new\"]/div[5]/input"));

        public static IWebElement CancelButton =>
            Driver._webdriver.FindElement(By.XPath("//*[@id=\"address_form_new\"]/div[6]/button"));

        public static IWebElement DeleteButton =>
            Driver._webdriver.FindElement(
                By.XPath("//*[@id=\"MainContent\"]/div[2]/div/div/ul/li/div[1]/ul/li[2]/button"));
    }
}
