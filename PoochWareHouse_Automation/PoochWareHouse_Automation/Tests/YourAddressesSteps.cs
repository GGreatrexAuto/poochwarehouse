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

        [Given(@"enter '(.*)' address details")]
        public void GivenEnterAddressDetails(string validity)
        {
            
            
            if (validity == "valid")
            {
                _addressActions.PopulateCustomerAddress(_expectedAddress);
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

            var actualDisplayedAddress = _addressActions.GetDefaultCustomerAddress();

            Assert.IsNotNull(actualDisplayedAddress);
            
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().Address), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().Address));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().Apartment), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().Apartment));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().City), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().City));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().Company), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().Company));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().Country), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().Country));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().FirstName), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().FirstName));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().Postcode), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().Postcode));
            Assert.IsTrue(actualDisplayedAddress.Contains(_expectedAddress.AddressDetails().Surname), TestErrorHelper.ExpectedAddressNotDisplayed(_expectedAddress.AddressDetails().Surname));
            
            Console.WriteLine($"The actual address was {actualDisplayedAddress}");

            //_addressActions.DeleteDefaultAddress();
        }

        

    }
}
