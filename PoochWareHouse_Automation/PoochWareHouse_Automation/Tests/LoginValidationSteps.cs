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

        [Given(@"an invalid email is entered")]
        public void GivenAnInvalidEmailIsEntered()
        {
            _loginFormActions.EnterCredentials(_credentials.InvalidEmailFormat());
        }

        [Given(@"an unregistered email account is used")]
        public void GivenAnUnregisteredEmailAccountIsUsed()
        {
            _loginFormActions.EnterCredentials(_credentials.EmailNotRegistered());
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

        [Then(@"an error will be displayed stating '(.*)'")]
        public void ThenAnErrorWillBeDisplayedStating(string expectedErrorMessage)
        {
            var actualErrorMessage = LoginForm.ErrorMessage.Text;

            Assert.AreEqual(expectedErrorMessage, actualErrorMessage, TestErrorHelper.ErrorsDoNotMatch(expectedErrorMessage, actualErrorMessage));
        }

        [Then(@"the my account page will not be displayed\.")]
        public void ThenTheMyAccountPageWillNotBeDisplayed_()
        {
            Assert.IsTrue(LoginForm.LoginPageheader.Displayed);
            Assert.AreEqual(LoginForm.LoginPageheader.Text, "Login");
        }

        [Then(@"the username field will be cleared")]
        public void ThenTheUsernameFieldWilBeCleared()
        {
            Assert.AreEqual(LoginForm.UserNameField.Text, string.Empty);
        }

        [Then(@"the username field colour will change")]
        public void ThenTheUsernameFieldColourWillChange()
        {
            //TODO
            var userNameBackGroundColour = LoginForm.UserNameField.GetCssValue("background-color");

            
        }

        [Then(@"the password field will be cleared")]
        public void ThenThePasswordFieldWilBeCleared()
        {
            Assert.AreEqual(LoginForm.PasswordField.Text, string.Empty);
        }

        [Then(@"the password field colour will change")]
        public void ThenThePasswordFieldColourWillChange()
        {
            //TODO
            var passwordBackGroundColout = LoginForm.PasswordField.GetCssValue("background-color");


        }


    }
}
