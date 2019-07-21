using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
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
            _site.InitialiseChromeDriver(Config.PoochWarehouseHomePage);
        }

        [Given(@"I access the poochwarehouse '(.*)' page")]
        public void GivenIAccessThePoochwarehousePage(string webPage)
        {
            switch (webPage)
            {
                   case "sale-items":
                       _site.InitialiseChromeDriver(Config.SaleItemsUrl);
                    break;
                case "all-products":
                    _site.InitialiseChromeDriver(Config.AllProductsUrl);
                    break;
                case "beds-blankets":
                    _site.InitialiseChromeDriver(Config.BedsBlanketsUrl);
                    break;
                   case "bowls-food":
                       _site.InitialiseChromeDriver(Config.BowlsFoodUrl);
                    break;
                case "health-grooming":
                    _site.InitialiseChromeDriver(Config.HealthGroomingUrl);
                    break;
                case "collars-leads":
                    _site.InitialiseChromeDriver(Config.CollarsLeadsUrl);
                    break;
                case "health-care":
                    _site.InitialiseChromeDriver(Config.HealthCareUrl);
                    break;
                case "training":
                    _site.InitialiseChromeDriver(Config.TrainingUrl);
                    break;
                case "small-dogs":
                    _site.InitialiseChromeDriver(Config.SmallDogsUrl);
                    break;
                case "large-dogs":
                    _site.InitialiseChromeDriver(Config.LargeDogsUrl);
                    break;
                case "toys-games":
                    _site.InitialiseChromeDriver(Config.ToysGamesUrl);
                    break;
                case "on-the-go":
                    _site.InitialiseChromeDriver(Config.OnTheGoUrl);
                    break;
                case "summer-collection":
                    _site.InitialiseChromeDriver(Config.SummerCollectionUrl);
                    break;
                case "winter-collection":
                    _site.InitialiseChromeDriver(Config.WinterCollectionUrl);
                    break;
                case "login":
                    _site.InitialiseChromeDriver(Config.LoginUrl);
                    break;
                case "your-cart":
                    _site.InitialiseChromeDriver(Config.YourCartUrl);
                    break;
                case "about-us":
                    _site.InitialiseChromeDriver(Config.AboutUsUrl);
                    break;
                case "faq":
                    _site.InitialiseChromeDriver(Config.FaqUrl);
                    break;
                case "delivery-shipping":
                    _site.InitialiseChromeDriver(Config.DeliveryShippingUrl);
                    break;
                case "returns-policy":
                    _site.InitialiseChromeDriver(Config.ReturnsPolicyUrl);
                    break;
                case "privacy-policy":
                    _site.InitialiseChromeDriver(Config.PrivacyPolicyUrl);
                    break;
                case "terms-of-use":
                    _site.InitialiseChromeDriver(Config.TermsOfUseUrl);
                    break;
                case "contact-us":
                    _site.InitialiseChromeDriver(Config.ContactUsUrl);
                    break;
                default:
                    Assert.Inconclusive($"webpage [{webPage}] passed into method was not recognised, is there a typo?");
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
                    Assert.Inconclusive($"linkName [{linkName}] passed into method was not recognised, is there a typo?");
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
                    Assert.Inconclusive($"collectionsLink [{collectionsLink}] passed into method was not recognised, is there a typo?");
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
                        $"collectionsDropDown [{collectionsDropDown}] passed into method was not recognised, is there a typo?");
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
                default:
                    Assert.Inconclusive($"headerOption [{headerOption}] passed into method was not recognised, is there a typo?");
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
                    Assert.Inconclusive($"homePageNavigationType [{homePageNavigationType}] passed into method was not recognised, is there a typo?");
                    break;
            }
        }


        [Then(@"the '(.*)' informational page will load")]
        public void ThenTheInformationalPageWillLoad(string expectedHeading)
        {
            Assert.IsTrue(InformationalPagesGenericItems.GenericPageHeading.Displayed, "The expected page heading was not displayed.");

            var actualHeading = InformationalPagesGenericItems.GenericPageHeading.Text;

            Assert.AreEqual(expectedHeading, actualHeading, 
                $"The expected page heading [{expectedHeading}] was not displayed, the actual heading was [{actualHeading}].");
        }

        [Then(@"the '(.*)' products collection page will load")]
        public void ThenTheProductsCollectionPageWillLoad(string expectedHeading)
        {
            Assert.IsTrue(ProductsPagesGenericItems.ProductsGenericPageHeading.Displayed, "The expected page heading was not displayed.");

            var actualHeading = ProductsPagesGenericItems.ProductsGenericPageHeading.Text;

            var actualHeadingManipulated = actualHeading.Substring(13);
            Assert.AreEqual(expectedHeading, actualHeadingManipulated,
                $"The expected page heading [{expectedHeading}] was not displayed, the actual heading was [{actualHeadingManipulated}].");
        }

        [Then(@"the '(.*)' products page will load")]
        public void ThenTheProductsPageWillLoad(string expectedHeading)
        {
            var actualHeading = string.Empty;
            
            if (expectedHeading == "Products")
            {
                Assert.IsTrue(AllProducts.ProductsPageHeading.Displayed, "The expected page heading was not displayed.");
                actualHeading = AllProducts.ProductsPageHeading.Text;
            }
            else if (expectedHeading == "Sale Items")
            {
                Assert.IsTrue(ProductsPagesGenericItems.ProductsGenericPageHeading.Displayed, "The expected page heading was not displayed.");
                actualHeading = ProductsPagesGenericItems.ProductsGenericPageHeading.Text;
            }
            else if(expectedHeading == "Login")
            {
                Assert.IsTrue(LoginForm.LoginPageheader.Displayed, "The expected page heading was not displayed.");
                actualHeading = LoginForm.LoginPageheader.Text;
            }
            else if(expectedHeading == "Your Cart")
            {
                Assert.IsTrue(YourCart.YourCartPageHeading.Displayed, "The expected page heading was not displayed.");
                actualHeading = YourCart.YourCartPageHeading.Text;
            }
            else
            {
                Assert.Inconclusive($"expectedHeading [{expectedHeading}] passed into method was not recognised, is there a typo?");
            }

            var actualHeadingManipulated = actualHeading.Substring(13);
            Assert.AreEqual(expectedHeading, actualHeadingManipulated,
                $"The expected page heading [{expectedHeading}] was not displayed, the actual heading was [{actualHeadingManipulated}].");
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
