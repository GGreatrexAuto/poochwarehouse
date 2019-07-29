using System.Threading;
using PoochWareHouse_Automation.Pages.PageElements;

namespace PoochWareHouse_Automation.Helpers
{
    public static class CookieOverlayActions
    {
        public static void ClearCookieOverlay()
        {
            CookieOverlay.AcceptCookieButton.Click();

            Thread.Sleep(1250);
        }
    }
}
