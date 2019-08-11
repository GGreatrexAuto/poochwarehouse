using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
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

        [When(@"I enter '(.*)' login credentials")]
        public void GivenIEnterLoginCredentials(string validity)
        {
            if (validity == "valid")
            {
                _loginFormActions.LoginUserAccount(LoginConfiguration.ValidUserName, LoginConfiguration.ValidPassword);
            }
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


    }
}
