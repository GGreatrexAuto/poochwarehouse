using NUnit.Framework;
using PoochWareHouse_Automation.Pages.Collections;

namespace PoochWareHouse_Automation.Helpers.Assertions
{
    public static class ProductsCollectionPagesGenericAssertions
    {
        public static void ConfirmProductCollectionPageHasBeenLoaded(string itemType, string expectedHeading)
        {
            Assert.IsTrue(ProductsPagesGenericItems.ProductsGenericPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));

            var actualHeading = ProductsPagesGenericItems.ProductsGenericPageHeading.Text;

            var actualHeadingManipulated = actualHeading.Substring(13);
            Assert.AreEqual(expectedHeading, actualHeadingManipulated,
                TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedHeading, actualHeadingManipulated));
        }
    }
}
