using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoochWareHouse_Automation.Helpers
{
    public static class BrowserHelper
    {
        public static void SwitchFocusToAnotherTab(int tabNumber)
        {
            var windowHandles = GetWindowHandle();

            Driver._webdriver.SwitchTo().Window(windowHandles[tabNumber]);
        }

        private static ReadOnlyCollection<string> GetWindowHandle()
        {
            return Driver._webdriver.WindowHandles;
        }
    }
}
