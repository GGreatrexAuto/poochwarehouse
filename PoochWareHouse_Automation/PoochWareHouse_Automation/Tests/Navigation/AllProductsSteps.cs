using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Pages;
using PoochWareHouse_Automation.Pages.PageElements;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "All Products")]
    public sealed class AllProductsSteps
    {
        private readonly Site _site;

        public AllProductsSteps()
        {
            _site = new Site();
        }

        [Given(@"I access the all products page number '(.*)'")]
        public void GivenIAccessTheAllProductsPageNumber(int pageNumber)
        {
            switch (pageNumber)
            {
                case 1:
                    _site.InitialiseChromeDriver(Urls.AllProductsUrlPgOne);
                    break;
                case 2:
                    _site.InitialiseChromeDriver(Urls.AllProductsUrlPgTwo);
                    break;
                case 3:
                    _site.InitialiseChromeDriver(Urls.AllProductsUrlPgThree);
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(pageNumber.ToString()));
                    break;
            }
        }

        [Given(@"I clear the cookie overlay")]
        public void GivenIClearTheCookieOverlay()
        {
            CookieOverlay.AcceptCookieButton.Click();

            Thread.Sleep(1250);
        }


        [When(@"I click the '(.*)' button")]
        public void WhenIClickTheButton(string navigationButton)
        {
            switch (navigationButton)
            {
                case "next":
                    AllProductsNavigation.ClickNextPage();
                    break;
                case "previous":
                    AllProductsNavigation.ClickPreviousPage();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(navigationButton));
                    break;
            }
        }

        [When(@"the page navigation buttons are displayed")]
        public void WhenThePageNavigationButtonsAreDisplayed()
        {
            //does nothing.
        }

        [Then(@"the expected page number (.*) will be displayed")]
        public void ThenTheExpectedPageNumberWillBeDisplayed(string expectedPageNumber)
        {
            var actualValue = AllProducts.PageNumberLabel.Text;
            var actualPageNumber = actualValue.Substring(5, 1);

            Assert.AreEqual(expectedPageNumber, actualPageNumber, $"The expected page number [{expectedPageNumber}] did not match the actual page number [{actualPageNumber}]");                          
        }

        [Then(@"the '(.*)' button will be disabled")]
        public void ThenTheButtonWillBeDisabled(string navigationButton)
        {
            switch (navigationButton)
            {
                case "previous":
                    Assert.IsFalse(AllProducts.PreviousPageButtonDisabled.Enabled, "The previous button should have been disabled.");
                    break;
                case "next":
                    Assert.IsFalse(AllProducts.NextPageButtonDisabled.Enabled, "The next button should have been disabled.");
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(navigationButton));
                    break;
            }
        }
    }
}
