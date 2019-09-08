using NUnit.Framework;
using PoochWareHouse_Automation.Configuration;

namespace PoochWareHouse_Automation.Helpers.Assertions
{
    public class UrlHelper
    {
        public string SetUrl(string webPage)
        {
            string url;

            switch (webPage)
            {
                case "sale-items":
                    url = Urls.SaleItemsUrl;
                    break;
                case "all-products":
                    url = Urls.AllProductsUrlPgOne;
                    break;
                case "beds-blankets":
                    url = Urls.BedsBlanketsUrl;
                    break;
                case "bowls-food":
                    url = Urls.BowlsFoodUrl;
                    break;
                case "health-grooming":
                    url = Urls.HealthGroomingUrl;
                    break;
                case "collars-leads":
                    url = Urls.CollarsLeadsUrl;
                    break;
                case "health-care":
                    url = Urls.HealthCareUrl;
                    break;
                case "training":
                    url = Urls.TrainingUrl;
                    break;
                case "small-dogs":
                    url = Urls.SmallDogsUrl;
                    break;
                case "large-dogs":
                    url = Urls.LargeDogsUrl;
                    break;
                case "toys-games":
                    url = Urls.ToysGamesUrl;
                    break;
                case "on-the-go":
                    url = Urls.OnTheGoUrl;
                    break;
                case "summer-collection":
                    url = Urls.SummerCollectionUrl;
                    break;
                case "winter-collection":
                    url = Urls.WinterCollectionUrl;
                    break;
                case "login":
                    url = Urls.LoginUrl;
                    break;
                case "your-cart":
                    url = Urls.YourCartUrl;
                    break;
                case "about-us":
                    url = Urls.AboutUsUrl;
                    break;
                case "faq":
                    url = Urls.FaqUrl;
                    break;
                case "delivery-shipping":
                    url = Urls.DeliveryShippingUrl;
                    break;
                case "returns-policy":
                    url = Urls.ReturnsPolicyUrl;
                    break;
                case "privacy-policy":
                    url = Urls.PrivacyPolicyUrl;
                    break;
                case "terms-of-use":
                    url = Urls.TermsOfUseUrl;
                    break;
                case "contact-us":
                    url = Urls.ContactUsUrl;
                    break;
                case "News & Blog":
                    url = Urls.NewsUrl;
                    break;
                case "Summer Is Here":
                    url = Urls.NewsArticleSummerUrl;
                    break;
                case "Pooch Car Safety":
                    url = Urls.NewsArticlePoochTravel;
                    break;
                case "Why Use a Harness?":
                    url = Urls.NewsArticleWhyHarness;
                    break;
                case "1":
                    url = Urls.AllProductsUrlPgOne;
                    break;
                case "2":
                    url = Urls.AllProductsUrlPgTwo;
                    break;
                case "3":
                    url = Urls.AllProductsUrlPgThree;
                    break;
                case "register":
                    url = Urls.CreateAccount;
                    break;
                default:
                    Assert.Inconclusive(TestErrorHelper.CaseValueNotRecognised(webPage));
                    url = null;
                    break;
            }

            return url;

        }
    }
}
