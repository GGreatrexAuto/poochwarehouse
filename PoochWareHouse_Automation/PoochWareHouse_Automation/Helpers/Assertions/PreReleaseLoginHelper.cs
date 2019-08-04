using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Tests;

namespace PoochWareHouse_Automation.Helpers.Assertions
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

    }
}
