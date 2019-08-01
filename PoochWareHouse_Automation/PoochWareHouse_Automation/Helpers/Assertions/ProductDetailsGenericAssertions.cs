using NUnit.Framework;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.Helpers.Assertions
{
    public static class ProductDetailsGenericAssertions
    {
        public static void ConfirmProductDetailsPageHasBeenLoaded(string itemType, string expectedHeading)
        {
            Assert.IsTrue(ProductsDetail.ProductName.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedHeading));

            var actualHeading = ProductsDetail.ProductName.Text;

            Assert.AreEqual(expectedHeading, actualHeading,
                TestErrorHelper.ExpectedActualPageHeadingsDoNotMatch(expectedHeading, actualHeading));
        }
    }
}
