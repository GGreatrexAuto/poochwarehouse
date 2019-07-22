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
    }
}
