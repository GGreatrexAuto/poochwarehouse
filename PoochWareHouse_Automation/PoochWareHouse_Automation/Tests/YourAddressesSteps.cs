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
    [Scope(Feature = "Your Addresses")]
    public sealed class YourAddressesSteps
    {
        private LoginFormActions _loginFormActions;
        private readonly CommonStepHelper _commonStepHelper;
        private YourAddressActions _addressActions;
        private AddressConfig _expectedAddress;

        public YourAddressesSteps()
        {
            _commonStepHelper = new CommonStepHelper();
            _loginFormActions = new LoginFormActions();
            _addressActions = new YourAddressActions();
            _expectedAddress = new AddressConfig();
        }

        [Given(@"I login and add a default address")]
        public void GivenILoginAndAddADefaultAddress()
        {
            GivenIAccessMyAccount();
            GivenClickTheViewAddressesButton();
            GivenClickAddANewAddress();
            GivenEnterAddressDetails("valid");
            WhenIPressAddAddress();
        }

        [Given(@"I access my account")]
        public void GivenIAccessMyAccount()
        {
            _commonStepHelper.AccessWebsite("login");
            CookieOverlayActions.ClearCookieOverlay();
            _loginFormActions.LoginUserAccount(LoginConfiguration.ValidUserName, LoginConfiguration.ValidPassword);
        }

        [Given(@"click the View Addresses button")]
        public void GivenClickTheViewAddressesButton()
        {
            MyAccount.ViewAddressButton.Click();
        }

        [Given(@"click Add A New Address")]
        public void GivenClickAddANewAddress()
        {
            YourAddresses.AddNewAddressButton.Click();
        }

        [Given(@"then add a second address")]
        public void GivenThenAddASecondAddress()
        {
            GivenClickAddANewAddress();
            _addressActions.PopulateCustomerAddress(_expectedAddress.FurtherAddressDetails());
        }


        [Given(@"enter '(.*)' address details")]
        public void GivenEnterAddressDetails(string validity)
        {
            
            
            if (validity == "valid")
            {
                _addressActions.PopulateCustomerAddress(_expectedAddress.DefaultAddressDetails());
            }
        }

        [When(@"I press Add Address")]
        public void WhenIPressAddAddress()
        {
            YourAddresses.AddAddressButton.Click();
        }

        [Then(@"the default address details will be saved as entered")]
        public void ThenTheAddressDetailsWillBeSavedAsEntered()
        {
            Assert.IsTrue(YourAddresses.AddressOneHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed("heading", "Default"));

            var actualDisplayedAddress = _addressActions.GetCustomerAddressOne();

            Assert.IsNotNull(actualDisplayedAddress);
            
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().Address), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().Address));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().Apartment), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().Apartment));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().City), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().City));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().Company), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().Company));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().Country), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().Country));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().FirstName), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().FirstName));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().Postcode), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().Postcode));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.DefaultAddressDetails().Surname), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.DefaultAddressDetails().Surname));
            
            Console.WriteLine($"The actual address was {actualDisplayedAddress}");
        }

        [Then(@"the second added address will be saved as entered")]
        public void ThenTheSecondAddedAddressWillBeSavedAsEntered()
        {
            var actualDisplayedAddress = _addressActions.GetCustomerAddressTwo();

            Assert.IsNotNull(actualDisplayedAddress);

            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().Address), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().Address));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().Apartment), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().Apartment));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().City), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().City));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().Company), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().Company));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().Country), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().Country));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().FirstName), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().FirstName));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().Postcode), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().Postcode));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.FurtherAddressDetails().Surname), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.FurtherAddressDetails().Surname));

            Console.WriteLine($"The actual address was {actualDisplayedAddress}");
        }


    }
}
