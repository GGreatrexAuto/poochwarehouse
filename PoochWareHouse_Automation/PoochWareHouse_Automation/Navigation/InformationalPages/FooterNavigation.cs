using PoochWareHouse_Automation.Pages.PageElements;

namespace PoochWareHouse_Automation.Navigation.InformationalPages
{
    public static class FooterNavigation
    {
        public static void ToFaq()
        {
            QuickLinksFooter.FAQLink.Click();   
        }

        public static void ToAboutUs()
        {
            QuickLinksFooter.AboutUsLink.Click();
        }

        public static void ToDeliveryAndShipping()
        {
            QuickLinksFooter.DeliveryAndShippingLink.Click();
        }

        public static void ToReturnsPolicy()
        {
            QuickLinksFooter.ReturnsPolicyLink.Click();
        }

        public static void ToPrivacyPolicy()
        {
            QuickLinksFooter.PrivacyPolicyLink.Click();
        }

        public static void ToTermsOfUse()
        {
            QuickLinksFooter.TermsOfUseLink.Click();
        }

        public static void ToContactUs()
        {
            QuickLinksFooter.ContactUsLink.Click();
        }
    }
}
