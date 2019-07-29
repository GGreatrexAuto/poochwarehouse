using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PoochWareHouse_Automation.Pages.InformationalPages;

namespace PoochWareHouse_Automation.Helpers
{
    public static class InformationalPageAssertions
    {
        public static void ConfirmInformationalPageHasBeenLoaded(string itemType, string expectedItem)
        {
            Assert.IsTrue(InformationalPagesGenericItems.GenericPageHeading.Displayed, TestErrorHelper.ExpectedItemNotDisplayed(itemType, expectedItem));

            var actualHeading = InformationalPagesGenericItems.GenericPageHeading.Text;

            Assert.AreEqual(expectedItem, actualHeading,
                TestErrorHelper.ExpectedActualageHeadingsDoNotMatch(expectedItem, actualHeading));
        }


    }
}
