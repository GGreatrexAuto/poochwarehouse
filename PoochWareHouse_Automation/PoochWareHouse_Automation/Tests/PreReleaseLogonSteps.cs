using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using PoochWareHouse_Automation.Pages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests
{
    [Binding]
    [Scope(Feature = "Pre Release Logon")]
    public class PreReleaseLogonSteps
    {
        private readonly Site _site = new Site();
        private readonly ComingSoon _comingSoon = new ComingSoon();

        public PreReleaseLogonSteps()
        {
            
        }

        [Given(@"I open the web page")]
        public void GivenIOpenTheWebPage()
        {
            _site.InitialiseChromeDriver();
        }

        [Given(@"I enter the email address")]
        public void GivenIEnterTheEmailAddress()
        {
            _comingSoon.NotifyEmailAddress.SendKeys("GG");

            
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Thread.Sleep(10000);
        }

        [Then(@"the result should be displayed on the screen")]
        public void ThenTheResultShouldBeOnTheScreen()
        {
            Assert.Fail();
        }


    }
}
