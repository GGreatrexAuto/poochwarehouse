using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Pages.PageElements;

namespace PoochWareHouse_Automation.Navigation
{
    public class FooterNavigation
    {
        private QuickLinksFooter _footerLinks;

        public FooterNavigation()
        {
            _footerLinks = new QuickLinksFooter();
        }

        public void ToFaq()
        {
            _footerLinks.FAQLink.Click();   
        }

        public void ToAboutUs()
        {
            _footerLinks.AboutUsLink.Click();
        }

        public void ToDeliveryAndShipping()
        {
            _footerLinks.DeliveryAndShippingLink.Click();
        }

        public void ToReturnsPolicy()
        {
            _footerLinks.ReturnsPolicyLink.Click();
        }

        public void ToPrivacyPolicy()
        {
            _footerLinks.PrivacyPolicyLink.Click();
        }

        public void ToTermsOfUse()
        {
            _footerLinks.TermsOfUseLink.Click();
        }

        public void ToContactUs()
        {
            _footerLinks.ContactUsLink.Click();
        }
    }
}
