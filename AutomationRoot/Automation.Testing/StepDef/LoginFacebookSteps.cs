using Automation.Testing.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Automation.Testing.StepDef
{
    [Binding]
    public class LoginFacebookSteps
    {
        private ILogin _login;
        private IWebDriver _driver;


        public LoginFacebookSteps(IWebDriver driver,ILogin login) {

            _driver = driver;
            _login =login;
        }
        [Given(@"I navigate to Facebook page")]
        public void GivenINavigateToFacebookPage()
        {
           

            // select or navigate to a url/website
            _driver.Navigate().GoToUrl("https://www.facebook.com/");
        }
        
        [When(@"I login with ""(.*)"" and ""(.*)""")]
        public void WhenILoginWithAnd(string userName, string password)
        {
            _login.Login(userName, password);
        }
        
        [Then(@"I can see my profile")]
        public void ThenICanSeeMyProfile()
        {
            

        }
    }
}
