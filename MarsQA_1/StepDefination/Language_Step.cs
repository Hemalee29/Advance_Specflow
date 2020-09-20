using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefination
{
    [Binding]

   
    public sealed class Language_Step

    {
        IWebDriver driver;
        [Given(@"click on the Language tab")]
        public void GivenClickOnTheLanguageTab()
        {
            Language_Page _language = new Language_Page();
            _language.tab(driver);
        }

        [When(@"I click on the add new language")]
        public void WhenIClickOnTheAddNewLanguage()
        {
            Language_Page _language = new Language_Page();
            _language.Addnew(driver);
        }

        [Then(@"I verify that language is successfully add or not")]
        public void ThenIVerifyThatLanguageIsSuccessfullyAddOrNot()
        {
            Language_Page _language = new Language_Page();
            _language.Language_Validation(driver);
        }
        [BeforeScenario]
        public void beforerun()
        {
            Console.WriteLine("before scenerio");
        }

    }
}
