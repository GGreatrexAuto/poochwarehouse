using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Helpers.Assertions;
using PoochWareHouse_Automation.PageActions;
using PoochWareHouse_Automation.Pages;
using PoochWareHouse_Automation.Pages.InformationalPages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "Login Navigation")]
    public sealed class LoginNavigationSteps
    {
        private LoginFormActions _loginFormActions;
        private readonly CommonStepHelper _commonStepHelper;

        //private readonly UrlHelper _urlHelper;
        //private readonly PreReleaseLoginHelper _preReleaseLoginHelper;
        //private readonly Site _site;



        public LoginNavigationSteps()
        {
            //_loginFormActions = new LoginFormActions();
            //_urlHelper = new UrlHelper();
            //_preReleaseLoginHelper = new PreReleaseLoginHelper();
            //_site = new Site();

            _commonStepHelper = new CommonStepHelper();
        }

        [Given(@"I access the '(.*)' page")]
        public void GivenIAccessingThePage(string pageName)
        {
            _commonStepHelper.AccessWebsite(pageName);
            //_site.InitialiseChromeDriver();

            //var url = _urlHelper.SetUrl(pageName);

            //_site.NavigateAndMaximise(url);

            //var currentUrl = _site.GetWebPageUrl();

            //var preReleaseMode = _preReleaseLoginHelper.IsWebsiteInPreReleaseMode(currentUrl);

            //_preReleaseLoginHelper.ByPassPreReleaseAndNavigateToPage(preReleaseMode, url);
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
