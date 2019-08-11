using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.PageActions;
using PoochWareHouse_Automation.Pages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "Login Navigation")]
    public sealed class LoginNavigationSteps
    {
        private LoginFormActions _loginFormActions;
        private readonly CommonStepHelper _commonStepHelper;

        public LoginNavigationSteps()
        {
            _commonStepHelper = new CommonStepHelper();
        }

        [Given(@"I access the '(.*)' page")]
        public void GivenIAccessingThePage(string pageName)
        {
            _commonStepHelper.AccessWebsite(pageName);
        }

        [Given(@"I clear the cookie notice")]
        public void GivenIClearTheCookieOverlay()
        {
            CookieOverlayActions.ClearCookieOverlay();
        }

        [Given(@"I access the My Account page")]
        public void GivenIAccessTheMyAccountPage()
        {
            _commonStepHelper.AccessWebsite("login");
            GivenIClearTheCookieOverlay();
            GivenIEnterLoginCredentials("valid");
        }


        [When(@"I enter '(.*)' login credentials")]
        public void GivenIEnterLoginCredentials(string validity)
        {
            if (validity == "valid")
            {
                _loginFormActions.LoginUserAccount(LoginConfiguration.ValidUserName, LoginConfiguration.ValidPassword);
            }
        }

        [When(@"I select the view addresses button")]
        public void WhenISelectTheViewAddressesButton()
        {
            MyAccountNavigation.ClickViewAddressesButton();
        }

        [When(@"I select the log out link")]
        public void WhenISelectTheLogOutLink()
        {
            MyAccountNavigation.ClickLogOutLink();
        }
        
        [Then(@"the '(.*)' page will be displayed")]
        public void ThenThePageWillBeDisplayed(string expectedPage)
        {
            var itemType = "page heading";

            Assert.IsTrue(MyAccount.MyAccountPageHeading.Displayed,
                TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedPage));

            var actualHeading = MyAccount.MyAccountPageHeading.Text;

            Assert.AreEqual(expectedPage, actualHeading,
                TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedPage, actualHeading));
        }

        [Then(@"the Your Addresses page will be displayed")]
        public void ThenTheYourAddressesPageWillBeDisplayed()
        {
            var expectedHeading = "Your Addresses";
            var itemType = "page heading";

            Assert.IsTrue(YourAddresses.YourAddressesHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));

            var actualHeading = YourAddresses.YourAddressesHeading.Text;

            Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedHeading, actualHeading));
        }

        [Then(@"the website homepage will be displayed")]
        public void ThenTheWebsiteHomepageWillBeDisplayed()
        {
            Assert.IsTrue(HomePage.HomePageImageFrame.Displayed, "The homepage (main image frame) was not displayed.");
            Assert.IsTrue(HomePage.TestimonialHeading.Displayed, "The homepage testimonial subheading was not displayed");
            Assert.IsTrue(HomePage.CollectionsSubHeading.Displayed, "The homepage collections subheading was not displayed");
        }
    }
}
