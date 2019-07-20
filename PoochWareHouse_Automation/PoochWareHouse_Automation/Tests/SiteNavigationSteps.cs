using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Pages;
using PoochWareHouse_Automation.Pages.Collections;
using PoochWareHouse_Automation.Pages.InformationalPages;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests
{
    [Binding]
    [Scope(Feature = "Site Navigation")]

    public sealed class SiteNavigationSteps
    {
        private readonly Site _site;
        private readonly FooterNavigation _footerNavigation;
        private readonly InformationalPagesGenericItems _genericItems;
        private readonly HomePageNavigation _homepage;
        private readonly CollectionsPagesGenericItems _collections;

        public SiteNavigationSteps()
        {
            _site = new Site();
            _footerNavigation = new FooterNavigation();
            _genericItems = new InformationalPagesGenericItems();
            _homepage = new HomePageNavigation();
            _collections = new CollectionsPagesGenericItems();
        }

        [Given(@"I have accessed the PoochwareHouse website homepage")]
        public void GivenIHaveAccessedThePoochwareHouseWebsite()
        {
            _site.InitialiseChromeDriver(Config.PoochwarehouseHomePage);
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
                    Console.WriteLine($"linkName [{linkName}] passed into method was not recognised, is there a typo?");
                    break;
            }
        }

        [When(@"I click the '(.*)' in the collections frame")]
        public void WhenIClickTheInTheCollectionsFrame(string collectionsLink)
        {
            switch (collectionsLink)
            {
                case "Beds & Blankets":
                    _homepage.ToCollectionsBedsBlankets();
                    break;
                case "Bowls & Food":
                    _homepage.ToCollectionsBowlsFood();
                    break;
                case "Grooming":
                    _homepage.ToCollectionsGrooming();
                    break;
                case "Collars & Leads":
                    _homepage.ToCollectionsCollarsLeads();
                    break;
                case "Health Care":
                    _homepage.ToCollectionsHealthCare();
                    break;
                case "Training":
                    _homepage.ToCollectionsTraining();
                    break;
                case "Small Dogs & Puppy":
                    _homepage.ToCollectionsSmallDogsPuppies();
                    break;
                case "Large Dogs":
                    _homepage.ToCollectionsLargeDogs();
                    break;
                case "Toys & Games":
                    _homepage.ToCollectionsToysGames();
                    break;
                case "On the go":
                    _homepage.ToCollectionsOnTheGo();
                    break;
                case "Summer Time":
                    _homepage.ToCollectionsSummerTime();
                    break;
                case "Winter Time":
                    _homepage.ToCollectionsWinterTime();
                    break;
                default:
                    Console.WriteLine(
                        $"collectionsLink [{collectionsLink}] passed into method was not recognised, is there a typo?");
                    break;
            }
        }

        [Then(@"the '(.*)' informational page will load")]
        public void ThenTheInformationalPageWillLoad(string expectedHeading)
        {
            Assert.IsTrue(_genericItems.GenericPageHeading.Displayed);

            var actualHeading = _genericItems.GenericPageHeading.Text;

            Assert.AreEqual(expectedHeading, actualHeading, 
                $"The expected page heading [{expectedHeading}] was not displayed, the actual heading was [{actualHeading}].");
        }

        [Then(@"the '(.*)' products collection page will load")]
        public void ThenTheProductsCollectionPageWillLoad(string expectedHeading)
        {
            Assert.IsTrue(_collections.CollectionsGenericPageHeading.Displayed);

            var actualHeading = _collections.CollectionsGenericPageHeading.Text;
            var actualHeadingManiplulated = actualHeading.Substring(13);

            Assert.AreEqual(expectedHeading, actualHeadingManiplulated, 
                $"The expected page heading [{expectedHeading}] was not displayed, the actual heading was [{actualHeadingManiplulated}].");
        }
    }
}
