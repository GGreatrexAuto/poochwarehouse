using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Pages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests
{
    [Binding]
    [Scope(Feature = "Create Account Validation")]

    public sealed class CreateAccountValidationSteps
    {
        




        [When(@"I press create account button")]
        public void WhenIPressCreateAccountButton()
        {
            CreateAccount.CreateAccountButton.Click();
        }





    }
}
