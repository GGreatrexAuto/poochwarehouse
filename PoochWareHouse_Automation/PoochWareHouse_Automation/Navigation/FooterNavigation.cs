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
        public FooterNavigation()
        {
        
        }

        public void ToFaq()
        {
            QuickLinksFooter.FAQLink.Click();   
        }

        public void ToAboutUs()
        {
            QuickLinksFooter.AboutUsLink.Click();
        }

        public void ToDeliveryAndShipping()
        {
            QuickLinksFooter.DeliveryAndShippingLink.Click();
        }

        public void ToReturnsPolicy()
        {
            QuickLinksFooter.ReturnsPolicyLink.Click();
        }

        public void ToPrivacyPolicy()
        {
            QuickLinksFooter.PrivacyPolicyLink.Click();
        }

        public void ToTermsOfUse()
        {
            QuickLinksFooter.TermsOfUseLink.Click();
        }

        public void ToContactUs()
        {
            QuickLinksFooter.ContactUsLink.Click();
        }
    }
}
