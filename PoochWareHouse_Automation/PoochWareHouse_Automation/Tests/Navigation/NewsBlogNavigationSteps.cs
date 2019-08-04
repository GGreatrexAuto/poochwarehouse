using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Helpers.Assertions;
using PoochWareHouse_Automation.Navigation;
using PoochWareHouse_Automation.Navigation.News;
using PoochWareHouse_Automation.Pages.News;
using TechTalk.SpecFlow;

namespace PoochWareHouse_Automation.Tests.Navigation
{
    [Binding]
    [Scope(Feature = "News and Blog Navigation")]
    public sealed class NewsBlogNavigationSteps
    {
        private readonly Site _site;

        public NewsBlogNavigationSteps()
        {
            _site = new Site();
        }

        [Given(@"I access the '(.*)' article page")]
        [Given(@"the news '(.*)' is loaded")]
        public void GivenIAccessTheArticlePage(string pageName)
        {
            string url = null;

            switch (pageName)
            {
                case "News & Blog":
                    url = Urls.NewsUrl;
                    break;
                case "Summer Is Here":
                    url = Urls.NewsArticleSummerUrl;
                    break;
                case "Pooch Car Safety":
                    url = Urls.NewsArticlePoochTravel;
                    break;
                case "Why Use a Harness?":
                    url = Urls.NewsArticleWhyHarness;
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(pageName));
                    break;
            }
            
            _site.InitialiseChromeDriverNavigate(url);
        }

        [Given(@"dismiss the cookies overlay")]
        public void GivenDismissTheCookiesOverlay()
        {
            CookieOverlayActions.ClearCookieOverlay();
        }

        [When(@"I select the '(.*)' article via the '(.*)' link")]
        public void WhenISelectTheArticleViaTheLink(string article, string linkType)
        {
            if (article == "Summer Is Here")
            {
                if (linkType == "image")
                {
                    NewsBlogNavigation.SummerIsHereArticleImage();
                }
                else if (linkType == "button")
                {
                    NewsBlogNavigation.SummerIsHereArticleButton();
                }
            }
            else if(article == "Pooch Car Safety")
            {
                if (linkType == "image")
                {
                    NewsBlogNavigation.PoochCarSafetyArticleImage();
                }
                else if (linkType == "button")
                {
                    NewsBlogNavigation.PoochCarSafetyArticleButton();
                }
            }
            else if (article == "Why Use a Harness?")
            {
                if (linkType == "image")
                {
                    NewsBlogNavigation.WhyHarnessArticleImage();
                }
                else if (linkType == "button")
                {
                    NewsBlogNavigation.WhyHarnessArticleButton();
                }
            }
        }

        [When(@"I select the '(.*)'")]
        public void WhenISelectThe(string hyperLink)
        {
            switch (hyperLink)
            {
                case "Back To News Button":
                    NewsArticleGenericNavigation.BackToNewsButton();
                    break;
                case "Summer Collection Image":
                    NewsArticleSummerHereNavigation.ClickSummerCollectionImage();
                    break;
                case "Travel Flask":
                    NewsArticleSummerHereNavigation.ClickTravelFlaskLink();
                    break;
                case "Summer Cooling Vest":
                    NewsArticleSummerHereNavigation.ClickSummerCoolingVestLink();
                    break;
                case "Summer Cooling Scarf":
                    NewsArticleSummerHereNavigation.ClickSummerCoolingScarfLink();
                    break;
                case "Thick Fur Grooming Comb":
                    NewsArticleSummerHereNavigation.ClickThickFurGroomingCombLink();
                    break;
                case "Harnesses":
                    NewsArticleWhyHarnessesNavigation.SelectHarnessesLink();
                    break;
                case "Positive Reinforcement":
                    NewsArticleWhyHarnessesNavigation.SelectPositiveReinforcementLink();
                    break;
                case "Harnesses Two":
                    NewsArticleWhyHarnessesNavigation.SelectHarnessesLinkTwo();
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(hyperLink));
                    break;
            }
        }

        [Then(@"correct article '(.*)' will be displayed")]
        public void ThenCorrectArticleWillBeDisplayed(string expectedArticle)
        {
            var itemType = "heading";

            Assert.IsTrue(NewsArticlesGenericItems.ArticlePageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedArticle));

            var actualPageHeading = NewsArticlesGenericItems.ArticlePageHeading.Text;

            Assert.AreEqual(expectedArticle, actualPageHeading, TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedArticle, actualPageHeading));
        }

        [Then(@"the '(.*)' will be displayed")]
        public void ThenTheWillBeDisplayed(string expectedPage)
        {
            string itemType = "page";

            if (expectedPage == "News")
            {
                var actualHeading = News.NewsPageHeading.Text;
                Assert.AreEqual(expectedPage, actualHeading, TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedPage, actualHeading));
            }

            if (expectedPage == "Training")
            {
                BrowserHelper.SwitchFocusToAnotherTab(1);
                ProductsCollectionPagesGenericAssertions.ConfirmProductCollectionPageHasBeenLoaded(itemType, expectedPage);
            }

            if (expectedPage == "Summer Time")
            {
                BrowserHelper.SwitchFocusToAnotherTab(1);
                ProductsCollectionPagesGenericAssertions.ConfirmProductCollectionPageHasBeenLoaded(itemType, expectedPage);
            }

            if (expectedPage == "Water & Food Flask with Collapsible Travel Bowl" || expectedPage == "Summer Cooling Vest" || expectedPage == "Summer Cooling Scarf" || expectedPage == "Thick Fur Grooming Comb" || expectedPage == "Selection of Adjustable Non-Pull Dog Harness")
            {
                BrowserHelper.SwitchFocusToAnotherTab(1);
                ProductDetailsGenericAssertions.ConfirmProductDetailsPageHasBeenLoaded(itemType, expectedPage);
            }
        }
    }
}
