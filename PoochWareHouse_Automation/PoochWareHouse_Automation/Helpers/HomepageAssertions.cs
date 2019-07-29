using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PoochWareHouse_Automation.Pages;

namespace PoochWareHouse_Automation.Helpers
{
    public static class HomepageAssertions
    {
        public static void ConfirmHomePageHasBeenLoaded()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(HomePage.HomePageImageFrame.Displayed,
                    "The homepage (main image frame) was not displayed.");
                Assert.IsTrue(HomePage.TestimonialHeading.Displayed,
                    "The homepage testimonial subheading was not displayed");
                Assert.IsTrue(HomePage.CollectionsSubHeading.Displayed,
                    "The homepage collections subheading was not displayed");
            });
        }

    }
}
