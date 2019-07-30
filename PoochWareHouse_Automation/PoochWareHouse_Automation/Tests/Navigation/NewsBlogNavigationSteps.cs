using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;
using PoochWareHouse_Automation.Helpers;
using PoochWareHouse_Automation.Navigation;
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

        [Given(@"I access the news and blog page")]
        public void GivenIAccessTheNewsAndBlogPage()
        {
            _site.InitialiseChromeDriver(Urls.NewsUrl);
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
        }

        [Then(@"correct article '(.*)' will be displayed")]
        public void ThenCorrectArticleWillBeDisplayed(string expectedArticle)
        {
            var itemType = "heading";

            Assert.IsTrue(NewsArticlesGenericItems.ArticlePageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedArticle));

            var actualPageHeading = NewsArticlesGenericItems.ArticlePageHeading.Text;

            Assert.AreEqual(expectedArticle, actualPageHeading, TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedArticle, actualPageHeading));
        }
    }
}
