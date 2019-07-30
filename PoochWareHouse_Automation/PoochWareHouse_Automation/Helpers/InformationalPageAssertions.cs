using NUnit.Framework;
using PoochWareHouse_Automation.Pages.InformationalPages;

namespace PoochWareHouse_Automation.Helpers
{
    public static class InformationalPageAssertions
    {
        public static void ConfirmInformationalPageHasBeenLoaded(string itemType, string expectedItem)
        {
            Assert.IsTrue(InformationalPagesGenericItems.GenericPageHeading.Displayed,
                TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedItem));

            var actualHeading = InformationalPagesGenericItems.GenericPageHeading.Text;

            Assert.AreEqual(expectedItem, actualHeading,
                TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedItem, actualHeading));
        }

        public static void ConfirmInformationalPageHyperLinksToExternalSitesAreCorrect(string expectedUrl)
        {
            var actualUrl = Driver._webdriver.Url;

            Assert.AreEqual(expectedUrl, actualUrl, TestErrorHelper.ExpectedExternalUrlDoNotMatch(expectedUrl, actualUrl));
        }
    }
}
