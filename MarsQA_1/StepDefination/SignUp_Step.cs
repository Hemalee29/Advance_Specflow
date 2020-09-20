using MarsQA_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefination
{
    [Binding]
    public sealed class SignUp_Step
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Navigate to Home Page and Click on the Join Button")]
        public void GivenNavigateToHomePageAndClickOnTheJoinButton()
        {
            //Mars_SignUp _signup = new Mars_SignUp();
            //_signup.ClickOnJoin(driver);
        }

        [When(@"I should be able to fill all the details in registration page")]
        public void WhenIShouldBeAbleToFillAllTheDetailsInRegistrationPage()
        {
            Mars_SignUp _signup = new Mars_SignUp();
            _signup.EnterValidData(driver);
        }

        [Then(@"I should be able to signup succesfully")]
        public void ThenIShouldBeAbleToSignupSuccesfully()
        {
            Mars_SignUp _signup = new Mars_SignUp();
            _signup.ClickMeTORegister(driver);
        }

    }
}
