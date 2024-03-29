﻿using NUnit.Framework;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Helpers.Assertions;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Pages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "All Products")]
    public sealed class AllProductsSteps
    {
        //private readonly Site _site;
        //private readonly UrlHelper _urlHelper;
        //private readonly PreReleaseLoginHelper _preReleaseLoginHelper;

        private readonly CommonStepHelper _commonStepHelper;

        public AllProductsSteps()
        {
            //_site = new Site();
            //_urlHelper = new UrlHelper();
            //_preReleaseLoginHelper = new PreReleaseLoginHelper();

            _commonStepHelper = new CommonStepHelper();
        }

        [Given(@"I access the all products page number '(.*)'")]
        public void GivenIAccessTheAllProductsPageNumber(int pageNumber)
        {
            _commonStepHelper.AccessWebsite(pageNumber.ToString());
            //_site.InitialiseChromeDriver();

            //var url = _urlHelper.SetUrl(pageNumber.ToString());

            //_site.NavigateAndMaximise(url);

            //var currentUrl = _site.GetWebPageUrl();

            //var preReleaseMode = _preReleaseLoginHelper.IsWebsiteInPreReleaseMode(currentUrl);

            //_preReleaseLoginHelper.ByPassPreReleaseAndNavigateToPage(preReleaseMode, url);
        }

        [Given(@"I clear the cookie overlay")]
        public void GivenIClearTheCookieOverlay()
        {
            CookieOverlayActions.ClearCookieOverlay();
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
