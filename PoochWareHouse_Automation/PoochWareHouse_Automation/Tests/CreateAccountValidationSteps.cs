using System;
using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.PageActions;
using PoochWareHouse_Automation.Pages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests
{
    [Binding]
    [Scope(Feature = "Create Account Validation")]

    public sealed class CreateAccountValidationSteps
    {
        private CommonStepHelper _commonStepHelper = new CommonStepHelper();
        private CreateAccountConfiguration _createAccount = new CreateAccountConfiguration();

        [Given(@"I access the create account page")]
        public void GivenIAccessTheCreateAccountPage()
        {
            _commonStepHelper.AccessWebsite("register");
            CookieOverlayActions.ClearCookieOverlay();
        }

        [Given(@"do not enter an email address")]
        public void GivenDoNotEnterAnEmailAddress()
        {
            CreateAccount.EmailAddressField.Clear();
        }

        [Given(@"enter a valid password")]
        public void GivenEnterAValidPassword()
        {
            CreateAccount.PasswordField.SendKeys(_createAccount.ValidPassword().Password);
        }

        [Given(@"enter a valid email address")]
        public void GivenEnterAValidEmailAddress()
        {
            CreateAccount.EmailAddressField.SendKeys(_createAccount.ValidEmail().EmailAddress);
        }

        [Given(@"do not enter a password")]
        public void GivenDoNotEnterAPassword()
        {
            CreateAccount.PasswordField.Clear();
        }

        [Given(@"enter an email address that has previously been registered")]
        public void GivenEnterAnEmailAddressThatHasPreviouslyBeenRegistered()
        {
            CreateAccount.EmailAddressField.SendKeys(_createAccount.ExistingAccount().EmailAddress);
        }

        [Given(@"enter a password less than 5 characters in length")]
        public void GivenEnterAPasswordLessThanCharactersInLength()
        {
            CreateAccount.PasswordField.SendKeys(_createAccount.PasswordTooShort().Password);
        }

        [Given(@"enter an invalid formatted email address")]
        public void GivenEnterAnInvalidFormattedEmailAddress()
        {
            CreateAccount.EmailAddressField.SendKeys(_createAccount.InvalidEmailFormat().EmailAddress);
        }


        [When(@"I press create account button")]
        public void WhenIPressCreateAccountButton()
        {
            CreateAccount.CreateAccountButton.Click();
        }

        [Then(@"the error '(.*)' will be displayed beneath the '(.*)' field")]
        public void ThenTheErrorTBeBlank_EmailField(string expectedError, string erroredField)
        {
            string actualError;

            if (erroredField == "email")
            {
                actualError = CreateAccount.EmailErrorMessage.Text;
            }
            else if (erroredField == "password")
            {
                actualError = CreateAccount.PasswordErrorMessage.Text;
            }
            else
            {
                actualError = String.Empty;
                Console.WriteLine($"Errored field value [{erroredField}], is not valid");
            }

            Assert.AreEqual(expectedError, actualError, TestErrorHelper.ErrorsDoNotMatch(expectedError, actualError));
        }

        [Then(@"the error '(.*)' will be displayed in the error section")]
        public void ThenTheErrorTBeBlank_WillBeDisplayedInTheErrorSection(string expectedError)
        {
            var actualError = CreateAccount.CreateAccountErrorSection.Text;

            Assert.IsTrue(ActualErrorContainsExpectedError(expectedError, actualError), TestErrorHelper.ErrorsDoNotMatch(expectedError, actualError));
        }

        [Then(@"the error section will change colour")]
        public void ThenTheErrorSectionWillChangeColour()
        {
            Console.WriteLine("Step not complete, need to convert rgb to hex");
        }

        [Then(@"the errored field \('(.*)'\) will change colour")]
        public void ThenTheErroredFieldWillChangeColour(string erroredField)
        {
            Console.WriteLine("Step not complete, need to convert rgb to hex");
        }


        private static bool ActualErrorContainsExpectedError(string expectedError, string actualError)
        {
            if (actualError.Contains(expectedError))
            {
                return true;
            }

            return false;
        }
    }
}
