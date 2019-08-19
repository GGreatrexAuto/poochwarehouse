using NUnit.Framework;
using OpenQA.Selenium;
using PoochWareHouse_Automation.Pages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("deprecated")]
        [BeforeScenario("WIP")]
        public void IgnoredTest()
        {
            Assert.Ignore("The site is now live and this test no longer applies.");
        }

        [BeforeScenario("WIP")]
        public void TestWorkInProgress()
        {
            Assert.Ignore("The test is currently incomplete and should not be run.");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario(Order = 2)]
        public void AfterScenario()
        {
            if (Driver._webdriver != null)
            {
                Driver._webdriver.Quit();
            }
        }

        [AfterScenario(Order = 1)]
        [Scope(Tag ="DeleteAddress")]
        public void DeleteAddressAddedByTest()
        {
            YourAddresses.DeleteButton.Click();

            IAlert deleteAddressAlert = Driver._webdriver.SwitchTo().Alert();
            deleteAddressAlert.Accept();
        }
    }
}
