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

        public PreReleaseLoginHelper()
        {
            _preReleaseLogonSteps = new PreReleaseLogonSteps();
        }

        public void LoginToMainSite()
        {
            _preReleaseLogonSteps.GivenIOpenTheWebPage();
            _preReleaseLogonSteps.GivenTheCustomerSelectsTheEnterUsingPasswordButton();
            _preReleaseLogonSteps.GivenTheCustomerEntersAValidPassword();
            _preReleaseLogonSteps.WhenTheEnterButtonIsSelected();
            _preReleaseLogonSteps.ThenThePoochwarehouseHomepageWillBeDisplayed();
        }
    }
}
