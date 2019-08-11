using System;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Tests;

namespace PoochWareHouse_Automation.Helpers
{
    public class PreReleaseLoginHelper
    {
        private PreReleaseLogonSteps _preReleaseLogonSteps;
        private readonly Site _site;

        public PreReleaseLoginHelper()
        {
            _preReleaseLogonSteps = new PreReleaseLogonSteps();
            _site = new Site();
        }

        public void LoginToMainSiteWithNewDriver()
        {
            _preReleaseLogonSteps.GivenIOpenTheWebPage();
            _preReleaseLogonSteps.GivenTheCustomerSelectsTheEnterUsingPasswordButton();
            _preReleaseLogonSteps.GivenTheCustomerEntersAValidPassword();
            _preReleaseLogonSteps.WhenTheEnterButtonIsSelected();
            _preReleaseLogonSteps.ThenThePoochwarehouseHomepageWillBeDisplayed();
        }

        public void LoginToMainSiteFromPreReleasePage()
        {
            _preReleaseLogonSteps.GivenTheCustomerSelectsTheEnterUsingPasswordButton();
            _preReleaseLogonSteps.GivenTheCustomerEntersAValidPassword();
            _preReleaseLogonSteps.WhenTheEnterButtonIsSelected();
            _preReleaseLogonSteps.ThenThePoochwarehouseHomepageWillBeDisplayed();
        }

        public bool IsWebsiteInPreReleaseMode(string currentUrl)
        {
            bool isPreRelease;

            if (currentUrl == Urls.PoochWarehousePreReleasePage)
            {
                return isPreRelease = true;
            }
            else
            {
                return false;
            }
        }

        public void ByPassPreReleaseAndNavigateToPage(bool preReleaseMode, string url)
        {
            if (preReleaseMode == true)
            {
                LoginToMainSiteFromPreReleasePage();
                _site.GoToUrl(url);
            }
            else
            {
                Console.WriteLine("Website not in PreRelease mode, PreRelease journey is not required.");
            }
        }
    }
}
