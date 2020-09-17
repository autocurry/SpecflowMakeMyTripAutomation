using System;
using TechTalk.SpecFlow;

namespace SpecflowMakeMyTripAutomation.Steps
{
    [Binding]
    public class MakemytriploginSteps
    {
        [Given(@"I am a registered makemytrip user")]
        public void GivenIAmARegisteredMakemytripUser()
        {
            Console.WriteLine("inside given");
        }
        
        [When(@"I open the login page")]
        public void WhenIOpenTheLoginPage()
        {
            Console.WriteLine("inside when");
        }
        
        [When(@"enter valid credentials")]
        public void WhenEnterValidCredentials()
        {
            Console.WriteLine("inside and");
        }
        
        [Then(@"i will be able to login successfully")]
        public void ThenIWillBeAbleToLoginSuccessfully()
        {
            Console.WriteLine("inside then");
        }
    }
}
