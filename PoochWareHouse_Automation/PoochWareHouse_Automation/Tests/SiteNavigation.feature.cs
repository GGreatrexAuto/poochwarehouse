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
namespace PoochWareHouse_Automation.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Site Navigation")]
    public partial class SiteNavigationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SiteNavigation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Site Navigation", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Confirm footer quick links navigate to the correct information page.")]
        [NUnit.Framework.TestCaseAttribute("About Us", "About Us", null)]
        [NUnit.Framework.TestCaseAttribute("FAQ", "FAQ", null)]
        [NUnit.Framework.TestCaseAttribute("Delivery & Shipping", "Delivery & Shipping", null)]
        [NUnit.Framework.TestCaseAttribute("Returns Policy", "Returns Policy", null)]
        [NUnit.Framework.TestCaseAttribute("Privacy Policy", "Privacy Policy", null)]
        [NUnit.Framework.TestCaseAttribute("Terms Of Use", "Terms Of Use", null)]
        [NUnit.Framework.TestCaseAttribute("Contact Us", "Contact Us", null)]
        public virtual void ConfirmFooterQuickLinksNavigateToTheCorrectInformationPage_(string pageLink, string heading, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Confirm footer quick links navigate to the correct information page.", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
 testRunner.Given("I have accessed the PoochwareHouse website homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.When(string.Format("I click the \'{0}\' in the website footer", pageLink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then(string.Format("the \'{0}\' informational page will load", heading), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Confirm collections section links navigate to the correct products page")]
        [NUnit.Framework.TestCaseAttribute("Beds & Blankets", "Beds & Blankets", null)]
        [NUnit.Framework.TestCaseAttribute("Bowls & Food", "Bowls & Food", null)]
        [NUnit.Framework.TestCaseAttribute("Grooming", "Grooming", null)]
        [NUnit.Framework.TestCaseAttribute("Collars & Leads", "Collars & Leads", null)]
        [NUnit.Framework.TestCaseAttribute("Health Care", "Health Care", null)]
        [NUnit.Framework.TestCaseAttribute("Training", "Training", null)]
        [NUnit.Framework.TestCaseAttribute("Small Dogs & Puppy", "Small Dogs & Puppy", null)]
        [NUnit.Framework.TestCaseAttribute("Large Dogs", "Large Dogs", null)]
        [NUnit.Framework.TestCaseAttribute("Toys & Games", "Toys & Games", null)]
        [NUnit.Framework.TestCaseAttribute("On the go", "On The Go", null)]
        [NUnit.Framework.TestCaseAttribute("Summer Time", "Summer Time", null)]
        [NUnit.Framework.TestCaseAttribute("Winter Time", "Winter Time", null)]
        public virtual void ConfirmCollectionsSectionLinksNavigateToTheCorrectProductsPage(string collectionLink, string heading, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Confirm collections section links navigate to the correct products page", null, exampleTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
 testRunner.Given("I have accessed the PoochwareHouse website homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.When(string.Format("I click the \'{0}\' in the collections frame", collectionLink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then(string.Format("the \'{0}\' products collection page will load", heading), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Confirm collections drop down in header frame navigates to the correct products p" +
            "age")]
        [NUnit.Framework.TestCaseAttribute("Beds & Blankets", "Beds & Blankets", null)]
        [NUnit.Framework.TestCaseAttribute("Bowls & Food", "Bowls & Food", null)]
        [NUnit.Framework.TestCaseAttribute("Grooming", "Grooming", null)]
        [NUnit.Framework.TestCaseAttribute("Collars & Leads", "Collars & Leads", null)]
        [NUnit.Framework.TestCaseAttribute("Health Care", "Health Care", null)]
        [NUnit.Framework.TestCaseAttribute("Training", "Training", null)]
        [NUnit.Framework.TestCaseAttribute("Small Dogs & Puppy", "Small Dogs & Puppy", null)]
        [NUnit.Framework.TestCaseAttribute("Large Dogs", "Large Dogs", null)]
        [NUnit.Framework.TestCaseAttribute("Toys & Games", "Toys & Games", null)]
        [NUnit.Framework.TestCaseAttribute("On the go", "On The Go", null)]
        [NUnit.Framework.TestCaseAttribute("Summer Time", "Summer Time", null)]
        [NUnit.Framework.TestCaseAttribute("Winter Time", "Winter Time", null)]
        public virtual void ConfirmCollectionsDropDownInHeaderFrameNavigatesToTheCorrectProductsPage(string collectionsDropDown, string heading, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Confirm collections drop down in header frame navigates to the correct products p" +
                    "age", null, exampleTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 39
 testRunner.Given("I have accessed the PoochwareHouse website homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
  testRunner.And("click the collections drop down option in the page header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When(string.Format("I click the \'{0}\' option on the drop down list", collectionsDropDown), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then(string.Format("the \'{0}\' products collection page will load", heading), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Confirm non-collections links in the header frame navigate to the correcrt produc" +
            "ts page")]
        [NUnit.Framework.TestCaseAttribute("On Sale", "Sale Items", null)]
        [NUnit.Framework.TestCaseAttribute("All Products", "Products", null)]
        public virtual void ConfirmNon_CollectionsLinksInTheHeaderFrameNavigateToTheCorrecrtProductsPage(string headerLink, string heading, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Confirm non-collections links in the header frame navigate to the correcrt produc" +
                    "ts page", null, exampleTags);
#line 60
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 61
 testRunner.Given("I have accessed the PoochwareHouse website homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 62
 testRunner.When(string.Format("I click the \'{0}\' header option", headerLink), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then(string.Format("the \'{0}\' products page wil load", heading), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
