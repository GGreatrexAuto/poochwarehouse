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
        private readonly ContactPasswordChallenge _contactPasswordChallenge = new ContactPasswordChallenge();
        private readonly string _preReleaseUrl = Config.PoochwarehousePreReleasePage;

        [Given(@"I access the Poochwarehouse.co.uk website")]
        public void GivenIOpenTheWebPage()
        {
            _site.InitialiseChromeDriver(_preReleaseUrl);
        }

        [Given(@"the store is not online for business")]
        public void GivenTheStoreIsNotOnlineForBusiness()
        {
            var expectedComingSoonSubHeader = "COMING SOON";

            Assert.AreEqual(expectedComingSoonSubHeader, _comingSoon.ComingSoonPageHeader.Text, "Expected the PoochWarehouse pre-release/coming soon webpage to be displayed but it was not.");
        }
        
        [Given(@"the customer enters a valid email address to be notified of launch")]
        public void GivenIEnterTheEmailAddress()
        {
            _comingSoon.NotifyEmailAddress.SendKeys(Config.ValidContactEmail);
        }

        [When(@"I press the notify me button")]
        public void WhenIPressAdd()
        {
            _comingSoon.NotifyMeButton.Click();
        }

        [Then(@"the challenge contact password screen will be displayed")]
        public void ThenTheResultShouldBeOnTheScreen()
        {
            var expectedBannerText = "To continue, let us know you're not a robot.";

            Assert.AreEqual(expectedBannerText, _contactPasswordChallenge.ChallengeContactPasswordBannerText.Text);
        }


    }
}
