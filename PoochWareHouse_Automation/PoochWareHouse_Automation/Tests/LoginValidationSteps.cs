using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.PageActions;
using PoochWareHouse_Automation.Pages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests
{
    [Binding]
    [Scope(Feature = "Login Validation")]
    public sealed class LoginValidationSteps
    {
        private LoginFormActions _loginFormActions;
        private readonly CommonStepHelper _commonStepHelper;
        private LoginConfiguration _credentials;

        public LoginValidationSteps()
        {
            _loginFormActions = new LoginFormActions();
            _commonStepHelper = new CommonStepHelper();
            _credentials = new LoginConfiguration();
        }

        [Given(@"I access the login page")]
        public void GivenIAccessTheLoginPage()
        {
            _commonStepHelper.AccessWebsite("login");
            CookieOverlayActions.ClearCookieOverlay();
        }

        [Given(@"valid credentials are entered")]
        public void GivenValidCredentialsAreEntered()
        {
            _loginFormActions.EnterCredentials(_credentials.ValidCredentials());
        }

        [Given(@"an incorrect password is entered with a registered email address")]
        public void GivenAnIncorrectPasswordIsEnteredWithARegisteredEmailAddress()
        {
            _loginFormActions.EnterCredentials(_credentials.IncorrectPassword());
        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            Login.ClickLoginButton();
        }

        [Then(@"the my account page will be displayed")]
        public void ThenTheMyAccountPageWillBeDisplayed()
        {
            Assert.IsTrue(MyAccount.MyAccountPageHeading.Displayed,TestErrorHelper.ExpectedItemNotDisplayed("heading", "My Account"));
        }


    }
}
