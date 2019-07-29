﻿namespace PoochWareHouse_Automation.Helpers
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

        public static string ExpectedActualageHeadingsDoNotMatch(string expectedHeading, string actualHeading)
        {
            var error =
                $"The expected page heading [{expectedHeading}] was not displayed, the actual heading was [{actualHeading}].";
            return error;
        }
    }
}
