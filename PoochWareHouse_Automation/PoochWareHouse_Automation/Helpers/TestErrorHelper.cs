using System.Net;
using PoochWareHouse_Automation.Configuration;

namespace PoochWareHouse_Automation.Helpers
{
    public static class TestErrorHelper
    {
        public static string CaseValueNotRecognised(string input)
        {
            var error = $"Case value [{input}] passed into method was not recognised, is there a typo?";
            return error;
        }

        public static string ExpectedItemNotDisplayed(string itemType,string expectedValue)
        {
            var error = $"The expected page {itemType} [{expectedValue}] was not displayed.";
            return error;
        }

        public static string ExpectedActualPageHeadingsDoNotMatch(string expectedHeading, string actualHeading)
        {
            var error =
                $"The expected page heading [{expectedHeading}] was not displayed, the actual heading was [{actualHeading}].";
            return error;
        }

        public static string ExpectedExternalUrlDoNotMatch(string expectedUrl, string actualUrl)
        {
            var error = $"The expected external url [{expectedUrl}], did not match the [{actualUrl}]";
            return error;
        }

        public static string ExpectedAddressNotDisplayed(string expectedAddressLine)
        {
            var error = $"The expected address line [{expectedAddressLine}], was not found in the displayed address.";
            return error;
        }
    }
}
