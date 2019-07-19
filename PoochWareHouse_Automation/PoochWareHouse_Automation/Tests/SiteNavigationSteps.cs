﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PoochWareHouse_Automation.Navigation;
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

        public SiteNavigationSteps()
        {
            _site = new Site();
            _footerNavigation = new FooterNavigation();
            _genericItems = new InformationalPagesGenericItems();
        }

        [Given(@"I have accessed the PoochwareHouse website")]
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

        [Then(@"the '(.*)' informational page will load")]
        public void ThenTheInformationalPageWillLoad(string expectedHeading)
        {
            Assert.IsTrue(_genericItems.GenericPageHeading.Displayed);

            var actualHeading = _genericItems.GenericPageHeading.Text;

            Assert.AreEqual(expectedHeading, actualHeading, 
                $"The expected page heading [{expectedHeading}] was not displayed, the actua; heading was [{actualHeading}].");
        }


    }
}