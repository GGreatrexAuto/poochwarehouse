using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
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

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (Driver._webdriver != null)
            {
                Driver._webdriver.Quit();
            }
        }
    }
}
