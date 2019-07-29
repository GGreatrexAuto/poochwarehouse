using System;
using System.Threading;
using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Pages;
using PoochWareHouse_Automation.Pages.Collections;
using PoochWareHouse_Automation.Pages.PageElements;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "Site Navigation")]

    public sealed class SiteNavigationSteps
    {
        private readonly Site _site;

        public SiteNavigationSteps()
        {
            _site = new Site();
        }

        [Given(@"I have accessed the PoochwareHouse website homepage")]
        public void GivenIHaveAccessedThePoochwareHouseWebsite()
        {
            _site.InitialiseChromeDriver(Urls.PoochWarehouseHomePage);
        }

        [Given(@"I clear the cookies overlay")]
        public void GivenIClearTheCookiesOverlay()
        {
            CookieOverlayActions.ClearCookieOverlay();
        }


        [Given(@"I access the poochwarehouse '(.*)' page")]
        public void GivenIAccessThePoochwarehousePage(string webPage)
        {
            switch (webPage)
            {
                   case "sale-items":
                       _site.InitialiseChromeDriver(Urls.SaleItemsUrl);
                    break;
                case "all-products":
                    _site.InitialiseChromeDriver(Urls.AllProductsUrlPgOne);
                    break;
                case "beds-blankets":
                    _site.InitialiseChromeDriver(Urls.BedsBlanketsUrl);
                    break;
                   case "bowls-food":
                       _site.InitialiseChromeDriver(Urls.BowlsFoodUrl);
                    break;
                case "health-grooming":
                    _site.InitialiseChromeDriver(Urls.HealthGroomingUrl);
                    break;
                case "collars-leads":
                    _site.InitialiseChromeDriver(Urls.CollarsLeadsUrl);
                    break;
                case "health-care":
                    _site.InitialiseChromeDriver(Urls.HealthCareUrl);
                    break;
                case "training":
                    _site.InitialiseChromeDriver(Urls.TrainingUrl);
                    break;
                case "small-dogs":
                    _site.InitialiseChromeDriver(Urls.SmallDogsUrl);
                    break;
                case "large-dogs":
                    _site.InitialiseChromeDriver(Urls.LargeDogsUrl);
                    break;
                case "toys-games":
                    _site.InitialiseChromeDriver(Urls.ToysGamesUrl);
                    break;
                case "on-the-go":
                    _site.InitialiseChromeDriver(Urls.OnTheGoUrl);
                    break;
                case "summer-collection":
                    _site.InitialiseChromeDriver(Urls.SummerCollectionUrl);
                    break;
                case "winter-collection":
                    _site.InitialiseChromeDriver(Urls.WinterCollectionUrl);
                    break;
                case "login":
                    _site.InitialiseChromeDriver(Urls.LoginUrl);
                    break;
                case "your-cart":
                    _site.InitialiseChromeDriver(Urls.YourCartUrl);
                    break;
                case "about-us":
                    _site.InitialiseChromeDriver(Urls.AboutUsUrl);
                    break;
                case "faq":
                    _site.InitialiseChromeDriver(Urls.FaqUrl);
                    break;
                case "delivery-shipping":
                    _site.InitialiseChromeDriver(Urls.DeliveryShippingUrl);
                    break;
                case "returns-policy":
                    _site.InitialiseChromeDriver(Urls.ReturnsPolicyUrl);
                    break;
                case "privacy-policy":
                    _site.InitialiseChromeDriver(Urls.PrivacyPolicyUrl);
                    break;
                case "terms-of-use":
                    _site.InitialiseChromeDriver(Urls.TermsOfUseUrl);
                    break;
                case "contact-us":
                    _site.InitialiseChromeDriver(Urls.ContactUsUrl);
                    break;
                   case "news":
                       _site.InitialiseChromeDriver(Urls.NewsUrl);
                       break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(webPage));
                    break;
            }
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

            Assert.IsTrue(ProductsPagesGenericItems.ProductsGenericPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));

            var actualHeading = ProductsPagesGenericItems.ProductsGenericPageHeading.Text;

            var actualHeadingManipulated = actualHeading.Substring(13);
            Assert.AreEqual(expectedHeading, actualHeadingManipulated,
                TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeadingManipulated));
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
                    TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeadingManipulated));
            }
            else if (expectedHeading == "Sale Items")
            {
                ThenTheProductsCollectionPageWillLoad(expectedHeading);
            }
            else if(expectedHeading == "Login")
            {
                Assert.IsTrue(LoginForm.LoginPageheader.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));
                actualHeading = LoginForm.LoginPageheader.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeading));
            }
            else if(expectedHeading == "Your cart")
            {
                Assert.IsTrue(YourCart.YourCartPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));
                actualHeading = YourCart.YourCartPageHeading.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeading));
            }
            else if (expectedHeading == "News")
            {
                Assert.IsTrue(News.NewsPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));
                actualHeading = News.NewsPageHeading.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeading));
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
