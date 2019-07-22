using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoochWareHouse_Automation.Helpers
{
    public static class TestErrorHelper
    {
        public static string CaseValueNotRecognised(string input)
        {
            var error = $"Case value [{input}] passed into method was not recognised, is there a typo?";
            return error;
        }

        public static string ExpectedPageHeadingNotDisplayed()
        {
            var error = "The expected page heading was not displayed.";
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
