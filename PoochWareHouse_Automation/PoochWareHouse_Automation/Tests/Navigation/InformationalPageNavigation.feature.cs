// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PoochWareHouse_Automation.Tests.Navigation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Informational Page Navigation")]
    public partial class InformationalPageNavigationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "InformationalPageNavigation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Informational Page Navigation", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Selecting hyperlinks within the informational page will navigate users to the cor" +
            "rect location")]
        [NUnit.Framework.TestCaseAttribute("faq", "return policy link", "Returns Policy", null)]
        [NUnit.Framework.TestCaseAttribute("privacy policy", "homepage link one", "Home Page", null)]
        [NUnit.Framework.TestCaseAttribute("privacy policy", "homepage link two", "Home Page", null)]
        [NUnit.Framework.TestCaseAttribute("privacy policy", "all about cookies link", "All About Cookies", null)]
        [NUnit.Framework.TestCaseAttribute("privacy policy", "shopify link", "Shopify Privacy", null)]
        [NUnit.Framework.TestCaseAttribute("privacy policy", "google privacy link", "Google Privacy", null)]
        [NUnit.Framework.TestCaseAttribute("privacy policy", "google opt out link", "Google Opt Out", null)]
        [NUnit.Framework.TestCaseAttribute("privacy policy", "facebook advertising link", "Facebook Data Policy", null)]
        [NUnit.Framework.TestCaseAttribute("returns policy", "contact us link", "Contact Us", null)]
        public virtual void SelectingHyperlinksWithinTheInformationalPageWillNavigateUsersToTheCorrectLocation(string informationalPage, string hyperLink, string expectedPage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Selecting hyperlinks within the informational page will navigate users to the cor" +
                    "rect location", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given(string.Format("I access the \'{0}\' page", informationalPage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("I clear the cookie notice", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And(string.Format("the \'{0}\' link is present", hyperLink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
  testRunner.When(string.Format("I click the \'{0}\'", hyperLink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then(string.Format("the \'{0}\' page will be loaded", expectedPage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
