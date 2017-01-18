using System;
using TechTalk.SpecFlow;
using Carpoolmodels;
using NUnit.Framework;
using CarpoolService;

namespace Carpool
{
    [Binding]
    public class QuickpostSteps
    {
        Ride ride;
        
        string actionButton, popupButton, message;
        [Given(@"""(.*)"" enter ""(.*)"" and ""(.*)"" and ""(.*)""")]
        public void GivenEnterAndAnd(string empName, string source, string destination, string time)
        {
            ride = new Ride();
            ride.Source = source;
            ride.Destination = destination;
            ride.Ride_Date = DateTime.Now;
            ride.Ride_Time = DateTime.Parse(time);
            ride.EmpName = empName;

        }
        
        [Given(@"his ""(.*)"" and ""(.*)""")]
        public void GivenHisAnd(string email, string phone)
        {
            ride.Email = email;
            ride.Phone = phone;
        }
        
        [When(@"click on ""(.*)""")]
        public void WhenClickOn(string p0)
        {
            //ScenarioContext.Current.Pending();
            actionButton = p0;
        }
        
        [Then(@"system display ""(.*)"" with ""(.*)"" button")]
        public void ThenSystemDisplayWithButton(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
            popupButton = p1;
            message = p0;
            RideService rideService = new RideService();
            Assert.NotNull(rideService.SaveRide(ride));

        }
        
        [Then(@"click on OK button will redirect on ""(.*)""")]
        public void ThenClickOnOKButtonWillRedirectOn(string p0)
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
