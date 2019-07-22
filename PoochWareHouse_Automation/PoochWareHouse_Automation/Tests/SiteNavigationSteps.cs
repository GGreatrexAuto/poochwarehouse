using System;
using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Pages;
using PoochWareHouse_Automation.Pages.Collections;
using PoochWareHouse_Automation.Pages.InformationalPages;
using PoochWareHouse_Automation.Pages.PageElements;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests
{
    [Binding]
    [Scope(Feature = "Site Navigation")]

    public sealed class SiteNavigationSteps
    {
        private readonly Site _site;
        private readonly FooterNavigation _footerNavigation;
        private readonly HomePageNavigation _homepageNavigation;
        private readonly HeaderNavigation _headerNavigation;

        public SiteNavigationSteps()
        {
            _site = new Site();
            _footerNavigation = new FooterNavigation();
            _homepageNavigation = new HomePageNavigation();
            _headerNavigation = new HeaderNavigation();
        }

        [Given(@"I have accessed the PoochwareHouse website homepage")]
        public void GivenIHaveAccessedThePoochwareHouseWebsite()
        {
            _site.InitialiseChromeDriver(Urls.PoochWarehouseHomePage);
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
                    _site.InitialiseChromeDriver(Urls.AllProductsUrl);
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
                    _footerNavigation.ToAboutUs();
                    break;
                case "FAQ":
                    _footerNavigation.ToFaq();
                    break;
                case "Delivery & Shipping":
                    _footerNavigation.ToDeliveryAndShipping();
                    break;
                case "Returns Policy":
                    _footerNavigation.ToReturnsPolicy();
                    break;
                case "Privacy Policy":
                    _footerNavigation.ToPrivacyPolicy();
                    break;
                case "Terms Of Use":
                    _footerNavigation.ToTermsOfUse();
                    break;
                case "Contact Us":
                    _footerNavigation.ToContactUs();
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
                    _homepageNavigation.ToCollectionsBedsBlankets();
                    break;
                case "Bowls & Food":
                    _homepageNavigation.ToCollectionsBowlsFood();
                    break;
                case "Grooming":
                    _homepageNavigation.ToCollectionsGrooming();
                    break;
                case "Collars & Leads":
                    _homepageNavigation.ToCollectionsCollarsLeads();
                    break;
                case "Health Care":
                    _homepageNavigation.ToCollectionsHealthCare();
                    break;
                case "Training":
                    _homepageNavigation.ToCollectionsTraining();
                    break;
                case "Small Dogs & Puppy":
                    _homepageNavigation.ToCollectionsSmallDogsPuppies();
                    break;
                case "Large Dogs":
                    _homepageNavigation.ToCollectionsLargeDogs();
                    break;
                case "Toys & Games":
                    _homepageNavigation.ToCollectionsToysGames();
                    break;
                case "On the go":
                    _homepageNavigation.ToCollectionsOnTheGo();
                    break;
                case "Summer Time":
                    _homepageNavigation.ToCollectionsSummerTime();
                    break;
                case "Winter Time":
                    _homepageNavigation.ToCollectionsWinterTime();
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
                    _headerNavigation.ToBedsBlankets();
                    break;
                case "Bowls & Food":
                    _headerNavigation.ToBowlsFood();
                    break;
                case "Grooming":
                    _headerNavigation.ToGrooming();
                    break;
                case "Collars & Leads":
                    _headerNavigation.ToCollarsLeads();
                    break;
                case "Health Care":
                    _headerNavigation.ToHealthCare();
                    break;
                case "Training":
                    _headerNavigation.ToTraining();
                    break;
                case "Small Dogs & Puppy":
                    _headerNavigation.ToSmallDogsPuppy();
                    break;
                case "Large Dogs":
                    _headerNavigation.ToLargeDogs();
                    break;
                case "Toys & Games":
                    _headerNavigation.ToToysGames();
                    break;
                case "On the go":
                    _headerNavigation.ToOnTheGo();
                    break;
                case "Summer Time":
                    _headerNavigation.ToSummerTime();
                    break;
                case "Winter Time":
                    _headerNavigation.ToWinterTime();
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
                    _headerNavigation.ToSaleItems();
                    break;
                case "All Products":
                    _headerNavigation.ToAllProducts();
                    break;
                case "Login":
                    _headerNavigation.ToLoginForm();
                    break;
                case "Your Cart":
                    _headerNavigation.ToYourCart();
                    break;
                case "News":
                    _headerNavigation.ToNews();
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
                    _headerNavigation.ToHomePage();
                    break;
                case "PoochWarehouse logo":
                    _headerNavigation.ToHomePageViaLogo();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(homePageNavigationType));
                    break;
            }
        }


        [Then(@"the '(.*)' informational page will load")]
        public void ThenTheInformationalPageWillLoad(string expectedHeading)
        {
            Assert.IsTrue(InformationalPagesGenericItems.GenericPageHeading.Displayed, TestErrorHelper.ExpectedPageHeadingNotDisplayed());

            var actualHeading = InformationalPagesGenericItems.GenericPageHeading.Text;

            Assert.AreEqual(expectedHeading, actualHeading, 
                TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeading));
        }

        [Then(@"the '(.*)' products collection page will load")]
        public void ThenTheProductsCollectionPageWillLoad(string expectedHeading)
        {
            Assert.IsTrue(ProductsPagesGenericItems.ProductsGenericPageHeading.Displayed, TestErrorHelper.ExpectedPageHeadingNotDisplayed());

            var actualHeading = ProductsPagesGenericItems.ProductsGenericPageHeading.Text;

            var actualHeadingManipulated = actualHeading.Substring(13);
            Assert.AreEqual(expectedHeading, actualHeadingManipulated,
                TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeadingManipulated));
        }

        [Then(@"the '(.*)' products page will load")]
        public void ThenTheProductsPageWillLoad(string expectedHeading)
        {
            var actualHeading = string.Empty;
            
            if (expectedHeading == "Products")
            {
                Assert.IsTrue(AllProducts.ProductsPageHeading.Displayed, TestErrorHelper.ExpectedPageHeadingNotDisplayed());
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
                Assert.IsTrue(LoginForm.LoginPageheader.Displayed, TestErrorHelper.ExpectedPageHeadingNotDisplayed());
                actualHeading = LoginForm.LoginPageheader.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeading));
            }
            else if(expectedHeading == "Your cart")
            {
                Assert.IsTrue(YourCart.YourCartPageHeading.Displayed, TestErrorHelper.ExpectedPageHeadingNotDisplayed());
                actualHeading = YourCart.YourCartPageHeading.Text;
                Assert.AreEqual(expectedHeading, actualHeading, TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedHeading, actualHeading));
            }
            else if (expectedHeading == "News")
            {
                Assert.IsTrue(News.NewsPageHeading.Displayed, TestErrorHelper.ExpectedPageHeadingNotDisplayed());
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
            Assert.Multiple(() =>
            {
                Assert.IsTrue(HomePage.HomePageImageFrame.Displayed,
                    "The homepage (main image frame) was not displayed.");
                Assert.IsTrue(HomePage.TestimonialHeading.Displayed,
                    "The homepage testimonial subheading was not displayed");
                Assert.IsTrue(HomePage.CollectionsSubHeading.Displayed,
                        "The homepage collections subheading was not displayed");
            });
        }
    }
}
