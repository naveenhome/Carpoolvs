﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Carpool.Features.RidePosting
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("quickpost")]
    public partial class QuickpostFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "quickpost.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "quickpost", "\tIr order to share my car\r\n\tAs an employee\r\n\tI want to post my ride with others", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Quickpost testing")]
        [NUnit.Framework.TestCaseAttribute("\"Naveen\"", "\"Office\"", "\"Kammanahalli\"", "\"5:30\"", "\"naveenhome@gmail.com\"", "\"9810547500\"", "\"Share\"", "\"Ride shared.\"", "\"Ok\"", "\"Home\"", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\"Naveen\"", "\"Office\"", "\"Kammanahalli\"", "\"5:30\"", "\"naveenhome@gmail.com\"", "\" \"", "\"Share\"", "\"Phone No is required.\"", "\"Ok\"", "\"Quick Post\"", new string[0])]
        public virtual void QuickpostTesting(string empname, string source, string destination, string time, string email, string phone, string button, string message, string actionButton, string page, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Quickpost testing", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given(string.Format("{0} enter {1} and {2} and {3}", empname, source, destination, time), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.And(string.Format("his {0} and {1}", email, phone), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.When(string.Format("click on {0}", button), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
testRunner.Then(string.Format("system display {0} with {1} button", message, actionButton), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
testRunner.And(string.Format("click on OK button will redirect on {0}", page), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
