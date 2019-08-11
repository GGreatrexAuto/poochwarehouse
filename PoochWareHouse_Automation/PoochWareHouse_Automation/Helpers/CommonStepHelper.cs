using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoochWareHouse_Automation.Helpers.Assertions;

namespace PoochWareHouse_Automation.Helpers
{
    public class CommonStepHelper
    {
        private readonly Site _site;
        private readonly UrlHelper _urlHelper;
        private readonly PreReleaseLoginHelper _preReleaseLoginHelper;

        public CommonStepHelper()
        {
            _site = new Site();
            _urlHelper = new UrlHelper();
            _preReleaseLoginHelper = new PreReleaseLoginHelper();
        }

        public void AccessWebsite(string startPage)
        {
            _site.InitialiseChromeDriver();

            var url = _urlHelper.SetUrl(startPage);

            _site.NavigateAndMaximise(url);

            var currentUrl = _site.GetWebPageUrl();

            var preReleaseMode = _preReleaseLoginHelper.IsWebsiteInPreReleaseMode(currentUrl);

            _preReleaseLoginHelper.ByPassPreReleaseAndNavigateToPage(preReleaseMode, url);
        }
    }
}
