using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Pages.InformationalPages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "Informational Page Navigation")]
    public sealed class InformationalPageNavigationSteps
    {
        private readonly Site _site;

        public InformationalPageNavigationSteps()
        {
            _site = new Site();
        }

        [Given(@"I access the '(.*)' page")]
        public void GivenIAccessThePage(string informationalPage)
        {
            switch (informationalPage)
            {
                case "faq":
                    _site.InitialiseChromeDriver(Urls.FaqUrl);
                    break;
                case "privacy policy":
                    _site.InitialiseChromeDriver(Urls.PrivacyPolicyUrl);
                    break;
                case "returns policy":
                    _site.InitialiseChromeDriver(Urls.ReturnsPolicyUrl);
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(informationalPage));
                    break;
            }           
        }

        [Given(@"I clear the cookie notice")]
        public void GivenIClearTheCookieNotice()
        {
            CookieOverlayActions.ClearCookieOverlay();
        }

        [Given(@"the '(.*)' link is present")]
        public void GivenTheLinkIsPresent(string hyperLink)
        {
            var itemType = "hyperLink";

            switch (hyperLink)
            {
                case "return policy link":
                    Assert.IsTrue(Faq.ReturnPolicyLink.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "homepage link one":
                    Assert.IsTrue(PrivacyPolicy.PoochWarehouseHyperlinkOne.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "homepage link two":
                    Assert.IsTrue(PrivacyPolicy.PoochWarehouseHyperlinkOne.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "all about cookies link":
                    Assert.IsTrue(PrivacyPolicy.AllAboutCookiesLink.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "shopify link":
                    Assert.IsTrue(PrivacyPolicy.ShopifyLegalLink.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "google privacy link":
                    Assert.IsTrue(PrivacyPolicy.GooglePrivacy.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "google opt out link":
                    Assert.IsTrue(PrivacyPolicy.GoogleOptOut.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "facebook advertising link":
                    Assert.IsTrue(PrivacyPolicy.FacebookAdvertising.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                case "contact us link":
                    Assert.IsTrue(ReturnsPolicy.ContactUsLink.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, hyperLink));
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(hyperLink));
                    break;
            }
        }

        [When(@"I click the '(.*)'")]
        public void WhenIClickThe(string hyperLink)
        {
            switch (hyperLink)
            {
                case "return policy link":
                    Faq.ReturnPolicyLink.Click();
                    break;
                case "homepage link one":
                    PrivacyPolicy.PoochWarehouseHyperlinkOne.Click();
                    break;
                case "homepage link two":
                    PrivacyPolicy.PoochWarehouseHyperlinkTwo.Click();
                    break;
                case "all about cookies link":
                    PrivacyPolicy.AllAboutCookiesLink.Click();
                    break;
                case "shopify link":
                    PrivacyPolicy.ShopifyLegalLink.Click();
                    break;
                case "google privacy link":
                    PrivacyPolicy.GooglePrivacy.Click();
                    break;
                case "google opt out link":
                    PrivacyPolicy.GoogleOptOut.Click();
                    break;
                case "facebook advertising link":
                    PrivacyPolicy.FacebookAdvertising.Click();
                    break;
                case "contact us link":
                    ReturnsPolicy.ContactUsLink.Click();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(hyperLink));
                    break;
            }
        }

        [Then(@"the '(.*)' page will be loaded")]
        public void ThenThePageWillBeLoaded(string expectedPage)
        {
            var itemType = "page heading";

            if (expectedPage == "Returns Policy" || expectedPage == "Contact Us")
            {
                InformationalPageAssertions.ConfirmInformationalPageHasBeenLoaded(itemType, expectedPage);
            }

            else if (expectedPage == "Home Page")
            {
                HomepageAssertions.ConfirmHomePageHasBeenLoaded();
            }
        }



    }
}
