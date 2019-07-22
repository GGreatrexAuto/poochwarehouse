using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
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
        private readonly ComingSoonLogonPage _comingSoonLogonPage = new ComingSoonLogonPage();
        private readonly string _preReleaseUrl = Urls.PoochWarehousePreReleasePage;

        [Given(@"I access the Poochwarehouse.co.uk website")]
        [Given(@"poochwarehouse is not yet live")]
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

        [Given(@"a potential customer attempts to access the site")]
        [Given(@"the customer selects the Enter Using Password button")]
        public void GivenTheCustomerSelectsTheEnterUsingPasswordButton()
        {
            _comingSoon.EnterUsingPasswordButton.Click();
        }

        [Given(@"the login page is displayed")]
        public void GivenTheLoginPageIsDisplayed()
        {
            var expectedPageTitle = "ENTER STORE USING PASSWORD";
            var actualPageTitle = _comingSoonLogonPage.PageTitle.Text;

            Assert.AreEqual(expectedPageTitle, actualPageTitle,  
                $@"The actual page title [{actualPageTitle}] did not match the expected page title [{expectedPageTitle}].");
        }

        [Given(@"the customer enters a valid password")]
        public void GivenTheCustomerEntersAValidPassword()
        {
            _comingSoonLogonPage.PasswordField.SendKeys(Config.PreReleasePassword);
        }

        [Given(@"enters an incorrect password")]
        public void GivenEntersAnIncorrectPassword()
        {
            var invalidPassword = "invalid";

            _comingSoonLogonPage.PasswordField.SendKeys(invalidPassword);
        }


        [When(@"the enter button is selected")]
        public void WhenTheEnterButtonIsSelected()
        {
            _comingSoonLogonPage.SubmitPasswordButton.Click();
        }

        [Then(@"the poochwarehouse homepage will be displayed")]
        public void ThenThePoochwarehouseHomepageWillBeDisplayed()
        {
            Assert.IsTrue(HomePage.HomePageImageFrame.Displayed, "The homepage (main image frame) was not displayed.");
            Assert.IsTrue(HomePage.TestimonialHeading.Displayed, "The homepage testimonial subheading was not displayed");
            Assert.IsTrue(HomePage.CollectionsSubHeading.Displayed, "The homepage collections subheading was not displayed");
        }

        [Then(@"an error will be displayed")]
        public void ThenAnErrorWillBeDisplayed()
        {
            var expectedInvalidPasswordError = "Password incorrect, please try again.";
            var actualInvalidPasswordError = _comingSoonLogonPage.ErrorSection.Text;

            Assert.Multiple(() =>
            {
                Assert.IsTrue(_comingSoonLogonPage.ErrorSection.Displayed,
                    "Expected an error to be displayed, but it was not.");
                Assert.AreEqual(expectedInvalidPasswordError, actualInvalidPasswordError,
                    $@"The expected error [{expectedInvalidPasswordError}] did not match the actual [{actualInvalidPasswordError}].");
            });
    }

        [Then(@"the homepage will not be displayed")]
        public void ThenTheHomepageWillNotBeDisplayed()
        {
            GivenTheLoginPageIsDisplayed();
        }


    }
}
