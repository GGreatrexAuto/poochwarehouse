using System;
using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Helpers.Assertions;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Navigation.InformationalPages;
using PoochWareHouse_Automation.Pages;
using PoochWareHouse_Automation.Pages.News;
using PoochWareHouse_Automation.Pages.PageElements;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "Site Navigation")]

    public sealed class SiteNavigationSteps
    {
        private readonly Site _site;
        private readonly PreReleaseLoginHelper _preReleaseLoginHelper;
        private readonly UrlHelper _urlHelper;
        private string _url;

        public SiteNavigationSteps()
        {
            _site = new Site();
            _preReleaseLoginHelper = new PreReleaseLoginHelper();
            _urlHelper = new UrlHelper();
        }

        [Given(@"I have accessed the PoochwareHouse website homepage")]
        public void GivenIHaveAccessedThePoochwareHouseWebsite()
        {
            _site.InitialiseChromeDriver();
            _site.NavigateAndMaximise(Urls.PoochWarehouseHomePage);

            var currentUrl = _site.GetWebPageUrl();

            if (currentUrl == Urls.PoochWarehousePreReleasePage)
            {
                _preReleaseLoginHelper.LoginToMainSiteFromPreReleasePage();
            }
            else
            {
                Console.WriteLine("PreRelease journey not required.");
            }
        }

        [Given(@"I clear the cookies overlay")]
        public void GivenIClearTheCookiesOverlay()
        {
            CookieOverlayActions.ClearCookieOverlay();
        }

        [Given(@"I access the poochwarehouse '(.*)' page")]
        public void GivenIAccessThePoochwarehousePage(string webPage)
        {
            _site.InitialiseChromeDriver();

            _url = _urlHelper.SetUrl(webPage);

            _site.NavigateAndMaximise(_url);

            var currentUrl = _site.GetWebPageUrl();

            var preReleaseMode = _preReleaseLoginHelper.IsWebsiteInPreReleaseMode(currentUrl);

            _preReleaseLoginHelper.ByPassPreReleaseAndNavigateToPage(preReleaseMode, _url);
        }
        
        [Given(@"click the collections drop down option in the page header")]
        public void GivenClickTheCollectionsDropDownOptionInThePageHeader()
        {
            HeaderMenu.CollectionsDropDownLink.Click();
        }

        [When(@"I click the '(.*)' in the website footer")]
        public void WhenIClickTheInTheWebsiteFooter(string linkName)
        {
            switch (linkName)
            {
                case "About Us":
                    FooterNavigation.ToAboutUs();
                    break;
                case "FAQ":
                    FooterNavigation.ToFaq();
                    break;
                case "Delivery & Shipping":
                    FooterNavigation.ToDeliveryAndShipping();
                    break;
                case "Returns Policy":
                    FooterNavigation.ToReturnsPolicy();
                    break;
                case "Privacy Policy":
                    FooterNavigation.ToPrivacyPolicy();
                    break;
                case "Terms Of Use":
                    FooterNavigation.ToTermsOfUse();
                    break;
                case "Contact Us":
                    FooterNavigation.ToContactUs();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(linkName));
                    break;
            }
        }

        [When(@"I click the '(.*)' in the collections frame")]
        public void WhenIClickTheInTheCollectionsFrame(string collectionsLink)
        {
            switch (collectionsLink)
            {
                case "Beds & Blankets":
                    HomePageNavigation.ToCollectionsBedsBlankets();
                    break;
                case "Bowls & Food":
                    HomePageNavigation.ToCollectionsBowlsFood();
                    break;
                case "Grooming":
                    HomePageNavigation.ToCollectionsGrooming();
                    break;
                case "Collars & Leads":
                    HomePageNavigation.ToCollectionsCollarsLeads();
                    break;
                case "Health Care":
                    HomePageNavigation.ToCollectionsHealthCare();
                    break;
                case "Training":
                    HomePageNavigation.ToCollectionsTraining();
                    break;
                case "Small Dogs & Puppy":
                    HomePageNavigation.ToCollectionsSmallDogsPuppies();
                    break;
                case "Large Dogs":
                    HomePageNavigation.ToCollectionsLargeDogs();
                    break;
                case "Toys & Games":
                    HomePageNavigation.ToCollectionsToysGames();
                    break;
                case "On the go":
                    HomePageNavigation.ToCollectionsOnTheGo();
                    break;
                case "Summer Time":
                    HomePageNavigation.ToCollectionsSummerTime();
                    break;
                case "Winter Time":
                    HomePageNavigation.ToCollectionsWinterTime();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(collectionsLink));
                    break;
            }
        }

        [When(@"I click the '(.*)' option on the drop down list")]
        public void WhenIClickTheOptionOnTheDropDownList(string collectionsDropDown)
        {
            switch (collectionsDropDown)
            {
                case "Beds & Blankets":
                    HeaderNavigation.ToBedsBlankets();
                    break;
                case "Bowls & Food":
                    HeaderNavigation.ToBowlsFood();
                    break;
                case "Grooming":
                    HeaderNavigation.ToGrooming();
                    break;
                case "Collars & Leads":
                    HeaderNavigation.ToCollarsLeads();
                    break;
                case "Health Care":
                    HeaderNavigation.ToHealthCare();
                    break;
                case "Training":
                    HeaderNavigation.ToTraining();
                    break;
                case "Small Dogs & Puppy":
                    HeaderNavigation.ToSmallDogsPuppy();
                    break;
                case "Large Dogs":
                    HeaderNavigation.ToLargeDogs();
                    break;
                case "Toys & Games":
                    HeaderNavigation.ToToysGames();
                    break;
                case "On the go":
                    HeaderNavigation.ToOnTheGo();
                    break;
                case "Summer Time":
                    HeaderNavigation.ToSummerTime();
                    break;
                case "Winter Time":
                    HeaderNavigation.ToWinterTime();
                    break;
                default:
                    Console.WriteLine(
                        TestErrorHelper.CaseValueNotRecognised(collectionsDropDown));
                    break;
            }
        }

        [When(@"I click the '(.*)' header option")]
        public void WhenIClickTheHeaderOption(string headerOption)
        {
            switch (headerOption)
            {
                case "On Sale":
                    HeaderNavigation.ToSaleItems();
                    break;
                case "All Products":
                    HeaderNavigation.ToAllProducts();
                    break;
                case "Login":
                    HeaderNavigation.ToLoginForm();
                    break;
                case "Your Cart":
                    HeaderNavigation.ToYourCart();
                    break;
                case "News":
                    HeaderNavigation.ToNews();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(headerOption));
                    break;
            }
        }

        [When(@"I click the '(.*)' option")]
        public void WhenIClickTheOption(string homePageNavigationType)
        {
            switch (homePageNavigationType)
            {
                case "Homepage header":
                    HeaderNavigation.ToHomePage();
                    break;
                case "PoochWarehouse logo":
                    HeaderNavigation.ToHomePageViaLogo();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(homePageNavigationType));
                    break;
            }
        }
        
        [Then(@"the '(.*)' informational page will load")]
        public void ThenTheInformationalPageWillLoad(string expectedHeading)
        {
            var itemType = "page heading";

            InformationalPageAssertions.ConfirmInformationalPageHasBeenLoaded(itemType, expectedHeading);
        }

        [Then(@"the '(.*)' products collection page will load")]
        public void ThenTheProductsCollectionPageWillLoad(string expectedHeading)
        {
            var itemType = "page heading";

            ProductsCollectionPagesGenericAssertions.ConfirmProductCollectionPageHasBeenLoaded(itemType, expectedHeading);
        }

        [Then(@"the '(.*)' products page will load")]
        public void ThenTheProductsPageWillLoad(string expectedHeading)
        {
            var itemType = "page heading";

            var actualHeading = string.Empty;
            
            if (expectedHeading == "Products")
            {
                Assert.IsTrue(AllProducts.ProductsPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));
                actualHeading = AllProducts.ProductsPageHeading.Text;
                var actualHeadingManipulated = actualHeading.Substring(13);
                Assert.AreEqual(expectedHeading, actualHeadingManipulated,
                    TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedHeading, actualHeadingManipulated));
            }
            else if (expectedHeading == "Sale Items")
            {
                ThenTheProductsCollectionPageWillLoad(expectedHeading);
            }
            else if(expectedHeading == "Login")
            {
                Assert.IsTrue(LoginForm.LoginPageheader.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));
                actualHeading = LoginForm.LoginPageheader.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedHeading, actualHeading));
            }
            else if(expectedHeading == "Your cart")
            {
                Assert.IsTrue(YourCart.YourCartPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));
                actualHeading = YourCart.YourCartPageHeading.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedHeading, actualHeading));
            }
            else if (expectedHeading == "News")
            {
                Assert.IsTrue(News.NewsPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));
                actualHeading = News.NewsPageHeading.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedHeading, actualHeading));
            }
            else
            {
                Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(expectedHeading));
            }            
        }

        [Then(@"the user will be navigated to the poochwarehouse homepage")]
        public void ThenTheUserWillBeNavigatedToThePoochwarehouseHomepage()
        {
            HomepageAssertions.ConfirmHomePageHasBeenLoaded();
        }
    }
}
