using System;
using TechTalk.SpecFlow;

namespace Carpool
{
    [Binding]
    public class QuickpostSteps
    {
        [Given(@"""(.*)"" enter ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void GivenEnterAndAnd(string p0, string p1, string p2, string p3)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"his ""(.*)"" and ""(.*)""")]
        public void GivenHisAnd(string p0, Decimal p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click on ""(.*)""")]
        public void WhenClickOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"system display ""(.*)"" with ""(.*)"" button")]
        public void ThenSystemDisplayWithButton(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"click on OK button will redirect on ""(.*)""")]
        public void ThenClickOnOKButtonWillRedirectOn(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
