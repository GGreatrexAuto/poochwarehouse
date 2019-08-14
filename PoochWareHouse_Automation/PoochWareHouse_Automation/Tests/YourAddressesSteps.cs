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

        [Then(@"the address details will be saved as entered")]
        public void ThenTheAddressDetailsWillBeSavedAsEntered()
        {
            var actualDisplayedAddress = _addressActions.GetAddress();

            Assert.Multiple(() =>
            {
                //Assert.AreEqual(_expectedAddress.FirstName, actualDisplayedAddress.FirstName);
                //Assert.AreEqual(_expectedAddress.Surname, actualDisplayedAddress.Surname);
                Assert.AreEqual(_expectedAddress.Address, actualDisplayedAddress.Address);
                Assert.AreEqual(_expectedAddress.Apartment, actualDisplayedAddress.Apartment);
                Assert.AreEqual(_expectedAddress.Company, actualDisplayedAddress.Company);
                Assert.AreEqual(_expectedAddress.City, actualDisplayedAddress.City);
                //Assert.AreEqual(_expectedAddress.Country, actualDisplayedAddress.Country);
                //Assert.AreEqual(_expectedAddress.Postcode, actualDisplayedAddress.Postcode);
            });
        }


    }
}
