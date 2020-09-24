using Docker.DotNet.Models;
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
    public sealed class Login
    {
                [When(@"Click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            Mars_Login _Login = new Mars_Login();
            _Login.ClickIn();
        }

        [Then(@"I should be able to login successfully with valid credenatial")]
        public void ThenIShouldBeAbleToLoginSuccessfullyWithValidCredenatial()
        {
            Mars_Login _Login = new Mars_Login();
            _Login.SignIn();
        }



















        
        //[When(@"Click on Login button")]
        //public void WhenClickOnLoginButton()
        //{
        //    Mars_Login _login = new Mars_Login();
        //    _login.ClickIn(driver);
        //}

        //[Then(@"I should be able to login succesfully with valid creadential")]
        //public void ThenIShouldBeAbleToLoginSuccesfullyWithValidCreadential()
        //{
        //    Mars_Login _login = new Mars_Login();
        //    _login.SignIn(driver);
        //}


    }
}
