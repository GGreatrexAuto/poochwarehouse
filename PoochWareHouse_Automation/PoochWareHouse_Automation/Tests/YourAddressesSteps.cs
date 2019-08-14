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

        public YourAddressesSteps()
        {
            _commonStepHelper = new CommonStepHelper();
            _loginFormActions = new LoginFormActions();
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
            AddressConfig validAddress = new AddressConfig();

            if (validity == "valid")
            {
                YourAddressActions.PopulateCustomerAddress(validAddress);
            }
        }

        [When(@"I press Add Address")]
        public void WhenIPressAddAddress()
        {
            YourAddresses.AddAddressButton.Click();
        }


    }
}
